using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneScriptingFloatChannel : UMovieSceneScriptingChannel
{
	private static bool SetPreInfinityExtrapolation_IsValid;

	private static IntPtr SetPreInfinityExtrapolation_FunctionAddress;

	private static int SetPreInfinityExtrapolation_ParamsSize;

	private static bool SetPreInfinityExtrapolation_InExtrapolation_IsValid;

	private static FFieldAddress SetPreInfinityExtrapolation_InExtrapolation_PropertyAddress;

	private static int SetPreInfinityExtrapolation_InExtrapolation_Offset;

	private static bool SetPostInfinityExtrapolation_IsValid;

	private static IntPtr SetPostInfinityExtrapolation_FunctionAddress;

	private static int SetPostInfinityExtrapolation_ParamsSize;

	private static bool SetPostInfinityExtrapolation_InExtrapolation_IsValid;

	private static FFieldAddress SetPostInfinityExtrapolation_InExtrapolation_PropertyAddress;

	private static int SetPostInfinityExtrapolation_InExtrapolation_Offset;

	private static bool SetDefault_IsValid;

	private static IntPtr SetDefault_FunctionAddress;

	private static int SetDefault_ParamsSize;

	private static bool SetDefault_InDefaultValue_IsValid;

	private static FFieldAddress SetDefault_InDefaultValue_PropertyAddress;

	private static int SetDefault_InDefaultValue_Offset;

	private static bool RemoveKey_IsValid;

	private static IntPtr RemoveKey_FunctionAddress;

	private static int RemoveKey_ParamsSize;

	private static bool RemoveKey_Key_IsValid;

	private static FFieldAddress RemoveKey_Key_PropertyAddress;

	private static int RemoveKey_Key_Offset;

	private static bool RemoveDefault_IsValid;

	private static IntPtr RemoveDefault_FunctionAddress;

	private static int RemoveDefault_ParamsSize;

	private static bool HasDefault_IsValid;

	private static IntPtr HasDefault_FunctionAddress;

	private static int HasDefault_ParamsSize;

	private static bool HasDefault_ReturnValue_IsValid;

	private static FFieldAddress HasDefault_ReturnValue_PropertyAddress;

	private static int HasDefault_ReturnValue_Offset;

	private static bool GetPreInfinityExtrapolation_IsValid;

	private static IntPtr GetPreInfinityExtrapolation_FunctionAddress;

	private static int GetPreInfinityExtrapolation_ParamsSize;

	private static bool GetPreInfinityExtrapolation_ReturnValue_IsValid;

	private static FFieldAddress GetPreInfinityExtrapolation_ReturnValue_PropertyAddress;

	private static int GetPreInfinityExtrapolation_ReturnValue_Offset;

	private static bool GetPostInfinityExtrapolation_IsValid;

	private static IntPtr GetPostInfinityExtrapolation_FunctionAddress;

	private static int GetPostInfinityExtrapolation_ParamsSize;

	private static bool GetPostInfinityExtrapolation_ReturnValue_IsValid;

	private static FFieldAddress GetPostInfinityExtrapolation_ReturnValue_PropertyAddress;

	private static int GetPostInfinityExtrapolation_ReturnValue_Offset;

	private static bool GetNumKeys_IsValid;

	private static IntPtr GetNumKeys_FunctionAddress;

	private static int GetNumKeys_ParamsSize;

	private static bool GetNumKeys_ReturnValue_IsValid;

	private static FFieldAddress GetNumKeys_ReturnValue_PropertyAddress;

	private static int GetNumKeys_ReturnValue_Offset;

	private static bool GetKeys_IsValid;

	private static IntPtr GetKeys_FunctionAddress;

	private static int GetKeys_ParamsSize;

	private static bool GetKeys_ReturnValue_IsValid;

	private static FFieldAddress GetKeys_ReturnValue_PropertyAddress;

	private static int GetKeys_ReturnValue_Offset;

	private static bool GetDefault_IsValid;

	private static IntPtr GetDefault_FunctionAddress;

	private static int GetDefault_ParamsSize;

	private static bool GetDefault_ReturnValue_IsValid;

	private static FFieldAddress GetDefault_ReturnValue_PropertyAddress;

	private static int GetDefault_ReturnValue_Offset;

	private static bool EvaluateKeys_IsValid;

	private static IntPtr EvaluateKeys_FunctionAddress;

	private static int EvaluateKeys_ParamsSize;

	private static bool EvaluateKeys_Range_IsValid;

	private static FFieldAddress EvaluateKeys_Range_PropertyAddress;

	private static int EvaluateKeys_Range_Offset;

	private static bool EvaluateKeys_FrameRate_IsValid;

	private static FFieldAddress EvaluateKeys_FrameRate_PropertyAddress;

	private static int EvaluateKeys_FrameRate_Offset;

	private static bool EvaluateKeys_ReturnValue_IsValid;

	private static FFieldAddress EvaluateKeys_ReturnValue_PropertyAddress;

	private static int EvaluateKeys_ReturnValue_Offset;

	private static bool ComputeEffectiveRange_IsValid;

	private static IntPtr ComputeEffectiveRange_FunctionAddress;

	private static int ComputeEffectiveRange_ParamsSize;

	private static bool ComputeEffectiveRange_ReturnValue_IsValid;

	private static FFieldAddress ComputeEffectiveRange_ReturnValue_PropertyAddress;

	private static int ComputeEffectiveRange_ReturnValue_Offset;

	private static bool AddKey_IsValid;

	private static IntPtr AddKey_FunctionAddress;

	private static int AddKey_ParamsSize;

	private static bool AddKey_InTime_IsValid;

	private static FFieldAddress AddKey_InTime_PropertyAddress;

	private static int AddKey_InTime_Offset;

	private static bool AddKey_NewValue_IsValid;

	private static FFieldAddress AddKey_NewValue_PropertyAddress;

	private static int AddKey_NewValue_Offset;

	private static bool AddKey_SubFrame_IsValid;

	private static FFieldAddress AddKey_SubFrame_PropertyAddress;

	private static int AddKey_SubFrame_Offset;

	private static bool AddKey_TimeUnit_IsValid;

	private static FFieldAddress AddKey_TimeUnit_PropertyAddress;

	private static int AddKey_TimeUnit_Offset;

	private static bool AddKey_InInterpolation_IsValid;

	private static FFieldAddress AddKey_InInterpolation_PropertyAddress;

	private static int AddKey_InInterpolation_Offset;

	private static bool AddKey_ReturnValue_IsValid;

	private static FFieldAddress AddKey_ReturnValue_PropertyAddress;

	private static int AddKey_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:SetPreInfinityExtrapolation")]
	public unsafe void SetPreInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation)
	{
		CheckDestroyed();
		if (!SetPreInfinityExtrapolation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:SetPreInfinityExtrapolation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPreInfinityExtrapolation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPreInfinityExtrapolation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERichCurveExtrapolation>.ToNative(IntPtr.Add(intPtr, SetPreInfinityExtrapolation_InExtrapolation_Offset), 0, SetPreInfinityExtrapolation_InExtrapolation_PropertyAddress.Address, InExtrapolation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPreInfinityExtrapolation_FunctionAddress, intPtr, SetPreInfinityExtrapolation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:SetPostInfinityExtrapolation")]
	public unsafe void SetPostInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation)
	{
		CheckDestroyed();
		if (!SetPostInfinityExtrapolation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:SetPostInfinityExtrapolation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPostInfinityExtrapolation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPostInfinityExtrapolation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERichCurveExtrapolation>.ToNative(IntPtr.Add(intPtr, SetPostInfinityExtrapolation_InExtrapolation_Offset), 0, SetPostInfinityExtrapolation_InExtrapolation_PropertyAddress.Address, InExtrapolation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPostInfinityExtrapolation_FunctionAddress, intPtr, SetPostInfinityExtrapolation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:SetDefault")]
	public unsafe void SetDefault(float InDefaultValue)
	{
		CheckDestroyed();
		if (!SetDefault_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:SetDefault");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefault_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefault_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDefault_InDefaultValue_Offset), 0, SetDefault_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefault_FunctionAddress, intPtr, SetDefault_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:RemoveKey")]
	public unsafe void RemoveKey(UMovieSceneScriptingKey Key)
	{
		CheckDestroyed();
		if (!RemoveKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:RemoveKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneScriptingKey>.ToNative(IntPtr.Add(intPtr, RemoveKey_Key_Offset), 0, RemoveKey_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveKey_FunctionAddress, intPtr, RemoveKey_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:RemoveDefault")]
	public unsafe void RemoveDefault()
	{
		CheckDestroyed();
		if (!RemoveDefault_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:RemoveDefault");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveDefault_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveDefault_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RemoveDefault_FunctionAddress, argsSize: RemoveDefault_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:HasDefault")]
	public unsafe bool HasDefault()
	{
		CheckDestroyed();
		if (!HasDefault_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:HasDefault");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasDefault_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasDefault_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasDefault_FunctionAddress, intPtr, HasDefault_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasDefault_ReturnValue_Offset), 0, HasDefault_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetPreInfinityExtrapolation")]
	public unsafe ERichCurveExtrapolation GetPreInfinityExtrapolation()
	{
		CheckDestroyed();
		if (!GetPreInfinityExtrapolation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetPreInfinityExtrapolation");
			return ERichCurveExtrapolation.RCCE_Cycle;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreInfinityExtrapolation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreInfinityExtrapolation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreInfinityExtrapolation_FunctionAddress, intPtr, GetPreInfinityExtrapolation_ParamsSize);
		return EnumMarshaler<ERichCurveExtrapolation>.FromNative(IntPtr.Add(intPtr, GetPreInfinityExtrapolation_ReturnValue_Offset), 0, GetPreInfinityExtrapolation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetPostInfinityExtrapolation")]
	public unsafe ERichCurveExtrapolation GetPostInfinityExtrapolation()
	{
		CheckDestroyed();
		if (!GetPostInfinityExtrapolation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetPostInfinityExtrapolation");
			return ERichCurveExtrapolation.RCCE_Cycle;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPostInfinityExtrapolation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPostInfinityExtrapolation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPostInfinityExtrapolation_FunctionAddress, intPtr, GetPostInfinityExtrapolation_ParamsSize);
		return EnumMarshaler<ERichCurveExtrapolation>.FromNative(IntPtr.Add(intPtr, GetPostInfinityExtrapolation_ReturnValue_Offset), 0, GetPostInfinityExtrapolation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetNumKeys")]
	public unsafe int GetNumKeys()
	{
		CheckDestroyed();
		if (!GetNumKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetNumKeys");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumKeys_FunctionAddress, intPtr, GetNumKeys_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumKeys_ReturnValue_Offset), 0, GetNumKeys_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetKeys")]
	public unsafe List<UMovieSceneScriptingKey> GetKeys()
	{
		CheckDestroyed();
		if (!GetKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetKeys_FunctionAddress, intPtr, GetKeys_ParamsSize);
		List<UMovieSceneScriptingKey> result = new TArrayCopyMarshaler<UMovieSceneScriptingKey>(1, GetKeys_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneScriptingKey, UObjectMarshaler<UMovieSceneScriptingKey>>.FromNative, CachedMarshalingDelegates<UMovieSceneScriptingKey, UObjectMarshaler<UMovieSceneScriptingKey>>.ToNative).FromNative(IntPtr.Add(intPtr, GetKeys_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetKeys_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetDefault")]
	public unsafe float GetDefault()
	{
		CheckDestroyed();
		if (!GetDefault_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetDefault");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefault_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefault_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefault_FunctionAddress, intPtr, GetDefault_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDefault_ReturnValue_Offset), 0, GetDefault_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:EvaluateKeys")]
	public unsafe List<float> EvaluateKeys(FSequencerScriptingRange Range, FFrameRate FrameRate)
	{
		CheckDestroyed();
		if (!EvaluateKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:EvaluateKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EvaluateKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EvaluateKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EvaluateKeys_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, EvaluateKeys_Range_Offset), 0, EvaluateKeys_Range_PropertyAddress.Address, Range);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, EvaluateKeys_FrameRate_Offset), 0, EvaluateKeys_FrameRate_PropertyAddress.Address, FrameRate);
		NativeReflection.InvokeFunctionOptimized(base.Address, EvaluateKeys_FunctionAddress, intPtr, EvaluateKeys_ParamsSize);
		List<float> result = new TArrayCopyMarshaler<float>(1, EvaluateKeys_ReturnValue_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, EvaluateKeys_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(EvaluateKeys_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:ComputeEffectiveRange")]
	public unsafe FSequencerScriptingRange ComputeEffectiveRange()
	{
		CheckDestroyed();
		if (!ComputeEffectiveRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:ComputeEffectiveRange");
			return default(FSequencerScriptingRange);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ComputeEffectiveRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComputeEffectiveRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ComputeEffectiveRange_FunctionAddress, intPtr, ComputeEffectiveRange_ParamsSize);
		return FSequencerScriptingRange.FromNative(IntPtr.Add(intPtr, ComputeEffectiveRange_ReturnValue_Offset), 0, ComputeEffectiveRange_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:AddKey")]
	public unsafe UMovieSceneScriptingFloatKey AddKey(FFrameNumber InTime, float NewValue, float SubFrame = 0f, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, EMovieSceneKeyInterpolation InInterpolation = EMovieSceneKeyInterpolation.Auto)
	{
		CheckDestroyed();
		if (!AddKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:AddKey");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddKey_InTime_Offset), 0, AddKey_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddKey_NewValue_Offset), 0, AddKey_NewValue_PropertyAddress.Address, NewValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddKey_SubFrame_Offset), 0, AddKey_SubFrame_PropertyAddress.Address, SubFrame);
		EnumMarshaler<ESequenceTimeUnit>.ToNative(IntPtr.Add(intPtr, AddKey_TimeUnit_Offset), 0, AddKey_TimeUnit_PropertyAddress.Address, TimeUnit);
		EnumMarshaler<EMovieSceneKeyInterpolation>.ToNative(IntPtr.Add(intPtr, AddKey_InInterpolation_Offset), 0, AddKey_InInterpolation_PropertyAddress.Address, InInterpolation);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddKey_FunctionAddress, intPtr, AddKey_ParamsSize);
		return UObjectMarshaler<UMovieSceneScriptingFloatKey>.FromNative(IntPtr.Add(intPtr, AddKey_ReturnValue_Offset), 0, AddKey_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneScriptingFloatChannel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneScriptingFloatChannel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneScriptingFloatChannel));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneScriptingFloatChannel");
		SetPreInfinityExtrapolation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPreInfinityExtrapolation");
		SetPreInfinityExtrapolation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPreInfinityExtrapolation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPreInfinityExtrapolation_InExtrapolation_PropertyAddress, SetPreInfinityExtrapolation_FunctionAddress, "InExtrapolation");
		SetPreInfinityExtrapolation_InExtrapolation_Offset = NativeReflectionCached.GetPropertyOffset(SetPreInfinityExtrapolation_FunctionAddress, "InExtrapolation");
		SetPreInfinityExtrapolation_InExtrapolation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreInfinityExtrapolation_FunctionAddress, "InExtrapolation", Classes.FByteProperty);
		SetPreInfinityExtrapolation_IsValid = SetPreInfinityExtrapolation_FunctionAddress != IntPtr.Zero && SetPreInfinityExtrapolation_InExtrapolation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:SetPreInfinityExtrapolation", SetPreInfinityExtrapolation_IsValid);
		SetPostInfinityExtrapolation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPostInfinityExtrapolation");
		SetPostInfinityExtrapolation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPostInfinityExtrapolation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPostInfinityExtrapolation_InExtrapolation_PropertyAddress, SetPostInfinityExtrapolation_FunctionAddress, "InExtrapolation");
		SetPostInfinityExtrapolation_InExtrapolation_Offset = NativeReflectionCached.GetPropertyOffset(SetPostInfinityExtrapolation_FunctionAddress, "InExtrapolation");
		SetPostInfinityExtrapolation_InExtrapolation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPostInfinityExtrapolation_FunctionAddress, "InExtrapolation", Classes.FByteProperty);
		SetPostInfinityExtrapolation_IsValid = SetPostInfinityExtrapolation_FunctionAddress != IntPtr.Zero && SetPostInfinityExtrapolation_InExtrapolation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:SetPostInfinityExtrapolation", SetPostInfinityExtrapolation_IsValid);
		SetDefault_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDefault");
		SetDefault_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefault_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefault_InDefaultValue_PropertyAddress, SetDefault_FunctionAddress, "InDefaultValue");
		SetDefault_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDefault_FunctionAddress, "InDefaultValue");
		SetDefault_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefault_FunctionAddress, "InDefaultValue", Classes.FFloatProperty);
		SetDefault_IsValid = SetDefault_FunctionAddress != IntPtr.Zero && SetDefault_InDefaultValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:SetDefault", SetDefault_IsValid);
		RemoveKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveKey");
		RemoveKey_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveKey_Key_PropertyAddress, RemoveKey_FunctionAddress, "Key");
		RemoveKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(RemoveKey_FunctionAddress, "Key");
		RemoveKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveKey_FunctionAddress, "Key", Classes.FObjectProperty);
		RemoveKey_IsValid = RemoveKey_FunctionAddress != IntPtr.Zero && RemoveKey_Key_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:RemoveKey", RemoveKey_IsValid);
		RemoveDefault_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveDefault");
		RemoveDefault_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveDefault_FunctionAddress);
		RemoveDefault_IsValid = RemoveDefault_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:RemoveDefault", RemoveDefault_IsValid);
		HasDefault_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasDefault");
		HasDefault_ParamsSize = NativeReflection.GetFunctionParamsSize(HasDefault_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasDefault_ReturnValue_PropertyAddress, HasDefault_FunctionAddress, "ReturnValue");
		HasDefault_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasDefault_FunctionAddress, "ReturnValue");
		HasDefault_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasDefault_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasDefault_IsValid = HasDefault_FunctionAddress != IntPtr.Zero && HasDefault_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:HasDefault", HasDefault_IsValid);
		GetPreInfinityExtrapolation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPreInfinityExtrapolation");
		GetPreInfinityExtrapolation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreInfinityExtrapolation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreInfinityExtrapolation_ReturnValue_PropertyAddress, GetPreInfinityExtrapolation_FunctionAddress, "ReturnValue");
		GetPreInfinityExtrapolation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreInfinityExtrapolation_FunctionAddress, "ReturnValue");
		GetPreInfinityExtrapolation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreInfinityExtrapolation_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetPreInfinityExtrapolation_IsValid = GetPreInfinityExtrapolation_FunctionAddress != IntPtr.Zero && GetPreInfinityExtrapolation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetPreInfinityExtrapolation", GetPreInfinityExtrapolation_IsValid);
		GetPostInfinityExtrapolation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPostInfinityExtrapolation");
		GetPostInfinityExtrapolation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPostInfinityExtrapolation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPostInfinityExtrapolation_ReturnValue_PropertyAddress, GetPostInfinityExtrapolation_FunctionAddress, "ReturnValue");
		GetPostInfinityExtrapolation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPostInfinityExtrapolation_FunctionAddress, "ReturnValue");
		GetPostInfinityExtrapolation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPostInfinityExtrapolation_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetPostInfinityExtrapolation_IsValid = GetPostInfinityExtrapolation_FunctionAddress != IntPtr.Zero && GetPostInfinityExtrapolation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetPostInfinityExtrapolation", GetPostInfinityExtrapolation_IsValid);
		GetNumKeys_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumKeys");
		GetNumKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumKeys_ReturnValue_PropertyAddress, GetNumKeys_FunctionAddress, "ReturnValue");
		GetNumKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumKeys_FunctionAddress, "ReturnValue");
		GetNumKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumKeys_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumKeys_IsValid = GetNumKeys_FunctionAddress != IntPtr.Zero && GetNumKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetNumKeys", GetNumKeys_IsValid);
		GetKeys_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetKeys");
		GetKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeys_ReturnValue_PropertyAddress, GetKeys_FunctionAddress, "ReturnValue");
		GetKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeys_FunctionAddress, "ReturnValue");
		GetKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetKeys_IsValid = GetKeys_FunctionAddress != IntPtr.Zero && GetKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetKeys", GetKeys_IsValid);
		GetDefault_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDefault");
		GetDefault_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefault_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefault_ReturnValue_PropertyAddress, GetDefault_FunctionAddress, "ReturnValue");
		GetDefault_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefault_FunctionAddress, "ReturnValue");
		GetDefault_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefault_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDefault_IsValid = GetDefault_FunctionAddress != IntPtr.Zero && GetDefault_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:GetDefault", GetDefault_IsValid);
		EvaluateKeys_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EvaluateKeys");
		EvaluateKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(EvaluateKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EvaluateKeys_Range_PropertyAddress, EvaluateKeys_FunctionAddress, "Range");
		EvaluateKeys_Range_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateKeys_FunctionAddress, "Range");
		EvaluateKeys_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateKeys_FunctionAddress, "Range", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateKeys_FrameRate_PropertyAddress, EvaluateKeys_FunctionAddress, "FrameRate");
		EvaluateKeys_FrameRate_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateKeys_FunctionAddress, "FrameRate");
		EvaluateKeys_FrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateKeys_FunctionAddress, "FrameRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateKeys_ReturnValue_PropertyAddress, EvaluateKeys_FunctionAddress, "ReturnValue");
		EvaluateKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateKeys_FunctionAddress, "ReturnValue");
		EvaluateKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		EvaluateKeys_IsValid = EvaluateKeys_FunctionAddress != IntPtr.Zero && EvaluateKeys_Range_IsValid && EvaluateKeys_FrameRate_IsValid && EvaluateKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:EvaluateKeys", EvaluateKeys_IsValid);
		ComputeEffectiveRange_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ComputeEffectiveRange");
		ComputeEffectiveRange_ParamsSize = NativeReflection.GetFunctionParamsSize(ComputeEffectiveRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComputeEffectiveRange_ReturnValue_PropertyAddress, ComputeEffectiveRange_FunctionAddress, "ReturnValue");
		ComputeEffectiveRange_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ComputeEffectiveRange_FunctionAddress, "ReturnValue");
		ComputeEffectiveRange_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeEffectiveRange_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ComputeEffectiveRange_IsValid = ComputeEffectiveRange_FunctionAddress != IntPtr.Zero && ComputeEffectiveRange_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:ComputeEffectiveRange", ComputeEffectiveRange_IsValid);
		AddKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddKey");
		AddKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddKey_InTime_PropertyAddress, AddKey_FunctionAddress, "InTime");
		AddKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "InTime");
		AddKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKey_NewValue_PropertyAddress, AddKey_FunctionAddress, "NewValue");
		AddKey_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "NewValue");
		AddKey_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "NewValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKey_SubFrame_PropertyAddress, AddKey_FunctionAddress, "SubFrame");
		AddKey_SubFrame_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "SubFrame");
		AddKey_SubFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "SubFrame", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKey_TimeUnit_PropertyAddress, AddKey_FunctionAddress, "TimeUnit");
		AddKey_TimeUnit_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "TimeUnit");
		AddKey_TimeUnit_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "TimeUnit", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKey_InInterpolation_PropertyAddress, AddKey_FunctionAddress, "InInterpolation");
		AddKey_InInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "InInterpolation");
		AddKey_InInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "InInterpolation", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKey_ReturnValue_PropertyAddress, AddKey_FunctionAddress, "ReturnValue");
		AddKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "ReturnValue");
		AddKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddKey_IsValid = AddKey_FunctionAddress != IntPtr.Zero && AddKey_InTime_IsValid && AddKey_NewValue_IsValid && AddKey_SubFrame_IsValid && AddKey_TimeUnit_IsValid && AddKey_InInterpolation_IsValid && AddKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatChannel:AddKey", AddKey_IsValid);
	}
}
