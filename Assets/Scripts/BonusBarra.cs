using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBarra : MonoBehaviour
{
    public GameObject barra;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "barra de base")
        {
            //transform.localScale = new Vector3(1.5f,1f,1f);
            collision.gameObject.transform.localScale += new Vector3(0.5f,0f,0f);
            Destroy(gameObject);

        }
    }

}
