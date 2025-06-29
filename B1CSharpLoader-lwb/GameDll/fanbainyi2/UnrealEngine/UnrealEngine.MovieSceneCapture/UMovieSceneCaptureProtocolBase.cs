using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[Abstract]
[UClass(Flags = (ClassFlags)810550433uL, Config = "EditorPerProjectUserSettings")]
[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase", "MovieSceneCapture", UnrealModuleType.Engine)]
public class UMovieSceneCaptureProtocolBase : UObject
{
	private static bool IsCapturing_IsValid;

	private static IntPtr IsCapturing_FunctionAddress;

	private static int IsCapturing_ParamsSize;

	private static bool IsCapturing_ReturnValue_IsValid;

	private static FFieldAddress IsCapturing_ReturnValue_PropertyAddress;

	private static int IsCapturing_ReturnValue_Offset;

	private static bool GetState_IsValid;

	private static IntPtr GetState_FunctionAddress;

	private static int GetState_ParamsSize;

	private static bool GetState_ReturnValue_IsValid;

	private static FFieldAddress GetState_ReturnValue_PropertyAddress;

	private static int GetState_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase:IsCapturing")]
	public unsafe bool IsCapturing()
	{
		CheckDestroyed();
		if (!IsCapturing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase:IsCapturing");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCapturing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCapturing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCapturing_FunctionAddress, intPtr, IsCapturing_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCapturing_ReturnValue_Offset), 0, IsCapturing_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase:GetState")]
	public unsafe EMovieSceneCaptureProtocolState GetState()
	{
		CheckDestroyed();
		if (!GetState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase:GetState");
			return EMovieSceneCaptureProtocolState.Idle;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetState_FunctionAddress, intPtr, GetState_ParamsSize);
		return EnumMarshaler<EMovieSceneCaptureProtocolState>.FromNative(IntPtr.Add(intPtr, GetState_ReturnValue_Offset), 0, GetState_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneCaptureProtocolBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneCaptureProtocolBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneCaptureProtocolBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase");
		IsCapturing_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsCapturing");
		IsCapturing_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCapturing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCapturing_ReturnValue_PropertyAddress, IsCapturing_FunctionAddress, "ReturnValue");
		IsCapturing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCapturing_FunctionAddress, "ReturnValue");
		IsCapturing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCapturing_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCapturing_IsValid = IsCapturing_FunctionAddress != IntPtr.Zero && IsCapturing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase:IsCapturing", IsCapturing_IsValid);
		GetState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetState");
		GetState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetState_ReturnValue_PropertyAddress, GetState_FunctionAddress, "ReturnValue");
		GetState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetState_FunctionAddress, "ReturnValue");
		GetState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetState_IsValid = GetState_FunctionAddress != IntPtr.Zero && GetState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase:GetState", GetState_IsValid);
	}
}
