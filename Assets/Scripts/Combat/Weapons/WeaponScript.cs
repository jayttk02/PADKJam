using UnityEngine;

public class WeaponScript : WeaponsBase
{
    //[SerializeField] protected WeaponsType weaponType;
    //[SerializeField] protected WeaponsStrength weaponStrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            TryAttack();
        }
    }
}
