using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.FPS.UI
{
    public class IntroMenuUI: MonoBehaviour
    {
        public GameObject ObjectToToggle;
        public bool isObjectActive;

        public void OnShowControls() 
        {
            isObjectActive = !isObjectActive;
            ObjectToToggle.SetActive(isObjectActive);
        }

        public void OnLoadGame()
        {
            SceneManager.LoadScene("SelectMenu");
        }
    }
}