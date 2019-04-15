using System;
using Visitor.src;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree root = new TreeNode()
            {
                Left = new TreeNode()
                {
                    Left = new TreeLeaf(),
                    Right = new TreeLeaf(),
                },
                Right = new TreeLeaf()
            };

            DepthTreeVisitor visitor = new DepthTreeVisitor();

            root.Accept(visitor);

            Console.WriteLine("Suma wartości na drzewie to {0}", visitor.Depth);
            Console.ReadLine(); ;
        }
    }
}
