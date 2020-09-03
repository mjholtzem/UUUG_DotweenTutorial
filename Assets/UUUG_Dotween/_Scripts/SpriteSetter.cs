using UnityEngine;

[ExecuteAlways]
public class SpriteSetter : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;
	public int spriteIndex = 0;
	public Sprite[] sprites;

	// Update is called once per frame
	void Update()
	{
		spriteRenderer.sprite = sprites[(int)Mathf.Repeat(spriteIndex, sprites.Length)];
	}
}
