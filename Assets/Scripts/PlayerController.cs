using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject playerPrefab;
    List<GameObject> players = new List<GameObject>();
    float speed = 2;

    void Update()
    {
        foreach (GameObject player in GameObject.FindObjectsOfType(typeof(GameObject)))
        {
            if (player.tag == "Player" && !players.Contains(player))
            {
                players.Add(player);
            }
        }

        //Player 1 Keyboard
        float P1_horizontalInput = Input.GetAxis("P1_Horizontal");
        float P1_verticalInput = Input.GetAxis("P1_Vertical");
        players[0].transform.Translate(new Vector3(P1_horizontalInput, P1_verticalInput, 0) * speed * Time.deltaTime);

        //Player 1 Gamepad
        float P1_horizontalInputGamepad = Input.GetAxis("P1_Horizontal_Gamepad");
        float P1_verticalInputGamepad = Input.GetAxis("P1_Vertical_Gamepad");
        players[0].transform.Translate(new Vector3(P1_horizontalInputGamepad, P1_verticalInputGamepad, 0) * speed * Time.deltaTime);

        //Player 2 Keyboard
        float P2_horizontalInput = Input.GetAxis("P2_Horizontal");
        float P2_verticalInput = Input.GetAxis("P2_Vertical");
        players[1].transform.Translate(new Vector3(P2_horizontalInput, P2_verticalInput, 0) * speed * Time.deltaTime);

        //Player 2 Gamepad
        float P2_horizontalInputGamepad = Input.GetAxis("P2_Horizontal_Gamepad");
        float P2_verticalInputGamepad = Input.GetAxis("P2_Vertical_Gamepad");
        players[1].transform.Translate(new Vector3(P2_horizontalInputGamepad, P2_verticalInputGamepad, 0) * speed * Time.deltaTime);
    }
}