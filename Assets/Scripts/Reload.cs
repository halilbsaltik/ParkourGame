using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reload : MonoBehaviour
{
    public float gameHeight,gameTime,gameGetTime,boundingPower;
    public Transform firstStartPosition; // Oyunu yeniden baþlayýnca ilk pozisyonumuz için
    public Text gameTimeText; // Oyunun zamaný tutucaðýz.
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
        if (transform.position.y <= gameHeight) // Game object pozisyonu y ekseninde yani aþaðý dogru belli bir miktar düþünce oyuna vereceðimiz yükseklikten küçük veya eþit olunca oyun yeniden baþlayacaktýr.
        {
            transform.position = firstStartPosition.position; 
        }
        if(gameTime <= 0) // Oyun zamanýmýz küçük ise sýfýrdan oyun posizyonlarýný en baþa çekiyorum.
        {
            transform.position = firstStartPosition.position;
            gameTime = gameGetTime; // Oyun zamanýný verilen zamana eþitliyorum.
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * boundingPower); // Karakterin Zýplamasý için 
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
