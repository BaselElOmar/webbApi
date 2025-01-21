var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.MapGet("/add", (int num1, int num2) => AddNumbers(num1, num2));

app.MapGet("/subtract", (int num1, int num2) => subtractNumbers(num1, num2));

app.Run();
//has to be the end for it to work

string AddNumbers(int num1, int num2)
{
    return $"The sum of {num1} and {num2} is: {num1 + num2}";
}

string subtractNumbers(int num1, int num2)
{
    return $"The dif of {num1} and {num2} is: {num1 - num2}";
}