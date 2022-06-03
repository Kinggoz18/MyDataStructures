using System;
using System.Collections.Generic;
using System.Text;

//Priority Array List
class MyArrayList<T> where T : IComparable
{
    T[] array;
    int count = 0;
    public MyArrayList(int size)
    {
        array = new T[size];
    }
    //Grows the size of my ArrayList
    private void grow()
    {
        T[] newArray = new T[array.Length * 2];
        for (int i = 0; i < count; i++) 
        {
            newArray[i] = array[i];
        }
        array = newArray;
    }
    //Adds element to the back of the array
    private void AddBack(T value)
    {
        array[count] = value;
        count += 1;
    }
    //Adds element to the front of the array
    private void AddFront(T value)
    {
        if (count >= array.Length - 1)
        {
            grow();
        }
        int size = count - 1;
        for (int i = size; i > 0; i++)
        {
            array[i] = array[i - 1];
        }
        array[0] = value;
        count += 1;
    }
    private void insert(T value)
    {

    }
    public void Add(T Value)
    {
        if (count >= array.Length - 1)
        {
            grow();
        }

        if (count==0)
        {
            array[0] = Value;
        }
        else
        {
            array[count] = Value;
            //If the new index in the array is greater
            if (array[0].CompareTo(array[count]) > 0)
            {
                AddFront(Value);
            }
            else if(array[count-1].CompareTo(array[count])<=0)
            {
                AddBack(Value);
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if(array[i].CompareTo(array[count])<=0)
                    {
                        insert(Value);
                        break;
                    }
                }
            }
        }
    }
}
