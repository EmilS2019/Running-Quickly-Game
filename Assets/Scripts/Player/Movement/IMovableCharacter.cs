using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovableCharacter
{
    int Speed { get; set; }
    void Movement();
    Transform CameraPosition { get; set; }

}
