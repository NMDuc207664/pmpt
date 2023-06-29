using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class ActivatePlatform : MonoBehaviour
=======
using Unity.Netcode;
public class ActivatePlatform : NetworkBehaviour
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
{
    [Header("Moving property")]
    [SerializeField] private Transform positionA;
    [SerializeField] private Transform positionB;
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool isatpointA = false;
<<<<<<< HEAD
    Vector3 targetPos; 

    private RobotMovement movementControl;
=======
    Vector3 targetPos;

    [HideInInspector] public RobotMovement movementControl;
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
    private Rigidbody2D rbPlatform;
    private Vector3 moveDirection;

    private void Awake()
<<<<<<< HEAD
    {
        movementControl = GameObject.FindGameObjectWithTag("Player").GetComponent<RobotMovement>();
=======
    {  
        //movementControl = GameObject.FindGameObjectWithTag("Player").GetComponent<RobotMovement>();
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
        rbPlatform = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        targetPos = positionA.position;
        DirectionCaculate();
    }

    public void MovePlatform()
    {
        rbPlatform.velocity = moveDirection * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
=======
        if (!GameObject.FindGameObjectWithTag("Player")) return;
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
        // If platfrom is moving toward A point, check mark that it's in A
        if ((Vector2.Distance(transform.position, positionA.position) < 0.1f) && !isatpointA)
        {
            targetPos = positionB.position;
            DirectionCaculate();
            rbPlatform.velocity = Vector2.zero;
            isatpointA = true;
        }

        // And reverse if it's move toward B point
        else if ((Vector2.Distance(transform.position, positionB.position) < 0.1f) && isatpointA)
        {
            targetPos = positionA.position;
            DirectionCaculate();
            rbPlatform.velocity = Vector2.zero;
            isatpointA = false;
        }

        
    }

    // Change the direction base on the target position
    private void DirectionCaculate()
    {
        moveDirection = (targetPos - transform.position).normalized;
    }

    // Allow player to move smoothly on the platform
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            movementControl.isOnPlatform = true;
            movementControl.platformRB = rbPlatform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        movementControl.isOnPlatform = false;
        movementControl.platformRB = null;
    }
}
