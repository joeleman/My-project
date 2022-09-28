using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcScript : EnemyBase
{
    void Start()
    {
        enemydamage = 100f;
     
    }


    public override void AttackPlayer()
    {
        print("Orc is attacking");
    }


    void Update()
    {
        AttackPlayer();
    }
}
