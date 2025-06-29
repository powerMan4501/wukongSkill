using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810623136uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.AnimNotify_GSBase", "b1", UnrealModuleType.Game)]
public class UAnimNotify_GSBase : UAnimNotify
{
	private static bool CanBePlacedInASCS_IsValid;

	private static FFieldAddress CanBePlacedInASCS_PropertyAddress;

	private static int CanBePlacedInASCS_Offset;

	private static bool isPreload_IsValid;

	private static FFieldAddress isPreload_PropertyAddress;

	private static int isPreload_Offset;

	private static bool NotifyNameForShow_IsValid;

	private static int NotifyNameForShow_Offset;

	private static bool GSValidateInputCS_IsValid;

	private IntPtr GSValidateInputCS_InstanceFunctionAddress;

	private static IntPtr GSValidateInputCS_FunctionAddress;

	private static int GSValidateInputCS_ParamsSize;

	private static bool GSValidateInputCS_actor_IsValid;

	private static FFieldAddress GSValidateInputCS_actor_PropertyAddress;

	private static int GSValidateInputCS_actor_Offset;

	private static bool GSPreNotifyDebugCS_IsValid;

	private IntPtr GSPreNotifyDebugCS_InstanceFunctionAddress;

	private static IntPtr GSPreNotifyDebugCS_FunctionAddress;

	private static int GSPreNotifyDebugCS_ParamsSize;

	private static bool GSPreNotifyDebugCS_NotifyParam_IsValid;

	private static FFieldAddress GSPreNotifyDebugCS_NotifyParam_PropertyAddress;

	private static int GSPreNotifyDebugCS_NotifyParam_Offset;

	private static bool GSPreNotifyDebugCS_ReturnValue_IsValid;

	private static FFieldAddress GSPreNotifyDebugCS_ReturnValue_PropertyAddress;

	private static int GSPreNotifyDebugCS_ReturnValue_Offset;

	private static bool GSPostNotifyDebugCS_IsValid;

	private IntPtr GSPostNotifyDebugCS_InstanceFunctionAddress;

	private static IntPtr GSPostNotifyDebugCS_FunctionAddress;

	private static int GSPostNotifyDebugCS_ParamsSize;

	private static bool GSPostNotifyDebugCS_NotifyParam_IsValid;

	private static FFieldAddress GSPostNotifyDebugCS_NotifyParam_PropertyAddress;

	private static int GSPostNotifyDebugCS_NotifyParam_Offset;

	private static bool GSPostNotifyDebugCS_ReturnValue_IsValid;

	private static FFieldAddress GSPostNotifyDebugCS_ReturnValue_PropertyAddress;

	private static int GSPostNotifyDebugCS_ReturnValue_Offset;

	private static bool GSNotifyCS_IsValid;

	private IntPtr GSNotifyCS_InstanceFunctionAddress;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static bool GetSoftReferences_IsValid;

	private IntPtr GetSoftReferences_InstanceFunctionAddress;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static bool GetPreloadedAssets_IsValid;

	private static IntPtr GetPreloadedAssets_FunctionAddress;

	private static int GetPreloadedAssets_ParamsSize;

	private static bool GetPreloadedAssets_ReturnValue_IsValid;

	private static FFieldAddress GetPreloadedAssets_ReturnValue_PropertyAddress;

	private static int GetPreloadedAssets_ReturnValue_Offset;

	private static bool GetJumpableSectionPrefix_IsValid;

	private IntPtr GetJumpableSectionPrefix_InstanceFunctionAddress;

	private static IntPtr GetJumpableSectionPrefix_FunctionAddress;

	private static int GetJumpableSectionPrefix_ParamsSize;

	private static bool GetJumpableSectionPrefix_ReturnValue_IsValid;

	private static FFieldAddress GetJumpableSectionPrefix_ReturnValue_PropertyAddress;

	private static int GetJumpableSectionPrefix_ReturnValue_Offset;

	private static bool GetAnimNType_IsValid;

	private IntPtr GetAnimNType_InstanceFunctionAddress;

