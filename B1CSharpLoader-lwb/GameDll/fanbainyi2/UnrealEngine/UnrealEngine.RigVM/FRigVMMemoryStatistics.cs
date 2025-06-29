using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/RigVM.RigVMMemoryStatistics", "RigVM", UnrealModuleType.Engine)]
public struct FRigVMMemoryStatistics
{
	private static bool RegisterCount_IsValid;

	private static int RegisterCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/RigVM.RigVMMemoryStatistics:RegisterCount")]
	public int RegisterCount;

	private static bool DataBytes_IsValid;

	private static int DataBytes_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/RigVM.RigVMMemoryStatistics:DataBytes")]
	public int DataBytes;

	private static bool TotalBytes_IsValid;

	private static int TotalBytes_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/RigVM.RigVMMemoryStatistics:TotalBytes")]
	public int TotalBytes;

	private static bool FRigVMMemoryStatistics_IsValid;

	private static int FRigVMMemoryStatistics_StructSize;

	public FRigVMMemoryStatistics Copy()
	{
		return this;
	}

	public static FRigVMMemoryStatistics FromNative(IntPtr nativeBuffer)
	{
		return new FRigVMMemoryStatistics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigVMMemoryStatistics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigVMMemoryStatistics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigVMMemoryStatistics(nativeBuffer + arrayIndex * FRigVMMemoryStatistics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigVMMemoryStatistics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigVMMemoryStatistics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigVMMemoryStatistics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMMemoryStatistics");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RegisterCount_Offset), RegisterCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DataBytes_Offset), DataBytes);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TotalBytes_Offset), TotalBytes);
	}

	public FRigVMMemoryStatistics(IntPtr nativeStruct)
	{
		if (!FRigVMMemoryStatistics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMMemoryStatistics");
			RegisterCount = 0;
			DataBytes = 0;
			TotalBytes = 0;
		}
		else
		{
			RegisterCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RegisterCount_Offset));
			DataBytes = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DataBytes_Offset));
			TotalBytes = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TotalBytes_Offset));
		}
	}

	static FRigVMMemoryStatistics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigVMMemoryStatistics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigVMMemoryStatistics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/RigVM.RigVMMemoryStatistics");
		FRigVMMemoryStatistics_StructSize = NativeReflection.GetStructSize(intPtr);
		RegisterCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RegisterCount");
		RegisterCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RegisterCount", Classes.FIntProperty);
		DataBytes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataBytes");
		DataBytes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataBytes", Classes.FIntProperty);
		TotalBytes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalBytes");
		TotalBytes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalBytes", Classes.FIntProperty);
		FRigVMMemoryStatistics_IsValid = intPtr != IntPtr.Zero && RegisterCount_IsValid && DataBytes_IsValid && TotalBytes_IsValid;
		NativeReflection.LogStructIsValid("/Script/RigVM.RigVMMemoryStatistics", FRigVMMemoryStatistics_IsValid);
	}
}
