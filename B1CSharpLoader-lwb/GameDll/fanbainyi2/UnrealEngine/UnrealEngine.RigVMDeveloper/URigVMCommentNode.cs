using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMCommentNode", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMCommentNode : URigVMNode
{
	private static bool GetCommentText_IsValid;

	private static IntPtr GetCommentText_FunctionAddress;

	private static int GetCommentText_ParamsSize;

	private static bool GetCommentText_ReturnValue_IsValid;

	private static FFieldAddress GetCommentText_ReturnValue_PropertyAddress;

	private static int GetCommentText_ReturnValue_Offset;

	private static bool GetCommentFontSize_IsValid;

	private static IntPtr GetCommentFontSize_FunctionAddress;

	private static int GetCommentFontSize_ParamsSize;

	private static bool GetCommentFontSize_ReturnValue_IsValid;

	private static FFieldAddress GetCommentFontSize_ReturnValue_PropertyAddress;

	private static int GetCommentFontSize_ReturnValue_Offset;

	private static bool GetCommentColorBubble_IsValid;

	private static IntPtr GetCommentColorBubble_FunctionAddress;

	private static int GetCommentColorBubble_ParamsSize;

	private static bool GetCommentColorBubble_ReturnValue_IsValid;

	private static FFieldAddress GetCommentColorBubble_ReturnValue_PropertyAddress;

	private static int GetCommentColorBubble_ReturnValue_Offset;

	private static bool GetCommentBubbleVisible_IsValid;

	private static IntPtr GetCommentBubbleVisible_FunctionAddress;

	private static int GetCommentBubbleVisible_ParamsSize;

	private static bool GetCommentBubbleVisible_ReturnValue_IsValid;

	private static FFieldAddress GetCommentBubbleVisible_ReturnValue_PropertyAddress;

	private static int GetCommentBubbleVisible_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentText")]
	public unsafe string GetCommentText()
	{
		CheckDestroyed();
		if (!GetCommentText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCommentText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCommentText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCommentText_FunctionAddress, intPtr, GetCommentText_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCommentText_ReturnValue_Offset), 0, GetCommentText_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCommentText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentFontSize")]
	public unsafe int GetCommentFontSize()
	{
		CheckDestroyed();
		if (!GetCommentFontSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentFontSize");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCommentFontSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCommentFontSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCommentFontSize_FunctionAddress, intPtr, GetCommentFontSize_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCommentFontSize_ReturnValue_Offset), 0, GetCommentFontSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentColorBubble")]
	public unsafe bool GetCommentColorBubble()
	{
		CheckDestroyed();
		if (!GetCommentColorBubble_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentColorBubble");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCommentColorBubble_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCommentColorBubble_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCommentColorBubble_FunctionAddress, intPtr, GetCommentColorBubble_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCommentColorBubble_ReturnValue_Offset), 0, GetCommentColorBubble_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentBubbleVisible")]
	public unsafe bool GetCommentBubbleVisible()
	{
		CheckDestroyed();
		if (!GetCommentBubbleVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentBubbleVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCommentBubbleVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCommentBubbleVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCommentBubbleVisible_FunctionAddress, intPtr, GetCommentBubbleVisible_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCommentBubbleVisible_ReturnValue_Offset), 0, GetCommentBubbleVisible_ReturnValue_PropertyAddress.Address);
	}

	static URigVMCommentNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMCommentNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMCommentNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMCommentNode");
		GetCommentText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCommentText");
		GetCommentText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCommentText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCommentText_ReturnValue_PropertyAddress, GetCommentText_FunctionAddress, "ReturnValue");
		GetCommentText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCommentText_FunctionAddress, "ReturnValue");
		GetCommentText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCommentText_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCommentText_IsValid = GetCommentText_FunctionAddress != IntPtr.Zero && GetCommentText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentText", GetCommentText_IsValid);
		GetCommentFontSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCommentFontSize");
		GetCommentFontSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCommentFontSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCommentFontSize_ReturnValue_PropertyAddress, GetCommentFontSize_FunctionAddress, "ReturnValue");
		GetCommentFontSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCommentFontSize_FunctionAddress, "ReturnValue");
		GetCommentFontSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCommentFontSize_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCommentFontSize_IsValid = GetCommentFontSize_FunctionAddress != IntPtr.Zero && GetCommentFontSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentFontSize", GetCommentFontSize_IsValid);
		GetCommentColorBubble_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCommentColorBubble");
		GetCommentColorBubble_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCommentColorBubble_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCommentColorBubble_ReturnValue_PropertyAddress, GetCommentColorBubble_FunctionAddress, "ReturnValue");
		GetCommentColorBubble_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCommentColorBubble_FunctionAddress, "ReturnValue");
		GetCommentColorBubble_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCommentColorBubble_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCommentColorBubble_IsValid = GetCommentColorBubble_FunctionAddress != IntPtr.Zero && GetCommentColorBubble_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentColorBubble", GetCommentColorBubble_IsValid);
		GetCommentBubbleVisible_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCommentBubbleVisible");
		GetCommentBubbleVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCommentBubbleVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCommentBubbleVisible_ReturnValue_PropertyAddress, GetCommentBubbleVisible_FunctionAddress, "ReturnValue");
		GetCommentBubbleVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCommentBubbleVisible_FunctionAddress, "ReturnValue");
		GetCommentBubbleVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCommentBubbleVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCommentBubbleVisible_IsValid = GetCommentBubbleVisible_FunctionAddress != IntPtr.Zero && GetCommentBubbleVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMCommentNode:GetCommentBubbleVisible", GetCommentBubbleVisible_IsValid);
	}
}
