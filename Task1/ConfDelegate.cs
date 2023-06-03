using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task1
{
    class ConfDelegate
    {
        public int DelID;       // unique identifier
        public String DName;
        public String Subj;
        public double Due;
        public bool Presenter;

        public ConfDelegate(int D, String N, String Sub, double Cost, bool P)
        {
            DelID = D;
            DName = N;
            Subj = Sub;
            Due = Cost;
            Presenter = P;
        }

        public bool Equals(ConfDelegate obj)
        {
            return this.DelID == obj.DelID;
        }

        public void processPayment(double Amnt)
        {
            Due -= Amnt;
        }


        public void display(char Pos, int ParentDelID)
        {
            Console.Write("DelID: {0} Name: {1} Subject: {2} Due: {3} ParentDelID: {4} ", DelID, DName, Subj, Due, ParentDelID);
            switch (Pos)
            {
                case 'L': Console.Write(" left"); break;
                case 'R': Console.Write(" right"); break;
            }
            if (Presenter)
                Console.WriteLine(" is presenting");
            else
                Console.WriteLine();
        }

        public void display()
        {
            Console.Write("DelID: {0} Name: {1} Subject: {2} Due: {3} ", DelID, DName, Subj, Due);
            if (Presenter)
                Console.WriteLine(" is presenting");
            else
                Console.WriteLine();
        }

        public ConfDelegate clone()
        {
            return new ConfDelegate(this.DelID, this.DName, this.Subj, this.Due, this.Presenter);
        }

        public int CompareTo(Object obj)
        {
            ConfDelegate other = (ConfDelegate)obj;
            return this.DelID - other.DelID;
        }

    }
}

