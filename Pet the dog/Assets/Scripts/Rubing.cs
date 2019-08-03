using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rubing : MonoBehaviour
{

    public GameObject test;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 min_mov = new Vector2(10.0f, 10.0f);

       if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.deltaPosition.x > min_mov.x)
            {
                Debug.Log("Ahola");
            }
           
        }



       
    }

    
}
