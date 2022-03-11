using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameOver : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void Restart_lvl2()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart_lvl1()
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    public void Menu()
    {
        SceneManager.LoadScene(3);
    }

    public void Button_quit()
    {
        Debug.Log("Quitamos la aplicación");
        Application.Quit();
    }
}
