using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.DataDrivenConsoleVariable", "Engine", UnrealModuleType.Engine)]
public struct FDataDrivenConsoleVariable
{
	private static bool FDataDrivenConsoleVariable_IsValid;

	private static int FDataDrivenConsoleVariable_StructSize;

	public FDataDrivenConsoleVariable Copy()
	{
		return this;
	}

	public static FDataDrivenConsoleVariable FromNative(IntPtr nativeBuffer)
	{
		return new FDataDrivenConsoleVariable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDataDrivenConsoleVariable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDataDrivenConsoleVariable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDataDrivenConsoleVariable(nativeBuffer + arrayIndex * FDataDrivenConsoleVariable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDataDrivenConsoleVariable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDataDrivenConsoleVariable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDataDrivenConsoleVariable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DataDrivenConsoleVariable");
		}
	}

	public FDataDrivenConsoleVariable(IntPtr nativeStruct)
	{
		if (!FDataDrivenConsoleVariable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DataDrivenConsoleVariable");
		}
	}

	static FDataDrivenConsoleVariable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDataDrivenConsoleVariable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDataDrivenConsoleVariable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.DataDrivenConsoleVariable");
		FDataDrivenConsoleVariable_StructSize = NativeReflection.GetStructSize(intPtr);
		FDataDrivenConsoleVariable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.DataDrivenConsoleVariable", FDataDrivenConsoleVariable_IsValid);
	}
}
