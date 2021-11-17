# TodoApp

### Pacotes Nuget's necessários
>- Microsoft.EntityFrameworkCore -Version 5.0.12 
>- Microsoft.EntityFrameworkCore.SqlServer -Version 5.0.12
>- Microsoft.EntityFrameworkCore.Tools -Version  5.0.12
>- Microsoft.Extensions.DependencyInjection -Version 5.0.2
>- Swashbuckle.AspNetCore -Version 5.6.3

### Obtendo ConnectionString
>- Faça uma pesquisa e procure: SQL Server Object Explorer e clique no mesmo.

![image](https://user-images.githubusercontent.com/72450648/142090182-a6100d27-1969-4801-a947-141bdbad5f87.png)

>- Ao fazer isso irá abrir uma aba com os bancos locais em sua máquina

![image](https://user-images.githubusercontent.com/72450648/142090258-72342ce6-3b05-4080-bbfa-f18b67a300ba.png)

> 1. No server Local que estiver disponível clique com o botão direto do Mouse e procure:

![image](https://user-images.githubusercontent.com/72450648/142090443-87da0fd3-7523-44fd-8e1b-4a98e1c1b1f5.png)

> 2. ConnectionString, selecione e copie a mesma.

![image](https://user-images.githubusercontent.com/72450648/142090556-b25bba93-c5a4-40da-8940-dc4c549643ac.png)

> 3. Após isso vá até a camada de Aplicação onde está o projeto e abra o arquivo AppSettings.json

![image](https://user-images.githubusercontent.com/72450648/142090636-9edc0099-6b61-434d-b2ac-7852f20d21a1.png)

> 4. Altere o valor da connectionString de AppContexto com sua ConnectionString.

![image](https://user-images.githubusercontent.com/72450648/142090677-c2518bd0-65a4-462e-979c-980bd5bfa008.png)

> Após setar a ConnectionString, você irá ter que fazer os passoas a baixo para criar o banco no seu server.

### Comandos Migrations
>- Ao finalizar as instalações dos pacotes no projeto e configuração da connectionString será necessário:
1. Abrir o Console Manager do Visual Studio

![image](https://user-images.githubusercontent.com/72450648/142090741-ce535468-4407-4922-80a4-269884a006fa.png)

2. No console selecionar onde os comandos serão feitos: Infra\3.1 - Data\Infra.Data

![image](https://user-images.githubusercontent.com/72450648/142090788-46cf205a-e535-4951-92f1-e415a8ce8c94.png)

3. Adicionar o comando: update-database e dar enter.

![image](https://user-images.githubusercontent.com/72450648/142090860-83926621-9803-4584-95dd-b8b4dd859921.png)

> Feito as configurações de acordo com mensionado a cima, o projeto está livre para quaisquer tester relacionados a sua função.

### EndPoints
![EndPointsApiTodo](https://user-images.githubusercontent.com/72450648/142089674-3431770d-9c7b-400d-8fb9-cb1582d099e0.png)
> Ao todo foram criados três EndPoints, Get/Post e Put, cada um com suas respectivas funções e validações.
> 1. Metodo Get, retorna todos os cadastros pelo DateTime mais próximo do dia atual e que tenha propriedade "TarefaConcluida" como FALSE.
> 2. Metodo Post, salva todos os cadastros, as propriedades exigidas são: Nome, Data e se a tarefa esta concluida ou não (TRUE/FALSE)
> 3. Metodo Put, altera o valor da propriedade "TarefaConcluida", é exigido adicionar o ID do cadastro para a alteração da mesma.

### Modelagem da Aplicação

> A aplicação foi feita em DDD (Domain Driven Design).

![image](https://user-images.githubusercontent.com/72450648/142091385-68c65784-1bb0-4c1c-abb9-d22f06d0c13f.png)


### Estou a disposição para qualquer dúvida ou se houver conflitos na criação do Banco Local, Até logo!

