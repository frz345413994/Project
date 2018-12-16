using connection;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Database();

            db.Insert(new Test());
            new Test().Insert();


        }
    }
}
