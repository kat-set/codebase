using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public Logicscript logic;
    public bool birdIsAlive = true;
    


    // Start is called before the first frame update
    void Start()
    {
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrenght;
        }
        }
           private void OnTriggerEnter2D(Collider2D other)
        { 
            if(other.gameObject.CompareTag("coll"))
            {
                  logic.gameOver();
                  birdIsAlive = false;
            }
                
        }
    }

    
