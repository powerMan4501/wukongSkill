using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGFilterByTypeSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGFilterByTypeSettings : UPCGSettings
{
	private static bool TargetType_IsValid;

	private static FFieldAddress TargetType_PropertyAddress;

	private static int TargetType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGFilterByTypeSettings:TargetType")]
	public EPCGDataType TargetType
	{
		get
		{
			CheckDestroyed();
			if (!TargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGFilterByTypeSettings:TargetType");
				return EPCGDataType.None;
			}
			return EnumMarshaler<EPCGDataType>.FromNative(IntPtr.Add(base.Address, TargetType_Offset), 0, TargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGFilterByTypeSettings:TargetType");
			}
			else
			{
				EnumMarshaler<EPCGDataType>.ToNative(IntPtr.Add(base.Address, TargetType_Offset), 0, TargetType_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGFilterByTypeSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGFilterByTypeSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGFilterByTypeSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGFilterByTypeSettings");
		NativeReflectionCached.GetPropertyRef(ref TargetType_PropertyAddress, unrealStruct, "TargetType");
		TargetType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetType");
		TargetType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetType", Classes.FEnumProperty);
	}
}
