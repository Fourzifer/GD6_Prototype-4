using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P2Transition : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene("LiamScene11B");
        Debug.Log("Player 2 transition");
    }
}