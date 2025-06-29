using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneScriptingObjectPathKey : UMovieSceneScriptingKey
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:SetValue")]
	public unsafe void SetValue(UObject InNewValue)
	{
		CheckDestroyed();
		if (!SetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:SetValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetValue_InNewValue_Offset), 0, SetValue_InNewValue_PropertyAddress.Address, InNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValue_FunctionAddress, intPtr, SetValue_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:SetTime")]
	public unsafe void SetTime(FFrameNumber NewFrameNumber, float SubFrame = 0f, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
	{
		CheckDestroyed();
		if (!SetTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:SetTime");
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

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:GetValue")]
	public unsafe UObject GetValue()
	{
		CheckDestroyed();
		if (!GetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:GetValue");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValue_FunctionAddress, intPtr, GetValue_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetValue_ReturnValue_Offset), 0, GetValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:GetTime")]
	public unsafe FFrameTime GetTime(ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
	{
		CheckDestroyed();
		if (!GetTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:GetTime");
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

	static UMovieSceneScriptingObjectPathKey()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneScriptingObjectPathKey)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneScriptingObjectPathKey));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey");
		SetValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetValue");
		SetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValue_InNewValue_PropertyAddress, SetValue_FunctionAddress, "InNewValue");
		SetValue_InNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValue_FunctionAddress, "InNewValue");
		SetValue_InNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValue_FunctionAddress, "InNewValue", Classes.FObjectProperty);
		SetValue_IsValid = SetValue_FunctionAddress != IntPtr.Zero && SetValue_InNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:SetValue", SetValue_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:SetTime", SetTime_IsValid);
		GetValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValue");
		GetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValue_ReturnValue_PropertyAddress, GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValue_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetValue_IsValid = GetValue_FunctionAddress != IntPtr.Zero && GetValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:GetValue", GetValue_IsValid);
		GetTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTime");
		GetTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTime_TimeUnit_PropertyAddress, GetTime_FunctionAddress, "TimeUnit");
		GetTime_TimeUnit_Offset = NativeReflectionCached.GetPropertyOffset(GetTime_FunctionAddress, "TimeUnit");
		GetTime_TimeUnit_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTime_FunctionAddress, "TimeUnit", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTime_ReturnValue_PropertyAddress, GetTime_FunctionAddress, "ReturnValue");
		GetTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTime_FunctionAddress, "ReturnValue");
		GetTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTime_IsValid = GetTime_FunctionAddress != IntPtr.Zero && GetTime_TimeUnit_IsValid && GetTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingObjectPathKey:GetTime", GetTime_IsValid);
	}
}
