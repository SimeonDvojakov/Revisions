using Abstract_Classes_And_Interfaces;

Teacher teacher1 =  new Teacher(1, "Ryan Gosling", "CoolTeacher123", new List<string> { "Math", "History", "Physics"} );
Teacher teacher2 =  new Teacher(2, "Jane Doe", "JDoe97", new List<string> { "Art", "PE", "Psychology", "English" });

Student student1 = new Student(3, "John Student", "McLovin", new Dictionary<string, int> { { "Math", 10 }, { "History", 10 }, { "Physics", 10 }, { "Art", 7 }, { "PE", 9 }, { "Psychology", 10 }, { "English", 10 } });
Student student2 = new Student(4, "Jane Student", "SummerBreakFan", new Dictionary<string, int> { { "Art", 10 }, { "Psychology", 7 }, { "English", 8 } });


teacher1.PrintUser();
teacher1.PrintSubjects();
teacher2.PrintUser();
teacher2.PrintSubjects();

student1.PrintUser();
student1.PrintGrades();
student2.PrintUser();
student2.PrintGrades();