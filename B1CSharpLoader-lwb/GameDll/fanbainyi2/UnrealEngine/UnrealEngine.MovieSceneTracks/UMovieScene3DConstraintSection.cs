using System;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)812122272uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieScene3DConstraintSection", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieScene3DConstraintSection : UMovieSceneSection
{
	private static bool SetConstraintBindingID_IsValid;

	private static IntPtr SetConstraintBindingID_FunctionAddress;

	private static int SetConstraintBindingID_ParamsSize;

	private static bool SetConstraintBindingID_InConstraintBindingID_IsValid;

	private static FFieldAddress SetConstraintBindingID_InConstraintBindingID_PropertyAddress;

	private static int SetConstraintBindingID_InConstraintBindingID_Offset;

	private static bool GetConstraintBindingID_IsValid;

	private static IntPtr GetConstraintBindingID_FunctionAddress;

	private static int GetConstraintBindingID_ParamsSize;

	private static bool GetConstraintBindingID_ReturnValue_IsValid;

	private static FFieldAddress GetConstraintBindingID_ReturnValue_PropertyAddress;

	private static int GetConstraintBindingID_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DConstraintSection:SetConstraintBindingID")]
	public unsafe void SetConstraintBindingID(FMovieSceneObjectBindingID InConstraintBindingID)
	{
		CheckDestroyed();
		if (!SetConstraintBindingID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieScene3DConstraintSection:SetConstraintBindingID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConstraintBindingID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConstraintBindingID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetConstraintBindingID_InConstraintBindingID_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, SetConstraintBindingID_InConstraintBindingID_Offset), 0, SetConstraintBindingID_InConstraintBindingID_PropertyAddress.Address, InConstraintBindingID);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConstraintBindingID_FunctionAddress, intPtr, SetConstraintBindingID_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DConstraintSection:GetConstraintBindingID")]
	public unsafe FMovieSceneObjectBindingID GetConstraintBindingID()
	{
		CheckDestroyed();
		if (!GetConstraintBindingID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieScene3DConstraintSection:GetConstraintBindingID");
			return default(FMovieSceneObjectBindingID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConstraintBindingID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConstraintBindingID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConstraintBindingID_FunctionAddress, intPtr, GetConstraintBindingID_ParamsSize);
		return FMovieSceneObjectBindingID.FromNative(IntPtr.Add(intPtr, GetConstraintBindingID_ReturnValue_Offset), 0, GetConstraintBindingID_ReturnValue_PropertyAddress.Address);
	}

	static UMovieScene3DConstraintSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieScene3DConstraintSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieScene3DConstraintSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieScene3DConstraintSection");
		SetConstraintBindingID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetConstraintBindingID");
		SetConstraintBindingID_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConstraintBindingID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConstraintBindingID_InConstraintBindingID_PropertyAddress, SetConstraintBindingID_FunctionAddress, "InConstraintBindingID");
		SetConstraintBindingID_InConstraintBindingID_Offset = NativeReflectionCached.GetPropertyOffset(SetConstraintBindingID_FunctionAddress, "InConstraintBindingID");
		SetConstraintBindingID_InConstraintBindingID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstraintBindingID_FunctionAddress, "InConstraintBindingID", Classes.FStructProperty);
		SetConstraintBindingID_IsValid = SetConstraintBindingID_FunctionAddress != IntPtr.Zero && SetConstraintBindingID_InConstraintBindingID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieScene3DConstraintSection:SetConstraintBindingID", SetConstraintBindingID_IsValid);
		GetConstraintBindingID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetConstraintBindingID");
		GetConstraintBindingID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConstraintBindingID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConstraintBindingID_ReturnValue_PropertyAddress, GetConstraintBindingID_FunctionAddress, "ReturnValue");
		GetConstraintBindingID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConstraintBindingID_FunctionAddress, "ReturnValue");
		GetConstraintBindingID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstraintBindingID_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetConstraintBindingID_IsValid = GetConstraintBindingID_FunctionAddress != IntPtr.Zero && GetConstraintBindingID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieScene3DConstraintSection:GetConstraintBindingID", GetConstraintBindingID_IsValid);
	}
}
