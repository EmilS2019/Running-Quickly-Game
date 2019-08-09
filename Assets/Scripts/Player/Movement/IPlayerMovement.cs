using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerMovement {

    void ChangeSpeed(float amount);
    float Speed { get; set; }

}
