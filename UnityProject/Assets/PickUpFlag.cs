using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Game;
using UnityEngine;

public class PickUpFlag : MonoBehaviour
{
    [SerializeField] string color;
    [SerializeField] PlayerInfo player;
    [SerializeField] FlagManager flagManager;
    [SerializeField] GameObject flag;

    private bool carriesFlag = false;



    // Start is called before the first frame update
    void Start()
    {
        var m_Health = gameObject.GetComponent<Health>();
        m_Health.OnDie += OnDie;
    }

    public void OnDie()
    {
        carriesFlag = false;
        flagManager.SpawnFlag();
        flag.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flag"))
        {
            other.gameObject.SetActive(false);
            carriesFlag = true;
            flag.SetActive(true);
        }

        if (carriesFlag)
        {
            if (other.CompareTag("BaseBlue") && color.Equals("blue"))
            {
                player.flags++;
                carriesFlag = false;
                flagManager.SpawnFlag();
                flag.SetActive(false);
            }
            else if (other.CompareTag("BaseRed") && color.Equals("red"))
            {
                player.flags++;
                carriesFlag = false;
                flagManager.SpawnFlag();
                flag.SetActive(false);
            }
            else if (other.CompareTag("BaseYellow") && color.Equals("yelllow"))
            {
                player.flags++;
                carriesFlag = false;
                flagManager.SpawnFlag();
                flag.SetActive(false);
            }
            else if (other.CompareTag("BaseGreen") && color.Equals("green"))
            { 
                player.flags++;
                carriesFlag = false;
                flagManager.SpawnFlag();
                flag.SetActive(false);
            }    
        }
    }
}
