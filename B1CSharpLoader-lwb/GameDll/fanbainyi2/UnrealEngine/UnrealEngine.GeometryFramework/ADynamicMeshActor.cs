using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GeometryFramework.DynamicMeshActor", "GeometryFramework", UnrealModuleType.Engine)]
public class ADynamicMeshActor : AActor
{
	private static bool DynamicMeshComponent_IsValid;

	private static int DynamicMeshComponent_Offset;

	private static bool EnableComputeMeshPool_IsValid;

	private static FFieldAddress EnableComputeMeshPool_PropertyAddress;

	private static int EnableComputeMeshPool_Offset;

	private static bool ReleaseComputeMesh_IsValid;

	private static IntPtr ReleaseComputeMesh_FunctionAddress;

	private static int ReleaseComputeMesh_ParamsSize;

	private static bool ReleaseComputeMesh_Mesh_IsValid;

	private static FFieldAddress ReleaseComputeMesh_Mesh_PropertyAddress;

	private static int ReleaseComputeMesh_Mesh_Offset;

	private static bool ReleaseComputeMesh_ReturnValue_IsValid;

	private static FFieldAddress ReleaseComputeMesh_ReturnValue_PropertyAddress;

	private static int ReleaseComputeMesh_ReturnValue_Offset;

	private static bool ReleaseAllComputeMeshes_IsValid;

	private static IntPtr ReleaseAllComputeMeshes_FunctionAddress;

	private static int ReleaseAllComputeMeshes_ParamsSize;

	private static bool GetDynamicMeshComponent_IsValid;

	private static IntPtr GetDynamicMeshComponent_FunctionAddress;

	private static int GetDynamicMeshComponent_ParamsSize;

	private static bool GetDynamicMeshComponent_ReturnValue_IsValid;

	private static FFieldAddress GetDynamicMeshComponent_ReturnValue_PropertyAddress;

	private static int GetDynamicMeshComponent_ReturnValue_Offset;

	private static bool GetComputeMeshPool_IsValid;

	private static IntPtr GetComputeMeshPool_FunctionAddress;

	private static int GetComputeMeshPool_ParamsSize;

	private static bool GetComputeMeshPool_ReturnValue_IsValid;

	private static FFieldAddress GetComputeMeshPool_ReturnValue_PropertyAddress;

	private static int GetComputeMeshPool_ReturnValue_Offset;

	private static bool FreeAllComputeMeshes_IsValid;

	private static IntPtr FreeAllComputeMeshes_FunctionAddress;

	private static int FreeAllComputeMeshes_ParamsSize;

	private static bool AllocateComputeMesh_IsValid;

	private static IntPtr AllocateComputeMesh_FunctionAddress;

	private static int AllocateComputeMesh_ParamsSize;

	private static bool AllocateComputeMesh_ReturnValue_IsValid;

	private static FFieldAddress AllocateComputeMesh_ReturnValue_PropertyAddress;

