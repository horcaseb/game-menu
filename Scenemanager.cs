using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject creditos;
    public GameObject menu;
    public GameObject instrucciones;
    // Update is called once per frame
    
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Creditos()
    {
        creditos.SetActive(true);
        menu.SetActive(false);
    }
    public void Menu()
    {
        menu.SetActive(true);
        creditos.SetActive(false);
        instrucciones.SetActive(false);
    }
    public void Instrucciones()
    {
        instrucciones.SetActive(true);
        menu.SetActive(false);
    }
}
