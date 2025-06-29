using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_ShadowPoseableData
{
	public FVector OriActorScale = FVector.OneVector;

	public List<MatParamInfoForData> MatInfoList = new List<MatParamInfoForData>();

	public float TotalUpdateTimeInSecond;

	public float UpdateTimer;

	public bool IsFinish;

	public float Scale;

	private TStrongObjectPtr<UCurveFloat> mScaleCurve = new TStrongObjectPtr<UCurveFloat>();

	public List<FMatParam> PostProcessMatInfoList { get; } = new List<FMatParam>();

	public List<UMaterialInstanceDynamic> PostProcessMIDs { get; } = new List<UMaterialInstanceDynamic>();

	public UCurveFloat ScaleCurve
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
}
