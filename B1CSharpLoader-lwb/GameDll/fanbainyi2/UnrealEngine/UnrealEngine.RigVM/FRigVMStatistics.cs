using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/RigVM.RigVMStatistics", "RigVM", UnrealModuleType.Engine)]
public struct FRigVMStatistics
{
	private static bool BytesForCDO_IsValid;

	private static int BytesForCDO_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/RigVM.RigVMStatistics:BytesForCDO")]
	public int BytesForCDO;

	private static bool BytesPerInstance_IsValid;

	private static int BytesPerInstance_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/RigVM.RigVMStatistics:BytesPerInstance")]
	public int BytesPerInstance;

	private static bool LiteralMemory_IsValid;

	private static int LiteralMemory_Offset;

	[UProperty(Flags = (PropFlags)4503668346978325uL)]
	[UMetaPath("/Script/RigVM.RigVMStatistics:LiteralMemory")]
	public FRigVMMemoryStatistics LiteralMemory;

	private static bool WorkMemory_IsValid;

	private static int WorkMemory_Offset;

	[UProperty(Flags = (PropFlags)4503668346978325uL)]
	[UMetaPath("/Script/RigVM.RigVMStatistics:WorkMemory")]
	public FRigVMMemoryStatistics WorkMemory;

	private static bool DebugMemory_IsValid;

	private static int DebugMemory_Offset;

	[UProperty(Flags = (PropFlags)4503668346978325uL)]
	[UMetaPath("/Script/RigVM.RigVMStatistics:DebugMemory")]
	public FRigVMMemoryStatistics DebugMemory;

	private static bool BytesForCaching_IsValid;

	private static int BytesForCaching_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/RigVM.RigVMStatistics:BytesForCaching")]
	public int BytesForCaching;

	private static bool ByteCode_IsValid;

	private static int ByteCode_Offset;

	[UProperty(Flags = (PropFlags)4503668346978325uL)]
	[UMetaPath("/Script/RigVM.RigVMStatistics:ByteCode")]
	public FRigVMByteCodeStatistics ByteCode;

	private static bool FRigVMStatistics_IsValid;

	private static int FRigVMStatistics_StructSize;

	public FRigVMStatistics Copy()
	{
		return this;
	}

	public static FRigVMStatistics FromNative(IntPtr nativeBuffer)
	{
		return new FRigVMStatistics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigVMStatistics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigVMStatistics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigVMStatistics(nativeBuffer + arrayIndex * FRigVMStatistics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigVMStatistics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigVMStatistics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigVMStatistics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMStatistics");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BytesForCDO_Offset), BytesForCDO);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BytesPerInstance_Offset), BytesPerInstance);
		FRigVMMemoryStatistics.ToNative(IntPtr.Add(nativeStruct, LiteralMemory_Offset), LiteralMemory);
		FRigVMMemoryStatistics.ToNative(IntPtr.Add(nativeStruct, WorkMemory_Offset), WorkMemory);
		FRigVMMemoryStatistics.ToNative(IntPtr.Add(nativeStruct, DebugMemory_Offset), DebugMemory);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BytesForCaching_Offset), BytesForCaching);
		FRigVMByteCodeStatistics.ToNative(IntPtr.Add(nativeStruct, ByteCode_Offset), ByteCode);
	}

	public FRigVMStatistics(IntPtr nativeStruct)
	{
		if (!FRigVMStatistics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMStatistics");
			BytesForCDO = 0;
			BytesPerInstance = 0;
			LiteralMemory = default(FRigVMMemoryStatistics);
			WorkMemory = default(FRigVMMemoryStatistics);
			DebugMemory = default(FRigVMMemoryStatistics);
			BytesForCaching = 0;
			ByteCode = default(FRigVMByteCodeStatistics);
		}
		else
		{
			BytesForCDO = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BytesForCDO_Offset));
			BytesPerInstance = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BytesPerInstance_Offset));
			LiteralMemory = FRigVMMemoryStatistics.FromNative(IntPtr.Add(nativeStruct, LiteralMemory_Offset));
			WorkMemory = FRigVMMemoryStatistics.FromNative(IntPtr.Add(nativeStruct, WorkMemory_Offset));
			DebugMemory = FRigVMMemoryStatistics.FromNative(IntPtr.Add(nativeStruct, DebugMemory_Offset));
			BytesForCaching = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BytesForCaching_Offset));
			ByteCode = FRigVMByteCodeStatistics.FromNative(IntPtr.Add(nativeStruct, ByteCode_Offset));
		}
	}

	static FRigVMStatistics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigVMStatistics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigVMStatistics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/RigVM.RigVMStatistics");
		FRigVMStatistics_StructSize = NativeReflection.GetStructSize(intPtr);
		BytesForCDO_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BytesForCDO");
		BytesForCDO_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BytesForCDO", Classes.FIntProperty);
		BytesPerInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BytesPerInstance");
		BytesPerInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BytesPerInstance", Classes.FIntProperty);
		LiteralMemory_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LiteralMemory");
		LiteralMemory_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LiteralMemory", Classes.FStructProperty);
		WorkMemory_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WorkMemory");
		WorkMemory_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WorkMemory", Classes.FStructProperty);
		DebugMemory_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugMemory");
		DebugMemory_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugMemory", Classes.FStructProperty);
		BytesForCaching_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BytesForCaching");
		BytesForCaching_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BytesForCaching", Classes.FIntProperty);
		ByteCode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ByteCode");
		ByteCode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ByteCode", Classes.FStructProperty);
		FRigVMStatistics_IsValid = intPtr != IntPtr.Zero && BytesForCDO_IsValid && BytesPerInstance_IsValid && LiteralMemory_IsValid && WorkMemory_IsValid && DebugMemory_IsValid && BytesForCaching_IsValid && ByteCode_IsValid;
		NativeReflection.LogStructIsValid("/Script/RigVM.RigVMStatistics", FRigVMStatistics_IsValid);
	}
}
