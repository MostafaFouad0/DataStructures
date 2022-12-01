#include<bits/stdc++.h>

using namespace std;


class Node {
public:
    int data;
    Node *nxt;
public:
    Node(int data) {
        this->data = data;
        nxt = NULL;
    }
};

class LinkedList {
    int c{};
    Node *head = NULL;
public:
    void add_end(int data) {
        Node *tmp = new Node(data);
        if (head == NULL) {
            head = tmp;
            c++;
            return;
        }
        Node *runner = head;
        while (runner->nxt != NULL) {
            runner = runner->nxt;
        }
        runner->nxt = tmp;
        c++;
    }

    void add_First(int data) {
        Node *tmp = new Node(data);
        if (head == NULL) {
            head = tmp;
            c++;
            return;
        }
        tmp->nxt = head;
        head = tmp;
        c++;
    }

    int Get_length() {
        return c;
    }

    bool is_valid_position(int pos) {
        return pos >= 0 and pos < c;
    }

    void add_at(int pos, int data) {
        pos--;
        if (pos + 1 == c) {
            add_end(data);
            return;
        }
        if (pos == 0) {
            add_First(data);
            return;
        }
        if (!is_valid_position(pos)) {
            return;
        }
        Node *q = head;
        Node *tmp = new Node(data);
        int run{};
        while (run != pos) {
            q = q->nxt;
            run++;
        }
        tmp->nxt = q->nxt;
        q->nxt = tmp;
        c++;
    }

    void print() {
        Node *q = head;
        while (q != NULL) {
            cout << q->data << " ";
            q = q->nxt;
        }
    }

    void reverse() {
        Node *start = NULL;
        Node *now;
        Node *nxt;
        now = head;
        while (now != NULL) {
            nxt = now->nxt;
            now->nxt = start;
            start = now;
            now = nxt;
        }
        head = start;
    }
    void delete_last(){
        ///O(N)
        if(head==NULL){
            return;
        }
        Node *q=head;
        while (q->nxt->nxt!=NULL){
            q=q->nxt;
        }
        c--;
        q->nxt=NULL;
    }
     void delete_first(){
        if(head==NULL){
            return;
        }
        head=head->nxt;
        c--;
    }
    void delete_at(int pos){
        pos--;
        if(pos==0){
            delete_first();
            return;
        }
        if(pos+1==c){
            delete_last();
            return;
        }
        if(!is_valid_position(pos)){
            return;
        }
        Node *q=head;
        for (int i = 0; i < pos-1; ++i) {
            q=q->nxt;
        }
        q->nxt=q->nxt->nxt;
    }
    int search(int value){
        ///O(N)
        if(head==NULL){
            return INT_MIN;
        }
        int pos{};
        Node *q=head;
        while (q!=NULL){
            if(q->data==value){
                return pos;
            }
            pos++;
            q=q->nxt;
        }
        return INT_MIN;
    }
};

int main() {
    LinkedList ll;
    ll.add_end(2);
    ll.add_end(4);
    ll.add_First(3);
    cout << ll.Get_length() << "\n";
    ll.add_at(2, 30);
    ll.add_at(5, 30);
    ll.print();
    cout << "\n";
    ll.reverse();
    ll.print();
    cout<<"\n";
    ll.delete_last();
    ll.print();
    cout<<"\n";
    ll.delete_first();
    ll.print();
    cout<<"\n";
    ll.add_end(40);
    ll.add_end(403);
    ll.delete_at(2);
    ll.print();
    cout<<ll.search(40);

}
