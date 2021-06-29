using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyText : MonoBehaviour
{

    public Text KeyWinText;

    // Start is called before the first frame update
    void Start()
    {
        KeyWinText.text = "<color=#000>" + Profile.Score + "/" + Profile.ScoreMax + "</color>  ";
    }
    private void Update()
    {
        KeyWinText.text = "<color=#000>" + Profile.Score + "/" + Profile.ScoreMax + "</color>  ";
    }

}
