using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.AnimationAttributeIdentifierExtensions", "Engine", UnrealModuleType.Engine)]
public class UAnimationAttributeIdentifierExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsValid_IsValid;

	private static IntPtr IsValid_FunctionAddress;

	private static int IsValid_ParamsSize;

	private static bool IsValid_Identifier_IsValid;

	private static FFieldAddress IsValid_Identifier_PropertyAddress;

	private static int IsValid_Identifier_Offset;

	private static bool IsValid_ReturnValue_IsValid;

	private static FFieldAddress IsValid_ReturnValue_PropertyAddress;

	private static int IsValid_ReturnValue_Offset;

	private static bool CreateAttributeIdentifier_IsValid;

	private static IntPtr CreateAttributeIdentifier_FunctionAddress;

	private static int CreateAttributeIdentifier_ParamsSize;

	private static bool CreateAttributeIdentifier_AnimationAsset_IsValid;

	private static FFieldAddress CreateAttributeIdentifier_AnimationAsset_PropertyAddress;

	private static int CreateAttributeIdentifier_AnimationAsset_Offset;

	private static bool CreateAttributeIdentifier_AttributeName_IsValid;

	private static FFieldAddress CreateAttributeIdentifier_AttributeName_PropertyAddress;

	private static int CreateAttributeIdentifier_AttributeName_Offset;

	private static bool CreateAttributeIdentifier_BoneName_IsValid;

	private static FFieldAddress CreateAttributeIdentifier_BoneName_PropertyAddress;

	private static int CreateAttributeIdentifier_BoneName_Offset;

	private static bool CreateAttributeIdentifier_AttributeType_IsValid;

	private static FFieldAddress CreateAttributeIdentifier_AttributeType_PropertyAddress;

	private static int CreateAttributeIdentifier_AttributeType_Offset;

	private static bool CreateAttributeIdentifier_bValidateExistsOnAsset_IsValid;

	private static FFieldAddress CreateAttributeIdentifier_bValidateExistsOnAsset_PropertyAddress;

	private static int CreateAttributeIdentifier_bValidateExistsOnAsset_Offset;

	private static bool CreateAttributeIdentifier_ReturnValue_IsValid;

	private static FFieldAddress CreateAttributeIdentifier_ReturnValue_PropertyAddress;

	private static int CreateAttributeIdentifier_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.AnimationAttributeIdentifierExtensions:IsValid")]
	public unsafe static bool IsValid(ref FAnimationAttributeIdentifier Identifier)
	{
		if (!IsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationAttributeIdentifierExtensions:IsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsValid_Identifier_PropertyAddress.Address, intPtr);
		FAnimationAttributeIdentifier.ToNative(IntPtr.Add(intPtr, IsValid_Identifier_Offset), 0, IsValid_Identifier_PropertyAddress.Address, Identifier);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValid_FunctionAddress, intPtr, IsValid_ParamsSize);
		Identifier = FAnimationAttributeIdentifier.FromNative(IntPtr.Add(intPtr, IsValid_Identifier_Offset), 0, IsValid_Identifier_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(IsValid_Identifier_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_ReturnValue_Offset), 0, IsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Engine.AnimationAttributeIdentifierExtensions:CreateAttributeIdentifier")]
	public unsafe static FAnimationAttributeIdentifier CreateAttributeIdentifier(UAnimationAsset AnimationAsset, FName AttributeName, FName BoneName, UScriptStruct AttributeType, bool bValidateExistsOnAsset = false)
	{
		if (!CreateAttributeIdentifier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationAttributeIdentifierExtensions:CreateAttributeIdentifier");
			return default(FAnimationAttributeIdentifier);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateAttributeIdentifier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateAttributeIdentifier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(intPtr, CreateAttributeIdentifier_AnimationAsset_Offset), 0, CreateAttributeIdentifier_AnimationAsset_PropertyAddress.Address, AnimationAsset);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateAttributeIdentifier_AttributeName_Offset), 0, CreateAttributeIdentifier_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateAttributeIdentifier_BoneName_Offset), 0, CreateAttributeIdentifier_BoneName_PropertyAddress.Address, BoneName);
		UObjectMarshaler<UScriptStruct>.ToNative(IntPtr.Add(intPtr, CreateAttributeIdentifier_AttributeType_Offset), 0, CreateAttributeIdentifier_AttributeType_PropertyAddress.Address, AttributeType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateAttributeIdentifier_bValidateExistsOnAsset_Offset), 0, CreateAttributeIdentifier_bValidateExistsOnAsset_PropertyAddress.Address, bValidateExistsOnAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateAttributeIdentifier_FunctionAddress, intPtr, CreateAttributeIdentifier_ParamsSize);
		FAnimationAttributeIdentifier result = FAnimationAttributeIdentifier.FromNative(IntPtr.Add(intPtr, CreateAttributeIdentifier_ReturnValue_Offset), 0, CreateAttributeIdentifier_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateAttributeIdentifier_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAnimationAttributeIdentifierExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimationAttributeIdentifierExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimationAttributeIdentifierExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.AnimationAttributeIdentifierExtensions");
		IsValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValid");
		IsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_Identifier_PropertyAddress, IsValid_FunctionAddress, "Identifier");
		IsValid_Identifier_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "Identifier");
		IsValid_Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "Identifier", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_ReturnValue_PropertyAddress, IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_IsValid = IsValid_FunctionAddress != IntPtr.Zero && IsValid_Identifier_IsValid && IsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationAttributeIdentifierExtensions:IsValid", IsValid_IsValid);
		CreateAttributeIdentifier_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateAttributeIdentifier");
		CreateAttributeIdentifier_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateAttributeIdentifier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateAttributeIdentifier_AnimationAsset_PropertyAddress, CreateAttributeIdentifier_FunctionAddress, "AnimationAsset");
		CreateAttributeIdentifier_AnimationAsset_Offset = NativeReflectionCached.GetPropertyOffset(CreateAttributeIdentifier_FunctionAddress, "AnimationAsset");
		CreateAttributeIdentifier_AnimationAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAttributeIdentifier_FunctionAddress, "AnimationAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAttributeIdentifier_AttributeName_PropertyAddress, CreateAttributeIdentifier_FunctionAddress, "AttributeName");
		CreateAttributeIdentifier_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateAttributeIdentifier_FunctionAddress, "AttributeName");
		CreateAttributeIdentifier_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAttributeIdentifier_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAttributeIdentifier_BoneName_PropertyAddress, CreateAttributeIdentifier_FunctionAddress, "BoneName");
		CreateAttributeIdentifier_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(CreateAttributeIdentifier_FunctionAddress, "BoneName");
		CreateAttributeIdentifier_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAttributeIdentifier_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAttributeIdentifier_AttributeType_PropertyAddress, CreateAttributeIdentifier_FunctionAddress, "AttributeType");
		CreateAttributeIdentifier_AttributeType_Offset = NativeReflectionCached.GetPropertyOffset(CreateAttributeIdentifier_FunctionAddress, "AttributeType");
		CreateAttributeIdentifier_AttributeType_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAttributeIdentifier_FunctionAddress, "AttributeType", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAttributeIdentifier_bValidateExistsOnAsset_PropertyAddress, CreateAttributeIdentifier_FunctionAddress, "bValidateExistsOnAsset");
		CreateAttributeIdentifier_bValidateExistsOnAsset_Offset = NativeReflectionCached.GetPropertyOffset(CreateAttributeIdentifier_FunctionAddress, "bValidateExistsOnAsset");
		CreateAttributeIdentifier_bValidateExistsOnAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAttributeIdentifier_FunctionAddress, "bValidateExistsOnAsset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAttributeIdentifier_ReturnValue_PropertyAddress, CreateAttributeIdentifier_FunctionAddress, "ReturnValue");
		CreateAttributeIdentifier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateAttributeIdentifier_FunctionAddress, "ReturnValue");
		CreateAttributeIdentifier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAttributeIdentifier_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateAttributeIdentifier_IsValid = CreateAttributeIdentifier_FunctionAddress != IntPtr.Zero && CreateAttributeIdentifier_AnimationAsset_IsValid && CreateAttributeIdentifier_AttributeName_IsValid && CreateAttributeIdentifier_BoneName_IsValid && CreateAttributeIdentifier_AttributeType_IsValid && CreateAttributeIdentifier_bValidateExistsOnAsset_IsValid && CreateAttributeIdentifier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationAttributeIdentifierExtensions:CreateAttributeIdentifier", CreateAttributeIdentifier_IsValid);
	}
}
