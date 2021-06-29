using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC2 : MonoBehaviour
{
    public GameObject btn;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            btn.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            btn.SetActive(false);
        }
    }

    public void SlimeLevelOn()
    {
        SceneManager.LoadScene("Slime_Game2");
    }
    public void SlimeLevelOff()
    {
        btn.SetActive(false);
    }
}
