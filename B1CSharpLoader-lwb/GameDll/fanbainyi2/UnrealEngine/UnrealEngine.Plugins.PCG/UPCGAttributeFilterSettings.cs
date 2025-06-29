using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGAttributeFilterSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGAttributeFilterSettings : UPCGSettings
{
	private static bool Operation_IsValid;

	private static FFieldAddress Operation_PropertyAddress;

	private static int Operation_Offset;

	private static bool SelectedAttributes_IsValid;

	private static int SelectedAttributes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeFilterSettings:Operation")]
	public EPCGAttributeFilterOperation Operation
	{
		get
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeFilterSettings:Operation");
				return EPCGAttributeFilterOperation.KeepSelectedAttributes;
			}
			return EnumMarshaler<EPCGAttributeFilterOperation>.FromNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeFilterSettings:Operation");
			}
			else
			{
				EnumMarshaler<EPCGAttributeFilterOperation>.ToNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/PCG.PCGAttributeFilterSettings:SelectedAttributes")]
	public string SelectedAttributes
	{
		get
		{
			CheckDestroyed();
			if (!SelectedAttributes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeFilterSettings:SelectedAttributes");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SelectedAttributes_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelectedAttributes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeFilterSettings:SelectedAttributes");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SelectedAttributes_Offset), value);
			}
		}
	}

	static UPCGAttributeFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGAttributeFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGAttributeFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGAttributeFilterSettings");
		NativeReflectionCached.GetPropertyRef(ref Operation_PropertyAddress, unrealStruct, "Operation");
		Operation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Operation");
		Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Operation", Classes.FEnumProperty);
		SelectedAttributes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SelectedAttributes");
		SelectedAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SelectedAttributes", Classes.FStrProperty);
	}
}
