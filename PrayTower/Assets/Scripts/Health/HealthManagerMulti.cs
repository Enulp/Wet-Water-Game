using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class HealthManagerMulti : NetworkBehaviour{


	[SerializeField]
	AudioClip[] death;

	public int maxHealth;
	public int currentHealth;

	public PlayerControllerMulti thePlayer;

	public float invincibilityLength;
	private float invincibilityCounter;

	public GameObject playerRenderer;
	private float flashCounter;
	public float flashLength = 0.1f;

	private bool isRespawning;
	private Vector3 respawnPoint;
	public float respawnLength;

	public GameObject deathEffect;
	public Image blackScreen;
	private bool isFadeToBlack;
	private bool isFadeFromBlack;
	public float fadeSpeed;
	public float waitForFade;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;

		//thePlayer = FindObjectOfType<PlayerController>();

		respawnPoint = thePlayer.transform.position;
	}

	//Update is called once per frame
	void Update () {
		if(invincibilityCounter > 0)
		{
			invincibilityCounter -= Time.deltaTime;

			flashCounter -= Time.deltaTime;
			if(flashCounter <= 0)
			{
				if(playerRenderer.activeSelf)
				{
					playerRenderer.SetActive (false);
				}
				else
				{
					playerRenderer.SetActive (true);
				}
				flashCounter = flashLength;
			}

			if(invincibilityCounter <= 0)
			{
				playerRenderer.SetActive(true);
			}
		}

		if(isFadeToBlack)
		{
			blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 1f, fadeSpeed * Time.deltaTime));
			if(blackScreen.color.a == 1f)
			{
				isFadeToBlack = false;
			}
		}

		if (isFadeFromBlack)
		{
			blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 0f, fadeSpeed * Time.deltaTime));
			if (blackScreen.color.a == 0f)
			{
				isFadeFromBlack = false;
			}
		}
	}
	public void HealPlayer(int healAmount)
	{
		currentHealth += healAmount;

		if(currentHealth > maxHealth)
		{
			currentHealth = maxHealth;
		}
	}

	public void SetSpawnPoint(Vector3 newPosition)
	{
		respawnPoint = newPosition;
	}
}