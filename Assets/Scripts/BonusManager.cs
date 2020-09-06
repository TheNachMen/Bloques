using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusManager : MonoBehaviour
{
    private string nombreBonus;
    private GameObject bonusBarra;
    private GameObject bonusVel;
    private GameObject bonusTamanio;
    private GameObject bonusPelota;

    public void SetNombreBonus(string nombre)
    {
        nombreBonus = nombre;
    }
    void Start()
    {
        bonusBarra = (GameObject)Resources.Load("Prefab/bonusBarra", typeof(GameObject));
        bonusVel = (GameObject)Resources.Load("Prefab/vel", typeof(GameObject));
        bonusTamanio = (GameObject)Resources.Load("Prefab/bonustamaño", typeof(GameObject));
        bonusPelota = (GameObject)Resources.Load("Prefab/bonus de pelota", typeof(GameObject));
        
    }

    private void InstanciarBonus(GameObject bonus)
    {
        Instantiate(bonus, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Pelota")
        {
            switch (nombreBonus)
            {
                case "velocidad":
                    //se crea el bonus de velocidad de la barra
                    InstanciarBonus(bonusVel);
                    break;
                case "pelota":
                    InstanciarBonus(bonusPelota);
                    break;
                case "barra":
                    InstanciarBonus(bonusBarra);
                    break;
                case "tamanio":
                    InstanciarBonus(bonusTamanio);
                    break;
                default:
                    break;
            }
            
        }
    }

}
