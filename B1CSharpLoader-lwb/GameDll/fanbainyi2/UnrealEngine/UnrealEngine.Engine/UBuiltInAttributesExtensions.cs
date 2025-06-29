using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/Engine.BuiltInAttributesExtensions", "Engine", UnrealModuleType.Engine)]
public class UBuiltInAttributesExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool AddTransformAttribute_IsValid;

	private static IntPtr AddTransformAttribute_FunctionAddress;

	private static int AddTransformAttribute_ParamsSize;

	private static bool AddTransformAttribute_AnimSequenceBase_IsValid;

	private static FFieldAddress AddTransformAttribute_AnimSequenceBase_PropertyAddress;

	private static int AddTransformAttribute_AnimSequenceBase_Offset;

	private static bool AddTransformAttribute_AttributeName_IsValid;

	private static FFieldAddress AddTransformAttribute_AttributeName_PropertyAddress;

	private static int AddTransformAttribute_AttributeName_Offset;

	private static bool AddTransformAttribute_BoneName_IsValid;

	private static FFieldAddress AddTransformAttribute_BoneName_PropertyAddress;

	private static int AddTransformAttribute_BoneName_Offset;

	private static bool AddTransformAttribute_Keys_IsValid;

	private static FFieldAddress AddTransformAttribute_Keys_PropertyAddress;

	private static int AddTransformAttribute_Keys_Offset;

	private static bool AddTransformAttribute_Values_IsValid;

	private static FFieldAddress AddTransformAttribute_Values_PropertyAddress;

	private static int AddTransformAttribute_Values_Offset;

	private static bool AddTransformAttribute_ReturnValue_IsValid;

	private static FFieldAddress AddTransformAttribute_ReturnValue_PropertyAddress;

	private static int AddTransformAttribute_ReturnValue_Offset;

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/Engine.BuiltInAttributesExtensions:AddTransformAttribute")]
	public unsafe static bool AddTransformAttribute(UAnimSequenceBase AnimSequenceBase, FName AttributeName, FName BoneName, List<float> Keys, List<FTransform> Values)
	{
		if (!AddTransformAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BuiltInAttributesExtensions:AddTransformAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTransformAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTransformAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, AddTransformAttribute_AnimSequenceBase_Offset), 0, AddTransformAttribute_AnimSequenceBase_PropertyAddress.Address, AnimSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddTransformAttribute_AttributeName_Offset), 0, AddTransformAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddTransformAttribute_BoneName_Offset), 0, AddTransformAttribute_BoneName_PropertyAddress.Address, BoneName);
		new TArrayCopyMarshaler<float>(1, AddTransformAttribute_Keys_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddTransformAttribute_Keys_Offset), Keys);
		new TArrayCopyMarshaler<FTransform>(1, AddTransformAttribute_Values_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(intPtr, AddTransformAttribute_Values_Offset), Values);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddTransformAttribute_FunctionAddress, intPtr, AddTransformAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddTransformAttribute_Keys_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddTransformAttribute_Values_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddTransformAttribute_ReturnValue_Offset), 0, AddTransformAttribute_ReturnValue_PropertyAddress.Address);
	}

	static UBuiltInAttributesExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBuiltInAttributesExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBuiltInAttributesExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.BuiltInAttributesExtensions");
		AddTransformAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddTransformAttribute");
		AddTransformAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTransformAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTransformAttribute_AnimSequenceBase_PropertyAddress, AddTransformAttribute_FunctionAddress, "AnimSequenceBase");
		AddTransformAttribute_AnimSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformAttribute_FunctionAddress, "AnimSequenceBase");
		AddTransformAttribute_AnimSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformAttribute_FunctionAddress, "AnimSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformAttribute_AttributeName_PropertyAddress, AddTransformAttribute_FunctionAddress, "AttributeName");
		AddTransformAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformAttribute_FunctionAddress, "AttributeName");
		AddTransformAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformAttribute_BoneName_PropertyAddress, AddTransformAttribute_FunctionAddress, "BoneName");
		AddTransformAttribute_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformAttribute_FunctionAddress, "BoneName");
		AddTransformAttribute_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformAttribute_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformAttribute_Keys_PropertyAddress, AddTransformAttribute_FunctionAddress, "Keys");
		AddTransformAttribute_Keys_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformAttribute_FunctionAddress, "Keys");
		AddTransformAttribute_Keys_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformAttribute_FunctionAddress, "Keys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformAttribute_Values_PropertyAddress, AddTransformAttribute_FunctionAddress, "Values");
		AddTransformAttribute_Values_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformAttribute_FunctionAddress, "Values");
		AddTransformAttribute_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformAttribute_FunctionAddress, "Values", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformAttribute_ReturnValue_PropertyAddress, AddTransformAttribute_FunctionAddress, "ReturnValue");
		AddTransformAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformAttribute_FunctionAddress, "ReturnValue");
		AddTransformAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddTransformAttribute_IsValid = AddTransformAttribute_FunctionAddress != IntPtr.Zero && AddTransformAttribute_AnimSequenceBase_IsValid && AddTransformAttribute_AttributeName_IsValid && AddTransformAttribute_BoneName_IsValid && AddTransformAttribute_Keys_IsValid && AddTransformAttribute_Values_IsValid && AddTransformAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BuiltInAttributesExtensions:AddTransformAttribute", AddTransformAttribute_IsValid);
	}
}
