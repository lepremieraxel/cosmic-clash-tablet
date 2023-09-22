using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogManager : MonoBehaviour
{
    public bool dogTurn = true;
    public int move;


    public string dogWay;


    private bool myWayIsL = false;
    public Transform planetL1;
    public Transform planetL2;
    public Transform planetL3;
    public Transform planetL4;
    public Transform planetL5;
    public Transform planetL6;
    public Transform planetL7;
    public Transform planetL8;

    public Transform planetChat;


    private bool myWayIsR = false;
    public Transform planetR1;
    public Transform planetR2;
    public Transform planetR3;
    public Transform planetR4;
    public Transform planetR5;
    public Transform planetR6;
    public Transform planetR7;
    public Transform planetR8;

    private bool myWayIsM = false;
    public Transform planetM1;
    public Transform planetM2;
    public Transform planetM3;
    public Transform planetM4;
    public Transform planetM5;
    
 

    
    void Update()
    {
        if (dogWay == "L")
        {
            if (move == 1)
            {
                this.transform.position = planetL1.transform.position;
                
            }
            if (move == 2)
            {
                this.transform.position = planetL2.transform.position;
                
            }
            if (move == 3)
            {
                this.transform.position = planetL3.transform.position;
                
            }
            if (move == 4)
            {
                this.transform.position = planetL4.transform.position;
                
            }
            if (move == 5)
            {
                this.transform.position = planetL5.transform.position;
                
            }
            if (move == 6)
            {
                this.transform.position = planetL6.transform.position;
                
            }
            if (move == 7)
            {
                this.transform.position = planetL7.transform.position;
                
            }
            if (move == 8)
            {
                this.transform.position = planetL8.transform.position;
                
            }

        }
        if (dogWay == "R")
        {
            if (move == 1)
            {
                this.transform.position = planetR1.transform.position;
                
            }
            if (move == 2)
            {
                this.transform.position = planetR2.transform.position;
                
            }
            if (move == 3)
            {
                this.transform.position = planetR3.transform.position;
                

            }
            if (move == 4)
            {
                this.transform.position = planetR4.transform.position;
                
            }
            if (move == 5)
            {
                this.transform.position = planetR5.transform.position;
               
            }
            if (move == 6)
            {
                this.transform.position = planetR6.transform.position;
               
            }
            if (move == 7)
            {
                this.transform.position = planetR7.transform.position;
               
            }
            if (move == 8)
            {
                this.transform.position = planetR8.transform.position;
               
            }
        }
            if (dogWay == "M")
            {
            if (move == 1)
            {
                this.transform.position = planetM1.transform.position;
               
            }
            if (move == 2)
            {
                this.transform.position = planetM2.transform.position;
                
            }
            if (move == 3)
            {
                this.transform.position = planetM3.transform.position;
                

            }
            if (move == 4)
            {
                this.transform.position = planetM4.transform.position;
                
            }
            if (move == 5)
            {
                this.transform.position = planetM5.transform.position;
                
            }
            if (move >= 6)
            {
                this.transform.position = planetChat.transform.position;
                //Lancer phase de combat
            }
        }
        if (move >= 9)
        {
            this.transform.position = planetChat.transform.position;
            //Lancer phase de combat
        }

    }



    //public void D6() {currentD = Random.Range(1, 7);Debug.Log(currentD);}

}
