using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer: MonoBehaviour
{
    //public GameObject player;
    //Vector3 offset = new Vector3(0, 5, -5);
    public Transform player;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.position;
    }
    void LateUpdate()
    {
        Vector3 targetPosition = player.position + offset;
        targetPosition.x = 0;
        transform.position = targetPosition;
    }
}