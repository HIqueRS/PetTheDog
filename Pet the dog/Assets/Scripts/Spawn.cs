using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] dog;
    public GameObject Final_Position;
    private int Dog_tipe;
    

    private float Timer = 0;
    public float Time_to_spawn = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        Time_to_spawn = Random.Range(5, 15);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        Dog_tipe = Random.Range(0, 3);

        if (Timer > Time_to_spawn)
        {
            dog[Dog_tipe].GetComponent<Dog_Movement>().Objective = Final_Position;
            dog[Dog_tipe].GetComponent<Dog_Movement>().Size_Tipe = Dog_tipe;
            Instantiate(dog[Dog_tipe], gameObject.transform.position, Quaternion.identity);
            
            Timer = 0;
            Time_to_spawn = Random.Range(5, 15);
        }
    }
}