	private static int AllocateComputeMesh_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)12393764862165533uL)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshActor:DynamicMeshComponent")]
	protected UDynamicMeshComponent DynamicMeshComponent
	{
		get
		{
			CheckDestroyed();
			if (!DynamicMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.DynamicMeshActor:DynamicMeshComponent");
				return null;
			}
			return UObjectMarshaler<UDynamicMeshComponent>.FromNative(IntPtr.Add(base.Address, DynamicMeshComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DynamicMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.DynamicMeshActor:DynamicMeshComponent");
			}
			else
			{
				UObjectMarshaler<UDynamicMeshComponent>.ToNative(IntPtr.Add(base.Address, DynamicMeshComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshActor:bEnableComputeMeshPool")]
	public bool EnableComputeMeshPool
	{
		get
		{
			CheckDestroyed();
			if (!EnableComputeMeshPool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.DynamicMeshActor:bEnableComputeMeshPool");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableComputeMeshPool_Offset), 0, EnableComputeMeshPool_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableComputeMeshPool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.DynamicMeshActor:bEnableComputeMeshPool");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableComputeMeshPool_Offset), 0, EnableComputeMeshPool_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshActor:ReleaseComputeMesh")]
	public unsafe bool ReleaseComputeMesh(UDynamicMesh Mesh)
	{
		CheckDestroyed();
		if (!ReleaseComputeMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshActor:ReleaseComputeMesh");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseComputeMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseComputeMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ReleaseComputeMesh_Mesh_Offset), 0, ReleaseComputeMesh_Mesh_PropertyAddress.Address, Mesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReleaseComputeMesh_FunctionAddress, intPtr, ReleaseComputeMesh_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReleaseComputeMesh_ReturnValue_Offset), 0, ReleaseComputeMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshActor:ReleaseAllComputeMeshes")]
	public unsafe void ReleaseAllComputeMeshes()
	{
		CheckDestroyed();
		if (!ReleaseAllComputeMeshes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshActor:ReleaseAllComputeMeshes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseAllComputeMeshes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseAllComputeMeshes_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReleaseAllComputeMeshes_FunctionAddress, argsSize: ReleaseAllComputeMeshes_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshActor:GetDynamicMeshComponent")]
	public unsafe UDynamicMeshComponent GetDynamicMeshComponent()
	{
		CheckDestroyed();
		if (!GetDynamicMeshComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshActor:GetDynamicMeshComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDynamicMeshComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDynamicMeshComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDynamicMeshComponent_FunctionAddress, intPtr, GetDynamicMeshComponent_ParamsSize);
		return UObjectMarshaler<UDynamicMeshComponent>.FromNative(IntPtr.Add(intPtr, GetDynamicMeshComponent_ReturnValue_Offset), 0, GetDynamicMeshComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshActor:GetComputeMeshPool")]
	public unsafe UDynamicMeshPool GetComputeMeshPool()
	{
		CheckDestroyed();
		if (!GetComputeMeshPool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshActor:GetComputeMeshPool");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComputeMeshPool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComputeMeshPool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetComputeMeshPool_FunctionAddress, intPtr, GetComputeMeshPool_ParamsSize);
		return UObjectMarshaler<UDynamicMeshPool>.FromNative(IntPtr.Add(intPtr, GetComputeMeshPool_ReturnValue_Offset), 0, GetComputeMeshPool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshActor:FreeAllComputeMeshes")]
	public unsafe void FreeAllComputeMeshes()
	{
		CheckDestroyed();
		if (!FreeAllComputeMeshes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshActor:FreeAllComputeMeshes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FreeAllComputeMeshes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FreeAllComputeMeshes_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FreeAllComputeMeshes_FunctionAddress, argsSize: FreeAllComputeMeshes_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshActor:AllocateComputeMesh")]
	public unsafe UDynamicMesh AllocateComputeMesh()
	{
		CheckDestroyed();
		if (!AllocateComputeMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshActor:AllocateComputeMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AllocateComputeMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AllocateComputeMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AllocateComputeMesh_FunctionAddress, intPtr, AllocateComputeMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AllocateComputeMesh_ReturnValue_Offset), 0, AllocateComputeMesh_ReturnValue_PropertyAddress.Address);
	}

	static ADynamicMeshActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ADynamicMeshActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ADynamicMeshActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryFramework.DynamicMeshActor");
		DynamicMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicMeshComponent");
		DynamicMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableComputeMeshPool_PropertyAddress, intPtr, "bEnableComputeMeshPool");
		EnableComputeMeshPool_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableComputeMeshPool");
		EnableComputeMeshPool_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableComputeMeshPool", Classes.FBoolProperty);
		ReleaseComputeMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReleaseComputeMesh");
		ReleaseComputeMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseComputeMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReleaseComputeMesh_Mesh_PropertyAddress, ReleaseComputeMesh_FunctionAddress, "Mesh");
		ReleaseComputeMesh_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseComputeMesh_FunctionAddress, "Mesh");
		ReleaseComputeMesh_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseComputeMesh_FunctionAddress, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReleaseComputeMesh_ReturnValue_PropertyAddress, ReleaseComputeMesh_FunctionAddress, "ReturnValue");
		ReleaseComputeMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseComputeMesh_FunctionAddress, "ReturnValue");
		ReleaseComputeMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseComputeMesh_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReleaseComputeMesh_IsValid = ReleaseComputeMesh_FunctionAddress != IntPtr.Zero && ReleaseComputeMesh_Mesh_IsValid && ReleaseComputeMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshActor:ReleaseComputeMesh", ReleaseComputeMesh_IsValid);
		ReleaseAllComputeMeshes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReleaseAllComputeMeshes");
		ReleaseAllComputeMeshes_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseAllComputeMeshes_FunctionAddress);
		ReleaseAllComputeMeshes_IsValid = ReleaseAllComputeMeshes_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshActor:ReleaseAllComputeMeshes", ReleaseAllComputeMeshes_IsValid);
		GetDynamicMeshComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDynamicMeshComponent");
		GetDynamicMeshComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDynamicMeshComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDynamicMeshComponent_ReturnValue_PropertyAddress, GetDynamicMeshComponent_FunctionAddress, "ReturnValue");
		GetDynamicMeshComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDynamicMeshComponent_FunctionAddress, "ReturnValue");
		GetDynamicMeshComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDynamicMeshComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDynamicMeshComponent_IsValid = GetDynamicMeshComponent_FunctionAddress != IntPtr.Zero && GetDynamicMeshComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshActor:GetDynamicMeshComponent", GetDynamicMeshComponent_IsValid);
		GetComputeMeshPool_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetComputeMeshPool");
		GetComputeMeshPool_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComputeMeshPool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetComputeMeshPool_ReturnValue_PropertyAddress, GetComputeMeshPool_FunctionAddress, "ReturnValue");
		GetComputeMeshPool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetComputeMeshPool_FunctionAddress, "ReturnValue");
		GetComputeMeshPool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComputeMeshPool_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetComputeMeshPool_IsValid = GetComputeMeshPool_FunctionAddress != IntPtr.Zero && GetComputeMeshPool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshActor:GetComputeMeshPool", GetComputeMeshPool_IsValid);
		FreeAllComputeMeshes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FreeAllComputeMeshes");
		FreeAllComputeMeshes_ParamsSize = NativeReflection.GetFunctionParamsSize(FreeAllComputeMeshes_FunctionAddress);
		FreeAllComputeMeshes_IsValid = FreeAllComputeMeshes_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshActor:FreeAllComputeMeshes", FreeAllComputeMeshes_IsValid);
		AllocateComputeMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AllocateComputeMesh");
		AllocateComputeMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(AllocateComputeMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AllocateComputeMesh_ReturnValue_PropertyAddress, AllocateComputeMesh_FunctionAddress, "ReturnValue");
		AllocateComputeMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AllocateComputeMesh_FunctionAddress, "ReturnValue");
		AllocateComputeMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AllocateComputeMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AllocateComputeMesh_IsValid = AllocateComputeMesh_FunctionAddress != IntPtr.Zero && AllocateComputeMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshActor:AllocateComputeMesh", AllocateComputeMesh_IsValid);
	}
}
