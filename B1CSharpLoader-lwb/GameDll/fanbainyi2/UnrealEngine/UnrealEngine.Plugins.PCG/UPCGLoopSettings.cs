using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGLoopSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGLoopSettings : UPCGSubgraphSettings
{
	private static bool LoopPins_IsValid;

	private static int LoopPins_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/PCG.PCGLoopSettings:LoopPins")]
	public string LoopPins
	{
		get
		{
			CheckDestroyed();
			if (!LoopPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLoopSettings:LoopPins");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, LoopPins_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoopPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLoopSettings:LoopPins");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, LoopPins_Offset), value);
			}
		}
	}

	static UPCGLoopSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGLoopSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGLoopSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGLoopSettings");
		LoopPins_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LoopPins");
		LoopPins_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LoopPins", Classes.FStrProperty);
	}
}
