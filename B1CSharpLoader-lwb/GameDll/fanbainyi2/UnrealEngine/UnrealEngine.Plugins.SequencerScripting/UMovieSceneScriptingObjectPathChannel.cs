using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneScriptingObjectPathChannel : UMovieSceneScriptingChannel
{
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:SetDefault")]
	public unsafe void SetDefault(UObject InDefaultValue)
	{
		CheckDestroyed();
		if (!SetDefault_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:SetDefault");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefault_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefault_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetDefault_InDefaultValue_Offset), 0, SetDefault_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefault_FunctionAddress, intPtr, SetDefault_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:RemoveKey")]
	public unsafe void RemoveKey(UMovieSceneScriptingKey Key)
	{
		CheckDestroyed();
		if (!RemoveKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:RemoveKey");
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
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:RemoveDefault")]
	public unsafe void RemoveDefault()
	{
		CheckDestroyed();
		if (!RemoveDefault_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:RemoveDefault");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveDefault_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveDefault_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RemoveDefault_FunctionAddress, argsSize: RemoveDefault_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:HasDefault")]
	public unsafe bool HasDefault()
	{
		CheckDestroyed();
		if (!HasDefault_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:HasDefault");
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

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:GetKeys")]
	public unsafe List<UMovieSceneScriptingKey> GetKeys()
	{
		CheckDestroyed();
		if (!GetKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:GetKeys");
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
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:GetDefault")]
	public unsafe UObject GetDefault()
	{
		CheckDestroyed();
		if (!GetDefault_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:GetDefault");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefault_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefault_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefault_FunctionAddress, intPtr, GetDefault_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetDefault_ReturnValue_Offset), 0, GetDefault_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:AddKey")]
	public unsafe UMovieSceneScriptingObjectPathKey AddKey(FFrameNumber InTime, UObject NewValue, float SubFrame = 0f, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
	{
		CheckDestroyed();
		if (!AddKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:AddKey");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddKey_InTime_Offset), 0, AddKey_InTime_PropertyAddress.Address, InTime);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddKey_NewValue_Offset), 0, AddKey_NewValue_PropertyAddress.Address, NewValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddKey_SubFrame_Offset), 0, AddKey_SubFrame_PropertyAddress.Address, SubFrame);
		EnumMarshaler<ESequenceTimeUnit>.ToNative(IntPtr.Add(intPtr, AddKey_TimeUnit_Offset), 0, AddKey_TimeUnit_PropertyAddress.Address, TimeUnit);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddKey_FunctionAddress, intPtr, AddKey_ParamsSize);
		return UObjectMarshaler<UMovieSceneScriptingObjectPathKey>.FromNative(IntPtr.Add(intPtr, AddKey_ReturnValue_Offset), 0, AddKey_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneScriptingObjectPathChannel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneScriptingObjectPathChannel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneScriptingObjectPathChannel));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel");
		SetDefault_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDefault");
		SetDefault_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefault_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefault_InDefaultValue_PropertyAddress, SetDefault_FunctionAddress, "InDefaultValue");
		SetDefault_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDefault_FunctionAddress, "InDefaultValue");
		SetDefault_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefault_FunctionAddress, "InDefaultValue", Classes.FObjectProperty);
		SetDefault_IsValid = SetDefault_FunctionAddress != IntPtr.Zero && SetDefault_InDefaultValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:SetDefault", SetDefault_IsValid);
		RemoveKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveKey");
		RemoveKey_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveKey_Key_PropertyAddress, RemoveKey_FunctionAddress, "Key");
		RemoveKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(RemoveKey_FunctionAddress, "Key");
		RemoveKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveKey_FunctionAddress, "Key", Classes.FObjectProperty);
		RemoveKey_IsValid = RemoveKey_FunctionAddress != IntPtr.Zero && RemoveKey_Key_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:RemoveKey", RemoveKey_IsValid);
		RemoveDefault_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveDefault");
		RemoveDefault_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveDefault_FunctionAddress);
		RemoveDefault_IsValid = RemoveDefault_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:RemoveDefault", RemoveDefault_IsValid);
		HasDefault_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasDefault");
		HasDefault_ParamsSize = NativeReflection.GetFunctionParamsSize(HasDefault_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasDefault_ReturnValue_PropertyAddress, HasDefault_FunctionAddress, "ReturnValue");
		HasDefault_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasDefault_FunctionAddress, "ReturnValue");
		HasDefault_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasDefault_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasDefault_IsValid = HasDefault_FunctionAddress != IntPtr.Zero && HasDefault_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:HasDefault", HasDefault_IsValid);
		GetKeys_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetKeys");
		GetKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeys_ReturnValue_PropertyAddress, GetKeys_FunctionAddress, "ReturnValue");
		GetKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeys_FunctionAddress, "ReturnValue");
		GetKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetKeys_IsValid = GetKeys_FunctionAddress != IntPtr.Zero && GetKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:GetKeys", GetKeys_IsValid);
		GetDefault_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDefault");
		GetDefault_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefault_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefault_ReturnValue_PropertyAddress, GetDefault_FunctionAddress, "ReturnValue");
		GetDefault_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefault_FunctionAddress, "ReturnValue");
		GetDefault_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefault_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDefault_IsValid = GetDefault_FunctionAddress != IntPtr.Zero && GetDefault_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:GetDefault", GetDefault_IsValid);
		AddKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddKey");
		AddKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddKey_InTime_PropertyAddress, AddKey_FunctionAddress, "InTime");
		AddKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "InTime");
		AddKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKey_NewValue_PropertyAddress, AddKey_FunctionAddress, "NewValue");
		AddKey_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(AddKey_FunctionAddress, "NewValue");
		AddKey_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKey_FunctionAddress, "NewValue", Classes.FObjectProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneScriptingObjectPathChannel:AddKey", AddKey_IsValid);
	}
}
