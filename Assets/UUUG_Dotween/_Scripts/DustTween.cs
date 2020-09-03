using DG.Tweening;
using UnityEngine;

public class DustTween : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;
	public float xMin, xMax, yMin, yMax;
	
	void Start()
	{
		PlayDustTween();
	}

	private void PlayDustTween()
	{
		float targetX = Random.Range(xMin, xMax) + transform.position.x;
		float targetY = Random.Range(yMin, yMax) + transform.position.y;

		Vector3 posA = new Vector3(Mathf.Lerp(transform.position.x, targetX, .75f), Mathf.Lerp(transform.position.y, targetY, .25f), transform.position.z);
		Vector3 posB = new Vector3(targetX, targetY, transform.position.z);

		Sequence sequence = DOTween.Sequence();
		sequence.Append(transform.DOPath(new Vector3[] { posA, posB }, 1, PathType.CatmullRom).SetEase(Ease.OutQuad));
		sequence.Insert(.75f, spriteRenderer.DOFade(0, .25f));
		sequence.OnComplete(() => Destroy(gameObject));
	}
}
