using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumExample : MonoBehaviour
{
    enum EnumExample1  {e0, e1, e2}
    enum EnumExample2 {e0 = 5, e1, e2 = 10};  //앞의 할당된 값보다 큰 값이 뒤에 와야함
    int[] ii = new int[]{1,2,4};
    enum Day {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};
    enum Mondth:byte{Jan=1,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec};
    [Flags]
    enum Days
    {
    Sunday = 0 , 
    Monday = 1, 
    Tuesday = 2, 
    Wednesday = 4, 
    Thursday = 8, 
    Friday = 16, 
    Saturday = 32
    };

    

    void Start()
    {
        
        Day today = Day.Monday;
        int dayNumber = (int)today;
        Debug.Log($"{today} is day number {dayNumber}.");

        Mondth thisMonth = Mondth.Jan;
        byte monthNumber = (byte)thisMonth;
        Debug.Log($"{thisMonth} is month number #{monthNumber}.");

        Days workingDay = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;
        Debug.Log($"Working Days are {workingDay}");
        Days today2 = Days.Wednesday;
        //오늘이 workingDay 인지 판별해서 출력
        //if ((today2 & workingDay) == 0)
        if (!workingDay.HasFlag(today2))
        {
            Debug.Log("Today is holiday.");
        }
        else
        {
            Debug.Log("Today is working day.");
        }
    }
        // Game State enum
    enum GameState {ready, play, gameover};
    public void StateGame()
    {
        GameState gameState = GameState.ready;
        if (gameState == GameState.ready)
        {

        }
        else if (gameState == GameState.play)
        {

        }
        else
        {

        }
    }
}