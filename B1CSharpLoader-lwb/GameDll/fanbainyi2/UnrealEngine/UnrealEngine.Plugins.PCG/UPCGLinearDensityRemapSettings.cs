using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)827326624uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGLinearDensityRemapSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGLinearDensityRemapSettings : UPCGSettings
{
	private static bool RemapMin_IsValid;

	private static int RemapMin_Offset;

	private static bool RemapMax_IsValid;

	private static int RemapMax_Offset;

	private static bool MultiplyDensity_IsValid;

	private static FFieldAddress MultiplyDensity_PropertyAddress;

	private static int MultiplyDensity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGLinearDensityRemapSettings:RemapMin")]
	public float RemapMin
	{
		get
		{
			CheckDestroyed();
			if (!RemapMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLinearDensityRemapSettings:RemapMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RemapMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RemapMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLinearDensityRemapSettings:RemapMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RemapMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGLinearDensityRemapSettings:RemapMax")]
	public float RemapMax
	{
		get
		{
			CheckDestroyed();
			if (!RemapMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLinearDensityRemapSettings:RemapMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RemapMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RemapMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLinearDensityRemapSettings:RemapMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RemapMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGLinearDensityRemapSettings:bMultiplyDensity")]
	public bool MultiplyDensity
	{
		get
		{
			CheckDestroyed();
			if (!MultiplyDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLinearDensityRemapSettings:bMultiplyDensity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MultiplyDensity_Offset), 0, MultiplyDensity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MultiplyDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLinearDensityRemapSettings:bMultiplyDensity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MultiplyDensity_Offset), 0, MultiplyDensity_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGLinearDensityRemapSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGLinearDensityRemapSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGLinearDensityRemapSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGLinearDensityRemapSettings");
		RemapMin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RemapMin");
		RemapMin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RemapMin", Classes.FFloatProperty);
		RemapMax_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RemapMax");
		RemapMax_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RemapMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiplyDensity_PropertyAddress, unrealStruct, "bMultiplyDensity");
		MultiplyDensity_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bMultiplyDensity");
		MultiplyDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bMultiplyDensity", Classes.FBoolProperty);
	}
}
