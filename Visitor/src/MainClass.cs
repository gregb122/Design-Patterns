using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.src
{
    public abstract class Tree
    {
        public int Depth { get; set; } = 1;

        public virtual void Accept(TreeVisitor visitor)
        {

        }
    }

    public class TreeNode : Tree
    {

        public Tree Left { get; set; }
        public Tree Right { get; set; }

        public override void Accept(TreeVisitor visitor)
        {
            visitor.VisitNode(this);

            if (Left != null)
                Left.Accept(visitor);
            if (Right != null)
                Right.Accept(visitor);
        }
    }

    public class TreeLeaf : Tree
    {

        public override void Accept(TreeVisitor visitor)
        {
            visitor.VisitLeaf(this);
        }
    }

    public abstract class TreeVisitor
    {
        public abstract void VisitNode(TreeNode node);
        public abstract void VisitLeaf(TreeLeaf leaf);
    }

    public class DepthTreeVisitor : TreeVisitor
    {
        public int Depth { get; set; } = 0;

        public override void VisitNode(TreeNode node)
        {
            if (node.Left.Depth > node.Right.Depth)
            {
                node.Depth += node.Left.Depth;
            }
            else
            {
                node.Depth += node.Right.Depth;
            }
        }

        public override void VisitLeaf(TreeLeaf leaf)
        {
            this.Depth += leaf.Depth;
        }
    }
}
