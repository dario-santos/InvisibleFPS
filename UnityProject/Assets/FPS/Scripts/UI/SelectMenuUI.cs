using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectMenuUI : MonoBehaviour
{
    private int isRedConnected    = -1;
    private int isBlueConnected   = -1;
    private int isYellowConnected = -1;
    private int isGreenConnected  = -1;

    private PlayerInput redController    = null;
    private PlayerInput blueController   = null;
    private PlayerInput yellowController = null;
    private PlayerInput greenController   = null;

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

    private void Awake()
    {
        // Don't destroy the information about the connected players
        //DontDestroyOnLoad(isRedConnected);

    }

    public void OnPlayerJoin(PlayerInput playerInput)
    {
        Debug.Log("Player Joined: " + playerInput.playerIndex);

        // 1 - Get first empty space
        // 2 - Set as occupied
        // 3 - Update UI
        if (isRedConnected == -1)
        {
            isRedConnected = playerInput.playerIndex;
            PlayerRed.color = PlayerRedMaterial.color;
        }
        else if (isBlueConnected == -1)
        {
            isBlueConnected = playerInput.playerIndex;
            PlayerBlue.color = PlayerBlueMaterial.color;
        }
        else if (isYellowConnected == -1)
        { 
            isYellowConnected = playerInput.playerIndex;
            PlayerYellow.color = PlayerYellowMaterial.color;
        }
        else if (isGreenConnected == -1)
        { 
            isGreenConnected = playerInput.playerIndex;
            PlayerGreen.color = PlayerGreenMaterial.color;
        }
    }

    public void OnPlayerLeft(PlayerInput playerInput)
    {
        Debug.Log("Player Lefted: " + playerInput.playerIndex);
        
        // 1 - Get the player who left
        // 2 - Set as available
        // 3 - Update UI
        if (isRedConnected == playerInput.playerIndex)
        {
            isRedConnected = -1;
            PlayerRed.color = PlayerDisconnectedMaterial.color;
        }
        else if (isBlueConnected == playerInput.playerIndex)
        {
            isBlueConnected = -1;
            PlayerBlue.color = PlayerDisconnectedMaterial.color;
        }
        else if (isYellowConnected == playerInput.playerIndex)
        {
            isYellowConnected = -1;
            PlayerYellow.color = PlayerDisconnectedMaterial.color;
        }
        else if (isGreenConnected == playerInput.playerIndex)
        {
            isGreenConnected = -1;
            PlayerGreen.color = PlayerDisconnectedMaterial.color;
        }
    }


    public void OnLoadLevelOne()
    {
        SceneManager.LoadScene("MainScene");
    }
}
