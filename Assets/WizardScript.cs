using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardScript : EnemyBase
{  
    void Start()
    {
        enemydamage = 100f;
       
    }

    void Update()
    {
        AttackPlayer();
    }
   
}
