using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SourceControl;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SourceControl.SourceControlState", "SourceControl", UnrealModuleType.Engine)]
public struct FSourceControlState
{
	private static bool Filename_IsValid;

	private static int Filename_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:Filename")]
	public string Filename;

	private static bool IsValid_IsValid;

	private static FFieldAddress IsValid_PropertyAddress;

	private static int IsValid_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bIsValid")]
	public bool IsValid;

	private static bool IsUnknown_IsValid;

	private static FFieldAddress IsUnknown_PropertyAddress;

	private static int IsUnknown_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bIsUnknown")]
	public bool IsUnknown;

	private static bool CanCheckIn_IsValid;

	private static FFieldAddress CanCheckIn_PropertyAddress;

	private static int CanCheckIn_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bCanCheckIn")]
	public bool CanCheckIn;

	private static bool CanCheckOut_IsValid;

	private static FFieldAddress CanCheckOut_PropertyAddress;

	private static int CanCheckOut_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bCanCheckOut")]
	public bool CanCheckOut;

	private static bool IsCheckedOut_IsValid;

	private static FFieldAddress IsCheckedOut_PropertyAddress;

	private static int IsCheckedOut_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bIsCheckedOut")]
	public bool IsCheckedOut;

	private static bool IsCurrent_IsValid;

	private static FFieldAddress IsCurrent_PropertyAddress;

	private static int IsCurrent_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bIsCurrent")]
	public bool IsCurrent;

	private static bool IsSourceControlled_IsValid;

	private static FFieldAddress IsSourceControlled_PropertyAddress;

	private static int IsSourceControlled_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bIsSourceControlled")]
	public bool IsSourceControlled;

	private static bool IsAdded_IsValid;

	private static FFieldAddress IsAdded_PropertyAddress;

	private static int IsAdded_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bIsAdded")]
	public bool IsAdded;

	private static bool IsDeleted_IsValid;

	private static FFieldAddress IsDeleted_PropertyAddress;

	private static int IsDeleted_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bIsDeleted")]
	public bool IsDeleted;

	private static bool IsIgnored_IsValid;

	private static FFieldAddress IsIgnored_PropertyAddress;

	private static int IsIgnored_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bIsIgnored")]
	public bool IsIgnored;

	private static bool CanEdit_IsValid;

	private static FFieldAddress CanEdit_PropertyAddress;

	private static int CanEdit_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bCanEdit")]
	public bool CanEdit;

	private static bool CanDelete_IsValid;

	private static FFieldAddress CanDelete_PropertyAddress;

	private static int CanDelete_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bCanDelete")]
	public bool CanDelete;

	private static bool IsModified_IsValid;

	private static FFieldAddress IsModified_PropertyAddress;

	private static int IsModified_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bIsModified")]
	public bool IsModified;

	private static bool CanAdd_IsValid;

	private static FFieldAddress CanAdd_PropertyAddress;

	private static int CanAdd_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bCanAdd")]
	public bool CanAdd;

	private static bool IsConflicted_IsValid;

	private static FFieldAddress IsConflicted_PropertyAddress;

	private static int IsConflicted_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bIsConflicted")]
	public bool IsConflicted;

	private static bool CanRevert_IsValid;

	private static FFieldAddress CanRevert_PropertyAddress;

	private static int CanRevert_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bCanRevert")]
	public bool CanRevert;

	private static bool IsCheckedOutOther_IsValid;

	private static FFieldAddress IsCheckedOutOther_PropertyAddress;

	private static int IsCheckedOutOther_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:bIsCheckedOutOther")]
	public bool IsCheckedOutOther;

	private static bool CheckedOutOther_IsValid;

	private static int CheckedOutOther_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/SourceControl.SourceControlState:CheckedOutOther")]
	public string CheckedOutOther;

	private static bool FSourceControlState_IsValid;

	private static int FSourceControlState_StructSize;

	public FSourceControlState Copy()
	{
		return this;
	}

