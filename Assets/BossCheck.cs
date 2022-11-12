// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class BossCheck : MonoBehaviour
// {
//     [SerializeField] private LayerMask Player;
//     public bool touchingBoss;

//     private void OnTriggerStay2D(Collider2D collider) {
//         touchingBoss = ( collider != null) &&(((1 << collider.gameObject.layer) & Ground) != 0);
//         ; //ti shmainei auto?
//     }
//     private void OnTriggerExit2D(Collider2D collider) {
//         touchingBoss = false; 
//     }
//     //s 

//     anim.SetTrigger("meeleeAttack");
// }