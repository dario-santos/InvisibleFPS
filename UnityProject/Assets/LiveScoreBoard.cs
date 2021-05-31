using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveScoreBoard : MonoBehaviour
{

    [SerializeField] private List<PlayerInfo> playerInfos;
    [SerializeField] private List<Text> playerKills;
    [SerializeField] private List<Text> playerDeaths;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0 ; i < playerInfos.Count ; i++)
        {
            playerKills[i].text = playerInfos[i].kills.ToString();
            playerDeaths[i].text = playerInfos[i].deaths.ToString();
        }
    }
}
