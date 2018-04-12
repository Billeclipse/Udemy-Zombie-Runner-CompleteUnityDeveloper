using UnityEngine;

public class InnerVoice : MonoBehaviour {

	public AudioClip whatHappened;
	public AudioClip goodLandingArea;

	private AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource>();
		audioSource.clip = whatHappened;
		audioSource.Play();
	}
	
	void OnFindClearArea()
	{
		audioSource.clip = goodLandingArea;
		audioSource.Play();

		Invoke("CallHeli", goodLandingArea.length + 1f);
	}

	void CallHeli()
	{
		SendMessageUpwards("OnMakeInitialHeliCall");
	}

}
