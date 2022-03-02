using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiCochecito : MonoBehaviour
{
    public float speed = 20f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xMov = Input.GetAxisRaw("Vertical");
        float zMov = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector3(xMov, rb.velocity.y, -zMov) * speed;
    }
}