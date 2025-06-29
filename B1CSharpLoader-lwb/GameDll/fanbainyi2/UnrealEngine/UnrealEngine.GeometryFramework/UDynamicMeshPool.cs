using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[UClass(Flags = (ClassFlags)810549416uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GeometryFramework.DynamicMeshPool", "GeometryFramework", UnrealModuleType.Engine)]
public class UDynamicMeshPool : UObject
{
	private static bool ReturnMesh_IsValid;

	private static IntPtr ReturnMesh_FunctionAddress;

	private static int ReturnMesh_ParamsSize;

	private static bool ReturnMesh_Mesh_IsValid;

	private static FFieldAddress ReturnMesh_Mesh_PropertyAddress;

	private static int ReturnMesh_Mesh_Offset;

	private static bool ReturnAllMeshes_IsValid;

	private static IntPtr ReturnAllMeshes_FunctionAddress;

	private static int ReturnAllMeshes_ParamsSize;

	private static bool RequestMesh_IsValid;

	private static IntPtr RequestMesh_FunctionAddress;

	private static int RequestMesh_ParamsSize;

	private static bool RequestMesh_ReturnValue_IsValid;

	private static FFieldAddress RequestMesh_ReturnValue_PropertyAddress;

	private static int RequestMesh_ReturnValue_Offset;

	private static bool FreeAllMeshes_IsValid;

	private static IntPtr FreeAllMeshes_FunctionAddress;

	private static int FreeAllMeshes_ParamsSize;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshPool:ReturnMesh")]
	public unsafe void ReturnMesh(UDynamicMesh Mesh)
	{
		CheckDestroyed();
		if (!ReturnMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshPool:ReturnMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReturnMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReturnMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ReturnMesh_Mesh_Offset), 0, ReturnMesh_Mesh_PropertyAddress.Address, Mesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReturnMesh_FunctionAddress, intPtr, ReturnMesh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshPool:ReturnAllMeshes")]
	public unsafe void ReturnAllMeshes()
	{
		CheckDestroyed();
		if (!ReturnAllMeshes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshPool:ReturnAllMeshes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReturnAllMeshes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReturnAllMeshes_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReturnAllMeshes_FunctionAddress, argsSize: ReturnAllMeshes_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshPool:RequestMesh")]
	public unsafe UDynamicMesh RequestMesh()
	{
		CheckDestroyed();
		if (!RequestMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshPool:RequestMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, RequestMesh_FunctionAddress, intPtr, RequestMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, RequestMesh_ReturnValue_Offset), 0, RequestMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshPool:FreeAllMeshes")]
	public unsafe void FreeAllMeshes()
	{
		CheckDestroyed();
		if (!FreeAllMeshes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshPool:FreeAllMeshes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FreeAllMeshes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FreeAllMeshes_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FreeAllMeshes_FunctionAddress, argsSize: FreeAllMeshes_ParamsSize);
	}

	static UDynamicMeshPool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDynamicMeshPool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDynamicMeshPool));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/GeometryFramework.DynamicMeshPool");
		ReturnMesh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReturnMesh");
		ReturnMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ReturnMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReturnMesh_Mesh_PropertyAddress, ReturnMesh_FunctionAddress, "Mesh");
		ReturnMesh_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(ReturnMesh_FunctionAddress, "Mesh");
		ReturnMesh_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ReturnMesh_FunctionAddress, "Mesh", Classes.FObjectProperty);
		ReturnMesh_IsValid = ReturnMesh_FunctionAddress != IntPtr.Zero && ReturnMesh_Mesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshPool:ReturnMesh", ReturnMesh_IsValid);
		ReturnAllMeshes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReturnAllMeshes");
		ReturnAllMeshes_ParamsSize = NativeReflection.GetFunctionParamsSize(ReturnAllMeshes_FunctionAddress);
		ReturnAllMeshes_IsValid = ReturnAllMeshes_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshPool:ReturnAllMeshes", ReturnAllMeshes_IsValid);
		RequestMesh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RequestMesh");
		RequestMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestMesh_ReturnValue_PropertyAddress, RequestMesh_FunctionAddress, "ReturnValue");
		RequestMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RequestMesh_FunctionAddress, "ReturnValue");
		RequestMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		RequestMesh_IsValid = RequestMesh_FunctionAddress != IntPtr.Zero && RequestMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshPool:RequestMesh", RequestMesh_IsValid);
		FreeAllMeshes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FreeAllMeshes");
		FreeAllMeshes_ParamsSize = NativeReflection.GetFunctionParamsSize(FreeAllMeshes_FunctionAddress);
		FreeAllMeshes_IsValid = FreeAllMeshes_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshPool:FreeAllMeshes", FreeAllMeshes_IsValid);
	}
}
