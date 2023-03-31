using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject YouWonPanel;
    [SerializeField] private float _moveSpeed = 10f;

    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
    }
    private void OnCollisionEnter(Collision other)
    {
         if(other.gameObject.CompareTag("Endpoint"))
        {
           YouWon();
        }
    }
    public void YouWon()
    {
       
        Time.timeScale = 0;
        YouWonPanel.SetActive(true);
    
    }
}
