using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.MappingQueryIssue", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public struct FMappingQueryIssue
{
	private static bool Issue_IsValid;

	private static FFieldAddress Issue_PropertyAddress;

	private static int Issue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/EnhancedInput.MappingQueryIssue:Issue")]
	public EMappingQueryIssueFlag Issue;

	private static bool BlockingContext_IsValid;

	private static int BlockingContext_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/EnhancedInput.MappingQueryIssue:BlockingContext")]
	public UInputMappingContext BlockingContext;

	private static bool BlockingAction_IsValid;

	private static int BlockingAction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/EnhancedInput.MappingQueryIssue:BlockingAction")]
	public UInputAction BlockingAction;

	private static bool FMappingQueryIssue_IsValid;

	private static int FMappingQueryIssue_StructSize;

	public FMappingQueryIssue Copy()
	{
		return this;
	}

	public static FMappingQueryIssue FromNative(IntPtr nativeBuffer)
	{
		return new FMappingQueryIssue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMappingQueryIssue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMappingQueryIssue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMappingQueryIssue(nativeBuffer + arrayIndex * FMappingQueryIssue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMappingQueryIssue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMappingQueryIssue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMappingQueryIssue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.MappingQueryIssue");
			return;
		}
		EnumMarshaler<EMappingQueryIssueFlag>.ToNative(IntPtr.Add(nativeStruct, Issue_Offset), 0, Issue_PropertyAddress.Address, Issue);
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(nativeStruct, BlockingContext_Offset), BlockingContext);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(nativeStruct, BlockingAction_Offset), BlockingAction);
	}

	public FMappingQueryIssue(IntPtr nativeStruct)
	{
		if (!FMappingQueryIssue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.MappingQueryIssue");
			Issue = EMappingQueryIssueFlag.NoIssue;
			BlockingContext = null;
			BlockingAction = null;
		}
		else
		{
			Issue = EnumMarshaler<EMappingQueryIssueFlag>.FromNative(IntPtr.Add(nativeStruct, Issue_Offset), 0, Issue_PropertyAddress.Address);
			BlockingContext = UObjectMarshaler<UInputMappingContext>.FromNative(IntPtr.Add(nativeStruct, BlockingContext_Offset));
			BlockingAction = UObjectMarshaler<UInputAction>.FromNative(IntPtr.Add(nativeStruct, BlockingAction_Offset));
		}
	}

	static FMappingQueryIssue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMappingQueryIssue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMappingQueryIssue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EnhancedInput.MappingQueryIssue");
		FMappingQueryIssue_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Issue_PropertyAddress, intPtr, "Issue");
		Issue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Issue");
		Issue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Issue", Classes.FEnumProperty);
		BlockingContext_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlockingContext");
		BlockingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlockingContext", Classes.FObjectProperty);
		BlockingAction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlockingAction");
		BlockingAction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlockingAction", Classes.FObjectProperty);
		FMappingQueryIssue_IsValid = intPtr != IntPtr.Zero && Issue_IsValid && BlockingContext_IsValid && BlockingAction_IsValid;
		NativeReflection.LogStructIsValid("/Script/EnhancedInput.MappingQueryIssue", FMappingQueryIssue_IsValid);
	}
}
