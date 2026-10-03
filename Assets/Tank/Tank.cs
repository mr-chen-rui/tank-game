using UnityEngine;
using Vector3 = UnityEngine.Vector3;


public class Tank : Entity
{

    public GameObject cannonMarker;
    public GameObject machineGunMarker;
    public GameObject Turret;
    public GameObject Cannon;

    public GameObject cannonAmmo;
    public int cannonAmmoAmount;
    public int cannonAmmoAmountMax;
    public GameObject machineGunAmmo;
    public int machineGunAmmoAmount;
    public int machineGunAmmoAmountMax;
    protected Vector3 cannonAimDirection;
    protected Vector3 machineGunAimDirection;

    public void Move(Vector2 dir)
    {
        
    }
    
    public void Aim(Vector2 dir)
    {
        
    
    }

    public void FireCannon()
    {
        if (cannonAmmoAmount > 0)
        {
            cannonAmmoAmount -= 1;
        }
    }

    public void FireMachineGun()
    {
         if (machineGunAmmoAmount > 0)
        {
            machineGunAmmoAmount -= 1;
        }
    }
}
