using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    public float step = 0f;
    public float trip = 0f;
    public float jump = 0f;
    public Text steps;
    public Text trips;
    public Text jumps;
    public bool levelDone = false;
    public Transform donepos;
    public GameObject doneCanvas;
    public float accuracy;
    public Text rank;
    public Text acc;

    public float movespeed = 0.1f;

    void FixedUpdate()
    {
        accuracy = (step / (step + trip)) * 100f;
        acc.text = "Accuracy: " + Mathf.FloorToInt(accuracy) + "%";
        if (accuracy >= 33 && accuracy <= 66)
        {
            rank.text = "B";
        }
        else if (accuracy < 33)
        {
            rank.text = "C";
        } else if (accuracy > 66 && accuracy <= 90)
        {
            rank.text = "A";
        } else if (accuracy > 90)
        {
            rank.text = "S";
        }
        steps.text = "Steps " + step;
        trips.text = "Trips " + trip;
        jumps.text = "Jumps " + jump;

        transform.position = new Vector3(transform.position.x - movespeed, transform.position.y);


        if (transform.position.x < -15.88f)
        {
            transform.position = new Vector3(15.88f, transform.position.y);
        }

        if (levelDone == true)
        {
            movespeed = 0;
            doneCanvas.gameObject.SetActive(true);
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
