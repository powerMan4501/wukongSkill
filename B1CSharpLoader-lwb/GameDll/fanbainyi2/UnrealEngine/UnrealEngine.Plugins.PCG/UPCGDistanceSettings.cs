using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGDistanceSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGDistanceSettings : UPCGSettings
{
	private static bool AttributeName_IsValid;

	private static int AttributeName_Offset;

	private static bool OutputDistanceVector_IsValid;

	private static FFieldAddress OutputDistanceVector_PropertyAddress;

	private static int OutputDistanceVector_Offset;

	private static bool SetDensity_IsValid;

	private static FFieldAddress SetDensity_PropertyAddress;

	private static int SetDensity_Offset;

	private static bool MaximumDistance_IsValid;

	private static int MaximumDistance_Offset;

	private static bool SourceShape_IsValid;

	private static FFieldAddress SourceShape_PropertyAddress;

	private static int SourceShape_Offset;

	private static bool TargetShape_IsValid;

	private static FFieldAddress TargetShape_PropertyAddress;

	private static int TargetShape_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDistanceSettings:AttributeName")]
	public FName AttributeName
	{
		get
		{
			CheckDestroyed();
			if (!AttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:AttributeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttributeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:AttributeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttributeName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDistanceSettings:bOutputDistanceVector")]
	public bool OutputDistanceVector
	{
		get
		{
			CheckDestroyed();
			if (!OutputDistanceVector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:bOutputDistanceVector");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OutputDistanceVector_Offset), 0, OutputDistanceVector_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OutputDistanceVector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:bOutputDistanceVector");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OutputDistanceVector_Offset), 0, OutputDistanceVector_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDistanceSettings:bSetDensity")]
	public bool SetDensity
	{
		get
		{
			CheckDestroyed();
			if (!SetDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:bSetDensity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SetDensity_Offset), 0, SetDensity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SetDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:bSetDensity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SetDensity_Offset), 0, SetDensity_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDistanceSettings:MaximumDistance")]
	public double MaximumDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaximumDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:MaximumDistance");
				return 0.0;
			}
			return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(base.Address, MaximumDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaximumDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:MaximumDistance");
			}
			else
			{
				BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(base.Address, MaximumDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDistanceSettings:SourceShape")]
	public EPCGDistanceShape SourceShape
	{
		get
		{
			CheckDestroyed();
			if (!SourceShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:SourceShape");
				return EPCGDistanceShape.SphereBounds;
			}
			return EnumMarshaler<EPCGDistanceShape>.FromNative(IntPtr.Add(base.Address, SourceShape_Offset), 0, SourceShape_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SourceShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:SourceShape");
			}
			else
			{
				EnumMarshaler<EPCGDistanceShape>.ToNative(IntPtr.Add(base.Address, SourceShape_Offset), 0, SourceShape_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDistanceSettings:TargetShape")]
	public EPCGDistanceShape TargetShape
	{
		get
		{
			CheckDestroyed();
			if (!TargetShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:TargetShape");
				return EPCGDistanceShape.SphereBounds;
			}
			return EnumMarshaler<EPCGDistanceShape>.FromNative(IntPtr.Add(base.Address, TargetShape_Offset), 0, TargetShape_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TargetShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDistanceSettings:TargetShape");
			}
			else
			{
				EnumMarshaler<EPCGDistanceShape>.ToNative(IntPtr.Add(base.Address, TargetShape_Offset), 0, TargetShape_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGDistanceSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGDistanceSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGDistanceSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGDistanceSettings");
		AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttributeName");
		AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OutputDistanceVector_PropertyAddress, unrealStruct, "bOutputDistanceVector");
		OutputDistanceVector_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOutputDistanceVector");
		OutputDistanceVector_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOutputDistanceVector", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDensity_PropertyAddress, unrealStruct, "bSetDensity");
		SetDensity_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bSetDensity");
		SetDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bSetDensity", Classes.FBoolProperty);
		MaximumDistance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaximumDistance");
		MaximumDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaximumDistance", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref SourceShape_PropertyAddress, unrealStruct, "SourceShape");
		SourceShape_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SourceShape");
		SourceShape_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SourceShape", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref TargetShape_PropertyAddress, unrealStruct, "TargetShape");
		TargetShape_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetShape");
		TargetShape_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetShape", Classes.FEnumProperty);
	}
}
