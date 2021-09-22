using System;
using NLog;

namespace CSharpDependabotTest
{
    public class Program{
        public static void Main(string[] args){
            LogManager.GetCurrentClassLogger().Info("Hey");
            Console.WriteLine("hey");
        }
    }
}