using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum GameStatus { Running, Paused, Dialog, GameOver }

public class GameController : MonoBehaviour
{
    public GameStatus gameStatus = GameStatus.Running;

    public GameObject defaultCamera;

    private static GameController _instance;

    public static GameController Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Start()
    {
        _instance = this;
        DontDestroyOnLoad(this);
    }

    public void ReturnToNormalCam(GameObject minigameCamera, GameObject minigameObj)
    {
        defaultCamera.SetActive(true);

        minigameObj.SetActive(false);

        PlayerScript.Instance.gameObject.GetComponent<PlayerInput>().enabled = true;

        minigameCamera.SetActive(false);
    }

    public void SwitchCam(GameObject minigameCamera, GameObject minigameObj)
    {
        defaultCamera.SetActive(false);

        minigameCamera.SetActive(true);

        PlayerScript.Instance.gameObject.GetComponent<PlayerInput>().enabled = false;

        minigameObj.SetActive(true);
    }
}
