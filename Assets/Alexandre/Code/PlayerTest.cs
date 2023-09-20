using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTest : MonoBehaviour
{
    private int move;
    private int currentD;

    private string myWay;


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
    
    private Deck draw;

    public GameObject buttonsDirection;
    public GameObject lancerLeDé;
    public GameObject cartePiochée;
    public Text textD;

    private void Awake()
    {
        draw = FindObjectOfType<Deck>();
    }
    private void Start()
    {
        buttonsDirection.SetActive(true);
        lancerLeDé.SetActive(false);
        cartePiochée.SetActive(false);
    }
    public void ReceiveMessage(string message)
    {
        if (message == "L")
        {
            buttonsDirection.SetActive(false);
            myWay = "L";
            lancerLeDé.SetActive(true);
        }
        if (message == "M")
        {
            buttonsDirection.SetActive(false);
            myWay = "M";
            lancerLeDé.SetActive(true);
        }
        if (message == "R")
        {
            buttonsDirection.SetActive(false);
            myWay = "R";
            lancerLeDé.SetActive(true);
        }
        if(message == "D4")
        {
            cartePiochée.SetActive(true);
            lancerLeDé.SetActive(false);
            D4();
        }
        if (message == "Ok")
        {
            cartePiochée.SetActive(false);
            lancerLeDé.SetActive(true);
        }

    }
    void Update()
    {
        if (myWay == "L")
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
        if (myWay == "R")
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
            if (myWay == "M")
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
    public void D4()
    {
        currentD = Random.Range(1, 5);
        Debug.Log(currentD);
        move += currentD;
        if(move>= 9 ||(myWay == "M"&& move >= 6))
        {
            draw.Draw(false, true);
        }
        else
        {
            draw.Draw(true, false);
        }
        textD.text = currentD.ToString();
    }


    //public void D6() {currentD = Random.Range(1, 7);Debug.Log(currentD);}

}
