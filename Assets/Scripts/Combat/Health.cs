using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int ObjectHealth;

    public virtual void ChangeHealth(int change)
    {
        ObjectHealth += change;
    }
}
