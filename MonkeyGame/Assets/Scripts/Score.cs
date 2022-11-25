using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    [SerializeField] private Text Myscore;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
        //Myscore.text = "Score : " +num;
    }

    private void OnTriggerEnter2D(Collider2D ScoreBox)
    {
        if(ScoreBox.tag == "Scoring")
        {
            num+=1;
            Destroy(ScoreBox.gameObject);
            Myscore.text = "Score : " +num;
        }
    }


}