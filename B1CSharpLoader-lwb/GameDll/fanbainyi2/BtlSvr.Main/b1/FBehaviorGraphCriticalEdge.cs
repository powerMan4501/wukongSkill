namespace b1;

public class FBehaviorGraphCriticalEdge : FBehaviorGraphEdgeBase, IFromLeftNodeEdge, IToRightNodeEdge
{
	public int CoolDownTimeMs { get; set; }

	public int RemainCoolDownTimeMs { get; set; }

	public bool bFromFailedPin { get; set; }

	public FBehaviorLeftNodeInstance FromNodeInstance { get; set; }

	public FBehaviorRightNodeInstance ToNodeInstance { get; set; }

	public void OnTick(float DeltaTime)
	{
		if (RemainCoolDownTimeMs > 0)
		{
			RemainCoolDownTimeMs -= (int)(DeltaTime * 1000f);
			return;
		}
		int num = IsInputSuccess();
		if (num != 0 && num > 0)
		{
			ExecuteOutput();
			RemainCoolDownTimeMs = CoolDownTimeMs;
		}
	}
}
