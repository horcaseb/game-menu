using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelchanger : MonoBehaviour
{
    AudioSource cristal;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Player";
        cristal = GetComponent<AudioSource>();
    }

    private void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag == "Finish")
        {
            Finish();
        }
    }
    void Finish()
    {
        cristal.Play();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
