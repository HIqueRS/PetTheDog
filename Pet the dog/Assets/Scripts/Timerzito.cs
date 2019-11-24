using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timerzito : MonoBehaviour
{
    public float maxtime;
    public GameObject text;
    private int time;
    private int minute;
    private int second;
    private bool bole;

    // Start is called before the first frame update
    void Start()
    {
        bole = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(bole)
        maxtime-= Time.deltaTime;

        minute = Mathf.FloorToInt(maxtime / 60);
        second = Mathf.FloorToInt(maxtime % 60);

      
        text.GetComponent<TMPro.TextMeshProUGUI>().text ="time: "+ minute + " : " + second;

        
        if(maxtime <=0)
        {
            maxtime = 0;
            bole = false;
            SceneManager.LoadScene("GameOver 1");
        }
    }

    public void SubTime()
    {
        maxtime -= 15;
    }

    public void AddTime()
    {
        maxtime += 5;
    }
}
