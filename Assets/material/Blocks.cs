using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Blocks : MonoBehaviour
{
    Transform myTransform;
    public Text gameClearMessage;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(myTransform.childCount == 0) {
            gameClearMessage.text = "Game Clear";
            Time.timeScale = 0f;
        }
    }
}
