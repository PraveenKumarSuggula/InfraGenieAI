output "cosmosdb_uri" {
  value = azurerm_cosmosdb_account.cicd_cosmos.endpoint
}

output "keyvault_uri" {
  value = azurerm_key_vault.cicd_kv.vault_uri
}
