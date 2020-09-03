using UnityEngine;
using DG.Tweening;

public class MoveWithLoop : MonoBehaviour
{
	public LoopType loopType;

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			PlayTweenWithLoop();
	}

	private void PlayTweenWithLoop()
	{
		transform.DOMoveX(-.5f, .5f).SetEase(Ease.InOutQuad).SetLoops(-1, loopType);
	}
}
