using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 20;
    private float lowerBound = -10;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < lowerBound) 
        {
            Destroy(gameObject);
            Debug.Log("Game Over.   Player1!");
            player.gameOver = true;
        
        }
    }
}
