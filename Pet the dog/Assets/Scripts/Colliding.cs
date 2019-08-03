using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Colliding : MonoBehaviour
{

    public Slider slider;

    private bool Dog_came = false;
    public int Dog_count = 0;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Dog_came)
        {
            slider.value -= 10 * Time.deltaTime * Dog_count;
        }

       if(slider.value == 0)
        {
            SceneManager.LoadScene("Main Game");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Dog")
        {
            Dog_came = true;
            Dog_count += 1;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
