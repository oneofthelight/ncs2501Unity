using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryCatchExample : MonoBehaviour
{
    GameObject go;
    void Start()
    {
        try 
        { 
            Debug.Log(go.name); // 에러가 발생합니다.  
        } 

        catch(Exception)
        {
            Debug.LogWarning($"예외발생!! : {ex}")
        }
        finally 
        { 
            Debug.Log("여기는 실행됩니다."); // 출력 : 여기는 실행됩니다.  
        } 

        Debug.Log("여기는 실행하지 않습니다."); // 여기는 실행하지 않습니다.
    }
    void Exam1()
    {
        go = new GameObject();  

        try 
        { 
            Debug.Log(go.name); 
        } 

        catch (ex) 
        { 
            Debug.Log(ex);   
        } 

        Debug.Log("여기도 실행됩니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
