using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGFilterByTagSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGFilterByTagSettings : UPCGSettings
{
	private static bool Operation_IsValid;

	private static FFieldAddress Operation_PropertyAddress;

	private static int Operation_Offset;

	private static bool SelectedTags_IsValid;

	private static int SelectedTags_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGFilterByTagSettings:Operation")]
	public EPCGFilterByTagOperation Operation
	{
		get
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGFilterByTagSettings:Operation");
				return EPCGFilterByTagOperation.KeepTagged;
			}
			return EnumMarshaler<EPCGFilterByTagOperation>.FromNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGFilterByTagSettings:Operation");
			}
			else
			{
				EnumMarshaler<EPCGFilterByTagOperation>.ToNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/PCG.PCGFilterByTagSettings:SelectedTags")]
	public string SelectedTags
	{
		get
		{
			CheckDestroyed();
			if (!SelectedTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGFilterByTagSettings:SelectedTags");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SelectedTags_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelectedTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGFilterByTagSettings:SelectedTags");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SelectedTags_Offset), value);
			}
		}
	}

	static UPCGFilterByTagSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGFilterByTagSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGFilterByTagSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGFilterByTagSettings");
		NativeReflectionCached.GetPropertyRef(ref Operation_PropertyAddress, unrealStruct, "Operation");
		Operation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Operation");
		Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Operation", Classes.FEnumProperty);
		SelectedTags_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SelectedTags");
		SelectedTags_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SelectedTags", Classes.FStrProperty);
	}
}
