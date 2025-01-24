using UnityEngine;
using System.Collections;

public class UsingOther : MonoBehaviour
{
    public GameObject otherGameObject;
    
    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    
    
    void Awake ()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>(); // 다른 게임 오브젝트에 있는 컴포넌트 얻어올 수 있음
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    
    
    void Start ()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log($"The player's score is {anotherScript.playerScore}");
        Debug.Log($"The player has died {yetAnotherScript.numberOfPlayerDeaths} times");
    }
    
}
