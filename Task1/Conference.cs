using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Conference
    {
        public BTNode ConfDelegates = null;

        //public void buildTreeTopDown()
        //{

        //    ConfDelegate Del12 = new ConfDelegate(12, "Del12", "Subj12", 1000, true);
        //    ConfDelegate Del34 = new ConfDelegate(34, "Del34", "Subj34", 2000, true);
        //    ConfDelegate Del17 = new ConfDelegate(17, "Del17", "Subj17", 3000, true);
        //    ConfDelegate Del23 = new ConfDelegate(23, "Del23", "Subj23", 4000, true);
        //    ConfDelegate Del11 = new ConfDelegate(11, "Del11", "Subj11", 5000, true);
        //    ConfDelegate Del22 = new ConfDelegate(22, "Del22", "Subj22", 6000, true);
        //    ConfDelegates = new BTNode(Del23);
        //    BTNode Subtree17 = new BTNode(Del17);
        //    ConfDelegates.setLeft(Subtree17);
        //    BTNode Subtree11 = new BTNode(Del11);
        //    ConfDelegates.setRight(Subtree11);
        //    BTNode Subtree12 = new BTNode(Del12);
        //    BTNode Subtree34 = new BTNode(Del34);
        //    Subtree17.setLeft(Subtree12);
        //    Subtree17.setRight(Subtree34);
        //    Subtree34.setParent(Subtree17);
        //    Subtree12.setParent(Subtree17);
        //    BTNode Subtree22 = new BTNode(Del22);
        //    Subtree11.setRight(Subtree22);
        //    Subtree22.setParent(Subtree11);



        //}
 

        public void buildTreeTopDown()
        {
            ConfDelegates = new BTNode(new ConfDelegate(19, "Del19", "Subj19", 1250, true), new BTNode(new ConfDelegate(12, "Del12", "Subj12", 1999, true), new BTNode(new ConfDelegate(11, "Del11", "Subj11", 1020, true), new BTNode(new ConfDelegate(5, "Del5", "Subj5", 1717, true)), null, null), new BTNode(new ConfDelegate(7, "Del7", "Subj7", 1115, true)), null), new BTNode(new ConfDelegate(37, "Del37", "Subj37", 556, true), null, new BTNode(new ConfDelegate(3, "Del03", "Subj03", 2256, true), new BTNode(new ConfDelegate(2, "Del02", "Subj02", 999, true), null, new BTNode(new ConfDelegate(1, "Del01", "Subj01", 99, true), null, null, null), null), null, null), null), null);
            setParents(ConfDelegates);
        }

        private void setParents(BTNode T)
        {
            if (T != null)
            {
                if (T.left() != null)
                {
                    T.left().setParent(T);
                    setParents(T.left());
                }
                if (T.right() != null)
                {
                    T.right().setParent(T);
                    setParents(T.right());
                }
            }
        }


        public int noConfDelegates()
        /* pre:  Have list of conference delegates (ConfDelegates) stored as a binary tree, 
         *       which may be empty.
         * post: Determine and return the number of conference delegates in the list. */
        {
            int c = 0;
            docount(ConfDelegates, ref c);
            return c;
        }
        private void docount(BTNode T,ref int c)
        {
            if (T != null)
            {
                c = c + 1;
                docount(T.left(),ref c);
                docount(T.right(),ref c);
            }
        }

        public double avgAmntDue()
        /* pre:  Have list of conference delegates (ConfDelegates) stored as a binary tree, 
         *       which may be empty.
         * post: Determine and return the average amount due by a conference delegate. */
        {
            double amt = 0;
            doamount(ConfDelegates, ref amt);
            return (amt / noConfDelegates());
        }
        private void doamount(BTNode T, ref double amt)
        {
            if (T != null)
            {
                ConfDelegate cur = (ConfDelegate)T.value();
                amt = amt + cur.Due;
                doamount(T.left(), ref amt);
                doamount(T.right(), ref amt);
            }
        }

        // NO CHANGES REQUIRED TO CODE BELOW


        public void displayTree()
        /* pre:  Have list of conference delegates (ConfDelegates) stored as a binary tree, 
         *       which may be empty.
         * post: Display the details for each conference delegate in the list. */
        {
            display(ConfDelegates);
        }

        private void display(BTNode T)
        {
            if (T != null)
            {
                ConfDelegate cur = (ConfDelegate)T.value();
                cur.display();
                display(T.left());
                display(T.right());
            }
        }

        public void displayTreeStructure()
        // with thanks to Minnaar Fullard (WRA202 Class of 2014)
        // adapted from Will's answer at http://stackoverflow.com/questions/1649027/how-do-i-print-out-a-tree-structure
        {
            if (ConfDelegates != null)
                PrintPretty(ConfDelegates, "", false);
        }

        public void PrintPretty(BTNode node, String indent, bool rightChild)
        {
            String output = Convert.ToString(((ConfDelegate)node.value()).DelID);
            if (!(node.parent() == null))  // node is not root
            {
                if (node.parent().left() == node)  // node is left child
                    output += " ~l";
                else
                    output += " ~r";
            }
            Console.Write(indent);
            if (rightChild)
            {
                Console.Write(" /--");
                indent += " | ";
            }
            else
                if (!(node.parent() == null))
                {
                    Console.Write(" \\--");
                    indent += "   ";
                }
            Console.WriteLine("{0}", output);
            if (node.left() != null && node.right() != null)
            {
                PrintPretty(node.right(), indent, true);
                PrintPretty(node.left(), indent, false);
            }
            else if (node.left() != null)
            {
                PrintPretty(node.left(), indent, true);
            }
            else if (node.right() != null)
            {
                PrintPretty(node.right(), indent, true);
            }
        }
    }
}

