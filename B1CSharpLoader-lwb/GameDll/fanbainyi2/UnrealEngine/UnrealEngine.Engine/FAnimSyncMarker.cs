using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 6145)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimSyncMarker", "Engine", UnrealModuleType.Engine)]
public struct FAnimSyncMarker
{
	private static bool MarkerName_IsValid;

	private static int MarkerName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.AnimSyncMarker:MarkerName")]
	public FName MarkerName;

	private static bool Time_IsValid;

	private static int Time_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.AnimSyncMarker:Time")]
	public float Time;

	private static bool FAnimSyncMarker_IsValid;

	private static int FAnimSyncMarker_StructSize;

	public FAnimSyncMarker Copy()
	{
		return this;
	}

	public static FAnimSyncMarker FromNative(IntPtr nativeBuffer)
	{
		return new FAnimSyncMarker(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimSyncMarker value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimSyncMarker FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimSyncMarker(nativeBuffer + arrayIndex * FAnimSyncMarker_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimSyncMarker value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimSyncMarker_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimSyncMarker_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimSyncMarker");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MarkerName_Offset), MarkerName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Time_Offset), Time);
	}

	public FAnimSyncMarker(IntPtr nativeStruct)
	{
		if (!FAnimSyncMarker_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimSyncMarker");
			MarkerName = default(FName);
			Time = 0f;
		}
		else
		{
			MarkerName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MarkerName_Offset));
			Time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Time_Offset));
		}
	}

	static FAnimSyncMarker()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimSyncMarker)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimSyncMarker));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimSyncMarker");
		FAnimSyncMarker_StructSize = NativeReflection.GetStructSize(intPtr);
		MarkerName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MarkerName");
		MarkerName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MarkerName", Classes.FNameProperty);
		Time_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		FAnimSyncMarker_IsValid = intPtr != IntPtr.Zero && MarkerName_IsValid && Time_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimSyncMarker", FAnimSyncMarker_IsValid);
	}
}
