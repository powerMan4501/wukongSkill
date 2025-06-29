using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_OnlineSocketFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_OnlineSocketFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetLocalListenPort_IsValid;

	private static IntPtr GetLocalListenPort_FunctionAddress;

	private static int GetLocalListenPort_ParamsSize;

	private static bool GetLocalListenPort_WorldContext_IsValid;

	private static FFieldAddress GetLocalListenPort_WorldContext_PropertyAddress;

	private static int GetLocalListenPort_WorldContext_Offset;

	private static bool GetLocalListenPort_ReturnValue_IsValid;

	private static FFieldAddress GetLocalListenPort_ReturnValue_PropertyAddress;

	private static int GetLocalListenPort_ReturnValue_Offset;

	private static bool GetLocalListenIp_IsValid;

	private static IntPtr GetLocalListenIp_FunctionAddress;

	private static int GetLocalListenIp_ParamsSize;

	private static bool GetLocalListenIp_WorldContext_IsValid;

	private static FFieldAddress GetLocalListenIp_WorldContext_PropertyAddress;

	private static int GetLocalListenIp_WorldContext_Offset;

	private static bool GetLocalListenIp_ReturnValue_IsValid;

	private static FFieldAddress GetLocalListenIp_ReturnValue_PropertyAddress;

	private static int GetLocalListenIp_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_OnlineSocketFuncLib:GetLocalListenPort")]
	public unsafe static int GetLocalListenPort(UObject WorldContext)
	{
		if (!GetLocalListenPort_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_OnlineSocketFuncLib:GetLocalListenPort");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalListenPort_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalListenPort_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLocalListenPort_WorldContext_Offset), 0, GetLocalListenPort_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLocalListenPort_FunctionAddress, intPtr, GetLocalListenPort_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLocalListenPort_ReturnValue_Offset), 0, GetLocalListenPort_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_OnlineSocketFuncLib:GetLocalListenIp")]
	public unsafe static string GetLocalListenIp(UObject WorldContext)
	{
		if (!GetLocalListenIp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_OnlineSocketFuncLib:GetLocalListenIp");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalListenIp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalListenIp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLocalListenIp_WorldContext_Offset), 0, GetLocalListenIp_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLocalListenIp_FunctionAddress, intPtr, GetLocalListenIp_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLocalListenIp_ReturnValue_Offset), 0, GetLocalListenIp_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLocalListenIp_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGSE_OnlineSocketFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_OnlineSocketFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_OnlineSocketFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_OnlineSocketFuncLib");
		GetLocalListenPort_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalListenPort");
		GetLocalListenPort_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalListenPort_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalListenPort_WorldContext_PropertyAddress, GetLocalListenPort_FunctionAddress, "WorldContext");
		GetLocalListenPort_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalListenPort_FunctionAddress, "WorldContext");
		GetLocalListenPort_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalListenPort_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalListenPort_ReturnValue_PropertyAddress, GetLocalListenPort_FunctionAddress, "ReturnValue");
		GetLocalListenPort_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalListenPort_FunctionAddress, "ReturnValue");
		GetLocalListenPort_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalListenPort_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLocalListenPort_IsValid = GetLocalListenPort_FunctionAddress != IntPtr.Zero && GetLocalListenPort_WorldContext_IsValid && GetLocalListenPort_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_OnlineSocketFuncLib:GetLocalListenPort", GetLocalListenPort_IsValid);
		GetLocalListenIp_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalListenIp");
		GetLocalListenIp_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalListenIp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalListenIp_WorldContext_PropertyAddress, GetLocalListenIp_FunctionAddress, "WorldContext");
		GetLocalListenIp_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalListenIp_FunctionAddress, "WorldContext");
		GetLocalListenIp_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalListenIp_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalListenIp_ReturnValue_PropertyAddress, GetLocalListenIp_FunctionAddress, "ReturnValue");
		GetLocalListenIp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalListenIp_FunctionAddress, "ReturnValue");
		GetLocalListenIp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalListenIp_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLocalListenIp_IsValid = GetLocalListenIp_FunctionAddress != IntPtr.Zero && GetLocalListenIp_WorldContext_IsValid && GetLocalListenIp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_OnlineSocketFuncLib:GetLocalListenIp", GetLocalListenIp_IsValid);
	}
}
