using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangePhysicsAssetFactoryNode : UInterchangeBaseNode
{
	private static bool SetCustomSkeletalMeshUid_IsValid;

	private static IntPtr SetCustomSkeletalMeshUid_FunctionAddress;

	private static int SetCustomSkeletalMeshUid_ParamsSize;

	private static bool SetCustomSkeletalMeshUid_AttributeValue_IsValid;

	private static FFieldAddress SetCustomSkeletalMeshUid_AttributeValue_PropertyAddress;

	private static int SetCustomSkeletalMeshUid_AttributeValue_Offset;

	private static bool SetCustomSkeletalMeshUid_ReturnValue_IsValid;

	private static FFieldAddress SetCustomSkeletalMeshUid_ReturnValue_PropertyAddress;

	private static int SetCustomSkeletalMeshUid_ReturnValue_Offset;

	private static bool InitializePhysicsAssetNode_IsValid;

	private static IntPtr InitializePhysicsAssetNode_FunctionAddress;

	private static int InitializePhysicsAssetNode_ParamsSize;

	private static bool InitializePhysicsAssetNode_UniqueID_IsValid;

	private static FFieldAddress InitializePhysicsAssetNode_UniqueID_PropertyAddress;

	private static int InitializePhysicsAssetNode_UniqueID_Offset;

	private static bool InitializePhysicsAssetNode_DisplayLabel_IsValid;

	private static FFieldAddress InitializePhysicsAssetNode_DisplayLabel_PropertyAddress;

	private static int InitializePhysicsAssetNode_DisplayLabel_Offset;

	private static bool InitializePhysicsAssetNode_InAssetClass_IsValid;

	private static FFieldAddress InitializePhysicsAssetNode_InAssetClass_PropertyAddress;

	private static int InitializePhysicsAssetNode_InAssetClass_Offset;

	private static bool GetObjectClass_IsValid;

	private static IntPtr GetObjectClass_FunctionAddress;

	private static int GetObjectClass_ParamsSize;

	private static bool GetObjectClass_ReturnValue_IsValid;

	private static FFieldAddress GetObjectClass_ReturnValue_PropertyAddress;

	private static int GetObjectClass_ReturnValue_Offset;

	private static bool GetCustomSkeletalMeshUid_IsValid;

	private static IntPtr GetCustomSkeletalMeshUid_FunctionAddress;

	private static int GetCustomSkeletalMeshUid_ParamsSize;

	private static bool GetCustomSkeletalMeshUid_AttributeValue_IsValid;

	private static FFieldAddress GetCustomSkeletalMeshUid_AttributeValue_PropertyAddress;

	private static int GetCustomSkeletalMeshUid_AttributeValue_Offset;

	private static bool GetCustomSkeletalMeshUid_ReturnValue_IsValid;

	private static FFieldAddress GetCustomSkeletalMeshUid_ReturnValue_PropertyAddress;

	private static int GetCustomSkeletalMeshUid_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:SetCustomSkeletalMeshUid")]
	public unsafe bool SetCustomSkeletalMeshUid(string AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomSkeletalMeshUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:SetCustomSkeletalMeshUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomSkeletalMeshUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomSkeletalMeshUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomSkeletalMeshUid_AttributeValue_Offset), 0, SetCustomSkeletalMeshUid_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomSkeletalMeshUid_FunctionAddress, intPtr, SetCustomSkeletalMeshUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomSkeletalMeshUid_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomSkeletalMeshUid_ReturnValue_Offset), 0, SetCustomSkeletalMeshUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:InitializePhysicsAssetNode")]
	public unsafe void InitializePhysicsAssetNode(string UniqueID, string DisplayLabel, string InAssetClass)
	{
		CheckDestroyed();
		if (!InitializePhysicsAssetNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:InitializePhysicsAssetNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializePhysicsAssetNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializePhysicsAssetNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializePhysicsAssetNode_UniqueID_Offset), 0, InitializePhysicsAssetNode_UniqueID_PropertyAddress.Address, UniqueID);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializePhysicsAssetNode_DisplayLabel_Offset), 0, InitializePhysicsAssetNode_DisplayLabel_PropertyAddress.Address, DisplayLabel);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializePhysicsAssetNode_InAssetClass_Offset), 0, InitializePhysicsAssetNode_InAssetClass_PropertyAddress.Address, InAssetClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializePhysicsAssetNode_FunctionAddress, intPtr, InitializePhysicsAssetNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InitializePhysicsAssetNode_UniqueID_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitializePhysicsAssetNode_DisplayLabel_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitializePhysicsAssetNode_InAssetClass_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:GetObjectClass")]
	public unsafe TSubclassOf<UObject> GetObjectClass()
	{
		CheckDestroyed();
		if (!GetObjectClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:GetObjectClass");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:GetCustomSkeletalMeshUid")]
	public unsafe bool GetCustomSkeletalMeshUid(out string AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomSkeletalMeshUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:GetCustomSkeletalMeshUid");
			AttributeValue = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomSkeletalMeshUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomSkeletalMeshUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomSkeletalMeshUid_FunctionAddress, intPtr, GetCustomSkeletalMeshUid_ParamsSize);
		AttributeValue = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomSkeletalMeshUid_AttributeValue_Offset), 0, GetCustomSkeletalMeshUid_AttributeValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCustomSkeletalMeshUid_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomSkeletalMeshUid_ReturnValue_Offset), 0, GetCustomSkeletalMeshUid_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangePhysicsAssetFactoryNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangePhysicsAssetFactoryNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangePhysicsAssetFactoryNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode");
		SetCustomSkeletalMeshUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomSkeletalMeshUid");
		SetCustomSkeletalMeshUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomSkeletalMeshUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomSkeletalMeshUid_AttributeValue_PropertyAddress, SetCustomSkeletalMeshUid_FunctionAddress, "AttributeValue");
		SetCustomSkeletalMeshUid_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomSkeletalMeshUid_FunctionAddress, "AttributeValue");
		SetCustomSkeletalMeshUid_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomSkeletalMeshUid_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomSkeletalMeshUid_ReturnValue_PropertyAddress, SetCustomSkeletalMeshUid_FunctionAddress, "ReturnValue");
		SetCustomSkeletalMeshUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomSkeletalMeshUid_FunctionAddress, "ReturnValue");
		SetCustomSkeletalMeshUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomSkeletalMeshUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomSkeletalMeshUid_IsValid = SetCustomSkeletalMeshUid_FunctionAddress != IntPtr.Zero && SetCustomSkeletalMeshUid_AttributeValue_IsValid && SetCustomSkeletalMeshUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:SetCustomSkeletalMeshUid", SetCustomSkeletalMeshUid_IsValid);
		InitializePhysicsAssetNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializePhysicsAssetNode");
		InitializePhysicsAssetNode_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializePhysicsAssetNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializePhysicsAssetNode_UniqueID_PropertyAddress, InitializePhysicsAssetNode_FunctionAddress, "UniqueID");
		InitializePhysicsAssetNode_UniqueID_Offset = NativeReflectionCached.GetPropertyOffset(InitializePhysicsAssetNode_FunctionAddress, "UniqueID");
		InitializePhysicsAssetNode_UniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializePhysicsAssetNode_FunctionAddress, "UniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializePhysicsAssetNode_DisplayLabel_PropertyAddress, InitializePhysicsAssetNode_FunctionAddress, "DisplayLabel");
		InitializePhysicsAssetNode_DisplayLabel_Offset = NativeReflectionCached.GetPropertyOffset(InitializePhysicsAssetNode_FunctionAddress, "DisplayLabel");
		InitializePhysicsAssetNode_DisplayLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializePhysicsAssetNode_FunctionAddress, "DisplayLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializePhysicsAssetNode_InAssetClass_PropertyAddress, InitializePhysicsAssetNode_FunctionAddress, "InAssetClass");
		InitializePhysicsAssetNode_InAssetClass_Offset = NativeReflectionCached.GetPropertyOffset(InitializePhysicsAssetNode_FunctionAddress, "InAssetClass");
		InitializePhysicsAssetNode_InAssetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializePhysicsAssetNode_FunctionAddress, "InAssetClass", Classes.FStrProperty);
		InitializePhysicsAssetNode_IsValid = InitializePhysicsAssetNode_FunctionAddress != IntPtr.Zero && InitializePhysicsAssetNode_UniqueID_IsValid && InitializePhysicsAssetNode_DisplayLabel_IsValid && InitializePhysicsAssetNode_InAssetClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:InitializePhysicsAssetNode", InitializePhysicsAssetNode_IsValid);
		GetObjectClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetObjectClass");
		GetObjectClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectClass_ReturnValue_PropertyAddress, GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetObjectClass_IsValid = GetObjectClass_FunctionAddress != IntPtr.Zero && GetObjectClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:GetObjectClass", GetObjectClass_IsValid);
		GetCustomSkeletalMeshUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomSkeletalMeshUid");
		GetCustomSkeletalMeshUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomSkeletalMeshUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomSkeletalMeshUid_AttributeValue_PropertyAddress, GetCustomSkeletalMeshUid_FunctionAddress, "AttributeValue");
		GetCustomSkeletalMeshUid_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomSkeletalMeshUid_FunctionAddress, "AttributeValue");
		GetCustomSkeletalMeshUid_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomSkeletalMeshUid_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomSkeletalMeshUid_ReturnValue_PropertyAddress, GetCustomSkeletalMeshUid_FunctionAddress, "ReturnValue");
		GetCustomSkeletalMeshUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomSkeletalMeshUid_FunctionAddress, "ReturnValue");
		GetCustomSkeletalMeshUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomSkeletalMeshUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomSkeletalMeshUid_IsValid = GetCustomSkeletalMeshUid_FunctionAddress != IntPtr.Zero && GetCustomSkeletalMeshUid_AttributeValue_IsValid && GetCustomSkeletalMeshUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangePhysicsAssetFactoryNode:GetCustomSkeletalMeshUid", GetCustomSkeletalMeshUid_IsValid);
	}
}
