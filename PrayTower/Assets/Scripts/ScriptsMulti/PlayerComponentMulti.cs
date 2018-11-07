using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerComponentMulti : NetworkBehaviour
{
    [SyncVar]
    private bool _isDead = false;
    public bool isDead
    {
        get { return _isDead; }
        protected set { _isDead = value; }
    }

    [ClientRpc]
    public void RpcCheckisDead()
    {
        if (isDead)
        {
            return;
        }
        
    }
    
    private void Die()
    {
        isDead = true;

        for (int i = 0; i < DeathZoneMulti.disableOnDeath.Length; i++)
        {
            DeathZoneMulti.disableOnDeath[i].enabled = false;
        }
		
        Collider _col = GetComponent<Collider>();
        if (_col != null)
        {
            _col.enabled = false;
        }
    }

}
