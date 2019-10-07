using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public float score = 0;
    private GameObject text;

    

    // Start is called before the first frame update
    void Start()
    {
       text = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void set_score(float scr)
    {
        score += scr;
        int corte = (int)score;
        text.GetComponent<Text>().text = "Score: " + corte.ToString();

        DontDestroyOnLoad(transform.gameObject);
    }
}
