using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    private SurfaceEffector2D surfaceEffector2D;
    public ParticleSystem snowParticles;
    public float torque = 1f;
    private float boost = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("GroundTag"))
        {
            snowParticles.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("GroundTag"))
        {
            snowParticles.Stop();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    void FixedUpdate()
    {
        boost = 10f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torque);
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torque);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            boost = 18f;
        }

        surfaceEffector2D.speed = boost;

    }

    public void onDead()
    {
        boost = 0f;
        surfaceEffector2D.speed = boost;
    }
}
