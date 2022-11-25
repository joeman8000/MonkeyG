using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EPressRestart : MonoBehaviour
{
    [SerializeField] private Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        int extrascore = TotalScore.totalscor;
        scoretext.text = "Score : " + extrascore;
        Debug.Log(TotalScore.totalscor);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Jump"))
        {
            TotalScore.totalscor = 0;
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
        
    }
}
