using UnrealEngine.Runtime;

namespace b1;

public class BUC_CameraBlendCache
{
	public FVector LastPlayerPos;

	public bool bRefPosUninitialized { get; set; }

	public GSLocation CurTargetRefPos { get; } = new GSLocation();

	public GSLocation CurPlayerRefPos { get; } = new GSLocation();

	public GSLocation CurTargetGiantRefPos { get; } = new GSLocation();

	public GSLocation CurPlayerGiantRefPos { get; } = new GSLocation();

	public GSLocation LastTargetRefPos { get; } = new GSLocation();

	public GSLocation LastPlayerRefPos { get; } = new GSLocation();

	public GSLocation LastCameraRefPos { get; } = new GSLocation();

	public float LastCameraRotationVelocity { get; set; }

	public float LastGiantT2PDistance { get; set; }

	public GSLocation LastGiantPlayerRefPos { get; set; }

	public GSLocation LastGiantTargetRefPos { get; set; }

	public BUC_CameraBlendCache()
	{
		bRefPosUninitialized = true;
	}

	public void ClearGiantCache()
	{
		LastGiantT2PDistance = -1f;
		LastGiantPlayerRefPos = null;
		LastGiantTargetRefPos = null;
	}
}
