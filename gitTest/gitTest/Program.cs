﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace gitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Git");
            int x = 12;

            SqlConnection con = ConnectionDB.Connection3();

            try
            {
                con.Open();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            testClass testCl = new testClass();
            testCl.Mess("test");
            Console.WriteLine(x.Ext());
            Console.WriteLine("Test2");
            Console.ReadKey();
        }
    }
}
