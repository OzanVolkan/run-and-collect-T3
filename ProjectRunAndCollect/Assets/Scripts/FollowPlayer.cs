using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;

    [SerializeField] private Vector3 offset;
    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
