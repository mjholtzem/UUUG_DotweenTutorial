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
	}
}
