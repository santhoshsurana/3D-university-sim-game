using UnityEngine;
using System.Collections;

public class CoinBehavior : MonoBehaviour {
	public  AudioClip collect;

	void OnTriggerEnter(Collider collider)
	{
		
		if(collider.gameObject.name== "carl")
		{
			CoinController.coinCount++;
			AudioSource.PlayClipAtPoint(collect, transform.position);
			Destroy (this.gameObject);
			
		}
		
		
	}

	
}