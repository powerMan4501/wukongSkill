using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementFramework;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/TypedElementFramework.ScriptTypedElementListProxy", "TypedElementFramework", UnrealModuleType.Engine)]
public struct FTypedElementList
{
	private static bool FTypedElementList_IsValid;

	private static int FTypedElementList_StructSize;

	public FTypedElementList Copy()
	{
		return this;
	}

	public static FTypedElementList FromNative(IntPtr nativeBuffer)
	{
		return new FTypedElementList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTypedElementList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTypedElementList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTypedElementList(nativeBuffer + arrayIndex * FTypedElementList_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTypedElementList value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTypedElementList_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTypedElementList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementFramework.ScriptTypedElementListProxy");
		}
	}

	public FTypedElementList(IntPtr nativeStruct)
	{
		if (!FTypedElementList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementFramework.ScriptTypedElementListProxy");
		}
	}

	static FTypedElementList()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTypedElementList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTypedElementList));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TypedElementFramework.ScriptTypedElementListProxy");
		FTypedElementList_StructSize = NativeReflection.GetStructSize(intPtr);
		FTypedElementList_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/TypedElementFramework.ScriptTypedElementListProxy", FTypedElementList_IsValid);
	}
}
