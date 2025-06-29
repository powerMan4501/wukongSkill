using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneSectionExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetStartFrameSeconds_IsValid;

	private static IntPtr SetStartFrameSeconds_FunctionAddress;

	private static int SetStartFrameSeconds_ParamsSize;

	private static bool SetStartFrameSeconds_Section_IsValid;

	private static FFieldAddress SetStartFrameSeconds_Section_PropertyAddress;

	private static int SetStartFrameSeconds_Section_Offset;

	private static bool SetStartFrameSeconds_StartTime_IsValid;

	private static FFieldAddress SetStartFrameSeconds_StartTime_PropertyAddress;

	private static int SetStartFrameSeconds_StartTime_Offset;

	private static bool SetStartFrameBounded_IsValid;

	private static IntPtr SetStartFrameBounded_FunctionAddress;

	private static int SetStartFrameBounded_ParamsSize;

	private static bool SetStartFrameBounded_Section_IsValid;

	private static FFieldAddress SetStartFrameBounded_Section_PropertyAddress;

	private static int SetStartFrameBounded_Section_Offset;

	private static bool SetStartFrameBounded_bIsBounded_IsValid;

	private static FFieldAddress SetStartFrameBounded_bIsBounded_PropertyAddress;

	private static int SetStartFrameBounded_bIsBounded_Offset;

	private static bool SetStartFrame_IsValid;

	private static IntPtr SetStartFrame_FunctionAddress;

	private static int SetStartFrame_ParamsSize;

	private static bool SetStartFrame_Section_IsValid;

	private static FFieldAddress SetStartFrame_Section_PropertyAddress;

	private static int SetStartFrame_Section_Offset;

	private static bool SetStartFrame_StartFrame_IsValid;

	private static FFieldAddress SetStartFrame_StartFrame_PropertyAddress;

	private static int SetStartFrame_StartFrame_Offset;

	private static bool SetRangeSeconds_IsValid;

	private static IntPtr SetRangeSeconds_FunctionAddress;

	private static int SetRangeSeconds_ParamsSize;

	private static bool SetRangeSeconds_Section_IsValid;

	private static FFieldAddress SetRangeSeconds_Section_PropertyAddress;

	private static int SetRangeSeconds_Section_Offset;

	private static bool SetRangeSeconds_StartTime_IsValid;

	private static FFieldAddress SetRangeSeconds_StartTime_PropertyAddress;

	private static int SetRangeSeconds_StartTime_Offset;

	private static bool SetRangeSeconds_EndTime_IsValid;

	private static FFieldAddress SetRangeSeconds_EndTime_PropertyAddress;

	private static int SetRangeSeconds_EndTime_Offset;

	private static bool SetRange_IsValid;

	private static IntPtr SetRange_FunctionAddress;

	private static int SetRange_ParamsSize;

	private static bool SetRange_Section_IsValid;

	private static FFieldAddress SetRange_Section_PropertyAddress;

	private static int SetRange_Section_Offset;

	private static bool SetRange_StartFrame_IsValid;

	private static FFieldAddress SetRange_StartFrame_PropertyAddress;

	private static int SetRange_StartFrame_Offset;

	private static bool SetRange_EndFrame_IsValid;

	private static FFieldAddress SetRange_EndFrame_PropertyAddress;

	private static int SetRange_EndFrame_Offset;

	private static bool SetEndFrameSeconds_IsValid;

	private static IntPtr SetEndFrameSeconds_FunctionAddress;

	private static int SetEndFrameSeconds_ParamsSize;

	private static bool SetEndFrameSeconds_Section_IsValid;

	private static FFieldAddress SetEndFrameSeconds_Section_PropertyAddress;

	private static int SetEndFrameSeconds_Section_Offset;

	private static bool SetEndFrameSeconds_EndTime_IsValid;

	private static FFieldAddress SetEndFrameSeconds_EndTime_PropertyAddress;

	private static int SetEndFrameSeconds_EndTime_Offset;

	private static bool SetEndFrameBounded_IsValid;

	private static IntPtr SetEndFrameBounded_FunctionAddress;

	private static int SetEndFrameBounded_ParamsSize;

	private static bool SetEndFrameBounded_Section_IsValid;

	private static FFieldAddress SetEndFrameBounded_Section_PropertyAddress;

	private static int SetEndFrameBounded_Section_Offset;

	private static bool SetEndFrameBounded_bIsBounded_IsValid;

	private static FFieldAddress SetEndFrameBounded_bIsBounded_PropertyAddress;

	private static int SetEndFrameBounded_bIsBounded_Offset;

	private static bool SetEndFrame_IsValid;

	private static IntPtr SetEndFrame_FunctionAddress;

	private static int SetEndFrame_ParamsSize;

	private static bool SetEndFrame_Section_IsValid;

	private static FFieldAddress SetEndFrame_Section_PropertyAddress;

	private static int SetEndFrame_Section_Offset;

	private static bool SetEndFrame_EndFrame_IsValid;

	private static FFieldAddress SetEndFrame_EndFrame_PropertyAddress;

	private static int SetEndFrame_EndFrame_Offset;

	private static bool HasStartFrame_IsValid;

	private static IntPtr HasStartFrame_FunctionAddress;

	private static int HasStartFrame_ParamsSize;

	private static bool HasStartFrame_Section_IsValid;

	private static FFieldAddress HasStartFrame_Section_PropertyAddress;

	private static int HasStartFrame_Section_Offset;

	private static bool HasStartFrame_ReturnValue_IsValid;

	private static FFieldAddress HasStartFrame_ReturnValue_PropertyAddress;

	private static int HasStartFrame_ReturnValue_Offset;

	private static bool HasEndFrame_IsValid;

	private static IntPtr HasEndFrame_FunctionAddress;

	private static int HasEndFrame_ParamsSize;

	private static bool HasEndFrame_Section_IsValid;

	private static FFieldAddress HasEndFrame_Section_PropertyAddress;

	private static int HasEndFrame_Section_Offset;

	private static bool HasEndFrame_ReturnValue_IsValid;

	private static FFieldAddress HasEndFrame_ReturnValue_PropertyAddress;

	private static int HasEndFrame_ReturnValue_Offset;

	private static bool GetStartFrameSeconds_IsValid;

	private static IntPtr GetStartFrameSeconds_FunctionAddress;

	private static int GetStartFrameSeconds_ParamsSize;

	private static bool GetStartFrameSeconds_Section_IsValid;

	private static FFieldAddress GetStartFrameSeconds_Section_PropertyAddress;

	private static int GetStartFrameSeconds_Section_Offset;

	private static bool GetStartFrameSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetStartFrameSeconds_ReturnValue_PropertyAddress;

	private static int GetStartFrameSeconds_ReturnValue_Offset;

	private static bool GetStartFrame_IsValid;

	private static IntPtr GetStartFrame_FunctionAddress;

	private static int GetStartFrame_ParamsSize;

	private static bool GetStartFrame_Section_IsValid;

	private static FFieldAddress GetStartFrame_Section_PropertyAddress;

	private static int GetStartFrame_Section_Offset;

	private static bool GetStartFrame_ReturnValue_IsValid;

	private static FFieldAddress GetStartFrame_ReturnValue_PropertyAddress;

	private static int GetStartFrame_ReturnValue_Offset;

	private static bool GetParentSequenceFrame_IsValid;

	private static IntPtr GetParentSequenceFrame_FunctionAddress;

	private static int GetParentSequenceFrame_ParamsSize;

	private static bool GetParentSequenceFrame_Section_IsValid;

	private static FFieldAddress GetParentSequenceFrame_Section_PropertyAddress;

	private static int GetParentSequenceFrame_Section_Offset;

	private static bool GetParentSequenceFrame_InFrame_IsValid;

	private static FFieldAddress GetParentSequenceFrame_InFrame_PropertyAddress;

	private static int GetParentSequenceFrame_InFrame_Offset;

	private static bool GetParentSequenceFrame_ParentSequence_IsValid;

	private static FFieldAddress GetParentSequenceFrame_ParentSequence_PropertyAddress;

	private static int GetParentSequenceFrame_ParentSequence_Offset;

	private static bool GetParentSequenceFrame_ReturnValue_IsValid;

	private static FFieldAddress GetParentSequenceFrame_ReturnValue_PropertyAddress;

	private static int GetParentSequenceFrame_ReturnValue_Offset;

	private static bool GetEndFrameSeconds_IsValid;

	private static IntPtr GetEndFrameSeconds_FunctionAddress;

	private static int GetEndFrameSeconds_ParamsSize;

	private static bool GetEndFrameSeconds_Section_IsValid;

	private static FFieldAddress GetEndFrameSeconds_Section_PropertyAddress;

	private static int GetEndFrameSeconds_Section_Offset;

	private static bool GetEndFrameSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetEndFrameSeconds_ReturnValue_PropertyAddress;

	private static int GetEndFrameSeconds_ReturnValue_Offset;

	private static bool GetEndFrame_IsValid;

	private static IntPtr GetEndFrame_FunctionAddress;

	private static int GetEndFrame_ParamsSize;

	private static bool GetEndFrame_Section_IsValid;

	private static FFieldAddress GetEndFrame_Section_PropertyAddress;

	private static int GetEndFrame_Section_Offset;

	private static bool GetEndFrame_ReturnValue_IsValid;

	private static FFieldAddress GetEndFrame_ReturnValue_PropertyAddress;

	private static int GetEndFrame_ReturnValue_Offset;

	private static bool GetChannelsByType_IsValid;

	private static IntPtr GetChannelsByType_FunctionAddress;

	private static int GetChannelsByType_ParamsSize;

	private static bool GetChannelsByType_Section_IsValid;

	private static FFieldAddress GetChannelsByType_Section_PropertyAddress;

	private static int GetChannelsByType_Section_Offset;

	private static bool GetChannelsByType_ChannelType_IsValid;

	private static FFieldAddress GetChannelsByType_ChannelType_PropertyAddress;

	private static int GetChannelsByType_ChannelType_Offset;

	private static bool GetChannelsByType_ReturnValue_IsValid;

	private static FFieldAddress GetChannelsByType_ReturnValue_PropertyAddress;

	private static int GetChannelsByType_ReturnValue_Offset;

	private static bool GetChannels_IsValid;

	private static IntPtr GetChannels_FunctionAddress;

	private static int GetChannels_ParamsSize;

	private static bool GetChannels_Section_IsValid;

	private static FFieldAddress GetChannels_Section_PropertyAddress;

	private static int GetChannels_Section_Offset;

	private static bool GetChannels_ReturnValue_IsValid;

	private static FFieldAddress GetChannels_ReturnValue_PropertyAddress;

	private static int GetChannels_ReturnValue_Offset;

	private static bool GetAllChannels_IsValid;

	private static IntPtr GetAllChannels_FunctionAddress;

	private static int GetAllChannels_ParamsSize;

	private static bool GetAllChannels_Section_IsValid;

	private static FFieldAddress GetAllChannels_Section_PropertyAddress;

	private static int GetAllChannels_Section_Offset;

	private static bool GetAllChannels_ReturnValue_IsValid;

	private static FFieldAddress GetAllChannels_ReturnValue_PropertyAddress;

	private static int GetAllChannels_ReturnValue_Offset;

	private static bool FindChannelsByType_IsValid;

	private static IntPtr FindChannelsByType_FunctionAddress;

	private static int FindChannelsByType_ParamsSize;

	private static bool FindChannelsByType_Section_IsValid;

	private static FFieldAddress FindChannelsByType_Section_PropertyAddress;

	private static int FindChannelsByType_Section_Offset;

	private static bool FindChannelsByType_ChannelType_IsValid;

	private static FFieldAddress FindChannelsByType_ChannelType_PropertyAddress;

	private static int FindChannelsByType_ChannelType_Offset;

	private static bool FindChannelsByType_ReturnValue_IsValid;

	private static FFieldAddress FindChannelsByType_ReturnValue_PropertyAddress;

	private static int FindChannelsByType_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:SetStartFrameSeconds")]
	public unsafe static void SetStartFrameSeconds(UMovieSceneSection Section, float StartTime)
	{
		if (!SetStartFrameSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:SetStartFrameSeconds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartFrameSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartFrameSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, SetStartFrameSeconds_Section_Offset), 0, SetStartFrameSeconds_Section_PropertyAddress.Address, Section);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStartFrameSeconds_StartTime_Offset), 0, SetStartFrameSeconds_StartTime_PropertyAddress.Address, StartTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStartFrameSeconds_FunctionAddress, intPtr, SetStartFrameSeconds_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:SetStartFrameBounded")]
	public unsafe static void SetStartFrameBounded(UMovieSceneSection Section, bool bIsBounded)
	{
		if (!SetStartFrameBounded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:SetStartFrameBounded");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartFrameBounded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartFrameBounded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, SetStartFrameBounded_Section_Offset), 0, SetStartFrameBounded_Section_PropertyAddress.Address, Section);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStartFrameBounded_bIsBounded_Offset), 0, SetStartFrameBounded_bIsBounded_PropertyAddress.Address, bIsBounded);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStartFrameBounded_FunctionAddress, intPtr, SetStartFrameBounded_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:SetStartFrame")]
	public unsafe static void SetStartFrame(UMovieSceneSection Section, int StartFrame)
	{
		if (!SetStartFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:SetStartFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, SetStartFrame_Section_Offset), 0, SetStartFrame_Section_PropertyAddress.Address, Section);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetStartFrame_StartFrame_Offset), 0, SetStartFrame_StartFrame_PropertyAddress.Address, StartFrame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStartFrame_FunctionAddress, intPtr, SetStartFrame_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:SetRangeSeconds")]
	public unsafe static void SetRangeSeconds(UMovieSceneSection Section, float StartTime, float EndTime)
	{
		if (!SetRangeSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:SetRangeSeconds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRangeSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRangeSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, SetRangeSeconds_Section_Offset), 0, SetRangeSeconds_Section_PropertyAddress.Address, Section);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRangeSeconds_StartTime_Offset), 0, SetRangeSeconds_StartTime_PropertyAddress.Address, StartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRangeSeconds_EndTime_Offset), 0, SetRangeSeconds_EndTime_PropertyAddress.Address, EndTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRangeSeconds_FunctionAddress, intPtr, SetRangeSeconds_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:SetRange")]
	public unsafe static void SetRange(UMovieSceneSection Section, int StartFrame, int EndFrame)
	{
		if (!SetRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:SetRange");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, SetRange_Section_Offset), 0, SetRange_Section_PropertyAddress.Address, Section);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRange_StartFrame_Offset), 0, SetRange_StartFrame_PropertyAddress.Address, StartFrame);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRange_EndFrame_Offset), 0, SetRange_EndFrame_PropertyAddress.Address, EndFrame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRange_FunctionAddress, intPtr, SetRange_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:SetEndFrameSeconds")]
	public unsafe static void SetEndFrameSeconds(UMovieSceneSection Section, float EndTime)
	{
		if (!SetEndFrameSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:SetEndFrameSeconds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEndFrameSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEndFrameSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, SetEndFrameSeconds_Section_Offset), 0, SetEndFrameSeconds_Section_PropertyAddress.Address, Section);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetEndFrameSeconds_EndTime_Offset), 0, SetEndFrameSeconds_EndTime_PropertyAddress.Address, EndTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEndFrameSeconds_FunctionAddress, intPtr, SetEndFrameSeconds_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:SetEndFrameBounded")]
	public unsafe static void SetEndFrameBounded(UMovieSceneSection Section, bool bIsBounded)
	{
		if (!SetEndFrameBounded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:SetEndFrameBounded");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEndFrameBounded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEndFrameBounded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, SetEndFrameBounded_Section_Offset), 0, SetEndFrameBounded_Section_PropertyAddress.Address, Section);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEndFrameBounded_bIsBounded_Offset), 0, SetEndFrameBounded_bIsBounded_PropertyAddress.Address, bIsBounded);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEndFrameBounded_FunctionAddress, intPtr, SetEndFrameBounded_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:SetEndFrame")]
	public unsafe static void SetEndFrame(UMovieSceneSection Section, int EndFrame)
	{
		if (!SetEndFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:SetEndFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEndFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEndFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, SetEndFrame_Section_Offset), 0, SetEndFrame_Section_PropertyAddress.Address, Section);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetEndFrame_EndFrame_Offset), 0, SetEndFrame_EndFrame_PropertyAddress.Address, EndFrame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEndFrame_FunctionAddress, intPtr, SetEndFrame_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:HasStartFrame")]
	public unsafe static bool HasStartFrame(UMovieSceneSection Section)
	{
		if (!HasStartFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:HasStartFrame");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasStartFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasStartFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, HasStartFrame_Section_Offset), 0, HasStartFrame_Section_PropertyAddress.Address, Section);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasStartFrame_FunctionAddress, intPtr, HasStartFrame_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasStartFrame_ReturnValue_Offset), 0, HasStartFrame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:HasEndFrame")]
	public unsafe static bool HasEndFrame(UMovieSceneSection Section)
	{
		if (!HasEndFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:HasEndFrame");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasEndFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasEndFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, HasEndFrame_Section_Offset), 0, HasEndFrame_Section_PropertyAddress.Address, Section);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasEndFrame_FunctionAddress, intPtr, HasEndFrame_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasEndFrame_ReturnValue_Offset), 0, HasEndFrame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:GetStartFrameSeconds")]
	public unsafe static float GetStartFrameSeconds(UMovieSceneSection Section)
	{
		if (!GetStartFrameSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:GetStartFrameSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartFrameSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartFrameSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, GetStartFrameSeconds_Section_Offset), 0, GetStartFrameSeconds_Section_PropertyAddress.Address, Section);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStartFrameSeconds_FunctionAddress, intPtr, GetStartFrameSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStartFrameSeconds_ReturnValue_Offset), 0, GetStartFrameSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:GetStartFrame")]
	public unsafe static int GetStartFrame(UMovieSceneSection Section)
	{
		if (!GetStartFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:GetStartFrame");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, GetStartFrame_Section_Offset), 0, GetStartFrame_Section_PropertyAddress.Address, Section);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStartFrame_FunctionAddress, intPtr, GetStartFrame_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetStartFrame_ReturnValue_Offset), 0, GetStartFrame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:GetParentSequenceFrame")]
	public unsafe static int GetParentSequenceFrame(UMovieSceneSubSection Section, int InFrame, UMovieSceneSequence ParentSequence)
	{
		if (!GetParentSequenceFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:GetParentSequenceFrame");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentSequenceFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentSequenceFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSubSection>.ToNative(IntPtr.Add(intPtr, GetParentSequenceFrame_Section_Offset), 0, GetParentSequenceFrame_Section_PropertyAddress.Address, Section);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParentSequenceFrame_InFrame_Offset), 0, GetParentSequenceFrame_InFrame_PropertyAddress.Address, InFrame);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetParentSequenceFrame_ParentSequence_Offset), 0, GetParentSequenceFrame_ParentSequence_PropertyAddress.Address, ParentSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetParentSequenceFrame_FunctionAddress, intPtr, GetParentSequenceFrame_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetParentSequenceFrame_ReturnValue_Offset), 0, GetParentSequenceFrame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:GetEndFrameSeconds")]
	public unsafe static float GetEndFrameSeconds(UMovieSceneSection Section)
	{
		if (!GetEndFrameSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:GetEndFrameSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndFrameSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndFrameSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, GetEndFrameSeconds_Section_Offset), 0, GetEndFrameSeconds_Section_PropertyAddress.Address, Section);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEndFrameSeconds_FunctionAddress, intPtr, GetEndFrameSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetEndFrameSeconds_ReturnValue_Offset), 0, GetEndFrameSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:GetEndFrame")]
	public unsafe static int GetEndFrame(UMovieSceneSection Section)
	{
		if (!GetEndFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:GetEndFrame");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, GetEndFrame_Section_Offset), 0, GetEndFrame_Section_PropertyAddress.Address, Section);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEndFrame_FunctionAddress, intPtr, GetEndFrame_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetEndFrame_ReturnValue_Offset), 0, GetEndFrame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:GetChannelsByType")]
	public unsafe static List<UMovieSceneScriptingChannel> GetChannelsByType(UMovieSceneSection Section, TSubclassOf<UMovieSceneScriptingChannel> ChannelType)
	{
		if (!GetChannelsByType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:GetChannelsByType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChannelsByType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChannelsByType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, GetChannelsByType_Section_Offset), 0, GetChannelsByType_Section_PropertyAddress.Address, Section);
		TSubclassOfMarshaler<UMovieSceneScriptingChannel>.ToNative(IntPtr.Add(intPtr, GetChannelsByType_ChannelType_Offset), 0, GetChannelsByType_ChannelType_PropertyAddress.Address, ChannelType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetChannelsByType_FunctionAddress, intPtr, GetChannelsByType_ParamsSize);
		List<UMovieSceneScriptingChannel> result = new TArrayCopyMarshaler<UMovieSceneScriptingChannel>(1, GetChannelsByType_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneScriptingChannel, UObjectMarshaler<UMovieSceneScriptingChannel>>.FromNative, CachedMarshalingDelegates<UMovieSceneScriptingChannel, UObjectMarshaler<UMovieSceneScriptingChannel>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChannelsByType_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetChannelsByType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:GetChannels")]
	public unsafe static List<UMovieSceneScriptingChannel> GetChannels(UMovieSceneSection Section)
	{
		if (!GetChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:GetChannels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, GetChannels_Section_Offset), 0, GetChannels_Section_PropertyAddress.Address, Section);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetChannels_FunctionAddress, intPtr, GetChannels_ParamsSize);
		List<UMovieSceneScriptingChannel> result = new TArrayCopyMarshaler<UMovieSceneScriptingChannel>(1, GetChannels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneScriptingChannel, UObjectMarshaler<UMovieSceneScriptingChannel>>.FromNative, CachedMarshalingDelegates<UMovieSceneScriptingChannel, UObjectMarshaler<UMovieSceneScriptingChannel>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChannels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetChannels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:GetAllChannels")]
	public unsafe static List<UMovieSceneScriptingChannel> GetAllChannels(UMovieSceneSection Section)
	{
		if (!GetAllChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:GetAllChannels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, GetAllChannels_Section_Offset), 0, GetAllChannels_Section_PropertyAddress.Address, Section);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllChannels_FunctionAddress, intPtr, GetAllChannels_ParamsSize);
		List<UMovieSceneScriptingChannel> result = new TArrayCopyMarshaler<UMovieSceneScriptingChannel>(1, GetAllChannels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneScriptingChannel, UObjectMarshaler<UMovieSceneScriptingChannel>>.FromNative, CachedMarshalingDelegates<UMovieSceneScriptingChannel, UObjectMarshaler<UMovieSceneScriptingChannel>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllChannels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllChannels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSectionExtensions:FindChannelsByType")]
	public unsafe static List<UMovieSceneScriptingChannel> FindChannelsByType(UMovieSceneSection Section, TSubclassOf<UMovieSceneScriptingChannel> ChannelType)
	{
		if (!FindChannelsByType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSectionExtensions:FindChannelsByType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindChannelsByType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindChannelsByType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, FindChannelsByType_Section_Offset), 0, FindChannelsByType_Section_PropertyAddress.Address, Section);
		TSubclassOfMarshaler<UMovieSceneScriptingChannel>.ToNative(IntPtr.Add(intPtr, FindChannelsByType_ChannelType_Offset), 0, FindChannelsByType_ChannelType_PropertyAddress.Address, ChannelType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindChannelsByType_FunctionAddress, intPtr, FindChannelsByType_ParamsSize);
		List<UMovieSceneScriptingChannel> result = new TArrayCopyMarshaler<UMovieSceneScriptingChannel>(1, FindChannelsByType_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneScriptingChannel, UObjectMarshaler<UMovieSceneScriptingChannel>>.FromNative, CachedMarshalingDelegates<UMovieSceneScriptingChannel, UObjectMarshaler<UMovieSceneScriptingChannel>>.ToNative).FromNative(IntPtr.Add(intPtr, FindChannelsByType_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindChannelsByType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UMovieSceneSectionExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneSectionExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneSectionExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneSectionExtensions");
		SetStartFrameSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStartFrameSeconds");
		SetStartFrameSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartFrameSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartFrameSeconds_Section_PropertyAddress, SetStartFrameSeconds_FunctionAddress, "Section");
		SetStartFrameSeconds_Section_Offset = NativeReflectionCached.GetPropertyOffset(SetStartFrameSeconds_FunctionAddress, "Section");
		SetStartFrameSeconds_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartFrameSeconds_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartFrameSeconds_StartTime_PropertyAddress, SetStartFrameSeconds_FunctionAddress, "StartTime");
		SetStartFrameSeconds_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(SetStartFrameSeconds_FunctionAddress, "StartTime");
		SetStartFrameSeconds_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartFrameSeconds_FunctionAddress, "StartTime", Classes.FFloatProperty);
		SetStartFrameSeconds_IsValid = SetStartFrameSeconds_FunctionAddress != IntPtr.Zero && SetStartFrameSeconds_Section_IsValid && SetStartFrameSeconds_StartTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:SetStartFrameSeconds", SetStartFrameSeconds_IsValid);
		SetStartFrameBounded_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStartFrameBounded");
		SetStartFrameBounded_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartFrameBounded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartFrameBounded_Section_PropertyAddress, SetStartFrameBounded_FunctionAddress, "Section");
		SetStartFrameBounded_Section_Offset = NativeReflectionCached.GetPropertyOffset(SetStartFrameBounded_FunctionAddress, "Section");
		SetStartFrameBounded_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartFrameBounded_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartFrameBounded_bIsBounded_PropertyAddress, SetStartFrameBounded_FunctionAddress, "bIsBounded");
		SetStartFrameBounded_bIsBounded_Offset = NativeReflectionCached.GetPropertyOffset(SetStartFrameBounded_FunctionAddress, "bIsBounded");
		SetStartFrameBounded_bIsBounded_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartFrameBounded_FunctionAddress, "bIsBounded", Classes.FBoolProperty);
		SetStartFrameBounded_IsValid = SetStartFrameBounded_FunctionAddress != IntPtr.Zero && SetStartFrameBounded_Section_IsValid && SetStartFrameBounded_bIsBounded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:SetStartFrameBounded", SetStartFrameBounded_IsValid);
		SetStartFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStartFrame");
		SetStartFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartFrame_Section_PropertyAddress, SetStartFrame_FunctionAddress, "Section");
		SetStartFrame_Section_Offset = NativeReflectionCached.GetPropertyOffset(SetStartFrame_FunctionAddress, "Section");
		SetStartFrame_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartFrame_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartFrame_StartFrame_PropertyAddress, SetStartFrame_FunctionAddress, "StartFrame");
		SetStartFrame_StartFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetStartFrame_FunctionAddress, "StartFrame");
		SetStartFrame_StartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartFrame_FunctionAddress, "StartFrame", Classes.FIntProperty);
		SetStartFrame_IsValid = SetStartFrame_FunctionAddress != IntPtr.Zero && SetStartFrame_Section_IsValid && SetStartFrame_StartFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:SetStartFrame", SetStartFrame_IsValid);
		SetRangeSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRangeSeconds");
		SetRangeSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRangeSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRangeSeconds_Section_PropertyAddress, SetRangeSeconds_FunctionAddress, "Section");
		SetRangeSeconds_Section_Offset = NativeReflectionCached.GetPropertyOffset(SetRangeSeconds_FunctionAddress, "Section");
		SetRangeSeconds_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRangeSeconds_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRangeSeconds_StartTime_PropertyAddress, SetRangeSeconds_FunctionAddress, "StartTime");
		SetRangeSeconds_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(SetRangeSeconds_FunctionAddress, "StartTime");
		SetRangeSeconds_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRangeSeconds_FunctionAddress, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRangeSeconds_EndTime_PropertyAddress, SetRangeSeconds_FunctionAddress, "EndTime");
		SetRangeSeconds_EndTime_Offset = NativeReflectionCached.GetPropertyOffset(SetRangeSeconds_FunctionAddress, "EndTime");
		SetRangeSeconds_EndTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRangeSeconds_FunctionAddress, "EndTime", Classes.FFloatProperty);
		SetRangeSeconds_IsValid = SetRangeSeconds_FunctionAddress != IntPtr.Zero && SetRangeSeconds_Section_IsValid && SetRangeSeconds_StartTime_IsValid && SetRangeSeconds_EndTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:SetRangeSeconds", SetRangeSeconds_IsValid);
		SetRange_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRange");
		SetRange_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRange_Section_PropertyAddress, SetRange_FunctionAddress, "Section");
		SetRange_Section_Offset = NativeReflectionCached.GetPropertyOffset(SetRange_FunctionAddress, "Section");
		SetRange_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRange_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRange_StartFrame_PropertyAddress, SetRange_FunctionAddress, "StartFrame");
		SetRange_StartFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetRange_FunctionAddress, "StartFrame");
		SetRange_StartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRange_FunctionAddress, "StartFrame", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRange_EndFrame_PropertyAddress, SetRange_FunctionAddress, "EndFrame");
		SetRange_EndFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetRange_FunctionAddress, "EndFrame");
		SetRange_EndFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRange_FunctionAddress, "EndFrame", Classes.FIntProperty);
		SetRange_IsValid = SetRange_FunctionAddress != IntPtr.Zero && SetRange_Section_IsValid && SetRange_StartFrame_IsValid && SetRange_EndFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:SetRange", SetRange_IsValid);
		SetEndFrameSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEndFrameSeconds");
		SetEndFrameSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEndFrameSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEndFrameSeconds_Section_PropertyAddress, SetEndFrameSeconds_FunctionAddress, "Section");
		SetEndFrameSeconds_Section_Offset = NativeReflectionCached.GetPropertyOffset(SetEndFrameSeconds_FunctionAddress, "Section");
		SetEndFrameSeconds_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndFrameSeconds_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEndFrameSeconds_EndTime_PropertyAddress, SetEndFrameSeconds_FunctionAddress, "EndTime");
		SetEndFrameSeconds_EndTime_Offset = NativeReflectionCached.GetPropertyOffset(SetEndFrameSeconds_FunctionAddress, "EndTime");
		SetEndFrameSeconds_EndTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndFrameSeconds_FunctionAddress, "EndTime", Classes.FFloatProperty);
		SetEndFrameSeconds_IsValid = SetEndFrameSeconds_FunctionAddress != IntPtr.Zero && SetEndFrameSeconds_Section_IsValid && SetEndFrameSeconds_EndTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:SetEndFrameSeconds", SetEndFrameSeconds_IsValid);
		SetEndFrameBounded_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEndFrameBounded");
		SetEndFrameBounded_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEndFrameBounded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEndFrameBounded_Section_PropertyAddress, SetEndFrameBounded_FunctionAddress, "Section");
		SetEndFrameBounded_Section_Offset = NativeReflectionCached.GetPropertyOffset(SetEndFrameBounded_FunctionAddress, "Section");
		SetEndFrameBounded_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndFrameBounded_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEndFrameBounded_bIsBounded_PropertyAddress, SetEndFrameBounded_FunctionAddress, "bIsBounded");
		SetEndFrameBounded_bIsBounded_Offset = NativeReflectionCached.GetPropertyOffset(SetEndFrameBounded_FunctionAddress, "bIsBounded");
		SetEndFrameBounded_bIsBounded_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndFrameBounded_FunctionAddress, "bIsBounded", Classes.FBoolProperty);
		SetEndFrameBounded_IsValid = SetEndFrameBounded_FunctionAddress != IntPtr.Zero && SetEndFrameBounded_Section_IsValid && SetEndFrameBounded_bIsBounded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:SetEndFrameBounded", SetEndFrameBounded_IsValid);
		SetEndFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEndFrame");
		SetEndFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEndFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEndFrame_Section_PropertyAddress, SetEndFrame_FunctionAddress, "Section");
		SetEndFrame_Section_Offset = NativeReflectionCached.GetPropertyOffset(SetEndFrame_FunctionAddress, "Section");
		SetEndFrame_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndFrame_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEndFrame_EndFrame_PropertyAddress, SetEndFrame_FunctionAddress, "EndFrame");
		SetEndFrame_EndFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetEndFrame_FunctionAddress, "EndFrame");
		SetEndFrame_EndFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndFrame_FunctionAddress, "EndFrame", Classes.FIntProperty);
		SetEndFrame_IsValid = SetEndFrame_FunctionAddress != IntPtr.Zero && SetEndFrame_Section_IsValid && SetEndFrame_EndFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:SetEndFrame", SetEndFrame_IsValid);
		HasStartFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasStartFrame");
		HasStartFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(HasStartFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasStartFrame_Section_PropertyAddress, HasStartFrame_FunctionAddress, "Section");
		HasStartFrame_Section_Offset = NativeReflectionCached.GetPropertyOffset(HasStartFrame_FunctionAddress, "Section");
		HasStartFrame_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(HasStartFrame_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasStartFrame_ReturnValue_PropertyAddress, HasStartFrame_FunctionAddress, "ReturnValue");
		HasStartFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasStartFrame_FunctionAddress, "ReturnValue");
		HasStartFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasStartFrame_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasStartFrame_IsValid = HasStartFrame_FunctionAddress != IntPtr.Zero && HasStartFrame_Section_IsValid && HasStartFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:HasStartFrame", HasStartFrame_IsValid);
		HasEndFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasEndFrame");
		HasEndFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(HasEndFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasEndFrame_Section_PropertyAddress, HasEndFrame_FunctionAddress, "Section");
		HasEndFrame_Section_Offset = NativeReflectionCached.GetPropertyOffset(HasEndFrame_FunctionAddress, "Section");
		HasEndFrame_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(HasEndFrame_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasEndFrame_ReturnValue_PropertyAddress, HasEndFrame_FunctionAddress, "ReturnValue");
		HasEndFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasEndFrame_FunctionAddress, "ReturnValue");
		HasEndFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasEndFrame_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasEndFrame_IsValid = HasEndFrame_FunctionAddress != IntPtr.Zero && HasEndFrame_Section_IsValid && HasEndFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:HasEndFrame", HasEndFrame_IsValid);
		GetStartFrameSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStartFrameSeconds");
		GetStartFrameSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartFrameSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartFrameSeconds_Section_PropertyAddress, GetStartFrameSeconds_FunctionAddress, "Section");
		GetStartFrameSeconds_Section_Offset = NativeReflectionCached.GetPropertyOffset(GetStartFrameSeconds_FunctionAddress, "Section");
		GetStartFrameSeconds_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartFrameSeconds_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStartFrameSeconds_ReturnValue_PropertyAddress, GetStartFrameSeconds_FunctionAddress, "ReturnValue");
		GetStartFrameSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartFrameSeconds_FunctionAddress, "ReturnValue");
		GetStartFrameSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartFrameSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStartFrameSeconds_IsValid = GetStartFrameSeconds_FunctionAddress != IntPtr.Zero && GetStartFrameSeconds_Section_IsValid && GetStartFrameSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:GetStartFrameSeconds", GetStartFrameSeconds_IsValid);
		GetStartFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStartFrame");
		GetStartFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartFrame_Section_PropertyAddress, GetStartFrame_FunctionAddress, "Section");
		GetStartFrame_Section_Offset = NativeReflectionCached.GetPropertyOffset(GetStartFrame_FunctionAddress, "Section");
		GetStartFrame_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartFrame_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStartFrame_ReturnValue_PropertyAddress, GetStartFrame_FunctionAddress, "ReturnValue");
		GetStartFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartFrame_FunctionAddress, "ReturnValue");
		GetStartFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartFrame_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetStartFrame_IsValid = GetStartFrame_FunctionAddress != IntPtr.Zero && GetStartFrame_Section_IsValid && GetStartFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:GetStartFrame", GetStartFrame_IsValid);
		GetParentSequenceFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParentSequenceFrame");
		GetParentSequenceFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentSequenceFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentSequenceFrame_Section_PropertyAddress, GetParentSequenceFrame_FunctionAddress, "Section");
		GetParentSequenceFrame_Section_Offset = NativeReflectionCached.GetPropertyOffset(GetParentSequenceFrame_FunctionAddress, "Section");
		GetParentSequenceFrame_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentSequenceFrame_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentSequenceFrame_InFrame_PropertyAddress, GetParentSequenceFrame_FunctionAddress, "InFrame");
		GetParentSequenceFrame_InFrame_Offset = NativeReflectionCached.GetPropertyOffset(GetParentSequenceFrame_FunctionAddress, "InFrame");
		GetParentSequenceFrame_InFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentSequenceFrame_FunctionAddress, "InFrame", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentSequenceFrame_ParentSequence_PropertyAddress, GetParentSequenceFrame_FunctionAddress, "ParentSequence");
		GetParentSequenceFrame_ParentSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetParentSequenceFrame_FunctionAddress, "ParentSequence");
		GetParentSequenceFrame_ParentSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentSequenceFrame_FunctionAddress, "ParentSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentSequenceFrame_ReturnValue_PropertyAddress, GetParentSequenceFrame_FunctionAddress, "ReturnValue");
		GetParentSequenceFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentSequenceFrame_FunctionAddress, "ReturnValue");
		GetParentSequenceFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentSequenceFrame_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetParentSequenceFrame_IsValid = GetParentSequenceFrame_FunctionAddress != IntPtr.Zero && GetParentSequenceFrame_Section_IsValid && GetParentSequenceFrame_InFrame_IsValid && GetParentSequenceFrame_ParentSequence_IsValid && GetParentSequenceFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:GetParentSequenceFrame", GetParentSequenceFrame_IsValid);
		GetEndFrameSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEndFrameSeconds");
		GetEndFrameSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndFrameSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndFrameSeconds_Section_PropertyAddress, GetEndFrameSeconds_FunctionAddress, "Section");
		GetEndFrameSeconds_Section_Offset = NativeReflectionCached.GetPropertyOffset(GetEndFrameSeconds_FunctionAddress, "Section");
		GetEndFrameSeconds_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndFrameSeconds_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEndFrameSeconds_ReturnValue_PropertyAddress, GetEndFrameSeconds_FunctionAddress, "ReturnValue");
		GetEndFrameSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndFrameSeconds_FunctionAddress, "ReturnValue");
		GetEndFrameSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndFrameSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetEndFrameSeconds_IsValid = GetEndFrameSeconds_FunctionAddress != IntPtr.Zero && GetEndFrameSeconds_Section_IsValid && GetEndFrameSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:GetEndFrameSeconds", GetEndFrameSeconds_IsValid);
		GetEndFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEndFrame");
		GetEndFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndFrame_Section_PropertyAddress, GetEndFrame_FunctionAddress, "Section");
		GetEndFrame_Section_Offset = NativeReflectionCached.GetPropertyOffset(GetEndFrame_FunctionAddress, "Section");
		GetEndFrame_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndFrame_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEndFrame_ReturnValue_PropertyAddress, GetEndFrame_FunctionAddress, "ReturnValue");
		GetEndFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndFrame_FunctionAddress, "ReturnValue");
		GetEndFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndFrame_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetEndFrame_IsValid = GetEndFrame_FunctionAddress != IntPtr.Zero && GetEndFrame_Section_IsValid && GetEndFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:GetEndFrame", GetEndFrame_IsValid);
		GetChannelsByType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChannelsByType");
		GetChannelsByType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChannelsByType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChannelsByType_Section_PropertyAddress, GetChannelsByType_FunctionAddress, "Section");
		GetChannelsByType_Section_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelsByType_FunctionAddress, "Section");
		GetChannelsByType_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelsByType_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannelsByType_ChannelType_PropertyAddress, GetChannelsByType_FunctionAddress, "ChannelType");
		GetChannelsByType_ChannelType_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelsByType_FunctionAddress, "ChannelType");
		GetChannelsByType_ChannelType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelsByType_FunctionAddress, "ChannelType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannelsByType_ReturnValue_PropertyAddress, GetChannelsByType_FunctionAddress, "ReturnValue");
		GetChannelsByType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelsByType_FunctionAddress, "ReturnValue");
		GetChannelsByType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelsByType_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetChannelsByType_IsValid = GetChannelsByType_FunctionAddress != IntPtr.Zero && GetChannelsByType_Section_IsValid && GetChannelsByType_ChannelType_IsValid && GetChannelsByType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:GetChannelsByType", GetChannelsByType_IsValid);
		GetChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChannels");
		GetChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChannels_Section_PropertyAddress, GetChannels_FunctionAddress, "Section");
		GetChannels_Section_Offset = NativeReflectionCached.GetPropertyOffset(GetChannels_FunctionAddress, "Section");
		GetChannels_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannels_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannels_ReturnValue_PropertyAddress, GetChannels_FunctionAddress, "ReturnValue");
		GetChannels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChannels_FunctionAddress, "ReturnValue");
		GetChannels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannels_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetChannels_IsValid = GetChannels_FunctionAddress != IntPtr.Zero && GetChannels_Section_IsValid && GetChannels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:GetChannels", GetChannels_IsValid);
		GetAllChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllChannels");
		GetAllChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllChannels_Section_PropertyAddress, GetAllChannels_FunctionAddress, "Section");
		GetAllChannels_Section_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChannels_FunctionAddress, "Section");
		GetAllChannels_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChannels_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllChannels_ReturnValue_PropertyAddress, GetAllChannels_FunctionAddress, "ReturnValue");
		GetAllChannels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChannels_FunctionAddress, "ReturnValue");
		GetAllChannels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChannels_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllChannels_IsValid = GetAllChannels_FunctionAddress != IntPtr.Zero && GetAllChannels_Section_IsValid && GetAllChannels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:GetAllChannels", GetAllChannels_IsValid);
		FindChannelsByType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindChannelsByType");
		FindChannelsByType_ParamsSize = NativeReflection.GetFunctionParamsSize(FindChannelsByType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindChannelsByType_Section_PropertyAddress, FindChannelsByType_FunctionAddress, "Section");
		FindChannelsByType_Section_Offset = NativeReflectionCached.GetPropertyOffset(FindChannelsByType_FunctionAddress, "Section");
		FindChannelsByType_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(FindChannelsByType_FunctionAddress, "Section", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindChannelsByType_ChannelType_PropertyAddress, FindChannelsByType_FunctionAddress, "ChannelType");
		FindChannelsByType_ChannelType_Offset = NativeReflectionCached.GetPropertyOffset(FindChannelsByType_FunctionAddress, "ChannelType");
		FindChannelsByType_ChannelType_IsValid = NativeReflectionCached.ValidatePropertyClass(FindChannelsByType_FunctionAddress, "ChannelType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindChannelsByType_ReturnValue_PropertyAddress, FindChannelsByType_FunctionAddress, "ReturnValue");
		FindChannelsByType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindChannelsByType_FunctionAddress, "ReturnValue");
		FindChannelsByType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindChannelsByType_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindChannelsByType_IsValid = FindChannelsByType_FunctionAddress != IntPtr.Zero && FindChannelsByType_Section_IsValid && FindChannelsByType_ChannelType_IsValid && FindChannelsByType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSectionExtensions:FindChannelsByType", FindChannelsByType_IsValid);
	}
}
