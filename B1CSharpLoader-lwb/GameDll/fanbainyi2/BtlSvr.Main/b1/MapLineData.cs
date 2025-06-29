using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MapLineData")]
public struct MapLineData
{
	public MapPointData PointOne;

	public MapPointData PointTwo;

	public List<int> Indexes;

	private static int MapLineData_StructSize;

	private static int MapLineData_IsValid;

	public MapLineData Copy()
	{
		return this;
	}

	public static MapLineData FromNative(IntPtr nativeBuffer)
	{
		return new MapLineData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MapLineData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MapLineData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MapLineData(IntPtr.Add(nativeBuffer, arrayIndex * MapLineData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MapLineData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MapLineData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MapLineData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapLineData");
		}
	}

	public MapLineData(IntPtr nativeStruct)
	{
		if (MapLineData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapLineData");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MapLineData");
		MapLineData_StructSize = NativeReflection.GetStructSize(intPtr);
		MapLineData_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MapLineData", (byte)MapLineData_IsValid != 0);
	}

	static MapLineData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MapLineData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MapLineData));
	}
}
