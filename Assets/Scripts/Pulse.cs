using UnityEngine;
using System.Collections;

public class Pulse : MonoBehaviour {

	public Color colorStart = Color.red;
	public Color colorEnd = Color.green;
	public float duration = 1.0F;
	public Renderer rend;
	public float delay = 1.0F;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale += new Vector3(0.3F, 0.3F, 0);

		float lerp = Mathf.PingPong(Time.time, duration) / duration;
		rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
		Object.Destroy(gameObject, 1.0f);
	}
}
