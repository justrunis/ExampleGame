using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCOntroller : MonoBehaviour
{
    public int health;
    [SerializeField]
    private Text text;

    public void TakeDamage(int damage)
    {
        if (health > 0)
        {
            health -= damage;
            text.text = health.ToString();
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
