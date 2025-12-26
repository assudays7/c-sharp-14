
using task1;

System.Console.WriteLine("Student:");

Student student = new Student("Muhammadjon", "Dushanbe", 3, ["Dart", "Frontend", "C#"], [83, 81, 75]);
student.AddCourseGrade(".Net", 80);

double average = student.GetAverageGrade();
System.Console.WriteLine(average);

student.PrintGrades();
System.Console.WriteLine("Teacher:");

Teacher teacher = new Teacher("Alijon", "Dushanbe", 2, [".NET", "C#"]);

teacher.AddCourse("Git");

teacher.AddCourse("C++");

teacher.RemoveCourse("Git");

teacher.PrintGrades();