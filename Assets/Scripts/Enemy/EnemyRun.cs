using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRun : EnemyBase
{
    protected override float CalculateSpeed()
    {
        return speed * 5;
    }
}
