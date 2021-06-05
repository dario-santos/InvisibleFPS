using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.FPS.Game
{
    public class GameFlowManager : MonoBehaviour
    {
        [Header("End Scene")] 
        public string LoseSceneName = "EndGame";
        public bool isCTF = false;
        public bool isWave = false;


        [Header("Timer")]
        [SerializeField] private IntVariable timer;

        [Header("Waves")]
        [SerializeField] private IntVariable baseLives;
        [SerializeField] private int baseInitialLives;


        public bool GameIsEnding { get; private set; }

        void Start()
        {
            baseLives.value = baseInitialLives;
            LoseSceneName = LoseSceneName + (isCTF ? "CTF" : "FFA");
            AudioUtility.SetMasterVolume(1);
        }

        void Update()
        {
            if (isWave)
            {
                // 1 - Base lives
                if (baseLives.value <= 0)
                {
                    GameIsEnding = true;

                    // 1.2 - Load scoreboard scene
                    SceneManager.LoadScene("WavesEndGame");
                }
            }
            else
            { 
                // 1 - Has the time ended yet?
                if(timer.value <= 0)
                {
                    GameIsEnding = true;

                    // 1.2 - Load scoreboard scene
                    SceneManager.LoadScene(LoseSceneName);
                }
            }
        }
    }
}