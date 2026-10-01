using System.Runtime.Intrinsics.X86;
using UnityEngine;

public interface Entity : MonoBehaviour
{
    public float health;
    public float armor;
    public float combatPower;

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
