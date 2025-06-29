using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.MediaComponent", "MediaAssets", UnrealModuleType.Engine)]
public class UMediaComponent : UActorComponent
{
	private static bool GetMediaTexture_IsValid;

	private static IntPtr GetMediaTexture_FunctionAddress;

	private static int GetMediaTexture_ParamsSize;

	private static bool GetMediaTexture_ReturnValue_IsValid;

	private static FFieldAddress GetMediaTexture_ReturnValue_PropertyAddress;

	private static int GetMediaTexture_ReturnValue_Offset;

	private static bool GetMediaPlayer_IsValid;

	private static IntPtr GetMediaPlayer_FunctionAddress;

	private static int GetMediaPlayer_ParamsSize;

	private static bool GetMediaPlayer_ReturnValue_IsValid;

	private static FFieldAddress GetMediaPlayer_ReturnValue_PropertyAddress;

	private static int GetMediaPlayer_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaComponent:GetMediaTexture")]
	public unsafe UMediaTexture GetMediaTexture()
	{
		CheckDestroyed();
		if (!GetMediaTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaComponent:GetMediaTexture");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMediaTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMediaTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMediaTexture_FunctionAddress, intPtr, GetMediaTexture_ParamsSize);
		return UObjectMarshaler<UMediaTexture>.FromNative(IntPtr.Add(intPtr, GetMediaTexture_ReturnValue_Offset), 0, GetMediaTexture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaComponent:GetMediaPlayer")]
	public unsafe UMediaPlayer GetMediaPlayer()
	{
		CheckDestroyed();
		if (!GetMediaPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaComponent:GetMediaPlayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMediaPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMediaPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMediaPlayer_FunctionAddress, intPtr, GetMediaPlayer_ParamsSize);
		return UObjectMarshaler<UMediaPlayer>.FromNative(IntPtr.Add(intPtr, GetMediaPlayer_ReturnValue_Offset), 0, GetMediaPlayer_ReturnValue_PropertyAddress.Address);
	}

	static UMediaComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMediaComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMediaComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MediaAssets.MediaComponent");
		GetMediaTexture_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMediaTexture");
		GetMediaTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMediaTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMediaTexture_ReturnValue_PropertyAddress, GetMediaTexture_FunctionAddress, "ReturnValue");
		GetMediaTexture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaTexture_FunctionAddress, "ReturnValue");
		GetMediaTexture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaTexture_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMediaTexture_IsValid = GetMediaTexture_FunctionAddress != IntPtr.Zero && GetMediaTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaComponent:GetMediaTexture", GetMediaTexture_IsValid);
		GetMediaPlayer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMediaPlayer");
		GetMediaPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMediaPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMediaPlayer_ReturnValue_PropertyAddress, GetMediaPlayer_FunctionAddress, "ReturnValue");
		GetMediaPlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaPlayer_FunctionAddress, "ReturnValue");
		GetMediaPlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaPlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMediaPlayer_IsValid = GetMediaPlayer_FunctionAddress != IntPtr.Zero && GetMediaPlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaComponent:GetMediaPlayer", GetMediaPlayer_IsValid);
	}
}
