using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSpeed : SuperPower
{

    public IPowerBar powerBar;
    public IPlayerMovement playerMovement;
    public float newSpeed;


    void Start()
    {
        powerBar = FindObjectOfType<PowerBar>();
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        switch (powerBar.CurrentStatus)
        {
            case PowerBar.Statuses.Idle:
                playerMovement.ChangeSpeed();
                break;
            case PowerBar.Statuses.Using:
                break;
            case PowerBar.Statuses.Repleneshing:
                break;
            default:
                break;
        }
    }
}
