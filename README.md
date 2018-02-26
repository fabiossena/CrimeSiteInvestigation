# CrimeSiteInvestigation

### Link:
http://crimesiteinvestigation.azurewebsites.net/


### Objetivo:
- Descubra quem é o assassino usando as pistas fornecidas e o depoimento (limitado) da única testemunha.


## Estrutura:

### Dois projetos:
- Um com estrutura Asp.Net Mvc. 
- E outro com a Model onde estão as entidades e regras de negócios. 


Usado bootstrap para um layout responsivo, onde efetuei algumas customizações (para deixa-lo com uma cara menos padrão) 
Usado JQuery para requisições AJAX.

### Próximos passos:
- As informações do jogo estão na própria lógica de negócios(mockup data), muitas informações para o usuário também estão na própria tela, vou colocar as mesmas no resources, pois facilitará habilitar outros idiomas, uso de banco de dados não se adequa pois no caso do aplicativo mobile devemos deixar o usuário ter acesso offline (ao menos que fizermos um banco local sincronizado com SQLite com Azure).
- Apenas para gravar log de pontuação e dados de login, devo usar banco de dados SQL Server hospedado no azure, acessando o mesmo com Entity.
- Relativo ao projeto para celular vou usar xamarin (para o que projeto seja multi-plataforma) com padrões MVVM, vinculando este com o projeto model usada na arquitetura MVC. 
- Relativo ao padrão MVC a estrutura ainda pode ser melhorada.
- As imagens ainda estou usando o link que peguei no google, vou trazer para o projeto colocando em um resources.


### Estrutra:

![alt text](https://docs.google.com/uc?export=download&id=1PD_i-zfwPx4bpmsrq4Yy9RtS8aCNKjZb)
