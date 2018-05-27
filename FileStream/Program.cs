using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1.	В файле записана непустая последовательность целых чисел, являющихся числами Фибоначчи. 
             * Приписать еще столько же чисел этой последовательности
             * */


            /*
            string pathINPUT = "INPUT1.TXT ";
            string pathOUTPUT = "OUTPUT1.TXT ";

            ///////string[] s;
            List<string> s = new List<string>();
            List<int> List = new List<int>();

            using (StreamReader sr = new StreamReader(pathINPUT))
            {
                string a = sr.ReadToEnd();
                s = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var item in s)
            {
                List.Add(Int32.Parse(item));
            }

            List = Fibonachi(List);

            using (StreamWriter sw = new StreamWriter(pathOUTPUT))
            {
                foreach (int item in List)
                {
                    sw.Write(item);
                }
            }
        
        


            static List<int> Fibonachi(List<int> List)
            {
                int size = List.Count;
                for (int i = size - 1; i < (size * 2) - 1; i++)
                {
                    List.Add(List[i - 1] + List[i]);
                }
                return List;
            }
            */





            /*2.	Сложить два целых числа А и В.
            Входные данные
            В единственной строке входного файла INPUT.TXT записано два натуральных числа через пробел.
            Выходные данные
            В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел А и В.

                */

            /*
            string pathINPUT = "INPUT2.TXT ";
            string pathOUTPUT = "OUTPUT2.TXT ";

            List<string> s = new List<string>();

            using (StreamReader sr = new StreamReader(pathINPUT))
            {
                string a = sr.ReadToEnd();
                s = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            using (StreamWriter sw = new StreamWriter(pathOUTPUT))
            {
                //int sum = Int32.Parse(s[0]) + Int32.Parse(s[1]);
                sw.Write(Int32.Parse(s[0]) + Int32.Parse(s[1]));
            }
            */




            /*1.	Написать программу, читающую побайтно заданный файл и подсчитывающую число появлений
             * каждого из 256 возможных знаков
             * */

            /*
            string pathINPUT = "INPUT3.TXT ";
            string pathOUTPUT = "OUTPUT3.TXT ";
            int[] chars = new int[255];
            string s;

            using (StreamReader sr = new StreamReader(pathINPUT))
            {
                s = sr.ReadToEnd();
            }

            foreach (char item in s)
            {
                ++chars[(int)item];
            }

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(i + " - " + chars[i]);
            }
            */



            /*2.	С помощью класса StreamWriter записать в текстовый файл свое имя, фамилию и возраст. 
             * Каждая запись должна начинаться с новой строки.
             * */


            /*
            string pathOUTPUT = "OUTPUT4.TXT ";

            using (StreamWriter sw = new StreamWriter(pathOUTPUT))
            {
                sw.WriteLine("Ulan");
                sw.WriteLine("Zholdaskhanov");
                sw.WriteLine("21");
            }
            */

        }

    }
}