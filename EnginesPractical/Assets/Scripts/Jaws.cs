using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jaws : GameManager
{
    void Update()
    {
        if(jawsPower >= 10)
        {
            AttackShip();
        }
    }

    void AttackShip()
    {
        // jaws attacks ship

        // reset jaws' power
    }
}
