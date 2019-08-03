using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dog_Movement : MonoBehaviour
{

    public GameObject Objective;
    public GameObject player;
    public GameObject Peting_bar;

    public float speed;

    public int Size_Tipe;
    private int Max_dog;
    public Sprite[] sprites_dog;
    

    private float max_pet;
    public int pet_var;
    public Vector2 Min_Mov;
   

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
      
        Max_dog = sprites_dog.Length;

        GetComponent<SpriteRenderer>().sprite = sprites_dog[Random.Range(0,Max_dog)];

        max_pet = pet_var;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, Objective.transform.position, step);


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.deltaPosition.x > Min_Mov.x || touch.deltaPosition.y > Min_Mov.y)
            {
                RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), Vector2.zero);
               
                if (hitInfo)
                {
                    if (gameObject == hitInfo.transform.gameObject)
                    {
                        Debug.Log(hitInfo.transform.gameObject.name);
                        pet_var -= 1;
                    }
                }
            }
        }

        if (pet_var < 0)
        {
            if (player.GetComponent<Colliding>().Dog_count > 0)
            {
                player.GetComponent<Colliding>().Dog_count -= 1;
            }
            
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }

    public float pet_bar()
    {
        return (pet_var * 100 / max_pet)/100;
    }
}
