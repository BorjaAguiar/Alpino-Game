using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMenu : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("0");
        print(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            print("1");
            GetComponent<LevelManager>().CambiarNivel(LevelManager.Levels.Menu);
        }
    }
}
