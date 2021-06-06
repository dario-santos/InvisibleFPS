using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameUI : MonoBehaviour
{
    private IEnumerator LoadSelectMenu(int seconds)
    {
        yield return new WaitForSeconds(seconds);

        SceneManager.LoadScene("SelectMenu");
    }

    public void Start()
    {
        StartCoroutine(LoadSelectMenu(10));
    }
}
