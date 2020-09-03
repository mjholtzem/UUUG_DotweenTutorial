using UnityEngine;
using DG.Tweening;

public class MoveWithEaseType : MonoBehaviour
{
	public Ease easeType;
	public AnimationCurve animationCurve;

	private bool _hasMoved = false;

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			PlayTweenWithEaseType();
	}

	private void PlayTweenWithEaseType()
	{
	}
}
