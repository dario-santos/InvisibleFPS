using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveScoreBoard : MonoBehaviour
{
    [SerializeField] private List<PlayerInfo> playerInfos;
    [SerializeField] private List<Text> playerKills;
    [SerializeField] private List<Text> playerDeaths;
    [SerializeField] private List<Image> playerBackground;

    [SerializeField] private bool isCTF = false;
    [SerializeField] private bool isToOrder = false;

    private void Start()
    {
        if (!isToOrder)
            return;

        // 1 - Sort list
        playerInfos.Sort(delegate (PlayerInfo x, PlayerInfo y)
        {
            int v = -x.kills.CompareTo(y.kills);

            return v != 0 ? v : x.deaths.CompareTo(y.deaths);
        });
    }

    private void Update()
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
            playerBackground[i].color = playerInfos[i].color;
            playerKills[i].text = playerInfos[i].kills.ToString();
            playerDeaths[i].text = playerInfos[i].deaths.ToString();
        }
    }

    private void UpdateScoreBoardCTF() 
    {
        for (int i = 0; i < playerInfos.Count; i++)
        {
            playerBackground[i].color = playerInfos[i].color;
            playerKills[i].text = playerInfos[i].flags.ToString();
            playerDeaths[i].text = playerInfos[i].kills.ToString();
        }
    }
}
