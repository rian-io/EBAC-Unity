using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRun : EnemyBase
{
    #region Protected Methods
    protected override float CalculateSpeed()
    {
        return Speed * 5;
    }
    #endregion
}
