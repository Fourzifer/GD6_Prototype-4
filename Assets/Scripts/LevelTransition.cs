using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    static int totalPlayers = 0;

    // Update is called once per frame
    void Update()
    {
        if (totalPlayers == 2)
        {
            SceneManager.LoadScene("MainScene");
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
}
