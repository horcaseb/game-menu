using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Player";
    }

    private void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag == "Fall")
        {
            Finish();
        }
    }
    void Finish()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
