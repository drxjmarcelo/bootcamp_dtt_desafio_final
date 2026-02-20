# 🟢Desafio Final - Gerenciador de Equipamentos
 Programa para listar, alterar, manipular, deletar equipamentos de mineração.
 
## Estrutura 🏗️
### Controllers: 🕹️
* EquipamentosController.cs
### Data: 💾
* AppDbContext.cs
### Dtos: 📋
* N/A
### Models: 🧊
* Equipamentos.cs
* HistoricoLocalizacao.cs (**_Não concluído_**)
### Services: 🔧
* EquipService.cs

## Detalhes: 📄
Manter atenção nesse trecho do código em Program.cs:
```
app.UseSwagger();
app.UseSwaggerUI();
```
Sem esse trecho, o código **não** irá abrir no navegador.

## Como Rodar **Com** o Docker? 🚢🤷
_Usar a porta: **5000**_

**No terminal do Visual Studio Code, utilize o comando abaixo:**
```
docker compose up -d --build
```
**Em seguida, abra seu navegador e coloque:**
```
http://localhost:5000/swagger
```

## Como Rodar **Sem** o Docker? ❌🚢🤷

**No terminal do Visual Studio Code, utilize o comando abaixo:**
```
dotnet run
```

**Observe a porta que ele apontou. Ex.: "Now listening on 5222"**
**Em seguida, abra seu navegador e coloque a porta apontada:**
```
http://localhost:5222/swagger

```

