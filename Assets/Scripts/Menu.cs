using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	public bool isQuitBtn = false;
		void OnMouseEnter () {
			renderer.material.color = Color.black;
		
		}
		void OnMouseExit () {
			renderer.material.color = Color.red;
		
		}
		void OnMouseUp(){
			if(isQuitBtn)
			{
				Application.Quit();
			}
			else
			{
				Application.LoadLevel(1);
			}
		}
}
