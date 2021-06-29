using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SlimePlayer")
        {
            if(!Profile.win1)
            {
                Profile.Score++;
                print(Profile.Score);
                Profile.win1 = true;
            }
            SceneManager.LoadScene("SampleScene");
        }
    }
}
