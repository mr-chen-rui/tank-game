using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public abstract class Entity : MonoBehaviour
{
    protected float health;
    protected float armor;
    protected float combatPower;

    public void TakeDamage(float damage)
    {
        if (damage - armor > 0)
        {
            health -= damage - armor;
        }
        if (health == 0)
        {
            Die();
        }
    }
    protected void Die()
    {
        
    }
}
