using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.FPS.Game
{
    public class GameFlowManager : MonoBehaviour
    {
        [Header("End Scene")] 
        public string LoseSceneName = "EndGame";
        public bool isCTF = false;

        [Header("Timer")]
        [SerializeField] private IntVariable timer;

        public bool GameIsEnding { get; private set; }

        void Start()
        {
            LoseSceneName = LoseSceneName + (isCTF ? "CTF" : "FFA");
            AudioUtility.SetMasterVolume(1);
        }

        void Update()
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