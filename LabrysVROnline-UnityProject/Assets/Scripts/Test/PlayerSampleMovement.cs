using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSampleMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Move(){
        rb.velocity = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), rb.velocity.z) * speed;
    }
}
