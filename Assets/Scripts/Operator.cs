using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    // 나누기 연산자를 곱하기 연산자로 사용하는 것이 최적화 할 때 도움이 됨
    void Start()
    {
        List<int> list = new List<int>();
        int intSize = sizeof(int);
        int fSize = sizeof(float);
        int bSize = sizeof(bool);
        Debug.Log($"int:{intSize}, float:{fSize}, bool:{bSize}");

        int i = 1;
        Debug.Log($"before:{i}");
        Debug.Log($"++i:{++i}");  //연산 전에 값을 더해줌
        Debug.Log($"after:{i}");

        i = 1;
        Debug.Log($"before:{i}");
        Debug.Log($"i++:{i++}"); // 연산 후에 값을 더해줌
        Debug.Log($"after:{i}");

        for (int k = 0; k < 10; k++)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
