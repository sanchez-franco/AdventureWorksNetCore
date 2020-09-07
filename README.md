# .NET Core 3.1 REST API using [AdventureWorks DB]


Sample implementation of an MVC application calling Web API using day to day concepts.

![LogIn](/Images/LogIn.PNG)

![Person Details](/Images/ViewPerson.PNG)

## Implementation Details

### Entity Framework (EF)

Using EF as our Object-Relational Mapping / Persistence Framework.

### [Repository Pattern]

Sample implementation of [Repository Pattern] defined by Mosh Hamedani

- A Repository mediates between the domain and data mapping layers, acting like an **in-memory collection** of domain objects.
- Minimizing duplicate query logic by the basic encapsulation principle.
- Promotes testability.

[Meh](https://github.com/sanchez-franco/AdventureWorks/blob/c2853d4ef3a9b1e77d951fc4077a9049be0ea868/AdventureWorks.Data.Repository/Repository.cs#L9)

![Repository Pattern](/Images/RepositoryPattern.PNG)

**NOTE: A current issue that I encounter using EF is the [N + 1 Problem]. Please make sure when you create your queries to address this issue.** 

![N + 1 Problem](/Images/N+1.PNG)

### Unit of Work Pattern (UOW)

- Maintains a list of objects affected by a business transaction and coordinates the writing out of changes.

![Unit of Work](/Images/UnitOfWork.PNG)

### Unit of Work Pattern + Repository Pattern

![Unit of Work Pattern + Repository Pattern](/Images/UnitOfWork&RepositoryPattern.PNG)

### [Factory Method]

- Using the creational pattern [Factory Method] to promote loose coupling.
- Promotes testability.

![Factory Method](/Images/FactoryMethod.PNG)

### Dependency Injection Pattern (DI)

- By definition, Dependency Injection (DI) is an object-oriented programming design pattern that allows us to develop loosely coupled code.
- This is accomplished by the Inversion of Control principle (IoC), the flow depends on the defined abstractions to be implemented that is built up during program execution.
- We use out of the box containers in our Web API project to configure this as follows.

![DI](/Images/DI.PNG)

### Web API Bearer Token

Screenshots to call our Web API using [Postman]

- Use out of the box configuration in our Web API project and use the integration to our DB to authenticate the user.

![Bearer Token](/Images/OAuth.PNG)

![Get Token](/Images/GetToken.PNG)

- Using our token to call crud methods in our Web API.

![CrudMethods](/Images/CrudMethods.PNG)

![Use Token](/Images/UseToken.PNG)

### Unit Testing

- I've created a small Unit Test project to check our validation process on the Authentication Service.
- There are a bunch of frameworks to do this, currently I use [Moq] to be able to Mock our abstractions
- Another good tool for Unit Testing that I like to use (not currently in this project) is [AutoFixture], since it helps you save a lot of time by autogenerating entities based on parameters.
- All of this can be accomplished since we used abstractions in our N-Tier Application, which made our code not tightly coupled.

![Unit Testing](/Images/UnitTesting.PNG)

[Moq]: https://github.com/moq/moq4
[AutoFixture]: https://github.com/AutoFixture/AutoFixture
[Postman]: https://learning.getpostman.com/docs/postman/sending_api_requests/authorization/
[Repository Pattern]: https://programmingwithmosh.com/
[AdventureWorks DB]: https://github.com/Microsoft/sql-server-samples/releases/tag/adventureworks
[Factory Method]: https://www.dofactory.com/net/factory-method-design-pattern
[N + 1 Problem]: http://blogs.microsoft.co.il/gilf/2010/08/18/select-n1-problem-how-to-decrease-your-orm-performance/
