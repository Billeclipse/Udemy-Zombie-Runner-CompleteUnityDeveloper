using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject playerSpawnPoints;
	public GameObject landingAreaPrefab;

	private Transform[] SpawnPoints;
	private bool reSpawn = false;

	void Start () {
		SpawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
		ReSpawn();
	}
	
	void Update () {
		if (reSpawn)
		{
			ReSpawn();
		}
	}

	private void ReSpawn()
	{
		this.transform.position = SpawnPoints[Random.Range(1, SpawnPoints.Length)].position;
		reSpawn = false;
		//Debug.Log("Respawn to : x->" + this.transform.position.x + " y->"+ this.transform.position.y + " z->" + this.transform.position.z);
	}

	void OnFindClearArea()
	{
		Invoke("DropFlare", 3f);
	}

	void DropFlare()
	{
		Instantiate(landingAreaPrefab, transform.position, transform.rotation);
	}
}
