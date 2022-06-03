using System;
using System.Collections.Generic;
using System.Text;
/*
 * Documentaion 
 * This is a Binary Tree created by Chigozie Muonagolu
 * This Binary Trea has the following functions
 * FindSmallest()
 * FindLargest()
 * Search()
 * Insert()
 * An InOrderTraversal()

 * Methods to be later on
 * Delete()
 */
namespace MyDataStructures
{
    public class Node<T>
    {
        public T data;
        public Node<T> left;
        public Node<T> right;
        public Node<T> parent;
    }
    class BinaryTree<T> where T : IComparable
    {
        private string inOder = "";
        Node<T> found = null;

        T deleted = default(T);
        Node<T> smallest = null;
        Node<T> largest = null;
        public Node<T> FindSmallest(Node<T> root)
        {
            if (root == null)
            {
                return smallest;
            }
            else
            {
                if (root.left == null)
                {
                    smallest = root;
                }
                FindSmallest(root.left);
                return smallest;
            }
        }
        public Node<T> FindLargest(Node<T> root)
        {
            if (root == null)
            {
                return largest;
            }
            else
            {
                if (root.right == null)
                {
                    largest = root;
                }
                FindLargest(root.right);
                return largest;
            }
        }
        public Node<T> search(Node<T> root, T find)
        {
            if (root == null)
            {
                return found;
            }
            else if (root.data.Equals(find))
            {
                found = root;
            }
            else
            {
                search(root.left, find);
                search(root.right, find);
            }
            return found;
        }
        public Node<T> insert(Node<T> root, T data)
        {
            if (root == null)
            {
                root = new Node<T>();
                root.data = data;
            }
            //If the data is greater than root
            else if (root.data.CompareTo(data) > 0)
            {
                root.left = insert(root.left, data);
                root.left.parent = root;
            }
            //Else if it is greater
            else
            {
                root.right = insert(root.right, data);
                root.right.parent = root;
            }
            return root;
        }
        public string inOderTravseral(Node<T> root)
        {
            if (root == null)
            {
                return default(string);
            }
            else
            {
                inOderTravseral(root.left);
                inOder += root.data.ToString() + "\n";
                inOderTravseral(root.right);
            }
            return inOder;
        }

        //Fix this
        public Node<T> delete(Node<T> root, T find)
        {

            //Case 1 node to delete is head


            //Case 2 node to delete has only right child
            //Case 3 node to delete only has left child
            //Case 4 node to delete has no children
            return root;
        }

    }
}
