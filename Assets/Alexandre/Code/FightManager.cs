using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    private int currentD;
 


    void StartBattle(string Attacker)
    {
        if(Attacker == "Cat")
        {
          
        }
        else if(Attacker == "Dog")
        {

        }

    }
    public void D6()
    {
    currentD = Random.Range(1, 7);
    Debug.Log(currentD);
    }
}
