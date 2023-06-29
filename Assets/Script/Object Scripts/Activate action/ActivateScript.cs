using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class ActivateScript : MonoBehaviour
{
    [SerializeField] public GameEvent onActivate;
    [SerializeField] private bool isInteract = false;

    private void Update()
    {
        // Press the button to send active signal
=======
using Unity.Netcode;
public class ActivateScript : NetworkBehaviour
{
    [SerializeField] public GameEvent onActivate;
    [SerializeField] private bool isInteract = false;
    private void Update()
    {
        //Press the button to send active signal
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
        if (Input.GetButtonDown("Interact") && isInteract && !PauseMenu.isPause)
        {
            onActivate.Call();
        }
<<<<<<< HEAD
=======

>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
    }

    // If player near the panel, enable interact
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInteract = true;
        }
            
    }

<<<<<<< HEAD
=======
    [ServerRpc]
    private void SignalCallServerRpc(NetworkBehaviourReference eventRef, ServerRpcParams serverRpcParams)
    {
        ulong clientID = serverRpcParams.Receive.SenderClientId; 
        
        onActivate.Call();
    }

>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
    private void OnTriggerExit2D(Collider2D collision)
    {
        isInteract = false;
    }
<<<<<<< HEAD
=======

    [ClientRpc]
    private void ActivateClientRpc()
    {
        if (Input.GetButtonDown("Interact") && isInteract && !PauseMenu.isPause)
        {
            onActivate.Call();
        }
    }
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
}
