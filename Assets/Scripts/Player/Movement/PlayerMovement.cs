using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IPlayerMovement {

    public float playerSpeed;
    //[HideInInspector] public float Speed { get; set; }
    float Speed;

    void Start() { ChangeSpeed(playerSpeed); }

	void Update ()
    {
        WSADControlls();
	}

    void WSADControlls()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += -transform.forward * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position += -transform.right * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * Speed * Time.deltaTime;
    }

    public void ChangeSpeed(float amount)
    {
        Speed = amount;
    }
}
