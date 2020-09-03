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
		target.gameObject.SetActive(true);
	}

	private void Hide()
	{
		target.gameObject.SetActive(false);
	}
}
