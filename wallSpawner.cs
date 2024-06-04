using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSpawner : MonoBehaviour
{
    public GameObject wall;
    public float spawnRate = 5;
    private float timer = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnwall();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }else
        {
             spawnwall();
              timer = 0;
        }
        
    }

    void spawnwall()
    {

     Instantiate(wall, new Vector3(transform.position.x, Random.Range(-2,2), 0), transform.rotation);
    }

}
