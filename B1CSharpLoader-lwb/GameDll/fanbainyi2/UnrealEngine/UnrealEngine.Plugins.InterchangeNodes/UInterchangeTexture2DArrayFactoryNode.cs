using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeTexture2DArrayFactoryNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeTexture2DArrayFactoryNode : UInterchangeTextureFactoryNode
{
	private static bool SetCustomAddressZ_IsValid;

	private static IntPtr SetCustomAddressZ_FunctionAddress;

	private static int SetCustomAddressZ_ParamsSize;

	private static bool SetCustomAddressZ_AttributeValue_IsValid;

	private static FFieldAddress SetCustomAddressZ_AttributeValue_PropertyAddress;

	private static int SetCustomAddressZ_AttributeValue_Offset;

	private static bool SetCustomAddressZ_bAddApplyDelegate_IsValid;

	private static FFieldAddress SetCustomAddressZ_bAddApplyDelegate_PropertyAddress;

	private static int SetCustomAddressZ_bAddApplyDelegate_Offset;

	private static bool SetCustomAddressZ_ReturnValue_IsValid;

	private static FFieldAddress SetCustomAddressZ_ReturnValue_PropertyAddress;

	private static int SetCustomAddressZ_ReturnValue_Offset;

	private static bool GetCustomAddressZ_IsValid;

	private static IntPtr GetCustomAddressZ_FunctionAddress;

	private static int GetCustomAddressZ_ParamsSize;

	private static bool GetCustomAddressZ_AttributeValue_IsValid;

	private static FFieldAddress GetCustomAddressZ_AttributeValue_PropertyAddress;

	private static int GetCustomAddressZ_AttributeValue_Offset;

	private static bool GetCustomAddressZ_ReturnValue_IsValid;

	private static FFieldAddress GetCustomAddressZ_ReturnValue_PropertyAddress;

	private static int GetCustomAddressZ_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeTexture2DArrayFactoryNode:SetCustomAddressZ")]
	public unsafe bool SetCustomAddressZ(byte AttributeValue, bool bAddApplyDelegate = true)
	{
		CheckDestroyed();
		if (!SetCustomAddressZ_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeTexture2DArrayFactoryNode:SetCustomAddressZ");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomAddressZ_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomAddressZ_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, SetCustomAddressZ_AttributeValue_Offset), 0, SetCustomAddressZ_AttributeValue_PropertyAddress.Address, AttributeValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomAddressZ_bAddApplyDelegate_Offset), 0, SetCustomAddressZ_bAddApplyDelegate_PropertyAddress.Address, bAddApplyDelegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomAddressZ_FunctionAddress, intPtr, SetCustomAddressZ_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomAddressZ_ReturnValue_Offset), 0, SetCustomAddressZ_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeTexture2DArrayFactoryNode:GetCustomAddressZ")]
	public unsafe bool GetCustomAddressZ(out byte AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomAddressZ_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeTexture2DArrayFactoryNode:GetCustomAddressZ");
			AttributeValue = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomAddressZ_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomAddressZ_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomAddressZ_FunctionAddress, intPtr, GetCustomAddressZ_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, GetCustomAddressZ_AttributeValue_Offset), 0, GetCustomAddressZ_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomAddressZ_ReturnValue_Offset), 0, GetCustomAddressZ_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeTexture2DArrayFactoryNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeTexture2DArrayFactoryNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeTexture2DArrayFactoryNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeTexture2DArrayFactoryNode");
		SetCustomAddressZ_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomAddressZ");
		SetCustomAddressZ_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomAddressZ_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomAddressZ_AttributeValue_PropertyAddress, SetCustomAddressZ_FunctionAddress, "AttributeValue");
		SetCustomAddressZ_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomAddressZ_FunctionAddress, "AttributeValue");
		SetCustomAddressZ_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomAddressZ_FunctionAddress, "AttributeValue", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomAddressZ_bAddApplyDelegate_PropertyAddress, SetCustomAddressZ_FunctionAddress, "bAddApplyDelegate");
		SetCustomAddressZ_bAddApplyDelegate_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomAddressZ_FunctionAddress, "bAddApplyDelegate");
		SetCustomAddressZ_bAddApplyDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomAddressZ_FunctionAddress, "bAddApplyDelegate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomAddressZ_ReturnValue_PropertyAddress, SetCustomAddressZ_FunctionAddress, "ReturnValue");
		SetCustomAddressZ_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomAddressZ_FunctionAddress, "ReturnValue");
		SetCustomAddressZ_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomAddressZ_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomAddressZ_IsValid = SetCustomAddressZ_FunctionAddress != IntPtr.Zero && SetCustomAddressZ_AttributeValue_IsValid && SetCustomAddressZ_bAddApplyDelegate_IsValid && SetCustomAddressZ_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeTexture2DArrayFactoryNode:SetCustomAddressZ", SetCustomAddressZ_IsValid);
		GetCustomAddressZ_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomAddressZ");
		GetCustomAddressZ_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomAddressZ_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomAddressZ_AttributeValue_PropertyAddress, GetCustomAddressZ_FunctionAddress, "AttributeValue");
		GetCustomAddressZ_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomAddressZ_FunctionAddress, "AttributeValue");
		GetCustomAddressZ_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomAddressZ_FunctionAddress, "AttributeValue", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomAddressZ_ReturnValue_PropertyAddress, GetCustomAddressZ_FunctionAddress, "ReturnValue");
		GetCustomAddressZ_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomAddressZ_FunctionAddress, "ReturnValue");
		GetCustomAddressZ_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomAddressZ_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomAddressZ_IsValid = GetCustomAddressZ_FunctionAddress != IntPtr.Zero && GetCustomAddressZ_AttributeValue_IsValid && GetCustomAddressZ_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeTexture2DArrayFactoryNode:GetCustomAddressZ", GetCustomAddressZ_IsValid);
	}
}
