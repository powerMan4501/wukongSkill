using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CustomMeshComponent;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/CustomMeshComponent.CustomMeshComponent", "CustomMeshComponent", UnrealModuleType.EnginePlugin)]
public class UCustomMeshComponent : UMeshComponent
{
	private static bool SetCustomMeshTriangles_IsValid;

	private static IntPtr SetCustomMeshTriangles_FunctionAddress;

	private static int SetCustomMeshTriangles_ParamsSize;

	private static bool SetCustomMeshTriangles_Triangles_IsValid;

	private static FFieldAddress SetCustomMeshTriangles_Triangles_PropertyAddress;

	private static int SetCustomMeshTriangles_Triangles_Offset;

	private static bool SetCustomMeshTriangles_ReturnValue_IsValid;

	private static FFieldAddress SetCustomMeshTriangles_ReturnValue_PropertyAddress;

	private static int SetCustomMeshTriangles_ReturnValue_Offset;

	private static bool ClearCustomMeshTriangles_IsValid;

	private static IntPtr ClearCustomMeshTriangles_FunctionAddress;

	private static int ClearCustomMeshTriangles_ParamsSize;

	private static bool AddCustomMeshTriangles_IsValid;

	private static IntPtr AddCustomMeshTriangles_FunctionAddress;

	private static int AddCustomMeshTriangles_ParamsSize;

	private static bool AddCustomMeshTriangles_Triangles_IsValid;

	private static FFieldAddress AddCustomMeshTriangles_Triangles_PropertyAddress;

	private static int AddCustomMeshTriangles_Triangles_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/CustomMeshComponent.CustomMeshComponent:SetCustomMeshTriangles")]
	public unsafe bool SetCustomMeshTriangles(List<FCustomMeshTriangle> Triangles)
	{
		CheckDestroyed();
		if (!SetCustomMeshTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomMeshComponent.CustomMeshComponent:SetCustomMeshTriangles");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomMeshTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomMeshTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FCustomMeshTriangle>(1, SetCustomMeshTriangles_Triangles_PropertyAddress, CachedMarshalingDelegates<FCustomMeshTriangle, FCustomMeshTriangle>.FromNative, CachedMarshalingDelegates<FCustomMeshTriangle, FCustomMeshTriangle>.ToNative).ToNative(IntPtr.Add(intPtr, SetCustomMeshTriangles_Triangles_Offset), Triangles);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomMeshTriangles_FunctionAddress, intPtr, SetCustomMeshTriangles_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomMeshTriangles_Triangles_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomMeshTriangles_ReturnValue_Offset), 0, SetCustomMeshTriangles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomMeshComponent.CustomMeshComponent:ClearCustomMeshTriangles")]
	public unsafe void ClearCustomMeshTriangles()
	{
		CheckDestroyed();
		if (!ClearCustomMeshTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomMeshComponent.CustomMeshComponent:ClearCustomMeshTriangles");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearCustomMeshTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearCustomMeshTriangles_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearCustomMeshTriangles_FunctionAddress, argsSize: ClearCustomMeshTriangles_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/CustomMeshComponent.CustomMeshComponent:AddCustomMeshTriangles")]
	public unsafe void AddCustomMeshTriangles(List<FCustomMeshTriangle> Triangles)
	{
		CheckDestroyed();
		if (!AddCustomMeshTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomMeshComponent.CustomMeshComponent:AddCustomMeshTriangles");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCustomMeshTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCustomMeshTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FCustomMeshTriangle>(1, AddCustomMeshTriangles_Triangles_PropertyAddress, CachedMarshalingDelegates<FCustomMeshTriangle, FCustomMeshTriangle>.FromNative, CachedMarshalingDelegates<FCustomMeshTriangle, FCustomMeshTriangle>.ToNative).ToNative(IntPtr.Add(intPtr, AddCustomMeshTriangles_Triangles_Offset), Triangles);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddCustomMeshTriangles_FunctionAddress, intPtr, AddCustomMeshTriangles_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddCustomMeshTriangles_Triangles_PropertyAddress.Address, intPtr);
	}

	static UCustomMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCustomMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCustomMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/CustomMeshComponent.CustomMeshComponent");
		SetCustomMeshTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomMeshTriangles");
		SetCustomMeshTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomMeshTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomMeshTriangles_Triangles_PropertyAddress, SetCustomMeshTriangles_FunctionAddress, "Triangles");
		SetCustomMeshTriangles_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomMeshTriangles_FunctionAddress, "Triangles");
		SetCustomMeshTriangles_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomMeshTriangles_FunctionAddress, "Triangles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomMeshTriangles_ReturnValue_PropertyAddress, SetCustomMeshTriangles_FunctionAddress, "ReturnValue");
		SetCustomMeshTriangles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomMeshTriangles_FunctionAddress, "ReturnValue");
		SetCustomMeshTriangles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomMeshTriangles_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomMeshTriangles_IsValid = SetCustomMeshTriangles_FunctionAddress != IntPtr.Zero && SetCustomMeshTriangles_Triangles_IsValid && SetCustomMeshTriangles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomMeshComponent.CustomMeshComponent:SetCustomMeshTriangles", SetCustomMeshTriangles_IsValid);
		ClearCustomMeshTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearCustomMeshTriangles");
		ClearCustomMeshTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearCustomMeshTriangles_FunctionAddress);
		ClearCustomMeshTriangles_IsValid = ClearCustomMeshTriangles_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomMeshComponent.CustomMeshComponent:ClearCustomMeshTriangles", ClearCustomMeshTriangles_IsValid);
		AddCustomMeshTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddCustomMeshTriangles");
		AddCustomMeshTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCustomMeshTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCustomMeshTriangles_Triangles_PropertyAddress, AddCustomMeshTriangles_FunctionAddress, "Triangles");
		AddCustomMeshTriangles_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(AddCustomMeshTriangles_FunctionAddress, "Triangles");
		AddCustomMeshTriangles_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCustomMeshTriangles_FunctionAddress, "Triangles", Classes.FArrayProperty);
		AddCustomMeshTriangles_IsValid = AddCustomMeshTriangles_FunctionAddress != IntPtr.Zero && AddCustomMeshTriangles_Triangles_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomMeshComponent.CustomMeshComponent:AddCustomMeshTriangles", AddCustomMeshTriangles_IsValid);
	}
}
