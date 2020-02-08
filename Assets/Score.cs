using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private GameObject ScoreText;
    public int point = 0;


    // Use this for initialization
    void Start()
    {
        //point = 0;
        this.ScoreText = GameObject.Find("ScoreText");

    }
     void OnCollisionEnter(Collision collision)
    {
        string Tag = collision.gameObject.tag;
       


        if (Tag == "LargeStarTag")
        {
            point += 20;
        }
        else if (Tag == "SmallStarTag")
        {
            point += 10;
        }
        
        else if (Tag == "SmallCloudTag")
        {
            point += 15;
        }
        else if (Tag == "LargeCloudTag")
        {
            point += 30;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        this.ScoreText.GetComponent<Text>().text = ("Score:" +point);
        //Debug.Log("Score:" + point);
    }
}
