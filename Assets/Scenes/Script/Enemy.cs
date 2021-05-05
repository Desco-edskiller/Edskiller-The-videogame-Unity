using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{


  private void OnCollisionEnter2D(Collision2D collision)
   {
    if (collision.transform.CompareTag("Player"))
    {
       Debug.Log("Player Damaged");      
      Destroy(collision.gameObject);
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  }
}
