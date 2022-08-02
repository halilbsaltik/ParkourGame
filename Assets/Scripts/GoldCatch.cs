using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCatch : MonoBehaviour
{
    public float coinVariable;
    public Text Score;
    public int scoreboard;// = 5;
    // Start is called before the first frame update
    void Start()
    {
        scoreboard = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = coinVariable.ToString("f0");
    }
    void OnCollisionEnter(Collision gold)
    {
        if (gold.gameObject.tag == "Gold1")
        {
            coinVariable += 5;
            Destroy(gold.gameObject);
        }
        if (gold.gameObject.tag == "Gold1")
        {
            scoreboard--;
        }
        if (scoreboard <= 0) 
        {
            Application.LoadLevel(0); // ilk sahneye git
        }

    }
}
