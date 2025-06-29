using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_WeaponCommData : b1.IBUC_WeaponCommData
{
	private TStrongObjectPtr<UCurveVector> mScaleCurve = new TStrongObjectPtr<UCurveVector>();

	public bool bIsActive { get; set; }

	public bool EnableScale { get; set; }

	public float ScaleTimer { get; set; }

	public UCurveVector ScaleCurve
	{
		get
		{
			return mScaleCurve.Get();
		}
		set
		{
			mScaleCurve.Set(value);
		}
	}

	public float DestroyDelayTime { get; set; }

	public void Init()
	{
		bIsActive = true;
		EnableScale = false;
		ScaleTimer = 0f;
		DestroyDelayTime = -1f;
	}
}
