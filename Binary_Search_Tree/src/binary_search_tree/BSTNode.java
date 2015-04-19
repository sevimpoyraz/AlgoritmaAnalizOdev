/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package binary_search_tree;

/**
 *
 * @author poyraz
 */
class BSTNode {
    
    BSTNode left, right;
    int data;

    /* Constructor */
    public BSTNode() {
        left = null;
        right = null;
        data = 0;
    }
    /* Constructor */

    public BSTNode(int n) {
        left = null;
        right = null;
        data = n;
    }
    /* Sol dügüm için */

    public void setLeft(BSTNode n) {
        left = n;
    }
    /* Sag dügüm için */

    public void setRight(BSTNode n) {
        right = n;
    }
    /* Sol Dügüm almak için  */

    public BSTNode getLeft() {
        return left;
    }
    /* Sag dügüm almak için */

    public BSTNode getRight() {
        return right;
    }
    /* Verileri ayarlamak için */

    public void setData(int d) {
        data = d;
    }
    /* Verileri almak için */

    public int getData() {
        return data;
    }

}
