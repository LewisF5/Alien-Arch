using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthDisplay : MonoBehaviour
{
    Slider healthSlider;

    PlayerHealth player;

    void Start()
    {
        healthSlider = GetComponent<Slider>();

        player = FindObjectOfType<PlayerHealth>();
    }

    void Update()
    {
        float currentHealth = player.getHealth();
        float maxHealth = player.startingHealth();

        healthSlider.value = currentHealth / maxHealth;
    }
}
