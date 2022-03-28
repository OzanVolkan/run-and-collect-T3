using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    [SerializeField] private Transform playerTransform;

    [SerializeField] private float leftMovementLimit = -4;
    [SerializeField] private float rightMovementLimit = 4;
    [SerializeField] private float movementSensitivity = 100f;

    public float moveSpeed = 10f;

    public bool isMoving = false;

    public void OnDrag(PointerEventData eventData)
    {
        //playerTransform.position += new Vector3(eventData.delta.x / 100f, 0, 0);
        Vector3 tempPosition = playerTransform.position;
        tempPosition.x = Mathf.Clamp(tempPosition.x + (eventData.delta.x / movementSensitivity), leftMovementLimit, rightMovementLimit);
        playerTransform.position = tempPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isMoving = true;
    }

    void Update()
    {
        if (isMoving)
        {
            playerTransform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else if(!isMoving)
        {
            playerTransform.Translate(Vector3.zero);
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
    }

    
}
