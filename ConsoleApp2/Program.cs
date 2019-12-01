using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string aa = "&ncsdnfhf.&fhuknduifsfkj";
            //string aa = "&ncsdnj&fhujv&fsddfsnfngfnf&bsjb";
            string aa = "&ncsdnj&fhujv&hhkj&bsjb&dnghfghgpg&jgh&thdjghjghj";
            int len = aa.Length;
            List<String> list = new List<String>();
            bool isShort = true;
            if (len <= 15)
            {
                Console.WriteLine(aa);
                Console.ReadKey();
            }
            else if (len > 15)
            {

                var array = aa.Split('&');
                Console.WriteLine("单词个数："+(array.Length-1));
                Console.WriteLine("字符长度：" + (len - 1));
                Console.WriteLine("--------------------------------------");
                //array[1]=ncsdnj
                //array[2]=fhujv
                //array[3]=fsddfsnfngfnf
                //array[4]=bsjb 
                //array[5]=jghfjhjghjghjghjghj
                for (int i = 1; i < array.Length; i++)
                {
                    if (isShort == true)
                    {
                        if (array[i].Length <= 15 && array[i].Length > 7)
                        {
                            list.Add(array[i]);
                            isShort = true;
                        }
                        else
                        {
                            if (array[i].Length <= 7)
                            {
                                //for (int j = i + 1; j < i + 2; j++)
                               int j = i + 1;
                                {
                                    if (i < array.Length - 1)
                                    {
                                        if (array[j].Length + array[i].Length < 15)
                                        {
                                            list.Add(array[i] + "&" + array[j]);                                
                                            isShort = false;
                                        }
                                    }
                                    else
                                    {
                                        list.Add(array[i]);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        isShort = true;
                    }
                }
                foreach (var a in list)
                {
                    Console.WriteLine(a);
                }
                Console.ReadKey();
            }
        }
    }
}