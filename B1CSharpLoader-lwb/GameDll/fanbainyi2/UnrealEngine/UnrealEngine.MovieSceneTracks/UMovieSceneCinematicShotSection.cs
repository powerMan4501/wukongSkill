using System;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)812646564uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneCinematicShotSection", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieSceneCinematicShotSection : UMovieSceneSubSection
{
	private static bool SetShotDisplayName_IsValid;

	private static IntPtr SetShotDisplayName_FunctionAddress;

	private static int SetShotDisplayName_ParamsSize;

	private static bool SetShotDisplayName_InShotDisplayName_IsValid;

	private static FFieldAddress SetShotDisplayName_InShotDisplayName_PropertyAddress;

	private static int SetShotDisplayName_InShotDisplayName_Offset;

	private static bool GetShotDisplayName_IsValid;

	private static IntPtr GetShotDisplayName_FunctionAddress;

	private static int GetShotDisplayName_ParamsSize;

	private static bool GetShotDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetShotDisplayName_ReturnValue_PropertyAddress;

	private static int GetShotDisplayName_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneCinematicShotSection:SetShotDisplayName")]
	public unsafe void SetShotDisplayName(string InShotDisplayName)
	{
		CheckDestroyed();
		if (!SetShotDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneCinematicShotSection:SetShotDisplayName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShotDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShotDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetShotDisplayName_InShotDisplayName_Offset), 0, SetShotDisplayName_InShotDisplayName_PropertyAddress.Address, InShotDisplayName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShotDisplayName_FunctionAddress, intPtr, SetShotDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetShotDisplayName_InShotDisplayName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneCinematicShotSection:GetShotDisplayName")]
	public unsafe string GetShotDisplayName()
	{
		CheckDestroyed();
		if (!GetShotDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneCinematicShotSection:GetShotDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShotDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShotDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShotDisplayName_FunctionAddress, intPtr, GetShotDisplayName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetShotDisplayName_ReturnValue_Offset), 0, GetShotDisplayName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetShotDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UMovieSceneCinematicShotSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneCinematicShotSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneCinematicShotSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieSceneCinematicShotSection");
		SetShotDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetShotDisplayName");
		SetShotDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShotDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShotDisplayName_InShotDisplayName_PropertyAddress, SetShotDisplayName_FunctionAddress, "InShotDisplayName");
		SetShotDisplayName_InShotDisplayName_Offset = NativeReflectionCached.GetPropertyOffset(SetShotDisplayName_FunctionAddress, "InShotDisplayName");
		SetShotDisplayName_InShotDisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShotDisplayName_FunctionAddress, "InShotDisplayName", Classes.FStrProperty);
		SetShotDisplayName_IsValid = SetShotDisplayName_FunctionAddress != IntPtr.Zero && SetShotDisplayName_InShotDisplayName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneCinematicShotSection:SetShotDisplayName", SetShotDisplayName_IsValid);
		GetShotDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetShotDisplayName");
		GetShotDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShotDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShotDisplayName_ReturnValue_PropertyAddress, GetShotDisplayName_FunctionAddress, "ReturnValue");
		GetShotDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShotDisplayName_FunctionAddress, "ReturnValue");
		GetShotDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShotDisplayName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetShotDisplayName_IsValid = GetShotDisplayName_FunctionAddress != IntPtr.Zero && GetShotDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneCinematicShotSection:GetShotDisplayName", GetShotDisplayName_IsValid);
	}
}
