using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    private SurfaceEffector2D surfaceEffector2D;
    public float torque = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        surfaceEffector2D.speed = 10f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torque);
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torque);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = 20f;
        }
    }
}
