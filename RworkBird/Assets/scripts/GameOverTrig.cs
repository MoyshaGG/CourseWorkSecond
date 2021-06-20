using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrig : MonoBehaviour
{
    private bool stop;
    private MenuGameOVer menuGameOVer;

    private void Awake()
    {
        menuGameOVer = FindObjectOfType<MenuGameOVer>();
        stop = true;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (stop)
        {
            if (other.tag == "freezeblue" || other.tag == "freezered" || other.tag == "freezegreen")
            {
                menuGameOVer.GameOver();
                stop = false;

            }
        }
    }

}
