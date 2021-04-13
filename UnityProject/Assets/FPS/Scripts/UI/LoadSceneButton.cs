using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Unity.FPS.UI
{
    public class LoadSceneButton : MonoBehaviour
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