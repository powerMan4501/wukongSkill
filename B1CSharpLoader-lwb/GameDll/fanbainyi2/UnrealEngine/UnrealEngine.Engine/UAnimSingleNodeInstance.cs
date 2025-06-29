using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938024uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimSingleNodeInstance", "Engine", UnrealModuleType.Engine)]
public class UAnimSingleNodeInstance : UAnimInstance
{
	private static bool StopAnim_IsValid;

	private static IntPtr StopAnim_FunctionAddress;

	private static int StopAnim_ParamsSize;

	private static bool SetReverse_IsValid;

	private static IntPtr SetReverse_FunctionAddress;

	private static int SetReverse_ParamsSize;

	private static bool SetReverse_bInReverse_IsValid;

	private static FFieldAddress SetReverse_bInReverse_PropertyAddress;

	private static int SetReverse_bInReverse_Offset;

	private static bool SetPreviewCurveOverride_IsValid;

	private static IntPtr SetPreviewCurveOverride_FunctionAddress;

	private static int SetPreviewCurveOverride_ParamsSize;

	private static bool SetPreviewCurveOverride_PoseName_IsValid;

	private static FFieldAddress SetPreviewCurveOverride_PoseName_PropertyAddress;

	private static int SetPreviewCurveOverride_PoseName_Offset;

	private static bool SetPreviewCurveOverride_Value_IsValid;

	private static FFieldAddress SetPreviewCurveOverride_Value_PropertyAddress;

	private static int SetPreviewCurveOverride_Value_Offset;

	private static bool SetPreviewCurveOverride_bRemoveIfZero_IsValid;

	private static FFieldAddress SetPreviewCurveOverride_bRemoveIfZero_PropertyAddress;

	private static int SetPreviewCurveOverride_bRemoveIfZero_Offset;

	private static bool SetPositionWithPreviousTime_IsValid;

	private static IntPtr SetPositionWithPreviousTime_FunctionAddress;

	private static int SetPositionWithPreviousTime_ParamsSize;

	private static bool SetPositionWithPreviousTime_InPosition_IsValid;

	private static FFieldAddress SetPositionWithPreviousTime_InPosition_PropertyAddress;

	private static int SetPositionWithPreviousTime_InPosition_Offset;

	private static bool SetPositionWithPreviousTime_InPreviousTime_IsValid;

	private static FFieldAddress SetPositionWithPreviousTime_InPreviousTime_PropertyAddress;

	private static int SetPositionWithPreviousTime_InPreviousTime_Offset;

	private static bool SetPositionWithPreviousTime_bFireNotifies_IsValid;

	private static FFieldAddress SetPositionWithPreviousTime_bFireNotifies_PropertyAddress;

	private static int SetPositionWithPreviousTime_bFireNotifies_Offset;

	private static bool SetPosition_IsValid;

	private static IntPtr SetPosition_FunctionAddress;

	private static int SetPosition_ParamsSize;

	private static bool SetPosition_InPosition_IsValid;

	private static FFieldAddress SetPosition_InPosition_PropertyAddress;

	private static int SetPosition_InPosition_Offset;

	private static bool SetPosition_bFireNotifies_IsValid;

	private static FFieldAddress SetPosition_bFireNotifies_PropertyAddress;

	private static int SetPosition_bFireNotifies_Offset;

	private static bool SetPlayRate_IsValid;

	private static IntPtr SetPlayRate_FunctionAddress;

	private static int SetPlayRate_ParamsSize;

	private static bool SetPlayRate_InPlayRate_IsValid;

	private static FFieldAddress SetPlayRate_InPlayRate_PropertyAddress;

	private static int SetPlayRate_InPlayRate_Offset;

	private static bool SetPlaying_IsValid;

	private static IntPtr SetPlaying_FunctionAddress;

	private static int SetPlaying_ParamsSize;

	private static bool SetPlaying_bIsPlaying_IsValid;

	private static FFieldAddress SetPlaying_bIsPlaying_PropertyAddress;

