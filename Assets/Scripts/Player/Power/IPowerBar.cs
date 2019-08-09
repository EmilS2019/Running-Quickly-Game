using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPowerBar
{
    float PowerAmount { get; set; }
    void ChangePowerAmount();
    float GetPowerAmount();
    PowerBar.Statuses CurrentStatus { get; set; }
}
