using UnityEngine;

public enum WeaponsType
{
    Gun,
    Flamethrower, 
    Hammer,
    Saw,
    Sword
}

public enum WeaponsStrength
{
    Low,
    Medium,
    High
}

public abstract class WeaponsBase : MonoBehaviour
{
    [SerializeField] protected float damage;
    [SerializeField] protected float cooldown;
    [SerializeField] protected WeaponsType weaponType;
    [SerializeField] protected WeaponsStrength weaponStrength = WeaponsStrength.Medium;

    protected float lastAttackTime;

    public void TryAttack()
    {
        if (!CanAttack())
        {
            Debug.Log("Reloading...");
            return;
        }

        lastAttackTime = Time.time;
        Attack();
    }

    protected bool CanAttack()
    {
        return Time.time >= lastAttackTime + cooldown;
    }

    protected void Attack()
    {
        string msg = "";
        if (weaponType == WeaponsType.Gun)
        {
            msg = "Pew!";
        }
        else if (weaponType == WeaponsType.Flamethrower)
        {
            msg = "Let it burn!";
        }
        else if (weaponType == WeaponsType.Hammer)
        {
            msg = "Smash!";
        }
        else if (weaponType == WeaponsType.Saw)
        {
            msg = "Bzzt!";
        }
        else if (weaponType == WeaponsType.Sword)
        {
            msg = "Stab!";
        }

        if (weaponStrength == WeaponsStrength.Low)
        {
            Debug.Log(msg.ToLower());
        }
        else if (weaponStrength == WeaponsStrength.Medium)
        {
            Debug.Log(msg);
        }
        else if (weaponStrength == WeaponsStrength.High)
        {
            Debug.Log(msg.ToUpper());
        }
    }

}
