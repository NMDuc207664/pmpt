using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDecrease : MonoBehaviour
{
    // Start is called before the first frame update
    //public HealthBar healthBar;
    public HealthBarBehavior healthBar;
    [SerializeField] private GameObject YourCharacter;
   
    [SerializeField] private GameObject isDead;
   //[SerializeField] private GameObject spawnpoint;
    public Spawnpoint sp;
    public float ArcherH = 3f;
    public float CommanderH = 3.5f;
    public float AmountOfHealth;
    public Animator anim;
    public bool die;
    //private float healthnow;
    public Collider2D collision;
    public float currentHealth;
    void Start()
    {
        //healthBar = GetComponent<HealthBarBehavior>();
        deCo();
        //atk = GetComponent<CommanderAttack>();
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

    // Update is called once per frame
    void Update()
    
    {
         //healthBar.Health(AmountOfHealth);
         Debug.Log(AmountOfHealth);
    }
    public void DeadChecker(float health){

        if(health<=0)
        {
            die = true;
            anim.SetTrigger("die");
            Co();
            Debug.Log(die);
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