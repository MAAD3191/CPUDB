using System;
using CPUDB.Model;
using CPUDB.View;
namespace CPUDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPUContext context = new CPUContext();
            Display display = new Display(context);
        }
    }
}
