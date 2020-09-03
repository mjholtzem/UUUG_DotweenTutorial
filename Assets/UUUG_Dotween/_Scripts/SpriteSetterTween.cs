using UnityEngine;
using DG.Tweening;

public class SpriteSetterTween : MonoBehaviour
{
	public SpriteSetter spriteSetter;

	private void Start()
	{
		PlaySpriteSetterTween();
	}

	private void PlaySpriteSetterTween()
	{
		DOTween.To
			(
				() => spriteSetter.spriteIndex, //Getter
				index => spriteSetter.spriteIndex = index, //Setter
				spriteSetter.sprites.Length - 1, //Target
				1 //Duration
			)
			.SetLoops(-1, LoopType.Restart)
			.SetEase(Ease.Linear);
	}
}
