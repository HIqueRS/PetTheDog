using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_Movement : MonoBehaviour
{
    
    public GameObject Objective;

    public float speed;

    public Sprite sprite_dog_p;
    public Sprite sprite_dog_m;
    public Sprite sprite_dog_g;

    public int pet_var;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprite_dog_g;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;



        transform.position = Vector3.MoveTowards(transform.position, Objective.transform.position, step);

        

    }
}
