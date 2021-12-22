using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            
            sqlServer.Add();

            MySql mySql = new MySql();

            mySql.Add();

            Console.ReadLine();

        }
    }



    class DataBase
    {
        public virtual void Add()
        {
            Console.WriteLine("Added By Default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted By Default");
        }
    }

    class SqlServer : DataBase
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
    }


    class MySql : DataBase
    {

    }
}





