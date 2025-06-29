using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CVarVolume", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACVarVolume : AVolume
{
	private static bool CVarFloats_IsValid;

	private static FFieldAddress CVarFloats_PropertyAddress;

	private static int CVarFloats_Offset;

	private TMapReadWriteMarshaler<string, float> CVarFloats_MarshalerCached;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool EnableOnlyInRaytracing_IsValid;

	private static FFieldAddress EnableOnlyInRaytracing_PropertyAddress;

	private static int EnableOnlyInRaytracing_Offset;

	private static bool EnableOnlyBelowQualityLevel_IsValid;

	private static int EnableOnlyBelowQualityLevel_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/CustomLightSystem.CVarVolume:CVarFloats")]
	public TMapReadWrite<string, float> CVarFloats
	{
		get
		{
			CheckDestroyed();
			if (!CVarFloats_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CVarVolume:CVarFloats");
				return null;
			}
			if (CVarFloats_MarshalerCached == null)
			{
				CVarFloats_MarshalerCached = new TMapReadWriteMarshaler<string, float>(1, CVarFloats_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return CVarFloats_MarshalerCached.FromNative(IntPtr.Add(base.Address, CVarFloats_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CVarVolume:Priority")]
	public int Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CVarVolume:Priority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CVarVolume:Priority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CVarVolume:bEnableOnlyInRaytracing")]
	public bool EnableOnlyInRaytracing
	{
		get
		{
			CheckDestroyed();
			if (!EnableOnlyInRaytracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CVarVolume:bEnableOnlyInRaytracing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableOnlyInRaytracing_Offset), 0, EnableOnlyInRaytracing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableOnlyInRaytracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CVarVolume:bEnableOnlyInRaytracing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableOnlyInRaytracing_Offset), 0, EnableOnlyInRaytracing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CVarVolume:EnableOnlyBelowQualityLevel")]
	public int EnableOnlyBelowQualityLevel
	{
		get
		{
			CheckDestroyed();
			if (!EnableOnlyBelowQualityLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CVarVolume:EnableOnlyBelowQualityLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EnableOnlyBelowQualityLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnableOnlyBelowQualityLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CVarVolume:EnableOnlyBelowQualityLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EnableOnlyBelowQualityLevel_Offset), value);
			}
		}
	}

	static ACVarVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACVarVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACVarVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/CustomLightSystem.CVarVolume");
		NativeReflectionCached.GetPropertyRef(ref CVarFloats_PropertyAddress, unrealStruct, "CVarFloats");
		CVarFloats_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CVarFloats");
		CVarFloats_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CVarFloats", Classes.FMapProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Priority", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableOnlyInRaytracing_PropertyAddress, unrealStruct, "bEnableOnlyInRaytracing");
		EnableOnlyInRaytracing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableOnlyInRaytracing");
		EnableOnlyInRaytracing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableOnlyInRaytracing", Classes.FBoolProperty);
		EnableOnlyBelowQualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EnableOnlyBelowQualityLevel");
		EnableOnlyBelowQualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EnableOnlyBelowQualityLevel", Classes.FIntProperty);
	}
}
