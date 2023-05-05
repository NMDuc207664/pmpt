using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDecrease : MonoBehaviour
{
    // Start is called before the first frame update
    
    public HealthBarBehavior healthBar;
    [SerializeField] private GameObject YourCharacter;
    [SerializeField] private GameObject isDead;
    public Spawnpoint sp;
    [SerializeField] private float ArcherH = 3f;
    [SerializeField] private float CommanderH = 3.5f;
    public float AmountOfHealth;
    public Animator anim;
    public bool isDie;
    public Collider2D collision;

    void Start()
    {
        // Deactive isDie and assign heath character to their health bar
        deCo();
        anim = GetComponent<Animator>();
        if(collision.tag == "Commander"){
            AmountOfHealth = CommanderH;
            healthBar.currenthealth = AmountOfHealth;
        }
        else if (collision.tag == "Archer"){
            AmountOfHealth = ArcherH;
            healthBar.Health(AmountOfHealth);
            healthBar.currenthealth = AmountOfHealth;
        }
    }

    void Update()   
    {
         //healthBar.Health(AmountOfHealth);
         //Debug.Log(AmountOfHealth);
    }
    public void DeadChecker(float health){

        if(health<=0)
        {
            isDie = true;
            anim.SetTrigger("die");
            Co();
            Debug.Log(isDie);
            Invoke("Revive", 5);
            Invoke("Destroy", 5);
        }
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
    public void Revive(){
        if(collision.tag == "Archer"){
            sp.RespawnArcher();
        }
        else  if(collision.tag == "Commander"){
            sp.RespawnCommander();
        }
    }

    private void deCo(){
        isDead.SetActive(false);
    }
    private void Co(){
        isDead.SetActive(true);
    }
}