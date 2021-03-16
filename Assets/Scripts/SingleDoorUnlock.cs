using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SingleDoorUnlock : MonoBehaviour
{
    public GameObject doorToUnlock;
    private bool playerStanding;

    // Update is called once per frame
    void Update()
    {
        if (playerStanding == true)
        {
            doorToUnlock.SetActive(false);
            Debug.Log("Unlocked door");            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        playerStanding = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        playerStanding = false;
    }
}