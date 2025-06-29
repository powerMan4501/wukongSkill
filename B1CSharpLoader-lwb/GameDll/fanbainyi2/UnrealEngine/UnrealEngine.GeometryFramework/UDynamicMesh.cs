using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GeometryFramework.DynamicMesh", "GeometryFramework", UnrealModuleType.Engine)]
public class UDynamicMesh : UObject, IMeshVertexCommandChangeTarget, IInterface, IMeshCommandChangeTarget, IMeshReplacementCommandChangeTarget
{
	private static bool MeshModifiedBPEvent_IsValid;

	private static int MeshModifiedBPEvent_Offset;

	private FOnDynamicMeshModifiedBP MeshModifiedBPEvent_DelegateCached;

	private static bool ResetToCube_IsValid;

	private static IntPtr ResetToCube_FunctionAddress;

	private static int ResetToCube_ParamsSize;

	private static bool ResetToCube_ReturnValue_IsValid;

	private static FFieldAddress ResetToCube_ReturnValue_PropertyAddress;

	private static int ResetToCube_ReturnValue_Offset;

	private static bool Reset_IsValid;

	private static IntPtr Reset_FunctionAddress;

	private static int Reset_ParamsSize;

	private static bool Reset_ReturnValue_IsValid;

	private static FFieldAddress Reset_ReturnValue_PropertyAddress;

	private static int Reset_ReturnValue_Offset;

	private static bool IsEmpty_IsValid;

	private static IntPtr IsEmpty_FunctionAddress;

	private static int IsEmpty_ParamsSize;

	private static bool IsEmpty_ReturnValue_IsValid;

	private static FFieldAddress IsEmpty_ReturnValue_PropertyAddress;

	private static int IsEmpty_ReturnValue_Offset;

	private static bool GetTriangleCount_IsValid;

	private static IntPtr GetTriangleCount_FunctionAddress;

	private static int GetTriangleCount_ParamsSize;

	private static bool GetTriangleCount_ReturnValue_IsValid;

	private static FFieldAddress GetTriangleCount_ReturnValue_PropertyAddress;

	private static int GetTriangleCount_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GeometryFramework.DynamicMesh:MeshModifiedBPEvent")]
	public FOnDynamicMeshModifiedBP MeshModifiedBPEvent
	{
		get
		{
			CheckDestroyed();
			if (!MeshModifiedBPEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.DynamicMesh:MeshModifiedBPEvent");
				return new FOnDynamicMeshModifiedBP();
			}
			if (MeshModifiedBPEvent_DelegateCached == null)
			{
				MeshModifiedBPEvent_DelegateCached = new FOnDynamicMeshModifiedBP();
				MeshModifiedBPEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, MeshModifiedBPEvent_Offset));
			}
			return MeshModifiedBPEvent_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMesh:ResetToCube")]
	public unsafe UDynamicMesh ResetToCube()
	{
		CheckDestroyed();
		if (!ResetToCube_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMesh:ResetToCube");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetToCube_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetToCube_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResetToCube_FunctionAddress, intPtr, ResetToCube_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ResetToCube_ReturnValue_Offset), 0, ResetToCube_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMesh:Reset")]
	public unsafe UDynamicMesh Reset()
	{
		CheckDestroyed();
		if (!Reset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMesh:Reset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Reset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Reset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Reset_FunctionAddress, intPtr, Reset_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, Reset_ReturnValue_Offset), 0, Reset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMesh:IsEmpty")]
	public unsafe bool IsEmpty()
	{
		CheckDestroyed();
		if (!IsEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMesh:IsEmpty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEmpty_FunctionAddress, intPtr, IsEmpty_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEmpty_ReturnValue_Offset), 0, IsEmpty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMesh:GetTriangleCount")]
	public unsafe int GetTriangleCount()
	{
		CheckDestroyed();
		if (!GetTriangleCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMesh:GetTriangleCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTriangleCount_FunctionAddress, intPtr, GetTriangleCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTriangleCount_ReturnValue_Offset), 0, GetTriangleCount_ReturnValue_PropertyAddress.Address);
	}

	static UDynamicMesh()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDynamicMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDynamicMesh));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryFramework.DynamicMesh");
		MeshModifiedBPEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshModifiedBPEvent");
		MeshModifiedBPEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshModifiedBPEvent", Classes.FMulticastDelegateProperty);
		ResetToCube_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetToCube");
		ResetToCube_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetToCube_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetToCube_ReturnValue_PropertyAddress, ResetToCube_FunctionAddress, "ReturnValue");
		ResetToCube_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ResetToCube_FunctionAddress, "ReturnValue");
		ResetToCube_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetToCube_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ResetToCube_IsValid = ResetToCube_FunctionAddress != IntPtr.Zero && ResetToCube_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMesh:ResetToCube", ResetToCube_IsValid);
		Reset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Reset");
		Reset_ParamsSize = NativeReflection.GetFunctionParamsSize(Reset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Reset_ReturnValue_PropertyAddress, Reset_FunctionAddress, "ReturnValue");
		Reset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Reset_FunctionAddress, "ReturnValue");
		Reset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Reset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Reset_IsValid = Reset_FunctionAddress != IntPtr.Zero && Reset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMesh:Reset", Reset_IsValid);
		IsEmpty_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsEmpty");
		IsEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEmpty_ReturnValue_PropertyAddress, IsEmpty_FunctionAddress, "ReturnValue");
		IsEmpty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEmpty_FunctionAddress, "ReturnValue");
		IsEmpty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEmpty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEmpty_IsValid = IsEmpty_FunctionAddress != IntPtr.Zero && IsEmpty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMesh:IsEmpty", IsEmpty_IsValid);
		GetTriangleCount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTriangleCount");
		GetTriangleCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleCount_ReturnValue_PropertyAddress, GetTriangleCount_FunctionAddress, "ReturnValue");
		GetTriangleCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleCount_FunctionAddress, "ReturnValue");
		GetTriangleCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTriangleCount_IsValid = GetTriangleCount_FunctionAddress != IntPtr.Zero && GetTriangleCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMesh:GetTriangleCount", GetTriangleCount_IsValid);
	}
}
