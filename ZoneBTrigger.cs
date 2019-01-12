﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneBTrigger : MonoBehaviour{

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
            Debug.Log("pica sfera in zona B");
            Destroy(collision.gameObject);
            GameManager.setSelectedAnswer("B");    
        }
    }
}
