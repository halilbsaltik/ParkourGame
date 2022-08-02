using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public float returnSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            this.transform.Translate(0, 0, 0.0100f); //z ekseninde hareket
        }
        if (Input.GetKey("down"))
        {
            this.transform.Translate(0, 0, -0.0100f); //z ekseninde hareket
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up, returnSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up, -returnSpeed);
        }
    }
}
