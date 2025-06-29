using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ChangeMaterialByUnitAttrConfig")]
public struct FChangeMaterialByUnitAttrConfig
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ChangeMaterialByUnitAttrConfig:UnitAttrType")]
	public EChangeMatUnitAttrType UnitAttrType;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ChangeMaterialByUnitAttrConfig:MaterialParameterConfig")]
	public List<FMaterialParameterConfig> MaterialParameterConfig;

	private static int ChangeMaterialByUnitAttrConfig_StructSize;

	private static int ChangeMaterialByUnitAttrConfig_IsValid;

	private static bool UnitAttrType_IsValid;

	private static int UnitAttrType_Offset;

	private static FFieldAddress UnitAttrType_PropertyAddress;

	private static bool MaterialParameterConfig_IsValid;

	private static int MaterialParameterConfig_Offset;

	private static FFieldAddress MaterialParameterConfig_PropertyAddress;

	public FChangeMaterialByUnitAttrConfig Copy()
	{
		FChangeMaterialByUnitAttrConfig result = this;
		if (MaterialParameterConfig != null)
		{
			result.MaterialParameterConfig = new List<FMaterialParameterConfig>(MaterialParameterConfig);
		}
		return result;
	}

	public static FChangeMaterialByUnitAttrConfig FromNative(IntPtr nativeBuffer)
	{
		return new FChangeMaterialByUnitAttrConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChangeMaterialByUnitAttrConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChangeMaterialByUnitAttrConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChangeMaterialByUnitAttrConfig(IntPtr.Add(nativeBuffer, arrayIndex * ChangeMaterialByUnitAttrConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChangeMaterialByUnitAttrConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ChangeMaterialByUnitAttrConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ChangeMaterialByUnitAttrConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ChangeMaterialByUnitAttrConfig");
			return;
		}
		EnumMarshaler<EChangeMatUnitAttrType>.ToNative(IntPtr.Add(nativeStruct, UnitAttrType_Offset), 0, UnitAttrType_PropertyAddress.Address, UnitAttrType);
		new TArrayCopyMarshaler<FMaterialParameterConfig>(1, MaterialParameterConfig_PropertyAddress, CachedMarshalingDelegates<FMaterialParameterConfig, FMaterialParameterConfig>.FromNative, CachedMarshalingDelegates<FMaterialParameterConfig, FMaterialParameterConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, MaterialParameterConfig_Offset), MaterialParameterConfig);
	}

	public FChangeMaterialByUnitAttrConfig(IntPtr nativeStruct)
	{
		if (ChangeMaterialByUnitAttrConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ChangeMaterialByUnitAttrConfig");
			UnitAttrType = EChangeMatUnitAttrType.None;
			MaterialParameterConfig = null;
		}
		else
		{
			UnitAttrType = EnumMarshaler<EChangeMatUnitAttrType>.FromNative(IntPtr.Add(nativeStruct, UnitAttrType_Offset), 0, UnitAttrType_PropertyAddress.Address);
			MaterialParameterConfig = new TArrayCopyMarshaler<FMaterialParameterConfig>(1, MaterialParameterConfig_PropertyAddress, CachedMarshalingDelegates<FMaterialParameterConfig, FMaterialParameterConfig>.FromNative, CachedMarshalingDelegates<FMaterialParameterConfig, FMaterialParameterConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, MaterialParameterConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ChangeMaterialByUnitAttrConfig");
		ChangeMaterialByUnitAttrConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UnitAttrType_PropertyAddress, intPtr, "UnitAttrType");
		UnitAttrType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitAttrType");
		UnitAttrType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitAttrType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MaterialParameterConfig_PropertyAddress, intPtr, "MaterialParameterConfig");
		MaterialParameterConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaterialParameterConfig");
		MaterialParameterConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaterialParameterConfig", Classes.FArrayProperty);
		ChangeMaterialByUnitAttrConfig_IsValid = ((intPtr != IntPtr.Zero && UnitAttrType_IsValid && MaterialParameterConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ChangeMaterialByUnitAttrConfig", (byte)ChangeMaterialByUnitAttrConfig_IsValid != 0);
	}

	static FChangeMaterialByUnitAttrConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FChangeMaterialByUnitAttrConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChangeMaterialByUnitAttrConfig));
	}
}
