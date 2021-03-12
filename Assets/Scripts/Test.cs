//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Test : MonoBehaviour
//{
//    private float xInput, yInput;
//    public int speed = 1, collisionDistance;
//    private Rigidbody2D body;
//    public Animator animator;
//    private bool isMoving;
//    public GameObject playerPrefab;
//    List<GameObject> players = new List<GameObject>();

//    void Start()
//    {
//        body = GetComponent<Rigidbody2D>();
//        //animator = GetComponent<Animator>();
//        isMoving = false;
//    }

//    void Update()
//    {

//        foreach (GameObject player in GameObject.FindObjectsOfType(typeof(GameObject)))
//        {
//            if (player.tag == "Player" && !players.Contains(player))
//            {
//                players.Add(player);
//            }
//        }

//        xInput = Input.GetAxisRaw("P1_Horizontal");
//        yInput = Input.GetAxisRaw("P1_Vertical");

//        isMoving = (xInput != 0 || yInput != 0);
        
//        if (isMoving)
//        {
//            var moveVector = new Vector3(xInput, yInput, 0);

//            body.MovePosition(new Vector2((transform.position.x + moveVector.x * speed * Time.deltaTime),
//                transform.position.y + moveVector.y * speed * Time.deltaTime));

//            //Player 1 Keyboard
//            float P1_horizontalInput = Input.GetAxis("P1_Horizontal");
//            float P1_verticalInput = Input.GetAxis("P1_Vertical");
//            players[0].transform.Translate(new Vector3(P1_horizontalInput, P1_verticalInput, 0) * speed * Time.deltaTime);

//            //Player 1 Gamepad
//            float P1_horizontalInputGamepad = Input.GetAxis("P1_Horizontal_Gamepad");
//            float P1_verticalInputGamepad = Input.GetAxis("P1_Vertical_Gamepad");
//            players[0].transform.Translate(new Vector3(P1_horizontalInputGamepad, P1_verticalInputGamepad, 0) * speed * Time.deltaTime);
//        }
//    }
//}