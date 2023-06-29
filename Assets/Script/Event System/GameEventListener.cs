using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
<<<<<<< HEAD

public class GameEventListener : MonoBehaviour
=======
using Unity.Netcode;
public class GameEventListener : NetworkBehaviour
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
{
    // Check if there is a event happening
    public GameEvent gameEvent;
    // Preform the unity event response to the call
    public UnityEvent response;

    public void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    public void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }

    public virtual void OnEventCall()
    {
        response.Invoke();
    }
}
