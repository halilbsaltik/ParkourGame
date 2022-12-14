using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reload : MonoBehaviour
{
    public float gameHeight,gameTime,gameGetTime,boundingPower;
    public Transform firstStartPosition; // Oyunu yeniden ba?lay?nca ilk pozisyonumuz i?in
    public Text gameTimeText; // Oyunun zaman? tutuca??z.
    // Start is called before the first frame update
    void Start()
    {
        gameTime = gameGetTime;
    }

    // Update is called once per frame
    void Update()
    {
        gameTime -= Time.deltaTime; ;
        gameTimeText.text = gameTime.ToString("f2");
        if (transform.position.y <= gameHeight) // Game object pozisyonu y ekseninde yani a?a?? dogru belli bir miktar d???nce oyuna verece?imiz y?kseklikten k???k veya e?it olunca oyun yeniden ba?layacakt?r.
        {
            transform.position = firstStartPosition.position; 
        }
        if(gameTime <= 0) // Oyun zaman?m?z k???k ise s?f?rdan oyun posizyonlar?n? en ba?a ?ekiyorum.
        {
            transform.position = firstStartPosition.position;
            gameTime = gameGetTime; // Oyun zaman?n? verilen zamana e?itliyorum.
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * boundingPower); // Karakterin Z?plamas? i?in 
        }
    }

    void OnCollisionEnter(Collision attingent)
    {
        if (attingent.gameObject.tag == "Door")
        {
            Application.LoadLevel(1);
        }
    }
}
