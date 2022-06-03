using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataStructures
{
    class program
    {
        public static void Main()
        {
            string[] name = { "Lebron", "Jodarn", "Bill", "Kobe", "Kyrie", "Curry", "Melo", "Elon", "Kanye", "Giannis", "Iverson", "Durant", "Jeff" };
            int size = name.Length;
            EmployeeGenerator[] employees = new EmployeeGenerator[size];

            Node<EmployeeGenerator> root = null;
            BinaryTree<EmployeeGenerator> bst = new BinaryTree<EmployeeGenerator>();
            Random rnd = new Random();
            //Generates Employees
            for (int i = 0; i < size; i++)
            {
                employees[i] = new EmployeeGenerator();
                employees[i].Priority = rnd.Next(0, size * 2);
                employees[i].Name = name[i];
            }
            //-------------------------------------- TEST FOR BINARY SEARCH TREE --------------------------------------//
            //Inserts Employee objects into the Binary Tree
            for (int i=0; i<size; i++)
            {
                root = bst.insert(root, employees[i]);
            }

            EmployeeGenerator emp = new EmployeeGenerator();
            emp.Name = "Chigozie";
            emp.Priority = 99;
            Console.WriteLine("Root before deleting: ");
            Console.WriteLine(bst.inOderTravseral(root));
            root = bst.delete(root, employees[0]);
            Console.WriteLine("Root after deleting: ");
            Console.WriteLine(bst.inOderTravseral(root));

            //-------------------------------------- TEST FOR ARRAYLIST --------------------------------------//
            MyArrayList<EmployeeGenerator> testArrayList = new MyArrayList<EmployeeGenerator>(10);

            for (int i = 0; i < size; i++)
            {
                testArrayList.Add(new EmployeeGenerator());
            }

            //-------------------------------------- TEST FOR LINKEDLIST --------------------------------------//

            LinkedList<EmployeeGenerator> myLinkedList = new LinkedList<EmployeeGenerator>();

            myLinkedList.Add(employees[1]);
            myLinkedList.Add(employees[0]);
            myLinkedList.Add(employees[3]);
            myLinkedList.Add(employees[2]);
            myLinkedList.Add(employees[7]);

            myLinkedList.printList();
        }

    }
}
