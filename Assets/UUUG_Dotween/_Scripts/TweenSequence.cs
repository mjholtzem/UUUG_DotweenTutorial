using UnityEngine;
using DG.Tweening;

public class TweenSequence : MonoBehaviour
{
	private SpriteRenderer _spriteRenderer;

	private void Start()
	{
		_spriteRenderer = GetComponent<SpriteRenderer>();
		PlayTweenSequence();
	}

	private void PlayTweenSequence()
	{
	}
}
