using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInHit : MonoBehaviour, Idamageable
{
    public void DealDamage(int damage)
    {
        Destroy(gameObject);
    }
}
