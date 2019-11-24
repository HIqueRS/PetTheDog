using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public bool landscape;
    // Start is called before the first frame update
    public Points point;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jogar()
    {
        if(!landscape)
        {
            Destroy(GameObject.Find("Gerente"));
            point.Point = 0;
            SceneManager.LoadScene("New game");
        }           
        else
        {
            Destroy(GameObject.Find("Gerente"));
            point.Point = 0;
            SceneManager.LoadScene("New game 1");
        }
            
    }

    public void Back_To_Menu()
    {
        if (!landscape)
            SceneManager.LoadScene("TelaInicial");
        else
            SceneManager.LoadScene("TelaInicial 1");
    }

    public void Pet_Shop()
    {
        SceneManager.LoadScene("Pet Store");
    }

    public void Go_Credits()
    {
        SceneManager.LoadScene("Credits");
    }

}
