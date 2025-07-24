terraform {
  required_version = ">= 1.2.0"

  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 3.0"
    }
  }
}

provider "azurerm" {
  features {}
}

data "azurerm_client_config" "current" {}

resource "azurerm_resource_group" "cicd_rg" {
  name     = var.resource_group_name
  location = var.location
}

resource "azurerm_cosmosdb_account" "cicd_cosmos" {
  name                = var.cosmosdb_account_name
  location            = azurerm_resource_group.cicd_rg.location
  resource_group_name = azurerm_resource_group.cicd_rg.name
  offer_type          = "Standard"
  kind                = "GlobalDocumentDB"

  consistency_policy {
    consistency_level = "Session"
  }

  capabilities {
    name = "EnableServerless" # Cheaper, usage-based billing
  }

  geo_location {
    location          = azurerm_resource_group.cicd_rg.location
    failover_priority = 0
  }
}

resource "azurerm_cosmosdb_sql_database" "cicd_db" {
  name                = var.cosmosdb_database_name
  resource_group_name = azurerm_resource_group.cicd_rg.name
  account_name        = azurerm_cosmosdb_account.cicd_cosmos.name
}

resource "azurerm_key_vault" "cicd_kv" {
  name                        = var.keyvault_name
  location                    = azurerm_resource_group.cicd_rg.location
  resource_group_name         = azurerm_resource_group.cicd_rg.name
  tenant_id                   = data.azurerm_client_config.current.tenant_id
  sku_name                    = "standard"
  # soft_delete_enabled         = true
  # purge_protection_enabled    = false
}
