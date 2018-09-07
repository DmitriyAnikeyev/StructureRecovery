using System;
using System.Collections.Generic;
using System.Text;

namespace StructureRecovery
{

    public class Node
    {
        public bool IsList;
        public Node Left;
        public Node Right;
        public Operation Operation;
        public double Coeff;
        public int Index;

        public Node(bool isList = false, int index = 0, Operation operation = Operation.Undefined, Node left = null, Node right = null, double coeff = 1)
        {
            IsList = isList;
            Operation = operation;
            Index = index;
            Left = left;
            Right = right;
            Coeff = coeff;
        }
    }

    public class Tree
    {
        Node Root;
    }
}
