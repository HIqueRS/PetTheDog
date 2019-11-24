using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Novo : MonoBehaviour
{
    public GameObject text;
    private GameObject pet;
    public Points point;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        int v = (int)point.Point;

        text.GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + v.ToString();

        //text.GetComponent<Text>().text = "Score: " + v.ToString();
    }
}
