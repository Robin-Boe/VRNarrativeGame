using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorInteract : MonoBehaviour
{
    // Check if key has been interacted with
    public GameObject keyObjectiveList;
    public GameObject findNewExitObjectiveList;

    // Enable Door Notficiaiton and List
    public GameObject doorObjectiveList;
    public GameObject findKeyNotification;
    public GameObject findExitNotificationComplete;
    public GameObject findExitCompleteIcon;
    public GameObject findDoorObjectiveComplete;
    public GameObject findDoorObjectiveCompleteIcon;

    public void DoorNotification()
    {
        // IF key has not been interacted with and Find Exit is active
        if ((!keyObjectiveList.activeSelf) && (findNewExitObjectiveList.activeSelf)){
            // Set Exit (Complete) Notification To Active
            findExitNotificationComplete.SetActive(true);
            // Set Exit Icon (checkmark) To Active
            findExitCompleteIcon.SetActive(true);
            // Set door objective in main menu to active
            doorObjectiveList.SetActive(true);
            // Set find key notification to active
            findKeyNotification.SetActive(true);

        }
        // IF key has not been interacted with and Find Exit is not active
        else if ((!keyObjectiveList.activeSelf) && (!findNewExitObjectiveList.activeSelf)){
            // Set door objective in main menu to active
            doorObjectiveList.SetActive(true);
            // Set find key notification to active
            findKeyNotification.SetActive(true);

        }
        // IF key interacted with first and Find Exit is active
        else if ((keyObjectiveList.activeSelf) && (findNewExitObjectiveList.activeSelf)){
            // Set find door objective to complete (checkmark)
            findDoorObjectiveCompleteIcon.SetActive(true);
            // Set the find door notification to active
            findDoorObjectiveComplete.SetActive(true);
            // Set Exit (Complete) Notification To Active
            findExitNotificationComplete.SetActive(true);
            // Set Exit Icon (checkmark) To Active
            findExitCompleteIcon.SetActive(true);
        }
        // IF key interacted with first and Find Exit is not active
        else if ((keyObjectiveList.activeSelf) && (!findNewExitObjectiveList.activeSelf)){
            // Set find door objective to complete (checkmark)
            findDoorObjectiveCompleteIcon.SetActive(true);
            // Set the find door notification to active
            findDoorObjectiveComplete.SetActive(true);
        }
    }
}
