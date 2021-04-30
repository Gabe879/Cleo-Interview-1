using System;
namespace Cleo_Interview_1
{

    public class School
    {
        public Teacher[] teachers;
        public Student[] students;
        public Course[] courses;

        public School(Teacher[] passedTeachers, Student[] passedStudents, Course[] passedCourses)
        {
            teachers = passedTeachers;
            students = passedStudents;
            courses = passedCourses;
        }

        public string getTeacherFromCourse(string courseName, string courseYear, string courseSem)
        {
            foreach (var Course in courses)
            {
                if (String.Equals(Course.name, courseName) && String.Equals(Course.year, courseYear) && String.Equals(Course.sem, courseSem))
                {
                    return String.Format("{0} {1}", Course.teacher.fName, Course.teacher.lName);
                    break;
                }
            }
        }


    }
    public class Teacher
    {
        public string fName;
        public string lName;
        public Course[] tCourses;

        public Teacher(string firstName, string lastName)
        {
            fName = firstName;
            lName = lastName;
        }

    }
    public class Student
    {
        public string fName;
        public string lName;
        public Grade[] grades;

        public Student(string firstName, string lastName, Grade[] gradesRef)
        {
            fName = firstName;
            lName = lastName;
            grades = gradesRef;
        }
    }
    public class Course
    {
        public string name;
        public string year;
        public string sem;
        public Teacher teacher;

        public Course(string courseName, string courseYear, string courseSemester, Teacher courseTeacher)
        {
            name = courseName;
            year = courseYear;
            sem = courseSemester;
            teacher = courseTeacher;
        }
    }

    public class Grade
    {
        public Course course;
        public string grade;
    
        public Grade(Course courseRef, string gradeRef)
        {
            course = courseRef;
            grade = gradeRef;
        }
    }
}