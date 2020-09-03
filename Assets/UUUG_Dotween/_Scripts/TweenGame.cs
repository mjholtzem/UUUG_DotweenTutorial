using DG.Tweening;
using UnityEngine;

public class TweenGame : MonoBehaviour
{
	public Camera mainCamera;
	public SpriteRenderer flashBg;
	public Transform player;
	public DustTween dustTweenPrefab;

	[Header("Config Values")]
	public float jumpHeight = 2;
	public float jumpDuration = 1;
	public float shakeStrength = 3;
	public float shakeDuration = 1;
	public int minDustParticles, maxDustParticles;

	private bool _isJumping = false;

	// Update is called once per frame
	void Update()
	{
		if(!_isJumping && Input.GetMouseButtonDown(0))
		{
			DoJumpTween(Input.mousePosition);
		}
	}

	private void DoJumpTween(Vector2 inMousePos)
	{
		Vector3 worldMousePos = mainCamera.ScreenToWorldPoint(inMousePos);
		Vector3 targetPos = new Vector3(worldMousePos.x, player.position.y, player.position.z);

		float direction = Mathf.Sign(targetPos.x - player.position.x);

		_isJumping = true;

		//Scale in direction of Jump
		player.DOScaleX(3 * direction, jumpDuration/2);

		//Jump tween
		player.DOJump(targetPos, jumpHeight, 1, jumpDuration)
			.SetEase(Ease.Linear)
			.OnComplete(()=>
			{
				DoJumpImpact();
				_isJumping = false;
			});
	}

	private void DoJumpImpact()
	{
		//Camer Shake Tween
		mainCamera.DOShakePosition(shakeDuration, new Vector3(shakeStrength, shakeStrength, 0));

		//BG Flash Tween
		flashBg.DOFade(1, .15f).SetEase(Ease.Linear).SetLoops(2, LoopType.Yoyo);

		//Spawn Dust Tweens
		int particleCount = Random.Range(minDustParticles, maxDustParticles);
		for(int i = 0; i < particleCount; i++)
		{
			DustTween dust = Instantiate(dustTweenPrefab, player.position - new Vector3(0, .5f, 0), Quaternion.identity);
			dust.gameObject.SetActive(true);
		}
	}
}
