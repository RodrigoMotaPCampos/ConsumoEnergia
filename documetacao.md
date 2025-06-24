# ⚡ EcoConta - Sistema de Controle de Consumo de Energia Elétrica

## 📖 Descrição

O **EcoConta** é um sistema desenvolvido em **C# com Windows Forms** que permite o gerenciamento e controle do consumo de energia elétrica para clientes residenciais e comerciais.

Ele possibilita o cadastro de clientes (pessoas físicas e jurídicas), o registro de contas de energia e a consulta de informações detalhadas sobre consumo e valores a serem pagos, auxiliando na gestão financeira e energética dos usuários.

---

## 🚀 Funcionalidades

### 🧍 Cadastro de Clientes
- Cadastro de pessoas físicas (CPF) e jurídicas (CNPJ)
- Validação:
  - CPF com exatamente **11 dígitos**
  - CNPJ com exatamente **14 dígitos**
  - Apenas números permitidos
  - Verificação de duplicidade
- Armazenamento em `clientes.txt`

### 💡 Registro de Contas de Energia
- Contas **residenciais** e **comerciais**
- Registro de leitura anterior e atual
- Validação de leitura atual ≥ leitura anterior
- Cálculo automático do consumo em kWh
- Armazenamento em `contas.txt`

### 💰 Cálculo de Valores
- **Residencial:** R$ 0,40/kWh + R$ 9,25 (iluminação pública) + **30% de imposto**
- **Comercial:** R$ 0,35/kWh + R$ 9,25 (iluminação pública) + **18% de imposto**

### 🔍 Consultas
- Busca por CPF/CNPJ
- Visualização do histórico de contas
- Detalhes exibidos:
  - Consumo em kWh
  - Valor sem impostos
  - Valor total com impostos

---

## 🏗️ Arquitetura do Sistema

### 📘 Diagrama de Classes

+-------------------+       +-------------------+       +-------------------+
|      Cliente      |       |   PessoaFisica    |       |  PessoaJuridica   |
+-------------------+       +-------------------+       +-------------------+
| - Nome: string    |<------|                   |       |                   |
| - Documento: string|      +-------------------+       +-------------------+
| - Contas: List    |       | + TipoCliente()   |       | + TipoCliente()   |
+-------------------+       +-------------------+       +-------------------+
| + TipoCliente()   |
+-------------------+
         ^
         |
         |
         v
+-------------------+       +-------------------+
|   ContaEnergia    |       | ClienteConverter  |
+-------------------+       +-------------------+
| - Tipo: enum      |       | + Read()          |
| - LeituraAnterior |       | + Write()         |
| - LeituraAtual    |       +-------------------+
+-------------------+
| + CalcularConsumo()|
| + CalcularValorSemImposto()|
| + CalcularValorTotal()|
+-------------------+


---

## 📦 Descrição das Classes

### 🔹 Cliente (Abstrata)
- Propriedades:
  - `Nome: string`
  - `Documento: string` (CPF/CNPJ)
  - `Contas: List<ContaEnergia>`
- Método:
  - `TipoCliente(): string` (abstrato)

### 🔹 PessoaFisica
- Herda de `Cliente`
- Documento com **11 dígitos**
- `TipoCliente()` retorna `"Pessoa Física"`

### 🔹 PessoaJuridica
- Herda de `Cliente`
- Documento com **14 dígitos**
- `TipoCliente()` retorna `"Pessoa Jurídica"`

### 🔹 ContaEnergia
- Propriedades:
  - `Tipo: TipoContaEnum` (Residencial ou Comercial)
  - `LeituraAnterior: double`
  - `LeituraAtual: double`
- Métodos:
  - `CalcularConsumo()`
  - `CalcularValorSemImposto()`
  - `CalcularValorTotal()`

### 🔹 ClienteConverter
- Serialização e desserialização JSON
- Métodos:
  - `Read(): Cliente`
  - `Write(): void`

---

## 🖥 Interface do Usuário

### 📂 Form1 (Principal)
- Menu principal
- Métodos:
  - `CarregarDados()`
  - `SalvarDados()`

### ➕ Form2 (Cadastro de Cliente)
- Cadastro de clientes
- Validação de documentos
- Armazena em `clientes.txt`

### 💾 Form3 (Cadastro de Contas)
- Registro de contas de energia
- Validação de leituras
- Armazena em `contas.txt`

### 🔎 Form4 (Consulta)
- Busca por documento
- Exibe dados detalhados de consumo e valores

---

## 🔄 Fluxo de Funcionamento

1. **Inicialização**
   - Executa `Program.cs`
   - Carrega `Form1` e os dados existentes

2. **Cadastro de Cliente**
   - Preenchimento de nome, documento e tipo
   - Validação e armazenamento

3. **Cadastro de Conta**
   - Verificação de cliente existente
   - Registro de leituras e tipo de conta

4. **Consulta**
   - Busca e exibição das informações completas

---

## 🗃️ Armazenamento de Dados

- `clientes.txt`  
  Formato: `Tipo; Nome; Documento`  
  Exemplo: `Pessoa Física; José; 12345678910`

- `contas.txt`  
  Formato: `Documento; TipoConta; LeituraAnterior; LeituraAtual`  
  Exemplo: `12345678900; Residencial; 1234; 1234`

---

## 📋 Requisitos do Sistema

- .NET **8.0** ou superior  
- Windows **7** ou superior  
- **4GB RAM** (recomendado)  
- **100MB** de espaço em disco  

---

## ▶️ Instalação e Execução

### ⚙️ Pré-requisitos
- Instale o [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download)

### 💻 Passos para Execução

```bash
git clone https://github.com/seu-usuario/ConsumoEnergia.git
cd ConsumoEnergia/EcoConta

# Compilar
dotnet build

# Executar
dotnet run