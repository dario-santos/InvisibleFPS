using System;
using System.Collections.Generic;
using Unity.FPS.Game;
using Unity.FPS.Gameplay;
using Unity.FPS.UI;
using UnityEngine;

public class ActivatePlayers : MonoBehaviour
{
    [Header("Players Objects")]
    public GameObject PlayerRed;
    public GameObject PlayerBlue;
    public GameObject PlayerYellow;
    public GameObject PlayerGreen;

    [Header("Player Info")]
    public PlayerInfo PlayerInfoRed;
    public PlayerInfo PlayerInfoBlue;
    public PlayerInfo PlayerInfoYellow;
    public PlayerInfo PlayerInfoGreen;

    [Header("User Interfaces Prefabs")]
    public GameObject TwoPlayers;
    public GameObject ThreePlayers;
    public GameObject FourPlayers;

    [Header("Two Player UI Componentes")]
    public List<PlayerHealthBar> healthBars;
    public List<WeaponHUDManager> weaponHUDManagers;
    public List<CrosshairManager> crosshairs;
    public List<FeedbackFlashHUD> feedbackFlashHUDs;


    [Header("Three Player UI Componentes")]
    public List<PlayerHealthBar> healthBarsThree;
    public List<WeaponHUDManager> weaponHUDManagersThree;
    public List<CrosshairManager> crosshairsThree;
    public List<FeedbackFlashHUD> feedbackFlashHUDThree;

    [Header("Four Player UI Componentes")]
    public List<PlayerHealthBar> healthBarsFour;
    public List<WeaponHUDManager> weaponHUDManagersFour;
    public List<CrosshairManager> crosshairsFour;
    public List<FeedbackFlashHUD> feedbackFlashHUDFour;

    private List<GameObject> players = new List<GameObject>();

    private void Awake()
    {

        PlayerInfoRed.kills = 0;
        PlayerInfoBlue.kills = 0;
        PlayerInfoGreen.kills = 0;
        PlayerInfoYellow.kills = 0;
        PlayerInfoRed.deaths = 0;
        PlayerInfoBlue.deaths = 0;
        PlayerInfoGreen.deaths = 0;
        PlayerInfoYellow.deaths = 0;
        PlayerInfoRed.flags = 0;
        PlayerInfoBlue.flags = 0;
        PlayerInfoGreen.flags = 0;
        PlayerInfoYellow.flags = 0;

        PlayerRed.SetActive(PlayerInfoRed.playerIndex != -1);
        if(PlayerInfoRed.playerIndex != -1)
            players.Add(PlayerRed);

        PlayerBlue.SetActive(PlayerInfoBlue.playerIndex != -1);
        if(PlayerInfoBlue.playerIndex != -1)
            players.Add(PlayerBlue);

        PlayerYellow.SetActive(PlayerInfoYellow.playerIndex != -1);
        if (PlayerInfoYellow.playerIndex != -1)
            players.Add(PlayerYellow);
        
        PlayerGreen.SetActive(PlayerInfoGreen.playerIndex != -1);
        if (PlayerInfoGreen.playerIndex != -1)
            players.Add(PlayerGreen);

        switch (players.Count)
        {
            case 2:
                SetTwoPlayerUI(players);
                break;
            case 3:
                SetThreePlayerUI(players);
                break;
            case 4:
                SetFourPlayerUI(players);
                break;
            default:
                Debug.Log("Invalid Number of players: " + players.Count);
                break;
        }
    }

    private void SetTwoPlayerUI(List<GameObject> players)
    {
        TwoPlayers.SetActive(true);

        for (int i = 0; i < players.Count; i++)
        {
            // Get Health
            healthBars[i].playerHealth = players[i].GetComponent<Health>();
            feedbackFlashHUDs[i].m_PlayerHealth = players[i].GetComponent<Health>();

            // Get WeaponsManager
            weaponHUDManagers[i].m_PlayerWeaponsManager = players[i].GetComponent<PlayerWeaponsManager>();

            // Get Crosshairs
            crosshairs[i].m_WeaponsManager = players[i].GetComponent<PlayerWeaponsManager>();
        }
    }

    private void SetThreePlayerUI(List<GameObject> players)
    {
        ThreePlayers.SetActive(true);

        for (int i = 0; i < players.Count; i++)
        {
            // Get Health
            healthBarsThree[i].playerHealth = players[i].GetComponent<Health>();
            feedbackFlashHUDThree[i].m_PlayerHealth = players[i].GetComponent<Health>();

            // Get WeaponsManager
            weaponHUDManagersThree[i].m_PlayerWeaponsManager = players[i].GetComponent<PlayerWeaponsManager>();

            // Get Crosshairs
            crosshairsThree[i].m_WeaponsManager = players[i].GetComponent<PlayerWeaponsManager>();
        }
    }

    private void SetFourPlayerUI(List<GameObject> players)
    {
        FourPlayers.SetActive(true);

        for (int i = 0; i < players.Count; i++)
        {
            // Get Health
            healthBarsFour[i].playerHealth = players[i].GetComponent<Health>();
            feedbackFlashHUDFour[i].m_PlayerHealth = players[i].GetComponent<Health>();

            // Get WeaponsManager
            weaponHUDManagersFour[i].m_PlayerWeaponsManager = players[i].GetComponent<PlayerWeaponsManager>();

            // Get Crosshairs
            crosshairsFour[i].m_WeaponsManager = players[i].GetComponent<PlayerWeaponsManager>();
        }
    }
}
