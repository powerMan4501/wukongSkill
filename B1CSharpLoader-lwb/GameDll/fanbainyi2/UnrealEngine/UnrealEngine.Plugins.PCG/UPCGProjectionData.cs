using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGProjectionData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGProjectionData : UPCGSpatialDataWithPointCache
{
	private static bool Source_IsValid;

	private static int Source_Offset;

	private static bool Target_IsValid;

	private static int Target_Offset;

	private static bool ProjectionParams_IsValid;

	private static int ProjectionParams_Offset;

	[UProperty(Flags = (PropFlags)12393764861641237uL)]
	[UMetaPath("/Script/PCG.PCGProjectionData:Source")]
	protected UPCGSpatialData Source
	{
		get
		{
			CheckDestroyed();
			if (!Source_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGProjectionData:Source");
				return null;
			}
			return UObjectMarshaler<UPCGSpatialData>.FromNative(IntPtr.Add(base.Address, Source_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Source_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGProjectionData:Source");
			}
			else
			{
				UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(base.Address, Source_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861641237uL)]
	[UMetaPath("/Script/PCG.PCGProjectionData:Target")]
	protected UPCGSpatialData Target
	{
		get
		{
			CheckDestroyed();
			if (!Target_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGProjectionData:Target");
				return null;
			}
			return UObjectMarshaler<UPCGSpatialData>.FromNative(IntPtr.Add(base.Address, Target_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Target_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGProjectionData:Target");
			}
			else
			{
				UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(base.Address, Target_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9015995347894277uL)]
	[UMetaPath("/Script/PCG.PCGProjectionData:ProjectionParams")]
	protected FPCGProjectionParams ProjectionParams
	{
		get
		{
			CheckDestroyed();
			if (!ProjectionParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGProjectionData:ProjectionParams");
				return default(FPCGProjectionParams);
			}
			return FPCGProjectionParams.FromNative(IntPtr.Add(base.Address, ProjectionParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectionParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGProjectionData:ProjectionParams");
			}
			else
			{
				FPCGProjectionParams.ToNative(IntPtr.Add(base.Address, ProjectionParams_Offset), value);
			}
		}
	}

	static UPCGProjectionData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGProjectionData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGProjectionData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGProjectionData");
		Source_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Source");
		Source_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Source", Classes.FObjectProperty);
		Target_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Target");
		Target_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Target", Classes.FObjectProperty);
		ProjectionParams_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ProjectionParams");
		ProjectionParams_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ProjectionParams", Classes.FStructProperty);
	}
}
