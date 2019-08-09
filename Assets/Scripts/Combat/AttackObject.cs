using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackObject : MonoBehaviour {

	public int damage;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<PlayerHealth>() != null)
        col.gameObject.GetComponent<PlayerHealth>().ChangeHealth(-damage);
    }

}
