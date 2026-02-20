# 🟢Desafio Final - Gerenciador de Equipamentos
 Programa para listar, alterar, manipular, deletar equipamentos de mineração.
 
## Estrutura 🏗️
### Controllers: 🕹️
* EquipamentosController.cs
### Data: 💾
* AppDbContext.cs
### Dtos: 📋
* CreateEquipamentosDto.cs
* EquipamentosResponseDto.cs
* UpdateEquipamentosDto.cs
### Models: 🧊
* Equipamentos.cs
### Services: 🔧
* EquipService.cs

## Detalhes: 📄
Manter atenção nesse trecho do código em Program.cs:
```
app.UseSwagger();
app.UseSwaggerUI();
```
Sem esse trecho, o código **não** irá abrir no navegador.

## 🚀 Tecnologias Utilizadas

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- Docker
- Swagger

## 🗄️ Banco de Dados

O projeto utiliza PostgreSQL.

A tabela `Equipamentos` possui a seguinte estrutura:

- id (SERIAL - PK)
- codigo (VARCHAR(50) - UNIQUE)
- tipo (VARCHAR(50))
- modelo (VARCHAR(50))
- horimetro (NUMERIC(10,2))
- statusoperacional (VARCHAR(50))
- dataaquisicao (DATE)
- localizacaoatual (VARCHAR(200))

## 🔵Como Rodar **Com** o Docker? 🚢🤷
_Usar a porta: **5000**_

**No terminal do Visual Studio Code, utilize o comando abaixo:**
```
docker compose up -d --build
```
**Em seguida, abra seu navegador e coloque:**
```
http://localhost:5000/swagger
```

## 🔴Como Rodar **Sem** o Docker? ❌🚢🤷

**No terminal do Visual Studio Code, utilize o comando abaixo:**
```
dotnet run
```

**Observe a porta que ele apontou. Ex.: "Now listening on 5666"**
**Em seguida, abra seu navegador e coloque a porta apontada:**
```
http://localhost:5666/swagger

```
## 🟣Resultados Testes Insomnia:
A saída dos testes devem ser nesse modelo:
```
{
  "codigo": "CAT-793F-000123",
  "tipo": "Caminhao",
  "modelo": "Caterpillar 793F",
  "horimetro": 18234.5,
  "statusOperacional": "Operacional",
  "dataAquisicao": "2019-03-15",
  "localizacaoAtual": "Mina Carajás N4E"
}
```