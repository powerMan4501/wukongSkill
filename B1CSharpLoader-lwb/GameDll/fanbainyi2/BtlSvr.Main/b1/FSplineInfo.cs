using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SplineInfo")]
public struct FSplineInfo
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SplineInfo:SplineStart")]
	public FVector SplineStart;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SplineInfo:SplineEnd")]
	public FVector SplineEnd;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SplineInfo:SplineActor")]
	public BGUSimpleSplineActor SplineActor;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SplineInfo:Guid")]
	public string Guid;

	private static int SplineInfo_StructSize;

	private static int SplineInfo_IsValid;

	private static bool SplineStart_IsValid;

	private static int SplineStart_Offset;

	private static bool SplineEnd_IsValid;

	private static int SplineEnd_Offset;

	private static bool SplineActor_IsValid;

	private static int SplineActor_Offset;

	private static bool Guid_IsValid;

	private static int Guid_Offset;

	public FSplineInfo Copy()
	{
		return this;
	}

	public static FSplineInfo FromNative(IntPtr nativeBuffer)
	{
		return new FSplineInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSplineInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSplineInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSplineInfo(IntPtr.Add(nativeBuffer, arrayIndex * SplineInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSplineInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SplineInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SplineInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SplineInfo");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SplineStart_Offset), SplineStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SplineEnd_Offset), SplineEnd);
		UObjectMarshaler<BGUSimpleSplineActor>.ToNative(IntPtr.Add(nativeStruct, SplineActor_Offset), SplineActor);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Guid_Offset), Guid);
	}

	public FSplineInfo(IntPtr nativeStruct)
	{
		if (SplineInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SplineInfo");
			SplineStart = default(FVector);
			SplineEnd = default(FVector);
			SplineActor = null;
			Guid = null;
		}
		else
		{
			SplineStart = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SplineStart_Offset));
			SplineEnd = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SplineEnd_Offset));
			SplineActor = UObjectMarshaler<BGUSimpleSplineActor>.FromNative(IntPtr.Add(nativeStruct, SplineActor_Offset));
			Guid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Guid_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SplineInfo");
		SplineInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		SplineStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineStart");
		SplineStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineStart", Classes.FStructProperty);
		SplineEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineEnd");
		SplineEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineEnd", Classes.FStructProperty);
		SplineActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineActor");
		SplineActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineActor", Classes.FObjectProperty);
		Guid_Offset = NativeReflection.GetPropertyOffset(intPtr, "Guid");
		Guid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Guid", Classes.FStrProperty);
		SplineInfo_IsValid = ((intPtr != IntPtr.Zero && SplineStart_IsValid && SplineEnd_IsValid && SplineActor_IsValid && Guid_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SplineInfo", (byte)SplineInfo_IsValid != 0);
	}

	static FSplineInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSplineInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSplineInfo));
	}
}
