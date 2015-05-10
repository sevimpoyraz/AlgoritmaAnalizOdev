/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package maxsumtest;

/**
 *
 * @author poyraz
 */
public class MaxSumTest {

    
    static private int seqStart = 0;
    static private int seqEnd = -1;
    
    public static void main(String[] args) {
        // TODO code application logic here
        
        int array[ ] = { 4, -3, 5, -2, -1, 2, 6, -2 };
       int maxSum;


        maxSum = maxSubSum( array );
        
        System.out.println("maxSum = "+maxSum);
        for(int s=seqStart;s<=seqEnd;s++){
            System.out.print("a["+s+"] ");
        }
        
    }
      public static int maxSubSum( int [ ] array )
    {
        int maxSum = 0;

        for( int i = 0; i < array.length; i++ )
            for( int j = i; j < array.length; j++ )
            {
                int thisSum = 0;

                for( int k = i; k <= j; k++ )
                    thisSum += array[ k ];
                   
                       
                       System.out.println("toplam: "+thisSum);

                if( thisSum > maxSum )
                {
                    maxSum   = thisSum;
                    seqStart = i;
                    seqEnd   = j;
                }
            }

        return maxSum;
    }
}