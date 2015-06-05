using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinavSorusu5
{
    class Program
    {

        public class Node
        {
            int  val;
            Node left;
            Node right;
  
            public static Node root { get; set; }}

       public  static search (Node n){
            Node p=null;
            Node node=root;
            while (node!=null){
                if(node!=null){
                    if(node.val>n.val){
                        p=node;
                        node=node.left;
                    }else if(node.val<n.val){
                        p=node;
                        node=node.right;
                    }
                    else {
                        return node;
                    }

                }
            }
        }




        static void Main(string[] args)
        {
            int val;
            Node left;
            Node right;
        }
    
public static Node root { get; set; }}
}


