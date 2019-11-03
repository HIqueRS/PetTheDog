using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] dog;
    public GameObject[] Final_Position;
    public GameObject[] pet_position;
    public GameObject config;
    private int Dog_tipe;
    

    private float Timer = 0;
    public float Time_to_spawn_Max;
    public float Time_to_spawn_Min;
    private float Time_to_spawn;

    // Start is called before the first frame update
    void Start()
    {
        Time_to_spawn = Random.Range(Time_to_spawn_Min, Time_to_spawn_Max);

        Dog_tipe = Random.Range(0, dog.Length);
        dog[Dog_tipe].GetComponent<Dog_Behaviour>().Objective = Final_Position;
        dog[Dog_tipe].GetComponent<Dog_Behaviour>().Size_Tipe = Dog_tipe;
        dog[Dog_tipe].GetComponent<Dog_Behaviour>().config = config;
        dog[Dog_tipe].GetComponent<Dog_Behaviour>().pet_position = pet_position;
        Instantiate(dog[Dog_tipe], gameObject.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
       


        if (Timer > Time_to_spawn)
        {
            //SpawnDog();
            
            Timer = 0;
            Time_to_spawn = Random.Range(Time_to_spawn_Min, Time_to_spawn_Max);
            Time_to_spawn_Max -= 0.25f;
            Time_to_spawn_Min -= 0.25f;
            if (Time_to_spawn_Max < 10 && Time_to_spawn_Min < 5)
            {
                Time_to_spawn_Max = 20f;
                Time_to_spawn_Min = 10f;
            }
        }
    }

    public void SpawnDog()
    {
        Dog_tipe = Random.Range(0, dog.Length);
        dog[Dog_tipe].GetComponent<Dog_Behaviour>().Objective = Final_Position;
        dog[Dog_tipe].GetComponent<Dog_Behaviour>().Size_Tipe = Dog_tipe;
        dog[Dog_tipe].GetComponent<Dog_Behaviour>().config = config;
        dog[Dog_tipe].GetComponent<Dog_Behaviour>().pet_position = pet_position;
        Instantiate(dog[Dog_tipe], gameObject.transform.position, Quaternion.identity);
    }
}
