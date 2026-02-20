using System.Collections;
using TMPro;
using UnityEngine;

public class LevelCompletedScreenHelper : MonoBehaviour
{
	private Animator animator;

	[SerializeField] private TextMeshProUGUI starTMP;
	[SerializeField] private TextMeshProUGUI coinTMP;
	[SerializeField] private TextMeshProUGUI crownTMP;
	private int starAmount;
	private int coinAmount;
	private int crownAmount;

	private void Start()
	{
		animator = GetComponent<Animator>();

		starAmount = int.Parse(starTMP.text);
		coinAmount = int.Parse(coinTMP.text);
		crownAmount = int.Parse(crownTMP.text);
	}

	private IEnumerator CountUp(TextMeshProUGUI TMP, int max, string animatorTrigger)
	{
		int total = 0;
		while (total < max)
		{
			total++;
			TMP.text = total.ToString();
			yield return new WaitForEndOfFrame();
		}

		animator.SetTrigger(animatorTrigger);
	}

	public void CountStars()
	{
		StartCoroutine(CountUp(starTMP, starAmount, "Star Count Done"));
	}

	public void CountCoins()
	{
		StartCoroutine(CountUp(coinTMP, coinAmount, "Coin Count Done"));
	}

	public void CountCrowns()
	{
		StartCoroutine(CountUp(crownTMP, crownAmount, "Crown Count Done"));
	}
}
