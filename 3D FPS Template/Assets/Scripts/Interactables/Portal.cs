using System;
using UnityEngine;

public class Portal : Interactable
{
    [Header("Portal Settings")]
    [Tooltip("The location where the player will be teleported to when interacting with the portal. / Pozice, kam bude hráč teleportován po interakci s portálem.")]
    public Vector3 teleportLocation = Vector3.zero;
    bool teleported = false;
    Collider player;

    public override void Interact(Collider other)
    {
        base.Interact(other);
        // Teleport the player to the specified location
        Debug.Log("player interact" + teleportLocation);
        teleported = true;
        player = other;
    }

    private void OnDrawGizmos() // Shows a debug sphere where to teleport player
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(teleportLocation, 1f);
    }

    void FixedUpdate()
    {
        if (teleported) {
            player.transform.position = teleportLocation;
            teleported = false;
        }

        
    }
}
