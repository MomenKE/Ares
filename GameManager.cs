using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [HideInInspector]
    public bool autonomous;
    [HideInInspector]
    public bool finished;

    private void Awake()
    {
        player.GetComponent<Enemy>().enabled = false;
        player.GetComponent<PlayerControlloer>().enabled = true;
        player.GetComponent<PlayerMotor>().enabled = true;
    }
    private void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("ROV");
            if (player == null)
            {
                Debug.LogError("Can't find any ROVs dude check ur input");
                return;
            }
        }
    }
    private void Update()
    {
        // autonomous mode
        if (Input.GetKeyDown(KeyCode.E) && autonomous)
        {
            Debug.Log("start autonomous");
            player.GetComponent<ROV>().enabled = true; //disable manual mode
            player.GetComponent<PlayerControlloer>().enabled = false;
            player.GetComponent<PlayerMotor>().enabled = false;
        }
        else if (finished)
        {
            autonomous = false;
            player.GetComponent<ROV>().enabled = false; // reactive manual mode
            player.GetComponent<PlayerControlloer>().enabled = true;
            player.GetComponent<PlayerMotor>().enabled = true;
        }
    }


}
