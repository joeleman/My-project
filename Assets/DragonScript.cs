using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScript : EnemyBase
{
    void Start()
    {
        enemydamage = 1000f;
        
    }


    public override void AttackPlayer()
    {
        print("dragon is attacking...");
    }

    void Update()
    {
        AttackPlayer();
    }
}
