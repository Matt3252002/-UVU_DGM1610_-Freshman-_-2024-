using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class PlayerCrouching : MonoBehaviour
{
    public CharacterController playerController;
    public float crouchSpeed, normalHeight, crouchHeight; // stores number variables like integers
    public Vector3 offset;
    public Transform player;
    bool crouching;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl)) // assigning crouch button
        {
            crouching = !crouching;
        }
        if(crouching == true)
        {
            playerController.height = playerController.height - crouchSpeed * Time.deltaTime;
            if(playerController.height <= crouchHeight)
            {
                playerController.height = crouchHeight;
            }

        }
        if (crouching == false)
        {
            playerController.height = playerController.height + crouchSpeed * Time.deltaTime;
            if (playerController.height < normalHeight)
            {
                player.gameObject.SetActive(false); // safeguard for code, prevents player from falling or colliding
                player.position = player.position + offset * Time.deltaTime; // safeguard for code, adds smoothness
                player.gameObject.SetActive(true);
            }
            if (playerController.height >= normalHeight)
            {
                playerController.height = normalHeight;
            }

        }
    }
}
