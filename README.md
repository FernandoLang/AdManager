# AdManager

#Esse projeto é uma forma simples de cadastro e calculo de alcance de anúncios com base no valor investido por dia por um tempo determinado.
##
## Sobre o Projeto:
### -> Foi desenvolvido na linguagem C# usando windows forms
### -> Foi usado o Entity Framework para manipulação e criação do banco de dados (a escolha do entity framework é para que assim que o projeto ou o executável seja aberto pela ###primeira vez na máquina, o programa já cria o banco de dados e as tabelas automaticamente)

## Requisitos:
### Visual Studio Community 2019
### dotnet 5.0.201 --> "https://dotnet.microsoft.com/download/dotnet/5.0"



### ABRINDO O PROJETO

#### Faça o download do repositório e abra o visual studio, no menu lateral escolha a opção Abrir um projeto ou solução e busque e selecione o arquivo AdManager.sln que está no repositório. 

![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/Solution.PNG)


###Após carregar tudo, para a criação do banco de dados vá no menu superior em Ferramentas -> Gerenciador de pacotes do nuget -> Console do gerenciador de pacotes.

![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/imagem_2021-05-10_190606.png)

### Um console irá aparecer na parte inferior da IDE. Digite os seguintes comandos em sequencia
#### enable-migrations
#### add-migration nome-da-migration  OBS: No projeto já vai ter uma migration pronta, então ignore essa parte e tente executar direto o próximo comando
#### update-database

OBS: Caso dê algum problema, dentro do projeto aberto no visual studio, localize a pasta 'migrations' e exclua a que contem o nome 'first_migration'


