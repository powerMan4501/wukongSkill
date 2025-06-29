using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGDebugSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGDebugSettings : UPCGSettings
{
	private static bool TargetActor_IsValid;

	private static int TargetActor_Offset;

	[UProperty(Flags = (PropFlags)7881299347898372uL)]
	[UMetaPath("/Script/PCG.PCGDebugSettings:TargetActor")]
	public TSoftObject<AActor> TargetActor
	{
		get
		{
			CheckDestroyed();
			if (!TargetActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDebugSettings:TargetActor");
				return default(TSoftObject<AActor>);
			}
			return TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, TargetActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDebugSettings:TargetActor");
			}
			else
			{
				TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, TargetActor_Offset), value);
			}
		}
	}

	static UPCGDebugSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGDebugSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGDebugSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGDebugSettings");
		TargetActor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetActor");
		TargetActor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetActor", Classes.FSoftObjectProperty);
	}
}
