using UnityEngine;
using System.Collections;

public class RingSpawn : MonoBehaviour 
{
public GameObject ring;  
public float fiveSecond = 0;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

		fiveSecond += Time.deltaTime;
		if (fiveSecond > 1)
		{		
			fiveSecond = 0;
				GameObject obj = Instantiate (ring) as GameObject;  
				obj.transform.position = new Vector3 (20, 0, 17);

		}
	}

}