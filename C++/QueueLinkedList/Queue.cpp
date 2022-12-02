#include<bits/stdc++.h>

using namespace std;

template<class T>
class Node{
public:
    T data;
    Node *nxt;
    Node(T data){
        this->data=data;
        nxt=NULL;
    }
};
template<class T>
class Queue{
    Node<T> *head;
    int size;
public:
    Queue(){
        head=NULL;
        size=0;
    }
    bool is_empty(){
        return head==NULL;
    }
    void enqueue(T val){
        //o(N)
        Node<T> *tmp=new Node(val);
        if(is_empty()){
            head=tmp;
            size++;
            return;
        }
        Node<T> *q=head;
        while(q->nxt!=NULL){
            q=q->nxt;
        }
        size++;
        q->nxt=tmp;
    }
    void dequeue(){
        //O(1)
        if(is_empty()){
            return;
        }
        head=head->nxt;
        size--;
    }
    int Size(){
        return size;
    }
    void print(){
        if(is_empty()){
            return;
        }
        Node<T> *q=head;
        while (q!=NULL){
            cout<<q->data<<" ";
            q=q->nxt;
        }
        cout<<"\n";
    }
};


int main() {
    Queue<char> q=Queue<char>();
    q.enqueue('A');
    q.enqueue('B');
    q.enqueue('C');
    q.print();
    q.dequeue();
    q.print();
}



