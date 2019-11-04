using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timerzito : MonoBehaviour
{
    public float maxtime;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        maxtime-= Time.deltaTime;
        text.GetComponent<TMPro.TextMeshProUGUI>().text = maxtime.ToString();

        
        if(maxtime <=0)
        {
            SceneManager.LoadScene("GameOver 1");
        }
    }
}
