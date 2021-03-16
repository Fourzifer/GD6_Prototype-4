using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LastDoors : MonoBehaviour
{
    public GameObject doorOne;
    public GameObject doorTwo;
    private bool playerStanding;

    // Update is called once per frame
    void Update()
    {
        if (playerStanding == true)
        {
            doorOne.SetActive(false);
            doorTwo.SetActive(true);
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