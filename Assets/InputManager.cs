using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public PlayerController pc;
    string pressedKey;

    [System.Serializable]
    public class KeyMapping
    {
        public string KeyCode;
        public string FunctionName;
    }

    public KeyMapping[] KeyMappings;

    private void Update()
    {
        pressedKey = Input.inputString;
        
        //���� Ű�� �ִ°�
        if (pressedKey != null) 
        {
            //���� ���ǵ� Ű���� ������
            foreach(KeyMapping key in KeyMappings) 
            {
                //���ǵ� Ű�� �۵�
                if (key.KeyCode == pressedKey)
                {
                    Debug.Log(pressedKey);//���� Ű ���
                    pc.Invoke(key.FunctionName,0);//Ű�� ���ε� �Լ� ����

                    //pc.Action(key.FunctionName);//�̰���
                }
            }
        }
    }
}
