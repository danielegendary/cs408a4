using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationkey : MonoBehaviour
{       
    public GameObject theNPC;
   
    void Update()
    {
        if (Input.GetButtonDown("1key"))
        {
            theNPC.GetComponent<Animator>().Play("pose1");
        }
        if (Input.GetButtonDown("2key"))
        {
            theNPC.GetComponent<Animator>().Play("pose2");
        }
        if (Input.GetButtonDown("3key"))
        {
            theNPC.GetComponent<Animator>().Play("pose0");
        }
    }
}
