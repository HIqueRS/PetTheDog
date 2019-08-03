using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colliding : MonoBehaviour
{

    public Slider slider;

    private bool Dog_came = false;
    private int Dog_count = 0;
   

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
