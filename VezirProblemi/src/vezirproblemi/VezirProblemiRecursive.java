/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package vezirproblemi;

import java.util.Random;

/**
 *
 * @author poyraz
 */
class VezirProblemiRecursive {
     public static boolean isConsistent(int[] q, int n) {
        for (int i = 0; i < n; i++) {
            if (q[i] == q[n])             return false;   // same column
            if ((q[i] - q[n]) == (n - i)) return false;   // same major diagonal
            if ((q[n] - q[i]) == (n - i)) return false;   // same minor diagonal
        }
        return true;
    }

    public static void printQueens(int[] q) {
        int N = q.length;
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                if (q[i] == j) System.out.print("Q ");
                else           System.out.print("* ");
            }
            System.out.println();
        }  
        System.out.println();
    }

    public static void enumerate(int N) {
        int[] a = new int[N];
        enumerate(a, 0);
    }

    public static void enumerate(int[] q, int n) {
        int N = q.length;
        if (n == N) printQueens(q);
        else {
            for (int i = 0; i < N; i++) {
                if (n==0){
                    Random rnd = new Random();
                    int sayi = rnd.nextInt(8);
                    q[n] = sayi;
                    if (isConsistent(q, n)) enumerate(q, n+1);
                } else {
                q[n] = i;
                if (isConsistent(q, n)) enumerate(q, n+1);
                }
            }
        }
    }  

}
