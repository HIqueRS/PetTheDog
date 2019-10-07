using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Novo : MonoBehaviour
{
    public GameObject text;
    private GameObject pet;

    // Start is called before the first frame update
    void Start()
    {
        pet = GameObject.Find("Gerente");
    }

    // Update is called once per frame
    void Update()
    {
        int v = (int)pet.GetComponent<Score>().score;

        text.GetComponent<Text>().text = "Score: " + v.ToString();
    }
}
