//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class OldPuzzleController : MonoBehaviour
//{
//    GameObject parent;
//    GameObject child;

//    private bool whites = true;
//    //private bool blacks = true;

//    // Start is called before the first frame update
//    void Awake()
//    {
//        parent = GameObject.Find("Whites");
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //parent = GameObject.Find("Whites");
//        if (Input.GetKey(KeyCode.F)/* && (whites == true)*/)
//        {
//            //transform.GetChild(0).gameObject.SetActive(false);
//            //transform.GetChild(2).gameObject.SetActive(true);

//            //whites = false;
//            //blacks = true;

//            //for (int i = 0; i < parent.transform.childCount; i++)
//            //{
//            //    parent.transform.GetChild(i).gameObject.setActive(false);

//            //}

//            parent.gameObject.SetActive(false);

//        }

//        if (Input.GetKey(KeyCode.Space))
//        {
//            parent.SetActive(false);
//        }
//        else
//        {
//            parent.SetActive(true);
//        }


//        if (Input.GetKey(KeyCode.V)/* && (whites == false)*/)
//        {
//            //parent = GameObject.Find("Whites");
//            //transform.GetChild(2).gameObject.SetActive(false);
//            //transform.GetChild(0).gameObject.SetActive(true);

//            //whites = true;
//            //blacks = false;

//            //for (int i = 0; i < parent.transform.childCount; i++)
//            //{
//            //    parent.transform.GetChild(i).gameObject.setActive(false);

//            //}

//            parent.gameObject.SetActive(true);
//        }


//        if (Input.GetKey(KeyCode.G)/* && (whites == false)*/)
//        {
//            transform.GetChild(1).gameObject.SetActive(false);
//            transform.GetChild(3).gameObject.SetActive(true);

//            //whites = true;
//            //blacks = false;
//        }

//        if (Input.GetKey(KeyCode.B)/* && (whites == true)*/)
//        {
//            transform.GetChild(3).gameObject.SetActive(false);
//            transform.GetChild(1).gameObject.SetActive(true);

//            //whites = true;
//            //blacks = false;
//        }
//    }
//}
