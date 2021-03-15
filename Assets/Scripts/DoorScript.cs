using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorScript : MonoBehaviour
{

    GameObject doorParent;

    // Start is called before the first frame update
    void Start()
    {
        doorParent = GameObject.Find("Doors");
        LevelTransition.totalPlayers = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelTransition.totalPlayers == 2)
        {
            //doorParent.SetActive(true);

            foreach (Transform child in doorParent.transform)
            {
            Debug.Log("2");
            child.gameObject.SetActive(false);
            //child.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;

            }
        }
    }
}