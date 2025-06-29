using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGNumberOfPointsSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGNumberOfPointsSettings : UPCGSettings
{
	private static bool OutputAttributeName_IsValid;

	private static int OutputAttributeName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGNumberOfPointsSettings:OutputAttributeName")]
	public FName OutputAttributeName
	{
		get
		{
			CheckDestroyed();
			if (!OutputAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNumberOfPointsSettings:OutputAttributeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OutputAttributeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNumberOfPointsSettings:OutputAttributeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OutputAttributeName_Offset), value);
			}
		}
	}

	static UPCGNumberOfPointsSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGNumberOfPointsSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGNumberOfPointsSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGNumberOfPointsSettings");
		OutputAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputAttributeName");
		OutputAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputAttributeName", Classes.FNameProperty);
	}
}
