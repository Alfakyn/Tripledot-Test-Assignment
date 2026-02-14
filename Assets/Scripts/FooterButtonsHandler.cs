using UnityEngine;
using UnityEngine.UI;

//Attach this script to the parent UI object of the buttons
public class FooterButtonsHandler : MonoBehaviour
{
	private void Start()
	{
		/* Quick hack to disable the leftmost and rightmost buttons.
		 * This would probably be handled by a UI Manager script with granular control of each button.
		 * The purpose of this is to showcase the "Disabled" state on the button prefabs */
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			Button button = child.GetComponent<Button>();
			if (button == null)
			{
				//Error handling would go here
				continue;
			}
			if (i == 0 || i == transform.childCount - 1)
			{
				button.interactable = false;
			}
		}
	}
}
