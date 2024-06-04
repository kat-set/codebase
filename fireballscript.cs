using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float movespeed = 3;
    public float flapStrenght;
    public Renderer myrenderer2;


     //float highestPoint = transform.position.y + 11;
     //float lowestPoint = transform.position.y + 6;



    // Start is called before the first frame update
     void Start()
    {
      myrenderer2.enabled=false; 
    }

    // Update is called once per frame
    void Update()
    {
           if (Input.GetKeyDown(KeyCode.Tab) == true)
        {
           myrenderer2.enabled=true;
        }

            if (Input.GetKeyUp(KeyCode.Tab) == true)
        {
           myrenderer2.enabled=false;
        }


        
       if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrenght;
        }

    }
}
