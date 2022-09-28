using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{


    public float enemydamage = 1f;

    public virtual void AttackPlayer()
    {
        print("Enemy is attacking player...");

    }
}
