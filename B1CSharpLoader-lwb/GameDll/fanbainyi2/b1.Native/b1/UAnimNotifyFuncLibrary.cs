using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.AnimNotifyFuncLibrary", "b1", UnrealModuleType.Game)]
public class UAnimNotifyFuncLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool PrepareAnimNotifySoftAsset_IsValid;

	private static IntPtr PrepareAnimNotifySoftAsset_FunctionAddress;

	private static int PrepareAnimNotifySoftAsset_ParamsSize;

	private static bool PrepareAnimNotifySoftAsset_AnimBase_IsValid;

	private static FFieldAddress PrepareAnimNotifySoftAsset_AnimBase_PropertyAddress;

	private static int PrepareAnimNotifySoftAsset_AnimBase_Offset;

	private static bool PrepareAnimNotifySoftAsset_outNotifyRefs_IsValid;

	private static FFieldAddress PrepareAnimNotifySoftAsset_outNotifyRefs_PropertyAddress;

	private static int PrepareAnimNotifySoftAsset_outNotifyRefs_Offset;

	private static bool PrepareAnimNotifySoftAsset_outNotifyStateRefs_IsValid;

	private static FFieldAddress PrepareAnimNotifySoftAsset_outNotifyStateRefs_PropertyAddress;

	private static int PrepareAnimNotifySoftAsset_outNotifyStateRefs_Offset;

	private static bool PrepareAnimationsNotifySoftAsset_IsValid;

	private static IntPtr PrepareAnimationsNotifySoftAsset_FunctionAddress;

	private static int PrepareAnimationsNotifySoftAsset_ParamsSize;

	private static bool PrepareAnimationsNotifySoftAsset_AnimBases_IsValid;

	private static FFieldAddress PrepareAnimationsNotifySoftAsset_AnimBases_PropertyAddress;

	private static int PrepareAnimationsNotifySoftAsset_AnimBases_Offset;

	private static bool PrepareAnimationsNotifySoftAsset_outNotifyRefs_IsValid;

	private static FFieldAddress PrepareAnimationsNotifySoftAsset_outNotifyRefs_PropertyAddress;

	private static int PrepareAnimationsNotifySoftAsset_outNotifyRefs_Offset;

	private static bool PrepareAnimationsNotifySoftAsset_outNotifyStateRefs_IsValid;

	private static FFieldAddress PrepareAnimationsNotifySoftAsset_outNotifyStateRefs_PropertyAddress;

	private static int PrepareAnimationsNotifySoftAsset_outNotifyStateRefs_Offset;

	private static bool GetAllAnimNotifySoftAsset_IsValid;

	private static IntPtr GetAllAnimNotifySoftAsset_FunctionAddress;

	private static int GetAllAnimNotifySoftAsset_ParamsSize;

	private static bool GetAllAnimNotifySoftAsset_AnimBase_IsValid;

	private static FFieldAddress GetAllAnimNotifySoftAsset_AnimBase_PropertyAddress;

	private static int GetAllAnimNotifySoftAsset_AnimBase_Offset;

	private static bool GetAllAnimNotifySoftAsset_outNotifyRefs_IsValid;

	private static FFieldAddress GetAllAnimNotifySoftAsset_outNotifyRefs_PropertyAddress;

	private static int GetAllAnimNotifySoftAsset_outNotifyRefs_Offset;

	private static bool GetAllAnimNotifySoftAsset_outNotifyStateRefs_IsValid;

	private static FFieldAddress GetAllAnimNotifySoftAsset_outNotifyStateRefs_PropertyAddress;

	private static int GetAllAnimNotifySoftAsset_outNotifyStateRefs_Offset;

	private static bool DeleteAnimNotifyAndAnimNotifyState_IsValid;

	private static IntPtr DeleteAnimNotifyAndAnimNotifyState_FunctionAddress;

	private static int DeleteAnimNotifyAndAnimNotifyState_ParamsSize;

	private static bool DeleteAnimNotifyAndAnimNotifyState_AnimMontage_IsValid;

	private static FFieldAddress DeleteAnimNotifyAndAnimNotifyState_AnimMontage_PropertyAddress;

	private static int DeleteAnimNotifyAndAnimNotifyState_AnimMontage_Offset;

	private static bool DeleteAnimNotifyAndAnimNotifyState_NotifyTypeList_IsValid;

	private static FFieldAddress DeleteAnimNotifyAndAnimNotifyState_NotifyTypeList_PropertyAddress;

	private static int DeleteAnimNotifyAndAnimNotifyState_NotifyTypeList_Offset;

	private static bool DeleteAnimNotifyAndAnimNotifyState_NotifyStateTypeList_IsValid;

	private static FFieldAddress DeleteAnimNotifyAndAnimNotifyState_NotifyStateTypeList_PropertyAddress;

	private static int DeleteAnimNotifyAndAnimNotifyState_NotifyStateTypeList_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.AnimNotifyFuncLibrary:PrepareAnimNotifySoftAsset")]
	public unsafe static void PrepareAnimNotifySoftAsset(UAnimSequenceBase AnimBase, out Dictionary<UAnimNotify_GSBase, FNotifySoftRefs> outNotifyRefs, out Dictionary<UAnimNotifyState_GSBase, FNotifySoftRefs> outNotifyStateRefs)
	{
		if (!PrepareAnimNotifySoftAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyFuncLibrary:PrepareAnimNotifySoftAsset");
			outNotifyRefs = null;
			outNotifyStateRefs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrepareAnimNotifySoftAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrepareAnimNotifySoftAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, PrepareAnimNotifySoftAsset_AnimBase_Offset), 0, PrepareAnimNotifySoftAsset_AnimBase_PropertyAddress.Address, AnimBase);
		NativeReflection.InitializeValue_InContainer(PrepareAnimNotifySoftAsset_outNotifyRefs_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(PrepareAnimNotifySoftAsset_outNotifyStateRefs_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PrepareAnimNotifySoftAsset_FunctionAddress, intPtr, PrepareAnimNotifySoftAsset_ParamsSize);
		outNotifyRefs = new TMapCopyMarshaler<UAnimNotify_GSBase, FNotifySoftRefs>(1, PrepareAnimNotifySoftAsset_outNotifyRefs_PropertyAddress, CachedMarshalingDelegates<UAnimNotify_GSBase, UObjectMarshaler<UAnimNotify_GSBase>>.FromNative, CachedMarshalingDelegates<UAnimNotify_GSBase, UObjectMarshaler<UAnimNotify_GSBase>>.ToNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.FromNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.ToNative).FromNative(IntPtr.Add(intPtr, PrepareAnimNotifySoftAsset_outNotifyRefs_Offset));
		NativeReflection.DestroyValue_InContainer(PrepareAnimNotifySoftAsset_outNotifyRefs_PropertyAddress.Address, intPtr);
		outNotifyStateRefs = new TMapCopyMarshaler<UAnimNotifyState_GSBase, FNotifySoftRefs>(1, PrepareAnimNotifySoftAsset_outNotifyStateRefs_PropertyAddress, CachedMarshalingDelegates<UAnimNotifyState_GSBase, UObjectMarshaler<UAnimNotifyState_GSBase>>.FromNative, CachedMarshalingDelegates<UAnimNotifyState_GSBase, UObjectMarshaler<UAnimNotifyState_GSBase>>.ToNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.FromNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.ToNative).FromNative(IntPtr.Add(intPtr, PrepareAnimNotifySoftAsset_outNotifyStateRefs_Offset));
		NativeReflection.DestroyValue_InContainer(PrepareAnimNotifySoftAsset_outNotifyStateRefs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.AnimNotifyFuncLibrary:PrepareAnimationsNotifySoftAsset")]
	public unsafe static void PrepareAnimationsNotifySoftAsset(List<UAnimSequenceBase> AnimBases, out Dictionary<UAnimNotify_GSBase, FNotifySoftRefs> outNotifyRefs, out Dictionary<UAnimNotifyState_GSBase, FNotifySoftRefs> outNotifyStateRefs)
	{
		if (!PrepareAnimationsNotifySoftAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyFuncLibrary:PrepareAnimationsNotifySoftAsset");
			outNotifyRefs = null;
			outNotifyStateRefs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrepareAnimationsNotifySoftAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrepareAnimationsNotifySoftAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UAnimSequenceBase>(1, PrepareAnimationsNotifySoftAsset_AnimBases_PropertyAddress, CachedMarshalingDelegates<UAnimSequenceBase, UObjectMarshaler<UAnimSequenceBase>>.FromNative, CachedMarshalingDelegates<UAnimSequenceBase, UObjectMarshaler<UAnimSequenceBase>>.ToNative).ToNative(IntPtr.Add(intPtr, PrepareAnimationsNotifySoftAsset_AnimBases_Offset), AnimBases);
		NativeReflection.InitializeValue_InContainer(PrepareAnimationsNotifySoftAsset_outNotifyRefs_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(PrepareAnimationsNotifySoftAsset_outNotifyStateRefs_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PrepareAnimationsNotifySoftAsset_FunctionAddress, intPtr, PrepareAnimationsNotifySoftAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PrepareAnimationsNotifySoftAsset_AnimBases_PropertyAddress.Address, intPtr);
		outNotifyRefs = new TMapCopyMarshaler<UAnimNotify_GSBase, FNotifySoftRefs>(1, PrepareAnimationsNotifySoftAsset_outNotifyRefs_PropertyAddress, CachedMarshalingDelegates<UAnimNotify_GSBase, UObjectMarshaler<UAnimNotify_GSBase>>.FromNative, CachedMarshalingDelegates<UAnimNotify_GSBase, UObjectMarshaler<UAnimNotify_GSBase>>.ToNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.FromNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.ToNative).FromNative(IntPtr.Add(intPtr, PrepareAnimationsNotifySoftAsset_outNotifyRefs_Offset));
		NativeReflection.DestroyValue_InContainer(PrepareAnimationsNotifySoftAsset_outNotifyRefs_PropertyAddress.Address, intPtr);
		outNotifyStateRefs = new TMapCopyMarshaler<UAnimNotifyState_GSBase, FNotifySoftRefs>(1, PrepareAnimationsNotifySoftAsset_outNotifyStateRefs_PropertyAddress, CachedMarshalingDelegates<UAnimNotifyState_GSBase, UObjectMarshaler<UAnimNotifyState_GSBase>>.FromNative, CachedMarshalingDelegates<UAnimNotifyState_GSBase, UObjectMarshaler<UAnimNotifyState_GSBase>>.ToNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.FromNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.ToNative).FromNative(IntPtr.Add(intPtr, PrepareAnimationsNotifySoftAsset_outNotifyStateRefs_Offset));
		NativeReflection.DestroyValue_InContainer(PrepareAnimationsNotifySoftAsset_outNotifyStateRefs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.AnimNotifyFuncLibrary:GetAllAnimNotifySoftAsset")]
	public unsafe static void GetAllAnimNotifySoftAsset(UAnimSequenceBase AnimBase, out Dictionary<UAnimNotify_GSBase, FNotifySoftRefs> outNotifyRefs, out Dictionary<UAnimNotifyState_GSBase, FNotifySoftRefs> outNotifyStateRefs)
	{
		if (!GetAllAnimNotifySoftAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyFuncLibrary:GetAllAnimNotifySoftAsset");
			outNotifyRefs = null;
			outNotifyStateRefs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllAnimNotifySoftAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllAnimNotifySoftAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetAllAnimNotifySoftAsset_AnimBase_Offset), 0, GetAllAnimNotifySoftAsset_AnimBase_PropertyAddress.Address, AnimBase);
		NativeReflection.InitializeValue_InContainer(GetAllAnimNotifySoftAsset_outNotifyRefs_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(GetAllAnimNotifySoftAsset_outNotifyStateRefs_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllAnimNotifySoftAsset_FunctionAddress, intPtr, GetAllAnimNotifySoftAsset_ParamsSize);
		outNotifyRefs = new TMapCopyMarshaler<UAnimNotify_GSBase, FNotifySoftRefs>(1, GetAllAnimNotifySoftAsset_outNotifyRefs_PropertyAddress, CachedMarshalingDelegates<UAnimNotify_GSBase, UObjectMarshaler<UAnimNotify_GSBase>>.FromNative, CachedMarshalingDelegates<UAnimNotify_GSBase, UObjectMarshaler<UAnimNotify_GSBase>>.ToNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.FromNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllAnimNotifySoftAsset_outNotifyRefs_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllAnimNotifySoftAsset_outNotifyRefs_PropertyAddress.Address, intPtr);
		outNotifyStateRefs = new TMapCopyMarshaler<UAnimNotifyState_GSBase, FNotifySoftRefs>(1, GetAllAnimNotifySoftAsset_outNotifyStateRefs_PropertyAddress, CachedMarshalingDelegates<UAnimNotifyState_GSBase, UObjectMarshaler<UAnimNotifyState_GSBase>>.FromNative, CachedMarshalingDelegates<UAnimNotifyState_GSBase, UObjectMarshaler<UAnimNotifyState_GSBase>>.ToNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.FromNative, CachedMarshalingDelegates<FNotifySoftRefs, FNotifySoftRefs>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllAnimNotifySoftAsset_outNotifyStateRefs_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllAnimNotifySoftAsset_outNotifyStateRefs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.AnimNotifyFuncLibrary:DeleteAnimNotifyAndAnimNotifyState")]
	public unsafe static void DeleteAnimNotifyAndAnimNotifyState(UAnimMontage AnimMontage, List<EGsEnAnimN> NotifyTypeList, List<EGsEnAnimNS> NotifyStateTypeList)
	{
		if (!DeleteAnimNotifyAndAnimNotifyState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyFuncLibrary:DeleteAnimNotifyAndAnimNotifyState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteAnimNotifyAndAnimNotifyState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteAnimNotifyAndAnimNotifyState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, DeleteAnimNotifyAndAnimNotifyState_AnimMontage_Offset), 0, DeleteAnimNotifyAndAnimNotifyState_AnimMontage_PropertyAddress.Address, AnimMontage);
		new TArrayCopyMarshaler<EGsEnAnimN>(1, DeleteAnimNotifyAndAnimNotifyState_NotifyTypeList_PropertyAddress, CachedMarshalingDelegates<EGsEnAnimN, EnumMarshaler<EGsEnAnimN>>.FromNative, CachedMarshalingDelegates<EGsEnAnimN, EnumMarshaler<EGsEnAnimN>>.ToNative).ToNative(IntPtr.Add(intPtr, DeleteAnimNotifyAndAnimNotifyState_NotifyTypeList_Offset), NotifyTypeList);
		new TArrayCopyMarshaler<EGsEnAnimNS>(1, DeleteAnimNotifyAndAnimNotifyState_NotifyStateTypeList_PropertyAddress, CachedMarshalingDelegates<EGsEnAnimNS, EnumMarshaler<EGsEnAnimNS>>.FromNative, CachedMarshalingDelegates<EGsEnAnimNS, EnumMarshaler<EGsEnAnimNS>>.ToNative).ToNative(IntPtr.Add(intPtr, DeleteAnimNotifyAndAnimNotifyState_NotifyStateTypeList_Offset), NotifyStateTypeList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteAnimNotifyAndAnimNotifyState_FunctionAddress, intPtr, DeleteAnimNotifyAndAnimNotifyState_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteAnimNotifyAndAnimNotifyState_NotifyTypeList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DeleteAnimNotifyAndAnimNotifyState_NotifyStateTypeList_PropertyAddress.Address, intPtr);
	}

	static UAnimNotifyFuncLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyFuncLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyFuncLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.AnimNotifyFuncLibrary");
		PrepareAnimNotifySoftAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrepareAnimNotifySoftAsset");
		PrepareAnimNotifySoftAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(PrepareAnimNotifySoftAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrepareAnimNotifySoftAsset_AnimBase_PropertyAddress, PrepareAnimNotifySoftAsset_FunctionAddress, "AnimBase");
		PrepareAnimNotifySoftAsset_AnimBase_Offset = NativeReflectionCached.GetPropertyOffset(PrepareAnimNotifySoftAsset_FunctionAddress, "AnimBase");
		PrepareAnimNotifySoftAsset_AnimBase_IsValid = NativeReflectionCached.ValidatePropertyClass(PrepareAnimNotifySoftAsset_FunctionAddress, "AnimBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PrepareAnimNotifySoftAsset_outNotifyRefs_PropertyAddress, PrepareAnimNotifySoftAsset_FunctionAddress, "outNotifyRefs");
		PrepareAnimNotifySoftAsset_outNotifyRefs_Offset = NativeReflectionCached.GetPropertyOffset(PrepareAnimNotifySoftAsset_FunctionAddress, "outNotifyRefs");
		PrepareAnimNotifySoftAsset_outNotifyRefs_IsValid = NativeReflectionCached.ValidatePropertyClass(PrepareAnimNotifySoftAsset_FunctionAddress, "outNotifyRefs", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref PrepareAnimNotifySoftAsset_outNotifyStateRefs_PropertyAddress, PrepareAnimNotifySoftAsset_FunctionAddress, "outNotifyStateRefs");
		PrepareAnimNotifySoftAsset_outNotifyStateRefs_Offset = NativeReflectionCached.GetPropertyOffset(PrepareAnimNotifySoftAsset_FunctionAddress, "outNotifyStateRefs");
		PrepareAnimNotifySoftAsset_outNotifyStateRefs_IsValid = NativeReflectionCached.ValidatePropertyClass(PrepareAnimNotifySoftAsset_FunctionAddress, "outNotifyStateRefs", Classes.FMapProperty);
		PrepareAnimNotifySoftAsset_IsValid = PrepareAnimNotifySoftAsset_FunctionAddress != IntPtr.Zero && PrepareAnimNotifySoftAsset_AnimBase_IsValid && PrepareAnimNotifySoftAsset_outNotifyRefs_IsValid && PrepareAnimNotifySoftAsset_outNotifyStateRefs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyFuncLibrary:PrepareAnimNotifySoftAsset", PrepareAnimNotifySoftAsset_IsValid);
		PrepareAnimationsNotifySoftAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrepareAnimationsNotifySoftAsset");
		PrepareAnimationsNotifySoftAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(PrepareAnimationsNotifySoftAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrepareAnimationsNotifySoftAsset_AnimBases_PropertyAddress, PrepareAnimationsNotifySoftAsset_FunctionAddress, "AnimBases");
		PrepareAnimationsNotifySoftAsset_AnimBases_Offset = NativeReflectionCached.GetPropertyOffset(PrepareAnimationsNotifySoftAsset_FunctionAddress, "AnimBases");
		PrepareAnimationsNotifySoftAsset_AnimBases_IsValid = NativeReflectionCached.ValidatePropertyClass(PrepareAnimationsNotifySoftAsset_FunctionAddress, "AnimBases", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PrepareAnimationsNotifySoftAsset_outNotifyRefs_PropertyAddress, PrepareAnimationsNotifySoftAsset_FunctionAddress, "outNotifyRefs");
		PrepareAnimationsNotifySoftAsset_outNotifyRefs_Offset = NativeReflectionCached.GetPropertyOffset(PrepareAnimationsNotifySoftAsset_FunctionAddress, "outNotifyRefs");
		PrepareAnimationsNotifySoftAsset_outNotifyRefs_IsValid = NativeReflectionCached.ValidatePropertyClass(PrepareAnimationsNotifySoftAsset_FunctionAddress, "outNotifyRefs", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref PrepareAnimationsNotifySoftAsset_outNotifyStateRefs_PropertyAddress, PrepareAnimationsNotifySoftAsset_FunctionAddress, "outNotifyStateRefs");
		PrepareAnimationsNotifySoftAsset_outNotifyStateRefs_Offset = NativeReflectionCached.GetPropertyOffset(PrepareAnimationsNotifySoftAsset_FunctionAddress, "outNotifyStateRefs");
		PrepareAnimationsNotifySoftAsset_outNotifyStateRefs_IsValid = NativeReflectionCached.ValidatePropertyClass(PrepareAnimationsNotifySoftAsset_FunctionAddress, "outNotifyStateRefs", Classes.FMapProperty);
		PrepareAnimationsNotifySoftAsset_IsValid = PrepareAnimationsNotifySoftAsset_FunctionAddress != IntPtr.Zero && PrepareAnimationsNotifySoftAsset_AnimBases_IsValid && PrepareAnimationsNotifySoftAsset_outNotifyRefs_IsValid && PrepareAnimationsNotifySoftAsset_outNotifyStateRefs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyFuncLibrary:PrepareAnimationsNotifySoftAsset", PrepareAnimationsNotifySoftAsset_IsValid);
		GetAllAnimNotifySoftAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllAnimNotifySoftAsset");
		GetAllAnimNotifySoftAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllAnimNotifySoftAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimNotifySoftAsset_AnimBase_PropertyAddress, GetAllAnimNotifySoftAsset_FunctionAddress, "AnimBase");
		GetAllAnimNotifySoftAsset_AnimBase_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimNotifySoftAsset_FunctionAddress, "AnimBase");
		GetAllAnimNotifySoftAsset_AnimBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimNotifySoftAsset_FunctionAddress, "AnimBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimNotifySoftAsset_outNotifyRefs_PropertyAddress, GetAllAnimNotifySoftAsset_FunctionAddress, "outNotifyRefs");
		GetAllAnimNotifySoftAsset_outNotifyRefs_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimNotifySoftAsset_FunctionAddress, "outNotifyRefs");
		GetAllAnimNotifySoftAsset_outNotifyRefs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimNotifySoftAsset_FunctionAddress, "outNotifyRefs", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimNotifySoftAsset_outNotifyStateRefs_PropertyAddress, GetAllAnimNotifySoftAsset_FunctionAddress, "outNotifyStateRefs");
		GetAllAnimNotifySoftAsset_outNotifyStateRefs_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimNotifySoftAsset_FunctionAddress, "outNotifyStateRefs");
		GetAllAnimNotifySoftAsset_outNotifyStateRefs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimNotifySoftAsset_FunctionAddress, "outNotifyStateRefs", Classes.FMapProperty);
		GetAllAnimNotifySoftAsset_IsValid = GetAllAnimNotifySoftAsset_FunctionAddress != IntPtr.Zero && GetAllAnimNotifySoftAsset_AnimBase_IsValid && GetAllAnimNotifySoftAsset_outNotifyRefs_IsValid && GetAllAnimNotifySoftAsset_outNotifyStateRefs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyFuncLibrary:GetAllAnimNotifySoftAsset", GetAllAnimNotifySoftAsset_IsValid);
		DeleteAnimNotifyAndAnimNotifyState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteAnimNotifyAndAnimNotifyState");
		DeleteAnimNotifyAndAnimNotifyState_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteAnimNotifyAndAnimNotifyState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteAnimNotifyAndAnimNotifyState_AnimMontage_PropertyAddress, DeleteAnimNotifyAndAnimNotifyState_FunctionAddress, "AnimMontage");
		DeleteAnimNotifyAndAnimNotifyState_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(DeleteAnimNotifyAndAnimNotifyState_FunctionAddress, "AnimMontage");
		DeleteAnimNotifyAndAnimNotifyState_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteAnimNotifyAndAnimNotifyState_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteAnimNotifyAndAnimNotifyState_NotifyTypeList_PropertyAddress, DeleteAnimNotifyAndAnimNotifyState_FunctionAddress, "NotifyTypeList");
		DeleteAnimNotifyAndAnimNotifyState_NotifyTypeList_Offset = NativeReflectionCached.GetPropertyOffset(DeleteAnimNotifyAndAnimNotifyState_FunctionAddress, "NotifyTypeList");
		DeleteAnimNotifyAndAnimNotifyState_NotifyTypeList_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteAnimNotifyAndAnimNotifyState_FunctionAddress, "NotifyTypeList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteAnimNotifyAndAnimNotifyState_NotifyStateTypeList_PropertyAddress, DeleteAnimNotifyAndAnimNotifyState_FunctionAddress, "NotifyStateTypeList");
		DeleteAnimNotifyAndAnimNotifyState_NotifyStateTypeList_Offset = NativeReflectionCached.GetPropertyOffset(DeleteAnimNotifyAndAnimNotifyState_FunctionAddress, "NotifyStateTypeList");
		DeleteAnimNotifyAndAnimNotifyState_NotifyStateTypeList_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteAnimNotifyAndAnimNotifyState_FunctionAddress, "NotifyStateTypeList", Classes.FArrayProperty);
		DeleteAnimNotifyAndAnimNotifyState_IsValid = DeleteAnimNotifyAndAnimNotifyState_FunctionAddress != IntPtr.Zero && DeleteAnimNotifyAndAnimNotifyState_AnimMontage_IsValid && DeleteAnimNotifyAndAnimNotifyState_NotifyTypeList_IsValid && DeleteAnimNotifyAndAnimNotifyState_NotifyStateTypeList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyFuncLibrary:DeleteAnimNotifyAndAnimNotifyState", DeleteAnimNotifyAndAnimNotifyState_IsValid);
	}
}
