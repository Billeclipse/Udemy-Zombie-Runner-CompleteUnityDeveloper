using UnityEngine;

public class RadioSystem : MonoBehaviour {

	public AudioClip initialHeliCall;
	public AudioClip initialCallReply;

	private AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

	void OnMakeInitialHeliCall()
	{
		audioSource.clip = initialHeliCall;
		audioSource.Play();

		Invoke("initialCallReplyPlay", initialHeliCall.length + 1f);		
	}

	void initialCallReplyPlay()
	{
		audioSource.clip = initialCallReply;
		audioSource.Play();
		BroadcastMessage("OnDispatchHelicopter");
	}
}
