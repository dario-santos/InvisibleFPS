using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerEventHandler : MonoBehaviour
{
    public void OnPlayerLeft(PlayerInput playerInput)
    {
        Destroy(gameObject);
        // 1 - Get the player who left
        // 2 - Set as available
    }
}
