using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    int ObjectHealth { get; set; }

    void ChangeHealth(int change);

}
