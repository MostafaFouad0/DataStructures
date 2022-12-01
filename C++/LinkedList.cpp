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
}
