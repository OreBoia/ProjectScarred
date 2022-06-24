using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEventCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EventScript eventObj = collision.gameObject.GetComponent<EventScript>();
        //Debug.Log(eventObj);

        if (eventObj != null)
        {
            if (eventObj.isMiniGame == false)
            {
                //Debug.Log("COLLISION " + collision);
                DialogController.Instance.dialogAsset = eventObj.dialogAsset;
                DialogController.Instance.AddSpeaker();
                DialogController.Instance.setPointObj = eventObj.setPoint;
                //GAME STATUS = INDIALOG
            }
            else
            {
                PlayerScript.Instance.eventObj = eventObj;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        EventScript eventObj = collision.gameObject.GetComponent<EventScript>();

        //Debug.Log("COLLISION " + collision);

        if (eventObj != null)
        {
            DialogController.Instance.Reset();
            //aggiungere controllo quando non c'è il dialog asset
        }

        if (PlayerScript.Instance.eventObj != null)
        {
            PlayerScript.Instance.eventObj = null;
        }
    }
}
