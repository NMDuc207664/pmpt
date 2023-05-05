using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTracker : MonoBehaviour
{
    private int orangerStatel;
    public void UpdateHolder(Component sender, object data)
    {
        if(data is int)
        {
            orangerStatel = (int) data;
            if (orangerStatel > 0)
            {
                Debug.Log("Player " + orangerStatel);
            }
            else
            {
                Debug.Log("No Player ");
            }
        }
    }
}
