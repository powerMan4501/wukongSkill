using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PoseAsset", "Engine", UnrealModuleType.Engine)]
public class UPoseAsset : UAnimationAsset
{
	private static bool UpdatePoseFromAnimation_IsValid;

	private static IntPtr UpdatePoseFromAnimation_FunctionAddress;

	private static int UpdatePoseFromAnimation_ParamsSize;

	private static bool UpdatePoseFromAnimation_AnimSequence_IsValid;

	private static FFieldAddress UpdatePoseFromAnimation_AnimSequence_PropertyAddress;

	private static int UpdatePoseFromAnimation_AnimSequence_Offset;

	private static bool RenamePose_IsValid;

	private static IntPtr RenamePose_FunctionAddress;

	private static int RenamePose_ParamsSize;

	private static bool RenamePose_OriginalPoseName_IsValid;

	private static FFieldAddress RenamePose_OriginalPoseName_PropertyAddress;

	private static int RenamePose_OriginalPoseName_Offset;

	private static bool RenamePose_NewPoseName_IsValid;

	private static FFieldAddress RenamePose_NewPoseName_PropertyAddress;

	private static int RenamePose_NewPoseName_Offset;

	private static bool GetPoseNames_IsValid;

	private static IntPtr GetPoseNames_FunctionAddress;

	private static int GetPoseNames_ParamsSize;

	private static bool GetPoseNames_PoseNames_IsValid;

	private static FFieldAddress GetPoseNames_PoseNames_PropertyAddress;

	private static int GetPoseNames_PoseNames_Offset;

	[UFunction(Flags = 604111875u)]
	[UMetaPath("/Script/Engine.PoseAsset:UpdatePoseFromAnimation")]
	public unsafe void UpdatePoseFromAnimation(UAnimSequence AnimSequence)
	{
		CheckDestroyed();
		if (!UpdatePoseFromAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseAsset:UpdatePoseFromAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdatePoseFromAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdatePoseFromAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, UpdatePoseFromAnimation_AnimSequence_Offset), 0, UpdatePoseFromAnimation_AnimSequence_PropertyAddress.Address, AnimSequence);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdatePoseFromAnimation_FunctionAddress, intPtr, UpdatePoseFromAnimation_ParamsSize);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/Engine.PoseAsset:RenamePose")]
	public unsafe void RenamePose(FName OriginalPoseName, FName NewPoseName)
	{
		CheckDestroyed();
		if (!RenamePose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseAsset:RenamePose");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenamePose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenamePose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenamePose_OriginalPoseName_Offset), 0, RenamePose_OriginalPoseName_PropertyAddress.Address, OriginalPoseName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenamePose_NewPoseName_Offset), 0, RenamePose_NewPoseName_PropertyAddress.Address, NewPoseName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenamePose_FunctionAddress, intPtr, RenamePose_ParamsSize);
	}

	[UFunction(Flags = 1950483457u)]
	[UMetaPath("/Script/Engine.PoseAsset:GetPoseNames")]
	public unsafe void GetPoseNames(out List<FName> PoseNames)
	{
		CheckDestroyed();
		if (!GetPoseNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseAsset:GetPoseNames");
			PoseNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPoseNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPoseNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPoseNames_FunctionAddress, intPtr, GetPoseNames_ParamsSize);
		PoseNames = new TArrayCopyMarshaler<FName>(1, GetPoseNames_PoseNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPoseNames_PoseNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetPoseNames_PoseNames_PropertyAddress.Address, intPtr);
	}

	static UPoseAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPoseAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPoseAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.PoseAsset");
		UpdatePoseFromAnimation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdatePoseFromAnimation");
		UpdatePoseFromAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdatePoseFromAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdatePoseFromAnimation_AnimSequence_PropertyAddress, UpdatePoseFromAnimation_FunctionAddress, "AnimSequence");
		UpdatePoseFromAnimation_AnimSequence_Offset = NativeReflectionCached.GetPropertyOffset(UpdatePoseFromAnimation_FunctionAddress, "AnimSequence");
		UpdatePoseFromAnimation_AnimSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdatePoseFromAnimation_FunctionAddress, "AnimSequence", Classes.FObjectProperty);
		UpdatePoseFromAnimation_IsValid = UpdatePoseFromAnimation_FunctionAddress != IntPtr.Zero && UpdatePoseFromAnimation_AnimSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseAsset:UpdatePoseFromAnimation", UpdatePoseFromAnimation_IsValid);
		RenamePose_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RenamePose");
		RenamePose_ParamsSize = NativeReflection.GetFunctionParamsSize(RenamePose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenamePose_OriginalPoseName_PropertyAddress, RenamePose_FunctionAddress, "OriginalPoseName");
		RenamePose_OriginalPoseName_Offset = NativeReflectionCached.GetPropertyOffset(RenamePose_FunctionAddress, "OriginalPoseName");
		RenamePose_OriginalPoseName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenamePose_FunctionAddress, "OriginalPoseName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenamePose_NewPoseName_PropertyAddress, RenamePose_FunctionAddress, "NewPoseName");
		RenamePose_NewPoseName_Offset = NativeReflectionCached.GetPropertyOffset(RenamePose_FunctionAddress, "NewPoseName");
		RenamePose_NewPoseName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenamePose_FunctionAddress, "NewPoseName", Classes.FNameProperty);
		RenamePose_IsValid = RenamePose_FunctionAddress != IntPtr.Zero && RenamePose_OriginalPoseName_IsValid && RenamePose_NewPoseName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseAsset:RenamePose", RenamePose_IsValid);
		GetPoseNames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPoseNames");
		GetPoseNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPoseNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPoseNames_PoseNames_PropertyAddress, GetPoseNames_FunctionAddress, "PoseNames");
		GetPoseNames_PoseNames_Offset = NativeReflectionCached.GetPropertyOffset(GetPoseNames_FunctionAddress, "PoseNames");
		GetPoseNames_PoseNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPoseNames_FunctionAddress, "PoseNames", Classes.FArrayProperty);
		GetPoseNames_IsValid = GetPoseNames_FunctionAddress != IntPtr.Zero && GetPoseNames_PoseNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseAsset:GetPoseNames", GetPoseNames_IsValid);
	}
}
