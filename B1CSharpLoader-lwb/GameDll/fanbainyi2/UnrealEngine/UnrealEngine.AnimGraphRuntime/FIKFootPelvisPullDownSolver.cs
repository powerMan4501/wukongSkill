using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.IKFootPelvisPullDownSolver", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FIKFootPelvisPullDownSolver
{
	private static bool FIKFootPelvisPullDownSolver_IsValid;

	private static int FIKFootPelvisPullDownSolver_StructSize;

	public FIKFootPelvisPullDownSolver Copy()
	{
		return this;
	}

	public static FIKFootPelvisPullDownSolver FromNative(IntPtr nativeBuffer)
	{
		return new FIKFootPelvisPullDownSolver(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FIKFootPelvisPullDownSolver value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FIKFootPelvisPullDownSolver FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FIKFootPelvisPullDownSolver(nativeBuffer + arrayIndex * FIKFootPelvisPullDownSolver_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FIKFootPelvisPullDownSolver value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FIKFootPelvisPullDownSolver_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FIKFootPelvisPullDownSolver_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.IKFootPelvisPullDownSolver");
		}
	}

	public FIKFootPelvisPullDownSolver(IntPtr nativeStruct)
	{
		if (!FIKFootPelvisPullDownSolver_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.IKFootPelvisPullDownSolver");
		}
	}

	static FIKFootPelvisPullDownSolver()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FIKFootPelvisPullDownSolver)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIKFootPelvisPullDownSolver));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.IKFootPelvisPullDownSolver");
		FIKFootPelvisPullDownSolver_StructSize = NativeReflection.GetStructSize(intPtr);
		FIKFootPelvisPullDownSolver_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.IKFootPelvisPullDownSolver", FIKFootPelvisPullDownSolver_IsValid);
	}
}
