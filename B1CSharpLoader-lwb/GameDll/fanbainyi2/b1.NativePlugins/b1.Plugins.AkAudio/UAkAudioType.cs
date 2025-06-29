using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[UMetaPath("/Script/AkAudio.AkAudioType", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkAudioType : UObject
{
	private static bool UnloadData_IsValid;

	private static IntPtr UnloadData_FunctionAddress;

	private static int UnloadData_ParamsSize;

	private static bool UnloadData_bAsync_IsValid;

	private static FFieldAddress UnloadData_bAsync_PropertyAddress;

	private static int UnloadData_bAsync_Offset;

	private static bool LoadData_IsValid;

	private static IntPtr LoadData_FunctionAddress;

	private static int LoadData_ParamsSize;

	private static bool GetWwiseShortID_IsValid;

	private static IntPtr GetWwiseShortID_FunctionAddress;

	private static int GetWwiseShortID_ParamsSize;

	private static bool GetWwiseShortID_ReturnValue_IsValid;

	private static FFieldAddress GetWwiseShortID_ReturnValue_PropertyAddress;

	private static int GetWwiseShortID_ReturnValue_Offset;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AkAudio.AkAudioType:UnloadData")]
	public unsafe void UnloadData(bool bAsync = false)
	{
		CheckDestroyed();
		if (!UnloadData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioType:UnloadData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnloadData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnloadData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UnloadData_bAsync_Offset), 0, UnloadData_bAsync_PropertyAddress.Address, bAsync);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnloadData_FunctionAddress, intPtr, UnloadData_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AkAudio.AkAudioType:LoadData")]
	public unsafe void LoadData()
	{
		CheckDestroyed();
		if (!LoadData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioType:LoadData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadData_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: LoadData_FunctionAddress, argsSize: LoadData_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AkAudio.AkAudioType:GetWwiseShortID")]
	public unsafe int GetWwiseShortID()
	{
		CheckDestroyed();
		if (!GetWwiseShortID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioType:GetWwiseShortID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWwiseShortID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWwiseShortID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWwiseShortID_FunctionAddress, intPtr, GetWwiseShortID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetWwiseShortID_ReturnValue_Offset), 0, GetWwiseShortID_ReturnValue_PropertyAddress.Address);
	}

	static UAkAudioType()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkAudioType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkAudioType));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AkAudio.AkAudioType");
		UnloadData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UnloadData");
		UnloadData_ParamsSize = NativeReflection.GetFunctionParamsSize(UnloadData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnloadData_bAsync_PropertyAddress, UnloadData_FunctionAddress, "bAsync");
		UnloadData_bAsync_Offset = NativeReflectionCached.GetPropertyOffset(UnloadData_FunctionAddress, "bAsync");
		UnloadData_bAsync_IsValid = NativeReflectionCached.ValidatePropertyClass(UnloadData_FunctionAddress, "bAsync", Classes.FBoolProperty);
		UnloadData_IsValid = UnloadData_FunctionAddress != IntPtr.Zero && UnloadData_bAsync_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioType:UnloadData", UnloadData_IsValid);
		LoadData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LoadData");
		LoadData_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadData_FunctionAddress);
		LoadData_IsValid = LoadData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioType:LoadData", LoadData_IsValid);
		GetWwiseShortID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWwiseShortID");
		GetWwiseShortID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWwiseShortID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWwiseShortID_ReturnValue_PropertyAddress, GetWwiseShortID_FunctionAddress, "ReturnValue");
		GetWwiseShortID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWwiseShortID_FunctionAddress, "ReturnValue");
		GetWwiseShortID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWwiseShortID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetWwiseShortID_IsValid = GetWwiseShortID_FunctionAddress != IntPtr.Zero && GetWwiseShortID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioType:GetWwiseShortID", GetWwiseShortID_IsValid);
	}
}
