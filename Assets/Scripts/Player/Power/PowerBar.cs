using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour, IPowerBar {

    public float PowerAmount { get; set; }
    public float decreasingPowerSpeed;
    public float replenishingPowerSpeed;

    public enum Statuses { Idle, Using, Repleneshing }
    public Statuses CurrentStatus { get; set; } 

    void Start() { PowerAmount = 1f; }

    void Update()
    {
        CurrentStatus = ChangeCurrentStatus();
        StatusSwitch();


        //ChangePowerAmount();
    }

    Statuses ChangeCurrentStatus()
    {
        if (Input.GetMouseButton(1) && PowerAmount >= 0.01f)
        {
            return Statuses.Using;
        }
        else if (PowerAmount <= 1)
        {
            return Statuses.Repleneshing;
        }
        else
        {
            return Statuses.Idle;
        }
    }

    void StatusSwitch()
    {
        switch (CurrentStatus)
        {
            case Statuses.Idle:
                break;
            case Statuses.Using:
                PowerAmount -= decreasingPowerSpeed / 1000;
                ChangeBarSize();
                break;
            case Statuses.Repleneshing:
                PowerAmount += replenishingPowerSpeed / 1000;
                ChangeBarSize();
                break;
        }
    }

    public void ChangePowerAmount()
    {
        if (Input.GetMouseButton(1) && PowerAmount >= 0.01f)
        {
            PowerAmount -= decreasingPowerSpeed / 1000;
            ChangeBarSize();
        }
        else if (PowerAmount <= 1)
        {
            PowerAmount += replenishingPowerSpeed / 1000;
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

