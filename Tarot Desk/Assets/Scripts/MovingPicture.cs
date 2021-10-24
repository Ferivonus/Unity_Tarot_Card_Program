using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPicture : MonoBehaviour
{
    private const float SPEED = 160f;
    private const float RUN = 1.5f;
    void Update()
    {
        Movment();

    }
    private void Movment()
    {
        float MoveX = 0f;
        float MoveY = 0f;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            MoveY = +1F;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            MoveY = -1F;

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            MoveX = -1F;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            MoveX = +1F;
        }
        Vector3 moveDir = new Vector3(MoveX, MoveY).normalized;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += moveDir * SPEED * RUN * Time.deltaTime;
        }
        else
        {
            transform.position += moveDir * SPEED * Time.deltaTime;
        }
    }
    /*private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("trigger was working!!");
    }*/
}
