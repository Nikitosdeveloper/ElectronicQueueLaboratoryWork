using ElectronicQuere;
using System.Diagnostics.Eventing.Reader;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

/*System.Console.WriteLine("������� ������ �������� � ������� ������� ��� �������� ������������������ ����������� ");
System.Console.WriteLine("����� ������");
System.Console.WriteLine("���������� ���");
System.Console.WriteLine("������� ���� � ������� �������� ���� (1, ���� ���� � 0, ���� �� ����");

string[] FIO = System.Console.ReadLine().Split(' ');
string login = System.Console.ReadLine();
string password = System.Console.ReadLine();
int count = int.Parse(Console.ReadLine());
List<string> list = new List<string>();
List<bool> List = new List<bool>();
for (int i  = 0; i < count; i++)
{
    list.Add(Console.ReadLine());
    List.Add(bool.Parse(Console.ReadLine()));
}

Student student = new Student {
    Name = FIO[1],
    SecondName = FIO[0],
    FatheredName = FIO[2],

};*/


using (var context = new Repository())
{
	ICollection<LaboratoryWork> Labs = new List<LaboratoryWork>
	{
		new LaboratoryWork
		{
			LaboratoryWorkName = "�������",
			IsCompleted = true
		},
		new LaboratoryWork
		{
			LaboratoryWorkName = "���������",
			IsCompleted = false
		},
	};
	Student student = new Student
	{
		Name = "������",
		SecondName = "���������",
		FatheredName = "����������",
		StudentNumber = 129323923,
		GroupNumber = 10234,
		Login = "abababab",
		Password = "213i035u8358",
		LaboratoryWorks = Labs
	};

	//context.Students.Add(student);
	//context.SaveChanges();
	int newStudentId = Operations.Create(student);

}
app.MapGet("/", () => "hello");

app.Run();
