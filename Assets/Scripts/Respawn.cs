using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Respawn : MonoBehaviour {
    public Action<Collider2D> OnCollision;
    private void OnTriggerEnter2D(Collider2D col) {
        // Debug.Log(col.name);
        if ( OnCollision != null )
            OnCollision.Invoke(col);
    }
}