	private static int SetPlaying_bIsPlaying_Offset;

	private static bool SetMirrorDataTable_IsValid;

	private static IntPtr SetMirrorDataTable_FunctionAddress;

	private static int SetMirrorDataTable_ParamsSize;

	private static bool SetMirrorDataTable_MirrorDataTable_IsValid;

	private static FFieldAddress SetMirrorDataTable_MirrorDataTable_PropertyAddress;

	private static int SetMirrorDataTable_MirrorDataTable_Offset;

	private static bool SetLooping_IsValid;

	private static IntPtr SetLooping_FunctionAddress;

	private static int SetLooping_ParamsSize;

	private static bool SetLooping_bIsLooping_IsValid;

	private static FFieldAddress SetLooping_bIsLooping_PropertyAddress;

	private static int SetLooping_bIsLooping_Offset;

	private static bool SetBlendSpacePosition_IsValid;

	private static IntPtr SetBlendSpacePosition_FunctionAddress;

	private static int SetBlendSpacePosition_ParamsSize;

	private static bool SetBlendSpacePosition_InPosition_IsValid;

	private static FFieldAddress SetBlendSpacePosition_InPosition_PropertyAddress;

	private static int SetBlendSpacePosition_InPosition_Offset;

	private static bool SetAnimationAsset_IsValid;

	private static IntPtr SetAnimationAsset_FunctionAddress;

	private static int SetAnimationAsset_ParamsSize;

	private static bool SetAnimationAsset_NewAsset_IsValid;

	private static FFieldAddress SetAnimationAsset_NewAsset_PropertyAddress;

	private static int SetAnimationAsset_NewAsset_Offset;

	private static bool SetAnimationAsset_bIsLooping_IsValid;

	private static FFieldAddress SetAnimationAsset_bIsLooping_PropertyAddress;

	private static int SetAnimationAsset_bIsLooping_Offset;

	private static bool SetAnimationAsset_InPlayRate_IsValid;

	private static FFieldAddress SetAnimationAsset_InPlayRate_PropertyAddress;

	private static int SetAnimationAsset_InPlayRate_Offset;

	private static bool PlayAnim_IsValid;

	private static IntPtr PlayAnim_FunctionAddress;

	private static int PlayAnim_ParamsSize;

	private static bool PlayAnim_bIsLooping_IsValid;

	private static FFieldAddress PlayAnim_bIsLooping_PropertyAddress;

	private static int PlayAnim_bIsLooping_Offset;

	private static bool PlayAnim_InPlayRate_IsValid;

	private static FFieldAddress PlayAnim_InPlayRate_PropertyAddress;

	private static int PlayAnim_InPlayRate_Offset;

	private static bool PlayAnim_InStartPosition_IsValid;

	private static FFieldAddress PlayAnim_InStartPosition_PropertyAddress;

	private static int PlayAnim_InStartPosition_Offset;

	private static bool GetMirrorDataTable_IsValid;

	private static IntPtr GetMirrorDataTable_FunctionAddress;

	private static int GetMirrorDataTable_ParamsSize;

	private static bool GetMirrorDataTable_ReturnValue_IsValid;

	private static FFieldAddress GetMirrorDataTable_ReturnValue_PropertyAddress;

	private static int GetMirrorDataTable_ReturnValue_Offset;

	private static bool GetLength_IsValid;

	private static IntPtr GetLength_FunctionAddress;

	private static int GetLength_ParamsSize;

	private static bool GetLength_ReturnValue_IsValid;

	private static FFieldAddress GetLength_ReturnValue_PropertyAddress;

	private static int GetLength_ReturnValue_Offset;

	private static bool GetAnimationAsset_IsValid;

	private static IntPtr GetAnimationAsset_FunctionAddress;

	private static int GetAnimationAsset_ParamsSize;

	private static bool GetAnimationAsset_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationAsset_ReturnValue_PropertyAddress;

