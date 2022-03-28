using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public GameObject inputScreen;
    public GameObject winScreen;
    public Text pointText;

    public PlayerMovement hasFinished;
    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("InputController");
        hasFinished = g.GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            winScreen.SetActive(true);
            hasFinished.isMoving = false;
            inputScreen.SetActive(false);
            pointText.enabled = true;
        }
    }
}
