using System;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UStruct]
[USharpPath("/Script/b1-Managed.STBarUninterruptData")]
public struct STBarUninterruptData
{
	public float AnPlayerTime;

	public float RightValue;

	public float LeftValue;

	public float TimeCountLeft;

	private static int STBarUninterruptData_StructSize;

	private static int STBarUninterruptData_IsValid;

	public STBarUninterruptData(float AnPlayerTime, float RightValue, float LeftValue, float TimeCountLeft)
	{
		this.AnPlayerTime = AnPlayerTime;
		this.RightValue = RightValue;
		this.LeftValue = LeftValue;
		this.TimeCountLeft = TimeCountLeft;
	}

	public STBarUninterruptData Copy()
	{
		return this;
	}

	public static STBarUninterruptData FromNative(IntPtr nativeBuffer)
	{
		return new STBarUninterruptData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, STBarUninterruptData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static STBarUninterruptData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new STBarUninterruptData(IntPtr.Add(nativeBuffer, arrayIndex * STBarUninterruptData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, STBarUninterruptData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * STBarUninterruptData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (STBarUninterruptData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.STBarUninterruptData");
		}
	}

	public STBarUninterruptData(IntPtr nativeStruct)
	{
		if (STBarUninterruptData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.STBarUninterruptData");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.STBarUninterruptData");
		STBarUninterruptData_StructSize = NativeReflection.GetStructSize(intPtr);
		STBarUninterruptData_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.STBarUninterruptData", (byte)STBarUninterruptData_IsValid != 0);
	}

	static STBarUninterruptData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(STBarUninterruptData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(STBarUninterruptData));
	}
}
