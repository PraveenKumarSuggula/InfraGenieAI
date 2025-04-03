# InfraGenie AI – Your AI DevOps Assistant 🤖🚀

## 👨‍💻 About Me

Hey there! I’m Praveen – a passionate Full Stack .NET Developer and Azure enthusiast.  
I love building cloud-native, scalable apps and empowering developers with AI.  
LinkedIn: https://www.linkedin.com/in/praveensuggula

Portfolio: https://praveensuggula.com

---

## 📘 Project Description

**InfraGenie AI** is a full-stack, AI-powered DevOps assistant that helps you generate infrastructure code from natural language prompts. Whether you're deploying a .NET app to Azure or provisioning Kubernetes with Helm and Terraform — InfraGenie AI does it all using OpenAI and GenAI-powered services.

---

## 📌 Table of Contents

1. [Problem Statement](#problem-statement)  
2. [Technologies Used](#technologies-used)  
3. [Feature Requirements](#feature-requirements)  
4. [Installation](#installation)  
5. [Usage](#usage)  
6. [API Overview](#api-overview)  
7. [Microservice Architecture](#microservice-architecture)  
8. [Deployment](#deployment)  
9. [Contributing](#contributing)  
10. [Contact](#contact)

---

## ❗ Problem Statement

Infrastructure automation is repetitive and time-consuming. Developers often waste hours configuring YAML files, Dockerfiles, IAM roles, and Terraform templates. InfraGenie AI solves this by turning your prompt into production-ready DevOps code — in seconds.

---

## ⚙️ Technologies Used

- **Frontend**: Angular 17, Angular Material, ngx-markdown, ngx-charts  
- **Backend**: .NET 8 Web API, C#, Serilog, Swagger, Azure SDK  
- **GenAI**: OpenAI GPT-4 / Azure OpenAI, Prompt Templates  
- **Cloud**: Azure App Service, Key Vault, Blob Storage, Cosmos DB  
- **Security**: JWT, Azure AD B2C, Azure Key Vault  
- **DevOps**: Docker, Docker Compose, GitHub Actions, Terraform

---

## ✨ Feature Requirements

### Functional Features
- ✅ CI/CD YAML Generator
- ✅ Dockerfile Generator
- ✅ Helm Chart Generator
- ✅ Terraform Generator
- ✅ IAM Role Generator
- ✅ Log Explainer
- ✅ AI Chat Interface
- ✅ Project Save & Export
- ✅ Auth + Secure Vault Integration
- ✅ Dashboard + Analytics

### Non-Functional
- ⏱️ High Performance
- 🔐 Secure Key Management
- ⚙️ Scalable Microservices
- 📊 Usable Interface
- 🧩 Modular Architecture

---

## 🛠 Installation

1. **Clone the repository**
```bash
git clone https://github.com/PraveenKumarSuggula/InfraGenieAI.git
cd InfraGenieAI
```

2. **Install backend dependencies**
```bash
cd src/CicdGeneratorService
dotnet restore
```

3. **Install frontend**
```bash
cd frontend/InfraGenieAI.Frontend
npm install
```

---

## 🚀 Usage

### Run Backend
```bash
dotnet run --project src/CicdGeneratorService
```

### Run Frontend
```bash
cd frontend/InfraGenieAI.Frontend
ng serve --open
```

- Frontend: `http://localhost:4200`  
- Swagger: `https://localhost:<port>/swagger`

---

## 🔌 API Overview

- `POST /api/cicd/generate` → Generate CI/CD YAML
- `POST /api/dockerfile/generate` → Generate Dockerfile
- `POST /api/terraform/generate` → Generate Terraform
- `POST /api/iam/generate` → Suggest IAM roles
- `POST /api/logs/explain` → Explain CI/CD logs

---

## 🧱 Microservice Architecture

```
InfraGenieAI/
├── src/
│   ├── CicdGeneratorService/
│   ├── DockerfileGeneratorService/
│   ├── HelmChartGeneratorService/
│   ├── TerraformGeneratorService/
│   └── IamRoleSuggesterService/
├── shared/InfraGenieAI.Shared/
├── apim/
├── k8s/
├── frontend/InfraGenieAI.Frontend/
├── docker-compose.yml
└── InfraGenieAI.sln
```

---

## ☁️ Deployment

- CI/CD: GitHub Actions
- Containers: Docker & Compose
- Hosting: Azure App Service or Azure Kubernetes Service
- Infra: Terraform
- Vault: Azure Key Vault

---

## 🤝 Contributing

1. Fork the project  
2. Create a new branch  
3. Make your changes  
4. Submit a pull request 🚀

---

## ✉️ Contact

**Praveen Kumar Suggula**  
🌐 [Portfolio](https://praveensuggula.com)  
📧 [praveenkumar.suggula0@gmail.com](mailto:praveenkumar.suggula0@gmail.com)  
🔗 [GitHub](https://github.com/PraveenKumarSuggula) | [LinkedIn](https://www.linkedin.com/in/praveensuggula)
