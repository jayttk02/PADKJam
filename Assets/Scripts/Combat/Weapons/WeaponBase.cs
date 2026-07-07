using UnityEngine;

public abstract class WeaponsBase : MonoBehaviour
{
    [SerializeField] protected float damage;
    [SerializeField] protected float cooldown;

    protected float lastAttackTime;

    public void TryAttack()
    {
        if (!CanAttack())
        {
            return;
        }

        lastAttackTime = Time.time;
        Attack();
    }

    protected bool CanAttack()
    {
        return Time.time >= lastAttackTime + cooldown;
    }

    protected abstract void Attack();

}
