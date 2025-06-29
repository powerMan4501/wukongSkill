using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGCopyPointsSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGCopyPointsSettings : UPCGSettings
{
	private static bool RotationInheritance_IsValid;

	private static FFieldAddress RotationInheritance_PropertyAddress;

	private static int RotationInheritance_Offset;

	private static bool ScaleInheritance_IsValid;

	private static FFieldAddress ScaleInheritance_PropertyAddress;

	private static int ScaleInheritance_Offset;

	private static bool ColorInheritance_IsValid;

	private static FFieldAddress ColorInheritance_PropertyAddress;

	private static int ColorInheritance_Offset;

	private static bool SeedInheritance_IsValid;

	private static FFieldAddress SeedInheritance_PropertyAddress;

	private static int SeedInheritance_Offset;

	private static bool AttributeInheritance_IsValid;

	private static FFieldAddress AttributeInheritance_PropertyAddress;

	private static int AttributeInheritance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCopyPointsSettings:RotationInheritance")]
	public EPCGCopyPointsInheritanceMode RotationInheritance
	{
		get
		{
			CheckDestroyed();
			if (!RotationInheritance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCopyPointsSettings:RotationInheritance");
				return EPCGCopyPointsInheritanceMode.Relative;
			}
			return EnumMarshaler<EPCGCopyPointsInheritanceMode>.FromNative(IntPtr.Add(base.Address, RotationInheritance_Offset), 0, RotationInheritance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotationInheritance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCopyPointsSettings:RotationInheritance");
			}
			else
			{
				EnumMarshaler<EPCGCopyPointsInheritanceMode>.ToNative(IntPtr.Add(base.Address, RotationInheritance_Offset), 0, RotationInheritance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCopyPointsSettings:ScaleInheritance")]
	public EPCGCopyPointsInheritanceMode ScaleInheritance
	{
		get
		{
			CheckDestroyed();
			if (!ScaleInheritance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCopyPointsSettings:ScaleInheritance");
				return EPCGCopyPointsInheritanceMode.Relative;
			}
			return EnumMarshaler<EPCGCopyPointsInheritanceMode>.FromNative(IntPtr.Add(base.Address, ScaleInheritance_Offset), 0, ScaleInheritance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScaleInheritance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCopyPointsSettings:ScaleInheritance");
			}
			else
			{
				EnumMarshaler<EPCGCopyPointsInheritanceMode>.ToNative(IntPtr.Add(base.Address, ScaleInheritance_Offset), 0, ScaleInheritance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCopyPointsSettings:ColorInheritance")]
	public EPCGCopyPointsInheritanceMode ColorInheritance
	{
		get
		{
			CheckDestroyed();
			if (!ColorInheritance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCopyPointsSettings:ColorInheritance");
				return EPCGCopyPointsInheritanceMode.Relative;
			}
			return EnumMarshaler<EPCGCopyPointsInheritanceMode>.FromNative(IntPtr.Add(base.Address, ColorInheritance_Offset), 0, ColorInheritance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ColorInheritance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCopyPointsSettings:ColorInheritance");
			}
			else
			{
				EnumMarshaler<EPCGCopyPointsInheritanceMode>.ToNative(IntPtr.Add(base.Address, ColorInheritance_Offset), 0, ColorInheritance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCopyPointsSettings:SeedInheritance")]
	public EPCGCopyPointsInheritanceMode SeedInheritance
	{
		get
		{
			CheckDestroyed();
			if (!SeedInheritance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCopyPointsSettings:SeedInheritance");
				return EPCGCopyPointsInheritanceMode.Relative;
			}
			return EnumMarshaler<EPCGCopyPointsInheritanceMode>.FromNative(IntPtr.Add(base.Address, SeedInheritance_Offset), 0, SeedInheritance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SeedInheritance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCopyPointsSettings:SeedInheritance");
			}
			else
			{
				EnumMarshaler<EPCGCopyPointsInheritanceMode>.ToNative(IntPtr.Add(base.Address, SeedInheritance_Offset), 0, SeedInheritance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCopyPointsSettings:AttributeInheritance")]
	public EPCGCopyPointsMetadataInheritanceMode AttributeInheritance
	{
		get
		{
			CheckDestroyed();
			if (!AttributeInheritance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCopyPointsSettings:AttributeInheritance");
				return EPCGCopyPointsMetadataInheritanceMode.SourceFirst;
			}
			return EnumMarshaler<EPCGCopyPointsMetadataInheritanceMode>.FromNative(IntPtr.Add(base.Address, AttributeInheritance_Offset), 0, AttributeInheritance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttributeInheritance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCopyPointsSettings:AttributeInheritance");
			}
			else
			{
				EnumMarshaler<EPCGCopyPointsMetadataInheritanceMode>.ToNative(IntPtr.Add(base.Address, AttributeInheritance_Offset), 0, AttributeInheritance_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGCopyPointsSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGCopyPointsSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGCopyPointsSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGCopyPointsSettings");
		NativeReflectionCached.GetPropertyRef(ref RotationInheritance_PropertyAddress, unrealStruct, "RotationInheritance");
		RotationInheritance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RotationInheritance");
		RotationInheritance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RotationInheritance", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleInheritance_PropertyAddress, unrealStruct, "ScaleInheritance");
		ScaleInheritance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ScaleInheritance");
		ScaleInheritance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ScaleInheritance", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ColorInheritance_PropertyAddress, unrealStruct, "ColorInheritance");
		ColorInheritance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ColorInheritance");
		ColorInheritance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ColorInheritance", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SeedInheritance_PropertyAddress, unrealStruct, "SeedInheritance");
		SeedInheritance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SeedInheritance");
		SeedInheritance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SeedInheritance", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttributeInheritance_PropertyAddress, unrealStruct, "AttributeInheritance");
		AttributeInheritance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttributeInheritance");
		AttributeInheritance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttributeInheritance", Classes.FEnumProperty);
	}
}
