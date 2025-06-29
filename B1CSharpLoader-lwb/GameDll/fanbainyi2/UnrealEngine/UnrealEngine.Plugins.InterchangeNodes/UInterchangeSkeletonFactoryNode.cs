using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeSkeletonFactoryNode : UInterchangeBaseNode
{
	private static bool SetCustomRootJointUid_IsValid;

	private static IntPtr SetCustomRootJointUid_FunctionAddress;

	private static int SetCustomRootJointUid_ParamsSize;

	private static bool SetCustomRootJointUid_AttributeValue_IsValid;

	private static FFieldAddress SetCustomRootJointUid_AttributeValue_PropertyAddress;

	private static int SetCustomRootJointUid_AttributeValue_Offset;

	private static bool SetCustomRootJointUid_ReturnValue_IsValid;

	private static FFieldAddress SetCustomRootJointUid_ReturnValue_PropertyAddress;

	private static int SetCustomRootJointUid_ReturnValue_Offset;

	private static bool InitializeSkeletonNode_IsValid;

	private static IntPtr InitializeSkeletonNode_FunctionAddress;

	private static int InitializeSkeletonNode_ParamsSize;

	private static bool InitializeSkeletonNode_UniqueID_IsValid;

	private static FFieldAddress InitializeSkeletonNode_UniqueID_PropertyAddress;

	private static int InitializeSkeletonNode_UniqueID_Offset;

	private static bool InitializeSkeletonNode_DisplayLabel_IsValid;

	private static FFieldAddress InitializeSkeletonNode_DisplayLabel_PropertyAddress;

	private static int InitializeSkeletonNode_DisplayLabel_Offset;

	private static bool InitializeSkeletonNode_InAssetClass_IsValid;

	private static FFieldAddress InitializeSkeletonNode_InAssetClass_PropertyAddress;

	private static int InitializeSkeletonNode_InAssetClass_Offset;

	private static bool GetObjectClass_IsValid;

	private static IntPtr GetObjectClass_FunctionAddress;

	private static int GetObjectClass_ParamsSize;

	private static bool GetObjectClass_ReturnValue_IsValid;

	private static FFieldAddress GetObjectClass_ReturnValue_PropertyAddress;

	private static int GetObjectClass_ReturnValue_Offset;

	private static bool GetCustomRootJointUid_IsValid;

	private static IntPtr GetCustomRootJointUid_FunctionAddress;

	private static int GetCustomRootJointUid_ParamsSize;

	private static bool GetCustomRootJointUid_AttributeValue_IsValid;

	private static FFieldAddress GetCustomRootJointUid_AttributeValue_PropertyAddress;

	private static int GetCustomRootJointUid_AttributeValue_Offset;

	private static bool GetCustomRootJointUid_ReturnValue_IsValid;

	private static FFieldAddress GetCustomRootJointUid_ReturnValue_PropertyAddress;

	private static int GetCustomRootJointUid_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:SetCustomRootJointUid")]
	public unsafe bool SetCustomRootJointUid(string AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomRootJointUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:SetCustomRootJointUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomRootJointUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomRootJointUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomRootJointUid_AttributeValue_Offset), 0, SetCustomRootJointUid_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomRootJointUid_FunctionAddress, intPtr, SetCustomRootJointUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomRootJointUid_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomRootJointUid_ReturnValue_Offset), 0, SetCustomRootJointUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:InitializeSkeletonNode")]
	public unsafe void InitializeSkeletonNode(string UniqueID, string DisplayLabel, string InAssetClass)
	{
		CheckDestroyed();
		if (!InitializeSkeletonNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:InitializeSkeletonNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeSkeletonNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeSkeletonNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeSkeletonNode_UniqueID_Offset), 0, InitializeSkeletonNode_UniqueID_PropertyAddress.Address, UniqueID);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeSkeletonNode_DisplayLabel_Offset), 0, InitializeSkeletonNode_DisplayLabel_PropertyAddress.Address, DisplayLabel);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeSkeletonNode_InAssetClass_Offset), 0, InitializeSkeletonNode_InAssetClass_PropertyAddress.Address, InAssetClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeSkeletonNode_FunctionAddress, intPtr, InitializeSkeletonNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InitializeSkeletonNode_UniqueID_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitializeSkeletonNode_DisplayLabel_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitializeSkeletonNode_InAssetClass_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:GetObjectClass")]
	public unsafe TSubclassOf<UObject> GetObjectClass()
	{
		CheckDestroyed();
		if (!GetObjectClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:GetObjectClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjectClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjectClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetObjectClass_FunctionAddress, intPtr, GetObjectClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetObjectClass_ReturnValue_Offset), 0, GetObjectClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:GetCustomRootJointUid")]
	public unsafe bool GetCustomRootJointUid(out string AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomRootJointUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:GetCustomRootJointUid");
			AttributeValue = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomRootJointUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomRootJointUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomRootJointUid_FunctionAddress, intPtr, GetCustomRootJointUid_ParamsSize);
		AttributeValue = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomRootJointUid_AttributeValue_Offset), 0, GetCustomRootJointUid_AttributeValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCustomRootJointUid_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomRootJointUid_ReturnValue_Offset), 0, GetCustomRootJointUid_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeSkeletonFactoryNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeSkeletonFactoryNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeSkeletonFactoryNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode");
		SetCustomRootJointUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomRootJointUid");
		SetCustomRootJointUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomRootJointUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomRootJointUid_AttributeValue_PropertyAddress, SetCustomRootJointUid_FunctionAddress, "AttributeValue");
		SetCustomRootJointUid_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomRootJointUid_FunctionAddress, "AttributeValue");
		SetCustomRootJointUid_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomRootJointUid_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomRootJointUid_ReturnValue_PropertyAddress, SetCustomRootJointUid_FunctionAddress, "ReturnValue");
		SetCustomRootJointUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomRootJointUid_FunctionAddress, "ReturnValue");
		SetCustomRootJointUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomRootJointUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomRootJointUid_IsValid = SetCustomRootJointUid_FunctionAddress != IntPtr.Zero && SetCustomRootJointUid_AttributeValue_IsValid && SetCustomRootJointUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:SetCustomRootJointUid", SetCustomRootJointUid_IsValid);
		InitializeSkeletonNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializeSkeletonNode");
		InitializeSkeletonNode_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeSkeletonNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeSkeletonNode_UniqueID_PropertyAddress, InitializeSkeletonNode_FunctionAddress, "UniqueID");
		InitializeSkeletonNode_UniqueID_Offset = NativeReflectionCached.GetPropertyOffset(InitializeSkeletonNode_FunctionAddress, "UniqueID");
		InitializeSkeletonNode_UniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeSkeletonNode_FunctionAddress, "UniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeSkeletonNode_DisplayLabel_PropertyAddress, InitializeSkeletonNode_FunctionAddress, "DisplayLabel");
		InitializeSkeletonNode_DisplayLabel_Offset = NativeReflectionCached.GetPropertyOffset(InitializeSkeletonNode_FunctionAddress, "DisplayLabel");
		InitializeSkeletonNode_DisplayLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeSkeletonNode_FunctionAddress, "DisplayLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeSkeletonNode_InAssetClass_PropertyAddress, InitializeSkeletonNode_FunctionAddress, "InAssetClass");
		InitializeSkeletonNode_InAssetClass_Offset = NativeReflectionCached.GetPropertyOffset(InitializeSkeletonNode_FunctionAddress, "InAssetClass");
		InitializeSkeletonNode_InAssetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeSkeletonNode_FunctionAddress, "InAssetClass", Classes.FStrProperty);
		InitializeSkeletonNode_IsValid = InitializeSkeletonNode_FunctionAddress != IntPtr.Zero && InitializeSkeletonNode_UniqueID_IsValid && InitializeSkeletonNode_DisplayLabel_IsValid && InitializeSkeletonNode_InAssetClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:InitializeSkeletonNode", InitializeSkeletonNode_IsValid);
		GetObjectClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetObjectClass");
		GetObjectClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectClass_ReturnValue_PropertyAddress, GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetObjectClass_IsValid = GetObjectClass_FunctionAddress != IntPtr.Zero && GetObjectClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:GetObjectClass", GetObjectClass_IsValid);
		GetCustomRootJointUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomRootJointUid");
		GetCustomRootJointUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomRootJointUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomRootJointUid_AttributeValue_PropertyAddress, GetCustomRootJointUid_FunctionAddress, "AttributeValue");
		GetCustomRootJointUid_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomRootJointUid_FunctionAddress, "AttributeValue");
		GetCustomRootJointUid_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomRootJointUid_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomRootJointUid_ReturnValue_PropertyAddress, GetCustomRootJointUid_FunctionAddress, "ReturnValue");
		GetCustomRootJointUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomRootJointUid_FunctionAddress, "ReturnValue");
		GetCustomRootJointUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomRootJointUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomRootJointUid_IsValid = GetCustomRootJointUid_FunctionAddress != IntPtr.Zero && GetCustomRootJointUid_AttributeValue_IsValid && GetCustomRootJointUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletonFactoryNode:GetCustomRootJointUid", GetCustomRootJointUid_IsValid);
	}
}
