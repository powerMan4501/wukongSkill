using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.ToolMenuSection", "ToolMenus", UnrealModuleType.Engine)]
public struct FToolMenuSection
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuSection:Name")]
	public FName Name;

	private static bool Owner_IsValid;

	private static int Owner_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuSection:Owner")]
	public FToolMenuOwner Owner;

	private static bool Blocks_IsValid;

	private static FFieldAddress Blocks_PropertyAddress;

	private static int Blocks_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuSection:Blocks")]
	public List<FToolMenuEntry> Blocks;

	private static bool InsertPosition_IsValid;

	private static int InsertPosition_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuSection:InsertPosition")]
	public FToolMenuInsert InsertPosition;

	private static bool Context_IsValid;

	private static int Context_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuSection:Context")]
	public FToolMenuContext Context;

	private static bool ToolMenuSectionDynamic_IsValid;

	private static int ToolMenuSectionDynamic_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuSection:ToolMenuSectionDynamic")]
	public UToolMenuSectionDynamic ToolMenuSectionDynamic;

	private static bool FToolMenuSection_IsValid;

	private static int FToolMenuSection_StructSize;

	public FToolMenuSection Copy()
	{
		FToolMenuSection result = this;
		if (Blocks != null)
		{
			result.Blocks = new List<FToolMenuEntry>(Blocks);
		}
		return result;
	}

	public static FToolMenuSection FromNative(IntPtr nativeBuffer)
	{
		return new FToolMenuSection(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FToolMenuSection value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FToolMenuSection FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FToolMenuSection(nativeBuffer + arrayIndex * FToolMenuSection_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FToolMenuSection value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FToolMenuSection_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FToolMenuSection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuSection");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		FToolMenuOwner.ToNative(IntPtr.Add(nativeStruct, Owner_Offset), Owner);
		new TArrayCopyMarshaler<FToolMenuEntry>(1, Blocks_PropertyAddress, CachedMarshalingDelegates<FToolMenuEntry, FToolMenuEntry>.FromNative, CachedMarshalingDelegates<FToolMenuEntry, FToolMenuEntry>.ToNative).ToNative(IntPtr.Add(nativeStruct, Blocks_Offset), Blocks);
		FToolMenuInsert.ToNative(IntPtr.Add(nativeStruct, InsertPosition_Offset), InsertPosition);
		FToolMenuContext.ToNative(IntPtr.Add(nativeStruct, Context_Offset), Context);
		UObjectMarshaler<UToolMenuSectionDynamic>.ToNative(IntPtr.Add(nativeStruct, ToolMenuSectionDynamic_Offset), ToolMenuSectionDynamic);
	}

	public FToolMenuSection(IntPtr nativeStruct)
	{
		if (!FToolMenuSection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuSection");
			Name = default(FName);
			Owner = default(FToolMenuOwner);
			Blocks = null;
			InsertPosition = default(FToolMenuInsert);
			Context = default(FToolMenuContext);
			ToolMenuSectionDynamic = null;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Owner = FToolMenuOwner.FromNative(IntPtr.Add(nativeStruct, Owner_Offset));
			Blocks = new TArrayCopyMarshaler<FToolMenuEntry>(1, Blocks_PropertyAddress, CachedMarshalingDelegates<FToolMenuEntry, FToolMenuEntry>.FromNative, CachedMarshalingDelegates<FToolMenuEntry, FToolMenuEntry>.ToNative).FromNative(IntPtr.Add(nativeStruct, Blocks_Offset));
			InsertPosition = FToolMenuInsert.FromNative(IntPtr.Add(nativeStruct, InsertPosition_Offset));
			Context = FToolMenuContext.FromNative(IntPtr.Add(nativeStruct, Context_Offset));
			ToolMenuSectionDynamic = UObjectMarshaler<UToolMenuSectionDynamic>.FromNative(IntPtr.Add(nativeStruct, ToolMenuSectionDynamic_Offset));
		}
	}

	static FToolMenuSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FToolMenuSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FToolMenuSection));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ToolMenus.ToolMenuSection");
		FToolMenuSection_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Owner_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Owner");
		Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Owner", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Blocks_PropertyAddress, intPtr, "Blocks");
		Blocks_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Blocks");
		Blocks_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Blocks", Classes.FArrayProperty);
		InsertPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InsertPosition");
		InsertPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InsertPosition", Classes.FStructProperty);
		Context_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Context");
		Context_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Context", Classes.FStructProperty);
		ToolMenuSectionDynamic_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ToolMenuSectionDynamic");
		ToolMenuSectionDynamic_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ToolMenuSectionDynamic", Classes.FObjectProperty);
		FToolMenuSection_IsValid = intPtr != IntPtr.Zero && Name_IsValid && Owner_IsValid && Blocks_IsValid && InsertPosition_IsValid && Context_IsValid && ToolMenuSectionDynamic_IsValid;
		NativeReflection.LogStructIsValid("/Script/ToolMenus.ToolMenuSection", FToolMenuSection_IsValid);
	}
}
