using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimSequence", "Engine", UnrealModuleType.Engine)]
public class UAnimSequence : UAnimSequenceBase
{
	private static bool RemoveCustomAttribute_IsValid;

	private static IntPtr RemoveCustomAttribute_FunctionAddress;

	private static int RemoveCustomAttribute_ParamsSize;

	private static bool RemoveCustomAttribute_BoneName_IsValid;

	private static FFieldAddress RemoveCustomAttribute_BoneName_PropertyAddress;

	private static int RemoveCustomAttribute_BoneName_Offset;

	private static bool RemoveCustomAttribute_AttributeName_IsValid;

	private static FFieldAddress RemoveCustomAttribute_AttributeName_PropertyAddress;

	private static int RemoveCustomAttribute_AttributeName_Offset;

	private static bool RemoveAllCustomAttributesForBone_IsValid;

	private static IntPtr RemoveAllCustomAttributesForBone_FunctionAddress;

	private static int RemoveAllCustomAttributesForBone_ParamsSize;

	private static bool RemoveAllCustomAttributesForBone_BoneName_IsValid;

	private static FFieldAddress RemoveAllCustomAttributesForBone_BoneName_PropertyAddress;

	private static int RemoveAllCustomAttributesForBone_BoneName_Offset;

	private static bool RemoveAllCustomAttributes_IsValid;

	private static IntPtr RemoveAllCustomAttributes_FunctionAddress;

	private static int RemoveAllCustomAttributes_ParamsSize;

	private static bool AddBoneStringCustomAttribute_IsValid;

	private static IntPtr AddBoneStringCustomAttribute_FunctionAddress;

	private static int AddBoneStringCustomAttribute_ParamsSize;

	private static bool AddBoneStringCustomAttribute_BoneName_IsValid;

	private static FFieldAddress AddBoneStringCustomAttribute_BoneName_PropertyAddress;

	private static int AddBoneStringCustomAttribute_BoneName_Offset;

	private static bool AddBoneStringCustomAttribute_AttributeName_IsValid;

	private static FFieldAddress AddBoneStringCustomAttribute_AttributeName_PropertyAddress;

	private static int AddBoneStringCustomAttribute_AttributeName_Offset;

	private static bool AddBoneStringCustomAttribute_TimeKeys_IsValid;

	private static FFieldAddress AddBoneStringCustomAttribute_TimeKeys_PropertyAddress;

	private static int AddBoneStringCustomAttribute_TimeKeys_Offset;

	private static bool AddBoneStringCustomAttribute_ValueKeys_IsValid;

	private static FFieldAddress AddBoneStringCustomAttribute_ValueKeys_PropertyAddress;

	private static int AddBoneStringCustomAttribute_ValueKeys_Offset;

	private static bool AddBoneIntegerCustomAttribute_IsValid;

	private static IntPtr AddBoneIntegerCustomAttribute_FunctionAddress;

	private static int AddBoneIntegerCustomAttribute_ParamsSize;

	private static bool AddBoneIntegerCustomAttribute_BoneName_IsValid;

	private static FFieldAddress AddBoneIntegerCustomAttribute_BoneName_PropertyAddress;

	private static int AddBoneIntegerCustomAttribute_BoneName_Offset;

	private static bool AddBoneIntegerCustomAttribute_AttributeName_IsValid;

	private static FFieldAddress AddBoneIntegerCustomAttribute_AttributeName_PropertyAddress;

	private static int AddBoneIntegerCustomAttribute_AttributeName_Offset;

	private static bool AddBoneIntegerCustomAttribute_TimeKeys_IsValid;

	private static FFieldAddress AddBoneIntegerCustomAttribute_TimeKeys_PropertyAddress;

	private static int AddBoneIntegerCustomAttribute_TimeKeys_Offset;

	private static bool AddBoneIntegerCustomAttribute_ValueKeys_IsValid;

	private static FFieldAddress AddBoneIntegerCustomAttribute_ValueKeys_PropertyAddress;

	private static int AddBoneIntegerCustomAttribute_ValueKeys_Offset;

	private static bool AddBoneFloatCustomAttribute_IsValid;

	private static IntPtr AddBoneFloatCustomAttribute_FunctionAddress;

	private static int AddBoneFloatCustomAttribute_ParamsSize;

	private static bool AddBoneFloatCustomAttribute_BoneName_IsValid;

	private static FFieldAddress AddBoneFloatCustomAttribute_BoneName_PropertyAddress;

	private static int AddBoneFloatCustomAttribute_BoneName_Offset;

	private static bool AddBoneFloatCustomAttribute_AttributeName_IsValid;

	private static FFieldAddress AddBoneFloatCustomAttribute_AttributeName_PropertyAddress;

	private static int AddBoneFloatCustomAttribute_AttributeName_Offset;

