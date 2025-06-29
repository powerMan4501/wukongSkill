using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeActorFactoryNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeActorFactoryNode : UInterchangeBaseNode
{
	private static bool SetCustomGlobalTransform_IsValid;

	private static IntPtr SetCustomGlobalTransform_FunctionAddress;

	private static int SetCustomGlobalTransform_ParamsSize;

	private static bool SetCustomGlobalTransform_AttributeValue_IsValid;

	private static FFieldAddress SetCustomGlobalTransform_AttributeValue_PropertyAddress;

	private static int SetCustomGlobalTransform_AttributeValue_Offset;

	private static bool SetCustomGlobalTransform_ReturnValue_IsValid;

	private static FFieldAddress SetCustomGlobalTransform_ReturnValue_PropertyAddress;

	private static int SetCustomGlobalTransform_ReturnValue_Offset;

	private static bool SetCustomActorClassName_IsValid;

	private static IntPtr SetCustomActorClassName_FunctionAddress;

	private static int SetCustomActorClassName_ParamsSize;

	private static bool SetCustomActorClassName_AttributeValue_IsValid;

	private static FFieldAddress SetCustomActorClassName_AttributeValue_PropertyAddress;

	private static int SetCustomActorClassName_AttributeValue_Offset;

	private static bool SetCustomActorClassName_ReturnValue_IsValid;

	private static FFieldAddress SetCustomActorClassName_ReturnValue_PropertyAddress;

	private static int SetCustomActorClassName_ReturnValue_Offset;

	private static bool GetCustomGlobalTransform_IsValid;

	private static IntPtr GetCustomGlobalTransform_FunctionAddress;

	private static int GetCustomGlobalTransform_ParamsSize;

	private static bool GetCustomGlobalTransform_AttributeValue_IsValid;

	private static FFieldAddress GetCustomGlobalTransform_AttributeValue_PropertyAddress;

	private static int GetCustomGlobalTransform_AttributeValue_Offset;

	private static bool GetCustomGlobalTransform_ReturnValue_IsValid;

	private static FFieldAddress GetCustomGlobalTransform_ReturnValue_PropertyAddress;

	private static int GetCustomGlobalTransform_ReturnValue_Offset;

	private static bool GetCustomActorClassName_IsValid;

	private static IntPtr GetCustomActorClassName_FunctionAddress;

	private static int GetCustomActorClassName_ParamsSize;

	private static bool GetCustomActorClassName_AttributeValue_IsValid;

	private static FFieldAddress GetCustomActorClassName_AttributeValue_PropertyAddress;

	private static int GetCustomActorClassName_AttributeValue_Offset;

	private static bool GetCustomActorClassName_ReturnValue_IsValid;

	private static FFieldAddress GetCustomActorClassName_ReturnValue_PropertyAddress;

	private static int GetCustomActorClassName_ReturnValue_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeActorFactoryNode:SetCustomGlobalTransform")]
	public unsafe bool SetCustomGlobalTransform(FTransform AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomGlobalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeActorFactoryNode:SetCustomGlobalTransform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomGlobalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomGlobalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCustomGlobalTransform_AttributeValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetCustomGlobalTransform_AttributeValue_Offset), 0, SetCustomGlobalTransform_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomGlobalTransform_FunctionAddress, intPtr, SetCustomGlobalTransform_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomGlobalTransform_ReturnValue_Offset), 0, SetCustomGlobalTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeActorFactoryNode:SetCustomActorClassName")]
	public unsafe bool SetCustomActorClassName(string AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomActorClassName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeActorFactoryNode:SetCustomActorClassName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomActorClassName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomActorClassName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomActorClassName_AttributeValue_Offset), 0, SetCustomActorClassName_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomActorClassName_FunctionAddress, intPtr, SetCustomActorClassName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomActorClassName_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomActorClassName_ReturnValue_Offset), 0, SetCustomActorClassName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeActorFactoryNode:GetCustomGlobalTransform")]
	public unsafe bool GetCustomGlobalTransform(out FTransform AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomGlobalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeActorFactoryNode:GetCustomGlobalTransform");
			AttributeValue = default(FTransform);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomGlobalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomGlobalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCustomGlobalTransform_AttributeValue_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomGlobalTransform_FunctionAddress, intPtr, GetCustomGlobalTransform_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetCustomGlobalTransform_AttributeValue_Offset), 0, GetCustomGlobalTransform_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomGlobalTransform_ReturnValue_Offset), 0, GetCustomGlobalTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeActorFactoryNode:GetCustomActorClassName")]
	public unsafe bool GetCustomActorClassName(out string AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomActorClassName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeActorFactoryNode:GetCustomActorClassName");
			AttributeValue = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomActorClassName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomActorClassName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomActorClassName_FunctionAddress, intPtr, GetCustomActorClassName_ParamsSize);
		AttributeValue = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomActorClassName_AttributeValue_Offset), 0, GetCustomActorClassName_AttributeValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCustomActorClassName_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomActorClassName_ReturnValue_Offset), 0, GetCustomActorClassName_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeActorFactoryNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeActorFactoryNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeActorFactoryNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeActorFactoryNode");
		SetCustomGlobalTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomGlobalTransform");
		SetCustomGlobalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomGlobalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomGlobalTransform_AttributeValue_PropertyAddress, SetCustomGlobalTransform_FunctionAddress, "AttributeValue");
		SetCustomGlobalTransform_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomGlobalTransform_FunctionAddress, "AttributeValue");
		SetCustomGlobalTransform_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomGlobalTransform_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomGlobalTransform_ReturnValue_PropertyAddress, SetCustomGlobalTransform_FunctionAddress, "ReturnValue");
		SetCustomGlobalTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomGlobalTransform_FunctionAddress, "ReturnValue");
		SetCustomGlobalTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomGlobalTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomGlobalTransform_IsValid = SetCustomGlobalTransform_FunctionAddress != IntPtr.Zero && SetCustomGlobalTransform_AttributeValue_IsValid && SetCustomGlobalTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeActorFactoryNode:SetCustomGlobalTransform", SetCustomGlobalTransform_IsValid);
		SetCustomActorClassName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomActorClassName");
		SetCustomActorClassName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomActorClassName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomActorClassName_AttributeValue_PropertyAddress, SetCustomActorClassName_FunctionAddress, "AttributeValue");
		SetCustomActorClassName_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomActorClassName_FunctionAddress, "AttributeValue");
		SetCustomActorClassName_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomActorClassName_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomActorClassName_ReturnValue_PropertyAddress, SetCustomActorClassName_FunctionAddress, "ReturnValue");
		SetCustomActorClassName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomActorClassName_FunctionAddress, "ReturnValue");
		SetCustomActorClassName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomActorClassName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomActorClassName_IsValid = SetCustomActorClassName_FunctionAddress != IntPtr.Zero && SetCustomActorClassName_AttributeValue_IsValid && SetCustomActorClassName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeActorFactoryNode:SetCustomActorClassName", SetCustomActorClassName_IsValid);
		GetCustomGlobalTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomGlobalTransform");
		GetCustomGlobalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomGlobalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomGlobalTransform_AttributeValue_PropertyAddress, GetCustomGlobalTransform_FunctionAddress, "AttributeValue");
		GetCustomGlobalTransform_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomGlobalTransform_FunctionAddress, "AttributeValue");
		GetCustomGlobalTransform_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomGlobalTransform_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomGlobalTransform_ReturnValue_PropertyAddress, GetCustomGlobalTransform_FunctionAddress, "ReturnValue");
		GetCustomGlobalTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomGlobalTransform_FunctionAddress, "ReturnValue");
		GetCustomGlobalTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomGlobalTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomGlobalTransform_IsValid = GetCustomGlobalTransform_FunctionAddress != IntPtr.Zero && GetCustomGlobalTransform_AttributeValue_IsValid && GetCustomGlobalTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeActorFactoryNode:GetCustomGlobalTransform", GetCustomGlobalTransform_IsValid);
		GetCustomActorClassName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomActorClassName");
		GetCustomActorClassName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomActorClassName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomActorClassName_AttributeValue_PropertyAddress, GetCustomActorClassName_FunctionAddress, "AttributeValue");
		GetCustomActorClassName_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomActorClassName_FunctionAddress, "AttributeValue");
		GetCustomActorClassName_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomActorClassName_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomActorClassName_ReturnValue_PropertyAddress, GetCustomActorClassName_FunctionAddress, "ReturnValue");
		GetCustomActorClassName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomActorClassName_FunctionAddress, "ReturnValue");
		GetCustomActorClassName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomActorClassName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomActorClassName_IsValid = GetCustomActorClassName_FunctionAddress != IntPtr.Zero && GetCustomActorClassName_AttributeValue_IsValid && GetCustomActorClassName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeActorFactoryNode:GetCustomActorClassName", GetCustomActorClassName_IsValid);
	}
}
