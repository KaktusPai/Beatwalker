using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public main m;
    public bool space = false;
    public bool final;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                if (space == false)
                {
                    m.step += 1;
                }
                else if (space == true)
                {
                    m.jump += 1;
                }

                if (final == true)
                {
                    m.levelDone = true;
                }
            }
        }

        if (transform.position.y < -5.6)
        {
            gameObject.SetActive(false);
            m.trip += 1;
            if (final == true)
            {
                m.levelDone = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Activator")
        {
            canBePressed = false;
        }
    }
}