using UnityEngine;
using DG.Tweening;

public class SimpleTransformTweens : MonoBehaviour
{
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			PlaySimpleTween();
	}

	private void PlaySimpleTween()
	{
	}
}
