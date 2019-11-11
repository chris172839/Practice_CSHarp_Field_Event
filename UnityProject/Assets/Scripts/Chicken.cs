using UnityEngine;

public class Chicken : MonoBehaviour
{
	[Header("移動速度"),Range(1f,100f)]
	public float speed = 1f;
	[Header("跳躍高度"),Range(1,2000)]
	public int jump=10;
	[Header("對話內容")]
	public string talk="咕咕咕~~~";
	[Header("是否取得雞蛋")]
	public bool Egg;
    void Start()
    {
        print("遊戲開始!!!");
    }

    // Update is called once per frame
    void Update()
    {
        print(talk);
    }
}
