using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpExample : MonoBehaviour
{
    void Start()
    {
        int n = 2; 

        switch (n) 
        { 
            case 1: 
                Debug.Log("1"); 
                break; 

            case 2: 
                for (int i = 0; i < 5; i++)
                {
                    if (i ==2 )
                    {
                        break;
                    }
                    Debug.Log($"n:{n}, i:{i}");
                }
                break; 

            default: 
                Debug.Log("default"); 
                break; 
        } 
        /*
        for (int k = 0; k < 2; k++)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    break; // i가 5가 되면 for 문을 벗어나게 됩니다. 
                }

                Debug.Log($"k:{k}, i:{i}"); // 출력 : 1 2 3 4  
            }
        }
        */
    }
}
