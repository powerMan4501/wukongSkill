using System;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UClass(Flags = (ClassFlags)812122272uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Calliope.CalliopeMovieSceneCameraCutSection", "Calliope", UnrealModuleType.GamePlugin)]
public class UCalliopeMovieSceneCameraCutSection : UMovieSceneSection, IMovieSceneEntityProvider, IInterface
{
	private static bool SetCameraBindingID_IsValid;

	private static IntPtr SetCameraBindingID_FunctionAddress;

	private static int SetCameraBindingID_ParamsSize;

	private static bool SetCameraBindingID_InCameraBindingID_IsValid;

	private static FFieldAddress SetCameraBindingID_InCameraBindingID_PropertyAddress;

	private static int SetCameraBindingID_InCameraBindingID_Offset;

	private static bool GetCameraBindingID_IsValid;

	private static IntPtr GetCameraBindingID_FunctionAddress;

	private static int GetCameraBindingID_ParamsSize;

	private static bool GetCameraBindingID_ReturnValue_IsValid;

	private static FFieldAddress GetCameraBindingID_ReturnValue_PropertyAddress;

	private static int GetCameraBindingID_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeMovieSceneCameraCutSection:SetCameraBindingID")]
	public unsafe void SetCameraBindingID(FMovieSceneObjectBindingID InCameraBindingID)
	{
		CheckDestroyed();
		if (!SetCameraBindingID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeMovieSceneCameraCutSection:SetCameraBindingID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCameraBindingID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCameraBindingID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCameraBindingID_InCameraBindingID_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, SetCameraBindingID_InCameraBindingID_Offset), 0, SetCameraBindingID_InCameraBindingID_PropertyAddress.Address, InCameraBindingID);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCameraBindingID_FunctionAddress, intPtr, SetCameraBindingID_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.CalliopeMovieSceneCameraCutSection:GetCameraBindingID")]
	public unsafe FMovieSceneObjectBindingID GetCameraBindingID()
	{
		CheckDestroyed();
		if (!GetCameraBindingID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeMovieSceneCameraCutSection:GetCameraBindingID");
			return default(FMovieSceneObjectBindingID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraBindingID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraBindingID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCameraBindingID_FunctionAddress, intPtr, GetCameraBindingID_ParamsSize);
		return FMovieSceneObjectBindingID.FromNative(IntPtr.Add(intPtr, GetCameraBindingID_ReturnValue_Offset), 0, GetCameraBindingID_ReturnValue_PropertyAddress.Address);
	}

	static UCalliopeMovieSceneCameraCutSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCalliopeMovieSceneCameraCutSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCalliopeMovieSceneCameraCutSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Calliope.CalliopeMovieSceneCameraCutSection");
		SetCameraBindingID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCameraBindingID");
		SetCameraBindingID_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCameraBindingID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCameraBindingID_InCameraBindingID_PropertyAddress, SetCameraBindingID_FunctionAddress, "InCameraBindingID");
		SetCameraBindingID_InCameraBindingID_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraBindingID_FunctionAddress, "InCameraBindingID");
		SetCameraBindingID_InCameraBindingID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraBindingID_FunctionAddress, "InCameraBindingID", Classes.FStructProperty);
		SetCameraBindingID_IsValid = SetCameraBindingID_FunctionAddress != IntPtr.Zero && SetCameraBindingID_InCameraBindingID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeMovieSceneCameraCutSection:SetCameraBindingID", SetCameraBindingID_IsValid);
		GetCameraBindingID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCameraBindingID");
		GetCameraBindingID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraBindingID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraBindingID_ReturnValue_PropertyAddress, GetCameraBindingID_FunctionAddress, "ReturnValue");
		GetCameraBindingID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraBindingID_FunctionAddress, "ReturnValue");
		GetCameraBindingID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraBindingID_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCameraBindingID_IsValid = GetCameraBindingID_FunctionAddress != IntPtr.Zero && GetCameraBindingID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeMovieSceneCameraCutSection:GetCameraBindingID", GetCameraBindingID_IsValid);
	}
}
