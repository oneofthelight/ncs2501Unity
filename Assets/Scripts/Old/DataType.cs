using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // Start is called before the first frame update

    // 전역변수
    int gv;
    void Start()
    {
        
        var i = 1;
        var f = 2f;
        var c = 'c';
        var s = "string";
        // 아래는 에러남
        // var v;

        int age = 46, brother = 2;
        float f1 = 1.0f, f2 = 2.3f;
        int i1, i2 = 4, i3;
        //var는 한줄에 하나만 정의 가능
        //var v1 = 2, v2 = 2;
        
        string str = new string("abc");
        
        int numbers1;
        numbers1 = 1;
        int newone =2 ;
        float numbers3 = 3f, numbers4 = 4f;
        bool isBool = true; //faulse

        Debug.Log(numbers1.ToString());
        Debug.Log(newone.ToString());
        Debug.Log(numbers3.ToString());
        Debug.Log(numbers4.ToString());
        Debug.Log(isBool.ToString());

        //값을 지정하지 않은 지역 변수는 사용하면 에러
        //Debug.Log(i1);
        Debug.Log("gv" + gv);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
