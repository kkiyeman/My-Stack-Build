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
        Debug.Log("---------------Push 끝--------------");       
        Debug.Log($"현재 스택 카운트 = {mystack.Count}");
        
        for (int i = 0; i < mystack.number.Length; i++)
        {
            Debug.Log($"{i+1}번째 POP = {mystack.Pop()}");
            Debug.Log($"{mystack.Count+1}번째 값 삭제확인 = {mystack.number[mystack.Count]}");
            Debug.Log($"현재 스택 카운트 = {mystack.Count}");
        }
        mystack.Pop();

        Debug.Log("---------------Pop 끝--------------");
        mystack.Clear();
        Debug.Log("Clear 완료 = 전부 0으로");
        for (int i = 0; i < mystack.number.Length; i++)
        {
            Debug.Log(mystack.number[i]);
        }
        Debug.Log(mystack.Count);
    }


}
