using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class MagnetControl : MonoBehaviour
=======
using Unity.Netcode;
public class MagnetControl : NetworkBehaviour
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
{
    [SerializeField] private AreaEffector2D buttonArea;
    [SerializeField] private GameObject buttonEffect;
    [SerializeField] private bool isTurnOn = true;
    private ParticleSystem spawnEffect;
    private BoxCollider2D fieldEffect;

    private void Start()
    {
        spawnEffect = buttonEffect.GetComponent<ParticleSystem>();
        fieldEffect = GetComponent<BoxCollider2D>();
        // Set how the magnet active in the beginsceen
        if (isTurnOn)
        {
            fieldEffect.enabled = true;
            buttonArea.enabled = true;
            buttonEffect.SetActive(true);
            spawnEffect.Play();
            isTurnOn = true;

        }
        else
        {
            fieldEffect.enabled = false;
            buttonArea.enabled = false;
            buttonEffect.SetActive(false);
            isTurnOn = false;
        }
<<<<<<< HEAD
=======
        MagnetServerRpc();
    }

    [ServerRpc]
    private void MagnetServerRpc()  
    {
        spawnEffect = buttonEffect.GetComponent<ParticleSystem>();
        fieldEffect = GetComponent<BoxCollider2D>();
        // Set how the magnet active in the beginsceen
        if (isTurnOn)
        {
            fieldEffect.enabled = true;
            buttonArea.enabled = true;
            buttonEffect.SetActive(true);
            spawnEffect.Play();
            isTurnOn = true;

        }
        else
        {
            fieldEffect.enabled = false;
            buttonArea.enabled = false;
            buttonEffect.SetActive(false);
            isTurnOn = false;
        }
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
    }

    public void TurnOnandOff()
    {
        if (isTurnOn)
        {
            fieldEffect.enabled = false;
            buttonArea.enabled = false;
            buttonEffect.SetActive(false);
            isTurnOn = false;
            
        }
        else
        {
            fieldEffect.enabled = true;
            buttonArea.enabled = true;
            buttonEffect.SetActive(true);
            spawnEffect.Play();
            isTurnOn = true;
        }
    }
<<<<<<< HEAD
=======

>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
}
