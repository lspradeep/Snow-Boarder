using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public ParticleSystem finishParticles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("PlayerTag"))
        {
            Invoke("ReloadScene", 0.5f);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
