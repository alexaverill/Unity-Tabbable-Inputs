using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TabbableInput : MonoBehaviour {

	public List<string> test = new List<string>();
	public List<GameObject> Inputs = new List<GameObject>();
	public int position = 0;
	void Start () {
		
	}


	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown(KeyCode.Tab)){	
			//likely want torefactor at some point.
			if(Inputs[position].GetComponent<TMP_InputField>() != null){
				var input = Inputs[position].GetComponent<TMP_InputField>();
				input.Select();
				//input.ActivateInputField();
			}else if(Inputs[position].GetComponent<InputField>() != null){
				var input = Inputs[position].GetComponent<InputField>();
				
				input.Select();
			}else if(Inputs[position].GetComponent<Button>() != null){
				var input = Inputs[position].GetComponent<Button>();
				input.Select();
			}else if(Inputs[position].GetComponent<TMP_Dropdown>() != null){
				var input = Inputs[position].GetComponent<TMP_Dropdown>();
				input.Select();
				input.Show();
			}else if(Inputs[position].GetComponent<Dropdown>() != null){
				var input = Inputs[position].GetComponent<Dropdown>();
				input.Select();
				input.Show();
			}
			
			position ++;
		}
	}
}
