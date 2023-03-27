using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public GameObject deDeur;
    private int Aantal;
    public int hoeveelnodig;

    // Start is called before the first frame update
    void Start()
    {
        Aantal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Aantal == hoeveelnodig)
        {
            Destroy(deDeur);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pickupobj"))
        {
            Debug.Log("andrea is een hond");
            Destroy(other.gameObject);
            Debug.Log(Aantal);
            Aantal++;
        }
    }
       
    }

