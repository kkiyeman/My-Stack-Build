using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStackTest : MonoBehaviour
{

    public MyStack mystack;
    
    void Start()
    {
        mystack = new MyStack(5);
        mystack.Push(1);
        Debug.Log(mystack.number[0]);
        mystack.Push(2);
        Debug.Log(mystack.number[1]);
        mystack.Push(3);
        Debug.Log(mystack.number[2]);
        mystack.Push(4);
        Debug.Log(mystack.number[3]);
        mystack.Push(5);
        Debug.Log(mystack.number[4]);
        mystack.Push(34264);
        Debug.Log(mystack.number[5]);   
        Debug.Log("---------------Push ��--------------");       
        Debug.Log($"���� ���� ī��Ʈ = {mystack.Count}");
        
        for (int i = 0; i < mystack.number.Length; i++)
        {
            Debug.Log($"{i+1}��° POP = {mystack.Pop()}");
            Debug.Log($"{mystack.Count+1}��° �� ����Ȯ�� = {mystack.number[mystack.Count]}");
            Debug.Log($"���� ���� ī��Ʈ = {mystack.Count}");
        }
        mystack.Pop();

        Debug.Log("---------------Pop ��--------------");
        mystack.Clear();
        Debug.Log("Clear �Ϸ� = ���� 0����");
        for (int i = 0; i < mystack.number.Length; i++)
        {
            Debug.Log(mystack.number[i]);
        }
        Debug.Log(mystack.Count);
    }


}
