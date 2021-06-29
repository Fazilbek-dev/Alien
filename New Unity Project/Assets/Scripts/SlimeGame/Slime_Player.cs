using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Player : MonoBehaviour
{
    public Transform Ptr;
    Transform tr;
    public int a = 0;
    public int b = 0;
    public int p = 0;
    // Start is called before the first frame update
    void Start()
    {
        Ptr = GetComponent<Transform>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            a += 90;
            tr.localRotation = Quaternion.Euler(0, 0, a);
            //tr.localRotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, a), Time.deltaTime * 5f);
            //Ptr.localRotation = Quaternion.Euler(0, 0, p - 90);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            a -= 90;
            tr.localRotation = Quaternion.Euler(0, 0, a);
            //tr.localRotation = Quaternion.Lerp(tr.localRotation, Quaternion.Euler(0, 0, a), Time.deltaTime * 5f);
            //Ptr.localRotation = Quaternion.Euler(0, 0, p + 90);
        }
    }

    public void Right()
    {
        tr.localRotation = Quaternion.Euler(0, 0, a);
        //Ptr.localRotation = Quaternion.Euler(0, 0, p + 90);
        a -= 90;
    }
    public void Left()
    {
        tr.localRotation = Quaternion.Euler(0, 0, a);
        //Ptr.localRotation = Quaternion.Euler(0, 0, p - 90);
        a += 90;
    }
}
