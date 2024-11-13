
//Дополнительное Задание 1
//Реализовать обработку POST запроса с возвращением ответа.
//Когда вы запустите приложение и сделаете POST-запрос к URL "/api/greeting"
//с телом запроса, содержащим строку (например, {"name": "John"}),
//вы должны получить ответ с персонализированным приветствием (например, "Hello, John!").

//var builder = WebApplication.CreateBuilder();
//var app = builder.Build();

//app.Run(async (context) =>
//{
//    context.Response.ContentType = "text/html; charset=utf-8";
//    await context.Response.WriteAsync($"<p>Hello, {context.Request.Query["name"]}!</p>");
//});

//app.Run();



/////////////////
//Дополнительное Задание 2
//Используя JavaScript или любой другой Фреймворк или PostMan, отправьте JSON объект на любое действие в C#.
//После получение, отобразите это значение на новой странице.


//var builder = WebApplication.CreateBuilder();
//var app = builder.Build();

//app.Run(async (context) =>
//{
//    var response = context.Response;
//    var request = context.Request;
//    string path = request.Path.ToString().ToLower();

//    if (path == "/api/user")
//    {
//        var message = "Некорректные данные";   // содержание сообщения по умолчанию
//        try
//        {
//            // пытаемся получить данные json
//            var person = await request.ReadFromJsonAsync<Person>();
//            if (person != null) // если данные сконвертированы в Person
//                message = $"Name: {person.Name}  Age: {person.Age}";
//        }
//        catch { }
//        // отправляем пользователю данные
//        response.ContentType = "text/html; charset=utf-8";
//        await response.WriteAsJsonAsync(new { text = message });
//    }
//    else
//    {
//        response.ContentType = "text/html; charset=utf-8";
//        await response.SendFileAsync("html/index.html");
//    }
//});

//app.Run();

//public record Person(string Name, int Age);



//////////////////
//Дополнительное Задание 3
//Создайте приложение возвращающие список пользователей из коллекции или базы данных в ответ на GET запрос.
//Сам GET-запрос направляем на URL "/api/customers" в лямбда-функцию,
//которая извлекает всех клиентов из базы данных или коллекции и возвращает их в качестве ответа.

//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//List<Person> customers = new List<Person>()
//{
//    new Person("Tom", 30),
//    new Person("Kate", 19)
//};

//app.Run(async (context) =>
//{
//    var path = context.Request.Path.ToString();
//    var response = context.Response;
//    var request = context.Request;

//    switch (path.ToLower())
//    {
//        case "/": { await response.WriteAsync("Welcome to Customers API"); break; }
        
//        case "/api/customers": { await response.WriteAsJsonAsync(customers); break; }

//        default: { await response.WriteAsJsonAsync("Not found"); break; }
//    }
//});

//app.Run();

//class Person
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//}

