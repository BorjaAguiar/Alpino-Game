using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{   
    public enum Levels {Lvl1 = 1, Lvl2 = 2, Menu = 0}

    public void CambiarNivel(Levels level)
    {
        SceneManager.LoadScene((int)level);
    }
    public void CambiarNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }
}
