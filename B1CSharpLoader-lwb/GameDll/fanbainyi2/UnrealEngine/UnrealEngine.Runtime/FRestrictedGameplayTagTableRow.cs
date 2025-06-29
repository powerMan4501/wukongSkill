using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GameplayTags.RestrictedGameplayTagTableRow", "GameplayTags", UnrealModuleType.Engine)]
public struct FRestrictedGameplayTagTableRow
{
	private static bool Tag_IsValid;

	private static int Tag_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GameplayTags.GameplayTagTableRow:Tag")]
	public FName Tag;

	private static bool DevComment_IsValid;

	private static int DevComment_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/GameplayTags.GameplayTagTableRow:DevComment")]
	public string DevComment;

	private static bool AllowNonRestrictedChildren_IsValid;

	private static FFieldAddress AllowNonRestrictedChildren_PropertyAddress;

	private static int AllowNonRestrictedChildren_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GameplayTags.RestrictedGameplayTagTableRow:bAllowNonRestrictedChildren")]
	public bool AllowNonRestrictedChildren;

	private static bool FRestrictedGameplayTagTableRow_IsValid;

	private static int FRestrictedGameplayTagTableRow_StructSize;

	public FRestrictedGameplayTagTableRow Copy()
	{
		return this;
	}

	public static FRestrictedGameplayTagTableRow FromNative(IntPtr nativeBuffer)
	{
		return new FRestrictedGameplayTagTableRow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRestrictedGameplayTagTableRow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRestrictedGameplayTagTableRow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRestrictedGameplayTagTableRow(nativeBuffer + arrayIndex * FRestrictedGameplayTagTableRow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRestrictedGameplayTagTableRow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRestrictedGameplayTagTableRow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRestrictedGameplayTagTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayTags.RestrictedGameplayTagTableRow");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowNonRestrictedChildren_Offset), 0, AllowNonRestrictedChildren_PropertyAddress.Address, AllowNonRestrictedChildren);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Tag_Offset), Tag);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DevComment_Offset), DevComment);
	}

	public FRestrictedGameplayTagTableRow(IntPtr nativeStruct)
	{
		if (!FRestrictedGameplayTagTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayTags.RestrictedGameplayTagTableRow");
			AllowNonRestrictedChildren = false;
			Tag = default(FName);
			DevComment = FStringMarshaler.DefaultString;
		}
		else
		{
			AllowNonRestrictedChildren = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowNonRestrictedChildren_Offset), 0, AllowNonRestrictedChildren_PropertyAddress.Address);
			Tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Tag_Offset));
			DevComment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DevComment_Offset));
		}
	}

	static FRestrictedGameplayTagTableRow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRestrictedGameplayTagTableRow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRestrictedGameplayTagTableRow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayTags.RestrictedGameplayTagTableRow");
		FRestrictedGameplayTagTableRow_StructSize = NativeReflection.GetStructSize(intPtr);
		Tag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tag");
		Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tag", Classes.FNameProperty);
		DevComment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DevComment");
		DevComment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DevComment", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowNonRestrictedChildren_PropertyAddress, intPtr, "bAllowNonRestrictedChildren");
		AllowNonRestrictedChildren_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowNonRestrictedChildren");
		AllowNonRestrictedChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowNonRestrictedChildren", Classes.FBoolProperty);
		FRestrictedGameplayTagTableRow_IsValid = intPtr != IntPtr.Zero && AllowNonRestrictedChildren_IsValid && Tag_IsValid && DevComment_IsValid;
		NativeReflection.LogStructIsValid("/Script/GameplayTags.RestrictedGameplayTagTableRow", FRestrictedGameplayTagTableRow_IsValid);
	}
}
