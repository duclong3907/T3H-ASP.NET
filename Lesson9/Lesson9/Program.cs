using Lesson9;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Teacher teacher1 = new Teacher("Nguyen", "An", 35, "T001");

Student student1 = new Student("Tran", "Long", 20, "S001");

Student student2 = new Student("Le", "Minh", 22, "S002");

Course course1 = new Course("C#", teacher1);
teacher1.AddCourse(course1.CourseName);

course1.EnrollStudent(student1);
course1.EnrollStudent(student2);

course1.DisplayCourseInfo();