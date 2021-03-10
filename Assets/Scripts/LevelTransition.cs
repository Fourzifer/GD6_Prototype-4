using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public static int totalPlayers = 0;

    // Update is called once per frame
    void Update()
    {
        if (totalPlayers == 2)
        {
            Debug.Log("2");
            //totalPlayers = 0;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        totalPlayers += 1;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        totalPlayers -= 1;
    }

    private void Teleport()
    {
        if (totalPlayers == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
