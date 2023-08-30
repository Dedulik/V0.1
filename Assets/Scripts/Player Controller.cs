using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 7f;
    public float jumpPower = 200f;
    public bool ground;
    public Rigidbody rb;

    
    private void Start()
    {
        
    }
   
    private void Update()
    {
        
        GetInput();
        
        
    }

    private void GetInput()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(ground == true)
            {
                rb.AddForce(transform.up * jumpPower);
            }
        }
        if (Input.GetKey("left shift"))
        {
            speed = 11;
        }
        if (Input.GetKeyUp("left shift"))
        {
            speed = 7;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        ground = false;
    }

}
