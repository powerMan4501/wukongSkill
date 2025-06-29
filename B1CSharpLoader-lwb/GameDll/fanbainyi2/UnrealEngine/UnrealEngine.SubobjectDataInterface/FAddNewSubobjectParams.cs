using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.SubobjectDataInterface;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SubobjectDataInterface.AddNewSubobjectParams", "SubobjectDataInterface", UnrealModuleType.Engine)]
public struct FAddNewSubobjectParams
{
	private static bool ParentHandle_IsValid;

	private static int ParentHandle_Offset;

	[UProperty(Flags = (PropFlags)6755399441055748uL)]
	[UMetaPath("/Script/SubobjectDataInterface.AddNewSubobjectParams:ParentHandle")]
	public FSubobjectDataHandle ParentHandle;

	private static bool NewClass_IsValid;

	private static int NewClass_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/SubobjectDataInterface.AddNewSubobjectParams:NewClass")]
	public TSubclassOf<UObject> NewClass;

	private static bool BlueprintContext_IsValid;

	private static int BlueprintContext_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/SubobjectDataInterface.AddNewSubobjectParams:BlueprintContext")]
	public UBlueprint BlueprintContext;

	private static bool SkipMarkBlueprintModified_IsValid;

	private static FFieldAddress SkipMarkBlueprintModified_PropertyAddress;

	private static int SkipMarkBlueprintModified_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/SubobjectDataInterface.AddNewSubobjectParams:bSkipMarkBlueprintModified")]
	public bool SkipMarkBlueprintModified;

	private static bool ConformTransformToParent_IsValid;

	private static FFieldAddress ConformTransformToParent_PropertyAddress;

	private static int ConformTransformToParent_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/SubobjectDataInterface.AddNewSubobjectParams:bConformTransformToParent")]
	public bool ConformTransformToParent;

	private static bool FAddNewSubobjectParams_IsValid;

	private static int FAddNewSubobjectParams_StructSize;

	public FAddNewSubobjectParams Copy()
	{
		return this;
	}

	public static FAddNewSubobjectParams FromNative(IntPtr nativeBuffer)
	{
		return new FAddNewSubobjectParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAddNewSubobjectParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAddNewSubobjectParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAddNewSubobjectParams(nativeBuffer + arrayIndex * FAddNewSubobjectParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAddNewSubobjectParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAddNewSubobjectParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAddNewSubobjectParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SubobjectDataInterface.AddNewSubobjectParams");
			return;
		}
		FSubobjectDataHandle.ToNative(IntPtr.Add(nativeStruct, ParentHandle_Offset), ParentHandle);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, NewClass_Offset), NewClass);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(nativeStruct, BlueprintContext_Offset), BlueprintContext);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SkipMarkBlueprintModified_Offset), 0, SkipMarkBlueprintModified_PropertyAddress.Address, SkipMarkBlueprintModified);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ConformTransformToParent_Offset), 0, ConformTransformToParent_PropertyAddress.Address, ConformTransformToParent);
	}

	public FAddNewSubobjectParams(IntPtr nativeStruct)
	{
		if (!FAddNewSubobjectParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SubobjectDataInterface.AddNewSubobjectParams");
			ParentHandle = default(FSubobjectDataHandle);
			NewClass = default(TSubclassOf<UObject>);
			BlueprintContext = null;
			SkipMarkBlueprintModified = false;
			ConformTransformToParent = false;
		}
		else
		{
			ParentHandle = FSubobjectDataHandle.FromNative(IntPtr.Add(nativeStruct, ParentHandle_Offset));
			NewClass = TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, NewClass_Offset));
			BlueprintContext = UObjectMarshaler<UBlueprint>.FromNative(IntPtr.Add(nativeStruct, BlueprintContext_Offset));
			SkipMarkBlueprintModified = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SkipMarkBlueprintModified_Offset), 0, SkipMarkBlueprintModified_PropertyAddress.Address);
			ConformTransformToParent = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ConformTransformToParent_Offset), 0, ConformTransformToParent_PropertyAddress.Address);
		}
	}

	static FAddNewSubobjectParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAddNewSubobjectParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAddNewSubobjectParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SubobjectDataInterface.AddNewSubobjectParams");
		FAddNewSubobjectParams_StructSize = NativeReflection.GetStructSize(intPtr);
		ParentHandle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParentHandle");
		ParentHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParentHandle", Classes.FStructProperty);
		NewClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewClass");
		NewClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewClass", Classes.FClassProperty);
		BlueprintContext_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlueprintContext");
		BlueprintContext_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlueprintContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipMarkBlueprintModified_PropertyAddress, intPtr, "bSkipMarkBlueprintModified");
		SkipMarkBlueprintModified_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipMarkBlueprintModified");
		SkipMarkBlueprintModified_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipMarkBlueprintModified", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ConformTransformToParent_PropertyAddress, intPtr, "bConformTransformToParent");
		ConformTransformToParent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bConformTransformToParent");
		ConformTransformToParent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bConformTransformToParent", Classes.FBoolProperty);
		FAddNewSubobjectParams_IsValid = intPtr != IntPtr.Zero && ParentHandle_IsValid && NewClass_IsValid && BlueprintContext_IsValid && SkipMarkBlueprintModified_IsValid && ConformTransformToParent_IsValid;
		NativeReflection.LogStructIsValid("/Script/SubobjectDataInterface.AddNewSubobjectParams", FAddNewSubobjectParams_IsValid);
	}
}
