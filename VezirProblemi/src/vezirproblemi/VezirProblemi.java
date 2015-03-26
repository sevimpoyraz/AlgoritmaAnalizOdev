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
public class VezirProblemi {

   private static int a;
    private static int a1;
    private static int a2;
    private static int a3;
    private static int a4;
    private static int a5;
    private static int a6;
    private static int a7;
    public static int[][] tahta={{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0}};

    public static void create(){
        for (int k=0;k<8;k++){
            Random rnd = new Random();
            int sayi=rnd.nextInt(8);
            tahta[sayi][k]=1;
        }
        for (int i=0;i<8;i++){
            for(int j=0;j<8;j++){
                System.out.print(tahta[i][j]+"  ");
            }
            System.out.println("");
        }
       
    }
    

    public static void main(String[] args) {
       create();
        conficts();
        int N = 8;
        VezirProblemiRecursive.enumerate(N);
        
    }
    

    public static void conficts() {
        for (int i=0;i<8;i++){
            for (int j=0;j<8;j++){
                if (tahta[j][i]==1){
                    sol(j,i);
                    solUst(j,i);
                    Ust(j,i);
                    sagUst(j,i);
                    sag(j,i);
                    sagAlt(j,i);
                    Alt(j,i);
                    solAlt(j,i);
                } 
            }
        }
        System.out.println(a+a1+a2+a3+a4+a5+a6+a7+" adet çakışma var.");
    }
    private static void sol(int y,int x) {
        while(x>0){
            x--;
            if(tahta[y][x]==1){
                a++;
            }
        }
    }
    private static void solUst(int y,int x) {
        while(y>0 && x>0){
            x--;
            y--;
            if(tahta[y][x]==1){
                a1++;
            }
        }
    }
    
     private static void Ust(int y,int x) {
        while(y>0){
            y--;
            if(tahta[y][x]==1){
                a2++;
            }
        }
    }
     
     private static void sagUst(int y,int x) {
        while(y>0 && x<7){
            x++;
            y--;
            if(tahta[y][x]==1){
                a3++;
            }
        }
    }
     
     private static void sag(int y,int x) {
        while(x<7){
            x++;
            if(tahta[y][x]==1){
                a4++;
            }
        }
    }
     
     private static void sagAlt(int y,int x) {
        while(y<7 && x<7){
            x++;
            y++;
            if(tahta[y][x]==1){
                a5++;
            }
        }
        
    }
     
     private static void Alt(int y,int x) {
        while(y<7){
            y++;
            if(tahta[y][x]==1){
                a6++;
            }
        }
    }
     
     private static void solAlt(int y,int x) {
        while(y<7 && x>0){
            x--;
            y++;
            if(tahta[y][x]==1){
                a7++;
            }
        }
    }
    
}

    

