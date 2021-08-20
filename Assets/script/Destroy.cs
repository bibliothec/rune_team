using UnityEngine;

public class Destroy : MonoBehaviour
{
	/// <summary>
	/// 衝突した時
	/// </summary>
	///<param name="collision"></param>
	private void OnCollisionEnter2D(Collision2D collision)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (collision.collider.tag == "Ground")
		{
			// 0.2秒後に消える
			Destroy(gameObject, 0.01f);
		}
		else if (collision.collider.tag == "Enemy"){
			Destroy(gameObject, 0.01f);
		}
	}
}