using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pla : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    Animator anim;
    [SerializeField] bool isGrounded = false;
    [SerializeField] Transform groundCheckCollider;
    [SerializeField] LayerMask groundLayer;
    public AudioSource Jump;
    public int Health = 100;



    // Start is called before the first frame update
    void Start()
    {
         rb = transform.GetComponent<Rigidbody2D>();
         anim = transform.GetComponent<Animator>();
    }
    

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        // if(GotHit()){
        //     Health -= 20;
        // }
        //if boss sword touches during the attack -20 health


       if(h != 0){
           anim.SetBool("Moving", true);
       }else anim.SetBool("Moving", false);

       if(Health <= 0){
        
       }

       if(h < 0){
           transform.localScale = new Vector3(-1, 1, 1);

       }else if(h > 0) transform.localScale = new Vector3(1, 1, 1);

       Vector2 pos = transform.position;

       pos.x += h * speed * Time.deltaTime;

       transform.position = pos;

       if(Input.GetKeyDown("space")){
           GroundCheck();
       }
    }

    void GroundCheck()
    {
        isGrounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, 0.2f, groundLayer);
        if(colliders.Length >= 1)
        {
            isGrounded = true;
        }
        //Debug.Log("isGrounded = " + isGrounded );
        if(isGrounded){
           rb.velocity = Vector2.up * 10f;
           //Jump.Play();
       }

    }
    // void GotHit(){
    //     //if sword touches player
    //     if(Bsc.touchingBoss == true){
    //        return true;
    //     }else return false;

    // }
    

  
}
