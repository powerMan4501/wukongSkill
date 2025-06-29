using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TeleportParam_RebirthPoint")]
public struct TeleportParam_RebirthPoint
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_RebirthPoint:RebirthPointId")]
	public int RebirthPointId;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_RebirthPoint:RebirthType")]
	public ERebirthType RebirthType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_RebirthPoint:FromSettingUI")]
	public bool FromSettingUI;

	private static int TeleportParam_RebirthPoint_StructSize;

	private static int TeleportParam_RebirthPoint_IsValid;

	private static bool RebirthPointId_IsValid;

	private static int RebirthPointId_Offset;

	private static bool RebirthType_IsValid;

	private static int RebirthType_Offset;

	private static FFieldAddress RebirthType_PropertyAddress;

	private static bool FromSettingUI_IsValid;

	private static int FromSettingUI_Offset;

	private static FFieldAddress FromSettingUI_PropertyAddress;

	public TeleportParam_RebirthPoint Copy()
	{
		return this;
	}

	public static TeleportParam_RebirthPoint FromNative(IntPtr nativeBuffer)
	{
		return new TeleportParam_RebirthPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, TeleportParam_RebirthPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static TeleportParam_RebirthPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TeleportParam_RebirthPoint(IntPtr.Add(nativeBuffer, arrayIndex * TeleportParam_RebirthPoint_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TeleportParam_RebirthPoint value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TeleportParam_RebirthPoint_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TeleportParam_RebirthPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TeleportParam_RebirthPoint");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RebirthPointId_Offset), RebirthPointId);
		EnumMarshaler<ERebirthType>.ToNative(IntPtr.Add(nativeStruct, RebirthType_Offset), 0, RebirthType_PropertyAddress.Address, RebirthType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FromSettingUI_Offset), 0, FromSettingUI_PropertyAddress.Address, FromSettingUI);
	}

	public TeleportParam_RebirthPoint(IntPtr nativeStruct)
	{
		if (TeleportParam_RebirthPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TeleportParam_RebirthPoint");
			RebirthPointId = 0;
			RebirthType = ERebirthType.RebirthPoint;
			FromSettingUI = false;
		}
		else
		{
			RebirthPointId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RebirthPointId_Offset));
			RebirthType = EnumMarshaler<ERebirthType>.FromNative(IntPtr.Add(nativeStruct, RebirthType_Offset), 0, RebirthType_PropertyAddress.Address);
			FromSettingUI = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FromSettingUI_Offset), 0, FromSettingUI_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TeleportParam_RebirthPoint");
		TeleportParam_RebirthPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		RebirthPointId_Offset = NativeReflection.GetPropertyOffset(intPtr, "RebirthPointId");
		RebirthPointId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RebirthPointId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref RebirthType_PropertyAddress, intPtr, "RebirthType");
		RebirthType_Offset = NativeReflection.GetPropertyOffset(intPtr, "RebirthType");
		RebirthType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RebirthType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref FromSettingUI_PropertyAddress, intPtr, "FromSettingUI");
		FromSettingUI_Offset = NativeReflection.GetPropertyOffset(intPtr, "FromSettingUI");
		FromSettingUI_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FromSettingUI", Classes.FBoolProperty);
		TeleportParam_RebirthPoint_IsValid = ((intPtr != IntPtr.Zero && RebirthPointId_IsValid && RebirthType_IsValid && FromSettingUI_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TeleportParam_RebirthPoint", (byte)TeleportParam_RebirthPoint_IsValid != 0);
	}

	static TeleportParam_RebirthPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TeleportParam_RebirthPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TeleportParam_RebirthPoint));
	}
}
