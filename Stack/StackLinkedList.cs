  public class Node {

       public int data;
       public Node nxt;
       public Node(int data) {
            this.data = data;
            nxt = null;
        }

    }
    internal class StackLinkedList
    {
        Node top;
      public StackLinkedList(){
            top=null;
         }
        public bool Is_empty() { 
        return top==null;
        }
        public void push(int data) {
            Node tmp=new Node(data);
            tmp.nxt = top;
            top=tmp;
        }
        public void pop() {
            if (Is_empty()) {
                Console.WriteLine("Stack Is Empty");
                return;
            }
            top = top.nxt;
        }
        public int Top() {

            if (Is_empty()) {
                Console.WriteLine("Stack Is Empty");
                return int.MaxValue;
            }
            return top.data;
        }
    }
