using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGDensityRemapSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGDensityRemapSettings : UPCGSettings
{
	private static bool InRangeMin_IsValid;

	private static int InRangeMin_Offset;

	private static bool InRangeMax_IsValid;

	private static int InRangeMax_Offset;

	private static bool OutRangeMin_IsValid;

	private static int OutRangeMin_Offset;

	private static bool OutRangeMax_IsValid;

	private static int OutRangeMax_Offset;

	private static bool ExcludeValuesOutsideInputRange_IsValid;

	private static FFieldAddress ExcludeValuesOutsideInputRange_PropertyAddress;

	private static int ExcludeValuesOutsideInputRange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDensityRemapSettings:InRangeMin")]
	public float InRangeMin
	{
		get
		{
			CheckDestroyed();
			if (!InRangeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityRemapSettings:InRangeMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InRangeMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InRangeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityRemapSettings:InRangeMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InRangeMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDensityRemapSettings:InRangeMax")]
	public float InRangeMax
	{
		get
		{
			CheckDestroyed();
			if (!InRangeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityRemapSettings:InRangeMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InRangeMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InRangeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityRemapSettings:InRangeMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InRangeMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDensityRemapSettings:OutRangeMin")]
	public float OutRangeMin
	{
		get
		{
			CheckDestroyed();
			if (!OutRangeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityRemapSettings:OutRangeMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OutRangeMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutRangeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityRemapSettings:OutRangeMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OutRangeMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDensityRemapSettings:OutRangeMax")]
	public float OutRangeMax
	{
		get
		{
			CheckDestroyed();
			if (!OutRangeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityRemapSettings:OutRangeMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OutRangeMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutRangeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityRemapSettings:OutRangeMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OutRangeMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDensityRemapSettings:bExcludeValuesOutsideInputRange")]
	public bool ExcludeValuesOutsideInputRange
	{
		get
		{
			CheckDestroyed();
			if (!ExcludeValuesOutsideInputRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityRemapSettings:bExcludeValuesOutsideInputRange");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExcludeValuesOutsideInputRange_Offset), 0, ExcludeValuesOutsideInputRange_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExcludeValuesOutsideInputRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDensityRemapSettings:bExcludeValuesOutsideInputRange");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExcludeValuesOutsideInputRange_Offset), 0, ExcludeValuesOutsideInputRange_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGDensityRemapSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGDensityRemapSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGDensityRemapSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGDensityRemapSettings");
		InRangeMin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InRangeMin");
		InRangeMin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InRangeMin", Classes.FFloatProperty);
		InRangeMax_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InRangeMax");
		InRangeMax_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InRangeMax", Classes.FFloatProperty);
		OutRangeMin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutRangeMin");
		OutRangeMin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutRangeMin", Classes.FFloatProperty);
		OutRangeMax_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutRangeMax");
		OutRangeMax_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutRangeMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ExcludeValuesOutsideInputRange_PropertyAddress, unrealStruct, "bExcludeValuesOutsideInputRange");
		ExcludeValuesOutsideInputRange_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bExcludeValuesOutsideInputRange");
		ExcludeValuesOutsideInputRange_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bExcludeValuesOutsideInputRange", Classes.FBoolProperty);
	}
}
