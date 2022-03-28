using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpEffects : MonoBehaviour
{
    public GameObject inputScreen;

    public PlayerMovement hasFinished;

    [SerializeField] private float speed;
    [SerializeField] private GameObject loseScreen;

    public MeshRenderer renderer;

    private void Start()
    {
        speed = FindObjectOfType<PlayerMovement>().moveSpeed;
        GameObject g = GameObject.FindGameObjectWithTag("InputController");
        hasFinished = g.GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PowerUpSpeed")
        {
            StartCoroutine(SpeedUp());
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "PowerUpRed")
        {
            StartCoroutine(ChangeColor());
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag=="Obstacle" && this.gameObject.tag=="Player")
        {
            loseScreen.SetActive(true);
            hasFinished.isMoving = false;
            inputScreen.SetActive(false);
        }
        
    }

    IEnumerator SpeedUp()
    {
        speed *= 2f;
        yield return new WaitForSeconds(2);
        speed /= 2f;
    }

    IEnumerator ChangeColor()
    {
        Color matColor = renderer.material.color;
        renderer.material.color = Color.red;
        gameObject.tag = "Disabled";
        yield return new WaitForSeconds(2);
        renderer.material.color = matColor;
        gameObject.tag = "Player";
    }
}
