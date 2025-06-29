using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary", "AnimGraphRuntime", UnrealModuleType.Engine)]
public class USequencePlayerLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetStartPosition_IsValid;

	private static IntPtr SetStartPosition_FunctionAddress;

	private static int SetStartPosition_ParamsSize;

	private static bool SetStartPosition_SequencePlayer_IsValid;

	private static FFieldAddress SetStartPosition_SequencePlayer_PropertyAddress;

	private static int SetStartPosition_SequencePlayer_Offset;

	private static bool SetStartPosition_StartPosition_IsValid;

	private static FFieldAddress SetStartPosition_StartPosition_PropertyAddress;

	private static int SetStartPosition_StartPosition_Offset;

	private static bool SetStartPosition_ReturnValue_IsValid;

	private static FFieldAddress SetStartPosition_ReturnValue_PropertyAddress;

	private static int SetStartPosition_ReturnValue_Offset;

	private static bool SetSequenceWithInertialBlending_IsValid;

	private static IntPtr SetSequenceWithInertialBlending_FunctionAddress;

	private static int SetSequenceWithInertialBlending_ParamsSize;

	private static bool SetSequenceWithInertialBlending_UpdateContext_IsValid;

	private static FFieldAddress SetSequenceWithInertialBlending_UpdateContext_PropertyAddress;

	private static int SetSequenceWithInertialBlending_UpdateContext_Offset;

	private static bool SetSequenceWithInertialBlending_SequencePlayer_IsValid;

	private static FFieldAddress SetSequenceWithInertialBlending_SequencePlayer_PropertyAddress;

	private static int SetSequenceWithInertialBlending_SequencePlayer_Offset;

	private static bool SetSequenceWithInertialBlending_Sequence_IsValid;

	private static FFieldAddress SetSequenceWithInertialBlending_Sequence_PropertyAddress;

	private static int SetSequenceWithInertialBlending_Sequence_Offset;

	private static bool SetSequenceWithInertialBlending_BlendTime_IsValid;

	private static FFieldAddress SetSequenceWithInertialBlending_BlendTime_PropertyAddress;

	private static int SetSequenceWithInertialBlending_BlendTime_Offset;

	private static bool SetSequenceWithInertialBlending_ReturnValue_IsValid;

	private static FFieldAddress SetSequenceWithInertialBlending_ReturnValue_PropertyAddress;

	private static int SetSequenceWithInertialBlending_ReturnValue_Offset;

	private static bool SetSequence_IsValid;

	private static IntPtr SetSequence_FunctionAddress;

	private static int SetSequence_ParamsSize;

	private static bool SetSequence_SequencePlayer_IsValid;

	private static FFieldAddress SetSequence_SequencePlayer_PropertyAddress;

	private static int SetSequence_SequencePlayer_Offset;

	private static bool SetSequence_Sequence_IsValid;

	private static FFieldAddress SetSequence_Sequence_PropertyAddress;

	private static int SetSequence_Sequence_Offset;

	private static bool SetSequence_ReturnValue_IsValid;

	private static FFieldAddress SetSequence_ReturnValue_PropertyAddress;

	private static int SetSequence_ReturnValue_Offset;

	private static bool SetPlayRate_IsValid;

	private static IntPtr SetPlayRate_FunctionAddress;

	private static int SetPlayRate_ParamsSize;

	private static bool SetPlayRate_SequencePlayer_IsValid;

	private static FFieldAddress SetPlayRate_SequencePlayer_PropertyAddress;

	private static int SetPlayRate_SequencePlayer_Offset;

	private static bool SetPlayRate_PlayRate_IsValid;

	private static FFieldAddress SetPlayRate_PlayRate_PropertyAddress;

	private static int SetPlayRate_PlayRate_Offset;

	private static bool SetPlayRate_ReturnValue_IsValid;

	private static FFieldAddress SetPlayRate_ReturnValue_PropertyAddress;

	private static int SetPlayRate_ReturnValue_Offset;

	private static bool SetAccumulatedTime_IsValid;

	private static IntPtr SetAccumulatedTime_FunctionAddress;

	private static int SetAccumulatedTime_ParamsSize;

	private static bool SetAccumulatedTime_SequencePlayer_IsValid;

	private static FFieldAddress SetAccumulatedTime_SequencePlayer_PropertyAddress;

	private static int SetAccumulatedTime_SequencePlayer_Offset;

	private static bool SetAccumulatedTime_Time_IsValid;

	private static FFieldAddress SetAccumulatedTime_Time_PropertyAddress;

	private static int SetAccumulatedTime_Time_Offset;

	private static bool SetAccumulatedTime_ReturnValue_IsValid;

	private static FFieldAddress SetAccumulatedTime_ReturnValue_PropertyAddress;

	private static int SetAccumulatedTime_ReturnValue_Offset;

	private static bool GetStartPosition_IsValid;

	private static IntPtr GetStartPosition_FunctionAddress;

	private static int GetStartPosition_ParamsSize;

	private static bool GetStartPosition_SequencePlayer_IsValid;

	private static FFieldAddress GetStartPosition_SequencePlayer_PropertyAddress;

	private static int GetStartPosition_SequencePlayer_Offset;

	private static bool GetStartPosition_ReturnValue_IsValid;

	private static FFieldAddress GetStartPosition_ReturnValue_PropertyAddress;

	private static int GetStartPosition_ReturnValue_Offset;

	private static bool GetSequencePure_IsValid;

	private static IntPtr GetSequencePure_FunctionAddress;

	private static int GetSequencePure_ParamsSize;

	private static bool GetSequencePure_SequencePlayer_IsValid;

	private static FFieldAddress GetSequencePure_SequencePlayer_PropertyAddress;

	private static int GetSequencePure_SequencePlayer_Offset;

	private static bool GetSequencePure_ReturnValue_IsValid;

	private static FFieldAddress GetSequencePure_ReturnValue_PropertyAddress;

	private static int GetSequencePure_ReturnValue_Offset;

	private static bool GetPlayRate_IsValid;

	private static IntPtr GetPlayRate_FunctionAddress;

	private static int GetPlayRate_ParamsSize;

	private static bool GetPlayRate_SequencePlayer_IsValid;

	private static FFieldAddress GetPlayRate_SequencePlayer_PropertyAddress;

	private static int GetPlayRate_SequencePlayer_Offset;

	private static bool GetPlayRate_ReturnValue_IsValid;

	private static FFieldAddress GetPlayRate_ReturnValue_PropertyAddress;

	private static int GetPlayRate_ReturnValue_Offset;

	private static bool GetLoopAnimation_IsValid;

	private static IntPtr GetLoopAnimation_FunctionAddress;

	private static int GetLoopAnimation_ParamsSize;

	private static bool GetLoopAnimation_SequencePlayer_IsValid;

	private static FFieldAddress GetLoopAnimation_SequencePlayer_PropertyAddress;

	private static int GetLoopAnimation_SequencePlayer_Offset;

	private static bool GetLoopAnimation_ReturnValue_IsValid;

	private static FFieldAddress GetLoopAnimation_ReturnValue_PropertyAddress;

	private static int GetLoopAnimation_ReturnValue_Offset;

	private static bool GetAccumulatedTime_IsValid;

	private static IntPtr GetAccumulatedTime_FunctionAddress;

	private static int GetAccumulatedTime_ParamsSize;

	private static bool GetAccumulatedTime_SequencePlayer_IsValid;

	private static FFieldAddress GetAccumulatedTime_SequencePlayer_PropertyAddress;

	private static int GetAccumulatedTime_SequencePlayer_Offset;

	private static bool GetAccumulatedTime_ReturnValue_IsValid;

	private static FFieldAddress GetAccumulatedTime_ReturnValue_PropertyAddress;

	private static int GetAccumulatedTime_ReturnValue_Offset;

	private static bool ConvertToSequencePlayerPure_IsValid;

	private static IntPtr ConvertToSequencePlayerPure_FunctionAddress;

	private static int ConvertToSequencePlayerPure_ParamsSize;

	private static bool ConvertToSequencePlayerPure_Node_IsValid;

	private static FFieldAddress ConvertToSequencePlayerPure_Node_PropertyAddress;

	private static int ConvertToSequencePlayerPure_Node_Offset;

	private static bool ConvertToSequencePlayerPure_SequencePlayer_IsValid;

	private static FFieldAddress ConvertToSequencePlayerPure_SequencePlayer_PropertyAddress;

	private static int ConvertToSequencePlayerPure_SequencePlayer_Offset;

	private static bool ConvertToSequencePlayerPure_Result_IsValid;

	private static FFieldAddress ConvertToSequencePlayerPure_Result_PropertyAddress;

	private static int ConvertToSequencePlayerPure_Result_Offset;

	private static bool ConvertToSequencePlayer_IsValid;

	private static IntPtr ConvertToSequencePlayer_FunctionAddress;

	private static int ConvertToSequencePlayer_ParamsSize;

	private static bool ConvertToSequencePlayer_Node_IsValid;

	private static FFieldAddress ConvertToSequencePlayer_Node_PropertyAddress;

	private static int ConvertToSequencePlayer_Node_Offset;

	private static bool ConvertToSequencePlayer_Result_IsValid;

	private static FFieldAddress ConvertToSequencePlayer_Result_PropertyAddress;

	private static int ConvertToSequencePlayer_Result_Offset;

	private static bool ConvertToSequencePlayer_ReturnValue_IsValid;

	private static FFieldAddress ConvertToSequencePlayer_ReturnValue_PropertyAddress;

	private static int ConvertToSequencePlayer_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetStartPosition")]
	public unsafe static FSequencePlayerReference SetStartPosition(FSequencePlayerReference SequencePlayer, float StartPosition)
	{
		if (!SetStartPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetStartPosition");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetStartPosition_SequencePlayer_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequencePlayerReference>.ToNative(IntPtr.Add(intPtr, SetStartPosition_SequencePlayer_Offset), 0, SetStartPosition_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStartPosition_StartPosition_Offset), 0, SetStartPosition_StartPosition_PropertyAddress.Address, StartPosition);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStartPosition_FunctionAddress, intPtr, SetStartPosition_ParamsSize);
		return StructAsClassMarshaler<FSequencePlayerReference>.FromNative(IntPtr.Add(intPtr, SetStartPosition_ReturnValue_Offset), 0, SetStartPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetSequenceWithInertialBlending")]
	public unsafe static FSequencePlayerReference SetSequenceWithInertialBlending(FAnimUpdateContext UpdateContext, FSequencePlayerReference SequencePlayer, UAnimSequenceBase Sequence, float BlendTime = 0.2f)
	{
		if (!SetSequenceWithInertialBlending_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetSequenceWithInertialBlending");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSequenceWithInertialBlending_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSequenceWithInertialBlending_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSequenceWithInertialBlending_UpdateContext_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(intPtr, SetSequenceWithInertialBlending_UpdateContext_Offset), 0, SetSequenceWithInertialBlending_UpdateContext_PropertyAddress.Address, UpdateContext);
		NativeReflection.InitializeValue_InContainer(SetSequenceWithInertialBlending_SequencePlayer_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequencePlayerReference>.ToNative(IntPtr.Add(intPtr, SetSequenceWithInertialBlending_SequencePlayer_Offset), 0, SetSequenceWithInertialBlending_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, SetSequenceWithInertialBlending_Sequence_Offset), 0, SetSequenceWithInertialBlending_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSequenceWithInertialBlending_BlendTime_Offset), 0, SetSequenceWithInertialBlending_BlendTime_PropertyAddress.Address, BlendTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSequenceWithInertialBlending_FunctionAddress, intPtr, SetSequenceWithInertialBlending_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSequenceWithInertialBlending_UpdateContext_PropertyAddress.Address, intPtr);
		return StructAsClassMarshaler<FSequencePlayerReference>.FromNative(IntPtr.Add(intPtr, SetSequenceWithInertialBlending_ReturnValue_Offset), 0, SetSequenceWithInertialBlending_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetSequence")]
	public unsafe static FSequencePlayerReference SetSequence(FSequencePlayerReference SequencePlayer, UAnimSequenceBase Sequence)
	{
		if (!SetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSequence_SequencePlayer_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequencePlayerReference>.ToNative(IntPtr.Add(intPtr, SetSequence_SequencePlayer_Offset), 0, SetSequence_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, SetSequence_Sequence_Offset), 0, SetSequence_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSequence_FunctionAddress, intPtr, SetSequence_ParamsSize);
		return StructAsClassMarshaler<FSequencePlayerReference>.FromNative(IntPtr.Add(intPtr, SetSequence_ReturnValue_Offset), 0, SetSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetPlayRate")]
	public unsafe static FSequencePlayerReference SetPlayRate(FSequencePlayerReference SequencePlayer, float PlayRate)
	{
		if (!SetPlayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetPlayRate");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPlayRate_SequencePlayer_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequencePlayerReference>.ToNative(IntPtr.Add(intPtr, SetPlayRate_SequencePlayer_Offset), 0, SetPlayRate_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlayRate_PlayRate_Offset), 0, SetPlayRate_PlayRate_PropertyAddress.Address, PlayRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPlayRate_FunctionAddress, intPtr, SetPlayRate_ParamsSize);
		return StructAsClassMarshaler<FSequencePlayerReference>.FromNative(IntPtr.Add(intPtr, SetPlayRate_ReturnValue_Offset), 0, SetPlayRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetAccumulatedTime")]
	public unsafe static FSequencePlayerReference SetAccumulatedTime(FSequencePlayerReference SequencePlayer, float Time)
	{
		if (!SetAccumulatedTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetAccumulatedTime");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAccumulatedTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAccumulatedTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAccumulatedTime_SequencePlayer_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequencePlayerReference>.ToNative(IntPtr.Add(intPtr, SetAccumulatedTime_SequencePlayer_Offset), 0, SetAccumulatedTime_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAccumulatedTime_Time_Offset), 0, SetAccumulatedTime_Time_PropertyAddress.Address, Time);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAccumulatedTime_FunctionAddress, intPtr, SetAccumulatedTime_ParamsSize);
		return StructAsClassMarshaler<FSequencePlayerReference>.FromNative(IntPtr.Add(intPtr, SetAccumulatedTime_ReturnValue_Offset), 0, SetAccumulatedTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetStartPosition")]
	public unsafe static float GetStartPosition(FSequencePlayerReference SequencePlayer)
	{
		if (!GetStartPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetStartPosition");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetStartPosition_SequencePlayer_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequencePlayerReference>.ToNative(IntPtr.Add(intPtr, GetStartPosition_SequencePlayer_Offset), 0, GetStartPosition_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStartPosition_FunctionAddress, intPtr, GetStartPosition_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStartPosition_ReturnValue_Offset), 0, GetStartPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetSequencePure")]
	public unsafe static UAnimSequenceBase GetSequencePure(FSequencePlayerReference SequencePlayer)
	{
		if (!GetSequencePure_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetSequencePure");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequencePure_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequencePure_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetSequencePure_SequencePlayer_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequencePlayerReference>.ToNative(IntPtr.Add(intPtr, GetSequencePure_SequencePlayer_Offset), 0, GetSequencePure_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSequencePure_FunctionAddress, intPtr, GetSequencePure_ParamsSize);
		return UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(intPtr, GetSequencePure_ReturnValue_Offset), 0, GetSequencePure_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetPlayRate")]
	public unsafe static float GetPlayRate(FSequencePlayerReference SequencePlayer)
	{
		if (!GetPlayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetPlayRate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPlayRate_SequencePlayer_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequencePlayerReference>.ToNative(IntPtr.Add(intPtr, GetPlayRate_SequencePlayer_Offset), 0, GetPlayRate_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlayRate_FunctionAddress, intPtr, GetPlayRate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlayRate_ReturnValue_Offset), 0, GetPlayRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetLoopAnimation")]
	public unsafe static bool GetLoopAnimation(FSequencePlayerReference SequencePlayer)
	{
		if (!GetLoopAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetLoopAnimation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLoopAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLoopAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLoopAnimation_SequencePlayer_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequencePlayerReference>.ToNative(IntPtr.Add(intPtr, GetLoopAnimation_SequencePlayer_Offset), 0, GetLoopAnimation_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLoopAnimation_FunctionAddress, intPtr, GetLoopAnimation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLoopAnimation_ReturnValue_Offset), 0, GetLoopAnimation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetAccumulatedTime")]
	public unsafe static float GetAccumulatedTime(FSequencePlayerReference SequencePlayer)
	{
		if (!GetAccumulatedTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetAccumulatedTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAccumulatedTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAccumulatedTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAccumulatedTime_SequencePlayer_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequencePlayerReference>.ToNative(IntPtr.Add(intPtr, GetAccumulatedTime_SequencePlayer_Offset), 0, GetAccumulatedTime_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAccumulatedTime_FunctionAddress, intPtr, GetAccumulatedTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAccumulatedTime_ReturnValue_Offset), 0, GetAccumulatedTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:ConvertToSequencePlayerPure")]
	public unsafe static void ConvertToSequencePlayerPure(FAnimNodeReference Node, out FSequencePlayerReference SequencePlayer, out bool Result)
	{
		if (!ConvertToSequencePlayerPure_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:ConvertToSequencePlayerPure");
			SequencePlayer = null;
			Result = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToSequencePlayerPure_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToSequencePlayerPure_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToSequencePlayerPure_Node_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(intPtr, ConvertToSequencePlayerPure_Node_Offset), 0, ConvertToSequencePlayerPure_Node_PropertyAddress.Address, Node);
		NativeReflection.InitializeValue_InContainer(ConvertToSequencePlayerPure_SequencePlayer_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToSequencePlayerPure_FunctionAddress, intPtr, ConvertToSequencePlayerPure_ParamsSize);
		SequencePlayer = StructAsClassMarshaler<FSequencePlayerReference>.FromNative(IntPtr.Add(intPtr, ConvertToSequencePlayerPure_SequencePlayer_Offset), 0, ConvertToSequencePlayerPure_SequencePlayer_PropertyAddress.Address);
		Result = BoolMarshaler.FromNative(IntPtr.Add(intPtr, ConvertToSequencePlayerPure_Result_Offset), 0, ConvertToSequencePlayerPure_Result_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerLibrary:ConvertToSequencePlayer")]
	public unsafe static FSequencePlayerReference ConvertToSequencePlayer(FAnimNodeReference Node, out EAnimNodeReferenceConversionResult Result)
	{
		if (!ConvertToSequencePlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequencePlayerLibrary:ConvertToSequencePlayer");
			Result = EAnimNodeReferenceConversionResult.Failed;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToSequencePlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToSequencePlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToSequencePlayer_Node_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(intPtr, ConvertToSequencePlayer_Node_Offset), 0, ConvertToSequencePlayer_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToSequencePlayer_FunctionAddress, intPtr, ConvertToSequencePlayer_ParamsSize);
		Result = EnumMarshaler<EAnimNodeReferenceConversionResult>.FromNative(IntPtr.Add(intPtr, ConvertToSequencePlayer_Result_Offset), 0, ConvertToSequencePlayer_Result_PropertyAddress.Address);
		return StructAsClassMarshaler<FSequencePlayerReference>.FromNative(IntPtr.Add(intPtr, ConvertToSequencePlayer_ReturnValue_Offset), 0, ConvertToSequencePlayer_ReturnValue_PropertyAddress.Address);
	}

	static USequencePlayerLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USequencePlayerLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USequencePlayerLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AnimGraphRuntime.SequencePlayerLibrary");
		SetStartPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStartPosition");
		SetStartPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartPosition_SequencePlayer_PropertyAddress, SetStartPosition_FunctionAddress, "SequencePlayer");
		SetStartPosition_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetStartPosition_FunctionAddress, "SequencePlayer");
		SetStartPosition_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartPosition_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartPosition_StartPosition_PropertyAddress, SetStartPosition_FunctionAddress, "StartPosition");
		SetStartPosition_StartPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetStartPosition_FunctionAddress, "StartPosition");
		SetStartPosition_StartPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartPosition_FunctionAddress, "StartPosition", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartPosition_ReturnValue_PropertyAddress, SetStartPosition_FunctionAddress, "ReturnValue");
		SetStartPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStartPosition_FunctionAddress, "ReturnValue");
		SetStartPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetStartPosition_IsValid = SetStartPosition_FunctionAddress != IntPtr.Zero && SetStartPosition_SequencePlayer_IsValid && SetStartPosition_StartPosition_IsValid && SetStartPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetStartPosition", SetStartPosition_IsValid);
		SetSequenceWithInertialBlending_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSequenceWithInertialBlending");
		SetSequenceWithInertialBlending_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSequenceWithInertialBlending_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSequenceWithInertialBlending_UpdateContext_PropertyAddress, SetSequenceWithInertialBlending_FunctionAddress, "UpdateContext");
		SetSequenceWithInertialBlending_UpdateContext_Offset = NativeReflectionCached.GetPropertyOffset(SetSequenceWithInertialBlending_FunctionAddress, "UpdateContext");
		SetSequenceWithInertialBlending_UpdateContext_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequenceWithInertialBlending_FunctionAddress, "UpdateContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequenceWithInertialBlending_SequencePlayer_PropertyAddress, SetSequenceWithInertialBlending_FunctionAddress, "SequencePlayer");
		SetSequenceWithInertialBlending_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetSequenceWithInertialBlending_FunctionAddress, "SequencePlayer");
		SetSequenceWithInertialBlending_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequenceWithInertialBlending_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequenceWithInertialBlending_Sequence_PropertyAddress, SetSequenceWithInertialBlending_FunctionAddress, "Sequence");
		SetSequenceWithInertialBlending_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetSequenceWithInertialBlending_FunctionAddress, "Sequence");
		SetSequenceWithInertialBlending_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequenceWithInertialBlending_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequenceWithInertialBlending_BlendTime_PropertyAddress, SetSequenceWithInertialBlending_FunctionAddress, "BlendTime");
		SetSequenceWithInertialBlending_BlendTime_Offset = NativeReflectionCached.GetPropertyOffset(SetSequenceWithInertialBlending_FunctionAddress, "BlendTime");
		SetSequenceWithInertialBlending_BlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequenceWithInertialBlending_FunctionAddress, "BlendTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequenceWithInertialBlending_ReturnValue_PropertyAddress, SetSequenceWithInertialBlending_FunctionAddress, "ReturnValue");
		SetSequenceWithInertialBlending_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSequenceWithInertialBlending_FunctionAddress, "ReturnValue");
		SetSequenceWithInertialBlending_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequenceWithInertialBlending_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetSequenceWithInertialBlending_IsValid = SetSequenceWithInertialBlending_FunctionAddress != IntPtr.Zero && SetSequenceWithInertialBlending_UpdateContext_IsValid && SetSequenceWithInertialBlending_SequencePlayer_IsValid && SetSequenceWithInertialBlending_Sequence_IsValid && SetSequenceWithInertialBlending_BlendTime_IsValid && SetSequenceWithInertialBlending_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetSequenceWithInertialBlending", SetSequenceWithInertialBlending_IsValid);
		SetSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSequence");
		SetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSequence_SequencePlayer_PropertyAddress, SetSequence_FunctionAddress, "SequencePlayer");
		SetSequence_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetSequence_FunctionAddress, "SequencePlayer");
		SetSequence_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequence_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequence_Sequence_PropertyAddress, SetSequence_FunctionAddress, "Sequence");
		SetSequence_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetSequence_FunctionAddress, "Sequence");
		SetSequence_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequence_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequence_ReturnValue_PropertyAddress, SetSequence_FunctionAddress, "ReturnValue");
		SetSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSequence_FunctionAddress, "ReturnValue");
		SetSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequence_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetSequence_IsValid = SetSequence_FunctionAddress != IntPtr.Zero && SetSequence_SequencePlayer_IsValid && SetSequence_Sequence_IsValid && SetSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetSequence", SetSequence_IsValid);
		SetPlayRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPlayRate");
		SetPlayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlayRate_SequencePlayer_PropertyAddress, SetPlayRate_FunctionAddress, "SequencePlayer");
		SetPlayRate_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayRate_FunctionAddress, "SequencePlayer");
		SetPlayRate_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayRate_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlayRate_PlayRate_PropertyAddress, SetPlayRate_FunctionAddress, "PlayRate");
		SetPlayRate_PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayRate_FunctionAddress, "PlayRate");
		SetPlayRate_PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayRate_FunctionAddress, "PlayRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlayRate_ReturnValue_PropertyAddress, SetPlayRate_FunctionAddress, "ReturnValue");
		SetPlayRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayRate_FunctionAddress, "ReturnValue");
		SetPlayRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayRate_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetPlayRate_IsValid = SetPlayRate_FunctionAddress != IntPtr.Zero && SetPlayRate_SequencePlayer_IsValid && SetPlayRate_PlayRate_IsValid && SetPlayRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetPlayRate", SetPlayRate_IsValid);
		SetAccumulatedTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAccumulatedTime");
		SetAccumulatedTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAccumulatedTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAccumulatedTime_SequencePlayer_PropertyAddress, SetAccumulatedTime_FunctionAddress, "SequencePlayer");
		SetAccumulatedTime_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetAccumulatedTime_FunctionAddress, "SequencePlayer");
		SetAccumulatedTime_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAccumulatedTime_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAccumulatedTime_Time_PropertyAddress, SetAccumulatedTime_FunctionAddress, "Time");
		SetAccumulatedTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(SetAccumulatedTime_FunctionAddress, "Time");
		SetAccumulatedTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAccumulatedTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAccumulatedTime_ReturnValue_PropertyAddress, SetAccumulatedTime_FunctionAddress, "ReturnValue");
		SetAccumulatedTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAccumulatedTime_FunctionAddress, "ReturnValue");
		SetAccumulatedTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAccumulatedTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetAccumulatedTime_IsValid = SetAccumulatedTime_FunctionAddress != IntPtr.Zero && SetAccumulatedTime_SequencePlayer_IsValid && SetAccumulatedTime_Time_IsValid && SetAccumulatedTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:SetAccumulatedTime", SetAccumulatedTime_IsValid);
		GetStartPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStartPosition");
		GetStartPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartPosition_SequencePlayer_PropertyAddress, GetStartPosition_FunctionAddress, "SequencePlayer");
		GetStartPosition_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetStartPosition_FunctionAddress, "SequencePlayer");
		GetStartPosition_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartPosition_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStartPosition_ReturnValue_PropertyAddress, GetStartPosition_FunctionAddress, "ReturnValue");
		GetStartPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartPosition_FunctionAddress, "ReturnValue");
		GetStartPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartPosition_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStartPosition_IsValid = GetStartPosition_FunctionAddress != IntPtr.Zero && GetStartPosition_SequencePlayer_IsValid && GetStartPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetStartPosition", GetStartPosition_IsValid);
		GetSequencePure_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSequencePure");
		GetSequencePure_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequencePure_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequencePure_SequencePlayer_PropertyAddress, GetSequencePure_FunctionAddress, "SequencePlayer");
		GetSequencePure_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetSequencePure_FunctionAddress, "SequencePlayer");
		GetSequencePure_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequencePure_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSequencePure_ReturnValue_PropertyAddress, GetSequencePure_FunctionAddress, "ReturnValue");
		GetSequencePure_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequencePure_FunctionAddress, "ReturnValue");
		GetSequencePure_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequencePure_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSequencePure_IsValid = GetSequencePure_FunctionAddress != IntPtr.Zero && GetSequencePure_SequencePlayer_IsValid && GetSequencePure_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetSequencePure", GetSequencePure_IsValid);
		GetPlayRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlayRate");
		GetPlayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayRate_SequencePlayer_PropertyAddress, GetPlayRate_FunctionAddress, "SequencePlayer");
		GetPlayRate_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayRate_FunctionAddress, "SequencePlayer");
		GetPlayRate_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayRate_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayRate_ReturnValue_PropertyAddress, GetPlayRate_FunctionAddress, "ReturnValue");
		GetPlayRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayRate_FunctionAddress, "ReturnValue");
		GetPlayRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayRate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlayRate_IsValid = GetPlayRate_FunctionAddress != IntPtr.Zero && GetPlayRate_SequencePlayer_IsValid && GetPlayRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetPlayRate", GetPlayRate_IsValid);
		GetLoopAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLoopAnimation");
		GetLoopAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLoopAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLoopAnimation_SequencePlayer_PropertyAddress, GetLoopAnimation_FunctionAddress, "SequencePlayer");
		GetLoopAnimation_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetLoopAnimation_FunctionAddress, "SequencePlayer");
		GetLoopAnimation_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLoopAnimation_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLoopAnimation_ReturnValue_PropertyAddress, GetLoopAnimation_FunctionAddress, "ReturnValue");
		GetLoopAnimation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLoopAnimation_FunctionAddress, "ReturnValue");
		GetLoopAnimation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLoopAnimation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetLoopAnimation_IsValid = GetLoopAnimation_FunctionAddress != IntPtr.Zero && GetLoopAnimation_SequencePlayer_IsValid && GetLoopAnimation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetLoopAnimation", GetLoopAnimation_IsValid);
		GetAccumulatedTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAccumulatedTime");
		GetAccumulatedTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAccumulatedTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAccumulatedTime_SequencePlayer_PropertyAddress, GetAccumulatedTime_FunctionAddress, "SequencePlayer");
		GetAccumulatedTime_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetAccumulatedTime_FunctionAddress, "SequencePlayer");
		GetAccumulatedTime_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAccumulatedTime_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAccumulatedTime_ReturnValue_PropertyAddress, GetAccumulatedTime_FunctionAddress, "ReturnValue");
		GetAccumulatedTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAccumulatedTime_FunctionAddress, "ReturnValue");
		GetAccumulatedTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAccumulatedTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAccumulatedTime_IsValid = GetAccumulatedTime_FunctionAddress != IntPtr.Zero && GetAccumulatedTime_SequencePlayer_IsValid && GetAccumulatedTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:GetAccumulatedTime", GetAccumulatedTime_IsValid);
		ConvertToSequencePlayerPure_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToSequencePlayerPure");
		ConvertToSequencePlayerPure_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToSequencePlayerPure_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequencePlayerPure_Node_PropertyAddress, ConvertToSequencePlayerPure_FunctionAddress, "Node");
		ConvertToSequencePlayerPure_Node_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequencePlayerPure_FunctionAddress, "Node");
		ConvertToSequencePlayerPure_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequencePlayerPure_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequencePlayerPure_SequencePlayer_PropertyAddress, ConvertToSequencePlayerPure_FunctionAddress, "SequencePlayer");
		ConvertToSequencePlayerPure_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequencePlayerPure_FunctionAddress, "SequencePlayer");
		ConvertToSequencePlayerPure_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequencePlayerPure_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequencePlayerPure_Result_PropertyAddress, ConvertToSequencePlayerPure_FunctionAddress, "Result");
		ConvertToSequencePlayerPure_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequencePlayerPure_FunctionAddress, "Result");
		ConvertToSequencePlayerPure_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequencePlayerPure_FunctionAddress, "Result", Classes.FBoolProperty);
		ConvertToSequencePlayerPure_IsValid = ConvertToSequencePlayerPure_FunctionAddress != IntPtr.Zero && ConvertToSequencePlayerPure_Node_IsValid && ConvertToSequencePlayerPure_SequencePlayer_IsValid && ConvertToSequencePlayerPure_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:ConvertToSequencePlayerPure", ConvertToSequencePlayerPure_IsValid);
		ConvertToSequencePlayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToSequencePlayer");
		ConvertToSequencePlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToSequencePlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequencePlayer_Node_PropertyAddress, ConvertToSequencePlayer_FunctionAddress, "Node");
		ConvertToSequencePlayer_Node_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequencePlayer_FunctionAddress, "Node");
		ConvertToSequencePlayer_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequencePlayer_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequencePlayer_Result_PropertyAddress, ConvertToSequencePlayer_FunctionAddress, "Result");
		ConvertToSequencePlayer_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequencePlayer_FunctionAddress, "Result");
		ConvertToSequencePlayer_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequencePlayer_FunctionAddress, "Result", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequencePlayer_ReturnValue_PropertyAddress, ConvertToSequencePlayer_FunctionAddress, "ReturnValue");
		ConvertToSequencePlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequencePlayer_FunctionAddress, "ReturnValue");
		ConvertToSequencePlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequencePlayer_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertToSequencePlayer_IsValid = ConvertToSequencePlayer_FunctionAddress != IntPtr.Zero && ConvertToSequencePlayer_Node_IsValid && ConvertToSequencePlayer_Result_IsValid && ConvertToSequencePlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequencePlayerLibrary:ConvertToSequencePlayer", ConvertToSequencePlayer_IsValid);
	}
}
