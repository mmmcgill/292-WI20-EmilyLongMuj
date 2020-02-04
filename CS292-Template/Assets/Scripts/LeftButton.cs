using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LeftButton : MonoBehaviour {
	public Button yourButton;
    public GameObject Blaze;

        
	void Start () {

		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
	}
}