
using GenericsDemo;


var student = new Store<Student>();
student.Add(new Student(1, "Hana"));
student.Add(new Student(2, "Karim"));
student.Add(new Student(3, "Mona"));
student.Add(new Student(4, "Omar"));
student.Add(new Student(5, "Salma"));

var course = new Store<Course>();
course.Add(new Course(101, "C#", 500));
course.Add(new Course(102, "SQL", 400));
course.Add(new Course(103, "Git", 300));

var s = student.GetById(3);
Console.WriteLine($"Student : {s?.Name}");
var c = course.GetById(102);
Console.WriteLine($"Course : {c?.Title}");

try
{
    student.Add(new Student(3,"Asmaa"));
}
catch(ArgumentException ex)
{
    Console.WriteLine($"Error :{ex.Message}");
}

Console.WriteLine("\nPage 2: ");
foreach (var stu in student.GetAll().Page(2, 2))
{
    Console.WriteLine($"Id: {stu.Id} , Name: {stu.Name}");
}


var list = new List<Course>()
{
    new Course(201, "Python", 350),
    new Course(202, "HTML", 200)
};
var foundCourse = list.FindById(202);
Console.WriteLine($"\nPlain list: {foundCourse?.Title}");

//var invalidLine = new Store<string>();   
   // MUST NOT COMPILE