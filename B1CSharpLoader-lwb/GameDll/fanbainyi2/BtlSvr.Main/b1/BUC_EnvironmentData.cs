using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_EnvironmentData : IPersistentECSData
{
	private TStrongObjectPtr<b1.BGUEnvironmentControllerBase> mEnvMgrActor = new TStrongObjectPtr<b1.BGUEnvironmentControllerBase>();

	public UExponentialHeightFogComponent EHFComp;

	public ExponentialHeightFogConfig PreExponentialHeightFogConfig;

	public ExponentialHeightFogConfig CurExponentialHeightFogConfig;

	public ExponentialHeightFogConfig TargetExponentialHeightFogConfig;

	public float RecoveryTimer_EHF;

	public float CurInterpolation_EHF;

	public float TargetInterpolation_EHF;

	public float InterpolationSpeed_EHF;

	public bool ChangeAbsolutelyOver_EHF;

	public float ChangePercentage;

	public int InterpolationTimes;

	public bool OnEHFChange;

	public bool OnEHFRecovery;

	public b1.BGUEnvironmentControllerBase EnvMgrActor
	{
		get
		{
			return mEnvMgrActor.Get();
		}
		set
		{
			mEnvMgrActor.Set(value);
		}
	}

	public BUC_EnvironmentData()
	{
		EHFComp = null;
		PreExponentialHeightFogConfig = default(ExponentialHeightFogConfig);
		CurExponentialHeightFogConfig = default(ExponentialHeightFogConfig);
		TargetExponentialHeightFogConfig = default(ExponentialHeightFogConfig);
		RecoveryTimer_EHF = 0f;
		CurInterpolation_EHF = 0f;
		TargetInterpolation_EHF = 0f;
		InterpolationSpeed_EHF = 0f;
		ChangeAbsolutelyOver_EHF = false;
		ChangePercentage = 0f;
		OnEHFChange = false;
		OnEHFRecovery = false;
	}
}
