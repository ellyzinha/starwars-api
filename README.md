<h1 align="center"> StarWarsAPI </h1>

# Como Executar:

OBS: para executar esse projeto você deve ter na sua máquina instalado o dotnet. 
<a> https://dotnet.microsoft.com/en-us/download </a>

- Baixe o projeto na sua máquina
- Pelo terminal acesse a pasta StarWarsShip
- Execute o comando: `dotnet run`
- Acesse o link após a execução: <a> https://localhost:7156/swagger/index.html </a>
- A rota do desafio: /ListStops

  ## Utilizando o NGROK para compartilhar a rota

  Para poder utilizar a chamada da API no bot eu utilizei o ngrok para compartilhar a rota. Para isso a API deve estar em execução na sua máquina local.
  - Link de Download: https://ngrok.com/download
  - Após baixar na sua máquina acesse a pasta no windows pelo terminal
  - Comando para executar o NGROK: `ngrok.exe http https://localhost:7156/`
  - Copie o link para utilizar no bot.
  - [![2023-11-05-20-59-17-Editing-starwars-api-README-md-at-main-ellyzinha-starwars-api-Vivaldi.png](https://i.postimg.cc/ZqqyY9TC/2023-11-05-20-59-17-Editing-starwars-api-README-md-at-main-ellyzinha-starwars-api-Vivaldi.png)](https://postimg.cc/qN97jv6T)

# Desenvolvimento Chatbot

- Erros Encontrados:
  - No bloco de Boas vindas no Hoje é dia está sem a variável calendar do blip, que seria: [calendar.date](http://calendar.date) para a data
  - No bloco redireciona para api estava esperando um input, então para ser redirecionado tinha que mandar outro input além do Menu
  - Além disso nas condições de saída do bloco de redirecionamento estava redirecionando para exceções, o correto seria para o Início
  - Bloco Chamada api aguardando um input
  - Script nas ações globais dando erro na execução do bot
  - O router context não estava ligado

## Modificando a url para a url gerado do NGROK
- No fluxo da api, no bloco *Chamada api* trocar a url para o teste:
- [![2023-11-05-21-02-46-API-SW-Vivaldi.png](https://i.postimg.cc/RVRF3Mpf/2023-11-05-21-02-46-API-SW-Vivaldi.png)](https://postimg.cc/N5KYSwcf)

Nome dos serviços no router para teste do bot:
- main
- apiService
