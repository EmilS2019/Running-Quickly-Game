using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{

    public void ResetLevelIfHealthDropsBelow0()
    {
        if (ObjectHealth <= 0)
        {
            MySceneManager.ResetLevel();
        }
    }

    public override void ChangeHealth(int change)
    {
        ObjectHealth += change;
        ResetLevelIfHealthDropsBelow0();
    }
}
