using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ForceFightControllerConfigComp")]
public class BUS_ForceFightControllerConfigComp : UActorEditCompBase
{
	private static bool ForceFightControlConfig_IsValid;

	private static int ForceFightControlConfig_Offset;

	private static FFieldAddress ForceFightControlConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSForceFightUnitGroupConfig> ForceFightControlConfig_Marshaler;

	[Tooltip("配置列表")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("配置列表")]
	[BlueprintReadWrite]
	[Category("战斗触发配置")]
	[USharpPath("/Script/b1-Managed.BUS_ForceFightControllerConfigComp:ForceFightControlConfig")]
	public TArrayReadWrite<FGSForceFightUnitGroupConfig> ForceFightControlConfig
	{
		get
		{
			CheckDestroyed();
			if (!ForceFightControlConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ForceFightControllerConfigComp:ForceFightControlConfig");
				return null;
			}
			if (ForceFightControlConfig_Marshaler == null)
			{
				ForceFightControlConfig_Marshaler = new TArrayReadWriteMarshaler<FGSForceFightUnitGroupConfig>(1, ForceFightControlConfig_PropertyAddress, CachedMarshalingDelegates<FGSForceFightUnitGroupConfig, FGSForceFightUnitGroupConfig>.FromNative, CachedMarshalingDelegates<FGSForceFightUnitGroupConfig, FGSForceFightUnitGroupConfig>.ToNative);
			}
			return ForceFightControlConfig_Marshaler.FromNative(IntPtr.Add(base.Address, ForceFightControlConfig_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_ForceFightControllerLogicData bUC_ForceFightControllerLogicData = RequireWritableData<b1.BUC_ForceFightControllerLogicData>();
		foreach (FGSForceFightUnitGroupConfig item in ForceFightControlConfig)
		{
			bUC_ForceFightControllerLogicData.ForceFightControlConfig.Add(new FForceFightUnitGroupConfig(item));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ForceFightControllerConfigComp");
		NativeReflection.GetPropertyRef(ref ForceFightControlConfig_PropertyAddress, unrealStruct, "ForceFightControlConfig");
		ForceFightControlConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForceFightControlConfig");
		ForceFightControlConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForceFightControlConfig", Classes.FArrayProperty);
	}

	static BUS_ForceFightControllerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ForceFightControllerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ForceFightControllerConfigComp));
	}
}
