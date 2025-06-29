using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGNormalToDensitySettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGNormalToDensitySettings : UPCGSettings
{
	private static bool Normal_IsValid;

	private static int Normal_Offset;

	private static bool Offset_IsValid;

	private static int Offset_Offset;

	private static bool Strength_IsValid;

	private static int Strength_Offset;

	private static bool DensityMode_IsValid;

	private static FFieldAddress DensityMode_PropertyAddress;

	private static int DensityMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGNormalToDensitySettings:Normal")]
	public FVector Normal
	{
		get
		{
			CheckDestroyed();
			if (!Normal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNormalToDensitySettings:Normal");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Normal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Normal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNormalToDensitySettings:Normal");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Normal_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGNormalToDensitySettings:Offset")]
	public double Offset
	{
		get
		{
			CheckDestroyed();
			if (!Offset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNormalToDensitySettings:Offset");
				return 0.0;
			}
			return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(base.Address, Offset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Offset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNormalToDensitySettings:Offset");
			}
			else
			{
				BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(base.Address, Offset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGNormalToDensitySettings:Strength")]
	public double Strength
	{
		get
		{
			CheckDestroyed();
			if (!Strength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNormalToDensitySettings:Strength");
				return 0.0;
			}
			return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(base.Address, Strength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Strength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNormalToDensitySettings:Strength");
			}
			else
			{
				BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(base.Address, Strength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGNormalToDensitySettings:DensityMode")]
	public EPCGNormalToDensityMode DensityMode
	{
		get
		{
			CheckDestroyed();
			if (!DensityMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNormalToDensitySettings:DensityMode");
				return EPCGNormalToDensityMode.Set;
			}
			return EnumMarshaler<EPCGNormalToDensityMode>.FromNative(IntPtr.Add(base.Address, DensityMode_Offset), 0, DensityMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DensityMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNormalToDensitySettings:DensityMode");
			}
			else
			{
				EnumMarshaler<EPCGNormalToDensityMode>.ToNative(IntPtr.Add(base.Address, DensityMode_Offset), 0, DensityMode_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGNormalToDensitySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGNormalToDensitySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGNormalToDensitySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGNormalToDensitySettings");
		Normal_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Normal");
		Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Normal", Classes.FStructProperty);
		Offset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Offset");
		Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Offset", Classes.FDoubleProperty);
		Strength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Strength");
		Strength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Strength", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref DensityMode_PropertyAddress, unrealStruct, "DensityMode");
		DensityMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DensityMode");
		DensityMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DensityMode", Classes.FEnumProperty);
	}
}
