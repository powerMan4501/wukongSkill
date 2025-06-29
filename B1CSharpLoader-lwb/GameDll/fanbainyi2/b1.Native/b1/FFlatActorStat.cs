using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.FlatActorStat", "FuncLibEditor", UnrealModuleType.Game)]
public struct FFlatActorStat
{
	private static bool FFlatActorStat_IsValid;

	private static int FFlatActorStat_StructSize;

	public FFlatActorStat Copy()
	{
		return this;
	}

	public static FFlatActorStat FromNative(IntPtr nativeBuffer)
	{
		return new FFlatActorStat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFlatActorStat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFlatActorStat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFlatActorStat(nativeBuffer + arrayIndex * FFlatActorStat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFlatActorStat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFlatActorStat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFlatActorStat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FlatActorStat");
		}
	}

	public FFlatActorStat(IntPtr nativeStruct)
	{
		if (!FFlatActorStat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FlatActorStat");
		}
	}

	static FFlatActorStat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFlatActorStat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFlatActorStat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.FlatActorStat");
		FFlatActorStat_StructSize = NativeReflection.GetStructSize(intPtr);
		FFlatActorStat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.FlatActorStat", FFlatActorStat_IsValid);
	}
}
