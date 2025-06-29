using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieSceneTracks;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingEventChannel", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneScriptingEventChannel : UMovieSceneScriptingChannel
{
	private static bool RemoveKey_IsValid;

	private static IntPtr RemoveKey_FunctionAddress;

	private static int RemoveKey_ParamsSize;

	private static bool RemoveKey_Key_IsValid;

	private static FFieldAddress RemoveKey_Key_PropertyAddress;

	private static int RemoveKey_Key_Offset;

	private static bool GetKeys_IsValid;

	private static IntPtr GetKeys_FunctionAddress;

	private static int GetKeys_ParamsSize;

	private static bool GetKeys_ReturnValue_IsValid;

	private static FFieldAddress GetKeys_ReturnValue_PropertyAddress;

	private static int GetKeys_ReturnValue_Offset;

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

	private static bool AddKey_ReturnValue_IsValid;

	private static FFieldAddress AddKey_ReturnValue_PropertyAddress;

	private static int AddKey_ReturnValue_Offset;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingEventChannel:RemoveKey")]
	public unsafe void RemoveKey(UMovieSceneScriptingKey Key)
	{
		CheckDestroyed();
		if (!RemoveKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingEventChannel:RemoveKey");
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

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingEventChannel:GetKeys")]
	public unsafe List<UMovieSceneScriptingKey> GetKeys()
	{
		CheckDestroyed();
		if (!GetKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingEventChannel:GetKeys");
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

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingEventChannel:AddKey")]
	public unsafe UMovieSceneScriptingEventKey AddKey(FFrameNumber InTime, FMovieSceneEvent NewValue, float SubFrame = 0f, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
	{
		CheckDestroyed();
		if (!AddKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingEventChannel:AddKey");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddKey_InTime_Offset), 0, AddKey_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InitializeValue_InContainer(AddKey_NewValue_PropertyAddress.Address, intPtr);
		FMovieSceneEvent.ToNative(IntPtr.Add(intPtr, AddKey_NewValue_Offset), 0, AddKey_NewValue_PropertyAddress.Address, NewValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddKey_SubFrame_Offset), 0, AddKey_SubFrame_PropertyAddress.Address, SubFrame);
		EnumMarshaler<ESequenceTimeUnit>.ToNative(IntPtr.Add(intPtr, AddKey_TimeUnit_Offset), 0, AddKey_TimeUnit_PropertyAddress.Address, TimeUnit);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddKey_FunctionAddress, intPtr, AddKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddKey_NewValue_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UMovieSceneScriptingEventKey>.FromNative(IntPtr.Add(intPtr, AddKey_ReturnValue_Offset), 0, AddKey_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneScriptingEventChannel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneScriptingEventChannel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneScriptingEventChannel));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneScriptingEventChannel");
		RemoveKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveKey");
		RemoveKey_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveKey_Key_PropertyAddress, RemoveKey_FunctionAddress, "Key");
		RemoveKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(RemoveKey_FunctionAddress, "Key");
		RemoveKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveKey_FunctionAddress, "Key", Classes.FObjectProperty);
		RemoveKey_IsValid = RemoveKey_FunctionAddress != IntPtr.Zero && RemoveKey_Key_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingEventChannel:RemoveKey", RemoveKey_IsValid);
		GetKeys_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetKeys");
		GetKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeys_ReturnValue_PropertyAddress, GetKeys_FunctionAddress, "ReturnValue");
		GetKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeys_FunctionAddress, "ReturnValue");
		GetKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetKeys_IsValid = GetKeys_FunctionAddress != IntPtr.Zero && GetKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingEventChannel:GetKeys", GetKeys_IsValid);
		AddKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddKey");
		AddKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddKey_InTime_PropertyAddress, AddKey_FunctionAddress, "InTime");
		AddKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "InTime");
		AddKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKey_NewValue_PropertyAddress, AddKey_FunctionAddress, "NewValue");
		AddKey_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "NewValue");
		AddKey_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "NewValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKey_SubFrame_PropertyAddress, AddKey_FunctionAddress, "SubFrame");
		AddKey_SubFrame_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "SubFrame");
		AddKey_SubFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "SubFrame", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKey_TimeUnit_PropertyAddress, AddKey_FunctionAddress, "TimeUnit");
		AddKey_TimeUnit_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "TimeUnit");
		AddKey_TimeUnit_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "TimeUnit", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKey_ReturnValue_PropertyAddress, AddKey_FunctionAddress, "ReturnValue");
		AddKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "ReturnValue");
		AddKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddKey_IsValid = AddKey_FunctionAddress != IntPtr.Zero && AddKey_InTime_IsValid && AddKey_NewValue_IsValid && AddKey_SubFrame_IsValid && AddKey_TimeUnit_IsValid && AddKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingEventChannel:AddKey", AddKey_IsValid);
	}
}
