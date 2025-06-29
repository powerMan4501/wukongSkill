using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPC_FoliageCameraFadeData : IBPC_FoliageCameraFadeData, IPersistentECSData
{
	public bool bEnableFoliageFade;

	private TStrongObjectPtr<UMaterialParameterCollection> mFoliageFadeMPC = new TStrongObjectPtr<UMaterialParameterCollection>();

	public float CurrentFoliageFadeDistance { get; set; }

	public UMaterialParameterCollection FoliageFadeMPC
	{
		get
		{
			return mFoliageFadeMPC.Get();
		}
		set
		{
			mFoliageFadeMPC.Set(value);
		}
	}

	public float GetCurrentFoliageFadeDistance()
	{
		if (!bEnableFoliageFade)
		{
			return 0f;
		}
		return CurrentFoliageFadeDistance;
	}
}
