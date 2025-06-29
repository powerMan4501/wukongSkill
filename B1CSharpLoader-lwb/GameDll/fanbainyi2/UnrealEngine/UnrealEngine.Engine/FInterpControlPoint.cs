using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.InterpControlPoint", "Engine", UnrealModuleType.Engine)]
public struct FInterpControlPoint
{
	private static bool PositionControlPoint_IsValid;

	private static int PositionControlPoint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InterpControlPoint:PositionControlPoint")]
	public FVector PositionControlPoint;

	private static bool PositionIsRelative_IsValid;

	private static FFieldAddress PositionIsRelative_PropertyAddress;

	private static int PositionIsRelative_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InterpControlPoint:bPositionIsRelative")]
	public bool PositionIsRelative;

	private static bool FInterpControlPoint_IsValid;

	private static int FInterpControlPoint_StructSize;

	public FInterpControlPoint Copy()
	{
		return this;
	}

	public static FInterpControlPoint FromNative(IntPtr nativeBuffer)
	{
		return new FInterpControlPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInterpControlPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInterpControlPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInterpControlPoint(nativeBuffer + arrayIndex * FInterpControlPoint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInterpControlPoint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInterpControlPoint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInterpControlPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InterpControlPoint");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, PositionControlPoint_Offset), PositionControlPoint);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, PositionIsRelative_Offset), 0, PositionIsRelative_PropertyAddress.Address, PositionIsRelative);
	}

	public FInterpControlPoint(IntPtr nativeStruct)
	{
		if (!FInterpControlPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InterpControlPoint");
			PositionControlPoint = default(FVector);
			PositionIsRelative = false;
		}
		else
		{
			PositionControlPoint = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, PositionControlPoint_Offset));
			PositionIsRelative = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, PositionIsRelative_Offset), 0, PositionIsRelative_PropertyAddress.Address);
		}
	}

	static FInterpControlPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterpControlPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpControlPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InterpControlPoint");
		FInterpControlPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		PositionControlPoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PositionControlPoint");
		PositionControlPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PositionControlPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PositionIsRelative_PropertyAddress, intPtr, "bPositionIsRelative");
		PositionIsRelative_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPositionIsRelative");
		PositionIsRelative_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPositionIsRelative", Classes.FBoolProperty);
		FInterpControlPoint_IsValid = intPtr != IntPtr.Zero && PositionControlPoint_IsValid && PositionIsRelative_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.InterpControlPoint", FInterpControlPoint_IsValid);
	}
}
