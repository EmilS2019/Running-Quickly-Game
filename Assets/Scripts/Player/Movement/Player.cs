using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IMovableCharacter
{
    public int Speed { get; set; }

    public Transform CameraPosition { get; set; }


    public void Start()
    {
        CameraPosition = transform;
    }

    public void Movement()
    {

    }
}
