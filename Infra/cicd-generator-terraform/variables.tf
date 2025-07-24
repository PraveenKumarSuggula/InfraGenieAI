variable "resource_group_name" {
  default = "cicd-generator-rg"
}

variable "location" {
  default = "West US 3"
}

variable "cosmosdb_account_name" {
  default = "cicdgeneratorcosmos"
}

variable "cosmosdb_database_name" {
  default = "PromptHistoryDB"
}

variable "keyvault_name" {
  default = "cicdgeneratorkv"
}
