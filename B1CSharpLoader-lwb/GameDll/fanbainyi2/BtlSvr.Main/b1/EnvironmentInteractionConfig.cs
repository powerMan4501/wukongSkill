using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.EnvironmentInteractionConfig")]
public struct EnvironmentInteractionConfig : IComparable<EnvironmentInteractionConfig>
{
	[UProperty]
	[EditAnywhere]
	[DisplayName("环境覆盖表面类型")]
	[USharpPath("/Script/b1-Managed.EnvironmentInteractionConfig:EnvironmentSurfaceType")]
	public ESceneItemSurfaceType EnvironmentSurfaceType;

	[UProperty]
	[EditAnywhere]
	[DisplayName("覆盖表面类型的方式")]
	[USharpPath("/Script/b1-Managed.EnvironmentInteractionConfig:SurfaceTypeOverrideMethod")]
	public ESurfaceTypeOverrideMethod SurfaceTypeOverrideMethod;

	[DisplayName("生成表面类型的映射列表")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.EnvironmentInteractionConfig:SurfaceTypeGenerationMapping")]
	public Dictionary<ESceneItemSurfaceType, ESceneItemSurfaceType> SurfaceTypeGenerationMapping;

	[UProperty]
	[EditAnywhere]
	[DisplayName("EnvironmentInteractionVolume优先级")]
	[USharpPath("/Script/b1-Managed.EnvironmentInteractionConfig:Priority")]
	public int Priority;

	private static int EnvironmentInteractionConfig_StructSize;

	private static int EnvironmentInteractionConfig_IsValid;

	private static bool EnvironmentSurfaceType_IsValid;

	private static int EnvironmentSurfaceType_Offset;

	private static FFieldAddress EnvironmentSurfaceType_PropertyAddress;

	private static bool SurfaceTypeOverrideMethod_IsValid;

	private static int SurfaceTypeOverrideMethod_Offset;

	private static FFieldAddress SurfaceTypeOverrideMethod_PropertyAddress;

	private static bool SurfaceTypeGenerationMapping_IsValid;

	private static int SurfaceTypeGenerationMapping_Offset;

	private static FFieldAddress SurfaceTypeGenerationMapping_PropertyAddress;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	public int CompareTo(EnvironmentInteractionConfig Other)
	{
		if (Priority < Other.Priority)
		{
			return 1;
		}
		return -1;
	}

	public EnvironmentInteractionConfig Copy()
	{
		EnvironmentInteractionConfig result = this;
		if (SurfaceTypeGenerationMapping != null)
		{
			result.SurfaceTypeGenerationMapping = new Dictionary<ESceneItemSurfaceType, ESceneItemSurfaceType>(SurfaceTypeGenerationMapping);
		}
		return result;
	}

	public static EnvironmentInteractionConfig FromNative(IntPtr nativeBuffer)
	{
		return new EnvironmentInteractionConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, EnvironmentInteractionConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static EnvironmentInteractionConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new EnvironmentInteractionConfig(IntPtr.Add(nativeBuffer, arrayIndex * EnvironmentInteractionConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, EnvironmentInteractionConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EnvironmentInteractionConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EnvironmentInteractionConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvironmentInteractionConfig");
			return;
		}
		EnumMarshaler<ESceneItemSurfaceType>.ToNative(IntPtr.Add(nativeStruct, EnvironmentSurfaceType_Offset), 0, EnvironmentSurfaceType_PropertyAddress.Address, EnvironmentSurfaceType);
		EnumMarshaler<ESurfaceTypeOverrideMethod>.ToNative(IntPtr.Add(nativeStruct, SurfaceTypeOverrideMethod_Offset), 0, SurfaceTypeOverrideMethod_PropertyAddress.Address, SurfaceTypeOverrideMethod);
		new TMapCopyMarshaler<ESceneItemSurfaceType, ESceneItemSurfaceType>(1, SurfaceTypeGenerationMapping_PropertyAddress, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.FromNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.ToNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.FromNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SurfaceTypeGenerationMapping_Offset), SurfaceTypeGenerationMapping);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Priority_Offset), Priority);
	}

	public EnvironmentInteractionConfig(IntPtr nativeStruct)
	{
		if (EnvironmentInteractionConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvironmentInteractionConfig");
			EnvironmentSurfaceType = ESceneItemSurfaceType.DefaultSurface;
			SurfaceTypeOverrideMethod = ESurfaceTypeOverrideMethod.None;
			SurfaceTypeGenerationMapping = null;
			Priority = 0;
		}
		else
		{
			EnvironmentSurfaceType = EnumMarshaler<ESceneItemSurfaceType>.FromNative(IntPtr.Add(nativeStruct, EnvironmentSurfaceType_Offset), 0, EnvironmentSurfaceType_PropertyAddress.Address);
			SurfaceTypeOverrideMethod = EnumMarshaler<ESurfaceTypeOverrideMethod>.FromNative(IntPtr.Add(nativeStruct, SurfaceTypeOverrideMethod_Offset), 0, SurfaceTypeOverrideMethod_PropertyAddress.Address);
			SurfaceTypeGenerationMapping = new TMapCopyMarshaler<ESceneItemSurfaceType, ESceneItemSurfaceType>(1, SurfaceTypeGenerationMapping_PropertyAddress, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.FromNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.ToNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.FromNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SurfaceTypeGenerationMapping_Offset));
			Priority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Priority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EnvironmentInteractionConfig");
		EnvironmentInteractionConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref EnvironmentSurfaceType_PropertyAddress, intPtr, "EnvironmentSurfaceType");
		EnvironmentSurfaceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnvironmentSurfaceType");
		EnvironmentSurfaceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnvironmentSurfaceType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SurfaceTypeOverrideMethod_PropertyAddress, intPtr, "SurfaceTypeOverrideMethod");
		SurfaceTypeOverrideMethod_Offset = NativeReflection.GetPropertyOffset(intPtr, "SurfaceTypeOverrideMethod");
		SurfaceTypeOverrideMethod_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SurfaceTypeOverrideMethod", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SurfaceTypeGenerationMapping_PropertyAddress, intPtr, "SurfaceTypeGenerationMapping");
		SurfaceTypeGenerationMapping_Offset = NativeReflection.GetPropertyOffset(intPtr, "SurfaceTypeGenerationMapping");
		SurfaceTypeGenerationMapping_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SurfaceTypeGenerationMapping", Classes.FMapProperty);
		Priority_Offset = NativeReflection.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Priority", Classes.FIntProperty);
		EnvironmentInteractionConfig_IsValid = ((intPtr != IntPtr.Zero && EnvironmentSurfaceType_IsValid && SurfaceTypeOverrideMethod_IsValid && SurfaceTypeGenerationMapping_IsValid && Priority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EnvironmentInteractionConfig", (byte)EnvironmentInteractionConfig_IsValid != 0);
	}

	static EnvironmentInteractionConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(EnvironmentInteractionConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(EnvironmentInteractionConfig));
	}
}
