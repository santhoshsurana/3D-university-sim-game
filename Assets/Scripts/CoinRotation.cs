using UnityEngine;
using System.Collections;

public class CoinRotation : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
		transform.Rotate ( 180 * Time.deltaTime , 0 , 0 );
	}
}
