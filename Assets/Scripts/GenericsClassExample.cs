using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsClassExample : MonoBehaviour
{
    public class GenericsClass<T>
    { 
        private T value; 

        public GenericsClass(T value) 
        { 
            this.value = value; 
        } 

        public void Method1() 
        { 
            Debug.Log(value); 
        } 
    } 

    void Startold() 
    { 
        GenericsClass<int> m_GenericsClass1 = new GenericsClass<int>(5); 
        m_GenericsClass1.Method1(); // 출력 : 5 
        GenericsClass<float> m_GenericsClass2 = new GenericsClass<float>(5.1f); 
        m_GenericsClass2.Method1(); // 출력 : 5.1 
    }
    void Swap<T>(ref T x, ref T y)
    {
        var temp = y;
        y = x;
        x = temp;
    }
    void Start() 
    { 
        int iX = 1, iY = 2; 
        Swap(ref iX, ref iY); 
        Debug.Log($"before : ix:{iX} iy:{iY}");
        Swap(ref iX, ref iY); 
        Debug.Log($"after : ix:{iX} iy:{iY}"); // 출력 : x = 2 y = 1  

        string sX = "ab", sY = "cd"; 
        Swap(ref sX, ref sY); 
        Debug.Log($"before : ix:{sX} iy:{sY}");
        Swap(ref sX, ref sY); 
        Debug.Log($"after : ix:{sX} iy:{sY}"); // 출력 : x = cd y = ab  
    }
}
