
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameUI : MonoBehaviour
{
    public void LoadSelectMenu()
    { 
        SceneManager.LoadScene("SelectMenu");
    }
}
