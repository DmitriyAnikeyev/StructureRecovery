using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StructureRecovery;

namespace StructureRecoveryBasicRun
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new Node(true, 0, Operation.Undefined);
            var list2 = new Node(true, 0, Operation.Undefined);
            var list3 = new Node(true, 0, Operation.Undefined);
            var list4 = new Node(true, 1, Operation.Undefined);
            var sq = new Node(false, 0, Operation.Multiply, list1, list2, 0.5);
            var qub = new Node(false, 0, Operation.Multiply, list3, sq, 1);
            var res = new Node(false, 0, Operation.Plus, qub, list4, 1);
            var point = new double[2] { 3, 1 };
            Console.WriteLine(Function.GetValue(res, point));
            Console.ReadLine();
        }
    }
}
