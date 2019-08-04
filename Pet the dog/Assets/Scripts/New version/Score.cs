using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private float score = 0;
    public GameObject text;

    

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
