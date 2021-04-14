using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using Unity;

public class SelectMenuUI : MonoBehaviour
{
    [Header("Player Info")]
    public PlayerInfo isRedConnected;
    public PlayerInfo isBlueConnected;
    public PlayerInfo isYellowConnected;
    public PlayerInfo isGreenConnected;

    [Header("UI Elements")]
    public RawImage PlayerRed;
    public RawImage PlayerBlue;
    public RawImage PlayerYellow;
    public RawImage PlayerGreen;

    [Header("Materials")]
    public Material PlayerRedMaterial;
    public Material PlayerBlueMaterial;
    public Material PlayerYellowMaterial;
    public Material PlayerGreenMaterial;
    public Material PlayerDisconnectedMaterial;

    private bool isLoadingScene = false;

    private void Awake()
    {
        isRedConnected.Reset();
        isBlueConnected.Reset();
        isYellowConnected.Reset();
        isGreenConnected.Reset();
    }

    public void OnPlayerJoin(PlayerInput playerInput)
    {
        if (isLoadingScene)
            return;

        Debug.Log("Player Joined: " + playerInput.playerIndex);

        // 1 - Get first empty space
        // 2 - Set as occupied
        // 3 - Update UI
        if (isRedConnected.playerIndex == -1)
        {
            isRedConnected.playerIndex = playerInput.playerIndex;
            PlayerRed.color = PlayerRedMaterial.color;
        }
        else if (isBlueConnected.playerIndex == -1)
        {
            isBlueConnected.playerIndex = playerInput.playerIndex;
            PlayerBlue.color = PlayerBlueMaterial.color;
        }
        else if (isYellowConnected.playerIndex == -1)
        { 
            isYellowConnected.playerIndex = playerInput.playerIndex;
            PlayerYellow.color = PlayerYellowMaterial.color;
        }
        else if (isGreenConnected.playerIndex == -1)
        { 
            isGreenConnected.playerIndex = playerInput.playerIndex;
            PlayerGreen.color = PlayerGreenMaterial.color;
        }
    }

    public void OnPlayerLeft(PlayerInput playerInput)
    {
        if (isLoadingScene)
            return;

        Debug.Log("Player Lefted: " + playerInput.playerIndex);
        
        // 1 - Get the player who left
        // 2 - Set as available
        // 3 - Update UI
        if (isRedConnected.playerIndex == playerInput.playerIndex)
        {
            isRedConnected.playerIndex = -1;
            PlayerRed.color = PlayerDisconnectedMaterial.color;
        }
        else if (isBlueConnected.playerIndex == playerInput.playerIndex)
        {
            isBlueConnected.playerIndex = -1;
            PlayerBlue.color = PlayerDisconnectedMaterial.color;
        }
        else if (isYellowConnected.playerIndex == playerInput.playerIndex)
        {
            isYellowConnected.playerIndex = -1;
            PlayerYellow.color = PlayerDisconnectedMaterial.color;
        }
        else if (isGreenConnected.playerIndex == playerInput.playerIndex)
        {
            isGreenConnected.playerIndex = -1;
            PlayerGreen.color = PlayerDisconnectedMaterial.color;
        }
    }


    public void OnLoadLevelOne()
    {
        isLoadingScene = true;
        SceneManager.LoadScene("MainScene");
    }
}