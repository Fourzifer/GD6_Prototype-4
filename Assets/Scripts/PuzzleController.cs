using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    GameObject whiteParent;
    GameObject blackParent;


    // Use this for initialization
    void Awake()
    {
        whiteParent = GameObject.Find("Whites");
        blackParent = GameObject.Find("Blacks");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.G) || (Input.GetKey("joystick button 4")))
        {
            foreach (Transform child in whiteParent.transform)
            {
                child.gameObject.SetActive(false);
            }
        }

        if (Input.GetKey(KeyCode.H) || (Input.GetAxis("P1_Trigger") > 0))
        {
            foreach (Transform child in whiteParent.transform)
            {
                child.gameObject.SetActive(true);

            }
        }

        if (Input.GetKey(KeyCode.K) || (Input.GetKey("joystick button 5")))
        {
            foreach (Transform child in blackParent.transform)
            {
                child.gameObject.SetActive(false);

            }
        }

        if (Input.GetKey(KeyCode.L) || (Input.GetAxis("P2_Trigger") > 0))
        {
            foreach (Transform child in blackParent.transform)
            {
                child.gameObject.SetActive(true);

            }
        }
    }
}