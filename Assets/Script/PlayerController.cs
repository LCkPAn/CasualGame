using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    [SerializeField]
    private float moveSpeed = 5f;

    private float maxSpeed = 20f;
   
    void Update()
    {
        float hMovement = moveSpeed;
        transform.Translate(new Vector3(0, 0, hMovement) * Time.deltaTime);

        if (moveSpeed < maxSpeed)
        {
            moveSpeed += 0.2f * Time.deltaTime;
        }

    }

   
}
