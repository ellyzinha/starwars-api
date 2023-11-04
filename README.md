<h1 align="center"> StarWarsAPI </h1>

# Como Executar:

OBS: para executar esse projeto você deve ter na sua máquina instalado o dotnet. 
<a> https://dotnet.microsoft.com/en-us/download </a>

- Baixe o projeto na sua máquina
- Pelo terminal acesse a pasta StarWarsShip
- Execute o comando: dotnet run
- Acesse o link após a execução: <a> https://localhost:7156/swagger/index.html </a>
- A rota do desafio: /ListStops

# Desenvolvimento Chatbot

- Erros Encontrados:
  - No bloco de Boas vindas no Hoje é dia está sem a variável calendar do blip, que seria: [calendar.date](http://calendar.date) para a data
  - No bloco redireciona para api estava esperando um input, então para ser redirecionado tinha que mandar outro input além do Menu
  - Além disso nas condições de saída do bloco de redirecionamento estava redirecionando para exceções, o correto seria para o Início
  - Bloco Chamada api aguardando um input
  - Script nas ações globais dando erro na execução do bot
  - O router context não estava ligado

Nome dos serviços no router para teste do bot:
- main
- apiService
