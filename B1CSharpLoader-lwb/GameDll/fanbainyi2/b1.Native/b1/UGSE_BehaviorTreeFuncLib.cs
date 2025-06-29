using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_BehaviorTreeFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetCurrentTree_IsValid;

	private static IntPtr GetCurrentTree_FunctionAddress;

	private static int GetCurrentTree_ParamsSize;

	private static bool GetCurrentTree_AIController_IsValid;

	private static FFieldAddress GetCurrentTree_AIController_PropertyAddress;

	private static int GetCurrentTree_AIController_Offset;

	private static bool GetCurrentTree_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentTree_ReturnValue_PropertyAddress;

	private static int GetCurrentTree_ReturnValue_Offset;

	private static bool GetCurrentBTActiveNodeInfo_IsValid;

	private static IntPtr GetCurrentBTActiveNodeInfo_FunctionAddress;

	private static int GetCurrentBTActiveNodeInfo_ParamsSize;

	private static bool GetCurrentBTActiveNodeInfo_BehaviorTreeComp_IsValid;

	private static FFieldAddress GetCurrentBTActiveNodeInfo_BehaviorTreeComp_PropertyAddress;

	private static int GetCurrentBTActiveNodeInfo_BehaviorTreeComp_Offset;

	private static bool GetCurrentBTActiveNodeInfo_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentBTActiveNodeInfo_ReturnValue_PropertyAddress;

	private static int GetCurrentBTActiveNodeInfo_ReturnValue_Offset;

	private static bool GetBTTaskNodes_IsValid;

	private static IntPtr GetBTTaskNodes_FunctionAddress;

	private static int GetBTTaskNodes_ParamsSize;

	private static bool GetBTTaskNodes_BT_IsValid;

	private static FFieldAddress GetBTTaskNodes_BT_PropertyAddress;

	private static int GetBTTaskNodes_BT_Offset;

	private static bool GetBTTaskNodes_NodeData_IsValid;

	private static FFieldAddress GetBTTaskNodes_NodeData_PropertyAddress;

	private static int GetBTTaskNodes_NodeData_Offset;

	private static bool BTDecoratorOverrideChildIdx_IsValid;

	private static IntPtr BTDecoratorOverrideChildIdx_FunctionAddress;

	private static int BTDecoratorOverrideChildIdx_ParamsSize;

	private static bool BTDecoratorOverrideChildIdx_BTDecorator_IsValid;

	private static FFieldAddress BTDecoratorOverrideChildIdx_BTDecorator_PropertyAddress;

	private static int BTDecoratorOverrideChildIdx_BTDecorator_Offset;

	private static bool BTDecoratorOverrideChildIdx_NewIndex_IsValid;

	private static FFieldAddress BTDecoratorOverrideChildIdx_NewIndex_PropertyAddress;

	private static int BTDecoratorOverrideChildIdx_NewIndex_Offset;

	private static bool BTDecoratorOverrideChildIdx_ReturnValue_IsValid;

	private static FFieldAddress BTDecoratorOverrideChildIdx_ReturnValue_PropertyAddress;

	private static int BTDecoratorOverrideChildIdx_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:GetCurrentTree")]
	public unsafe static UBehaviorTree GetCurrentTree(AIController AIController)
	{
		if (!GetCurrentTree_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:GetCurrentTree");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentTree_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentTree_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, GetCurrentTree_AIController_Offset), 0, GetCurrentTree_AIController_PropertyAddress.Address, AIController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentTree_FunctionAddress, intPtr, GetCurrentTree_ParamsSize);
		return UObjectMarshaler<UBehaviorTree>.FromNative(IntPtr.Add(intPtr, GetCurrentTree_ReturnValue_Offset), 0, GetCurrentTree_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:GetCurrentBTActiveNodeInfo")]
	public unsafe static List<string> GetCurrentBTActiveNodeInfo(UBehaviorTreeComponent BehaviorTreeComp)
	{
		if (!GetCurrentBTActiveNodeInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:GetCurrentBTActiveNodeInfo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentBTActiveNodeInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentBTActiveNodeInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBehaviorTreeComponent>.ToNative(IntPtr.Add(intPtr, GetCurrentBTActiveNodeInfo_BehaviorTreeComp_Offset), 0, GetCurrentBTActiveNodeInfo_BehaviorTreeComp_PropertyAddress.Address, BehaviorTreeComp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentBTActiveNodeInfo_FunctionAddress, intPtr, GetCurrentBTActiveNodeInfo_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetCurrentBTActiveNodeInfo_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetCurrentBTActiveNodeInfo_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCurrentBTActiveNodeInfo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:GetBTTaskNodes")]
	public unsafe static void GetBTTaskNodes(UBehaviorTree BT, out FBehaviorTreeNodeData NodeData)
	{
		if (!GetBTTaskNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:GetBTTaskNodes");
			NodeData = default(FBehaviorTreeNodeData);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBTTaskNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBTTaskNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBehaviorTree>.ToNative(IntPtr.Add(intPtr, GetBTTaskNodes_BT_Offset), 0, GetBTTaskNodes_BT_PropertyAddress.Address, BT);
		NativeReflection.InitializeValue_InContainer(GetBTTaskNodes_NodeData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBTTaskNodes_FunctionAddress, intPtr, GetBTTaskNodes_ParamsSize);
		NodeData = FBehaviorTreeNodeData.FromNative(IntPtr.Add(intPtr, GetBTTaskNodes_NodeData_Offset), 0, GetBTTaskNodes_NodeData_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetBTTaskNodes_NodeData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:BTDecoratorOverrideChildIdx")]
	public unsafe static bool BTDecoratorOverrideChildIdx(UBTDecorator_BlueprintBase BTDecorator, int NewIndex)
	{
		if (!BTDecoratorOverrideChildIdx_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:BTDecoratorOverrideChildIdx");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BTDecoratorOverrideChildIdx_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BTDecoratorOverrideChildIdx_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBTDecorator_BlueprintBase>.ToNative(IntPtr.Add(intPtr, BTDecoratorOverrideChildIdx_BTDecorator_Offset), 0, BTDecoratorOverrideChildIdx_BTDecorator_PropertyAddress.Address, BTDecorator);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BTDecoratorOverrideChildIdx_NewIndex_Offset), 0, BTDecoratorOverrideChildIdx_NewIndex_PropertyAddress.Address, NewIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BTDecoratorOverrideChildIdx_FunctionAddress, intPtr, BTDecoratorOverrideChildIdx_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BTDecoratorOverrideChildIdx_ReturnValue_Offset), 0, BTDecoratorOverrideChildIdx_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_BehaviorTreeFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_BehaviorTreeFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_BehaviorTreeFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib");
		GetCurrentTree_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentTree");
		GetCurrentTree_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentTree_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentTree_AIController_PropertyAddress, GetCurrentTree_FunctionAddress, "AIController");
		GetCurrentTree_AIController_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentTree_FunctionAddress, "AIController");
		GetCurrentTree_AIController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentTree_FunctionAddress, "AIController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentTree_ReturnValue_PropertyAddress, GetCurrentTree_FunctionAddress, "ReturnValue");
		GetCurrentTree_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentTree_FunctionAddress, "ReturnValue");
		GetCurrentTree_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentTree_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentTree_IsValid = GetCurrentTree_FunctionAddress != IntPtr.Zero && GetCurrentTree_AIController_IsValid && GetCurrentTree_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:GetCurrentTree", GetCurrentTree_IsValid);
		GetCurrentBTActiveNodeInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentBTActiveNodeInfo");
		GetCurrentBTActiveNodeInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentBTActiveNodeInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentBTActiveNodeInfo_BehaviorTreeComp_PropertyAddress, GetCurrentBTActiveNodeInfo_FunctionAddress, "BehaviorTreeComp");
		GetCurrentBTActiveNodeInfo_BehaviorTreeComp_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentBTActiveNodeInfo_FunctionAddress, "BehaviorTreeComp");
		GetCurrentBTActiveNodeInfo_BehaviorTreeComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentBTActiveNodeInfo_FunctionAddress, "BehaviorTreeComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentBTActiveNodeInfo_ReturnValue_PropertyAddress, GetCurrentBTActiveNodeInfo_FunctionAddress, "ReturnValue");
		GetCurrentBTActiveNodeInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentBTActiveNodeInfo_FunctionAddress, "ReturnValue");
		GetCurrentBTActiveNodeInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentBTActiveNodeInfo_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCurrentBTActiveNodeInfo_IsValid = GetCurrentBTActiveNodeInfo_FunctionAddress != IntPtr.Zero && GetCurrentBTActiveNodeInfo_BehaviorTreeComp_IsValid && GetCurrentBTActiveNodeInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:GetCurrentBTActiveNodeInfo", GetCurrentBTActiveNodeInfo_IsValid);
		GetBTTaskNodes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBTTaskNodes");
		GetBTTaskNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBTTaskNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBTTaskNodes_BT_PropertyAddress, GetBTTaskNodes_FunctionAddress, "BT");
		GetBTTaskNodes_BT_Offset = NativeReflectionCached.GetPropertyOffset(GetBTTaskNodes_FunctionAddress, "BT");
		GetBTTaskNodes_BT_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBTTaskNodes_FunctionAddress, "BT", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBTTaskNodes_NodeData_PropertyAddress, GetBTTaskNodes_FunctionAddress, "NodeData");
		GetBTTaskNodes_NodeData_Offset = NativeReflectionCached.GetPropertyOffset(GetBTTaskNodes_FunctionAddress, "NodeData");
		GetBTTaskNodes_NodeData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBTTaskNodes_FunctionAddress, "NodeData", Classes.FStructProperty);
		GetBTTaskNodes_IsValid = GetBTTaskNodes_FunctionAddress != IntPtr.Zero && GetBTTaskNodes_BT_IsValid && GetBTTaskNodes_NodeData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:GetBTTaskNodes", GetBTTaskNodes_IsValid);
		BTDecoratorOverrideChildIdx_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BTDecoratorOverrideChildIdx");
		BTDecoratorOverrideChildIdx_ParamsSize = NativeReflection.GetFunctionParamsSize(BTDecoratorOverrideChildIdx_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BTDecoratorOverrideChildIdx_BTDecorator_PropertyAddress, BTDecoratorOverrideChildIdx_FunctionAddress, "BTDecorator");
		BTDecoratorOverrideChildIdx_BTDecorator_Offset = NativeReflectionCached.GetPropertyOffset(BTDecoratorOverrideChildIdx_FunctionAddress, "BTDecorator");
		BTDecoratorOverrideChildIdx_BTDecorator_IsValid = NativeReflectionCached.ValidatePropertyClass(BTDecoratorOverrideChildIdx_FunctionAddress, "BTDecorator", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BTDecoratorOverrideChildIdx_NewIndex_PropertyAddress, BTDecoratorOverrideChildIdx_FunctionAddress, "NewIndex");
		BTDecoratorOverrideChildIdx_NewIndex_Offset = NativeReflectionCached.GetPropertyOffset(BTDecoratorOverrideChildIdx_FunctionAddress, "NewIndex");
		BTDecoratorOverrideChildIdx_NewIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(BTDecoratorOverrideChildIdx_FunctionAddress, "NewIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BTDecoratorOverrideChildIdx_ReturnValue_PropertyAddress, BTDecoratorOverrideChildIdx_FunctionAddress, "ReturnValue");
		BTDecoratorOverrideChildIdx_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BTDecoratorOverrideChildIdx_FunctionAddress, "ReturnValue");
		BTDecoratorOverrideChildIdx_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BTDecoratorOverrideChildIdx_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BTDecoratorOverrideChildIdx_IsValid = BTDecoratorOverrideChildIdx_FunctionAddress != IntPtr.Zero && BTDecoratorOverrideChildIdx_BTDecorator_IsValid && BTDecoratorOverrideChildIdx_NewIndex_IsValid && BTDecoratorOverrideChildIdx_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_BehaviorTreeFuncLib:BTDecoratorOverrideChildIdx", BTDecoratorOverrideChildIdx_IsValid);
	}
}
