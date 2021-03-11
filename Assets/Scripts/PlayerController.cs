using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject playerPrefab;
    List<GameObject> players = new List<GameObject>();
    float speed = 2;
    //public Animator animator;
    Vector2 movement;

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
        movement.x = Input.GetAxis("P1_Horizontal");
        movement.y = Input.GetAxis("P1_Vertical");
        players[0].transform.Translate(new Vector2(movement.x, movement.y) * speed * Time.deltaTime);

        //Player 1 Gamepad
        float P1_horizontalInputGamepad = Input.GetAxis("P1_Horizontal_Gamepad");
        float P1_verticalInputGamepad = Input.GetAxis("P1_Vertical_Gamepad");
        players[0].transform.Translate(new Vector2(P1_horizontalInputGamepad, P1_verticalInputGamepad) * speed * Time.deltaTime);

        //Player 2 Keyboard
        float P2_horizontalInput = Input.GetAxis("P2_Horizontal");
        float P2_verticalInput = Input.GetAxis("P2_Vertical");
        players[1].transform.Translate(new Vector2(P2_horizontalInput, P2_verticalInput) * speed * Time.deltaTime);

        //Player 2 Gamepad
        float P2_horizontalInputGamepad = Input.GetAxis("P2_Horizontal_Gamepad");
        float P2_verticalInputGamepad = Input.GetAxis("P2_Vertical_Gamepad");
        players[1].transform.Translate(new Vector2(P2_horizontalInputGamepad, P2_verticalInputGamepad) * speed * Time.deltaTime);
    }
}