	public static FSourceControlState FromNative(IntPtr nativeBuffer)
	{
		return new FSourceControlState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceControlState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceControlState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceControlState(nativeBuffer + arrayIndex * FSourceControlState_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceControlState value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceControlState_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceControlState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SourceControl.SourceControlState");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Filename_Offset), Filename);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsValid_Offset), 0, IsValid_PropertyAddress.Address, IsValid);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsUnknown_Offset), 0, IsUnknown_PropertyAddress.Address, IsUnknown);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanCheckIn_Offset), 0, CanCheckIn_PropertyAddress.Address, CanCheckIn);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanCheckOut_Offset), 0, CanCheckOut_PropertyAddress.Address, CanCheckOut);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsCheckedOut_Offset), 0, IsCheckedOut_PropertyAddress.Address, IsCheckedOut);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsCurrent_Offset), 0, IsCurrent_PropertyAddress.Address, IsCurrent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsSourceControlled_Offset), 0, IsSourceControlled_PropertyAddress.Address, IsSourceControlled);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsAdded_Offset), 0, IsAdded_PropertyAddress.Address, IsAdded);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsDeleted_Offset), 0, IsDeleted_PropertyAddress.Address, IsDeleted);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsIgnored_Offset), 0, IsIgnored_PropertyAddress.Address, IsIgnored);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanEdit_Offset), 0, CanEdit_PropertyAddress.Address, CanEdit);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanDelete_Offset), 0, CanDelete_PropertyAddress.Address, CanDelete);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsModified_Offset), 0, IsModified_PropertyAddress.Address, IsModified);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanAdd_Offset), 0, CanAdd_PropertyAddress.Address, CanAdd);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsConflicted_Offset), 0, IsConflicted_PropertyAddress.Address, IsConflicted);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanRevert_Offset), 0, CanRevert_PropertyAddress.Address, CanRevert);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsCheckedOutOther_Offset), 0, IsCheckedOutOther_PropertyAddress.Address, IsCheckedOutOther);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckedOutOther_Offset), CheckedOutOther);
	}

	public FSourceControlState(IntPtr nativeStruct)
	{
		if (!FSourceControlState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SourceControl.SourceControlState");
			Filename = FStringMarshaler.DefaultString;
			IsValid = false;
			IsUnknown = false;
			CanCheckIn = false;
			CanCheckOut = false;
			IsCheckedOut = false;
			IsCurrent = false;
			IsSourceControlled = false;
			IsAdded = false;
			IsDeleted = false;
			IsIgnored = false;
			CanEdit = false;
			CanDelete = false;
			IsModified = false;
			CanAdd = false;
			IsConflicted = false;
			CanRevert = false;
			IsCheckedOutOther = false;
			CheckedOutOther = FStringMarshaler.DefaultString;
		}
		else
		{
			Filename = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Filename_Offset));
			IsValid = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsValid_Offset), 0, IsValid_PropertyAddress.Address);
			IsUnknown = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsUnknown_Offset), 0, IsUnknown_PropertyAddress.Address);
			CanCheckIn = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanCheckIn_Offset), 0, CanCheckIn_PropertyAddress.Address);
			CanCheckOut = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanCheckOut_Offset), 0, CanCheckOut_PropertyAddress.Address);
			IsCheckedOut = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsCheckedOut_Offset), 0, IsCheckedOut_PropertyAddress.Address);
			IsCurrent = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsCurrent_Offset), 0, IsCurrent_PropertyAddress.Address);
			IsSourceControlled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsSourceControlled_Offset), 0, IsSourceControlled_PropertyAddress.Address);
			IsAdded = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsAdded_Offset), 0, IsAdded_PropertyAddress.Address);
			IsDeleted = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsDeleted_Offset), 0, IsDeleted_PropertyAddress.Address);
			IsIgnored = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsIgnored_Offset), 0, IsIgnored_PropertyAddress.Address);
			CanEdit = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanEdit_Offset), 0, CanEdit_PropertyAddress.Address);
			CanDelete = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanDelete_Offset), 0, CanDelete_PropertyAddress.Address);
			IsModified = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsModified_Offset), 0, IsModified_PropertyAddress.Address);
			CanAdd = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanAdd_Offset), 0, CanAdd_PropertyAddress.Address);
			IsConflicted = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsConflicted_Offset), 0, IsConflicted_PropertyAddress.Address);
			CanRevert = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanRevert_Offset), 0, CanRevert_PropertyAddress.Address);
			IsCheckedOutOther = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsCheckedOutOther_Offset), 0, IsCheckedOutOther_PropertyAddress.Address);
			CheckedOutOther = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckedOutOther_Offset));
		}
	}

	static FSourceControlState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceControlState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceControlState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SourceControl.SourceControlState");
		FSourceControlState_StructSize = NativeReflection.GetStructSize(intPtr);
		Filename_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filename");
		Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_PropertyAddress, intPtr, "bIsValid");
		IsValid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsValid");
		IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsUnknown_PropertyAddress, intPtr, "bIsUnknown");
		IsUnknown_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsUnknown");
		IsUnknown_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsUnknown", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanCheckIn_PropertyAddress, intPtr, "bCanCheckIn");
		CanCheckIn_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanCheckIn");
		CanCheckIn_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanCheckIn", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanCheckOut_PropertyAddress, intPtr, "bCanCheckOut");
		CanCheckOut_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanCheckOut");
		CanCheckOut_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanCheckOut", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCheckedOut_PropertyAddress, intPtr, "bIsCheckedOut");
		IsCheckedOut_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsCheckedOut");
		IsCheckedOut_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsCheckedOut", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCurrent_PropertyAddress, intPtr, "bIsCurrent");
		IsCurrent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsCurrent");
		IsCurrent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsCurrent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSourceControlled_PropertyAddress, intPtr, "bIsSourceControlled");
		IsSourceControlled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSourceControlled");
		IsSourceControlled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSourceControlled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAdded_PropertyAddress, intPtr, "bIsAdded");
		IsAdded_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsAdded");
		IsAdded_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsAdded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDeleted_PropertyAddress, intPtr, "bIsDeleted");
		IsDeleted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsDeleted");
		IsDeleted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsDeleted", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsIgnored_PropertyAddress, intPtr, "bIsIgnored");
		IsIgnored_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsIgnored");
		IsIgnored_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsIgnored", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanEdit_PropertyAddress, intPtr, "bCanEdit");
		CanEdit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanEdit");
		CanEdit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanEdit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanDelete_PropertyAddress, intPtr, "bCanDelete");
		CanDelete_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanDelete");
		CanDelete_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanDelete", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsModified_PropertyAddress, intPtr, "bIsModified");
		IsModified_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsModified");
		IsModified_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsModified", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanAdd_PropertyAddress, intPtr, "bCanAdd");
		CanAdd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanAdd");
		CanAdd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanAdd", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsConflicted_PropertyAddress, intPtr, "bIsConflicted");
		IsConflicted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsConflicted");
		IsConflicted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsConflicted", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanRevert_PropertyAddress, intPtr, "bCanRevert");
		CanRevert_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanRevert");
		CanRevert_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanRevert", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCheckedOutOther_PropertyAddress, intPtr, "bIsCheckedOutOther");
		IsCheckedOutOther_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsCheckedOutOther");
		IsCheckedOutOther_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsCheckedOutOther", Classes.FBoolProperty);
		CheckedOutOther_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheckedOutOther");
		CheckedOutOther_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheckedOutOther", Classes.FStrProperty);
		FSourceControlState_IsValid = intPtr != IntPtr.Zero && Filename_IsValid && IsValid_IsValid && IsUnknown_IsValid && CanCheckIn_IsValid && CanCheckOut_IsValid && IsCheckedOut_IsValid && IsCurrent_IsValid && IsSourceControlled_IsValid && IsAdded_IsValid && IsDeleted_IsValid && IsIgnored_IsValid && CanEdit_IsValid && CanDelete_IsValid && IsModified_IsValid && CanAdd_IsValid && IsConflicted_IsValid && CanRevert_IsValid && IsCheckedOutOther_IsValid && CheckedOutOther_IsValid;
		NativeReflection.LogStructIsValid("/Script/SourceControl.SourceControlState", FSourceControlState_IsValid);
	}
}
