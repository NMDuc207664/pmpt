using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherHealthLost : MonoBehaviour
{
    // Start is called before the first frame update
    public HealthDecrease health;

     private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.tag == "Catk1" || collision.tag == "Catk2" ||collision.tag == "Catk3"||collision.tag == "Aatk1" ||collision.tag == "Aatk2"||collision.tag == "Aatk3"||collision.tag == "Aarrow")
            {
                health.anim.SetTrigger("hurt");
            }
         if (collision.tag == "Catk1"){
            health.AmountOfHealth-=0.25f;
            health.DeadChecker(health.AmountOfHealth);
            health.healthBar.Health(health.AmountOfHealth);
         }
         else if (collision.tag == "Catk2"){
            health.AmountOfHealth-=0.35f;
            health.DeadChecker(health.AmountOfHealth);
            health.healthBar.Health(health.AmountOfHealth);
         }
         else if (collision.tag == "Catk3"){
            health.AmountOfHealth-=0.70f;
            health.DeadChecker(health.AmountOfHealth);
            health.healthBar.Health(health.AmountOfHealth);
         }
         else if (collision.tag == "Aatk1"){
            health.AmountOfHealth-=0.15f;
            health.DeadChecker(health.AmountOfHealth);
            health.healthBar.Health(health.AmountOfHealth);           
         }
         else if (collision.tag == "Aatk2"){
            health.AmountOfHealth-=0.23f;
            health.DeadChecker(health.AmountOfHealth);
            health.healthBar.Health(health.AmountOfHealth);
         }
         else if (collision.tag == "Aatk3"){
            health.AmountOfHealth-=0.35f;
            health.DeadChecker(health.AmountOfHealth);
            health.healthBar.Health(health.AmountOfHealth);
         }
         else if (collision.tag == "Aarrow"){
            health.AmountOfHealth-=0.70f;
            health.DeadChecker(health.AmountOfHealth);
            health.healthBar.Health(health.AmountOfHealth);
         }
    }
}
