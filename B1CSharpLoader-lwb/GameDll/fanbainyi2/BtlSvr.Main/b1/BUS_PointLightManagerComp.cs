using b1.Plugins.CustomLightSystem;
using UnrealEngine.Engine;

namespace b1;

public class BUS_PointLightManagerComp : UActorCompBaseCS
{
	private BUC_PointLightMangerData PointLightMangerData { get; set; }

	public override void OnAttach()
	{
		PointLightMangerData = RequireWritableData<BUC_PointLightMangerData>();
	}

	public override void OnBeginPlay()
	{
		if (GameplayTagExtension.IsValid(PointLightMangerData.EnableTag))
		{
			UCLSFunctionLibrary.RegisterNeedPointLightControlActor(PointLightMangerData.EnableTag.TagName, Owner);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (GameplayTagExtension.IsValid(PointLightMangerData.EnableTag))
		{
			UCLSFunctionLibrary.UnregisterNeedPointLightControlActor(PointLightMangerData.EnableTag.TagName);
		}
	}
}
