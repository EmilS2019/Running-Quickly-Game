using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour, IPowerBar {

    public float PowerAmount { get; set; }

    void Start() { PowerAmount = 1f; }

    void Update()
    {
        ChangePowerAmount();
    }

    public void ChangePowerAmount()
    {
        if (Input.GetMouseButton(1) && PowerAmount >= 0.01f)
        {
            PowerAmount -= 0.005f;
            ChangeBarSize();
        }
        else if (PowerAmount <= 1)
        {
            PowerAmount += 0.001f;
            ChangeBarSize();
        }
    }

    void ChangeBarSize()
    {
        transform.localScale = new Vector3(1, PowerAmount);
    }

    public float GetPowerAmount()
    {
        return PowerAmount;
    }
}

