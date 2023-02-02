using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int maxHealth;
    public int bonusHealth;
    [Range(0,1)]
    public float defence;
    public int regen;
    [HideInInspector()]
    public float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        TakeDamage(50);
    }

    public void TakeDamage(int baseDamage)
    {
        currentHealth -= baseDamage * (1 - defence);
    }

    public void Heal(float healAmount)
    {
        currentHealth = Mathf.Clamp(currentHealth + healAmount, 0, maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < maxHealth)
            Heal(regen * Time.deltaTime);
    }
}
