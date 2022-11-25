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
        scoretext.text = "Score : " + TotalScore.totalscore;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Score : " + TotalScore.totalscore;
        if (Input.GetButton("Jump"))
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
    }
}
