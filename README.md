# AdManager

#Esse projeto é uma forma simples de cadastro e calculo de alcance de anúncios com base no valor investido por dia por um tempo determinado.
##
## Sobre o Projeto:
### -> Foi desenvolvido na linguagem C# usando windows forms
### -> Foi usado o Entity Framework para manipulação e criação do banco de dados 

## Requisitos:
### Visual Studio Community 2019
### dotnet 5.0.201 --> "https://dotnet.microsoft.com/download/dotnet/5.0"



### ABRINDO O PROJETO

#### Faça o download do repositório e abra o visual studio, no menu lateral escolha a opção Abrir um projeto ou solução e busque e selecione o arquivo AdManager.sln que está no repositório. 

![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/openproject.PNG)
![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/Solution.PNG)


###Após carregar tudo, para a criação do banco de dados vá no menu superior em Ferramentas -> Gerenciador de pacotes do nuget -> Console do gerenciador de pacotes.

![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/imagem_2021-05-10_190606.png)

### Um console irá aparecer na parte inferior da IDE. Digite os seguintes comandos em sequencia
#### >enable-migrations
#### >add-migration nome-da-migration  -- OBS: No projeto já vai ter uma migration pronta, então ignore essa parte e tente executar direto o próximo comando --
#### >update-database

OBS: Caso dê algum problema, dentro do projeto aberto no visual studio, localize a pasta 'migrations' e exclua a que contem o nome 'first_migration'

### Em seguida execute o projeto na seta verde no meio superior da IDE:

![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/run.PNG)



# O Programa

## Salvar

### Após executar o projeto uma tela irá aparecer, nela você devera preencher com os dados necessários e uma tela de confirmação aparecerá quando salvar

![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/run.PNG)
![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/save1.PNG)
Obs: Caso os dados forem preenchidos de forma errada, uma mensagem irá aparecer informando os erros


## Anúncios

### Após salvar, esse anúncio já estará disponível na lista localisada na aba 'Anuncios'

![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/save2.PNG)

### Ao clicar no anúncio especificado, uma nova janela abrirá mostrando um relatório básico de projeção de alcance, cliques e alcance com compartilhamento

![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/imagem_2021-05-10_191339.png)

### Acima tera uma ComboBox que podera ser usada para selecionar todos os anúncios de cada usuário, poderá ser usado junto o intervalo de tempo entre uma data e outra, ou seja,
irá exibir os anúncios do cliente e dentro da data estipulada pelo usuário caso seja especificada.

![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/save3.PNG)
![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/save4.PNG)


## Configurações

### As configurações são compostas basicamente por médias que o usuário pode alterar para ver o alcance com diferentes coeficientes.

![alt text](https://github.com/FernandoLang/AdManager/blob/main/Images/save5.PNG)
#### Coeficiente de pessoas : Quantas pessoas serão alcançadas por dia por cada real investido?
#### Coeficiente de compartilhamentos : Qual o número de compartilhamentos em sequência serão utilizados? (pessoa > compartilha > pessoa > compartilha > pessoa > compartilha)
#### Coeficiente de cliques : A cada quantas pessoas alcançadas irá resultar em um clique?

#### Esses valores poderão ser alterados para conferir o relatório em diferentes possibilidades.








