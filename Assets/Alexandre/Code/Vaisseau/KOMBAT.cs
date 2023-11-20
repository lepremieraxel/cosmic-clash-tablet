using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KOMBAT : MonoBehaviour
{
    private int dice;
    // Start is called before the first frame update
    public Transform C1;
    public Transform C2;
    public Transform C3;
    public Transform C4;
    public Transform C5;
    public Transform C6;

    public Transform L1;
    public Transform L2;
    public Transform L3;
    public Transform L4;
    public Transform L5;
    public Transform L6;

    void Start()
    {
        
    }
    void Fight(int dice)
    {
       
    }
    void D6()
    {
        dice = Random.Range(1, 7);
        Debug.Log(dice);
        Fight(dice);
    }

    /*
     * lance un dé 6
     * choisis en cliquant sur la ligne ou collone = a D6
     * choisis haut ou bas = a ligne ou collone cliqué
     * instantier le projectile
     * 
     */
    // Update is called once per frame
    void Update()
    {
        
    }
}
