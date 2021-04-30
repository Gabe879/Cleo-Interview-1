using System;
using System.Collections;

namespace Cleo_Interview_1
{
    class Program
    {
        public School testSchool;
        static void Main(string[] args)
        {

            /*
                I underestimated the scope of these problems as far as
                the completion time was concerned. If I had more time, I could
                work out the bugs and have these functioning as intended.
                There was simply not enough time to test and bugfix while
                implementing the required functionality. I hope you can understand
                the intended functionality from what is present here.
            */


            //---------------------------------------------------------
            //Problem1 (not enough time to finish. Only one function Implemented. Class structure is crude but can be found in School.cs.)
            //---------------------------------------------------------
            testSchool = newSchool();
            Console.WriteLine(testSchool.getTeacherFromCourse("MATH101", "2020", "Fall"));
            
            //---------------------------------------------------------
            //Problem2 (Almost fully functional, a few changes still required.)
            //---------------------------------------------------------
            ArrayList[] aList =  {"a string", {"a","b",{"1","2","3"}}, "spam", {"eggs"}};
            writeOutList("Example", aList);

        }

        public School newSchool()
        {
            Teacher teacher1 = new Teacher("Molly", "Jones");
            Teacher teacher2 = new Teacher("Jason", "Reinhardt");
            Teacher teacher3 = new Teacher("Ed", "Donald");

            Teacher[] teachers = {teacher1, teacher2, teacher3};


            Course course1 = new Course(MATH101, 2020, Fall, teacher1);
            Course course2 = new Course(MATH102, 2020, Fall, teacher2);            
            Course course3 = new Course(MATH101, 2020, Spring, teacher1);
            Course course4 = new Course(MATH102, 2020, Spring, teacher2);
            Course course5 = new Course(MATH101, 2021, Fall, teacher1);
            Course course6 = new Course(MATH102, 2021, Fall, teacher2);
            Course course7 = new Course(MATH101, 2021, Spring, teacher1);
            Course course8 = new Course(MATH102, 2021, Spring, teacher2);

            Courses[] courses = {course1, course2, course3, course4,
                                 course5, course6, course7, course8,};
            Courses[] courses1 = {course4, course5, course6};
            Courses[] courses2 = {course1, course2, course3};
            Courses[] courses3 = {course7, course8};

            Grade grade1 = new Grade(course1, "A");
            Grade grade2 = new Grade(course2, "B");
            Grade grade3 = new Grade(course3, "C");

            Grade[] grades = {grade1, grade2, grade3};

            Student student1 = new Student("John", "Doe", grades);
            Student student2 = new Student("Jeff", "Adams", grades);
            Student student3 = new Student("Jane", "Smith", grades);

            Student[] students = {student1, student2, student3};

            School newSchool = new School(teachers, students, courses);
            return newSchool;
        }

        public void writeOutList(string name, ArrayList aList)
        {
            Console.Write(name + "");
            for(int i = 0; i < aList.Length; i++)
            {
                if (Item.GetType() == String)
                {
                    Console.Write("{0}.{1}\n", i , Item.toString());
                }
                else
                {
                    Console.Write(i + ".");
                    writeOutList(name, aList);
                }
            }
        }
    }
}






            
