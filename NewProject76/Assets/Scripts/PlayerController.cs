using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public bool onGround = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("In game");
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 10);

        } else if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * (-10));
        }
        if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
        {
            playerRb.AddForce(Vector3.up *5, ForceMode.Impulse);
            onGround = false;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
            
        }
    }
}
