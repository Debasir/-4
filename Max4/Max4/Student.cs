using System;
using System.Collections.Generic;
using System.Text;

namespace Max4
{
    class Student
    {
        string name;
        double GPA;
        int course;
        double Q;

        public Student(string name, double GPA, int course)
        {
            this.name = name;
            this.GPA = GPA;
            this.course = course;
            this.Q = set_Q(GPA, course);
        }

        private double set_Q(double GPA, int course)
        {
            return 0.2 * GPA * course;
        }

        public double get_Q()
        {
            return (double)Q;
        }

    }
}
