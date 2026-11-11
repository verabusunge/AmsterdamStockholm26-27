using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class OrderSystem : MonoBehaviour
{
    public DishesScript[] dishes;
    public int[] customers;
    public float time = 60;
    public int currency = 0;

    [Header("UI")]
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI currencyText;

    private int currentCustomerIndex = 0;
    private float currentTime = 0;
    private bool timerActive;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        if (timerActive)
        {
            time = time - Time.deltaTime;
        }
        if (currentTime >= 60)
        {
            print("time is out");
        }

        if (time == 45)
        {

        }

        UpdateUI();


    }

    public void dishFinished()
    {
        currentCustomerIndex++;
        timerActive = false;

    }

    public void UpdateUI()
    {
        currencyText.text = ("money: " + currency.ToString() + ("kr"));
        timeText.text = ("time left: " + time.ToString("F0") + ("s"));
    }

    public void StartOrder()
    {
        currentTime = 0;
        timerActive = true;
    }
}
