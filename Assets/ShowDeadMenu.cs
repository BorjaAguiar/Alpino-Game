using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowDeadMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject pinguino;

    // Start is called before the first frame update

    void Update()
    {
        if (pinguino == null)
        {
            Setvisible();
        }
    }

    void Setvisible()
    {
        pauseMenuUI.SetActive(true);
    }




}