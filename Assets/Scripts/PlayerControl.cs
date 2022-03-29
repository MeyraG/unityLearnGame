using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    float turningSpeed;

    [SerializeField]
    float horizontalInput;

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(horizontalInput * turningSpeed * Time.deltaTime, 0, speed * Time.deltaTime);

        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //transform.Translate(Vector3.right * turningSpeed * Time.deltaTime * horizontalInput);
    }
}