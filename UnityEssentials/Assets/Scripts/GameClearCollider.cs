using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameClearCollider : MonoBehaviour
{
    [SerializeField] private GameObject GameClearUI;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            GameClearUI.SetActive(true);
        }
    }
}
