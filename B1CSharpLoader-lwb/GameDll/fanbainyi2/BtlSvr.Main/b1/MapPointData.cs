using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MapPointData")]
public struct MapPointData
{
	public int X;

	public int Y;

	public int PointWidth;

	public int PointHeight;

	private static int MapPointData_StructSize;

	private static int MapPointData_IsValid;

	public MapPointData Copy()
	{
		return this;
	}

	public static MapPointData FromNative(IntPtr nativeBuffer)
	{
		return new MapPointData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MapPointData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MapPointData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MapPointData(IntPtr.Add(nativeBuffer, arrayIndex * MapPointData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MapPointData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MapPointData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MapPointData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapPointData");
		}
	}

	public MapPointData(IntPtr nativeStruct)
	{
		if (MapPointData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapPointData");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MapPointData");
		MapPointData_StructSize = NativeReflection.GetStructSize(intPtr);
		MapPointData_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MapPointData", (byte)MapPointData_IsValid != 0);
	}

	static MapPointData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MapPointData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MapPointData));
	}
}
