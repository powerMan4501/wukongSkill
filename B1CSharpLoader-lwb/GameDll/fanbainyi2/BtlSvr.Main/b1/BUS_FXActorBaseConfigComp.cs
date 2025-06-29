using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_FXActorBaseConfigComp")]
public class BUS_FXActorBaseConfigComp : UActorEditCompBase
{
	private static bool FXActorConfig_IsValid;

	private static int FXActorConfig_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("FXActorConfig")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_FXActorBaseConfigComp:FXActorConfig")]
	public FFXActorConfig FXActorConfig
	{
		get
		{
			CheckDestroyed();
			if (!FXActorConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXActorBaseConfigComp:FXActorConfig");
				return default(FFXActorConfig);
			}
			return FFXActorConfig.FromNative(IntPtr.Add(base.Address, FXActorConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FXActorConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXActorBaseConfigComp:FXActorConfig");
			}
			else
			{
				FFXActorConfig.ToNative(IntPtr.Add(base.Address, FXActorConfig_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		FXActorConfig = new FFXActorConfig
		{
			LifeTime = -1f,
			DestroyedDebrisLifeTime = 10f,
			DebrisDissipationTime = 2f
		};
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_FXActorBaseData bUC_FXActorBaseData = RequireWritableData<b1.BUC_FXActorBaseData>();
		bUC_FXActorBaseData.LifeTime = FXActorConfig.LifeTime;
		bUC_FXActorBaseData.DelayDestroyTime = FXActorConfig.DelayDestroyTime;
		bUC_FXActorBaseData.FXActorType = FXActorConfig.FXActorType;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_FXActorBaseConfigComp");
		FXActorConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FXActorConfig");
		FXActorConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FXActorConfig", Classes.FStructProperty);
	}

	static BUS_FXActorBaseConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_FXActorBaseConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_FXActorBaseConfigComp));
	}
}
