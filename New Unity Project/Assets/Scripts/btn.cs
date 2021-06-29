using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn : MonoBehaviour {
    public GameObject[] block;
    public Sprite btnDown;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MarkBox")
        {
            GetComponent<SpriteRenderer>().sprite = btnDown;
            GetComponent<CircleCollider2D>().enabled = false;
            foreach (GameObject obj in block)
            {
                Destroy(obj);
            }
        }
    }
}
