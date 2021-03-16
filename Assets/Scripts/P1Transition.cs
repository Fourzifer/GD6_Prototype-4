using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P1Transition : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene("LiamScene11A");
        Debug.Log("Player 1 transition");
    }
}