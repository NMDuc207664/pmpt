using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    public HealthDecrease healthDecrease;
    [SerializeField] private GameObject Orange;
    [SerializeField] private Transform OrangeDrop;
    private int Oranges = 0;
    // [SerializeField] private Text cherriesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruits"))
        {
            Destroy(collision.gameObject);
            Oranges++;
            // cherriesText.text = "Oranges: "+Oranges;
        }
    }
    public void CheckonDead(){
        if(healthDecrease.die == true && Oranges>0){
            Oranges--;
            Instantiate(Orange, OrangeDrop.position, transform.rotation);
        }
    }
    void Update(){
        CheckonDead();
        //Debug.Log(Oranges);
    }
}