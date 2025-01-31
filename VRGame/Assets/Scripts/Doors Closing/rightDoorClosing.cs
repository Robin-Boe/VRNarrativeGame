using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightDoorClosing : MonoBehaviour
{
    // Player
    public GameObject Player;

    // Doors
    public Animator rightDoorAnim;
    public BoxCollider rightDoorCollider;
    int doorCheck = 0;

    // Check
    public GameObject checkIfPlayer;

    // Start is called before the first frame update
    /*void Start()
    {
        rightDoorAnim = GetComponent<Animator>();
    }

    // Door closing sequence 
    void doorClose()
    {
        rightDoorAnim.Play("doorClosingRight");
        rightDoorCollider.enabled = true;
    }*/

    // Update is called once per frame
    void Update()
    {
        if (checkIfPlayer.activeSelf){
            rightDoorCollider.enabled = true;
        }
        else{
            rightDoorCollider.enabled = false;
        }       
        // If the player enters the mansion within certain positions than  
        /*if ((Player.transform.position.x <= 2.896436f && Player.transform.position.x >= -3.542453f) && (Player.transform.position.y >= 0 && Player.transform.position.y <= 2) && (Player.transform.position.z <= -6.5f && Player.transform.position.z >= -9.0f) && (doorCheck == 0)){
            doorCheck = 1;
            doorClose();
        }*/
    }
}
