using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void Button_lvl1()
    {
        SceneManager.LoadScene(1);
    }

    public void Button_lvl2()
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    public void Button_quit()
    {
        Debug.Log("Quitamos la aplicación");
        Application.Quit();
    }
}
