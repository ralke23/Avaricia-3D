using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Local variables
    public float playerSpeed;
    public float playerTurn;
    public GameObject ballTrigger;
    // Modifify Animator parameters
    public Animator playerAnimator;
    private Vector3 lastMove;
    public GameObject playerDirection;
    public float idleBlendValue;
    public float runBlendValue;
    //Rigidbody playerRigidbody;
    public GameObject shieldGeo;
    bool moving;
    float movementX;
    float movementY = 0;
    public float range;
    public GameObject Shield;
    public GameObject EText;

    void Start()
    {
            // Access to Animator component on start
            playerAnimator = GetComponent<Animator>();
            ballTrigger.gameObject.SetActive(false);
            playerSpeed = 0;
            //playerRigidbody = GetComponent<Rigidbody>();
            //lastMove = new Vector3(0, 5, 0);
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball_sub3_true") && !shieldGeo.activeSelf)
        {
            //Bool animation death
            Debug.Log("Death");
            //playerAnimator.SetBool("Death", true);
        }
        else if (collision.gameObject.CompareTag("Ball_sub3_true") && shieldGeo.activeSelf)
        {
            //Bool animation death
            playerAnimator.SetBool("Death", true);
            Debug.Log("Death2");
        }
    }

    /// This will be called once when we change enabled from true to false.

void Update()
    {
        // Get player data (input)
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        //Raycast
        Vector3 playerRay = Vector3.back;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(playerRay * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(playerRay * range));

        // Apuntar
       if (Input.GetKey(KeyCode.RightControl) && y > 0)
        {
            Debug.Log("Apuntando Norte");
        }

        // Shield 

        if (Input.GetKey(KeyCode.E) && Shield.activeSelf)
        {
            Debug.Log("Using E");
            playerSpeed = 0;
            playerAnimator.SetBool("Shield", true);
            movementX = 0;
            movementY = 0;
            ballTrigger.gameObject.SetActive(true);
            range = 1;
            EText.SetActive(false);
            return;         
        }

        else if (Input.GetKey(KeyCode.E) && !Shield.activeSelf)
        {
            Debug.Log("Aun no tiene escudo");
        }

            if (Physics.Raycast(theRay, out RaycastHit hit, range))
        {
            if (hit.collider.tag == "Wall")
            {
                print("Chocando pared");
                playerAnimator.SetBool("Caminar", false);
                playerSpeed = 0;
            }
            else if (hit.collider.tag == "Ball_sub3_true")
            {
                print("Colliding Fireeball");
                playerSpeed = 0;
            }
        }

        // Tiled walk
        if (movementX > 0)
        {
            movementX = movementX + 100;
        }
        else if (movementY < 0)
        {
            movementY = movementY + 100;
        }

        //In update
        if (x != 0)
            {
                movementX = x;
                movementY = 0;
                moving = true;
            }
            else if (y != 0)
            {
                movementX = 0;
                movementY = y;
                moving = true;
            }
            if (moving)
            {
                if (x == 0 && y == 0)
                {
                    movementX = 0;
                    movementY = 0;
                    moving = false;
                }
                else if (x != 0 & y != 0)
            {
                moving = false;
            }
            }

            // Save in xyz
            Vector3 direction = new Vector3(movementX, 0, movementY);

        // Apply the movement
        // Use transform.Position(); if character teleports
        transform.Translate(direction * playerSpeed * Time.deltaTime, Space.World);
        //transform.Translate(direction * playerSpeed * Time.deltaTime, Space.World);

        // If player moves, turn direction
        if (direction != Vector3.zero)
        {
            // Generate advanced rotation, rotate where you look
            Quaternion rota = Quaternion.LookRotation(direction, Vector3.up);

            // Apply rotations to character
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rota, playerTurn);

            // Text variable (string) that calls Animator's boolean
            playerAnimator.SetBool("Caminar", true);
            playerSpeed = 3;
        }

        else if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * playerSpeed * Time.deltaTime, 0f, 0f));
            lastMove = new Vector3(Input.GetAxisRaw("Horizontal"), 0f);
        }

        //Angulos de Euler (by ralke)
        // Se utiliza indleBlendValue para fijar direccion a traves de variable float

        // Norte
        else if (playerDirection.transform.rotation.eulerAngles.y == 0 && playerSpeed == 0)
        {
            Debug.Log("Miro Arriba");
            playerAnimator.SetBool("Caminar", false);
            idleBlendValue = 2f;
            playerAnimator.SetFloat("IdleBlend", idleBlendValue);
            playerSpeed = 0;
        }

        // Sur
        else if (playerDirection.transform.rotation.eulerAngles.y == 180 && playerSpeed == 0)
        {
            Debug.Log("Miro Abajo");
            //playerAnimator.SetBool("Caminar", false);
            playerAnimator.SetBool("Shield", false);
            idleBlendValue = 0f;
            playerAnimator.SetFloat("IdleBlend", idleBlendValue);
            playerSpeed = 0;
        }

        // Oeste (izquierda)
        else if (playerDirection.transform.rotation.eulerAngles.y == 270 && playerSpeed == 0)
        {
            Debug.Log("Miro Izquierda");
            //playerAnimator.SetBool("Caminar", false);
            playerAnimator.SetBool("Shield", false);
            idleBlendValue = 3f;
            playerAnimator.SetFloat("IdleBlend", idleBlendValue);
            playerSpeed = 0;
        }
        // Este (derecha)
        else if (playerDirection.transform.rotation.eulerAngles.y == 90 && playerSpeed == 0)
        {
            Debug.Log("Miro Derecha");
            //playerAnimator.SetBool("Caminar", false);
            playerAnimator.SetBool("Shield", false);
            idleBlendValue = 4f;
            playerAnimator.SetFloat("IdleBlend", idleBlendValue);
            playerSpeed = 0;
            
        }

        else
        {
            playerAnimator.SetBool("Caminar", false);
            playerAnimator.SetBool("Shield", false);
            ballTrigger.gameObject.SetActive(false);
            playerAnimator.GetComponent<Player>().enabled = true;
            playerSpeed = 0;
            range = 0.5f;
            return;
        }

       // Run rotations
        if (playerDirection.transform.rotation.eulerAngles.y == 0 && playerSpeed == 3)
        {
            Debug.Log("Run Arriba");
            playerAnimator.SetBool("Caminar", true);
            runBlendValue = 1f;
            playerAnimator.SetFloat("RunBlend", runBlendValue);
            playerSpeed = 3;
        }

        else if (playerDirection.transform.rotation.eulerAngles.y == 180 && playerSpeed == 3)
        {
            Debug.Log("Run Abajo");
            playerAnimator.SetBool("Caminar", true);
            runBlendValue = 0f;
            playerAnimator.SetFloat("RunBlend", runBlendValue);
            playerSpeed = 3;
        }

        // Este (derecha)
        else if (playerDirection.transform.rotation.eulerAngles.y == 90 && playerSpeed == 3)
        {
            Debug.Log("Corro Derecha");
            playerAnimator.SetBool("Caminar", true); 
            runBlendValue = 2f;
            playerAnimator.SetFloat("RunBlend", runBlendValue);
            playerSpeed = 3;
        }
        else if (playerDirection.transform.rotation.eulerAngles.y == 270 && playerSpeed == 3)
        {
            Debug.Log("Corro Izquierda");
            playerAnimator.SetBool("Caminar", true);
            runBlendValue = 3f;
            playerAnimator.SetFloat("RunBlend", runBlendValue);
            playerSpeed = 3;
        }
        // Condicionales restantes (no entran en ninguna variable)

    }
}