	private static int GetAnimationAsset_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:StopAnim")]
	public unsafe void StopAnim()
	{
		CheckDestroyed();
		if (!StopAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:StopAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAnim_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopAnim_FunctionAddress, argsSize: StopAnim_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:SetReverse")]
	public unsafe void SetReverse(bool bInReverse)
	{
		CheckDestroyed();
		if (!SetReverse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:SetReverse");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReverse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReverse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetReverse_bInReverse_Offset), 0, SetReverse_bInReverse_PropertyAddress.Address, bInReverse);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReverse_FunctionAddress, intPtr, SetReverse_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:SetPreviewCurveOverride")]
	public unsafe void SetPreviewCurveOverride(FName PoseName, float Value, bool bRemoveIfZero)
	{
		CheckDestroyed();
		if (!SetPreviewCurveOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:SetPreviewCurveOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPreviewCurveOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPreviewCurveOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetPreviewCurveOverride_PoseName_Offset), 0, SetPreviewCurveOverride_PoseName_PropertyAddress.Address, PoseName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPreviewCurveOverride_Value_Offset), 0, SetPreviewCurveOverride_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPreviewCurveOverride_bRemoveIfZero_Offset), 0, SetPreviewCurveOverride_bRemoveIfZero_PropertyAddress.Address, bRemoveIfZero);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPreviewCurveOverride_FunctionAddress, intPtr, SetPreviewCurveOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:SetPositionWithPreviousTime")]
	public unsafe void SetPositionWithPreviousTime(float InPosition, float InPreviousTime, bool bFireNotifies = true)
	{
		CheckDestroyed();
		if (!SetPositionWithPreviousTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:SetPositionWithPreviousTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPositionWithPreviousTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPositionWithPreviousTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPositionWithPreviousTime_InPosition_Offset), 0, SetPositionWithPreviousTime_InPosition_PropertyAddress.Address, InPosition);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPositionWithPreviousTime_InPreviousTime_Offset), 0, SetPositionWithPreviousTime_InPreviousTime_PropertyAddress.Address, InPreviousTime);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPositionWithPreviousTime_bFireNotifies_Offset), 0, SetPositionWithPreviousTime_bFireNotifies_PropertyAddress.Address, bFireNotifies);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPositionWithPreviousTime_FunctionAddress, intPtr, SetPositionWithPreviousTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:SetPosition")]
	public unsafe void SetPosition(float InPosition, bool bFireNotifies = true)
	{
		CheckDestroyed();
		if (!SetPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:SetPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPosition_InPosition_Offset), 0, SetPosition_InPosition_PropertyAddress.Address, InPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPosition_bFireNotifies_Offset), 0, SetPosition_bFireNotifies_PropertyAddress.Address, bFireNotifies);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPosition_FunctionAddress, intPtr, SetPosition_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:SetPlayRate")]
	public unsafe void SetPlayRate(float InPlayRate)
	{
		CheckDestroyed();
		if (!SetPlayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:SetPlayRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlayRate_InPlayRate_Offset), 0, SetPlayRate_InPlayRate_PropertyAddress.Address, InPlayRate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlayRate_FunctionAddress, intPtr, SetPlayRate_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:SetPlaying")]
	public unsafe void SetPlaying(bool bIsPlaying)
	{
		CheckDestroyed();
		if (!SetPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:SetPlaying");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPlaying_bIsPlaying_Offset), 0, SetPlaying_bIsPlaying_PropertyAddress.Address, bIsPlaying);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaying_FunctionAddress, intPtr, SetPlaying_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:SetMirrorDataTable")]
	public unsafe void SetMirrorDataTable(UMirrorDataTable MirrorDataTable)
	{
		CheckDestroyed();
		if (!SetMirrorDataTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:SetMirrorDataTable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMirrorDataTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMirrorDataTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMirrorDataTable>.ToNative(IntPtr.Add(intPtr, SetMirrorDataTable_MirrorDataTable_Offset), 0, SetMirrorDataTable_MirrorDataTable_PropertyAddress.Address, MirrorDataTable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMirrorDataTable_FunctionAddress, intPtr, SetMirrorDataTable_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:SetLooping")]
	public unsafe void SetLooping(bool bIsLooping)
	{
		CheckDestroyed();
		if (!SetLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:SetLooping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLooping_bIsLooping_Offset), 0, SetLooping_bIsLooping_PropertyAddress.Address, bIsLooping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLooping_FunctionAddress, intPtr, SetLooping_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:SetBlendSpacePosition")]
	public unsafe void SetBlendSpacePosition(FVector InPosition)
	{
		CheckDestroyed();
		if (!SetBlendSpacePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:SetBlendSpacePosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlendSpacePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlendSpacePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetBlendSpacePosition_InPosition_Offset), 0, SetBlendSpacePosition_InPosition_PropertyAddress.Address, InPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBlendSpacePosition_FunctionAddress, intPtr, SetBlendSpacePosition_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:SetAnimationAsset")]
	public unsafe void SetAnimationAsset(UAnimationAsset NewAsset, bool bIsLooping = true, float InPlayRate = 1f)
	{
		CheckDestroyed();
		if (!SetAnimationAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:SetAnimationAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimationAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimationAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(intPtr, SetAnimationAsset_NewAsset_Offset), 0, SetAnimationAsset_NewAsset_PropertyAddress.Address, NewAsset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAnimationAsset_bIsLooping_Offset), 0, SetAnimationAsset_bIsLooping_PropertyAddress.Address, bIsLooping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAnimationAsset_InPlayRate_Offset), 0, SetAnimationAsset_InPlayRate_PropertyAddress.Address, InPlayRate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnimationAsset_FunctionAddress, intPtr, SetAnimationAsset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:PlayAnim")]
	public unsafe void PlayAnim(bool bIsLooping = false, float InPlayRate = 1f, float InStartPosition = 0f)
	{
		CheckDestroyed();
		if (!PlayAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:PlayAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayAnim_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayAnim_bIsLooping_Offset), 0, PlayAnim_bIsLooping_PropertyAddress.Address, bIsLooping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayAnim_InPlayRate_Offset), 0, PlayAnim_InPlayRate_PropertyAddress.Address, InPlayRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayAnim_InStartPosition_Offset), 0, PlayAnim_InStartPosition_PropertyAddress.Address, InStartPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayAnim_FunctionAddress, intPtr, PlayAnim_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:GetMirrorDataTable")]
	public unsafe UMirrorDataTable GetMirrorDataTable()
	{
		CheckDestroyed();
		if (!GetMirrorDataTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:GetMirrorDataTable");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMirrorDataTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMirrorDataTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMirrorDataTable_FunctionAddress, intPtr, GetMirrorDataTable_ParamsSize);
		return UObjectMarshaler<UMirrorDataTable>.FromNative(IntPtr.Add(intPtr, GetMirrorDataTable_ReturnValue_Offset), 0, GetMirrorDataTable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:GetLength")]
	public unsafe float GetLength()
	{
		CheckDestroyed();
		if (!GetLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:GetLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLength_FunctionAddress, intPtr, GetLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLength_ReturnValue_Offset), 0, GetLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.AnimSingleNodeInstance:GetAnimationAsset")]
	public unsafe UAnimationAsset GetAnimationAsset()
	{
		CheckDestroyed();
		if (!GetAnimationAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimSingleNodeInstance:GetAnimationAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimationAsset_FunctionAddress, intPtr, GetAnimationAsset_ParamsSize);
		return UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(intPtr, GetAnimationAsset_ReturnValue_Offset), 0, GetAnimationAsset_ReturnValue_PropertyAddress.Address);
	}

	static UAnimSingleNodeInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimSingleNodeInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimSingleNodeInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.AnimSingleNodeInstance");
		StopAnim_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StopAnim");
		StopAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAnim_FunctionAddress);
		StopAnim_IsValid = StopAnim_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:StopAnim", StopAnim_IsValid);
		SetReverse_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetReverse");
		SetReverse_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReverse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReverse_bInReverse_PropertyAddress, SetReverse_FunctionAddress, "bInReverse");
		SetReverse_bInReverse_Offset = NativeReflectionCached.GetPropertyOffset(SetReverse_FunctionAddress, "bInReverse");
		SetReverse_bInReverse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReverse_FunctionAddress, "bInReverse", Classes.FBoolProperty);
		SetReverse_IsValid = SetReverse_FunctionAddress != IntPtr.Zero && SetReverse_bInReverse_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:SetReverse", SetReverse_IsValid);
		SetPreviewCurveOverride_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPreviewCurveOverride");
		SetPreviewCurveOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPreviewCurveOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewCurveOverride_PoseName_PropertyAddress, SetPreviewCurveOverride_FunctionAddress, "PoseName");
		SetPreviewCurveOverride_PoseName_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewCurveOverride_FunctionAddress, "PoseName");
		SetPreviewCurveOverride_PoseName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewCurveOverride_FunctionAddress, "PoseName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewCurveOverride_Value_PropertyAddress, SetPreviewCurveOverride_FunctionAddress, "Value");
		SetPreviewCurveOverride_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewCurveOverride_FunctionAddress, "Value");
		SetPreviewCurveOverride_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewCurveOverride_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewCurveOverride_bRemoveIfZero_PropertyAddress, SetPreviewCurveOverride_FunctionAddress, "bRemoveIfZero");
		SetPreviewCurveOverride_bRemoveIfZero_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewCurveOverride_FunctionAddress, "bRemoveIfZero");
		SetPreviewCurveOverride_bRemoveIfZero_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewCurveOverride_FunctionAddress, "bRemoveIfZero", Classes.FBoolProperty);
		SetPreviewCurveOverride_IsValid = SetPreviewCurveOverride_FunctionAddress != IntPtr.Zero && SetPreviewCurveOverride_PoseName_IsValid && SetPreviewCurveOverride_Value_IsValid && SetPreviewCurveOverride_bRemoveIfZero_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:SetPreviewCurveOverride", SetPreviewCurveOverride_IsValid);
		SetPositionWithPreviousTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPositionWithPreviousTime");
		SetPositionWithPreviousTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPositionWithPreviousTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPositionWithPreviousTime_InPosition_PropertyAddress, SetPositionWithPreviousTime_FunctionAddress, "InPosition");
		SetPositionWithPreviousTime_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionWithPreviousTime_FunctionAddress, "InPosition");
		SetPositionWithPreviousTime_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionWithPreviousTime_FunctionAddress, "InPosition", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPositionWithPreviousTime_InPreviousTime_PropertyAddress, SetPositionWithPreviousTime_FunctionAddress, "InPreviousTime");
		SetPositionWithPreviousTime_InPreviousTime_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionWithPreviousTime_FunctionAddress, "InPreviousTime");
		SetPositionWithPreviousTime_InPreviousTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionWithPreviousTime_FunctionAddress, "InPreviousTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPositionWithPreviousTime_bFireNotifies_PropertyAddress, SetPositionWithPreviousTime_FunctionAddress, "bFireNotifies");
		SetPositionWithPreviousTime_bFireNotifies_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionWithPreviousTime_FunctionAddress, "bFireNotifies");
		SetPositionWithPreviousTime_bFireNotifies_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionWithPreviousTime_FunctionAddress, "bFireNotifies", Classes.FBoolProperty);
		SetPositionWithPreviousTime_IsValid = SetPositionWithPreviousTime_FunctionAddress != IntPtr.Zero && SetPositionWithPreviousTime_InPosition_IsValid && SetPositionWithPreviousTime_InPreviousTime_IsValid && SetPositionWithPreviousTime_bFireNotifies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:SetPositionWithPreviousTime", SetPositionWithPreviousTime_IsValid);
		SetPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPosition");
		SetPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPosition_InPosition_PropertyAddress, SetPosition_FunctionAddress, "InPosition");
		SetPosition_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetPosition_FunctionAddress, "InPosition");
		SetPosition_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPosition_FunctionAddress, "InPosition", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPosition_bFireNotifies_PropertyAddress, SetPosition_FunctionAddress, "bFireNotifies");
		SetPosition_bFireNotifies_Offset = NativeReflectionCached.GetPropertyOffset(SetPosition_FunctionAddress, "bFireNotifies");
		SetPosition_bFireNotifies_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPosition_FunctionAddress, "bFireNotifies", Classes.FBoolProperty);
		SetPosition_IsValid = SetPosition_FunctionAddress != IntPtr.Zero && SetPosition_InPosition_IsValid && SetPosition_bFireNotifies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:SetPosition", SetPosition_IsValid);
		SetPlayRate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPlayRate");
		SetPlayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlayRate_InPlayRate_PropertyAddress, SetPlayRate_FunctionAddress, "InPlayRate");
		SetPlayRate_InPlayRate_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayRate_FunctionAddress, "InPlayRate");
		SetPlayRate_InPlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayRate_FunctionAddress, "InPlayRate", Classes.FFloatProperty);
		SetPlayRate_IsValid = SetPlayRate_FunctionAddress != IntPtr.Zero && SetPlayRate_InPlayRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:SetPlayRate", SetPlayRate_IsValid);
		SetPlaying_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPlaying");
		SetPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaying_bIsPlaying_PropertyAddress, SetPlaying_FunctionAddress, "bIsPlaying");
		SetPlaying_bIsPlaying_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaying_FunctionAddress, "bIsPlaying");
		SetPlaying_bIsPlaying_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaying_FunctionAddress, "bIsPlaying", Classes.FBoolProperty);
		SetPlaying_IsValid = SetPlaying_FunctionAddress != IntPtr.Zero && SetPlaying_bIsPlaying_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:SetPlaying", SetPlaying_IsValid);
		SetMirrorDataTable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMirrorDataTable");
		SetMirrorDataTable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMirrorDataTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMirrorDataTable_MirrorDataTable_PropertyAddress, SetMirrorDataTable_FunctionAddress, "MirrorDataTable");
		SetMirrorDataTable_MirrorDataTable_Offset = NativeReflectionCached.GetPropertyOffset(SetMirrorDataTable_FunctionAddress, "MirrorDataTable");
		SetMirrorDataTable_MirrorDataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMirrorDataTable_FunctionAddress, "MirrorDataTable", Classes.FObjectProperty);
		SetMirrorDataTable_IsValid = SetMirrorDataTable_FunctionAddress != IntPtr.Zero && SetMirrorDataTable_MirrorDataTable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:SetMirrorDataTable", SetMirrorDataTable_IsValid);
		SetLooping_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLooping");
		SetLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLooping_bIsLooping_PropertyAddress, SetLooping_FunctionAddress, "bIsLooping");
		SetLooping_bIsLooping_Offset = NativeReflectionCached.GetPropertyOffset(SetLooping_FunctionAddress, "bIsLooping");
		SetLooping_bIsLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLooping_FunctionAddress, "bIsLooping", Classes.FBoolProperty);
		SetLooping_IsValid = SetLooping_FunctionAddress != IntPtr.Zero && SetLooping_bIsLooping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:SetLooping", SetLooping_IsValid);
		SetBlendSpacePosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBlendSpacePosition");
		SetBlendSpacePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlendSpacePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlendSpacePosition_InPosition_PropertyAddress, SetBlendSpacePosition_FunctionAddress, "InPosition");
		SetBlendSpacePosition_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetBlendSpacePosition_FunctionAddress, "InPosition");
		SetBlendSpacePosition_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlendSpacePosition_FunctionAddress, "InPosition", Classes.FStructProperty);
		SetBlendSpacePosition_IsValid = SetBlendSpacePosition_FunctionAddress != IntPtr.Zero && SetBlendSpacePosition_InPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:SetBlendSpacePosition", SetBlendSpacePosition_IsValid);
		SetAnimationAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAnimationAsset");
		SetAnimationAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimationAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationAsset_NewAsset_PropertyAddress, SetAnimationAsset_FunctionAddress, "NewAsset");
		SetAnimationAsset_NewAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationAsset_FunctionAddress, "NewAsset");
		SetAnimationAsset_NewAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationAsset_FunctionAddress, "NewAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationAsset_bIsLooping_PropertyAddress, SetAnimationAsset_FunctionAddress, "bIsLooping");
		SetAnimationAsset_bIsLooping_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationAsset_FunctionAddress, "bIsLooping");
		SetAnimationAsset_bIsLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationAsset_FunctionAddress, "bIsLooping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationAsset_InPlayRate_PropertyAddress, SetAnimationAsset_FunctionAddress, "InPlayRate");
		SetAnimationAsset_InPlayRate_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationAsset_FunctionAddress, "InPlayRate");
		SetAnimationAsset_InPlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationAsset_FunctionAddress, "InPlayRate", Classes.FFloatProperty);
		SetAnimationAsset_IsValid = SetAnimationAsset_FunctionAddress != IntPtr.Zero && SetAnimationAsset_NewAsset_IsValid && SetAnimationAsset_bIsLooping_IsValid && SetAnimationAsset_InPlayRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:SetAnimationAsset", SetAnimationAsset_IsValid);
		PlayAnim_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PlayAnim");
		PlayAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayAnim_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayAnim_bIsLooping_PropertyAddress, PlayAnim_FunctionAddress, "bIsLooping");
		PlayAnim_bIsLooping_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnim_FunctionAddress, "bIsLooping");
		PlayAnim_bIsLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnim_FunctionAddress, "bIsLooping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnim_InPlayRate_PropertyAddress, PlayAnim_FunctionAddress, "InPlayRate");
		PlayAnim_InPlayRate_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnim_FunctionAddress, "InPlayRate");
		PlayAnim_InPlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnim_FunctionAddress, "InPlayRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnim_InStartPosition_PropertyAddress, PlayAnim_FunctionAddress, "InStartPosition");
		PlayAnim_InStartPosition_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnim_FunctionAddress, "InStartPosition");
		PlayAnim_InStartPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnim_FunctionAddress, "InStartPosition", Classes.FFloatProperty);
		PlayAnim_IsValid = PlayAnim_FunctionAddress != IntPtr.Zero && PlayAnim_bIsLooping_IsValid && PlayAnim_InPlayRate_IsValid && PlayAnim_InStartPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:PlayAnim", PlayAnim_IsValid);
		GetMirrorDataTable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMirrorDataTable");
		GetMirrorDataTable_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMirrorDataTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMirrorDataTable_ReturnValue_PropertyAddress, GetMirrorDataTable_FunctionAddress, "ReturnValue");
		GetMirrorDataTable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMirrorDataTable_FunctionAddress, "ReturnValue");
		GetMirrorDataTable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMirrorDataTable_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMirrorDataTable_IsValid = GetMirrorDataTable_FunctionAddress != IntPtr.Zero && GetMirrorDataTable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:GetMirrorDataTable", GetMirrorDataTable_IsValid);
		GetLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLength");
		GetLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLength_ReturnValue_PropertyAddress, GetLength_FunctionAddress, "ReturnValue");
		GetLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLength_FunctionAddress, "ReturnValue");
		GetLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetLength_IsValid = GetLength_FunctionAddress != IntPtr.Zero && GetLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:GetLength", GetLength_IsValid);
		GetAnimationAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAnimationAsset");
		GetAnimationAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationAsset_ReturnValue_PropertyAddress, GetAnimationAsset_FunctionAddress, "ReturnValue");
		GetAnimationAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationAsset_FunctionAddress, "ReturnValue");
		GetAnimationAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAnimationAsset_IsValid = GetAnimationAsset_FunctionAddress != IntPtr.Zero && GetAnimationAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimSingleNodeInstance:GetAnimationAsset", GetAnimationAsset_IsValid);
	}
}
