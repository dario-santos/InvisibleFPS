using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.FPS.UI
{
    public class LoseMenuUI : MonoBehaviour
    {

        public void OnLoadMenu()
        {
            SceneManager.LoadScene("IntroMenu");
        }

        public void OnLoadGame()
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}