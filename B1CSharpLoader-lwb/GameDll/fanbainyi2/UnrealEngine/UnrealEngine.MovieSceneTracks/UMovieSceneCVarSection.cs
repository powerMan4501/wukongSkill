using System;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)812122272uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneCVarSection", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieSceneCVarSection : UMovieSceneSection, IMovieSceneEntityProvider, IInterface
{
	private static bool SetFromString_IsValid;

	private static IntPtr SetFromString_FunctionAddress;

	private static int SetFromString_ParamsSize;

	private static bool SetFromString_InString_IsValid;

	private static FFieldAddress SetFromString_InString_PropertyAddress;

	private static int SetFromString_InString_Offset;

	private static bool GetString_IsValid;

	private static IntPtr GetString_FunctionAddress;

	private static int GetString_ParamsSize;

	private static bool GetString_ReturnValue_IsValid;

	private static FFieldAddress GetString_ReturnValue_PropertyAddress;

	private static int GetString_ReturnValue_Offset;

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneCVarSection:SetFromString")]
	public unsafe void SetFromString(string InString)
	{
		CheckDestroyed();
		if (!SetFromString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneCVarSection:SetFromString");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFromString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFromString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetFromString_InString_Offset), 0, SetFromString_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFromString_FunctionAddress, intPtr, SetFromString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetFromString_InString_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneCVarSection:GetString")]
	public unsafe string GetString()
	{
		CheckDestroyed();
		if (!GetString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneCVarSection:GetString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetString_FunctionAddress, intPtr, GetString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetString_ReturnValue_Offset), 0, GetString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UMovieSceneCVarSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneCVarSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneCVarSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieSceneCVarSection");
		SetFromString_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetFromString");
		SetFromString_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFromString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFromString_InString_PropertyAddress, SetFromString_FunctionAddress, "InString");
		SetFromString_InString_Offset = NativeReflectionCached.GetPropertyOffset(SetFromString_FunctionAddress, "InString");
		SetFromString_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFromString_FunctionAddress, "InString", Classes.FStrProperty);
		SetFromString_IsValid = SetFromString_FunctionAddress != IntPtr.Zero && SetFromString_InString_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneCVarSection:SetFromString", SetFromString_IsValid);
		GetString_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetString");
		GetString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetString_ReturnValue_PropertyAddress, GetString_FunctionAddress, "ReturnValue");
		GetString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "ReturnValue");
		GetString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetString_IsValid = GetString_FunctionAddress != IntPtr.Zero && GetString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneCVarSection:GetString", GetString_IsValid);
	}
}
