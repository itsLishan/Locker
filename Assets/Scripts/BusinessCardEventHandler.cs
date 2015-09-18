using UnityEngine;
using System.Collections;
using Vuforia;

public class BusinessCardEventHandler : MonoBehaviour, IVirtualButtonEventHandler {
	
	//private GameObject videoPlane;
	// Use this for initialization
	void Start () {
		//videoPlane = GameObject.FindGameObjectWithTag ("Video");
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i) {
			// Register with the virtual buttons TrackableBehaviour
			vbs [i].RegisterEventHandler (this);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		//videoPlane.GetComponent<MeshRenderer>().enabled = true;
		//FillScreen fScreen = videoPlane.GetComponent<FillScreen> ();
		//fScreen.enabled = true;
		Handheld.PlayFullScreenMovie ("CardMovie.mp4", Color.black, FullScreenMovieControlMode.Hidden);
	}
	
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		//videoPlane.GetComponent<MeshRenderer>().enabled = false;
		//videoPlane.GetComponent<FillScreen>().enabled = false;
	}
	
}
