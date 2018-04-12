using UnityEngine;

public class ClearArea : MonoBehaviour {

	public float timeSinceLastTrigger = 0f;

	private bool foundClearArea = false;

	void Update () {
		timeSinceLastTrigger += Time.deltaTime;

		if(timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f && !foundClearArea)
		{
			SendMessageUpwards("OnFindClearArea");
			foundClearArea = true;
		}
	}

	private void OnTriggerStay(Collider collider)
	{
		if (!collider.tag.Equals("Player"))
		{
			timeSinceLastTrigger = 0f;
		}		
	}
}
