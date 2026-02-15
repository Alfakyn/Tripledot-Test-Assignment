using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottomVarView : MonoBehaviour
{
	/// <summary>
	/// Barebones method that serves as a callback for when a button has been hovered on by a pointer
	/// </summary>
	/// <param name="button"> Workaround to be able to get a reference to the button that is calling this method. For debug purposes only.</param>
	public void ButtonSelected(Transform button)
	{
		if (button != null)
		{
			if (button.GetComponent<Button>().IsInteractable())
			{
				Debug.Log(button.name + " has been selected");
			}
		}
		else
		{
			Debug.Log("Button selected. No parameter passed");
		}
	}

	/// <summary>
	/// Barebones method that serves as a callback for when a button has stopped being hovered on by a pointer
	/// </summary>
	/// <param name="button"> Workaround to be able to get a reference to the button that is calling this method. For debug purposes only.</param>
	public void ButtonUnselected(Transform button)
	{
		if (button != null)
		{
			if (button.GetComponent<Button>().IsInteractable())
			{
				Debug.Log(button.name + " has been unselected");
			}
		}
		else
		{
			Debug.Log("Button unselected. No parameter passed");
		}
	}

	/// <summary>
	/// Barebones method that serves as a callback for when a button has been clicked/tapped
	/// </summary>
	/// <param name="content">Placeholder for the content that would open when this method is fired</param>
	public void ContentActivated(Transform content = null)
	{
		if (content != null)
		{
			Debug.Log(content.name + " has been activated");
		}
		else
		{
			Debug.Log("Content activated. No parameter passed");
		}
	}

	/// <summary>
	/// Barebones method that serves as a callback for when certain content would be toggled off (i.e. a "close" button on a menu has been pressed)
	/// </summary>
	/// <param name="content">Placeholder for the content that would close when this method is fired</param>
	public void ContentDeactivated(Transform content = null)
	{
		if (content != null)
		{
			Debug.Log(content.name + " has been deactivated");
		}
		else
		{
			Debug.Log("Content deactivated. No parameter passed");
		}
	}
}
