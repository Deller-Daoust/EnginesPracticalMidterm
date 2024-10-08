using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    bool playerHasCharges;
    float chargeCount = 10;

    /*
        For commands, there needs to be an array that would hold the list of commands, for simplicity, each action would be given a number to put into the array.
        For instance, lets say we have an array of values 1, 0, 0, 0
        The 1 would be the drop charges command, while the zeros are nothing.
    */

    // Update is called once per frame
    void Update()
    {
        if(chargeCount <= 0)
        {
            playerHasCharges = false;
        }

        if(Input.GetKeyDown("A"))
        {
            //player go left
        }
        if(Input.GetKeyDown("D"))
        {
            //player go right
        }
        if(Input.GetKeyDown("G"))
        {
            //Insert 1 in actions array
        }
    }

    public void DropCharges()
    {
        if(playerHasCharges == true)
        {
            //depth charges are dropped
        }
    }
}
