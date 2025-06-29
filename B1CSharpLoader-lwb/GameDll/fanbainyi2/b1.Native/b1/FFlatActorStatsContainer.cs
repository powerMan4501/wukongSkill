using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.FlatActorStatsContainer", "FuncLibEditor", UnrealModuleType.Game)]
public struct FFlatActorStatsContainer
{
	private static bool FFlatActorStatsContainer_IsValid;

	private static int FFlatActorStatsContainer_StructSize;

	public FFlatActorStatsContainer Copy()
	{
		return this;
	}

	public static FFlatActorStatsContainer FromNative(IntPtr nativeBuffer)
	{
		return new FFlatActorStatsContainer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFlatActorStatsContainer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFlatActorStatsContainer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFlatActorStatsContainer(nativeBuffer + arrayIndex * FFlatActorStatsContainer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFlatActorStatsContainer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFlatActorStatsContainer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFlatActorStatsContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FlatActorStatsContainer");
		}
	}

	public FFlatActorStatsContainer(IntPtr nativeStruct)
	{
		if (!FFlatActorStatsContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FlatActorStatsContainer");
		}
	}

	static FFlatActorStatsContainer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFlatActorStatsContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFlatActorStatsContainer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.FlatActorStatsContainer");
		FFlatActorStatsContainer_StructSize = NativeReflection.GetStructSize(intPtr);
		FFlatActorStatsContainer_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.FlatActorStatsContainer", FFlatActorStatsContainer_IsValid);
	}
}
