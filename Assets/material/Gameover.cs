using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gameover : MonoBehaviour
{
    public Text gameOverMessage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision collision) {
        gameOverMessage.text = "Game Over";
        Destroy(collision.gameObject);
    }
}
