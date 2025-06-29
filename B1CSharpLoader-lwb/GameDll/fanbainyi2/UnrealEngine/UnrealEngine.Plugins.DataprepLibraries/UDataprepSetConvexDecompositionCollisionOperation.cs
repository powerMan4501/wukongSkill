using System;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSetConvexDecompositionCollisionOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSetConvexDecompositionCollisionOperation : UDataprepOperation
{
	private static bool HullCount_IsValid;

	private static int HullCount_Offset;

	private static bool MaxHullVerts_IsValid;

	private static int MaxHullVerts_Offset;

	private static bool HullPrecision_IsValid;

	private static int HullPrecision_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetConvexDecompositionCollisionOperation:HullCount")]
	public int HullCount
	{
		get
		{
			CheckDestroyed();
			if (!HullCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetConvexDecompositionCollisionOperation:HullCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HullCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HullCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetConvexDecompositionCollisionOperation:HullCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HullCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetConvexDecompositionCollisionOperation:MaxHullVerts")]
	public int MaxHullVerts
	{
		get
		{
			CheckDestroyed();
			if (!MaxHullVerts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetConvexDecompositionCollisionOperation:MaxHullVerts");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxHullVerts_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxHullVerts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetConvexDecompositionCollisionOperation:MaxHullVerts");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxHullVerts_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetConvexDecompositionCollisionOperation:HullPrecision")]
	public int HullPrecision
	{
		get
		{
			CheckDestroyed();
			if (!HullPrecision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetConvexDecompositionCollisionOperation:HullPrecision");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HullPrecision_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HullPrecision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetConvexDecompositionCollisionOperation:HullPrecision");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HullPrecision_Offset), value);
			}
		}
	}

	static UDataprepSetConvexDecompositionCollisionOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSetConvexDecompositionCollisionOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSetConvexDecompositionCollisionOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSetConvexDecompositionCollisionOperation");
		HullCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HullCount");
		HullCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HullCount", Classes.FIntProperty);
		MaxHullVerts_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxHullVerts");
		MaxHullVerts_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxHullVerts", Classes.FIntProperty);
		HullPrecision_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HullPrecision");
		HullPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HullPrecision", Classes.FIntProperty);
	}
}
