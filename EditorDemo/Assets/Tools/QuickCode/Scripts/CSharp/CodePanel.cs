//this file is auto created by QuickCode,you can edit it 
//do not need to care initialization of ui widget any more 
//------------------------------------------------------------------------------
/**
* @author :
* date    :
* purpose :
*/
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CodePanel
{

	#region UI Variable Statement 
	private Transform transform; 
	private Image image_Button; 
	private Toggle toggle_Toggle; 
	private Image image_Dropdown; 
	private Image image_InputField; 
	#endregion 

	#region UI Variable Assignment 
	private void InitUI() 
	{
		//assign transform by your ui framework
		//transform = ; 
		image_Button = transform.Find("Button").GetComponent<Image>(); 
		toggle_Toggle = transform.Find("Toggle").GetComponent<Toggle>(); 
		image_Dropdown = transform.Find("Dropdown").GetComponent<Image>(); 
		image_InputField = transform.Find("InputField").GetComponent<Image>(); 

	}
	#endregion 

	#region UI Event Register 
	private void AddEvent() 
	{

		toggle_Toggle.onValueChanged.AddListener(OnToggleValueChanged);
	}

	private void OnToggleValueChanged(bool arg)
	{

	}
	#endregion 

}
