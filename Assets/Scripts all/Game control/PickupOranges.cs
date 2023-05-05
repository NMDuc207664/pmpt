using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupOranges: MonoBehaviour
{
    private int orangeCount = 0;
    [SerializeField] private GameObject Oranges;

    [Header("Assign player pick up")]
    public GameObject playerPickUp;
    public HealthDecrease PlayerDeath;
    [SerializeField] private GameEvent hasPickUp;

    [Header("Assign player killed")]
    [SerializeField] private GameEvent hasDrop;

    private void Update()
    {
        CheckDead();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            playerPickUp = collision.gameObject;
            PlayerDeath = playerPickUp.GetComponent<HealthDecrease>();
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.position = playerPickUp.transform.position;
            gameObject.transform.SetParent(playerPickUp.transform);
            orangeCount++;
            hasPickUp.Call(this,orangeCount);
        }
    }

    private void CheckDead()
    {
        if (orangeCount > 0 && PlayerDeath.isDie)
        {
            gameObject.transform.SetParent(null);
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            orangeCount--;
            hasDrop.Call(this, orangeCount);
        }
    }
   
}