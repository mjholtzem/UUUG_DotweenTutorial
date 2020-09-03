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
		float destination = _hasMoved ? 1 : -1;
		if(easeType == Ease.INTERNAL_Custom)
			transform.DOMoveX(destination, 2).SetEase(animationCurve);
		else
			transform.DOMoveX(destination, 2).SetEase(easeType);
		_hasMoved = !_hasMoved;
	}
}
