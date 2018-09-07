using System;

namespace StructureRecovery
{
    public class Function
    {
        public static double GetValue(Node tree, double[] point)
        {
            if (tree.IsList)
            {
                return point[tree.Index] * tree.Coeff;
            }

            return Calculate(GetValue(tree.Left, point), GetValue(tree.Right, point), tree.Operation, tree.Coeff);
        }

        public static double Calculate(double x, double y, Operation op, double coeff)
        {
            switch (op)
            {
                case Operation.Plus:
                    {
                        return (x + y) * coeff;
                    }
                case Operation.Multiply:
                    {
                        return x * y * coeff;
                    }
                default:
                    return 0;
            };
        }
    }
}
