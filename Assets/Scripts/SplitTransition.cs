using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplitTransition : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "LiamScene11A")
        {
            SceneManager.LoadScene("LiamScene12A");
        }

        else if (sceneName == "LiamScene11B")
        {
            SceneManager.LoadScene("LiamScene12B");
        }

        if (sceneName == "LiamScene12A")
        {
            SceneManager.LoadScene("LiamScene13A");
        }

        else if (sceneName == "LiamScene12B")
        {
            SceneManager.LoadScene("LiamScene13B");
        }

        if ((sceneName == "LiamScene13B") || (sceneName == "LiamScene13A"))
        {
            SceneManager.LoadScene("LiamScene14");
        }
    }
}