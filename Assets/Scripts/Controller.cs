using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private KeyCode leftKey;
    [SerializeField] private KeyCode rightKey;
    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;

    private Rigidbody rigidbody;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 finalVelocity = new Vector3(0, 0, 0);

        if (Input.GetKey(leftKey))
        {
            finalVelocity += new Vector3(-1, 0, 0);
        }
        else if (Input.GetKey(rightKey))
        {
            finalVelocity += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(upKey))
        {
            finalVelocity += new Vector3(0, 0, 1);
        }
        else if (Input.GetKey(downKey))
        {
            finalVelocity += new Vector3(0, 0, -1);
        }
        rigidbody.velocity = finalVelocity;
    }
}
