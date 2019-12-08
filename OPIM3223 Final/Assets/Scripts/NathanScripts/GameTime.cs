using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTime : MonoBehaviour
{
    public float TimeLeft = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TimeLeft -= Time.deltaTime;
        if (TimeLeft < 0)
        {
            SceneManager.LoadScene("MenuScene");

        }
    }
}
