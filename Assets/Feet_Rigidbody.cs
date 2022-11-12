// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Feet_Rigidbody : MonoBehaviour
// {
//     public bool isGrounded = false;

//    void OnTriggerEnter2D (Collider2D other) {
//          if (other.gameObject.CompareTag ("Ground")) {
//              isGrounded = true;
//          } else {
//              isGrounded = false;
//          }
//     }
//     void Update (){
//         isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
//     }
// }
