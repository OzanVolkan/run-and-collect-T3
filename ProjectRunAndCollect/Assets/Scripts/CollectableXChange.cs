using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectableXChange : MonoBehaviour
{
    Vector3 spawnPos;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Score.scoreCounter++;
            Destroy(this.gameObject);
        }

    }

    private void Start()
    {
        InvokeRepeating("ChangePosition", 1f, 0f);
    }
    private void Update()
    {

    }
    public void ChangePosition()
    {
        spawnPos = new Vector3(Random.Range(-4f, 4f), transform.position.y, transform.position.z);
        transform.position = spawnPos;
        InvokeRepeating("ChangePosition", 1f, 0f);
    }
}
