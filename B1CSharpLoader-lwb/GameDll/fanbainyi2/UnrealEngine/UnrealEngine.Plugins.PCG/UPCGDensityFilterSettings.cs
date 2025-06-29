using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGDensityFilterSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGDensityFilterSettings : UPCGSettings
{
	private static bool LowerBound_IsValid;

	private static int LowerBound_Offset;

	private static bool UpperBound_IsValid;

	private static int UpperBound_Offset;

	private static bool InvertFilter_IsValid;

	private static FFieldAddress InvertFilter_PropertyAddress;

	private static int InvertFilter_Offset;

	private static bool KeepZeroDensityPoints_IsValid;

	private static FFieldAddress KeepZeroDensityPoints_PropertyAddress;

	private static int KeepZeroDensityPoints_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDensityFilterSettings:LowerBound")]
	public float LowerBound
	{
		get
		{
			CheckDestroyed();
			if (!LowerBound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityFilterSettings:LowerBound");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LowerBound_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LowerBound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityFilterSettings:LowerBound");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LowerBound_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDensityFilterSettings:UpperBound")]
	public float UpperBound
	{
		get
		{
			CheckDestroyed();
			if (!UpperBound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityFilterSettings:UpperBound");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UpperBound_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpperBound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityFilterSettings:UpperBound");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UpperBound_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDensityFilterSettings:bInvertFilter")]
	public bool InvertFilter
	{
		get
		{
			CheckDestroyed();
			if (!InvertFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityFilterSettings:bInvertFilter");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InvertFilter_Offset), 0, InvertFilter_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InvertFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityFilterSettings:bInvertFilter");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InvertFilter_Offset), 0, InvertFilter_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594021381uL)]
	[UMetaPath("/Script/PCG.PCGDensityFilterSettings:bKeepZeroDensityPoints")]
	public bool KeepZeroDensityPoints
	{
		get
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityFilterSettings:bKeepZeroDensityPoints");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityFilterSettings:bKeepZeroDensityPoints");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGDensityFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGDensityFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGDensityFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGDensityFilterSettings");
		LowerBound_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LowerBound");
		LowerBound_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LowerBound", Classes.FFloatProperty);
		UpperBound_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UpperBound");
		UpperBound_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UpperBound", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InvertFilter_PropertyAddress, unrealStruct, "bInvertFilter");
		InvertFilter_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bInvertFilter");
		InvertFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bInvertFilter", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref KeepZeroDensityPoints_PropertyAddress, unrealStruct, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bKeepZeroDensityPoints", Classes.FBoolProperty);
	}
}
