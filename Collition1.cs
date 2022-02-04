using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collition1 : MonoBehaviour
{
    GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Player";
    }
     
    // Update is called once per frame
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fall")
        {
            panel.SetActive(true);
        }
    }
    

}
