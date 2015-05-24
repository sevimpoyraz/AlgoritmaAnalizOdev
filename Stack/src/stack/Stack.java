/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package stack;

import java.util.*;

/**
 *
 * @author poyraz
 */
public class Stack {

    static void showpush(java.util.Stack stack, int boyut) {
        stack.push(new Integer(boyut));
        System.out.println("push(" + boyut + ")");
        System.out.println("stack: " + stack);
    }

    static void showpop(java.util.Stack stack) {
        System.out.print("pop -> ");
        Integer boyut = (Integer) stack.pop();
        System.out.println(boyut);
        System.out.println("stack: " + stack);
    }

    public static void main(String args[]) {
        Random random = new Random();
        java.util.Stack stack = new java.util.Stack();
        int boyut;
        System.out.println("stack: " + stack);
        for (int i = 0; i < 10; i++) {
            boyut = random.nextInt(1000);
            showpush(stack, boyut);

        }
        showpop(stack);
    }

}
