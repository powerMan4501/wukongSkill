using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UClass(Flags = (ClassFlags)818413733uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneSequence", "MovieScene", UnrealModuleType.Engine)]
public class UMovieSceneSequence : UMovieSceneSignedObject
{
	private static bool GetEarliestTimecodeSource_IsValid;

	private static IntPtr GetEarliestTimecodeSource_FunctionAddress;

	private static int GetEarliestTimecodeSource_ParamsSize;

	private static bool GetEarliestTimecodeSource_ReturnValue_IsValid;

	private static FFieldAddress GetEarliestTimecodeSource_ReturnValue_PropertyAddress;

	private static int GetEarliestTimecodeSource_ReturnValue_Offset;

	private static bool FindBindingsByTag_IsValid;

	private static IntPtr FindBindingsByTag_FunctionAddress;

	private static int FindBindingsByTag_ParamsSize;

	private static bool FindBindingsByTag_InBindingName_IsValid;

	private static FFieldAddress FindBindingsByTag_InBindingName_PropertyAddress;

	private static int FindBindingsByTag_InBindingName_Offset;

	private static bool FindBindingsByTag_ReturnValue_IsValid;

	private static FFieldAddress FindBindingsByTag_ReturnValue_PropertyAddress;

	private static int FindBindingsByTag_ReturnValue_Offset;

	private static bool FindBindingByTag_IsValid;

	private static IntPtr FindBindingByTag_FunctionAddress;

	private static int FindBindingByTag_ParamsSize;

	private static bool FindBindingByTag_InBindingName_IsValid;

	private static FFieldAddress FindBindingByTag_InBindingName_PropertyAddress;

	private static int FindBindingByTag_InBindingName_Offset;

	private static bool FindBindingByTag_ReturnValue_IsValid;

	private static FFieldAddress FindBindingByTag_ReturnValue_PropertyAddress;

	private static int FindBindingByTag_ReturnValue_Offset;

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequence:GetEarliestTimecodeSource")]
	public unsafe FMovieSceneTimecodeSource GetEarliestTimecodeSource()
	{
		CheckDestroyed();
		if (!GetEarliestTimecodeSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequence:GetEarliestTimecodeSource");
			return default(FMovieSceneTimecodeSource);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEarliestTimecodeSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEarliestTimecodeSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEarliestTimecodeSource_FunctionAddress, intPtr, GetEarliestTimecodeSource_ParamsSize);
		return FMovieSceneTimecodeSource.FromNative(IntPtr.Add(intPtr, GetEarliestTimecodeSource_ReturnValue_Offset), 0, GetEarliestTimecodeSource_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequence:FindBindingsByTag")]
	public unsafe List<FMovieSceneObjectBindingID> FindBindingsByTag(FName InBindingName)
	{
		CheckDestroyed();
		if (!FindBindingsByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequence:FindBindingsByTag");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindBindingsByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindBindingsByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindBindingsByTag_InBindingName_Offset), 0, FindBindingsByTag_InBindingName_PropertyAddress.Address, InBindingName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindBindingsByTag_FunctionAddress, intPtr, FindBindingsByTag_ParamsSize);
		List<FMovieSceneObjectBindingID> result = new TArrayCopyMarshaler<FMovieSceneObjectBindingID>(1, FindBindingsByTag_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FMovieSceneObjectBindingID, FMovieSceneObjectBindingID>.FromNative, CachedMarshalingDelegates<FMovieSceneObjectBindingID, FMovieSceneObjectBindingID>.ToNative).FromNative(IntPtr.Add(intPtr, FindBindingsByTag_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindBindingsByTag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequence:FindBindingByTag")]
	public unsafe FMovieSceneObjectBindingID FindBindingByTag(FName InBindingName)
	{
		CheckDestroyed();
		if (!FindBindingByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequence:FindBindingByTag");
			return default(FMovieSceneObjectBindingID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindBindingByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindBindingByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindBindingByTag_InBindingName_Offset), 0, FindBindingByTag_InBindingName_PropertyAddress.Address, InBindingName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindBindingByTag_FunctionAddress, intPtr, FindBindingByTag_ParamsSize);
		return FMovieSceneObjectBindingID.FromNative(IntPtr.Add(intPtr, FindBindingByTag_ReturnValue_Offset), 0, FindBindingByTag_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneSequence()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneSequence));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieScene.MovieSceneSequence");
		GetEarliestTimecodeSource_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEarliestTimecodeSource");
		GetEarliestTimecodeSource_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEarliestTimecodeSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEarliestTimecodeSource_ReturnValue_PropertyAddress, GetEarliestTimecodeSource_FunctionAddress, "ReturnValue");
		GetEarliestTimecodeSource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEarliestTimecodeSource_FunctionAddress, "ReturnValue");
		GetEarliestTimecodeSource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEarliestTimecodeSource_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEarliestTimecodeSource_IsValid = GetEarliestTimecodeSource_FunctionAddress != IntPtr.Zero && GetEarliestTimecodeSource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequence:GetEarliestTimecodeSource", GetEarliestTimecodeSource_IsValid);
		FindBindingsByTag_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindBindingsByTag");
		FindBindingsByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(FindBindingsByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindBindingsByTag_InBindingName_PropertyAddress, FindBindingsByTag_FunctionAddress, "InBindingName");
		FindBindingsByTag_InBindingName_Offset = NativeReflectionCached.GetPropertyOffset(FindBindingsByTag_FunctionAddress, "InBindingName");
		FindBindingsByTag_InBindingName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBindingsByTag_FunctionAddress, "InBindingName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindBindingsByTag_ReturnValue_PropertyAddress, FindBindingsByTag_FunctionAddress, "ReturnValue");
		FindBindingsByTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindBindingsByTag_FunctionAddress, "ReturnValue");
		FindBindingsByTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBindingsByTag_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindBindingsByTag_IsValid = FindBindingsByTag_FunctionAddress != IntPtr.Zero && FindBindingsByTag_InBindingName_IsValid && FindBindingsByTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequence:FindBindingsByTag", FindBindingsByTag_IsValid);
		FindBindingByTag_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindBindingByTag");
		FindBindingByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(FindBindingByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindBindingByTag_InBindingName_PropertyAddress, FindBindingByTag_FunctionAddress, "InBindingName");
		FindBindingByTag_InBindingName_Offset = NativeReflectionCached.GetPropertyOffset(FindBindingByTag_FunctionAddress, "InBindingName");
		FindBindingByTag_InBindingName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBindingByTag_FunctionAddress, "InBindingName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindBindingByTag_ReturnValue_PropertyAddress, FindBindingByTag_FunctionAddress, "ReturnValue");
		FindBindingByTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindBindingByTag_FunctionAddress, "ReturnValue");
		FindBindingByTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBindingByTag_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindBindingByTag_IsValid = FindBindingByTag_FunctionAddress != IntPtr.Zero && FindBindingByTag_InBindingName_IsValid && FindBindingByTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequence:FindBindingByTag", FindBindingByTag_IsValid);
	}
}
