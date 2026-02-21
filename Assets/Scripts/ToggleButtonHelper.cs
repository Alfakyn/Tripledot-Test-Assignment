using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ToggleButtonHelper : MonoBehaviour
{
	[SerializeField] private bool toggledOnAtStart;

	[SerializeField] private Sprite toggledOnSprite;
	[SerializeField] private Sprite toggledOffSprite;

	private Image image;

	private bool toggledState;

	private void Start()
	{
		image = GetComponent<Image>();
		if (toggledOnSprite == null)
		{
			Debug.LogError("The " + nameof(toggledOnSprite) + " reference in the " + GetType().ToString() + " component of the " + gameObject.name + " object is missing");
		}
		if (toggledOffSprite == null)
		{
			Debug.LogError("The " + nameof(toggledOffSprite) + " reference in the " + GetType().ToString() + " component of the " + gameObject.name + " object is missing");
		}

		toggledState = toggledOnAtStart;
		UpdateVisuals(toggledOnAtStart);
	}

	/// <summary>
	/// Whenever this method is called, the internal state of the button is set, and the visuals updated accordingly
	/// </summary>
	public void Toggle()
	{
		toggledState = !toggledState;
		UpdateVisuals(toggledState);
	}

	private void UpdateVisuals(bool isToggledOn)
	{
		if (isToggledOn)
		{
			image.sprite = toggledOnSprite;
		}
		else
		{
			image.sprite = toggledOffSprite;
		}
	}
}
