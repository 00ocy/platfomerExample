using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    public void MoveLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    public void MoveRight()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }




    //�Լ� �����ͷ� ���� ����
    System.Reflection.MethodInfo methodInfo;
    public void Action(string functionName)
    {
        methodInfo = GetType().GetMethod(functionName);

        // �޼��尡 ã�������� Ȯ��
        if (methodInfo != null)
        {
            // �޼��� ����
            methodInfo.Invoke(this, null);
        }
        else
        {
            Debug.LogError("Method not found: " + functionName);
        }
    }

}
