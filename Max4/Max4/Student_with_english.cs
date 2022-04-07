using System;
using System.Collections.Generic;
using System.Text;

namespace Max4
{
    class Student_with_english: Student
    {
        bool P;
        double Qp;

        public Student_with_english(string name, double GPA, int course, bool P) : base(name, GPA, course)
        {
            this.P = P;
            this.Qp = set_Q(P);

        }
        public double set_Q(bool P)
        {
            if (P)
            {
                return 0.9 * (double)base.get_Q();
            }
            else
            {
                return base.get_Q();
            }
        }

        public double get_Q()
        {
            return Qp;
        }
    }
}
