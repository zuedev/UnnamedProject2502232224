using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

/*
 * StarsFollowPlayer.cs
 *
 * This script is attached to the stars in the sky. It makes the stars follow the player.
 */
public class StarsFollowPlayer : UdonSharpBehaviour
{
    void Start()
    {
        // Set the initial position of the stars to the player's position
        transform.position = Networking.LocalPlayer.GetPosition();
    }

    void Update()
    {
        // Set the position of the stars to the player's position
        transform.position = Networking.LocalPlayer.GetPosition();
    }
}
