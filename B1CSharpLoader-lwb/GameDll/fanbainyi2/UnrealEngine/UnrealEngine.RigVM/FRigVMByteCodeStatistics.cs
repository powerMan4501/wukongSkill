using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/RigVM.RigVMByteCodeStatistics", "RigVM", UnrealModuleType.Engine)]
public struct FRigVMByteCodeStatistics
{
	private static bool InstructionCount_IsValid;

	private static int InstructionCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/RigVM.RigVMByteCodeStatistics:InstructionCount")]
	public int InstructionCount;

	private static bool DataBytes_IsValid;

	private static int DataBytes_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/RigVM.RigVMByteCodeStatistics:DataBytes")]
	public int DataBytes;

	private static bool FRigVMByteCodeStatistics_IsValid;

	private static int FRigVMByteCodeStatistics_StructSize;

	public FRigVMByteCodeStatistics Copy()
	{
		return this;
	}

	public static FRigVMByteCodeStatistics FromNative(IntPtr nativeBuffer)
	{
		return new FRigVMByteCodeStatistics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigVMByteCodeStatistics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigVMByteCodeStatistics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigVMByteCodeStatistics(nativeBuffer + arrayIndex * FRigVMByteCodeStatistics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigVMByteCodeStatistics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigVMByteCodeStatistics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigVMByteCodeStatistics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMByteCodeStatistics");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InstructionCount_Offset), InstructionCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DataBytes_Offset), DataBytes);
	}

	public FRigVMByteCodeStatistics(IntPtr nativeStruct)
	{
		if (!FRigVMByteCodeStatistics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMByteCodeStatistics");
			InstructionCount = 0;
			DataBytes = 0;
		}
		else
		{
			InstructionCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InstructionCount_Offset));
			DataBytes = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DataBytes_Offset));
		}
	}

	static FRigVMByteCodeStatistics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigVMByteCodeStatistics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigVMByteCodeStatistics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/RigVM.RigVMByteCodeStatistics");
		FRigVMByteCodeStatistics_StructSize = NativeReflection.GetStructSize(intPtr);
		InstructionCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InstructionCount");
		InstructionCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InstructionCount", Classes.FIntProperty);
		DataBytes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataBytes");
		DataBytes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataBytes", Classes.FIntProperty);
		FRigVMByteCodeStatistics_IsValid = intPtr != IntPtr.Zero && InstructionCount_IsValid && DataBytes_IsValid;
		NativeReflection.LogStructIsValid("/Script/RigVM.RigVMByteCodeStatistics", FRigVMByteCodeStatistics_IsValid);
	}
}
