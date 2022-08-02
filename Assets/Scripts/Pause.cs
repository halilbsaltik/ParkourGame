using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool stop;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            stop = !stop;
        }
        if (stop)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
        if (!stop)
        {
            panel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
