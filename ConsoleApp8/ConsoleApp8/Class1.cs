using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using System.Collections;

namespace ClassLibrary1
{
    public class student
    {

        public ArrayList a = new ArrayList();

        public void add(int[] id, int x)
        {
            WriteLine("Введите id студента");
            a.Add(ReadLine());
            int c = 0;
            for (int i = 0; i < x; i++)
            {
                if (ToInt32(a[0]) == ToInt32(id[i]))
                {
                    c++;
                }

            }

            if (c == 0)
            {


                WriteLine("Введите Фамилию студента");
                a.Add(ReadLine());
                WriteLine("Введите Имя студента");
                a.Add(ReadLine());
                WriteLine("Введите Отчество студента");
                a.Add(ReadLine());
                WriteLine("введите группу студента");
                a.Add(ReadLine());
                WriteLine("введите дату рождения в виде( дд.мм.гггг");
                a.Add(ReadLine());
            }
            else
            {
                WriteLine("данный id занят");
            }
        }
        public void cor(int[] id, int x)
        {
            a.Clear();
            WriteLine("Введите новое id студента");
            a.Add(ReadLine());
            int c = 0;
            for (int i = 0; i < x; i++)
            {
                if (ToInt32(a[0]) == ToInt32(id[i]))
                {
                    c++;
                }
            }
            if (c == 0)
            {


                WriteLine("Введите Фамилию студента");
                a.Add(ReadLine());
                WriteLine("Введите Имя студента");
                a.Add(ReadLine());
                WriteLine("Введите Отчество студента");
                a.Add(ReadLine());
                WriteLine("введите новую группу студента");
                a.Add(ReadLine());
                WriteLine("введите новую дату рождения в виде( дд.мм.гггг");
                a.Add(ReadLine());
            }
        }
        public void del()
        {
            a.Clear();
        }
        public void all()
        {
            for (int i = 0; i < a.Count; i++)
            {
                Write(a[i] + " ");
            }
            WriteLine();
        }
        public void seach(int q)
        {
            if (q == ToInt32(a[0]))
            {
                for (int i = 0; i < a.Count; i++)
                {
                    Write(a[i] + "  ");
                }
            }
        }
        public void year(int q)
        {
            string s = a[3] + "";
            string[] s1 = s.Split('.');
            if (q == ToInt32(a[0]))
            {

                WriteLine(2020 - ToInt32(s1[2]));
            }
        }
        public void inic(int q)
        {
            if (q == ToInt32(a[0]))
            {

                string s1 = a[1] + "";
                string s2 = a[2] + "";
                string s3 = a[3] + "";
                WriteLine(s1 + " " + s2[0] + "." + s3[0] + ".");
            }
        }
        public void vozr(string c)
        {
            int v;
            string s = a[3] + "";
            string[] s1 = s.Split('.');
            v = 2020 - ToInt32(s1[2]);
            if (c == "a")
            {
                if (v <= 18)
                {
                    for (int i = 0; i < a.Count; i++)
                    {
                        WriteLine(a[i] + " ");
                    }
                }
            }
            else if (c == "s")
            {
                if (v >= 18)
                {
                    for (int i = 0; i < a.Count; i++)
                    {
                        Write(a[i] + " ");
                    }
                    WriteLine();
                }
            }
        }
        public void fam(string c)
        {
            if (c == a[2].ToString())
            {
                for (int i = 0; i < a.Count; i++)
                {
                    Write(a[i] + " ");
                }
            }
        }
    }
}
