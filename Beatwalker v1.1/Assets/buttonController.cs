using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonController : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite def;
    public Sprite pres;
    public KeyCode keyToPress;

    //public SpriteRenderer a;
    //public Sprite yes;
    //public Sprite no;
    //public Sprite none;
    //public bool hit;
    //public float time = 0f;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            sr.sprite = def;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            sr.sprite = pres;
        }



        /*Garbage way of timing rythm
        if (time > 300 && time < 400 ||
            time > 500 && time < 600 ||
            time > 700 && time < 800 ||
            time > 900 && time < 1000 ||
            time > 1100 && time < 1200 ||
            time > 1300 && time < 1400 ||
            time > 1500 && time < 1600 ||
            time > 1700 && time < 1800 ||
            time > 1900 && time < 2000 
            ) {
            if (Input.GetKeyDown(keyToPress))
            {
                hit = true;
                Debug.Log(hit);
            }
        } else
        {
            a.sprite = none;
            hit = false;
            Debug.Log(hit);
        }

        //Showhit
        if (hit == true)
        {
            a.sprite = yes;
        }
        else if (hit == false)
        {
            a.sprite = no;
        };*/
    }


}
