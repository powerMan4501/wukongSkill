using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimationCore.FilterOptionPerAxis", "AnimationCore", UnrealModuleType.Engine)]
public struct FFilterOptionPerAxis
{
	private static bool X_IsValid;

	private static FFieldAddress X_PropertyAddress;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.FilterOptionPerAxis:bX")]
	public bool X;

	private static bool Y_IsValid;

	private static FFieldAddress Y_PropertyAddress;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.FilterOptionPerAxis:bY")]
	public bool Y;

	private static bool Z_IsValid;

	private static FFieldAddress Z_PropertyAddress;

	private static int Z_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.FilterOptionPerAxis:bZ")]
	public bool Z;

	private static bool FFilterOptionPerAxis_IsValid;

	private static int FFilterOptionPerAxis_StructSize;

	public FFilterOptionPerAxis Copy()
	{
		return this;
	}

	public static FFilterOptionPerAxis FromNative(IntPtr nativeBuffer)
	{
		return new FFilterOptionPerAxis(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFilterOptionPerAxis value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFilterOptionPerAxis FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFilterOptionPerAxis(nativeBuffer + arrayIndex * FFilterOptionPerAxis_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFilterOptionPerAxis value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFilterOptionPerAxis_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFilterOptionPerAxis_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.FilterOptionPerAxis");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, X_Offset), 0, X_PropertyAddress.Address, X);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Y_Offset), 0, Y_PropertyAddress.Address, Y);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Z_Offset), 0, Z_PropertyAddress.Address, Z);
	}

	public FFilterOptionPerAxis(IntPtr nativeStruct)
	{
		if (!FFilterOptionPerAxis_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.FilterOptionPerAxis");
			X = false;
			Y = false;
			Z = false;
		}
		else
		{
			X = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, X_Offset), 0, X_PropertyAddress.Address);
			Y = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Y_Offset), 0, Y_PropertyAddress.Address);
			Z = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Z_Offset), 0, Z_PropertyAddress.Address);
		}
	}

	static FFilterOptionPerAxis()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFilterOptionPerAxis)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFilterOptionPerAxis));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimationCore.FilterOptionPerAxis");
		FFilterOptionPerAxis_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref X_PropertyAddress, intPtr, "bX");
		X_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bX");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Y_PropertyAddress, intPtr, "bY");
		Y_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bY");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Z_PropertyAddress, intPtr, "bZ");
		Z_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bZ");
		Z_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bZ", Classes.FBoolProperty);
		FFilterOptionPerAxis_IsValid = intPtr != IntPtr.Zero && X_IsValid && Y_IsValid && Z_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimationCore.FilterOptionPerAxis", FFilterOptionPerAxis_IsValid);
	}
}
