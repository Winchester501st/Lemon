using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{public Rigidbody rb;
    public float jumpForce;
    float speed = 5.0f;
    float _speedMultiplier = 1f;
    // Start is called before the first frame update
    void Start()
    {
        speed = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        
if (Input.GetKeyDown(KeyCode.Space))
{
    _speedMultiplier = 3f;
}
if (Input.GetKeyUp(KeyCode.Space))
{
    _speedMultiplier = 1f;
}
    }
}