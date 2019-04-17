using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAutonomous : MonoBehaviour
{
    [SerializeField] GameManager GM;

    private void Start()
    {
        if (GM == null)
        {
            Debug.LogError("Please assign ur GM");
            return;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ROV")
        {
            Debug.Log("Here Again bbe");
            GM.autonomous = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ROV")
        {
            Debug.Log("Not here Again bbe");
            GM.autonomous = false;
        }
    }
}
