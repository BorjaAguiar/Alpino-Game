using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{   
    public enum Levels {Lvl1 = 0, Lvl2 = 1, Menu = 3}

    public void CambiarNivel(Levels level)
    {
        SceneManager.LoadScene((int)level);
    }
    public void CambiarNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }
}
