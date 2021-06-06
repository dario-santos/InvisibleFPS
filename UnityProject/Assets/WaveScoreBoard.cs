using UnityEngine;
using UnityEngine.UI;

public class WaveScoreBoard : MonoBehaviour
{
    [SerializeField] private IntVariable waves;
    [SerializeField] private Text wavesText;

    void Start()
    {
        wavesText.text = "Wave: " + waves.value;
    }
}
