using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    [SerializeField] private IntVariable lives;
    [SerializeField] private Text livesText;


    private void Update()
        => livesText.text = lives.value.ToString();
}
