using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    private bool visible = false;


    // Start is called before the first frame update
    void Start()
    {
        visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.GetComponent<SpriteRenderer>().enabled = visible;
       
        if (Input.touchCount > 0)
        {
            Debug.Log(Input.touchCount);
            transform.position = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            transform.position = new Vector3(transform.position.x, transform.position.y, -9);
            visible = true;
        }
        else
        {
            visible = false;
        }
    }
}
