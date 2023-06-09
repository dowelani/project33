﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    public class BTNode
    {
        private Object Value;
        private BTNode Left;
        private BTNode Right;
        private BTNode Parent;

        // Code the following 6 methods

        public bool isLeft()
        {
            return Parent.left() == this;
        }

        public bool isRight()
        {
            return Parent.right() == this;
        }

        public bool leafNode()
        {
            return ((Left == null) && (Right == null));
        }

        public bool isRoot()
        {
            return Parent == null;
        }

        public bool internalNode()
        {
            return ((Left != null) || (Right != null));
        }

        public bool fullNode()
        {
            return ((Left != null) && (Right != null));
        }

        // NO MODIFICATIONS TO BE MADE TO METHODS BELOW

        public BTNode()
        {
            Value = null;
            Left = null;
            Right = null;
            Parent = null;
        }

        public BTNode(Object Data)
        {
            Value = Data;
            Left = null;
            Right = null;
            Parent = null;
        }

        public BTNode(Object Data, BTNode L, BTNode R, BTNode P)
        {
            Value = Data;
            setLeft(L);
            setRight(R);
            Parent = P;
        }

        public BTNode left()
        {
            return Left;
        }

        public BTNode right()
        {
            return Right;
        }

        public BTNode parent()
        {
            return Parent;
        }

        public void setLeft(BTNode newLeft)
        {
            Left = newLeft;
            if (newLeft != null)
                newLeft.setParent(this);
        }

        public void setRight(BTNode newRight)
        {
            Right = newRight;
            if (newRight != null)
                newRight.setParent(this);
        }

        public void setParent(BTNode newParent)
        {
            Parent = newParent;
        }

        public Object value()
        {
            return Value;
        }

        public void setValue(Object Data)
        {
            Value = Data;
        }

        public BTNode clear()
        {
            return null;
        }
    }
}