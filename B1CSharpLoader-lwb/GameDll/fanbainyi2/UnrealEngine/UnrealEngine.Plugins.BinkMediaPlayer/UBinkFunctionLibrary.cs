using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BinkMediaPlayer;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/BinkMediaPlayer.BinkFunctionLibrary", "BinkMediaPlayer", UnrealModuleType.EnginePlugin)]
public class UBinkFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool BinkLoadingMovie_GetTime_IsValid;

	private static IntPtr BinkLoadingMovie_GetTime_FunctionAddress;

	private static int BinkLoadingMovie_GetTime_ParamsSize;

	private static bool BinkLoadingMovie_GetTime_ReturnValue_IsValid;

	private static FFieldAddress BinkLoadingMovie_GetTime_ReturnValue_PropertyAddress;

	private static int BinkLoadingMovie_GetTime_ReturnValue_Offset;

	private static bool BinkLoadingMovie_GetDuration_IsValid;

	private static IntPtr BinkLoadingMovie_GetDuration_FunctionAddress;

	private static int BinkLoadingMovie_GetDuration_ParamsSize;

	private static bool BinkLoadingMovie_GetDuration_ReturnValue_IsValid;

	private static FFieldAddress BinkLoadingMovie_GetDuration_ReturnValue_PropertyAddress;

	private static int BinkLoadingMovie_GetDuration_ReturnValue_Offset;

	private static bool Bink_DrawOverlays_IsValid;

	private static IntPtr Bink_DrawOverlays_FunctionAddress;

	private static int Bink_DrawOverlays_ParamsSize;

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkFunctionLibrary:BinkLoadingMovie_GetTime")]
	public unsafe static FTimespan BinkLoadingMovie_GetTime()
	{
		if (!BinkLoadingMovie_GetTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkFunctionLibrary:BinkLoadingMovie_GetTime");
			return default(FTimespan);
		}
		byte* ptr = stackalloc byte[(int)(uint)(BinkLoadingMovie_GetTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BinkLoadingMovie_GetTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BinkLoadingMovie_GetTime_FunctionAddress, intPtr, BinkLoadingMovie_GetTime_ParamsSize);
		return FTimespan.FromNative(IntPtr.Add(intPtr, BinkLoadingMovie_GetTime_ReturnValue_Offset), 0, BinkLoadingMovie_GetTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkFunctionLibrary:BinkLoadingMovie_GetDuration")]
	public unsafe static FTimespan BinkLoadingMovie_GetDuration()
	{
		if (!BinkLoadingMovie_GetDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkFunctionLibrary:BinkLoadingMovie_GetDuration");
			return default(FTimespan);
		}
		byte* ptr = stackalloc byte[(int)(uint)(BinkLoadingMovie_GetDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BinkLoadingMovie_GetDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BinkLoadingMovie_GetDuration_FunctionAddress, intPtr, BinkLoadingMovie_GetDuration_ParamsSize);
		return FTimespan.FromNative(IntPtr.Add(intPtr, BinkLoadingMovie_GetDuration_ReturnValue_Offset), 0, BinkLoadingMovie_GetDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkFunctionLibrary:Bink_DrawOverlays")]
	public unsafe static void Bink_DrawOverlays()
	{
		if (!Bink_DrawOverlays_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkFunctionLibrary:Bink_DrawOverlays");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Bink_DrawOverlays_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Bink_DrawOverlays_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: Bink_DrawOverlays_FunctionAddress, argsSize: Bink_DrawOverlays_ParamsSize);
	}

	static UBinkFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBinkFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBinkFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/BinkMediaPlayer.BinkFunctionLibrary");
		BinkLoadingMovie_GetTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BinkLoadingMovie_GetTime");
		BinkLoadingMovie_GetTime_ParamsSize = NativeReflection.GetFunctionParamsSize(BinkLoadingMovie_GetTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BinkLoadingMovie_GetTime_ReturnValue_PropertyAddress, BinkLoadingMovie_GetTime_FunctionAddress, "ReturnValue");
		BinkLoadingMovie_GetTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BinkLoadingMovie_GetTime_FunctionAddress, "ReturnValue");
		BinkLoadingMovie_GetTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BinkLoadingMovie_GetTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BinkLoadingMovie_GetTime_IsValid = BinkLoadingMovie_GetTime_FunctionAddress != IntPtr.Zero && BinkLoadingMovie_GetTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkFunctionLibrary:BinkLoadingMovie_GetTime", BinkLoadingMovie_GetTime_IsValid);
		BinkLoadingMovie_GetDuration_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BinkLoadingMovie_GetDuration");
		BinkLoadingMovie_GetDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(BinkLoadingMovie_GetDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BinkLoadingMovie_GetDuration_ReturnValue_PropertyAddress, BinkLoadingMovie_GetDuration_FunctionAddress, "ReturnValue");
		BinkLoadingMovie_GetDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BinkLoadingMovie_GetDuration_FunctionAddress, "ReturnValue");
		BinkLoadingMovie_GetDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BinkLoadingMovie_GetDuration_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BinkLoadingMovie_GetDuration_IsValid = BinkLoadingMovie_GetDuration_FunctionAddress != IntPtr.Zero && BinkLoadingMovie_GetDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkFunctionLibrary:BinkLoadingMovie_GetDuration", BinkLoadingMovie_GetDuration_IsValid);
		Bink_DrawOverlays_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Bink_DrawOverlays");
		Bink_DrawOverlays_ParamsSize = NativeReflection.GetFunctionParamsSize(Bink_DrawOverlays_FunctionAddress);
		Bink_DrawOverlays_IsValid = Bink_DrawOverlays_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkFunctionLibrary:Bink_DrawOverlays", Bink_DrawOverlays_IsValid);
	}
}
