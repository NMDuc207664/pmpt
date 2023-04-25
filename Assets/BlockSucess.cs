using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSucess : MonoBehaviour
{
    public HealthDecrease health;
    public CommanderAttack atk;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(atk.isblock == true){
            if (collision.tag == "Catk1"){
                health.AmountOfHealth-=0.25f/2f;
                //healthBar.Health(AmountOfHealth);
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-25" + health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Catk2"){
                health.AmountOfHealth-=0.35f/2f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-35 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Catk3"){
                health.AmountOfHealth-=0.70f/2f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-70 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Aatk1"){
                health.AmountOfHealth-=0.15f/2f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-15 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);           
            }
            else if (collision.tag == "Aatk2"){
                health.AmountOfHealth-=0.23f/2f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-23 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Aatk3"){
                health.AmountOfHealth-=0.35f/2f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-35 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Aarrow"){
                health.AmountOfHealth-=0.70f/2f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-70 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
        }
    }
}
