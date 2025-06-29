using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TortoiseLevelStreamingConfigComp")]
internal class BUS_TortoiseLevelStreamingConfigComp : UActorEditCompBase
{
	private static bool BeginConfig_IsValid;

	private static int BeginConfig_Offset;

	private static bool LoopConfig_IsValid;

	private static int LoopConfig_Offset;

	private static bool EndConfig_IsValid;

	private static int EndConfig_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_TortoiseLevelStreamingConfigComp:BeginConfig")]
	public BGWDataAsset_TortoiseLevelStreamingConfig BeginConfig
	{
		get
		{
			CheckDestroyed();
			if (!BeginConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseLevelStreamingConfigComp:BeginConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_TortoiseLevelStreamingConfig>.FromNative(IntPtr.Add(base.Address, BeginConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseLevelStreamingConfigComp:BeginConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_TortoiseLevelStreamingConfig>.ToNative(IntPtr.Add(base.Address, BeginConfig_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TortoiseLevelStreamingConfigComp:LoopConfig")]
	public BGWDataAsset_TortoiseLevelStreamingConfig LoopConfig
	{
		get
		{
			CheckDestroyed();
			if (!LoopConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseLevelStreamingConfigComp:LoopConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_TortoiseLevelStreamingConfig>.FromNative(IntPtr.Add(base.Address, LoopConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoopConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseLevelStreamingConfigComp:LoopConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_TortoiseLevelStreamingConfig>.ToNative(IntPtr.Add(base.Address, LoopConfig_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TortoiseLevelStreamingConfigComp:EndConfig")]
	public BGWDataAsset_TortoiseLevelStreamingConfig EndConfig
	{
		get
		{
			CheckDestroyed();
			if (!EndConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseLevelStreamingConfigComp:EndConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_TortoiseLevelStreamingConfig>.FromNative(IntPtr.Add(base.Address, EndConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseLevelStreamingConfigComp:EndConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_TortoiseLevelStreamingConfig>.ToNative(IntPtr.Add(base.Address, EndConfig_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void OnDataConvert(AActor Owner)
	{
		string actorLabel = Owner.GetActorLabel();
		b1.BUC_TortoiseLevelStreamingMgrData bUC_TortoiseLevelStreamingMgrData = RequireWritableData<b1.BUC_TortoiseLevelStreamingMgrData>();
		bUC_TortoiseLevelStreamingMgrData.AddLevelStreamingConfig(FTortoiseLevelState.begin, BeginConfig.ToConfigInfo(EGSLevelStateInfoLayerType.CPG, actorLabel));
		bUC_TortoiseLevelStreamingMgrData.AddLevelStreamingConfig(FTortoiseLevelState.loop, LoopConfig.ToConfigInfo(EGSLevelStateInfoLayerType.CPG, actorLabel));
		bUC_TortoiseLevelStreamingMgrData.AddLevelStreamingConfig(FTortoiseLevelState.end, EndConfig.ToConfigInfo(EGSLevelStateInfoLayerType.CPG, actorLabel));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_TortoiseLevelStreamingConfigComp");
		BeginConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginConfig");
		BeginConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginConfig", Classes.FObjectProperty);
		LoopConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LoopConfig");
		LoopConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LoopConfig", Classes.FObjectProperty);
		EndConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EndConfig");
		EndConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EndConfig", Classes.FObjectProperty);
	}

	static BUS_TortoiseLevelStreamingConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_TortoiseLevelStreamingConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_TortoiseLevelStreamingConfigComp));
	}
}
