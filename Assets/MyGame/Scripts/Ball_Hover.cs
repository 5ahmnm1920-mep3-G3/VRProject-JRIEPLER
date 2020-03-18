using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Hover : MonoBehaviour
{
    private Rigidbody rb;
    private float upforce = 5f;

    [HideInInspector] public bool doHover = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Hover();
    }

    private void Hover()
    {
        if (!doHover) return;
        rb.AddForce(new Vector3(x: 0, y: -Physics.gravity.y, z: 0));
    }

    public void EnableHover(bool mode)
    {
        doHover = mode;
    }

}
