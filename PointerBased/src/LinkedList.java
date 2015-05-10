/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author poyraz
 */
public class LinkedList {
    static Node head, tail;
    
    public void add(int index){
        Node newNode = new Node();
        
        if(head==null){
            head= newNode;
            tail=newNode;
            
        }else{
            tail.next= newNode;
            tail= newNode;
        }
        
    }
    public void removeQueue(){
        Node temp,previous;
        temp=head;
        
        if(temp==null){
            System.out.println("Empty!!!");
        }else{
            System.out.println("number issued: "+head.data);
        }

    }
    public void removeStack(){
        Node temp,previous;
        temp=head;
        previous=temp;
        
        if(temp==null){
            System.out.println("Empty!!!");
        }else{
            temp= temp.next;
            while(temp.next != null){
                previous = temp;
                temp= temp.next;
            }
            System.out.println("number issued :" + temp.data);
            tail = previous;
            tail.next = null;

        }
      
    }
     public void listele() {
        Node temp = head;
        while (temp != null) {
            System.out.print(temp.data + "-");

            temp = temp.next;

        }
        System.out.println("");
   
}
      public void find(int sayi) {
        Node temp = head;
        while (temp.next != null) {
            if (temp.data == sayi) {
                System.out.println("The current number sought!!!");
                System.out.println("Current number =" + temp.data);
            }
            temp = temp.next;
        }
        System.out.println("Current number is not found!!!");
    }
       public void indexAccesss(int indexNumber) {
        Node temp = head;
        int i = 1;
        while (temp.next!= null) {

            if (i == indexNumber) {
                System.out.println("Current number = " + temp.data);
                break;
            }
            i++;
            temp = temp.next;
            if (temp.next == null) {
                System.out.println("list length exceeded !");
            }
        }
       }
}