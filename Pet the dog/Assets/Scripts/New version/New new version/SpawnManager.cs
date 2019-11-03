using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnManager : MonoBehaviour
{
    public UnityEvent spawn1;
    public UnityEvent spawn2;

    private float Timer = 0;
    public float Time_to_spawn_Max;
    public float Time_to_spawn_Min;
    private float Time_to_spawn;

    private int SpawnDecision;
    private int MaxDogo;

    // Start is called before the first frame update
    void Start()
    {
        Time_to_spawn = Random.Range(Time_to_spawn_Min, Time_to_spawn_Max);
        spawn1.Invoke();
        spawn2.Invoke();
        MaxDogo = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > Time_to_spawn)
        {
            if(MaxDogo < 10)
            {
                SpawnDecision = Random.Range(0, 3);
                if (SpawnDecision == 0)
                {
                    spawn1.Invoke();
                    MaxDogo++;
                }
                else if (SpawnDecision == 1)
                {
                    spawn2.Invoke();
                    MaxDogo++;
                }
                else
                {
                    spawn1.Invoke();
                    spawn2.Invoke();
                    MaxDogo += 2;
                }
                Timer = 0;
                Time_to_spawn = Random.Range(Time_to_spawn_Min, Time_to_spawn_Max);
            }
           
        }
    }
}
