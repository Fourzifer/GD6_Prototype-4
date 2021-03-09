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
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelTransition.totalPlayers == 2)
        {
            //doorParent.SetActive(true);

            foreach (Transform child in doorParent.transform)
            {

            child.gameObject.SetActive(false);
            //child.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;

            }
        }
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}
}
