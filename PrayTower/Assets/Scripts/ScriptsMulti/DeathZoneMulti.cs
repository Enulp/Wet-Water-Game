using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(PlayerComponentMulti))]
public class DeathZoneMulti : NetworkBehaviour
{
	[SerializeField] public static Behaviour[] disableOnDeath;
	private bool[] wasEnabled;

	[SerializeField]
	public Transform spawnPoint;

	[SerializeField]
	public Transform player;

	public void Setup()
	{
		wasEnabled = new bool[disableOnDeath.Length];
		for (int i = 0; i < wasEnabled.Length; i++)
		{
			wasEnabled[i] = disableOnDeath[i].enabled;
		}
		
		SetDefaults();
	}

	void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
		Instantiate(player, spawnPoint.transform.position, spawnPoint.transform.rotation);
	}

	public void SetDefaults()
	{

		for (int i = 0; i < disableOnDeath.Length; i++)
		{
			disableOnDeath[i].enabled = wasEnabled[i];
		}

		Collider _col = GetComponent<Collider>();
		if (_col != null)
		{
			_col.enabled = true;
		}
	}
}
 