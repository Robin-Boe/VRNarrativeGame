using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endPhase : MonoBehaviour
{
    // Paintings 
    public GameObject mrPainting;
    public GameObject mrsPainting;
    public GameObject workerPainting;
    public GameObject couplePainting;

    // Painting Monsters
    public GameObject paintingGhoul;
    public GameObject paintingYokai;

    // Monsters
    public GameObject ghoul;
    public GameObject yokai;
    public GameObject blinking;
    public GameObject chiefDialog;

    // Subtitle
    public GameObject chiefText;
    public TMP_Text dialogText;

    // Timer
    private float timer = 30.0f;
    private float timerSubtitle = 7.0f;

    // Notifications
    public GameObject fourPaintingsNotificationComplete;
    public GameObject fourPaintingsIconComplete;
    public GameObject leavePropertyNotification;
    public GameObject leavePropertyObjectiveList;

    // Check
    public GameObject checkIfPaintingsBurned;

    // Update is called once per frame
    void Update()
    {
        if ((!mrPainting.activeSelf) && (!mrsPainting.activeSelf) && (!workerPainting.activeSelf) && (!couplePainting.activeSelf)){
            if ((!paintingGhoul.activeSelf) && (!paintingYokai.activeSelf)){
                timer -= Time.deltaTime;
            }
            else if ((paintingGhoul.activeSelf) || (paintingYokai.activeSelf)){
                timer = 0.0f;
            }
            
            if (timer <= 0.0f){
                // Objectives
                fourPaintingsNotificationComplete.SetActive(true);
                fourPaintingsIconComplete.SetActive(true);
                leavePropertyNotification.SetActive(true);
                leavePropertyObjectiveList.SetActive(true);

                blinking.SetActive(true);
                chiefDialog.SetActive(true);
                // If the player collects the man or woman painting, disable that chase, and active the other chase
                paintingGhoul.SetActive(false);
                paintingYokai.SetActive(false);
                if ((!checkIfPaintingsBurned.activeSelf) && (timerSubtitle <= 4.0f)){
                    ghoul.SetActive(true);
                    yokai.SetActive(true);
                }

                timerSubtitle -= Time.deltaTime;

                // Subtitle
                if (timerSubtitle <= 0.0f){
                    chiefText.SetActive(false);
                }
                else if (timerSubtitle <= 0.3f){ 
                    dialogText.text = @"<b>CHIEF:</b> NOW!";
                }
                else if (timerSubtitle <= 1.2f){ 
                    dialogText.text = @"";
                }
                else if (timerSubtitle <= 2.0f){ 
                    dialogText.text = @"<b>CHIEF:</b> YOU NEED TO GET...";
                }
                else if (timerSubtitle <= 4.0f){ 
                    dialogText.text = @"";
                }
                else if (timerSubtitle <= 7.0f){
                    chiefText.SetActive(true);
                }
            }    
        }
    }
}
