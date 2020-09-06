using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonustamanio : MonoBehaviour
{
    public GameObject pelota;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "barra de base")
        {
            pelota.transform.localScale += new Vector3(1.5f, 1.5f, 0);
            Destroy(gameObject);
        }
    }
}
