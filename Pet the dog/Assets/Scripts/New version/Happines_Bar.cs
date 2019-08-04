using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Happines_Bar : MonoBehaviour
{
    Vector3 localScale;
    public bool barra;

    public GameObject Dog;
    // Start is called before the first frame update
    void Start()
    {
        if (!barra)
        {
            localScale = transform.localScale;
            transform.localScale = localScale;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!barra)
        {
            localScale.x = 10 * Dog.GetComponent<Dog_Behaviour>().pet_bar();
            transform.localScale = localScale;
        }
       

        if (Dog.GetComponent<Dog_Behaviour>().Size_Tipe == 0) //Golden
        {
            if (Dog.GetComponent<Dog_Behaviour>().in_pet)
            {
                if (!barra)
                {
                    transform.localPosition = new Vector3(-9.0f, 22.0f, -1.0f);
                }
                else
                {
                    transform.localPosition = new Vector3(-4.0f, 21.44f, 0.0f);//barra de vida
                }
            }
            else
            {
                if (!barra)
                {
                    transform.localPosition = new Vector3(-5.0f, 9.0f, -1.0f);
                }
                else
                {
                    transform.localPosition = new Vector3(-0.01f, 8.49f, 0.0f);//barra de vida
                }
            }
               
        }
        else if(Dog.GetComponent<Dog_Behaviour>().Size_Tipe == 1) //Corgi
        {
            if (Dog.GetComponent<Dog_Behaviour>().in_pet)
            {
                if (!barra)
                {
                    transform.localPosition = new Vector3(-6.0f, 17.0f, -1.0f);
                }
                else
                {
                    transform.localPosition = new Vector3(-0.98f, 16.5f, 0.0f);//barra de vida
                }
            }
               
            else
            {
                if (!barra)
                {
                    transform.localPosition = new Vector3(-5.0f, 9.0f, -1.0f);
                }
                else
                {
                    transform.localPosition = new Vector3(-0.04f, 8.48f, 0.0f);//barra de vida
                }
            }
                
        }
        else
        {
            if (Dog.GetComponent<Dog_Behaviour>().in_pet) //Franchie
            {
                if (!barra)
                {
                    transform.localPosition = new Vector3(-7.0f, 8.0f, -1.0f);
                }
                else
                {
                    transform.localPosition = new Vector3(-1.99f, 7.48f, 0.0f);//barra de vida
                }
            }
                
            else
            {
                if (!barra)
                {
                    transform.localPosition = new Vector3(-5.0f, 8.0f, -1.0f);
                }
                else
                {
                    transform.localPosition = new Vector3(-0.07f, 7.45f, 0.0f);//barra de vida
                }
            }
                
        }
    }
}
