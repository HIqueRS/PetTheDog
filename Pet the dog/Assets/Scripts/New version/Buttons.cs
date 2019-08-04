using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jogar()
    {
        SceneManager.LoadScene("New game");
    }

    public void Back_To_Menu()
    {
        SceneManager.LoadScene("TelaInicial");
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
