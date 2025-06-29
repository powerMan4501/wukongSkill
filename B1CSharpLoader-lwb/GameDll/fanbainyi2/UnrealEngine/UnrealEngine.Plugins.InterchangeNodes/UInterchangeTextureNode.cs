using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeTextureNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeTextureNode : UInterchangeBaseNode
{
	private static bool SetPayLoadKey_IsValid;

	private static IntPtr SetPayLoadKey_FunctionAddress;

	private static int SetPayLoadKey_ParamsSize;

	private static bool SetPayLoadKey_PayloadKey_IsValid;

	private static FFieldAddress SetPayLoadKey_PayloadKey_PropertyAddress;

	private static int SetPayLoadKey_PayloadKey_Offset;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeTextureNode:SetPayLoadKey")]
	public unsafe void SetPayLoadKey(string PayloadKey)
	{
		CheckDestroyed();
		if (!SetPayLoadKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeTextureNode:SetPayLoadKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPayLoadKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPayLoadKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetPayLoadKey_PayloadKey_Offset), 0, SetPayLoadKey_PayloadKey_PropertyAddress.Address, PayloadKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPayLoadKey_FunctionAddress, intPtr, SetPayLoadKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPayLoadKey_PayloadKey_PropertyAddress.Address, intPtr);
	}

	static UInterchangeTextureNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeTextureNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeTextureNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeTextureNode");
		SetPayLoadKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPayLoadKey");
		SetPayLoadKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPayLoadKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPayLoadKey_PayloadKey_PropertyAddress, SetPayLoadKey_FunctionAddress, "PayloadKey");
		SetPayLoadKey_PayloadKey_Offset = NativeReflectionCached.GetPropertyOffset(SetPayLoadKey_FunctionAddress, "PayloadKey");
		SetPayLoadKey_PayloadKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPayLoadKey_FunctionAddress, "PayloadKey", Classes.FStrProperty);
		SetPayLoadKey_IsValid = SetPayLoadKey_FunctionAddress != IntPtr.Zero && SetPayLoadKey_PayloadKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeTextureNode:SetPayLoadKey", SetPayLoadKey_IsValid);
	}
}
