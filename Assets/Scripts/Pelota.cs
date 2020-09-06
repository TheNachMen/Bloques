using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speedintro = 600f;
    
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

}
