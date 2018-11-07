using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(PlayerComponentMulti))]
public class PlayerSetupNetwork : NetworkBehaviour{

	[SerializeField]
	Behaviour[] thingsToDisable;    

	[SerializeField] 
	private string remoteLayername = "RemotePlayer";

	void Start()
	{
		if (!isLocalPlayer)
		{
			for (int i = 0; i < thingsToDisable.Length; i++)
			{
				thingsToDisable[i].enabled = false;
			}
			AssignRemoteLayer();
		}
	}

	public override void OnStartClient()
	{
		base.OnStartClient();

		string _netID = GetComponent<NetworkIdentity>().netId.ToString();

		PlayerComponentMulti _player = GetComponent<PlayerComponentMulti>();
		
		GameManagerMulti.ResgisterPlayer(_netID, _player);
	}

	void AssignRemoteLayer()
	{
		gameObject.layer = LayerMask.NameToLayer(remoteLayername);
	}

	void OnDisbale()
	{
		GameManagerMulti.UnRegisterPlayer(transform.name);
	}
}
