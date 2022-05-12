using System;

namespace practical4
{


    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "Fenil Patel";

            Console.WriteLine("Name:" + s.name);
            s.rollno = 5;
            Console.WriteLine("Roll no:" + s.rollno);
            s.getdata();
            Console.WriteLine("Your Percentage is " + s.percentage + " .");
            Console.WriteLine("You got  " + s.grade + "  grade.");


            Console.ReadLine();
        }
    }
    class Student
    {
        public int rollno;
        public string name;
        public int n;
        public int[] subject;
        float per;

        public void getdata()
        {


            Console.WriteLine("Enter number of subjects");
            n = Convert.ToInt32(Console.ReadLine());
            subject = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter marks of subject:");
                subject[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public int rollnum
        {
            get
            {
                return rollno;
            }

            set
            {
                if (value > 0)
                {
                    rollno = value;
                }
            }
        }

        public string myname
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public float percentage
        {

            get
            {
                int sum = 0;
                foreach (int j in subject)
                {
                    sum += j;
                }
                per = (float)sum / n;
                return (per);
            }

        }

        public string grade
        {
            get
            {
                if (percentage > 90)
                    return "A";
                else if (percentage > 80)
                {
                    return "B";
                }
                else if (percentage > 70)
                {
                    return "C";
                }
                else if (percentage > 60)
                {
                    return "D";

                }
                else
                {
                    return "F";
                }
            }

        }


    }

}
