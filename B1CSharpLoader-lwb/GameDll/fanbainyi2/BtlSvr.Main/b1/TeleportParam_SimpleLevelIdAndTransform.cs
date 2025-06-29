using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TeleportParam_SimpleLevelIdAndTransform")]
public struct TeleportParam_SimpleLevelIdAndTransform
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_SimpleLevelIdAndTransform:LevelId")]
	public int LevelId;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_SimpleLevelIdAndTransform:TeleportTransform")]
	public FTransform TeleportTransform;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_SimpleLevelIdAndTransform:LevelTravelUseDefaultPlayerStart")]
	public bool LevelTravelUseDefaultPlayerStart;

	public Action TeleportFinishCallback;

	private static int TeleportParam_SimpleLevelIdAndTransform_StructSize;

	private static int TeleportParam_SimpleLevelIdAndTransform_IsValid;

	private static bool LevelId_IsValid;

	private static int LevelId_Offset;

	private static bool TeleportTransform_IsValid;

	private static int TeleportTransform_Offset;

	private static bool LevelTravelUseDefaultPlayerStart_IsValid;

	private static int LevelTravelUseDefaultPlayerStart_Offset;

	private static FFieldAddress LevelTravelUseDefaultPlayerStart_PropertyAddress;

	public TeleportParam_SimpleLevelIdAndTransform Copy()
	{
		return this;
	}

	public static TeleportParam_SimpleLevelIdAndTransform FromNative(IntPtr nativeBuffer)
	{
		return new TeleportParam_SimpleLevelIdAndTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, TeleportParam_SimpleLevelIdAndTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static TeleportParam_SimpleLevelIdAndTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TeleportParam_SimpleLevelIdAndTransform(IntPtr.Add(nativeBuffer, arrayIndex * TeleportParam_SimpleLevelIdAndTransform_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TeleportParam_SimpleLevelIdAndTransform value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TeleportParam_SimpleLevelIdAndTransform_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TeleportParam_SimpleLevelIdAndTransform_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TeleportParam_SimpleLevelIdAndTransform");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LevelId_Offset), LevelId);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, TeleportTransform_Offset), TeleportTransform);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, LevelTravelUseDefaultPlayerStart_Offset), 0, LevelTravelUseDefaultPlayerStart_PropertyAddress.Address, LevelTravelUseDefaultPlayerStart);
	}

	public TeleportParam_SimpleLevelIdAndTransform(IntPtr nativeStruct)
	{
		if (TeleportParam_SimpleLevelIdAndTransform_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TeleportParam_SimpleLevelIdAndTransform");
			LevelId = 0;
			TeleportTransform = default(FTransform);
			LevelTravelUseDefaultPlayerStart = false;
		}
		else
		{
			LevelId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LevelId_Offset));
			TeleportTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, TeleportTransform_Offset));
			LevelTravelUseDefaultPlayerStart = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, LevelTravelUseDefaultPlayerStart_Offset), 0, LevelTravelUseDefaultPlayerStart_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TeleportParam_SimpleLevelIdAndTransform");
		TeleportParam_SimpleLevelIdAndTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		LevelId_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelId");
		LevelId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelId", Classes.FIntProperty);
		TeleportTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "TeleportTransform");
		TeleportTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TeleportTransform", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref LevelTravelUseDefaultPlayerStart_PropertyAddress, intPtr, "LevelTravelUseDefaultPlayerStart");
		LevelTravelUseDefaultPlayerStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelTravelUseDefaultPlayerStart");
		LevelTravelUseDefaultPlayerStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelTravelUseDefaultPlayerStart", Classes.FBoolProperty);
		TeleportParam_SimpleLevelIdAndTransform_IsValid = ((intPtr != IntPtr.Zero && LevelId_IsValid && TeleportTransform_IsValid && LevelTravelUseDefaultPlayerStart_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TeleportParam_SimpleLevelIdAndTransform", (byte)TeleportParam_SimpleLevelIdAndTransform_IsValid != 0);
	}

	static TeleportParam_SimpleLevelIdAndTransform()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TeleportParam_SimpleLevelIdAndTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TeleportParam_SimpleLevelIdAndTransform));
	}
}