	private static IntPtr GetAnimNType_FunctionAddress;

	private static int GetAnimNType_ParamsSize;

	private static bool GetAnimNType_ReturnValue_IsValid;

	private static FFieldAddress GetAnimNType_ReturnValue_PropertyAddress;

	private static int GetAnimNType_ReturnValue_Offset;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private IntPtr bIsNativeBranchingPointCS_InstanceFunctionAddress;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static bool AddPreloadedAsset_IsValid;

	private static IntPtr AddPreloadedAsset_FunctionAddress;

	private static int AddPreloadedAsset_ParamsSize;

	private static bool AddPreloadedAsset_Obj_IsValid;

	private static FFieldAddress AddPreloadedAsset_Obj_PropertyAddress;

	private static int AddPreloadedAsset_Obj_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:CanBePlacedInASCS")]
	protected bool CanBePlacedInASCS
	{
		get
		{
			CheckDestroyed();
			if (!CanBePlacedInASCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSBase:CanBePlacedInASCS");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanBePlacedInASCS_Offset), 0, CanBePlacedInASCS_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanBePlacedInASCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSBase:CanBePlacedInASCS");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanBePlacedInASCS_Offset), 0, CanBePlacedInASCS_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:isPreload")]
	public bool isPreload
	{
		get
		{
			CheckDestroyed();
			if (!isPreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSBase:isPreload");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, isPreload_Offset), 0, isPreload_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!isPreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSBase:isPreload");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, isPreload_Offset), 0, isPreload_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013205uL)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:NotifyNameForShow")]
	public FName NotifyNameForShow
	{
		get
		{
			CheckDestroyed();
			if (!NotifyNameForShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSBase:NotifyNameForShow");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NotifyNameForShow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyNameForShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSBase:NotifyNameForShow");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NotifyNameForShow_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:GSValidateInputCS")]
	public unsafe void GSValidateInputCS(AActor actor)
	{
		CheckDestroyed();
		if (!GSValidateInputCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GSValidateInputCS");
			return;
		}
		if (GSValidateInputCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSValidateInputCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSValidateInputCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSValidateInputCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSValidateInputCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GSValidateInputCS_actor_Offset), 0, GSValidateInputCS_actor_PropertyAddress.Address, actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSValidateInputCS_InstanceFunctionAddress, intPtr, GSValidateInputCS_ParamsSize);
	}

	protected unsafe virtual void GSValidateInputCS_Implementation(AActor actor)
	{
		CheckDestroyed();
		if (!GSValidateInputCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GSValidateInputCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSValidateInputCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSValidateInputCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GSValidateInputCS_actor_Offset), 0, GSValidateInputCS_actor_PropertyAddress.Address, actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSValidateInputCS_FunctionAddress, intPtr, GSValidateInputCS_ParamsSize);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:GSPreNotifyDebugCS")]
	protected unsafe int GSPreNotifyDebugCS(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSPreNotifyDebugCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GSPreNotifyDebugCS");
			return 0;
		}
		if (GSPreNotifyDebugCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSPreNotifyDebugCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSPreNotifyDebugCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSPreNotifyDebugCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSPreNotifyDebugCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSPreNotifyDebugCS_NotifyParam_Offset), 0, GSPreNotifyDebugCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSPreNotifyDebugCS_InstanceFunctionAddress, intPtr, GSPreNotifyDebugCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSPreNotifyDebugCS_ReturnValue_Offset), 0, GSPreNotifyDebugCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GSPreNotifyDebugCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSPreNotifyDebugCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GSPreNotifyDebugCS");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSPreNotifyDebugCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSPreNotifyDebugCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSPreNotifyDebugCS_NotifyParam_Offset), 0, GSPreNotifyDebugCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSPreNotifyDebugCS_FunctionAddress, intPtr, GSPreNotifyDebugCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSPreNotifyDebugCS_ReturnValue_Offset), 0, GSPreNotifyDebugCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:GSPostNotifyDebugCS")]
	protected unsafe int GSPostNotifyDebugCS(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSPostNotifyDebugCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GSPostNotifyDebugCS");
			return 0;
		}
		if (GSPostNotifyDebugCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSPostNotifyDebugCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSPostNotifyDebugCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSPostNotifyDebugCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSPostNotifyDebugCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSPostNotifyDebugCS_NotifyParam_Offset), 0, GSPostNotifyDebugCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSPostNotifyDebugCS_InstanceFunctionAddress, intPtr, GSPostNotifyDebugCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSPostNotifyDebugCS_ReturnValue_Offset), 0, GSPostNotifyDebugCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GSPostNotifyDebugCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSPostNotifyDebugCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GSPostNotifyDebugCS");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSPostNotifyDebugCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSPostNotifyDebugCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSPostNotifyDebugCS_NotifyParam_Offset), 0, GSPostNotifyDebugCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSPostNotifyDebugCS_FunctionAddress, intPtr, GSPostNotifyDebugCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSPostNotifyDebugCS_ReturnValue_Offset), 0, GSPostNotifyDebugCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:GSNotifyCS")]
	protected unsafe void GSNotifyCS(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GSNotifyCS");
			return;
		}
		if (GSNotifyCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNotifyCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNotifyCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyCS_NotifyParam_Offset), 0, GSNotifyCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyCS_InstanceFunctionAddress, intPtr, GSNotifyCS_ParamsSize);
	}

	protected unsafe virtual void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GSNotifyCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyCS_NotifyParam_Offset), 0, GSNotifyCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyCS_FunctionAddress, intPtr, GSNotifyCS_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:GetSoftReferences")]
	public unsafe List<FSoftObjectPath> GetSoftReferences()
	{
		CheckDestroyed();
		if (!GetSoftReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GetSoftReferences");
			return null;
		}
		if (GetSoftReferences_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetSoftReferences_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetSoftReferences");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSoftReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSoftReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSoftReferences_InstanceFunctionAddress, intPtr, GetSoftReferences_ParamsSize);
		List<FSoftObjectPath> result = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).FromNative(IntPtr.Add(intPtr, GetSoftReferences_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSoftReferences_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		CheckDestroyed();
		if (!GetSoftReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GetSoftReferences");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSoftReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSoftReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSoftReferences_FunctionAddress, intPtr, GetSoftReferences_ParamsSize);
		List<FSoftObjectPath> result = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).FromNative(IntPtr.Add(intPtr, GetSoftReferences_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSoftReferences_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:GetPreloadedAssets")]
	public unsafe List<UObject> GetPreloadedAssets()
	{
		CheckDestroyed();
		if (!GetPreloadedAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GetPreloadedAssets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreloadedAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreloadedAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreloadedAssets_FunctionAddress, intPtr, GetPreloadedAssets_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetPreloadedAssets_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPreloadedAssets_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPreloadedAssets_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:GetJumpableSectionPrefix")]
	public unsafe string GetJumpableSectionPrefix()
	{
		CheckDestroyed();
		if (!GetJumpableSectionPrefix_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GetJumpableSectionPrefix");
			return FStringMarshaler.DefaultString;
		}
		if (GetJumpableSectionPrefix_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetJumpableSectionPrefix_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetJumpableSectionPrefix");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetJumpableSectionPrefix_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetJumpableSectionPrefix_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetJumpableSectionPrefix_InstanceFunctionAddress, intPtr, GetJumpableSectionPrefix_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetJumpableSectionPrefix_ReturnValue_Offset), 0, GetJumpableSectionPrefix_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetJumpableSectionPrefix_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetJumpableSectionPrefix_Implementation()
	{
		CheckDestroyed();
		if (!GetJumpableSectionPrefix_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GetJumpableSectionPrefix");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetJumpableSectionPrefix_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetJumpableSectionPrefix_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetJumpableSectionPrefix_FunctionAddress, intPtr, GetJumpableSectionPrefix_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetJumpableSectionPrefix_ReturnValue_Offset), 0, GetJumpableSectionPrefix_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetJumpableSectionPrefix_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:GetAnimNType")]
	public unsafe EGsEnAnimN GetAnimNType()
	{
		CheckDestroyed();
		if (!GetAnimNType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GetAnimNType");
			return EGsEnAnimN.None;
		}
		if (GetAnimNType_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAnimNType_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAnimNType");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimNType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimNType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimNType_InstanceFunctionAddress, intPtr, GetAnimNType_ParamsSize);
		return EnumMarshaler<EGsEnAnimN>.FromNative(IntPtr.Add(intPtr, GetAnimNType_ReturnValue_Offset), 0, GetAnimNType_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual EGsEnAnimN GetAnimNType_Implementation()
	{
		CheckDestroyed();
		if (!GetAnimNType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:GetAnimNType");
			return EGsEnAnimN.None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimNType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimNType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimNType_FunctionAddress, intPtr, GetAnimNType_ParamsSize);
		return EnumMarshaler<EGsEnAnimN>.FromNative(IntPtr.Add(intPtr, GetAnimNType_ReturnValue_Offset), 0, GetAnimNType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:bIsNativeBranchingPointCS")]
	public unsafe bool bIsNativeBranchingPointCS()
	{
		CheckDestroyed();
		if (!bIsNativeBranchingPointCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:bIsNativeBranchingPointCS");
			return false;
		}
		if (bIsNativeBranchingPointCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			bIsNativeBranchingPointCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "bIsNativeBranchingPointCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(bIsNativeBranchingPointCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)bIsNativeBranchingPointCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, bIsNativeBranchingPointCS_InstanceFunctionAddress, intPtr, bIsNativeBranchingPointCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool bIsNativeBranchingPointCS_Implementation()
	{
		CheckDestroyed();
		if (!bIsNativeBranchingPointCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:bIsNativeBranchingPointCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(bIsNativeBranchingPointCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)bIsNativeBranchingPointCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, bIsNativeBranchingPointCS_FunctionAddress, intPtr, bIsNativeBranchingPointCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/b1.AnimNotify_GSBase:AddPreloadedAsset")]
	public unsafe void AddPreloadedAsset(UObject Obj)
	{
		CheckDestroyed();
		if (!AddPreloadedAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotify_GSBase:AddPreloadedAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPreloadedAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPreloadedAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddPreloadedAsset_Obj_Offset), 0, AddPreloadedAsset_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddPreloadedAsset_FunctionAddress, intPtr, AddPreloadedAsset_ParamsSize);
	}

	static UAnimNotify_GSBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotify_GSBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotify_GSBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.AnimNotify_GSBase");
		NativeReflectionCached.GetPropertyRef(ref CanBePlacedInASCS_PropertyAddress, intPtr, "CanBePlacedInASCS");
		CanBePlacedInASCS_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CanBePlacedInASCS");
		CanBePlacedInASCS_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CanBePlacedInASCS", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref isPreload_PropertyAddress, intPtr, "isPreload");
		isPreload_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "isPreload");
		isPreload_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "isPreload", Classes.FBoolProperty);
		NotifyNameForShow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyNameForShow");
		NotifyNameForShow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyNameForShow", Classes.FNameProperty);
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSValidateInputCS_actor_PropertyAddress, GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_Offset = NativeReflectionCached.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "actor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotify_GSBase:GSValidateInputCS", GSValidateInputCS_IsValid);
		GSPreNotifyDebugCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSPreNotifyDebugCS");
		GSPreNotifyDebugCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSPreNotifyDebugCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSPreNotifyDebugCS_NotifyParam_PropertyAddress, GSPreNotifyDebugCS_FunctionAddress, "NotifyParam");
		GSPreNotifyDebugCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSPreNotifyDebugCS_FunctionAddress, "NotifyParam");
		GSPreNotifyDebugCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSPreNotifyDebugCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSPreNotifyDebugCS_ReturnValue_PropertyAddress, GSPreNotifyDebugCS_FunctionAddress, "ReturnValue");
		GSPreNotifyDebugCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSPreNotifyDebugCS_FunctionAddress, "ReturnValue");
		GSPreNotifyDebugCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSPreNotifyDebugCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSPreNotifyDebugCS_IsValid = GSPreNotifyDebugCS_FunctionAddress != IntPtr.Zero && GSPreNotifyDebugCS_NotifyParam_IsValid && GSPreNotifyDebugCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotify_GSBase:GSPreNotifyDebugCS", GSPreNotifyDebugCS_IsValid);
		GSPostNotifyDebugCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSPostNotifyDebugCS");
		GSPostNotifyDebugCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSPostNotifyDebugCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSPostNotifyDebugCS_NotifyParam_PropertyAddress, GSPostNotifyDebugCS_FunctionAddress, "NotifyParam");
		GSPostNotifyDebugCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSPostNotifyDebugCS_FunctionAddress, "NotifyParam");
		GSPostNotifyDebugCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSPostNotifyDebugCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSPostNotifyDebugCS_ReturnValue_PropertyAddress, GSPostNotifyDebugCS_FunctionAddress, "ReturnValue");
		GSPostNotifyDebugCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSPostNotifyDebugCS_FunctionAddress, "ReturnValue");
		GSPostNotifyDebugCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSPostNotifyDebugCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSPostNotifyDebugCS_IsValid = GSPostNotifyDebugCS_FunctionAddress != IntPtr.Zero && GSPostNotifyDebugCS_NotifyParam_IsValid && GSPostNotifyDebugCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotify_GSBase:GSPostNotifyDebugCS", GSPostNotifyDebugCS_IsValid);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotify_GSBase:GSNotifyCS", GSNotifyCS_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotify_GSBase:GetSoftReferences", GetSoftReferences_IsValid);
		GetPreloadedAssets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPreloadedAssets");
		GetPreloadedAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreloadedAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreloadedAssets_ReturnValue_PropertyAddress, GetPreloadedAssets_FunctionAddress, "ReturnValue");
		GetPreloadedAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreloadedAssets_FunctionAddress, "ReturnValue");
		GetPreloadedAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreloadedAssets_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPreloadedAssets_IsValid = GetPreloadedAssets_FunctionAddress != IntPtr.Zero && GetPreloadedAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotify_GSBase:GetPreloadedAssets", GetPreloadedAssets_IsValid);
		GetJumpableSectionPrefix_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetJumpableSectionPrefix");
		GetJumpableSectionPrefix_ParamsSize = NativeReflection.GetFunctionParamsSize(GetJumpableSectionPrefix_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetJumpableSectionPrefix_ReturnValue_PropertyAddress, GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetJumpableSectionPrefix_IsValid = GetJumpableSectionPrefix_FunctionAddress != IntPtr.Zero && GetJumpableSectionPrefix_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotify_GSBase:GetJumpableSectionPrefix", GetJumpableSectionPrefix_IsValid);
		GetAnimNType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNType");
		GetAnimNType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimNType_ReturnValue_PropertyAddress, GetAnimNType_FunctionAddress, "ReturnValue");
		GetAnimNType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimNType_FunctionAddress, "ReturnValue");
		GetAnimNType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimNType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNType_IsValid = GetAnimNType_FunctionAddress != IntPtr.Zero && GetAnimNType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotify_GSBase:GetAnimNType", GetAnimNType_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotify_GSBase:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
		AddPreloadedAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddPreloadedAsset");
		AddPreloadedAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPreloadedAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPreloadedAsset_Obj_PropertyAddress, AddPreloadedAsset_FunctionAddress, "Obj");
		AddPreloadedAsset_Obj_Offset = NativeReflectionCached.GetPropertyOffset(AddPreloadedAsset_FunctionAddress, "Obj");
		AddPreloadedAsset_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPreloadedAsset_FunctionAddress, "Obj", Classes.FObjectProperty);
		AddPreloadedAsset_IsValid = AddPreloadedAsset_FunctionAddress != IntPtr.Zero && AddPreloadedAsset_Obj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotify_GSBase:AddPreloadedAsset", AddPreloadedAsset_IsValid);
	}
}
