using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_NetFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_NetFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetAllActiveConnectionInfo_IsValid;

	private static IntPtr GetAllActiveConnectionInfo_FunctionAddress;

	private static int GetAllActiveConnectionInfo_ParamsSize;

	private static bool GetAllActiveConnectionInfo_WorldContext_IsValid;

	private static FFieldAddress GetAllActiveConnectionInfo_WorldContext_PropertyAddress;

	private static int GetAllActiveConnectionInfo_WorldContext_Offset;

	private static bool GetAllActiveConnectionInfo_ConnectionInfos_IsValid;

	private static FFieldAddress GetAllActiveConnectionInfo_ConnectionInfos_PropertyAddress;

	private static int GetAllActiveConnectionInfo_ConnectionInfos_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_NetFuncLib:GetAllActiveConnectionInfo")]
	public unsafe static void GetAllActiveConnectionInfo(UObject WorldContext, out List<FGSConnectionInfo> ConnectionInfos)
	{
		if (!GetAllActiveConnectionInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_NetFuncLib:GetAllActiveConnectionInfo");
			ConnectionInfos = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllActiveConnectionInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllActiveConnectionInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAllActiveConnectionInfo_WorldContext_Offset), 0, GetAllActiveConnectionInfo_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllActiveConnectionInfo_FunctionAddress, intPtr, GetAllActiveConnectionInfo_ParamsSize);
		ConnectionInfos = new TArrayCopyMarshaler<FGSConnectionInfo>(1, GetAllActiveConnectionInfo_ConnectionInfos_PropertyAddress, CachedMarshalingDelegates<FGSConnectionInfo, FGSConnectionInfo>.FromNative, CachedMarshalingDelegates<FGSConnectionInfo, FGSConnectionInfo>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllActiveConnectionInfo_ConnectionInfos_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllActiveConnectionInfo_ConnectionInfos_PropertyAddress.Address, intPtr);
	}

	static UGSE_NetFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_NetFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_NetFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_NetFuncLib");
		GetAllActiveConnectionInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllActiveConnectionInfo");
		GetAllActiveConnectionInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllActiveConnectionInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllActiveConnectionInfo_WorldContext_PropertyAddress, GetAllActiveConnectionInfo_FunctionAddress, "WorldContext");
		GetAllActiveConnectionInfo_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActiveConnectionInfo_FunctionAddress, "WorldContext");
		GetAllActiveConnectionInfo_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActiveConnectionInfo_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActiveConnectionInfo_ConnectionInfos_PropertyAddress, GetAllActiveConnectionInfo_FunctionAddress, "ConnectionInfos");
		GetAllActiveConnectionInfo_ConnectionInfos_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActiveConnectionInfo_FunctionAddress, "ConnectionInfos");
		GetAllActiveConnectionInfo_ConnectionInfos_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActiveConnectionInfo_FunctionAddress, "ConnectionInfos", Classes.FArrayProperty);
		GetAllActiveConnectionInfo_IsValid = GetAllActiveConnectionInfo_FunctionAddress != IntPtr.Zero && GetAllActiveConnectionInfo_WorldContext_IsValid && GetAllActiveConnectionInfo_ConnectionInfos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_NetFuncLib:GetAllActiveConnectionInfo", GetAllActiveConnectionInfo_IsValid);
	}
}
