using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

[CreateAssetMenu(menuName = "Game Event")]
public class GameEvent : ScriptableObject
{
    public List<GameEventListener> listenerList = new List<GameEventListener>();

=======
using Unity.Netcode;

[CreateAssetMenu(menuName = "Game Event")]
public class GameEvent : ScriptableObject, INetworkSerializeByMemcpy
{
    public List<GameEventListener> listenerList = new List<GameEventListener>();


>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
    // Call event though different methods signatures
    public void Call()
    {
        for(int i = 0; i < listenerList.Count; i++)
        {
            listenerList[i].OnEventCall();
        }
    }

    // Manage Listeners
    public void RegisterListener(GameEventListener listener)
    {
        if (!listenerList.Contains(listener))
        {
            listenerList.Add(listener);
        }
    }

    public void UnregisterListener(GameEventListener listener)
    {
        if (listenerList.Contains(listener))
        {
            listenerList.Remove(listener);
        }
    }
}
