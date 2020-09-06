using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonuspelota : MonoBehaviour
{
    public GameObject pelota;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //si el trigger del bonus detecta colicion con la barra
        if (collision.gameObject.name == "barra de base")
        {
            GameObject p = Instantiate(pelota, new Vector3(collision.gameObject.transform.position.x, -3.8f, 0f), Quaternion.identity);
            Rigidbody2D r = p.GetComponent<Rigidbody2D>();
            r.AddForce(new Vector3(200f, 200f, 0));
            
            Destroy(gameObject);
        }
    }
}
