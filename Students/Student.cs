using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Student
    {
        private string name;
        private int IQ;
        private int hoursPerWeek;

        public Student(string n, int iq, int hours)
        {
            name = n;
            IQ = iq;
            hoursPerWeek = hours;
            Console.WriteLine("Student has been created.");
        }

        public string PredictGrade()
        {
            int score = IQ * hoursPerWeek;
            string predictedGrade = "Predicted grade of student " + name + " is: ";

            if (score >= 500)
            {
                predictedGrade += "A*";
            }
            if (score < 500 && score >= 400)
            {
                predictedGrade += "A";
            }
            if (score < 400 && score >= 300)
            {
                predictedGrade += "B";
            }
            if (score < 300)
            {
                predictedGrade += "C";
            }

            return predictedGrade;
            
        }

        public void Learn()
        {
            IQ += 5;
        }

        public void Effort(int changeInHours)
        {
            hoursPerWeek += changeInHours;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public void SetIQ(int IQ)
        {
            this.IQ = IQ;
        }
        public int GetIQ()
        {
            return IQ;
        }

        public void SetHours(int hours)
        {
            hoursPerWeek = hours;
        }
        public int GetHours()
        {
            return hoursPerWeek;
        }
    }
}
