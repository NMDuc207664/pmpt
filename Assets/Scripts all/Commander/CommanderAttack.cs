using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommanderAttack : MonoBehaviour
{
    [Header("Attack hit box")]
    [SerializeField] private GameObject lightHitboxC1;
    [SerializeField] private GameObject lightHitboxC2;
    [SerializeField] private GameObject heavyHitboxC;
    
    public HealthDecrease health;
    // All the require Components
    [HideInInspector] public Animator anim; 
    private float moveHorizontal;

    [SerializeField] public static bool isblock;

    [Header("Ground Checker")]
    [SerializeField] private BoxCollider2D checkCollision;

    [SerializeField] [Range(0.1f, 0.3f)] private float rayBuffer = 0.2f;


    [Header("Layer Mask")]
    public LayerMask jumpableGround;

    private void Start()
    {  
        anim = GetComponent<Animator>();
        deActivateAllatk();
    }

    // Update is called once per frame
    private void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal"); 
        UpdateAnimationAttack();
    }

    #region Requirement

    public static CommanderAttack instance;
    // For combo attack
    private void Awake()
    {
        instance = this;
    }

    // Check the ground to attack
    private bool isGround()
    {
        return Physics2D.BoxCast(checkCollision.bounds.center, checkCollision.bounds.size, 0f, Vector2.down, rayBuffer, jumpableGround);
    }
    
    #endregion

    #region Attack 

    [Header("Light Attack stats")]
    [SerializeField] private float attack1Rate = 0.5f;

    public bool isAttacking1 = false;

    [Header("Heavy Attack stats")]
    [SerializeField] private float attack2Rate = 0.8f;

    public bool isAttacking2 = true;

    private float nextTimeAttack1 = 0f;
    private float nextTimeAttack2 = 0f;

    // Trigger the light attack hurtbox in animation event
    private void LightAttack()
    {
        nextTimeAttack1 = Time.time + attack1Rate;
    }

    // Trigger the heavy attack hurtbox in animation event
    private void HeavyAttack()
    {
        nextTimeAttack2 = Time.time + attack2Rate;
    }

    // Shoot out arrow when call in animation event

    public void ActivateLatk1(){
        lightHitboxC1.SetActive(true);
    }
     public void ActivateLatk2(){
        lightHitboxC2.SetActive(true);
    }
     public void ActivateLatk3(){
        heavyHitboxC.SetActive(true);
    }
    public void deActivateLatk1(){
        lightHitboxC1.SetActive(false);
    }
    public void deActivateLatk2(){
        lightHitboxC2.SetActive(false);
    }
    public void deActivateLatk3(){
        heavyHitboxC.SetActive(false);
    }

    public void deActivateAllatk(){
        lightHitboxC1.SetActive(false);
        lightHitboxC2.SetActive(false);
        heavyHitboxC.SetActive(false);
        
    }

    private void UpdateAnimationAttack()
    {
        // If the player in on the ground and trigger then attack
        if (isGround() && !isAttacking1)
        {
            if(Input.GetButtonDown("LightAttack")){
                if (Time.time >= nextTimeAttack1) 
                {
                    isAttacking1 = true;
                }
                deActivateAllatk(); 
            }
        }
        
        if (isGround())
        {
            if(Input.GetButtonDown("HeavyAttack")){
                if (Time.time >= nextTimeAttack2)
                {
                    isAttacking2 = true;
                }
                deActivateAllatk();
            }
        }
        if (isGround() && health.isDie == false){
            if (Input.GetKey(KeyCode.L))
            {
                isblock = true;
                anim.SetBool("isblock", isblock);
                
            }
            else
            {
                isblock = false;
                anim.SetBool("isblock", isblock);
            }
        }

    }

    #endregion
}

