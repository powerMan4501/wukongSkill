using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGActorSelectorSettings", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGActorSelectorSettings
{
	private static bool ActorFilter_IsValid;

	private static FFieldAddress ActorFilter_PropertyAddress;

	private static int ActorFilter_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGActorSelectorSettings:ActorFilter")]
	public EPCGActorFilter ActorFilter;

	private static bool MustOverlapSelf_IsValid;

	private static FFieldAddress MustOverlapSelf_PropertyAddress;

	private static int MustOverlapSelf_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGActorSelectorSettings:bMustOverlapSelf")]
	public bool MustOverlapSelf;

	private static bool IncludeChildren_IsValid;

	private static FFieldAddress IncludeChildren_PropertyAddress;

	private static int IncludeChildren_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGActorSelectorSettings:bIncludeChildren")]
	public bool IncludeChildren;

	private static bool DisableFilter_IsValid;

	private static FFieldAddress DisableFilter_PropertyAddress;

	private static int DisableFilter_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGActorSelectorSettings:bDisableFilter")]
	public bool DisableFilter;

	private static bool ActorSelection_IsValid;

	private static FFieldAddress ActorSelection_PropertyAddress;

	private static int ActorSelection_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGActorSelectorSettings:ActorSelection")]
	public EPCGActorSelection ActorSelection;

	private static bool ActorSelectionTag_IsValid;

	private static int ActorSelectionTag_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGActorSelectorSettings:ActorSelectionTag")]
	public FName ActorSelectionTag;

	private static bool ActorSelectionClass_IsValid;

	private static int ActorSelectionClass_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/PCG.PCGActorSelectorSettings:ActorSelectionClass")]
	public TSubclassOf<AActor> ActorSelectionClass;

	private static bool SelectMultiple_IsValid;

	private static FFieldAddress SelectMultiple_PropertyAddress;

	private static int SelectMultiple_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGActorSelectorSettings:bSelectMultiple")]
	public bool SelectMultiple;

	private static bool IgnoreSelfAndChildren_IsValid;

	private static FFieldAddress IgnoreSelfAndChildren_PropertyAddress;

	private static int IgnoreSelfAndChildren_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGActorSelectorSettings:bIgnoreSelfAndChildren")]
	public bool IgnoreSelfAndChildren;

	private static bool FPCGActorSelectorSettings_IsValid;

	private static int FPCGActorSelectorSettings_StructSize;

	public FPCGActorSelectorSettings Copy()
	{
		return this;
	}

	public static FPCGActorSelectorSettings FromNative(IntPtr nativeBuffer)
	{
		return new FPCGActorSelectorSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGActorSelectorSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGActorSelectorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGActorSelectorSettings(nativeBuffer + arrayIndex * FPCGActorSelectorSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGActorSelectorSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGActorSelectorSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGActorSelectorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGActorSelectorSettings");
			return;
		}
		EnumMarshaler<EPCGActorFilter>.ToNative(IntPtr.Add(nativeStruct, ActorFilter_Offset), 0, ActorFilter_PropertyAddress.Address, ActorFilter);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MustOverlapSelf_Offset), 0, MustOverlapSelf_PropertyAddress.Address, MustOverlapSelf);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeChildren_Offset), 0, IncludeChildren_PropertyAddress.Address, IncludeChildren);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DisableFilter_Offset), 0, DisableFilter_PropertyAddress.Address, DisableFilter);
		EnumMarshaler<EPCGActorSelection>.ToNative(IntPtr.Add(nativeStruct, ActorSelection_Offset), 0, ActorSelection_PropertyAddress.Address, ActorSelection);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ActorSelectionTag_Offset), ActorSelectionTag);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, ActorSelectionClass_Offset), ActorSelectionClass);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SelectMultiple_Offset), 0, SelectMultiple_PropertyAddress.Address, SelectMultiple);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreSelfAndChildren_Offset), 0, IgnoreSelfAndChildren_PropertyAddress.Address, IgnoreSelfAndChildren);
	}

	public FPCGActorSelectorSettings(IntPtr nativeStruct)
	{
		if (!FPCGActorSelectorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGActorSelectorSettings");
			ActorFilter = EPCGActorFilter.Self;
			MustOverlapSelf = false;
			IncludeChildren = false;
			DisableFilter = false;
			ActorSelection = EPCGActorSelection.ByTag;
			ActorSelectionTag = default(FName);
			ActorSelectionClass = default(TSubclassOf<AActor>);
			SelectMultiple = false;
			IgnoreSelfAndChildren = false;
		}
		else
		{
			ActorFilter = EnumMarshaler<EPCGActorFilter>.FromNative(IntPtr.Add(nativeStruct, ActorFilter_Offset), 0, ActorFilter_PropertyAddress.Address);
			MustOverlapSelf = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MustOverlapSelf_Offset), 0, MustOverlapSelf_PropertyAddress.Address);
			IncludeChildren = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeChildren_Offset), 0, IncludeChildren_PropertyAddress.Address);
			DisableFilter = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DisableFilter_Offset), 0, DisableFilter_PropertyAddress.Address);
			ActorSelection = EnumMarshaler<EPCGActorSelection>.FromNative(IntPtr.Add(nativeStruct, ActorSelection_Offset), 0, ActorSelection_PropertyAddress.Address);
			ActorSelectionTag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ActorSelectionTag_Offset));
			ActorSelectionClass = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, ActorSelectionClass_Offset));
			SelectMultiple = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SelectMultiple_Offset), 0, SelectMultiple_PropertyAddress.Address);
			IgnoreSelfAndChildren = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreSelfAndChildren_Offset), 0, IgnoreSelfAndChildren_PropertyAddress.Address);
		}
	}

	static FPCGActorSelectorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGActorSelectorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGActorSelectorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGActorSelectorSettings");
		FPCGActorSelectorSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ActorFilter_PropertyAddress, intPtr, "ActorFilter");
		ActorFilter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorFilter");
		ActorFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorFilter", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref MustOverlapSelf_PropertyAddress, intPtr, "bMustOverlapSelf");
		MustOverlapSelf_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMustOverlapSelf");
		MustOverlapSelf_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMustOverlapSelf", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeChildren_PropertyAddress, intPtr, "bIncludeChildren");
		IncludeChildren_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeChildren");
		IncludeChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableFilter_PropertyAddress, intPtr, "bDisableFilter");
		DisableFilter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableFilter");
		DisableFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableFilter", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorSelection_PropertyAddress, intPtr, "ActorSelection");
		ActorSelection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorSelection");
		ActorSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorSelection", Classes.FEnumProperty);
		ActorSelectionTag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorSelectionTag");
		ActorSelectionTag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorSelectionTag", Classes.FNameProperty);
		ActorSelectionClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorSelectionClass");
		ActorSelectionClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorSelectionClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectMultiple_PropertyAddress, intPtr, "bSelectMultiple");
		SelectMultiple_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSelectMultiple");
		SelectMultiple_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSelectMultiple", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreSelfAndChildren_PropertyAddress, intPtr, "bIgnoreSelfAndChildren");
		IgnoreSelfAndChildren_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreSelfAndChildren");
		IgnoreSelfAndChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreSelfAndChildren", Classes.FBoolProperty);
		FPCGActorSelectorSettings_IsValid = intPtr != IntPtr.Zero && ActorFilter_IsValid && MustOverlapSelf_IsValid && IncludeChildren_IsValid && DisableFilter_IsValid && ActorSelection_IsValid && ActorSelectionTag_IsValid && ActorSelectionClass_IsValid && SelectMultiple_IsValid && IgnoreSelfAndChildren_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGActorSelectorSettings", FPCGActorSelectorSettings_IsValid);
	}
}
