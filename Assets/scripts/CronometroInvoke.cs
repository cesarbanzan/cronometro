using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CronometroInvoke : MonoBehaviour
{
   public float tiempoPasado = 0f;
   public bool start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (start == false)
            {
                InvokeRepeating("actualizarCronometro", 1,1);
                start = true;
            }
            else
            {
                CancelInvoke("actualizarCronometro");
                start = false;
            }
        }
    }
    void actualizarCronometro()
    {
            tiempoPasado =tiempoPasado +1;
            Debug.Log("tiempo transcurrido"+tiempoPasado);
    }
}

