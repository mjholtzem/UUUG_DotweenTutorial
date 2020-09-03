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
		//Initialize Starting Variables
		var startColor = _spriteRenderer.color;
		startColor.a = 0;
		_spriteRenderer.color = startColor;
		transform.localPosition = Vector3.zero;
		transform.localScale = Vector3.zero;


		//Play Tween Sequence
		Sequence sequence = DOTween.Sequence();

		sequence.Append(transform.DOScale(3, .5f).SetEase(Ease.OutBack)); //Scale In
		sequence.Join(gameObject.GetComponent<SpriteRenderer>().DOFade(1, .5f));
		sequence.AppendInterval(.5f);

		sequence.Append(transform.DOMove(new Vector2(-1, 1), .5f)); //Top Left Corner
		sequence.Append(transform.DOMove(new Vector2(1, 1), .5f)); //Top Right Corner
		sequence.Append(transform.DOMove(new Vector2(1, -1), .5f)); //Bottom Right Corner
		sequence.Append(transform.DOMove(new Vector2(-1, -1), .5f)); //Bottom Left Corner
		sequence.Append(transform.DOMove(new Vector2(0, 0), .5f)); //Center

		sequence.Append(transform.DOScale(0, .5f).SetEase(Ease.InBack)); //Scale Down
		sequence.Join(gameObject.GetComponent<SpriteRenderer>().DOFade(0, .5f));
		sequence.AppendInterval(.5f);

		sequence.SetLoops(-1, LoopType.Restart);
	}
}
