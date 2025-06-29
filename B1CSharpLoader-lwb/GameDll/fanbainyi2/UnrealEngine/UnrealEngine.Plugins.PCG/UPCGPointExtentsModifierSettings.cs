using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPointExtentsModifierSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGPointExtentsModifierSettings : UPCGSettings
{
	private static bool Extents_IsValid;

	private static int Extents_Offset;

	private static bool Mode_IsValid;

	private static FFieldAddress Mode_PropertyAddress;

	private static int Mode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPointExtentsModifierSettings:Extents")]
	public FVector Extents
	{
		get
		{
			CheckDestroyed();
			if (!Extents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointExtentsModifierSettings:Extents");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Extents_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Extents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointExtentsModifierSettings:Extents");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Extents_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPointExtentsModifierSettings:Mode")]
	public EPCGPointExtentsModifierMode Mode
	{
		get
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointExtentsModifierSettings:Mode");
				return EPCGPointExtentsModifierMode.Set;
			}
			return EnumMarshaler<EPCGPointExtentsModifierMode>.FromNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointExtentsModifierSettings:Mode");
			}
			else
			{
				EnumMarshaler<EPCGPointExtentsModifierMode>.ToNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGPointExtentsModifierSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGPointExtentsModifierSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGPointExtentsModifierSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGPointExtentsModifierSettings");
		Extents_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Extents");
		Extents_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Extents", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Mode_PropertyAddress, unrealStruct, "Mode");
		Mode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Mode");
		Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Mode", Classes.FEnumProperty);
	}
}
