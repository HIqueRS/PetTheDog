using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dog_Behaviour : MonoBehaviour
{
    public int Current_target;
    public GameObject[] Objective;
    public GameObject[] pet_position;
    public GameObject Peting_bar;
    public GameObject config;

    
    public float speed;

    public int Size_Tipe;
    private int Max_dog;
    public Sprite[] sprites_dog;
    public Sprite[] sprites_walk;
    public Sprite[] sprites_pet;

    private float max_pet;
    public float pet_var;
    private bool in_pet;

    public float Coeficiente_Carinho =1;

    private bool Start_Bar = false;

    private float Timer = 0;
    private bool pot = true;
    public float anim_vel;

    private Vector3 target_scale;

    // Start is called before the first frame update
    void Start()
    {

        switch (Size_Tipe)
        {
            case 2:
                transform.localScale = new Vector3(0.15f, 0.15f, 0.2f);
                target_scale = new Vector3(0.15f, 0.15f, 0.2f);
                break;
            case 1:
                transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                target_scale = new Vector3(0.2f, 0.2f, 0.2f);
                break;
            case 0:
                transform.localScale = new Vector3(0.3f, 0.3f, 0.2f);
                target_scale = new Vector3(0.3f, 0.3f, 0.2f);
                break;
        }

        config = GameObject.Find("config");
        pet_position[0] = GameObject.Find("Left_Pos");
        pet_position[1] = GameObject.Find("Mid_Pos");
        pet_position[2] = GameObject.Find("Right_Pos");


        Max_dog = sprites_dog.Length;

        GetComponent<SpriteRenderer>().sprite = sprites_dog[Random.Range(0, Max_dog)];

        max_pet = pet_var;

        Current_target = Random.Range(0, Objective.Length - 3);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        Timer += Time.fixedDeltaTime;

        if (Current_target < 3)
        {
            switch (Size_Tipe)
            {
                case 2:
                    target_scale = new Vector3(0.2f, 0.2f, 0.2f);
                    break;
                case 1:
                    target_scale = new Vector3(0.28f, 0.28f, 0.2f);
                    break;
                case 0:
                    target_scale = new Vector3(0.4f, 0.4f, 0.2f);
                    break;
            }

        }
        else if (Current_target < 6)
        {
            switch (Size_Tipe)
            {
                case 2:
                    target_scale = new Vector3(0.175f, 0.175f, 0.2f);
                    break;
                case 1:
                    target_scale = new Vector3(0.24f, 0.24f, 0.2f);
                    break;
                case 0:
                    target_scale = new Vector3(0.35f, 0.35f, 0.2f);
                    break;
            }
        }
        else if (Current_target < 9)
        {

            switch (Size_Tipe)
            {
                case 2:
                    target_scale = new Vector3(0.15f, 0.15f, 0.2f);
                    break;
                case 1:
                    target_scale = new Vector3(0.2f, 0.2f, 0.2f);
                    break;
                case 0:
                    target_scale = new Vector3(0.3f, 0.3f, 0.2f);
                    break;
            }
        }

        if (gameObject.transform.localScale.x < target_scale.x)
        {
            gameObject.transform.localScale += new Vector3(0.03f, 0.03f, 0f) * Time.deltaTime;
        }
        else
        {
            gameObject.transform.localScale -= new Vector3(0.03f, 0.03f, 0f) * Time.deltaTime;
        }
       

        if (Timer > anim_vel)
        {
            if (pot)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites_walk[0];
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites_walk[1];
            }
            pot = !pot;
           
            Debug.Log(gameObject.name);
            
            Timer = 0;
        }

        if  (!in_pet)
        {
            transform.position = Vector3.MoveTowards(transform.position, Objective[Current_target].transform.position, step);
        }
        else
        {

            if (pet_bar() < 0.5)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites_pet[0];
            }
            else if (pet_bar() < 0.7)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites_pet[1];
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites_pet[2];
            }

            pet_var += Time.deltaTime * Coeficiente_Carinho;
            if (pet_var > max_pet)
            {
                pet_var = max_pet;
            }
            
        }
       

        if (Vector3.Distance(transform.position,Objective[Current_target].transform.position) < 0.5)
        {
            Debug.Log("Start the bar");
            Debug.Log("Randomize another objective");

           

            Current_target = Random.Range(0, Objective.Length - 3);
            //start the bar
            //and start movement
            //randomize another objective.position

            Start_Bar = true;
        }

        if (Start_Bar && !in_pet)
        {
            pet_var -= Time.deltaTime;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), Vector2.zero);

            if (hitInfo)
            {
                if (gameObject == hitInfo.transform.gameObject )
                {
                    //ir pra frente
                    Debug.Log("Vai pra frente");
                    if (config.GetComponent<Config>().can_you_pet)
                    {
                        transform.position = Objective[Random.Range(9,Objective.Length)].transform.position;
                        config.GetComponent<Config>().can_you_pet = false;
                        in_pet = true;
                    }
                    
                }
            }
        }
        else
        {
            config.GetComponent<Config>().can_you_pet = true;
            in_pet = false;
           // gameObject.GetComponent<SpriteRenderer>().sprite = sprites_walk[0];
        }

        if (pet_var < 0)
        {
            //game over
            //SceneManager.LoadScene("New game");
            //Destroy(gameObject);
        }

    }

    public float pet_bar()
    {
        return (pet_var * 100 / max_pet) / 100;
    }
}
