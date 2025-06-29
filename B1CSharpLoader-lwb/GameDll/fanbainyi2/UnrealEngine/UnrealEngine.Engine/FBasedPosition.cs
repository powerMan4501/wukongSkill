using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.BasedPosition", "Engine", UnrealModuleType.Engine)]
public struct FBasedPosition
{
	private static bool Base__IsValid;

	private static int Base__Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.BasedPosition:Base")]
	public AActor Base_;

	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BasedPosition:Position")]
	public FVector Position;

	private static bool FBasedPosition_IsValid;

	private static int FBasedPosition_StructSize;

	public FBasedPosition Copy()
	{
		return this;
	}

	public static FBasedPosition FromNative(IntPtr nativeBuffer)
	{
		return new FBasedPosition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBasedPosition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBasedPosition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBasedPosition(nativeBuffer + arrayIndex * FBasedPosition_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBasedPosition value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBasedPosition_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBasedPosition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BasedPosition");
			return;
		}
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Base__Offset), Base_);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
	}

	public FBasedPosition(IntPtr nativeStruct)
	{
		if (!FBasedPosition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BasedPosition");
			Base_ = null;
			Position = default(FVector);
		}
		else
		{
			Base_ = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Base__Offset));
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
		}
	}

	static FBasedPosition()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBasedPosition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBasedPosition));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.BasedPosition");
		FBasedPosition_StructSize = NativeReflection.GetStructSize(intPtr);
		Base__Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Base");
		Base__IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Base", Classes.FObjectProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		FBasedPosition_IsValid = intPtr != IntPtr.Zero && Base__IsValid && Position_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.BasedPosition", FBasedPosition_IsValid);
	}
}
