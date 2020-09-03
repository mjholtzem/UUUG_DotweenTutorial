using DG.Tweening;
using UnityEngine;

public class TweenCallbacks : MonoBehaviour
{
	public Transform target;

	private bool _isShowing = false;
	private bool _isTweening = false;

	void Start()
	{
		target.localScale = Vector3.zero;
		target.gameObject.SetActive(false);
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space) && !_isTweening)
		{
			if(_isShowing)
				Hide();
			else
				Show();
		}
	}

	private void Show()
	{
		target.DOScale(1, .25f).SetEase(Ease.OutBack)
			.OnStart(() =>
			{
				target.gameObject.SetActive(true);
				_isTweening = true;
			})
			.OnComplete(()=>
			{
				_isTweening = false;
				_isShowing = true;
			});
	}

	private void Hide()
	{
		target.DOScale(0, .25f).SetEase(Ease.InBack)
			.OnStart(() =>
			{
				_isTweening = true;
			})
			.OnComplete(() =>
			{
				target.gameObject.SetActive(false);
				_isTweening = false;
				_isShowing = false;
			});
	}
}
