using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeTexture2DNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeTexture2DNode : UInterchangeTextureNode
{
	private static bool SetSourceBlocks_IsValid;

	private static IntPtr SetSourceBlocks_FunctionAddress;

	private static int SetSourceBlocks_ParamsSize;

	private static bool SetSourceBlocks_InSourceBlocks_IsValid;

	private static FFieldAddress SetSourceBlocks_InSourceBlocks_PropertyAddress;

	private static int SetSourceBlocks_InSourceBlocks_Offset;

	private static bool GetSourceBlocks_IsValid;

	private static IntPtr GetSourceBlocks_FunctionAddress;

	private static int GetSourceBlocks_ParamsSize;

	private static bool GetSourceBlocks_ReturnValue_IsValid;

	private static FFieldAddress GetSourceBlocks_ReturnValue_PropertyAddress;

	private static int GetSourceBlocks_ReturnValue_Offset;

	private static bool ClearSourceBlocksData_IsValid;

	private static IntPtr ClearSourceBlocksData_FunctionAddress;

	private static int ClearSourceBlocksData_ParamsSize;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeTexture2DNode:SetSourceBlocks")]
	public unsafe void SetSourceBlocks(Dictionary<int, string> InSourceBlocks)
	{
		CheckDestroyed();
		if (!SetSourceBlocks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeTexture2DNode:SetSourceBlocks");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSourceBlocks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSourceBlocks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSourceBlocks_InSourceBlocks_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, string>(1, SetSourceBlocks_InSourceBlocks_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetSourceBlocks_InSourceBlocks_Offset), InSourceBlocks);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSourceBlocks_FunctionAddress, intPtr, SetSourceBlocks_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSourceBlocks_InSourceBlocks_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeTexture2DNode:GetSourceBlocks")]
	public unsafe Dictionary<int, string> GetSourceBlocks()
	{
		CheckDestroyed();
		if (!GetSourceBlocks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeTexture2DNode:GetSourceBlocks");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSourceBlocks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSourceBlocks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSourceBlocks_FunctionAddress, intPtr, GetSourceBlocks_ParamsSize);
		Dictionary<int, string> result = new TMapCopyMarshaler<int, string>(1, GetSourceBlocks_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetSourceBlocks_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSourceBlocks_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeTexture2DNode:ClearSourceBlocksData")]
	public unsafe void ClearSourceBlocksData()
	{
		CheckDestroyed();
		if (!ClearSourceBlocksData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeTexture2DNode:ClearSourceBlocksData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSourceBlocksData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSourceBlocksData_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearSourceBlocksData_FunctionAddress, argsSize: ClearSourceBlocksData_ParamsSize);
	}

	static UInterchangeTexture2DNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeTexture2DNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeTexture2DNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeTexture2DNode");
		SetSourceBlocks_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSourceBlocks");
		SetSourceBlocks_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSourceBlocks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSourceBlocks_InSourceBlocks_PropertyAddress, SetSourceBlocks_FunctionAddress, "InSourceBlocks");
		SetSourceBlocks_InSourceBlocks_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceBlocks_FunctionAddress, "InSourceBlocks");
		SetSourceBlocks_InSourceBlocks_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceBlocks_FunctionAddress, "InSourceBlocks", Classes.FMapProperty);
		SetSourceBlocks_IsValid = SetSourceBlocks_FunctionAddress != IntPtr.Zero && SetSourceBlocks_InSourceBlocks_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeTexture2DNode:SetSourceBlocks", SetSourceBlocks_IsValid);
		GetSourceBlocks_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSourceBlocks");
		GetSourceBlocks_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSourceBlocks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSourceBlocks_ReturnValue_PropertyAddress, GetSourceBlocks_FunctionAddress, "ReturnValue");
		GetSourceBlocks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSourceBlocks_FunctionAddress, "ReturnValue");
		GetSourceBlocks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSourceBlocks_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetSourceBlocks_IsValid = GetSourceBlocks_FunctionAddress != IntPtr.Zero && GetSourceBlocks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeTexture2DNode:GetSourceBlocks", GetSourceBlocks_IsValid);
		ClearSourceBlocksData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearSourceBlocksData");
		ClearSourceBlocksData_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSourceBlocksData_FunctionAddress);
		ClearSourceBlocksData_IsValid = ClearSourceBlocksData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeTexture2DNode:ClearSourceBlocksData", ClearSourceBlocksData_IsValid);
	}
}
