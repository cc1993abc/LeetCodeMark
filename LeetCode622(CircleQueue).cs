    using System;
    using System.Collections.Generic;
    public class MyCircularQueue {
        private List<int> data {get;set;}
        private int head {get;set;}
        private int tail {get;set;}

        private int size {get;set;}
        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k) {
            data = new List<int>(k){};
            head = tail = -1;
            size = k;
        }
        
        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value) {
            if (IsFull())
            {
                return false;
            }
            if(IsEmpty()) head = 0;
            tail = (tail + 1) % size;
            data[tail] = value;
            return true;
        }
        
        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue() {
            if(IsEmpty()){
            return false;
            }
            head = (head +1) %  size;
            return true;
        }
        
        /** Get the front item from the queue. */
        public int Front() {
            if(IsEmpty()) return -1;
            return data[head];
        }
        
        /** Get the last item from the queue. */
        public int Rear() {
            if(IsEmpty()) return -1;
            return data[tail];
        }
        
        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty() {
            return head == -1;
        }
        
        /** Checks whether the circular queue is full or not. */
        public bool IsFull() {
            return (tail + 1) % size == head;
        }
    }

    /**
    * Your MyCircularQueue object will be instantiated and called as such:
    * MyCircularQueue obj = new MyCircularQueue(k);
    * bool param_1 = obj.EnQueue(value);
    * bool param_2 = obj.DeQueue();
    * int param_3 = obj.Front();
    * int param_4 = obj.Rear();
    * bool param_5 = obj.IsEmpty();
    * bool param_6 = obj.IsFull();
    */