using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SeqSimpleStatePair")]
public struct FSeqSimpleStatePair
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("SimpleStates")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SeqSimpleStatePair:SimpleState")]
	public EBGUSimpleState SimpleState;

	[UProperty]
	[DisplayName("是否移除")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SeqSimpleStatePair:IsRemoving")]
	public bool IsRemoving;

	private static int SeqSimpleStatePair_StructSize;

	private static int SeqSimpleStatePair_IsValid;

	private static bool SimpleState_IsValid;

	private static int SimpleState_Offset;

	private static FFieldAddress SimpleState_PropertyAddress;

	private static bool IsRemoving_IsValid;

	private static int IsRemoving_Offset;

	private static FFieldAddress IsRemoving_PropertyAddress;

	public FSeqSimpleStatePair Copy()
	{
		return this;
	}

	public static FSeqSimpleStatePair FromNative(IntPtr nativeBuffer)
	{
		return new FSeqSimpleStatePair(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSeqSimpleStatePair value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSeqSimpleStatePair FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSeqSimpleStatePair(IntPtr.Add(nativeBuffer, arrayIndex * SeqSimpleStatePair_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSeqSimpleStatePair value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SeqSimpleStatePair_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SeqSimpleStatePair_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SeqSimpleStatePair");
			return;
		}
		EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(nativeStruct, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address, SimpleState);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsRemoving_Offset), 0, IsRemoving_PropertyAddress.Address, IsRemoving);
	}

	public FSeqSimpleStatePair(IntPtr nativeStruct)
	{
		if (SeqSimpleStatePair_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SeqSimpleStatePair");
			SimpleState = EBGUSimpleState.Normal;
			IsRemoving = false;
		}
		else
		{
			SimpleState = EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(nativeStruct, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address);
			IsRemoving = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsRemoving_Offset), 0, IsRemoving_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SeqSimpleStatePair");
		SeqSimpleStatePair_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SimpleState_PropertyAddress, intPtr, "SimpleState");
		SimpleState_Offset = NativeReflection.GetPropertyOffset(intPtr, "SimpleState");
		SimpleState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsRemoving_PropertyAddress, intPtr, "IsRemoving");
		IsRemoving_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRemoving");
		IsRemoving_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRemoving", Classes.FBoolProperty);
		SeqSimpleStatePair_IsValid = ((intPtr != IntPtr.Zero && SimpleState_IsValid && IsRemoving_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SeqSimpleStatePair", (byte)SeqSimpleStatePair_IsValid != 0);
	}

	static FSeqSimpleStatePair()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSeqSimpleStatePair)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSeqSimpleStatePair));
	}
}
