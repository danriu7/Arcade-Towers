using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction : MonoBehaviour
{
    [SerializeField] private float speed;
    //private Vector3 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        
        if (Input.GetKey(KeyCode.W))
        {

            Vector3 forward = transform.forward;
            direction += forward; // * (speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 forward = transform.forward;
            direction -= forward; // * (speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 right = transform.right;
            direction += right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 right = transform.right;
            direction -= right;
        }

        if (Input.GetKey(KeyCode.C))
        {
            Vector3 jump = transform.up;
            direction += jump;
        }

        direction = direction.normalized;
        direction.y = 0;
        transform.position += direction * (speed * Time.deltaTime);
    }
}
