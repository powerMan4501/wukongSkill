using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Arteries;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Arteries.ArteriesPoint", "Arteries", UnrealModuleType.GamePlugin)]
public struct FArteriesPoint
{
	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Arteries.ArteriesPoint:Position")]
	public FVector Position;

	private static bool FArteriesPoint_IsValid;

	private static int FArteriesPoint_StructSize;

	public FArteriesPoint Copy()
	{
		return this;
	}

	public static FArteriesPoint FromNative(IntPtr nativeBuffer)
	{
		return new FArteriesPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FArteriesPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FArteriesPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FArteriesPoint(nativeBuffer + arrayIndex * FArteriesPoint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FArteriesPoint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FArteriesPoint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FArteriesPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Arteries.ArteriesPoint");
		}
		else
		{
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		}
	}

	public FArteriesPoint(IntPtr nativeStruct)
	{
		if (!FArteriesPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Arteries.ArteriesPoint");
			Position = default(FVector);
		}
		else
		{
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
		}
	}

	static FArteriesPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FArteriesPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FArteriesPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Arteries.ArteriesPoint");
		FArteriesPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		FArteriesPoint_IsValid = intPtr != IntPtr.Zero && Position_IsValid;
		NativeReflection.LogStructIsValid("/Script/Arteries.ArteriesPoint", FArteriesPoint_IsValid);
	}
}
