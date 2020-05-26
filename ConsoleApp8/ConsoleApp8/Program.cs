using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using System.Collections;


namespace ConsoleApp8
{
    class Program
    {
        static public int x = 0;
            static void Main(string[] args)
        {

            ClassLibrary1.student[] s = new ClassLibrary1.student[20];      
                int y = 0;
                int[] id = new int[20];
            bool b = true;
                for (int i = 0; i < 20; i++)
                {
                    s[i] = new ClassLibrary1.student();
                }
                while (b)
                {
                    WriteLine();
                    WriteLine("введите номер операции \n 1- добавление студента \n 2 - редактирование студента \n 3 - удаление студента \n 4 -  вывод всех студентов \n 5 - вывод всей информации по студенту по его id \n 6 - вывод возраста студента студента по его id \n 7 - вывести инициаллы студента по id \n 8 - вывести студетов которым больше 18-введите затем s,и которым меньше введите затем a \n 9 - поиск по фамилии \n 10 - закрыть программу");
                    int i = ToInt32(ReadLine());
                    int q;
                    string c = "";
                    switch (i)
                    {
                        case 1: s[x].add(id, x); id[x] = ToInt32(s[x].a[0]); WriteLine(id[0]); x++; break;
                        case 2:
                            WriteLine("введите номер по счёту студента которого хотите изменить");
                            if (x != 0 && x >= y)
                            {
                                y = ToInt32(ReadLine()); s[y].cor(id, x);
                            }
                            else
                            {
                                WriteLine("список студентов пуст");
                            }
                            break;
                        case 3:
                            WriteLine("введите номер по счёту студента которого хотите удалить");
                            if (x != 0 && x >= y)
                            {
                                y = ToInt32(ReadLine()) - 1; s[y].del();
                            }
                            else
                            {
                                WriteLine("список студентов пуст");
                            }
                            break;
                        case 4:
                            for (int j = 0; j < x; j++)
                            {
                                s[j].all();
                            }
                            break;
                        case 5:
                            q = ToInt32(ReadLine());
                            for (int j = 0; j < x; j++)
                            {

                                s[j].seach(q);
                            }
                            break;
                        case 6:
                            q = ToInt32(ReadLine());
                            for (int j = 0; j < x; j++)
                            {

                                s[j].year(q);
                            }
                            break;
                        case 7:
                            WriteLine("введите id студента чьи инициалы вывести"); q = ToInt32(ReadLine());
                            for (int j = 0; j < x; j++)
                            {

                                s[j].seach(q);
                            }
                            break;
                        case 8:
                            c = ReadLine();
                            for (int j = 0; j < x; j++)
                            {

                                s[j].vozr(c);
                            }
                            break;
                        case 9:
                            WriteLine("введите фамилию которую хотите найти"); c = ReadLine();
                            for (int j = 0; j < x; j++)
                            {
                                s[j].fam(c);
                            }
                            break;
                        case 10: b = false; break;
                    }

                }
            }
        }
    }
