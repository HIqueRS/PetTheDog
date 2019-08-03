using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_Movement : MonoBehaviour
{
    
    public GameObject Objective;

    private float speed;
    public float speed_p;
    public float speed_m;
    public float speed_g;


    private int Size_Tipe;
    private int Max_dog;
    public Sprite[] sprite_dog_p;
    public Sprite[] sprite_dog_m;
    public Sprite[] sprite_dog_g;

    private int pet_var;
    public int pet_var_p;
    public int pet_var_m;
    public int pet_var_g;

    // Start is called before the first frame update
    void Start()
    {
        Size_Tipe = Random.Range(0, 3);

        switch(Size_Tipe)
        {
            case 0:
                    Max_dog = sprite_dog_p.Length;

                    GetComponent<SpriteRenderer>().sprite = sprite_dog_p[Random.Range(0,Max_dog)];
                break;
            case 1:
                    Max_dog = sprite_dog_m.Length;

                    GetComponent<SpriteRenderer>().sprite = sprite_dog_m[Random.Range(0, Max_dog)];
                break;
            case 2:
                    Max_dog = sprite_dog_g.Length;

                    GetComponent<SpriteRenderer>().sprite = sprite_dog_g[Random.Range(0, Max_dog)];
                break;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;



        transform.position = Vector3.MoveTowards(transform.position, Objective.transform.position, step);


       
    }
}
