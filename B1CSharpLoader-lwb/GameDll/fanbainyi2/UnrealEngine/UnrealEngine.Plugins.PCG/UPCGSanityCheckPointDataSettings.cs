using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSanityCheckPointDataSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSanityCheckPointDataSettings : UPCGSettings
{
	private static bool MinPointCount_IsValid;

	private static int MinPointCount_Offset;

	private static bool MaxPointCount_IsValid;

	private static int MaxPointCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSanityCheckPointDataSettings:MinPointCount")]
	public int MinPointCount
	{
		get
		{
			CheckDestroyed();
			if (!MinPointCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSanityCheckPointDataSettings:MinPointCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinPointCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinPointCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSanityCheckPointDataSettings:MinPointCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinPointCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSanityCheckPointDataSettings:MaxPointCount")]
	public int MaxPointCount
	{
		get
		{
			CheckDestroyed();
			if (!MaxPointCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSanityCheckPointDataSettings:MaxPointCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxPointCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxPointCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSanityCheckPointDataSettings:MaxPointCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxPointCount_Offset), value);
			}
		}
	}

	static UPCGSanityCheckPointDataSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSanityCheckPointDataSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSanityCheckPointDataSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSanityCheckPointDataSettings");
		MinPointCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MinPointCount");
		MinPointCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MinPointCount", Classes.FIntProperty);
		MaxPointCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxPointCount");
		MaxPointCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxPointCount", Classes.FIntProperty);
	}
}
