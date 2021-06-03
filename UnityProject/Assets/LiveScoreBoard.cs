using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveScoreBoard : MonoBehaviour
{

    [SerializeField] private List<PlayerInfo> playerInfos;
    [SerializeField] private List<Text> playerKills;
    [SerializeField] private List<Text> playerDeaths;
    [SerializeField] private bool isCTF = false;

    // Update is called once per frame
    void Update()
    {
        if (isCTF)
        {
            UpdateScoreBoardCTF();
        }
        else
        {
            UpdateScoreBoardF4A();
        }
    }

    private void UpdateScoreBoardF4A()
    {
        for (int i = 0; i < playerInfos.Count; i++)
        {
            playerKills[i].text = playerInfos[i].kills.ToString();
            playerDeaths[i].text = playerInfos[i].deaths.ToString();
        }
    }

    private void UpdateScoreBoardCTF() 
    {
        for (int i = 0; i < playerInfos.Count; i++)
        {
            playerKills[i].text = playerInfos[i].flags.ToString();
            playerDeaths[i].text = playerInfos[i].kills.ToString();
        }
    }
}
