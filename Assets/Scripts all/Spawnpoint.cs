using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{   
    public GameObject character1;
    public GameObject character2;
    public HealthDecrease health1;
    public HealthDecrease health2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnArcher(){
        Instantiate(character1,transform.position, transform.rotation);
        health1.die = false;
    }
    public void RespawnCommander(){
        Instantiate(character2,transform.position, transform.rotation);
        health2.die = false;
    }
}
