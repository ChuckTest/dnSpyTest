﻿using System;

namespace dnSpyTest
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Hello world");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
