using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.DistributionWhiteListItem", "FuncLibEditor", UnrealModuleType.Game)]
public struct FDistributionWhiteListItem
{
	private static bool WhiteListActorClass_IsValid;

	private static int WhiteListActorClass_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.DistributionWhiteListItem:WhiteListActorClass")]
	public FSoftClassPath WhiteListActorClass;

	private static bool ExcludeActorNameKeywords_IsValid;

	private static int ExcludeActorNameKeywords_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.DistributionWhiteListItem:ExcludeActorNameKeywords")]
	public string ExcludeActorNameKeywords;

	private static bool FDistributionWhiteListItem_IsValid;

	private static int FDistributionWhiteListItem_StructSize;

	public FDistributionWhiteListItem Copy()
	{
		return this;
	}

	public static FDistributionWhiteListItem FromNative(IntPtr nativeBuffer)
	{
		return new FDistributionWhiteListItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDistributionWhiteListItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDistributionWhiteListItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDistributionWhiteListItem(nativeBuffer + arrayIndex * FDistributionWhiteListItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDistributionWhiteListItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDistributionWhiteListItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDistributionWhiteListItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.DistributionWhiteListItem");
			return;
		}
		FSoftClassPath.ToNative(IntPtr.Add(nativeStruct, WhiteListActorClass_Offset), WhiteListActorClass);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ExcludeActorNameKeywords_Offset), ExcludeActorNameKeywords);
	}

	public FDistributionWhiteListItem(IntPtr nativeStruct)
	{
		if (!FDistributionWhiteListItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.DistributionWhiteListItem");
			WhiteListActorClass = default(FSoftClassPath);
			ExcludeActorNameKeywords = FStringMarshaler.DefaultString;
		}
		else
		{
			WhiteListActorClass = FSoftClassPath.FromNative(IntPtr.Add(nativeStruct, WhiteListActorClass_Offset));
			ExcludeActorNameKeywords = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ExcludeActorNameKeywords_Offset));
		}
	}

	static FDistributionWhiteListItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDistributionWhiteListItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDistributionWhiteListItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.DistributionWhiteListItem");
		FDistributionWhiteListItem_StructSize = NativeReflection.GetStructSize(intPtr);
		WhiteListActorClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WhiteListActorClass");
		WhiteListActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WhiteListActorClass", Classes.FStructProperty);
		ExcludeActorNameKeywords_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExcludeActorNameKeywords");
		ExcludeActorNameKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExcludeActorNameKeywords", Classes.FStrProperty);
		FDistributionWhiteListItem_IsValid = intPtr != IntPtr.Zero && WhiteListActorClass_IsValid && ExcludeActorNameKeywords_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.DistributionWhiteListItem", FDistributionWhiteListItem_IsValid);
	}
}
