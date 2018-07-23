using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColDetectY : MonoBehaviour {

    public Text countText;
    public Text winText;

    private int count;

// Starting state 

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Goal") {

            gameObject.SetActive(false);
            count = count + 1;
            SetCountText();

        }

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count == 1)
        {
            winText.text = "You Win!";
        }
    }
}
