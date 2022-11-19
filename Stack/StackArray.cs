 internal class StackArray
    {
        int top;
        int[] data;
      public  StackArray(int size)
        {
            top = -1;
            data = new int[size];
        }
        public int GetSize()
        {
            return top + 1;
        }
        public bool Is_full()
        {
            return top + 1 == data.Length;
        }
        public bool Is_Empty()
        {

            return top == -1;
        }

      public  void Push(int val)
        {
            if (Is_full())
            {
                Console.WriteLine("Stack OverFlow");
                return;
            }
            data[++top] = val;
        }
       public void pop()
        {
            if (Is_Empty())
            {
                Console.WriteLine("Stack Is Empty");
                return;
            }
            --top;
        }

      public  int Top()
        {
            if (Is_Empty())
            {
                return int.MinValue;
            }
            return top;
        }
     public   void Print()
        {

            if (Is_Empty())
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            for (int i = top; i >= 0; i--)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }


    }
