using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonustamanio : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "barra de base")
        {
            GameObject[] listapelotas = GameObject.FindGameObjectsWithTag("Pelota");
            for (int i =0; i < listapelotas.Length;i++)
            {
                listapelotas[i].transform.localScale += new Vector3(1.5f, 1.5f, 0f);
            }
            Destroy(gameObject);
        }
    }
}
