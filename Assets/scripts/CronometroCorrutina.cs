using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CronometroCorrutina : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            if(start== false)
            {
                StartCoroutine(actualizarCronometro());
                start = true;
            }
            else 
            {
                Debug.Log("true");
                StopAllCoroutines();
                start = false;
            }
        }
    }
    IEnumerator actualizarCronometro()
    {
        while (true)
        {

            tiempoPasado = tiempoPasado + Time.deltaTime;
            string tiempotexto = tiempoPasado.ToString("0.00");
          //  Debug.Log("tiempo transcurrido: "+tiempoPasado);
         
             yield return null;
        }
       
    }
}


