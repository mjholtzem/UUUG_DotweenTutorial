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
		//Basic Transform Tweens
		transform.DOMove(new Vector3(1, 0, 0), 1);
		transform.DORotate(new Vector3(0, 0, 360), 1, RotateMode.FastBeyond360);
		transform.DOScale(3.5f, 1);
	}
}
