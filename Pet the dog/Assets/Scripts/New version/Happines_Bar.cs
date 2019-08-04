using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Happines_Bar : MonoBehaviour
{
    Vector3 localScale;

    public GameObject Dog;
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;

        
        transform.localScale = localScale;
    }

    // Update is called once per frame
    void Update()
    {
        localScale.x = 10 * Dog.GetComponent<Dog_Behaviour>().pet_bar();
        transform.localScale = localScale;
    }
}
