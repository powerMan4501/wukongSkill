using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.UsbStorageDeviceInfo", "UnrealExtent", UnrealModuleType.Game)]
public struct FUsbStorageDeviceInfo
{
	private static bool TotalSpace_IsValid;

	private static int TotalSpace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.UsbStorageDeviceInfo:TotalSpace")]
	public long TotalSpace;

	private static bool AvailableSpace_IsValid;

	private static int AvailableSpace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.UsbStorageDeviceInfo:AvailableSpace")]
	public long AvailableSpace;

	private static bool Manufacture_IsValid;

	private static int Manufacture_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealExtent.UsbStorageDeviceInfo:Manufacture")]
	public string Manufacture;

	private static bool FUsbStorageDeviceInfo_IsValid;

	private static int FUsbStorageDeviceInfo_StructSize;

	public FUsbStorageDeviceInfo Copy()
	{
		return this;
	}

	public static FUsbStorageDeviceInfo FromNative(IntPtr nativeBuffer)
	{
		return new FUsbStorageDeviceInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUsbStorageDeviceInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUsbStorageDeviceInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUsbStorageDeviceInfo(nativeBuffer + arrayIndex * FUsbStorageDeviceInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUsbStorageDeviceInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUsbStorageDeviceInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUsbStorageDeviceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.UsbStorageDeviceInfo");
			return;
		}
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(nativeStruct, TotalSpace_Offset), TotalSpace);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(nativeStruct, AvailableSpace_Offset), AvailableSpace);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Manufacture_Offset), Manufacture);
	}

	public FUsbStorageDeviceInfo(IntPtr nativeStruct)
	{
		if (!FUsbStorageDeviceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.UsbStorageDeviceInfo");
			TotalSpace = 0L;
			AvailableSpace = 0L;
			Manufacture = FStringMarshaler.DefaultString;
		}
		else
		{
			TotalSpace = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(nativeStruct, TotalSpace_Offset));
			AvailableSpace = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(nativeStruct, AvailableSpace_Offset));
			Manufacture = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Manufacture_Offset));
		}
	}

	static FUsbStorageDeviceInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUsbStorageDeviceInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUsbStorageDeviceInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.UsbStorageDeviceInfo");
		FUsbStorageDeviceInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		TotalSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalSpace");
		TotalSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalSpace", Classes.FInt64Property);
		AvailableSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AvailableSpace");
		AvailableSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AvailableSpace", Classes.FInt64Property);
		Manufacture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Manufacture");
		Manufacture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Manufacture", Classes.FStrProperty);
		FUsbStorageDeviceInfo_IsValid = intPtr != IntPtr.Zero && TotalSpace_IsValid && AvailableSpace_IsValid && Manufacture_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.UsbStorageDeviceInfo", FUsbStorageDeviceInfo_IsValid);
	}
}
