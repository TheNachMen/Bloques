using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    private string[] listaBonus = {"velocidad","pelota","tamanio","barra"};
    void Start()
    {
        //
        int number = Random.Range(0,100);
        if (number > 75)
        {
            transform.gameObject.AddComponent<BonusManager>();
            transform.GetComponent<BonusManager>().SetNombreBonus(listaBonus[Random.Range(0,listaBonus.Length)]);
        }
        
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
