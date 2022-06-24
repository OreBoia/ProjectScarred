using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EventScript : MonoBehaviour
{
    public DialogScriptableObject dialogAsset;
    public GameObject setPoint;

    public bool isMiniGame = false;

    public GameObject minigameCamera;
    public GameObject defaultCamera;
    public GameObject minigameObj;

    private static EventScript _instance;

    public static EventScript Instance
    {
        get
        {
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }

    public void SwitchCam()
    {
        GameController.Instance.SwitchCam(minigameCamera, minigameObj);
    }
}
