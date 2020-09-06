using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speedintro = 600f;
    public Transform bonuspelota;
    public CircleCollider2D cc;
    public Transform Bonusbarra;
    public Transform bonusVel;
    public Transform bonusTamanio;
    //bool enjuego;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //cuando la pelota empieza a moverse
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Mov();
        }
        //cuando la pelota cae del escenario
        if (transform.position.y <= -5.5f)
        {
            Destroy(gameObject);
        }
        
    }

    void Mov()
    {
           transform.SetParent(null);
           rig.isKinematic = false;
           rig.AddForce(new Vector3(speedintro,speedintro,0));
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //si coliciona en un bloque en especifico.
        switch (collision.gameObject.name)
        {
            /*
            case "barra (29)":
                //se crea el sprite del bonus de la pelota
                Instantiate(bonuspelota, new Vector3(1.817459f, -1.655794f, 0f), Quaternion.identity);
                break;
            case "barra (15)":
                //se crea el bonus de la barra
                Instantiate(Bonusbarra, new Vector3(1.817459f, -0.333447f, 0f), Quaternion.identity);
                break;
            case "barra (28)":
                //se crea el bonus de velocidad de la barra
                Instantiate(bonusVel, new Vector3(collision.gameObject.GetComponent<Barra>().transform.position.x, collision.gameObject.GetComponent<Barra>().transform.position.y, collision.gameObject.GetComponent<Barra>().transform.position.z),Quaternion.identity);
                break;
                */
            case "barra (28)":
                Instantiate(bonusTamanio, new Vector3(collision.gameObject.GetComponent<Barra>().transform.position.x, collision.gameObject.GetComponent<Barra>().transform.position.y, collision.gameObject.GetComponent<Barra>().transform.position.z), Quaternion.identity);
                break;
        }
    }

    

}
