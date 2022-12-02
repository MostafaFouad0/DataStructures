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
class Stack{
    Node<T> *head;
    int size;
public:
    Stack(){
        head=NULL;
        size=0;
    }
    bool is_empty(){
        return head==NULL;
    }
    void push(T val){
        Node<T> *tmp=new Node(val);
        if(is_empty()){
            head=tmp;
            size++;
            return;
        }
        tmp->nxt=head;
        head=tmp;
        size++;
    }
    void pop(){
        if(is_empty()){
            return;
        }
        size--;
        head=head->nxt;
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
    int peek(){
        if(is_empty()){
            return INT_MIN;
        }
        return head->data;
    }
    int Size(){
        return size;
    }

};


int main() {
    Stack<char> st=Stack<char>();
    st.push('A');
    st.push('B');
    st.push('C');
    st.print();
    st.pop();
    st.push('D');
    st.print();
    cout<<st.Size();
}



