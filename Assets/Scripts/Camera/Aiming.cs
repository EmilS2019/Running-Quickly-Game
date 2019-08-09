using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour, IAim {

    public float aimRange;
    public GameObject Selection { get; set; }
    RaycastHit hit;

    public void Update()
    {
        Deselection();
        Aim();
    }

    public void Aim()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction);
        if (Physics.Raycast(ray, out hit, aimRange))
        {
            Selection = hit.collider.gameObject;
        }
    }

    public void Deselection()
    {
        if (Selection != null)
        {
            Renderer renderer = Selection.GetComponent<Renderer>();
            Selection = null;
        }
    }

    public void ResetHit()
    {
        hit = new RaycastHit();
        Selection = null;
    }
}