	private static bool AddBoneFloatCustomAttribute_TimeKeys_IsValid;

	private static FFieldAddress AddBoneFloatCustomAttribute_TimeKeys_PropertyAddress;

	private static int AddBoneFloatCustomAttribute_TimeKeys_Offset;

	private static bool AddBoneFloatCustomAttribute_ValueKeys_IsValid;

	private static FFieldAddress AddBoneFloatCustomAttribute_ValueKeys_PropertyAddress;

	private static int AddBoneFloatCustomAttribute_ValueKeys_Offset;

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/Engine.AnimSequence:RemoveCustomAttribute")]
	public unsafe void RemoveCustomAttribute(FName BoneName, FName AttributeName)
	{
		CheckDestroyed();
		if (!RemoveCustomAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSequence:RemoveCustomAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveCustomAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveCustomAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveCustomAttribute_BoneName_Offset), 0, RemoveCustomAttribute_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveCustomAttribute_AttributeName_Offset), 0, RemoveCustomAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveCustomAttribute_FunctionAddress, intPtr, RemoveCustomAttribute_ParamsSize);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/Engine.AnimSequence:RemoveAllCustomAttributesForBone")]
	public unsafe void RemoveAllCustomAttributesForBone(FName BoneName)
	{
		CheckDestroyed();
		if (!RemoveAllCustomAttributesForBone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSequence:RemoveAllCustomAttributesForBone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllCustomAttributesForBone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllCustomAttributesForBone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveAllCustomAttributesForBone_BoneName_Offset), 0, RemoveAllCustomAttributesForBone_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAllCustomAttributesForBone_FunctionAddress, intPtr, RemoveAllCustomAttributesForBone_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Engine.AnimSequence:RemoveAllCustomAttributes")]
	public unsafe void RemoveAllCustomAttributes()
	{
		CheckDestroyed();
		if (!RemoveAllCustomAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSequence:RemoveAllCustomAttributes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllCustomAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllCustomAttributes_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RemoveAllCustomAttributes_FunctionAddress, argsSize: RemoveAllCustomAttributes_ParamsSize);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/Engine.AnimSequence:AddBoneStringCustomAttribute")]
	public unsafe void AddBoneStringCustomAttribute(FName BoneName, FName AttributeName, List<float> TimeKeys, List<string> ValueKeys)
	{
		CheckDestroyed();
		if (!AddBoneStringCustomAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSequence:AddBoneStringCustomAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBoneStringCustomAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBoneStringCustomAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBoneStringCustomAttribute_BoneName_Offset), 0, AddBoneStringCustomAttribute_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBoneStringCustomAttribute_AttributeName_Offset), 0, AddBoneStringCustomAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		new TArrayCopyMarshaler<float>(1, AddBoneStringCustomAttribute_TimeKeys_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddBoneStringCustomAttribute_TimeKeys_Offset), TimeKeys);
		new TArrayCopyMarshaler<string>(1, AddBoneStringCustomAttribute_ValueKeys_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, AddBoneStringCustomAttribute_ValueKeys_Offset), ValueKeys);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBoneStringCustomAttribute_FunctionAddress, intPtr, AddBoneStringCustomAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddBoneStringCustomAttribute_TimeKeys_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddBoneStringCustomAttribute_ValueKeys_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/Engine.AnimSequence:AddBoneIntegerCustomAttribute")]
	public unsafe void AddBoneIntegerCustomAttribute(FName BoneName, FName AttributeName, List<float> TimeKeys, List<int> ValueKeys)
	{
		CheckDestroyed();
		if (!AddBoneIntegerCustomAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSequence:AddBoneIntegerCustomAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBoneIntegerCustomAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBoneIntegerCustomAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBoneIntegerCustomAttribute_BoneName_Offset), 0, AddBoneIntegerCustomAttribute_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBoneIntegerCustomAttribute_AttributeName_Offset), 0, AddBoneIntegerCustomAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		new TArrayCopyMarshaler<float>(1, AddBoneIntegerCustomAttribute_TimeKeys_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddBoneIntegerCustomAttribute_TimeKeys_Offset), TimeKeys);
		new TArrayCopyMarshaler<int>(1, AddBoneIntegerCustomAttribute_ValueKeys_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, AddBoneIntegerCustomAttribute_ValueKeys_Offset), ValueKeys);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBoneIntegerCustomAttribute_FunctionAddress, intPtr, AddBoneIntegerCustomAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddBoneIntegerCustomAttribute_TimeKeys_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddBoneIntegerCustomAttribute_ValueKeys_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/Engine.AnimSequence:AddBoneFloatCustomAttribute")]
	public unsafe void AddBoneFloatCustomAttribute(FName BoneName, FName AttributeName, List<float> TimeKeys, List<float> ValueKeys)
	{
		CheckDestroyed();
		if (!AddBoneFloatCustomAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSequence:AddBoneFloatCustomAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBoneFloatCustomAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBoneFloatCustomAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBoneFloatCustomAttribute_BoneName_Offset), 0, AddBoneFloatCustomAttribute_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBoneFloatCustomAttribute_AttributeName_Offset), 0, AddBoneFloatCustomAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		new TArrayCopyMarshaler<float>(1, AddBoneFloatCustomAttribute_TimeKeys_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddBoneFloatCustomAttribute_TimeKeys_Offset), TimeKeys);
		new TArrayCopyMarshaler<float>(1, AddBoneFloatCustomAttribute_ValueKeys_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddBoneFloatCustomAttribute_ValueKeys_Offset), ValueKeys);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBoneFloatCustomAttribute_FunctionAddress, intPtr, AddBoneFloatCustomAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddBoneFloatCustomAttribute_TimeKeys_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddBoneFloatCustomAttribute_ValueKeys_PropertyAddress.Address, intPtr);
	}

	static UAnimSequence()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimSequence));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.AnimSequence");
		RemoveCustomAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveCustomAttribute");
		RemoveCustomAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveCustomAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveCustomAttribute_BoneName_PropertyAddress, RemoveCustomAttribute_FunctionAddress, "BoneName");
		RemoveCustomAttribute_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCustomAttribute_FunctionAddress, "BoneName");
		RemoveCustomAttribute_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCustomAttribute_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCustomAttribute_AttributeName_PropertyAddress, RemoveCustomAttribute_FunctionAddress, "AttributeName");
		RemoveCustomAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCustomAttribute_FunctionAddress, "AttributeName");
		RemoveCustomAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCustomAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		RemoveCustomAttribute_IsValid = RemoveCustomAttribute_FunctionAddress != IntPtr.Zero && RemoveCustomAttribute_BoneName_IsValid && RemoveCustomAttribute_AttributeName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSequence:RemoveCustomAttribute", RemoveCustomAttribute_IsValid);
		RemoveAllCustomAttributesForBone_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAllCustomAttributesForBone");
		RemoveAllCustomAttributesForBone_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllCustomAttributesForBone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllCustomAttributesForBone_BoneName_PropertyAddress, RemoveAllCustomAttributesForBone_FunctionAddress, "BoneName");
		RemoveAllCustomAttributesForBone_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllCustomAttributesForBone_FunctionAddress, "BoneName");
		RemoveAllCustomAttributesForBone_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllCustomAttributesForBone_FunctionAddress, "BoneName", Classes.FNameProperty);
		RemoveAllCustomAttributesForBone_IsValid = RemoveAllCustomAttributesForBone_FunctionAddress != IntPtr.Zero && RemoveAllCustomAttributesForBone_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSequence:RemoveAllCustomAttributesForBone", RemoveAllCustomAttributesForBone_IsValid);
		RemoveAllCustomAttributes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAllCustomAttributes");
		RemoveAllCustomAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllCustomAttributes_FunctionAddress);
		RemoveAllCustomAttributes_IsValid = RemoveAllCustomAttributes_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSequence:RemoveAllCustomAttributes", RemoveAllCustomAttributes_IsValid);
		AddBoneStringCustomAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddBoneStringCustomAttribute");
		AddBoneStringCustomAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBoneStringCustomAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBoneStringCustomAttribute_BoneName_PropertyAddress, AddBoneStringCustomAttribute_FunctionAddress, "BoneName");
		AddBoneStringCustomAttribute_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneStringCustomAttribute_FunctionAddress, "BoneName");
		AddBoneStringCustomAttribute_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneStringCustomAttribute_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoneStringCustomAttribute_AttributeName_PropertyAddress, AddBoneStringCustomAttribute_FunctionAddress, "AttributeName");
		AddBoneStringCustomAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneStringCustomAttribute_FunctionAddress, "AttributeName");
		AddBoneStringCustomAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneStringCustomAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoneStringCustomAttribute_TimeKeys_PropertyAddress, AddBoneStringCustomAttribute_FunctionAddress, "TimeKeys");
		AddBoneStringCustomAttribute_TimeKeys_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneStringCustomAttribute_FunctionAddress, "TimeKeys");
		AddBoneStringCustomAttribute_TimeKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneStringCustomAttribute_FunctionAddress, "TimeKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoneStringCustomAttribute_ValueKeys_PropertyAddress, AddBoneStringCustomAttribute_FunctionAddress, "ValueKeys");
		AddBoneStringCustomAttribute_ValueKeys_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneStringCustomAttribute_FunctionAddress, "ValueKeys");
		AddBoneStringCustomAttribute_ValueKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneStringCustomAttribute_FunctionAddress, "ValueKeys", Classes.FArrayProperty);
		AddBoneStringCustomAttribute_IsValid = AddBoneStringCustomAttribute_FunctionAddress != IntPtr.Zero && AddBoneStringCustomAttribute_BoneName_IsValid && AddBoneStringCustomAttribute_AttributeName_IsValid && AddBoneStringCustomAttribute_TimeKeys_IsValid && AddBoneStringCustomAttribute_ValueKeys_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSequence:AddBoneStringCustomAttribute", AddBoneStringCustomAttribute_IsValid);
		AddBoneIntegerCustomAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddBoneIntegerCustomAttribute");
		AddBoneIntegerCustomAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBoneIntegerCustomAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBoneIntegerCustomAttribute_BoneName_PropertyAddress, AddBoneIntegerCustomAttribute_FunctionAddress, "BoneName");
		AddBoneIntegerCustomAttribute_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneIntegerCustomAttribute_FunctionAddress, "BoneName");
		AddBoneIntegerCustomAttribute_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneIntegerCustomAttribute_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoneIntegerCustomAttribute_AttributeName_PropertyAddress, AddBoneIntegerCustomAttribute_FunctionAddress, "AttributeName");
		AddBoneIntegerCustomAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneIntegerCustomAttribute_FunctionAddress, "AttributeName");
		AddBoneIntegerCustomAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneIntegerCustomAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoneIntegerCustomAttribute_TimeKeys_PropertyAddress, AddBoneIntegerCustomAttribute_FunctionAddress, "TimeKeys");
		AddBoneIntegerCustomAttribute_TimeKeys_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneIntegerCustomAttribute_FunctionAddress, "TimeKeys");
		AddBoneIntegerCustomAttribute_TimeKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneIntegerCustomAttribute_FunctionAddress, "TimeKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoneIntegerCustomAttribute_ValueKeys_PropertyAddress, AddBoneIntegerCustomAttribute_FunctionAddress, "ValueKeys");
		AddBoneIntegerCustomAttribute_ValueKeys_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneIntegerCustomAttribute_FunctionAddress, "ValueKeys");
		AddBoneIntegerCustomAttribute_ValueKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneIntegerCustomAttribute_FunctionAddress, "ValueKeys", Classes.FArrayProperty);
		AddBoneIntegerCustomAttribute_IsValid = AddBoneIntegerCustomAttribute_FunctionAddress != IntPtr.Zero && AddBoneIntegerCustomAttribute_BoneName_IsValid && AddBoneIntegerCustomAttribute_AttributeName_IsValid && AddBoneIntegerCustomAttribute_TimeKeys_IsValid && AddBoneIntegerCustomAttribute_ValueKeys_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSequence:AddBoneIntegerCustomAttribute", AddBoneIntegerCustomAttribute_IsValid);
		AddBoneFloatCustomAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddBoneFloatCustomAttribute");
		AddBoneFloatCustomAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBoneFloatCustomAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBoneFloatCustomAttribute_BoneName_PropertyAddress, AddBoneFloatCustomAttribute_FunctionAddress, "BoneName");
		AddBoneFloatCustomAttribute_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneFloatCustomAttribute_FunctionAddress, "BoneName");
		AddBoneFloatCustomAttribute_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneFloatCustomAttribute_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoneFloatCustomAttribute_AttributeName_PropertyAddress, AddBoneFloatCustomAttribute_FunctionAddress, "AttributeName");
		AddBoneFloatCustomAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneFloatCustomAttribute_FunctionAddress, "AttributeName");
		AddBoneFloatCustomAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneFloatCustomAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoneFloatCustomAttribute_TimeKeys_PropertyAddress, AddBoneFloatCustomAttribute_FunctionAddress, "TimeKeys");
		AddBoneFloatCustomAttribute_TimeKeys_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneFloatCustomAttribute_FunctionAddress, "TimeKeys");
		AddBoneFloatCustomAttribute_TimeKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneFloatCustomAttribute_FunctionAddress, "TimeKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoneFloatCustomAttribute_ValueKeys_PropertyAddress, AddBoneFloatCustomAttribute_FunctionAddress, "ValueKeys");
		AddBoneFloatCustomAttribute_ValueKeys_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneFloatCustomAttribute_FunctionAddress, "ValueKeys");
		AddBoneFloatCustomAttribute_ValueKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneFloatCustomAttribute_FunctionAddress, "ValueKeys", Classes.FArrayProperty);
		AddBoneFloatCustomAttribute_IsValid = AddBoneFloatCustomAttribute_FunctionAddress != IntPtr.Zero && AddBoneFloatCustomAttribute_BoneName_IsValid && AddBoneFloatCustomAttribute_AttributeName_IsValid && AddBoneFloatCustomAttribute_TimeKeys_IsValid && AddBoneFloatCustomAttribute_ValueKeys_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSequence:AddBoneFloatCustomAttribute", AddBoneFloatCustomAttribute_IsValid);
	}
}
