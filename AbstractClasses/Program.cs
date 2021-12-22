﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses  //Abstract Classlar birer inheritance'dir

{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }

        abstract class Database
        {
            public void Add()  //TAMAMLANMIŞ Metod
            {
                Console.WriteLine("Added By Default");
            }

            public abstract void Delete(); //TANIMLANMAMIŞ Metod

        }

        class SqlServer: Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted By Sql");
            }
        }

        class Oracle : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted By Oracle");
            }
        }
    }
}