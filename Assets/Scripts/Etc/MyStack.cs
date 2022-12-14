using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStack
{
    public int Count = 0;
    public int[] number;

    public MyStack(int size)
    {
        number = new int[size];       
    }

    public void Push(int data)
    {   
        if(Count<number.Length)
        {
            number[Count++] = data;
            //Count++;
        }
        else if (Count >= number.Length)
        {
            Debug.LogWarning("Stack Overflow라 추가합니다");
            ExPush(data);
        }
    }

    public void ExPush(int data)
    {
        int[] instantNum = new int[Count+1];
        for (int i = 0; i < Count; i++)
        {
            instantNum[i] = number[i];
        }
        number = instantNum;
        number[Count] = data;
        Count ++;
    }

    public int Pop()
    {
        int p=0;
        if (Count>0)
        {
            p = number[--Count];
            number[Count] = 0;
            
            
        }
        else if (Count<=0)
        {
            Debug.LogError("Stack is Empty!!");
            Debug.Log($"현재 스택 카운트 = {Count}");
        }

        return p;     
        
    }

    public int Peek()
    {
        int p = 0;
        if (Count > 0)
        {
            p = number[--Count];
                       
        }
        else if (Count <= 0)
        {
            Debug.LogError("Stack is Empty!!");
            Debug.Log($"현재 스택 카운트 = {Count}");
        }

        return p;

    }

    public void Clear()
    {
        for (int i = 0; i < number.Length; i++)
        {
            number[i] = 0;
        }
        Count = 0;
    }

}
