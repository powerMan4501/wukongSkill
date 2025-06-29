using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AndroidFileServer;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/AndroidFileServer.AndroidFileServerBPLibrary", "AndroidFileServer", UnrealModuleType.EnginePlugin)]
public class UAndroidFileServerBPLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool StopFileServer_IsValid;

	private static IntPtr StopFileServer_FunctionAddress;

	private static int StopFileServer_ParamsSize;

	private static bool StopFileServer_bUSB_IsValid;

	private static FFieldAddress StopFileServer_bUSB_PropertyAddress;

	private static int StopFileServer_bUSB_Offset;

	private static bool StopFileServer_bNetwork_IsValid;

	private static FFieldAddress StopFileServer_bNetwork_PropertyAddress;

	private static int StopFileServer_bNetwork_Offset;

	private static bool StopFileServer_ReturnValue_IsValid;

	private static FFieldAddress StopFileServer_ReturnValue_PropertyAddress;

	private static int StopFileServer_ReturnValue_Offset;

	private static bool StartFileServer_IsValid;

	private static IntPtr StartFileServer_FunctionAddress;

	private static int StartFileServer_ParamsSize;

	private static bool StartFileServer_bUSB_IsValid;

	private static FFieldAddress StartFileServer_bUSB_PropertyAddress;

	private static int StartFileServer_bUSB_Offset;

	private static bool StartFileServer_bNetwork_IsValid;

	private static FFieldAddress StartFileServer_bNetwork_PropertyAddress;

	private static int StartFileServer_bNetwork_Offset;

	private static bool StartFileServer_Port_IsValid;

	private static FFieldAddress StartFileServer_Port_PropertyAddress;

	private static int StartFileServer_Port_Offset;

	private static bool StartFileServer_ReturnValue_IsValid;

	private static FFieldAddress StartFileServer_ReturnValue_PropertyAddress;

	private static int StartFileServer_ReturnValue_Offset;

	private static bool IsFileServerRunning_IsValid;

	private static IntPtr IsFileServerRunning_FunctionAddress;

	private static int IsFileServerRunning_ParamsSize;

	private static bool IsFileServerRunning_ReturnValue_IsValid;

	private static FFieldAddress IsFileServerRunning_ReturnValue_PropertyAddress;

	private static int IsFileServerRunning_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AndroidFileServer.AndroidFileServerBPLibrary:StopFileServer")]
	public unsafe static bool StopFileServer(bool bUSB = true, bool bNetwork = true)
	{
		if (!StopFileServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AndroidFileServer.AndroidFileServerBPLibrary:StopFileServer");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopFileServer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopFileServer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopFileServer_bUSB_Offset), 0, StopFileServer_bUSB_PropertyAddress.Address, bUSB);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopFileServer_bNetwork_Offset), 0, StopFileServer_bNetwork_PropertyAddress.Address, bNetwork);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StopFileServer_FunctionAddress, intPtr, StopFileServer_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StopFileServer_ReturnValue_Offset), 0, StopFileServer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AndroidFileServer.AndroidFileServerBPLibrary:StartFileServer")]
	public unsafe static bool StartFileServer(bool bUSB = true, bool bNetwork = false, int Port = 57099)
	{
		if (!StartFileServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AndroidFileServer.AndroidFileServerBPLibrary:StartFileServer");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartFileServer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartFileServer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StartFileServer_bUSB_Offset), 0, StartFileServer_bUSB_PropertyAddress.Address, bUSB);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StartFileServer_bNetwork_Offset), 0, StartFileServer_bNetwork_PropertyAddress.Address, bNetwork);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, StartFileServer_Port_Offset), 0, StartFileServer_Port_PropertyAddress.Address, Port);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartFileServer_FunctionAddress, intPtr, StartFileServer_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StartFileServer_ReturnValue_Offset), 0, StartFileServer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AndroidFileServer.AndroidFileServerBPLibrary:IsFileServerRunning")]
	public unsafe static EAFSActiveType IsFileServerRunning()
	{
		if (!IsFileServerRunning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AndroidFileServer.AndroidFileServerBPLibrary:IsFileServerRunning");
			return EAFSActiveType.None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsFileServerRunning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsFileServerRunning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsFileServerRunning_FunctionAddress, intPtr, IsFileServerRunning_ParamsSize);
		return EnumMarshaler<EAFSActiveType>.FromNative(IntPtr.Add(intPtr, IsFileServerRunning_ReturnValue_Offset), 0, IsFileServerRunning_ReturnValue_PropertyAddress.Address);
	}

	static UAndroidFileServerBPLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAndroidFileServerBPLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAndroidFileServerBPLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AndroidFileServer.AndroidFileServerBPLibrary");
		StopFileServer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopFileServer");
		StopFileServer_ParamsSize = NativeReflection.GetFunctionParamsSize(StopFileServer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopFileServer_bUSB_PropertyAddress, StopFileServer_FunctionAddress, "bUSB");
		StopFileServer_bUSB_Offset = NativeReflectionCached.GetPropertyOffset(StopFileServer_FunctionAddress, "bUSB");
		StopFileServer_bUSB_IsValid = NativeReflectionCached.ValidatePropertyClass(StopFileServer_FunctionAddress, "bUSB", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StopFileServer_bNetwork_PropertyAddress, StopFileServer_FunctionAddress, "bNetwork");
		StopFileServer_bNetwork_Offset = NativeReflectionCached.GetPropertyOffset(StopFileServer_FunctionAddress, "bNetwork");
		StopFileServer_bNetwork_IsValid = NativeReflectionCached.ValidatePropertyClass(StopFileServer_FunctionAddress, "bNetwork", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StopFileServer_ReturnValue_PropertyAddress, StopFileServer_FunctionAddress, "ReturnValue");
		StopFileServer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StopFileServer_FunctionAddress, "ReturnValue");
		StopFileServer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StopFileServer_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StopFileServer_IsValid = StopFileServer_FunctionAddress != IntPtr.Zero && StopFileServer_bUSB_IsValid && StopFileServer_bNetwork_IsValid && StopFileServer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AndroidFileServer.AndroidFileServerBPLibrary:StopFileServer", StopFileServer_IsValid);
		StartFileServer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartFileServer");
		StartFileServer_ParamsSize = NativeReflection.GetFunctionParamsSize(StartFileServer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartFileServer_bUSB_PropertyAddress, StartFileServer_FunctionAddress, "bUSB");
		StartFileServer_bUSB_Offset = NativeReflectionCached.GetPropertyOffset(StartFileServer_FunctionAddress, "bUSB");
		StartFileServer_bUSB_IsValid = NativeReflectionCached.ValidatePropertyClass(StartFileServer_FunctionAddress, "bUSB", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StartFileServer_bNetwork_PropertyAddress, StartFileServer_FunctionAddress, "bNetwork");
		StartFileServer_bNetwork_Offset = NativeReflectionCached.GetPropertyOffset(StartFileServer_FunctionAddress, "bNetwork");
		StartFileServer_bNetwork_IsValid = NativeReflectionCached.ValidatePropertyClass(StartFileServer_FunctionAddress, "bNetwork", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StartFileServer_Port_PropertyAddress, StartFileServer_FunctionAddress, "Port");
		StartFileServer_Port_Offset = NativeReflectionCached.GetPropertyOffset(StartFileServer_FunctionAddress, "Port");
		StartFileServer_Port_IsValid = NativeReflectionCached.ValidatePropertyClass(StartFileServer_FunctionAddress, "Port", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref StartFileServer_ReturnValue_PropertyAddress, StartFileServer_FunctionAddress, "ReturnValue");
		StartFileServer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StartFileServer_FunctionAddress, "ReturnValue");
		StartFileServer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StartFileServer_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StartFileServer_IsValid = StartFileServer_FunctionAddress != IntPtr.Zero && StartFileServer_bUSB_IsValid && StartFileServer_bNetwork_IsValid && StartFileServer_Port_IsValid && StartFileServer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AndroidFileServer.AndroidFileServerBPLibrary:StartFileServer", StartFileServer_IsValid);
		IsFileServerRunning_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsFileServerRunning");
		IsFileServerRunning_ParamsSize = NativeReflection.GetFunctionParamsSize(IsFileServerRunning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsFileServerRunning_ReturnValue_PropertyAddress, IsFileServerRunning_FunctionAddress, "ReturnValue");
		IsFileServerRunning_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsFileServerRunning_FunctionAddress, "ReturnValue");
		IsFileServerRunning_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsFileServerRunning_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		IsFileServerRunning_IsValid = IsFileServerRunning_FunctionAddress != IntPtr.Zero && IsFileServerRunning_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AndroidFileServer.AndroidFileServerBPLibrary:IsFileServerRunning", IsFileServerRunning_IsValid);
	}
}
