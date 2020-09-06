using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusVel : MonoBehaviour
{
    public GameObject barra;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "barra de base")
        {
            collision.gameObject.GetComponent<BarraBaseControler>().speed += 20.0f;
            Destroy(gameObject);
        }
    }
}
