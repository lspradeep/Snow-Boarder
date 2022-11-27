using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bloodParticles;
    private ParticleSystem effect;
    private bool showBlood = false;

    void Start()
    {
        effect = bloodParticles.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (showBlood && !effect.isPlaying)
        {
            bloodParticles.GetComponent<Transform>().position = transform.position;
            bloodParticles.SetActive(true);
            effect.Play();
        }   
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.tag);

        if (collision.tag.Equals("GroundTag"))
        {
            showBlood = true;
            Invoke("ReloadScene", 1f);
        }
    }


    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
