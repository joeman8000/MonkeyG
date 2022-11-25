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
        scoretext.text = "Score : " + Score.num;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
    }
}
