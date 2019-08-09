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
        StartCoroutine(GetSpeedFromPlayerMovement());
    }

    IEnumerator GetSpeedFromPlayerMovement ()
    {
        yield return new WaitForFixedUpdate();
        originalSpeed = playerMovement.Speed;
    }

    float originalSpeed;

    void Update()
    {
        switch (powerBar.CurrentStatus)
        {
            case PowerBar.Statuses.Idle:
                playerMovement.ChangeSpeed(originalSpeed);
                break;
            case PowerBar.Statuses.Using:
                playerMovement.ChangeSpeed(newSpeed);
                break;
            case PowerBar.Statuses.Repleneshing:
                playerMovement.ChangeSpeed(originalSpeed - 3f);
                break;
            default:
                break;
        }
    }
}
