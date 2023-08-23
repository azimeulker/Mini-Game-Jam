using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class movement : MonoBehaviour
{
   public float x, y,z=0.0f;
    Rigidbody2D rb;
    public float speed=5.0f;
    //public Animator animator;
    public GameObject Lock;
    public GameObject menu;
    private Vector3 target;


    // Start is called before the first frame update
    void Start()
    {
        target=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            target=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z=transform.position.z;
        }
        transform.position=Vector3.MoveTowards(transform.position,target,speed*Time.deltaTime);
        
    }
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="lock")
        {
         
           if (Input.GetKeyDown(KeyCode.E)){
            Debug.Log("E key was pressed.");
            //SceneManager.LoadScene("Lock", LoadSceneMode.Additive);
           }
            
            
        }
    }
}
