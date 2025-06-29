using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_ImpactActionData
{
	private TStrongObjectPtr<UAnimMontage> mForwardImpactActionAnim = new TStrongObjectPtr<UAnimMontage>();

	private TStrongObjectPtr<UAnimMontage> mLeftSideImpactActionAnim = new TStrongObjectPtr<UAnimMontage>();

	private TStrongObjectPtr<UAnimMontage> mRightSideImpactActionAnim = new TStrongObjectPtr<UAnimMontage>();

	public List<UShapeComponent> CheckComps = new List<UShapeComponent>();

	public List<FGSSweepCheckShapeInfo> CheckCompShapeInfo = new List<FGSSweepCheckShapeInfo>();

	public bool bEnableImpactAction { get; set; }

	public float EnableImplactCalculationParameter { get; set; }

	public float EnableImpactActionHeightDiff { get; set; }

	public float EnableImpactAnimThreshold { get; set; }

	public float EnableImpactActionMinSpeed { get; set; }

	public float LeftAngleSplitLine { get; set; }

	public float MiddleLeftAngleSplitLine { get; set; }

	public float MiddleRightAngleSplitLine { get; set; }

	public float RightAngleSplitLine { get; set; }

	public UAnimMontage ForwardImpactActionAnim
	{
		get
		{
			return mForwardImpactActionAnim.Get();
		}
		set
		{
			mForwardImpactActionAnim.Set(value);
		}
	}

	public UAnimMontage LeftSideImpactActionAnim
	{
		get
		{
			return mLeftSideImpactActionAnim.Get();
		}
		set
		{
			mLeftSideImpactActionAnim.Set(value);
		}
	}

	public UAnimMontage RightSideImpactActionAnim
	{
		get
		{
			return mRightSideImpactActionAnim.Get();
		}
		set
		{
			mRightSideImpactActionAnim.Set(value);
		}
	}
}
