using UnityEngine;
using System.Collections;

public class FillScreen:MonoBehaviour
{
	/*public MovieTexture mTexture;
	public bool isBeingTouched;
	private Renderer renderer;
	private AudioSource aud;

	void Start(){
		renderer = GetComponent<Renderer> ();
		aud = GetComponent<AudioSource> ();
	}
	*/

	void Update()
	{
		Camera cam = Camera.main;
		
		float pos = (cam.nearClipPlane + 0.01f);
		
		transform.position = cam.transform.position + cam.transform.forward * pos;
		transform.LookAt (cam.transform);
		transform.Rotate (90.0f, 0.0f, 0.0f);
		
		float h = (Mathf.Tan(cam.fov*Mathf.Deg2Rad*0.5f)*pos*2f) /10.0f;
		
		transform.localScale = new Vector3(h*cam.aspect,1.0f, h);

		/*if (mTexture) {
			aud.clip = mTexture.audioClip;
			renderer.material.mainTexture = mTexture;
			if (isBeingTouched) {
				renderer.enabled = true;
				if (!mTexture.isPlaying) {
					mTexture.Play ();
					aud.Play ();
				}
			} else {
				renderer.enabled = false;
				if (mTexture.isPlaying) {
					mTexture.Stop ();
					aud.Stop ();
				}
				
			}
		}*/
	}
}
