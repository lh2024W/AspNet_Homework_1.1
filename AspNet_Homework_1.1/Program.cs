
//�������������� ������� 1
//����������� ��������� POST ������� � ������������ ������.
//����� �� ��������� ���������� � �������� POST-������ � URL "/api/greeting"
//� ����� �������, ���������� ������ (��������, {"name": "John"}),
//�� ������ �������� ����� � ������������������� ������������ (��������, "Hello, John!").

//var builder = WebApplication.CreateBuilder();
//var app = builder.Build();

//app.Run(async (context) =>
//{
//    context.Response.ContentType = "text/html; charset=utf-8";
//    await context.Response.WriteAsync($"<p>Hello, {context.Request.Query["name"]}!</p>");
//});

//app.Run();



/////////////////
//�������������� ������� 2
//��������� JavaScript ��� ����� ������ ��������� ��� PostMan, ��������� JSON ������ �� ����� �������� � C#.
//����� ���������, ���������� ��� �������� �� ����� ��������.


//var builder = WebApplication.CreateBuilder();
//var app = builder.Build();

//app.Run(async (context) =>
//{
//    var response = context.Response;
//    var request = context.Request;
//    string path = request.Path.ToString().ToLower();

//    if (path == "/api/user")
//    {
//        var message = "������������ ������";   // ���������� ��������� �� ���������
//        try
//        {
//            // �������� �������� ������ json
//            var person = await request.ReadFromJsonAsync<Person>();
//            if (person != null) // ���� ������ ��������������� � Person
//                message = $"Name: {person.Name}  Age: {person.Age}";
//        }
//        catch { }
//        // ���������� ������������ ������
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
//�������������� ������� 3
//�������� ���������� ������������ ������ ������������� �� ��������� ��� ���� ������ � ����� �� GET ������.
//��� GET-������ ���������� �� URL "/api/customers" � ������-�������,
//������� ��������� ���� �������� �� ���� ������ ��� ��������� � ���������� �� � �������� ������.

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

