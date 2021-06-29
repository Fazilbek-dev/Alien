using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SlimePlayer")
        {
            if(!Profile.win2)
            {
                Profile.Score++;
                print(Profile.Score);
                Profile.win2 = true;
            }
            SceneManager.LoadScene("SampleScene");
        }
    }
}
