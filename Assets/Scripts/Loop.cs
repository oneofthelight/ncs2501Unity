using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    int numEnemies = 3; 
    void Start()
    {
        //ForLoop();
        // WhileLoop();
        // DoWhile();
        ForeachLoop();
    }

    void ForLoop()
    {
        for(int i = 1; i < numEnemies; i++)
        {   
            Debug.Log("Creating enemy:" + i);
        }
        for (int i = numEnemies; i>= 0; i--)
        {
            Debug.Log("minus for" + i);
        }
    }
    void WhileLoop()
    {
        int cupInTheSink = 4;

        while (cupInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupInTheSink--;
        }

        cupInTheSink = 4;
        for( int i = 0; i < cupInTheSink; i++)
        {
            Debug.Log("I've washed a cup!");
        }
    }
    void DoWhile()
    {
        bool ShouldContunue = false;
        do
        {
            print("Hello World");

        }while (ShouldContunue == true);
    }
    void ForeachLoop()
    {   
        string[] strings = new string[3];
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (string item in strings)
        {
            print(item);
        }
        
    }
}
