using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTeleport : MonoBehaviour
{
    public bool IsTeleportEnabled = true;

    public void EnableTeleport() { IsTeleportEnabled = true; }
    public void Teleport(GameObject destination)
    {
        if (IsTeleportEnabled)
        {
            transform.position = destination.transform.position;
        }
    }
}
