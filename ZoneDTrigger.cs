﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneDTrigger : MonoBehaviour{

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
            Debug.Log("pica sfera in zona D");
            Destroy(collision.gameObject);
            GameManager.setSelectedAnswer("D");
        }
    }
}
