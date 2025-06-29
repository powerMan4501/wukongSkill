using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMLink", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMLink : UObject
{
	private static bool GetTargetPin_IsValid;

	private static IntPtr GetTargetPin_FunctionAddress;

	private static int GetTargetPin_ParamsSize;

	private static bool GetTargetPin_ReturnValue_IsValid;

	private static FFieldAddress GetTargetPin_ReturnValue_PropertyAddress;

	private static int GetTargetPin_ReturnValue_Offset;

	private static bool GetSourcePin_IsValid;

	private static IntPtr GetSourcePin_FunctionAddress;

	private static int GetSourcePin_ParamsSize;

	private static bool GetSourcePin_ReturnValue_IsValid;

	private static FFieldAddress GetSourcePin_ReturnValue_PropertyAddress;

	private static int GetSourcePin_ReturnValue_Offset;

	private static bool GetPinPathRepresentation_IsValid;

	private static IntPtr GetPinPathRepresentation_FunctionAddress;

	private static int GetPinPathRepresentation_ParamsSize;

	private static bool GetPinPathRepresentation_ReturnValue_IsValid;

	private static FFieldAddress GetPinPathRepresentation_ReturnValue_PropertyAddress;

	private static int GetPinPathRepresentation_ReturnValue_Offset;

	private static bool GetLinkIndex_IsValid;

	private static IntPtr GetLinkIndex_FunctionAddress;

	private static int GetLinkIndex_ParamsSize;

	private static bool GetLinkIndex_ReturnValue_IsValid;

	private static FFieldAddress GetLinkIndex_ReturnValue_PropertyAddress;

	private static int GetLinkIndex_ReturnValue_Offset;

	private static bool GetGraph_IsValid;

	private static IntPtr GetGraph_FunctionAddress;

	private static int GetGraph_ParamsSize;

	private static bool GetGraph_ReturnValue_IsValid;

	private static FFieldAddress GetGraph_ReturnValue_PropertyAddress;

	private static int GetGraph_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMLink:GetTargetPin")]
	public unsafe URigVMPin GetTargetPin()
	{
		CheckDestroyed();
		if (!GetTargetPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMLink:GetTargetPin");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTargetPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTargetPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTargetPin_FunctionAddress, intPtr, GetTargetPin_ParamsSize);
		return UObjectMarshaler<URigVMPin>.FromNative(IntPtr.Add(intPtr, GetTargetPin_ReturnValue_Offset), 0, GetTargetPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMLink:GetSourcePin")]
	public unsafe URigVMPin GetSourcePin()
	{
		CheckDestroyed();
		if (!GetSourcePin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMLink:GetSourcePin");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSourcePin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSourcePin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSourcePin_FunctionAddress, intPtr, GetSourcePin_ParamsSize);
		return UObjectMarshaler<URigVMPin>.FromNative(IntPtr.Add(intPtr, GetSourcePin_ReturnValue_Offset), 0, GetSourcePin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMLink:GetPinPathRepresentation")]
	public unsafe string GetPinPathRepresentation()
	{
		CheckDestroyed();
		if (!GetPinPathRepresentation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMLink:GetPinPathRepresentation");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPinPathRepresentation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPinPathRepresentation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPinPathRepresentation_FunctionAddress, intPtr, GetPinPathRepresentation_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPinPathRepresentation_ReturnValue_Offset), 0, GetPinPathRepresentation_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPinPathRepresentation_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMLink:GetLinkIndex")]
	public unsafe int GetLinkIndex()
	{
		CheckDestroyed();
		if (!GetLinkIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMLink:GetLinkIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinkIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinkIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLinkIndex_FunctionAddress, intPtr, GetLinkIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLinkIndex_ReturnValue_Offset), 0, GetLinkIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMLink:GetGraph")]
	public unsafe URigVMGraph GetGraph()
	{
		CheckDestroyed();
		if (!GetGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMLink:GetGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGraph_FunctionAddress, intPtr, GetGraph_ParamsSize);
		return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(intPtr, GetGraph_ReturnValue_Offset), 0, GetGraph_ReturnValue_PropertyAddress.Address);
	}

	static URigVMLink()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMLink)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMLink));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMLink");
		GetTargetPin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTargetPin");
		GetTargetPin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTargetPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTargetPin_ReturnValue_PropertyAddress, GetTargetPin_FunctionAddress, "ReturnValue");
		GetTargetPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTargetPin_FunctionAddress, "ReturnValue");
		GetTargetPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTargetPin_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTargetPin_IsValid = GetTargetPin_FunctionAddress != IntPtr.Zero && GetTargetPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMLink:GetTargetPin", GetTargetPin_IsValid);
		GetSourcePin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSourcePin");
		GetSourcePin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSourcePin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSourcePin_ReturnValue_PropertyAddress, GetSourcePin_FunctionAddress, "ReturnValue");
		GetSourcePin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSourcePin_FunctionAddress, "ReturnValue");
		GetSourcePin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSourcePin_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSourcePin_IsValid = GetSourcePin_FunctionAddress != IntPtr.Zero && GetSourcePin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMLink:GetSourcePin", GetSourcePin_IsValid);
		GetPinPathRepresentation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPinPathRepresentation");
		GetPinPathRepresentation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPinPathRepresentation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPinPathRepresentation_ReturnValue_PropertyAddress, GetPinPathRepresentation_FunctionAddress, "ReturnValue");
		GetPinPathRepresentation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPinPathRepresentation_FunctionAddress, "ReturnValue");
		GetPinPathRepresentation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPinPathRepresentation_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetPinPathRepresentation_IsValid = GetPinPathRepresentation_FunctionAddress != IntPtr.Zero && GetPinPathRepresentation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMLink:GetPinPathRepresentation", GetPinPathRepresentation_IsValid);
		GetLinkIndex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLinkIndex");
		GetLinkIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinkIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinkIndex_ReturnValue_PropertyAddress, GetLinkIndex_FunctionAddress, "ReturnValue");
		GetLinkIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinkIndex_FunctionAddress, "ReturnValue");
		GetLinkIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinkIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLinkIndex_IsValid = GetLinkIndex_FunctionAddress != IntPtr.Zero && GetLinkIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMLink:GetLinkIndex", GetLinkIndex_IsValid);
		GetGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGraph");
		GetGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraph_ReturnValue_PropertyAddress, GetGraph_FunctionAddress, "ReturnValue");
		GetGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGraph_FunctionAddress, "ReturnValue");
		GetGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGraph_IsValid = GetGraph_FunctionAddress != IntPtr.Zero && GetGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMLink:GetGraph", GetGraph_IsValid);
	}
}
