using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAim
{
    void Aim();
    void Deselection();
    void ResetHit();
    GameObject Selection { get; set; }
}
