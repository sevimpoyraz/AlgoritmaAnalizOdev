

package binarysearchtree;

/**
 *
 * @author poyraz
 */
public class  BST {
    private Object root;
    private int comparation;
     public BST() {
        root = null;
    }
    /* Agac boş mu kontrolü */

    public boolean isEmpty() {
        return root == null;
    }
    /* veri eklemek için */

    public void insert(int data) {
        root = insert((BSTNode) root, data);
    }
    /* Recursive olarak veri ekleme */

    private BSTNode insert(BSTNode node, int data) {

        if (node == null) {
            node = new BSTNode(data);
        } else {

            if (data <= node.getData()) {
                node.left = insert(node.left, data);
            } else {
                node.right = insert(node.right, data);
            }

        }

        return node;

    }
    /* Veri silmek için */

    public void delete(int k) {
        if (isEmpty()) {
            System.out.println("Empty!!!!");
             System.out.println("Comparation count = "+comparation);
        } else if (search(k) == false) {
            System.out.println("Bu sayi " + k + " mevcut değil");
             System.out.println("Comparation count = "+comparation);
        } else {
            root = delete((BSTNode) root, k);
            System.out.println(k + " Delete");
            System.out.println("Comparation count = "+comparation);
        }
    }

    private BSTNode delete(BSTNode root, int k) {
        BSTNode p, p2, n;
        if (root.getData() == k) {
            BSTNode lt, rt;
            lt = root.getLeft();
            rt = root.getRight();
            if (lt == null && rt == null) {
                return null;
            } else if (lt == null) {
                p = rt;
                return p;
            } else if (rt == null) {
                p = lt;
                return p;
            } else {
                p2 = rt;
                p = rt;
                while (p.getLeft() != null) {
                    p = p.getLeft();
                }
                p.setLeft(lt);
                return p2;
            }
        }
        if (k < root.getData()) {
            n = delete(root.getLeft(), k);
            root.setLeft(n);
        } else {
            n = delete(root.getRight(), k);
            root.setRight(n);
        }
        return root;
    }
    /* Dugumlerin sayısını saymak için */

    public int countNodes() {
        return countNodes((BSTNode) root);
    }
    /* Recursive olarak dugumlerin sayısını saymak için */

    private int countNodes(BSTNode r) {
        if (r == null) {
            return 0;
        } else {
            int l = 1;
            l += countNodes(r.getLeft());
            l += countNodes(r.getRight());
            return l;
        }
    }
    /* Bir eleman aramak için */

    public boolean search(int val) {
        return search((BSTNode) root, val);
    }
    /* Bir elemanı recursive olarak aramak için */

    private boolean search(BSTNode r, int val) {
        boolean found = false;
       
        while ((r != null) && !found) {
            int rval = r.getData();
            if (val < rval) {
                r = r.getLeft();
            } else if (val > rval) {
                r = r.getRight();
            } else {
                found = true;
                break;
            }
            found = search(r, val);
           comparation++;
        }
        
        return found;
        
    }
    
    /* Agacı sıralı bir sekilde aramak için */

    public void inorder() {
        inorder((BSTNode) root);
    }

    private void inorder(BSTNode r) {
        if (r != null) {
            inorder(r.getLeft());
            System.out.print(r.getData() + " ");
            inorder(r.getRight());
        }
    }
    /* Function for preorder traversal */

    public void preorder() {
        preorder((BSTNode) root);
    }

    private void preorder(BSTNode r) {
        if (r != null) {
            System.out.print(r.getData() + " ");
            preorder(r.getLeft());
            preorder(r.getRight());
        }
    }
    /* Function for postorder traversal */

    public void postorder() {
        postorder((BSTNode) root);
    }

    private void postorder(BSTNode r) {
        if (r != null) {
            postorder(r.getLeft());
            postorder(r.getRight());
            System.out.print(r.getData() + " ");
        }
    }
}
