using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 15;

    public float xRange = 20;

    public Transform blaster;
    public GameObject laserBolt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // this creates boundry for the left 
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // creates boundry for the right
        if(transform.position.x > xRange )
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // if button pressed, fire bolt
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
    }
}
