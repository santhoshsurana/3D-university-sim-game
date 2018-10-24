using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {
	public float Seconds = 0;
	public float Minutes = 0;
	public float Timer = 0;
	// Update is called once per frame
	void OnGUI () {
	// This is if statement checks how many seconds there are to decide what to do.
	// If there are more than 0 seconds it will continue to countdown.
	// If not then it will reset the amount of seconds to 59 and handle the minutes;
	// Handling the minutes is very similar to handling the seconds.
	if(Seconds <= 0)
	{
		Seconds = 59;
		if(Minutes >= 1)
		{
			Minutes--;
		}
		else
		{
			Minutes = 0;
			Seconds = 0;
			string Timer =Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
			GUI.Box (new Rect(Screen.width - 120, 45, 60, 20), Timer);
			// This makes the guiText show the time as X:XX. ToString.("f0") formats it so there is no decimal place.
			//GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
		}
	}
	else
	{
		Seconds -= Time.deltaTime;
	}
	
	// These lines will make sure the time is shown as X:XX and not X:XX.XXXXXX
	if(Mathf.Round(Seconds) <= 9)
	{
			string Timer =Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
			GUI.Box (new Rect(Screen.width - 120, 45, 60, 20), Timer);
		//GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
		
	}
	else
	{
			string Timer =Minutes.ToString("f0") + ":" + Seconds.ToString("f0");
			GUI.Box (new Rect(Screen.width - 120, 45, 60, 20), Timer);
		//GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":" + Seconds.ToString("f0");
	}
		
	if(Minutes == 0 && Seconds == 0)
	{
		if (CoinController.coinCount<216)
		{
			Application.LoadLevel(3);
			CoinController.coinCount=0;
			
		}
		else
		{
			Application.LoadLevel(3);
			CoinController.coinCount=0;
		}
	}
	else if (CoinController.coinCount>=50)
	{
			Application.LoadLevel(2);
			CoinController.coinCount=0;
			
	}
		
	}
}
