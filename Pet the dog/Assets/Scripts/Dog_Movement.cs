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

    public int pet_var;
    public Vector2 Min_Mov;
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

                speed = speed_p;
                pet_var = pet_var_p;
                break;
            case 1:
                Max_dog = sprite_dog_m.Length;

                GetComponent<SpriteRenderer>().sprite = sprite_dog_m[Random.Range(0, Max_dog)];

                speed = speed_m;
                pet_var = pet_var_m;
                break;
            case 2:
                Max_dog = sprite_dog_g.Length;

                GetComponent<SpriteRenderer>().sprite = sprite_dog_g[Random.Range(0, Max_dog)];

                speed = speed_g;
                pet_var = pet_var_g;
                break;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;



        transform.position = Vector3.MoveTowards(transform.position, Objective.transform.position, step);

        //Vector2 min_mov = new Vector2(10.0f, 10.0f);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.deltaPosition.x > Min_Mov.x)
            {
                RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), Vector2.zero);
                // RaycastHit2D can be either true or null, but has an implicit conversion to bool, so we can use it like this
                if (hitInfo)
                {
                    
                    if (gameObject == hitInfo.transform.gameObject)
                    {
                        Debug.Log(hitInfo.transform.gameObject.name);
                        pet_var -= 1;
                    }
                    // Here you can check hitInfo to see which collider has been hit, and act appropriately.
                }
            }
        }

        if (pet_var < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
