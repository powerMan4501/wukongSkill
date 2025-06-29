using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ProjectileScaleMgrData
{
	public EProjectileScaleCurveXAxisType ScaleCurveXAxisType;

	public EProjectileScaleCurveYAxisType ScaleCurveYAxisType;

	public FVector OriProjectileScale_Comp;

	public FVector OriProjectileScale_Actor;

	public FVector OriInnerBlockCompScale;

	public float OriProjectileRadius;

	public float ProjectileScaleAge;

	private TStrongObjectPtr<UCurveVector> mScaleCurve = new TStrongObjectPtr<UCurveVector>();

	private TStrongObjectPtr<UCurveFloat> mInnerRadiusCurve = new TStrongObjectPtr<UCurveFloat>();

	public float InnerRadiusCurveValue;

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

	public UCurveFloat InnerRadiusCurve
	{
		get
		{
			return mInnerRadiusCurve.Get();
		}
		set
		{
			mInnerRadiusCurve.Set(value);
		}
	}

	public BUC_ProjectileScaleMgrData()
	{
		ScaleCurveXAxisType = EProjectileScaleCurveXAxisType.Time;
		ScaleCurveYAxisType = EProjectileScaleCurveYAxisType.Scale;
		OriProjectileScale_Comp = FVector.OneVector;
		OriProjectileScale_Actor = FVector.OneVector;
		OriInnerBlockCompScale = FVector.OneVector;
		OriProjectileRadius = 0f;
		ProjectileScaleAge = -1f;
		InnerRadiusCurveValue = 0f;
	}
}
