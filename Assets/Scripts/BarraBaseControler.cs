using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;


public class BarraBaseControler : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento de la barra
        float hinput = Input.GetAxis("Horizontal");
        float posX = transform.position.x + (hinput * speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(posX,-2,2), transform.position.y, transform.position.z);
        
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        //if (collision.gameObject.name == "bonusBarra")
        //{
          //  transform.localScale = new Vector3(1.5f,1f,1f);
        //}
    //}
}
