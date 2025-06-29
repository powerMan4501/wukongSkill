using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[Abstract]
[UClass(Flags = (ClassFlags)809500833uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneScriptingFloatKey : UMovieSceneScriptingKey
{
	private static bool SetValue_IsValid;

	private static IntPtr SetValue_FunctionAddress;

	private static int SetValue_ParamsSize;

	private static bool SetValue_InNewValue_IsValid;

	private static FFieldAddress SetValue_InNewValue_PropertyAddress;

	private static int SetValue_InNewValue_Offset;

	private static bool SetTime_IsValid;

	private static IntPtr SetTime_FunctionAddress;

	private static int SetTime_ParamsSize;

	private static bool SetTime_NewFrameNumber_IsValid;

	private static FFieldAddress SetTime_NewFrameNumber_PropertyAddress;

	private static int SetTime_NewFrameNumber_Offset;

	private static bool SetTime_SubFrame_IsValid;

	private static FFieldAddress SetTime_SubFrame_PropertyAddress;

	private static int SetTime_SubFrame_Offset;

	private static bool SetTime_TimeUnit_IsValid;

	private static FFieldAddress SetTime_TimeUnit_PropertyAddress;

	private static int SetTime_TimeUnit_Offset;

	private static bool SetTangentWeightMode_IsValid;

	private static IntPtr SetTangentWeightMode_FunctionAddress;

	private static int SetTangentWeightMode_ParamsSize;

	private static bool SetTangentWeightMode_InNewValue_IsValid;

	private static FFieldAddress SetTangentWeightMode_InNewValue_PropertyAddress;

	private static int SetTangentWeightMode_InNewValue_Offset;

	private static bool SetTangentMode_IsValid;

	private static IntPtr SetTangentMode_FunctionAddress;

	private static int SetTangentMode_ParamsSize;

	private static bool SetTangentMode_InNewValue_IsValid;

	private static FFieldAddress SetTangentMode_InNewValue_PropertyAddress;

	private static int SetTangentMode_InNewValue_Offset;

	private static bool SetLeaveTangentWeight_IsValid;

	private static IntPtr SetLeaveTangentWeight_FunctionAddress;

	private static int SetLeaveTangentWeight_ParamsSize;

	private static bool SetLeaveTangentWeight_InNewValue_IsValid;

	private static FFieldAddress SetLeaveTangentWeight_InNewValue_PropertyAddress;

	private static int SetLeaveTangentWeight_InNewValue_Offset;

	private static bool SetLeaveTangent_IsValid;

	private static IntPtr SetLeaveTangent_FunctionAddress;

	private static int SetLeaveTangent_ParamsSize;

	private static bool SetLeaveTangent_InNewValue_IsValid;

	private static FFieldAddress SetLeaveTangent_InNewValue_PropertyAddress;

	private static int SetLeaveTangent_InNewValue_Offset;

	private static bool SetInterpolationMode_IsValid;

	private static IntPtr SetInterpolationMode_FunctionAddress;

	private static int SetInterpolationMode_ParamsSize;

	private static bool SetInterpolationMode_InNewValue_IsValid;

	private static FFieldAddress SetInterpolationMode_InNewValue_PropertyAddress;

	private static int SetInterpolationMode_InNewValue_Offset;

	private static bool SetArriveTangentWeight_IsValid;

	private static IntPtr SetArriveTangentWeight_FunctionAddress;

	private static int SetArriveTangentWeight_ParamsSize;

	private static bool SetArriveTangentWeight_InNewValue_IsValid;

	private static FFieldAddress SetArriveTangentWeight_InNewValue_PropertyAddress;

	private static int SetArriveTangentWeight_InNewValue_Offset;

	private static bool SetArriveTangent_IsValid;

	private static IntPtr SetArriveTangent_FunctionAddress;

	private static int SetArriveTangent_ParamsSize;

	private static bool SetArriveTangent_InNewValue_IsValid;

	private static FFieldAddress SetArriveTangent_InNewValue_PropertyAddress;

	private static int SetArriveTangent_InNewValue_Offset;

	private static bool GetValue_IsValid;

	private static IntPtr GetValue_FunctionAddress;

	private static int GetValue_ParamsSize;

	private static bool GetValue_ReturnValue_IsValid;

	private static FFieldAddress GetValue_ReturnValue_PropertyAddress;

	private static int GetValue_ReturnValue_Offset;

	private static bool GetTime_IsValid;

	private static IntPtr GetTime_FunctionAddress;

	private static int GetTime_ParamsSize;

	private static bool GetTime_TimeUnit_IsValid;

	private static FFieldAddress GetTime_TimeUnit_PropertyAddress;

	private static int GetTime_TimeUnit_Offset;

	private static bool GetTime_ReturnValue_IsValid;

	private static FFieldAddress GetTime_ReturnValue_PropertyAddress;

	private static int GetTime_ReturnValue_Offset;

	private static bool GetTangentWeightMode_IsValid;

	private static IntPtr GetTangentWeightMode_FunctionAddress;

	private static int GetTangentWeightMode_ParamsSize;

	private static bool GetTangentWeightMode_ReturnValue_IsValid;

	private static FFieldAddress GetTangentWeightMode_ReturnValue_PropertyAddress;

	private static int GetTangentWeightMode_ReturnValue_Offset;

	private static bool GetTangentMode_IsValid;

	private static IntPtr GetTangentMode_FunctionAddress;

	private static int GetTangentMode_ParamsSize;

	private static bool GetTangentMode_ReturnValue_IsValid;

	private static FFieldAddress GetTangentMode_ReturnValue_PropertyAddress;

	private static int GetTangentMode_ReturnValue_Offset;

	private static bool GetLeaveTangentWeight_IsValid;

	private static IntPtr GetLeaveTangentWeight_FunctionAddress;

	private static int GetLeaveTangentWeight_ParamsSize;

	private static bool GetLeaveTangentWeight_ReturnValue_IsValid;

	private static FFieldAddress GetLeaveTangentWeight_ReturnValue_PropertyAddress;

	private static int GetLeaveTangentWeight_ReturnValue_Offset;

	private static bool GetLeaveTangent_IsValid;

	private static IntPtr GetLeaveTangent_FunctionAddress;

	private static int GetLeaveTangent_ParamsSize;

	private static bool GetLeaveTangent_ReturnValue_IsValid;

	private static FFieldAddress GetLeaveTangent_ReturnValue_PropertyAddress;

	private static int GetLeaveTangent_ReturnValue_Offset;

	private static bool GetInterpolationMode_IsValid;

	private static IntPtr GetInterpolationMode_FunctionAddress;

	private static int GetInterpolationMode_ParamsSize;

	private static bool GetInterpolationMode_ReturnValue_IsValid;

	private static FFieldAddress GetInterpolationMode_ReturnValue_PropertyAddress;

	private static int GetInterpolationMode_ReturnValue_Offset;

	private static bool GetArriveTangentWeight_IsValid;

	private static IntPtr GetArriveTangentWeight_FunctionAddress;

	private static int GetArriveTangentWeight_ParamsSize;

	private static bool GetArriveTangentWeight_ReturnValue_IsValid;

	private static FFieldAddress GetArriveTangentWeight_ReturnValue_PropertyAddress;

	private static int GetArriveTangentWeight_ReturnValue_Offset;

	private static bool GetArriveTangent_IsValid;

	private static IntPtr GetArriveTangent_FunctionAddress;

	private static int GetArriveTangent_ParamsSize;

	private static bool GetArriveTangent_ReturnValue_IsValid;

	private static FFieldAddress GetArriveTangent_ReturnValue_PropertyAddress;

	private static int GetArriveTangent_ReturnValue_Offset;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetValue")]
	public unsafe void SetValue(float InNewValue)
	{
		CheckDestroyed();
		if (!SetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetValue_InNewValue_Offset), 0, SetValue_InNewValue_PropertyAddress.Address, InNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValue_FunctionAddress, intPtr, SetValue_ParamsSize);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetTime")]
	public unsafe void SetTime(FFrameNumber NewFrameNumber, float SubFrame = 0f, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
	{
		CheckDestroyed();
		if (!SetTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetTime_NewFrameNumber_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, SetTime_NewFrameNumber_Offset), 0, SetTime_NewFrameNumber_PropertyAddress.Address, NewFrameNumber);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTime_SubFrame_Offset), 0, SetTime_SubFrame_PropertyAddress.Address, SubFrame);
		EnumMarshaler<ESequenceTimeUnit>.ToNative(IntPtr.Add(intPtr, SetTime_TimeUnit_Offset), 0, SetTime_TimeUnit_PropertyAddress.Address, TimeUnit);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTime_FunctionAddress, intPtr, SetTime_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetTangentWeightMode")]
	public unsafe void SetTangentWeightMode(ERichCurveTangentWeightMode InNewValue)
	{
		CheckDestroyed();
		if (!SetTangentWeightMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetTangentWeightMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTangentWeightMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTangentWeightMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERichCurveTangentWeightMode>.ToNative(IntPtr.Add(intPtr, SetTangentWeightMode_InNewValue_Offset), 0, SetTangentWeightMode_InNewValue_PropertyAddress.Address, InNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTangentWeightMode_FunctionAddress, intPtr, SetTangentWeightMode_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetTangentMode")]
	public unsafe void SetTangentMode(ERichCurveTangentMode InNewValue)
	{
		CheckDestroyed();
		if (!SetTangentMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetTangentMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTangentMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTangentMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERichCurveTangentMode>.ToNative(IntPtr.Add(intPtr, SetTangentMode_InNewValue_Offset), 0, SetTangentMode_InNewValue_PropertyAddress.Address, InNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTangentMode_FunctionAddress, intPtr, SetTangentMode_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetLeaveTangentWeight")]
	public unsafe void SetLeaveTangentWeight(float InNewValue)
	{
		CheckDestroyed();
		if (!SetLeaveTangentWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetLeaveTangentWeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLeaveTangentWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLeaveTangentWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLeaveTangentWeight_InNewValue_Offset), 0, SetLeaveTangentWeight_InNewValue_PropertyAddress.Address, InNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLeaveTangentWeight_FunctionAddress, intPtr, SetLeaveTangentWeight_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetLeaveTangent")]
	public unsafe void SetLeaveTangent(float InNewValue)
	{
		CheckDestroyed();
		if (!SetLeaveTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetLeaveTangent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLeaveTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLeaveTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLeaveTangent_InNewValue_Offset), 0, SetLeaveTangent_InNewValue_PropertyAddress.Address, InNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLeaveTangent_FunctionAddress, intPtr, SetLeaveTangent_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetInterpolationMode")]
	public unsafe void SetInterpolationMode(ERichCurveInterpMode InNewValue)
	{
		CheckDestroyed();
		if (!SetInterpolationMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetInterpolationMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInterpolationMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInterpolationMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERichCurveInterpMode>.ToNative(IntPtr.Add(intPtr, SetInterpolationMode_InNewValue_Offset), 0, SetInterpolationMode_InNewValue_PropertyAddress.Address, InNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInterpolationMode_FunctionAddress, intPtr, SetInterpolationMode_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetArriveTangentWeight")]
	public unsafe void SetArriveTangentWeight(float InNewValue)
	{
		CheckDestroyed();
		if (!SetArriveTangentWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetArriveTangentWeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetArriveTangentWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetArriveTangentWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetArriveTangentWeight_InNewValue_Offset), 0, SetArriveTangentWeight_InNewValue_PropertyAddress.Address, InNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetArriveTangentWeight_FunctionAddress, intPtr, SetArriveTangentWeight_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetArriveTangent")]
	public unsafe void SetArriveTangent(float InNewValue)
	{
		CheckDestroyed();
		if (!SetArriveTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetArriveTangent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetArriveTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetArriveTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetArriveTangent_InNewValue_Offset), 0, SetArriveTangent_InNewValue_PropertyAddress.Address, InNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetArriveTangent_FunctionAddress, intPtr, SetArriveTangent_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetValue")]
	public unsafe float GetValue()
	{
		CheckDestroyed();
		if (!GetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValue_FunctionAddress, intPtr, GetValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetValue_ReturnValue_Offset), 0, GetValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetTime")]
	public unsafe FFrameTime GetTime(ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
	{
		CheckDestroyed();
		if (!GetTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetTime");
			return default(FFrameTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESequenceTimeUnit>.ToNative(IntPtr.Add(intPtr, GetTime_TimeUnit_Offset), 0, GetTime_TimeUnit_PropertyAddress.Address, TimeUnit);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTime_FunctionAddress, intPtr, GetTime_ParamsSize);
		return FFrameTime.FromNative(IntPtr.Add(intPtr, GetTime_ReturnValue_Offset), 0, GetTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetTangentWeightMode")]
	public unsafe ERichCurveTangentWeightMode GetTangentWeightMode()
	{
		CheckDestroyed();
		if (!GetTangentWeightMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetTangentWeightMode");
			return ERichCurveTangentWeightMode.RCTWM_WeightedNone;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTangentWeightMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTangentWeightMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTangentWeightMode_FunctionAddress, intPtr, GetTangentWeightMode_ParamsSize);
		return EnumMarshaler<ERichCurveTangentWeightMode>.FromNative(IntPtr.Add(intPtr, GetTangentWeightMode_ReturnValue_Offset), 0, GetTangentWeightMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetTangentMode")]
	public unsafe ERichCurveTangentMode GetTangentMode()
	{
		CheckDestroyed();
		if (!GetTangentMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetTangentMode");
			return ERichCurveTangentMode.RCTM_Auto;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTangentMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTangentMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTangentMode_FunctionAddress, intPtr, GetTangentMode_ParamsSize);
		return EnumMarshaler<ERichCurveTangentMode>.FromNative(IntPtr.Add(intPtr, GetTangentMode_ReturnValue_Offset), 0, GetTangentMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetLeaveTangentWeight")]
	public unsafe float GetLeaveTangentWeight()
	{
		CheckDestroyed();
		if (!GetLeaveTangentWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetLeaveTangentWeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLeaveTangentWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLeaveTangentWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLeaveTangentWeight_FunctionAddress, intPtr, GetLeaveTangentWeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLeaveTangentWeight_ReturnValue_Offset), 0, GetLeaveTangentWeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetLeaveTangent")]
	public unsafe float GetLeaveTangent()
	{
		CheckDestroyed();
		if (!GetLeaveTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetLeaveTangent");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLeaveTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLeaveTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLeaveTangent_FunctionAddress, intPtr, GetLeaveTangent_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLeaveTangent_ReturnValue_Offset), 0, GetLeaveTangent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetInterpolationMode")]
	public unsafe ERichCurveInterpMode GetInterpolationMode()
	{
		CheckDestroyed();
		if (!GetInterpolationMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetInterpolationMode");
			return ERichCurveInterpMode.RCIM_Linear;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInterpolationMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInterpolationMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInterpolationMode_FunctionAddress, intPtr, GetInterpolationMode_ParamsSize);
		return EnumMarshaler<ERichCurveInterpMode>.FromNative(IntPtr.Add(intPtr, GetInterpolationMode_ReturnValue_Offset), 0, GetInterpolationMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetArriveTangentWeight")]
	public unsafe float GetArriveTangentWeight()
	{
		CheckDestroyed();
		if (!GetArriveTangentWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetArriveTangentWeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetArriveTangentWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetArriveTangentWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetArriveTangentWeight_FunctionAddress, intPtr, GetArriveTangentWeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetArriveTangentWeight_ReturnValue_Offset), 0, GetArriveTangentWeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetArriveTangent")]
	public unsafe float GetArriveTangent()
	{
		CheckDestroyed();
		if (!GetArriveTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetArriveTangent");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetArriveTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetArriveTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetArriveTangent_FunctionAddress, intPtr, GetArriveTangent_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetArriveTangent_ReturnValue_Offset), 0, GetArriveTangent_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneScriptingFloatKey()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneScriptingFloatKey)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneScriptingFloatKey));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneScriptingFloatKey");
		SetValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValue");
		SetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValue_InNewValue_PropertyAddress, SetValue_FunctionAddress, "InNewValue");
		SetValue_InNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValue_FunctionAddress, "InNewValue");
		SetValue_InNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValue_FunctionAddress, "InNewValue", Classes.FFloatProperty);
		SetValue_IsValid = SetValue_FunctionAddress != IntPtr.Zero && SetValue_InNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetValue", SetValue_IsValid);
		SetTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTime");
		SetTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTime_NewFrameNumber_PropertyAddress, SetTime_FunctionAddress, "NewFrameNumber");
		SetTime_NewFrameNumber_Offset = NativeReflectionCached.GetPropertyOffset(SetTime_FunctionAddress, "NewFrameNumber");
		SetTime_NewFrameNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTime_FunctionAddress, "NewFrameNumber", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTime_SubFrame_PropertyAddress, SetTime_FunctionAddress, "SubFrame");
		SetTime_SubFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetTime_FunctionAddress, "SubFrame");
		SetTime_SubFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTime_FunctionAddress, "SubFrame", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTime_TimeUnit_PropertyAddress, SetTime_FunctionAddress, "TimeUnit");
		SetTime_TimeUnit_Offset = NativeReflectionCached.GetPropertyOffset(SetTime_FunctionAddress, "TimeUnit");
		SetTime_TimeUnit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTime_FunctionAddress, "TimeUnit", Classes.FEnumProperty);
		SetTime_IsValid = SetTime_FunctionAddress != IntPtr.Zero && SetTime_NewFrameNumber_IsValid && SetTime_SubFrame_IsValid && SetTime_TimeUnit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetTime", SetTime_IsValid);
		SetTangentWeightMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTangentWeightMode");
		SetTangentWeightMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTangentWeightMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTangentWeightMode_InNewValue_PropertyAddress, SetTangentWeightMode_FunctionAddress, "InNewValue");
		SetTangentWeightMode_InNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentWeightMode_FunctionAddress, "InNewValue");
		SetTangentWeightMode_InNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentWeightMode_FunctionAddress, "InNewValue", Classes.FByteProperty);
		SetTangentWeightMode_IsValid = SetTangentWeightMode_FunctionAddress != IntPtr.Zero && SetTangentWeightMode_InNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetTangentWeightMode", SetTangentWeightMode_IsValid);
		SetTangentMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTangentMode");
		SetTangentMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTangentMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTangentMode_InNewValue_PropertyAddress, SetTangentMode_FunctionAddress, "InNewValue");
		SetTangentMode_InNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentMode_FunctionAddress, "InNewValue");
		SetTangentMode_InNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentMode_FunctionAddress, "InNewValue", Classes.FByteProperty);
		SetTangentMode_IsValid = SetTangentMode_FunctionAddress != IntPtr.Zero && SetTangentMode_InNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetTangentMode", SetTangentMode_IsValid);
		SetLeaveTangentWeight_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLeaveTangentWeight");
		SetLeaveTangentWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLeaveTangentWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLeaveTangentWeight_InNewValue_PropertyAddress, SetLeaveTangentWeight_FunctionAddress, "InNewValue");
		SetLeaveTangentWeight_InNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLeaveTangentWeight_FunctionAddress, "InNewValue");
		SetLeaveTangentWeight_InNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLeaveTangentWeight_FunctionAddress, "InNewValue", Classes.FFloatProperty);
		SetLeaveTangentWeight_IsValid = SetLeaveTangentWeight_FunctionAddress != IntPtr.Zero && SetLeaveTangentWeight_InNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetLeaveTangentWeight", SetLeaveTangentWeight_IsValid);
		SetLeaveTangent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLeaveTangent");
		SetLeaveTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLeaveTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLeaveTangent_InNewValue_PropertyAddress, SetLeaveTangent_FunctionAddress, "InNewValue");
		SetLeaveTangent_InNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLeaveTangent_FunctionAddress, "InNewValue");
		SetLeaveTangent_InNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLeaveTangent_FunctionAddress, "InNewValue", Classes.FFloatProperty);
		SetLeaveTangent_IsValid = SetLeaveTangent_FunctionAddress != IntPtr.Zero && SetLeaveTangent_InNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetLeaveTangent", SetLeaveTangent_IsValid);
		SetInterpolationMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetInterpolationMode");
		SetInterpolationMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInterpolationMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInterpolationMode_InNewValue_PropertyAddress, SetInterpolationMode_FunctionAddress, "InNewValue");
		SetInterpolationMode_InNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetInterpolationMode_FunctionAddress, "InNewValue");
		SetInterpolationMode_InNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInterpolationMode_FunctionAddress, "InNewValue", Classes.FByteProperty);
		SetInterpolationMode_IsValid = SetInterpolationMode_FunctionAddress != IntPtr.Zero && SetInterpolationMode_InNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetInterpolationMode", SetInterpolationMode_IsValid);
		SetArriveTangentWeight_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetArriveTangentWeight");
		SetArriveTangentWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetArriveTangentWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetArriveTangentWeight_InNewValue_PropertyAddress, SetArriveTangentWeight_FunctionAddress, "InNewValue");
		SetArriveTangentWeight_InNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetArriveTangentWeight_FunctionAddress, "InNewValue");
		SetArriveTangentWeight_InNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArriveTangentWeight_FunctionAddress, "InNewValue", Classes.FFloatProperty);
		SetArriveTangentWeight_IsValid = SetArriveTangentWeight_FunctionAddress != IntPtr.Zero && SetArriveTangentWeight_InNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetArriveTangentWeight", SetArriveTangentWeight_IsValid);
		SetArriveTangent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetArriveTangent");
		SetArriveTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetArriveTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetArriveTangent_InNewValue_PropertyAddress, SetArriveTangent_FunctionAddress, "InNewValue");
		SetArriveTangent_InNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetArriveTangent_FunctionAddress, "InNewValue");
		SetArriveTangent_InNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArriveTangent_FunctionAddress, "InNewValue", Classes.FFloatProperty);
		SetArriveTangent_IsValid = SetArriveTangent_FunctionAddress != IntPtr.Zero && SetArriveTangent_InNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:SetArriveTangent", SetArriveTangent_IsValid);
		GetValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValue");
		GetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValue_ReturnValue_PropertyAddress, GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetValue_IsValid = GetValue_FunctionAddress != IntPtr.Zero && GetValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetValue", GetValue_IsValid);
		GetTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTime");
		GetTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTime_TimeUnit_PropertyAddress, GetTime_FunctionAddress, "TimeUnit");
		GetTime_TimeUnit_Offset = NativeReflectionCached.GetPropertyOffset(GetTime_FunctionAddress, "TimeUnit");
		GetTime_TimeUnit_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTime_FunctionAddress, "TimeUnit", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTime_ReturnValue_PropertyAddress, GetTime_FunctionAddress, "ReturnValue");
		GetTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTime_FunctionAddress, "ReturnValue");
		GetTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTime_IsValid = GetTime_FunctionAddress != IntPtr.Zero && GetTime_TimeUnit_IsValid && GetTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetTime", GetTime_IsValid);
		GetTangentWeightMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTangentWeightMode");
		GetTangentWeightMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTangentWeightMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTangentWeightMode_ReturnValue_PropertyAddress, GetTangentWeightMode_FunctionAddress, "ReturnValue");
		GetTangentWeightMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentWeightMode_FunctionAddress, "ReturnValue");
		GetTangentWeightMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentWeightMode_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetTangentWeightMode_IsValid = GetTangentWeightMode_FunctionAddress != IntPtr.Zero && GetTangentWeightMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetTangentWeightMode", GetTangentWeightMode_IsValid);
		GetTangentMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTangentMode");
		GetTangentMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTangentMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTangentMode_ReturnValue_PropertyAddress, GetTangentMode_FunctionAddress, "ReturnValue");
		GetTangentMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentMode_FunctionAddress, "ReturnValue");
		GetTangentMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentMode_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetTangentMode_IsValid = GetTangentMode_FunctionAddress != IntPtr.Zero && GetTangentMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetTangentMode", GetTangentMode_IsValid);
		GetLeaveTangentWeight_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLeaveTangentWeight");
		GetLeaveTangentWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLeaveTangentWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLeaveTangentWeight_ReturnValue_PropertyAddress, GetLeaveTangentWeight_FunctionAddress, "ReturnValue");
		GetLeaveTangentWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLeaveTangentWeight_FunctionAddress, "ReturnValue");
		GetLeaveTangentWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLeaveTangentWeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetLeaveTangentWeight_IsValid = GetLeaveTangentWeight_FunctionAddress != IntPtr.Zero && GetLeaveTangentWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetLeaveTangentWeight", GetLeaveTangentWeight_IsValid);
		GetLeaveTangent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLeaveTangent");
		GetLeaveTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLeaveTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLeaveTangent_ReturnValue_PropertyAddress, GetLeaveTangent_FunctionAddress, "ReturnValue");
		GetLeaveTangent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLeaveTangent_FunctionAddress, "ReturnValue");
		GetLeaveTangent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLeaveTangent_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetLeaveTangent_IsValid = GetLeaveTangent_FunctionAddress != IntPtr.Zero && GetLeaveTangent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetLeaveTangent", GetLeaveTangent_IsValid);
		GetInterpolationMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetInterpolationMode");
		GetInterpolationMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInterpolationMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInterpolationMode_ReturnValue_PropertyAddress, GetInterpolationMode_FunctionAddress, "ReturnValue");
		GetInterpolationMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInterpolationMode_FunctionAddress, "ReturnValue");
		GetInterpolationMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInterpolationMode_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetInterpolationMode_IsValid = GetInterpolationMode_FunctionAddress != IntPtr.Zero && GetInterpolationMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetInterpolationMode", GetInterpolationMode_IsValid);
		GetArriveTangentWeight_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetArriveTangentWeight");
		GetArriveTangentWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetArriveTangentWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetArriveTangentWeight_ReturnValue_PropertyAddress, GetArriveTangentWeight_FunctionAddress, "ReturnValue");
		GetArriveTangentWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetArriveTangentWeight_FunctionAddress, "ReturnValue");
		GetArriveTangentWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArriveTangentWeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetArriveTangentWeight_IsValid = GetArriveTangentWeight_FunctionAddress != IntPtr.Zero && GetArriveTangentWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetArriveTangentWeight", GetArriveTangentWeight_IsValid);
		GetArriveTangent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetArriveTangent");
		GetArriveTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetArriveTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetArriveTangent_ReturnValue_PropertyAddress, GetArriveTangent_FunctionAddress, "ReturnValue");
		GetArriveTangent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetArriveTangent_FunctionAddress, "ReturnValue");
		GetArriveTangent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArriveTangent_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetArriveTangent_IsValid = GetArriveTangent_FunctionAddress != IntPtr.Zero && GetArriveTangent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingFloatKey:GetArriveTangent", GetArriveTangent_IsValid);
	}
}
