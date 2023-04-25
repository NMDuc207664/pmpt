using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComHealthLost : MonoBehaviour
{
    // Start is called before the first frame update
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
         if ((collision.tag == "Catk1" || collision.tag == "Catk2" ||collision.tag == "Catk3"||collision.tag == "Aatk1" ||collision.tag == "Aatk2"||collision.tag == "Aatk3"||collision.tag == "Aarrow")&& atk.isblock == false)
            {
                health.anim.SetTrigger("hurt");
            }
        if(atk.isblock == false && gameObject.tag == "Commander"){
            if (collision.tag == "Catk1"){
                health.AmountOfHealth-=0.25f;
                //healthBar.Health(AmountOfHealth);
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-25" + health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Catk2"){
                health.AmountOfHealth-=0.35f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-35 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Catk3"){
                health.AmountOfHealth-=0.70f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-70 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Aatk1"){
                health.AmountOfHealth-=0.15f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-15 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);           
            }
            else if (collision.tag == "Aatk2"){
                health.AmountOfHealth-=0.23f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-23 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Aatk3"){
                health.AmountOfHealth-=0.35f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-35 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Aarrow"){
                health.AmountOfHealth-=0.70f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-70 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
        }
        else if(atk.isblock == true && gameObject.tag == "Commander"){
            if (collision.tag == "Catk1"){
                health.AmountOfHealth-=0.25f;
                //healthBar.Health(AmountOfHealth);
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-25" + health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Catk2"){
                health.AmountOfHealth-=0.35f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-35 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Catk3"){
                health.AmountOfHealth-=0.70f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-70 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Aatk1"){
                health.AmountOfHealth-=0.15f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-15 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);           
            }
            else if (collision.tag == "Aatk2"){
                health.AmountOfHealth-=0.23f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-23 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Aatk3"){
                health.AmountOfHealth-=0.35f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-35 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
            else if (collision.tag == "Aarrow"){
                health.AmountOfHealth-=0.70f;
                health.DeadChecker(health.AmountOfHealth);
                Debug.Log("-70 "+ health.AmountOfHealth);
                health.healthBar.Health(health.AmountOfHealth);
            }
        }
    }
}
