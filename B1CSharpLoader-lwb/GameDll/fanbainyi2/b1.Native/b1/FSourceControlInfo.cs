using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.SourceControlInfo", "FuncLibEditor", UnrealModuleType.Game)]
public struct FSourceControlInfo
{
	private static bool HistorySize_IsValid;

	private static int HistorySize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.SourceControlInfo:HistorySize")]
	public int HistorySize;

	private static bool CanCheckOut_IsValid;

	private static FFieldAddress CanCheckOut_PropertyAddress;

	private static int CanCheckOut_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.SourceControlInfo:CanCheckOut")]
	public bool CanCheckOut;

	private static bool IsCurrent_IsValid;

	private static FFieldAddress IsCurrent_PropertyAddress;

	private static int IsCurrent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.SourceControlInfo:IsCurrent")]
	public bool IsCurrent;

	private static bool IsLocal_IsValid;

	private static FFieldAddress IsLocal_PropertyAddress;

	private static int IsLocal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.SourceControlInfo:IsLocal")]
	public bool IsLocal;

	private static bool IsCheckOut_IsValid;

	private static FFieldAddress IsCheckOut_PropertyAddress;

	private static int IsCheckOut_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.SourceControlInfo:IsCheckOut")]
	public bool IsCheckOut;

	private static bool FSourceControlInfo_IsValid;

	private static int FSourceControlInfo_StructSize;

	public FSourceControlInfo Copy()
	{
		return this;
	}

	public static FSourceControlInfo FromNative(IntPtr nativeBuffer)
	{
		return new FSourceControlInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceControlInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceControlInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceControlInfo(nativeBuffer + arrayIndex * FSourceControlInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceControlInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceControlInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceControlInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.SourceControlInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, HistorySize_Offset), HistorySize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanCheckOut_Offset), 0, CanCheckOut_PropertyAddress.Address, CanCheckOut);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsCurrent_Offset), 0, IsCurrent_PropertyAddress.Address, IsCurrent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLocal_Offset), 0, IsLocal_PropertyAddress.Address, IsLocal);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsCheckOut_Offset), 0, IsCheckOut_PropertyAddress.Address, IsCheckOut);
	}

	public FSourceControlInfo(IntPtr nativeStruct)
	{
		if (!FSourceControlInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.SourceControlInfo");
			HistorySize = 0;
			CanCheckOut = false;
			IsCurrent = false;
			IsLocal = false;
			IsCheckOut = false;
		}
		else
		{
			HistorySize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, HistorySize_Offset));
			CanCheckOut = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanCheckOut_Offset), 0, CanCheckOut_PropertyAddress.Address);
			IsCurrent = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsCurrent_Offset), 0, IsCurrent_PropertyAddress.Address);
			IsLocal = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLocal_Offset), 0, IsLocal_PropertyAddress.Address);
			IsCheckOut = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsCheckOut_Offset), 0, IsCheckOut_PropertyAddress.Address);
		}
	}

	static FSourceControlInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceControlInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceControlInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.SourceControlInfo");
		FSourceControlInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		HistorySize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HistorySize");
		HistorySize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HistorySize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CanCheckOut_PropertyAddress, intPtr, "CanCheckOut");
		CanCheckOut_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CanCheckOut");
		CanCheckOut_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CanCheckOut", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCurrent_PropertyAddress, intPtr, "IsCurrent");
		IsCurrent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsCurrent");
		IsCurrent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsCurrent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLocal_PropertyAddress, intPtr, "IsLocal");
		IsLocal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsLocal");
		IsLocal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsLocal", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCheckOut_PropertyAddress, intPtr, "IsCheckOut");
		IsCheckOut_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsCheckOut");
		IsCheckOut_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsCheckOut", Classes.FBoolProperty);
		FSourceControlInfo_IsValid = intPtr != IntPtr.Zero && HistorySize_IsValid && CanCheckOut_IsValid && IsCurrent_IsValid && IsLocal_IsValid && IsCheckOut_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.SourceControlInfo", FSourceControlInfo_IsValid);
	}
}
