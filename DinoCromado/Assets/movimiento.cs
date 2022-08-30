using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public int str;
    public bool Jump;
    private Rigidbody2D rb2d;
    public float LongCast;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    
    void Update()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, LongCast);
               if (hit.collider!=null)
           {
               Jump = false;
           }
        
        if (Input.GetKeyDown(KeyCode.Space)&&Jump==false)
        {
            rb2d.velocity = new Vector3(0, str, 0);
            Jump = true;
        }
      

    }
    private void OnDrawGizmoSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, Vector2.down * LongCast);
    }
}
