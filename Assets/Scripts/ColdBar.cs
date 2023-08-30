using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColdBar : MonoBehaviour
{
    public Image coldBar;
    public float fill;

    public float coldAmount = 100;
    public float secondsCold = 60f;

    void Start()
    {
        coldBar.fillAmount = coldAmount / 100;
    }
    
    void Update()
    {
        if (coldAmount > 0)
        {
            coldAmount -= 100 / secondsCold * Time.deltaTime;
            coldBar.fillAmount = coldAmount / 100;
        }
        
    }

    void OnTriggerStay(Collider collision)
    {
        Debug.Log("TriggerEnter");
        if (collision.CompareTag("CampFire"))
        {
            if (coldAmount == 100)
            {
                coldAmount -= 100 / secondsCold * Time.deltaTime;
            }
            if (coldAmount <= 100)
            {
                coldAmount += 5 * Time.deltaTime;
            }

        }
              
    }
    void OnTriggerExit(Collider collision)
    {
        Update();
        Debug.Log("TriggerExit");
    }
   
}
