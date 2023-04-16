namespace Projectile_Motion___Final_Year
{
    class ListOfQuestions
    {
        public  Node Head;
        public  Node Tail;
        public  Node Current;

        public  void Add(Question thisQues)
        {
            Node tempN = new Node();
            tempN.ThisQuestion = thisQues;

            if(Head == null)
            {
                Head = tempN;
                Tail = tempN;
            }
            else
            {
                Tail.Right = tempN;
                tempN.Left = Tail;
                Tail = Tail.Right;
            }
        }// links new node 
        public void Reset()
        {
            Current = Head;
        }// goes back to head
        public void Next()
        {
            if(Current.Right != null)
            {
                Current = Current.Right;
            }
        }// go ti next node
        public void Previous()
        {
            if (Current.Left != null)
            {
                Current = Current.Left;
            }

        }//go to previous node

    }


}
