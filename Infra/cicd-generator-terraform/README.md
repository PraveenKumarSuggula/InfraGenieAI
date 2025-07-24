📁 Project: cicd-generator/

This Terraform project provisions Azure Cosmos DB and Azure Key Vault for the InfraGenie AI CICD Generator microservice.

📦 Files Included
- main.tf – Core infrastructure setup for:
  • Azure Resource Group
  • Azure Cosmos DB (Serverless mode)
  • Azure Key Vault
- variables.tf – Input variables used in the infrastructure
- terraform.tfvars – Optional file to define actual values for variables (can also override via CLI)
- outputs.tf – Define useful output values (optional)
- README.txt – This help file

🛠️ Prerequisites
- Terraform v1.2+ (https://developer.hashicorp.com/terraform/downloads)
- Azure CLI authenticated (az login)
- An active Azure subscription

🚀 How to Use
cd cicd-generator
terraform init
terraform plan    # Optional - Preview changes before applying 
terraform apply

🧩 Variables (from variables.tf)

| Variable Name            | Description                             | Default Value              |
|--------------------------|-----------------------------------------|----------------------------|
| resource_group_name      | Name of the Azure resource group         | cicd-generator-rg          |
| location                 | Azure region to deploy resources         | West US 3                    |
| cosmosdb_account_name    | Name for Cosmos DB account               | cicdgeneratorcosmos        |
| cosmosdb_database_name   | Name for Cosmos DB SQL database          | PromptHistoryDB            |
| keyvault_name            | Name for Azure Key Vault                 | cicdgeneratorvault         |