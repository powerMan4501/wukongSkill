using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MRMesh;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MRMesh.MRMeshComponent", "MRMesh", UnrealModuleType.Engine)]
public class UMRMeshComponent : UPrimitiveComponent
{
	private static bool SetWireframeMaterial_IsValid;

	private static IntPtr SetWireframeMaterial_FunctionAddress;

	private static int SetWireframeMaterial_ParamsSize;

	private static bool SetWireframeMaterial_InMaterial_IsValid;

	private static FFieldAddress SetWireframeMaterial_InMaterial_PropertyAddress;

	private static int SetWireframeMaterial_InMaterial_Offset;

	private static bool SetWireframeColor_IsValid;

	private static IntPtr SetWireframeColor_FunctionAddress;

	private static int SetWireframeColor_ParamsSize;

	private static bool SetWireframeColor_InColor_IsValid;

	private static FFieldAddress SetWireframeColor_InColor_PropertyAddress;

	private static int SetWireframeColor_InColor_Offset;

	private static bool SetUseWireframe_IsValid;

	private static IntPtr SetUseWireframe_FunctionAddress;

	private static int SetUseWireframe_ParamsSize;

	private static bool SetUseWireframe_bUseWireframe_IsValid;

	private static FFieldAddress SetUseWireframe_bUseWireframe_PropertyAddress;

	private static int SetUseWireframe_bUseWireframe_Offset;

	private static bool SetEnableMeshOcclusion_IsValid;

	private static IntPtr SetEnableMeshOcclusion_FunctionAddress;

	private static int SetEnableMeshOcclusion_ParamsSize;

	private static bool SetEnableMeshOcclusion_bEnable_IsValid;

	private static FFieldAddress SetEnableMeshOcclusion_bEnable_PropertyAddress;

	private static int SetEnableMeshOcclusion_bEnable_Offset;

	private static bool RequestNavMeshUpdate_IsValid;

	private static IntPtr RequestNavMeshUpdate_FunctionAddress;

	private static int RequestNavMeshUpdate_ParamsSize;

	private static bool IsConnected_IsValid;

	private static IntPtr IsConnected_FunctionAddress;

	private static int IsConnected_ParamsSize;

	private static bool IsConnected_ReturnValue_IsValid;

	private static FFieldAddress IsConnected_ReturnValue_PropertyAddress;

	private static int IsConnected_ReturnValue_Offset;

	private static bool GetWireframeColor_IsValid;

	private static IntPtr GetWireframeColor_FunctionAddress;

	private static int GetWireframeColor_ParamsSize;

	private static bool GetWireframeColor_ReturnValue_IsValid;

	private static FFieldAddress GetWireframeColor_ReturnValue_PropertyAddress;

	private static int GetWireframeColor_ReturnValue_Offset;

	private static bool GetUseWireframe_IsValid;

	private static IntPtr GetUseWireframe_FunctionAddress;

	private static int GetUseWireframe_ParamsSize;

	private static bool GetUseWireframe_ReturnValue_IsValid;

	private static FFieldAddress GetUseWireframe_ReturnValue_PropertyAddress;

	private static int GetUseWireframe_ReturnValue_Offset;

	private static bool GetEnableMeshOcclusion_IsValid;

	private static IntPtr GetEnableMeshOcclusion_FunctionAddress;

	private static int GetEnableMeshOcclusion_ParamsSize;

	private static bool GetEnableMeshOcclusion_ReturnValue_IsValid;

	private static FFieldAddress GetEnableMeshOcclusion_ReturnValue_PropertyAddress;

	private static int GetEnableMeshOcclusion_ReturnValue_Offset;

	private static bool ForceNavMeshUpdate_IsValid;

	private static IntPtr ForceNavMeshUpdate_FunctionAddress;

	private static int ForceNavMeshUpdate_ParamsSize;

	private static bool Clear_IsValid;

	private static IntPtr Clear_FunctionAddress;

	private static int Clear_ParamsSize;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/MRMesh.MRMeshComponent:SetWireframeMaterial")]
	public unsafe void SetWireframeMaterial(UMaterialInterface InMaterial)
	{
		CheckDestroyed();
		if (!SetWireframeMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MRMeshComponent:SetWireframeMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWireframeMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWireframeMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetWireframeMaterial_InMaterial_Offset), 0, SetWireframeMaterial_InMaterial_PropertyAddress.Address, InMaterial);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWireframeMaterial_FunctionAddress, intPtr, SetWireframeMaterial_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/MRMesh.MRMeshComponent:SetWireframeColor")]
	public unsafe void SetWireframeColor(FLinearColor InColor)
	{
		CheckDestroyed();
		if (!SetWireframeColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MRMeshComponent:SetWireframeColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWireframeColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWireframeColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetWireframeColor_InColor_Offset), 0, SetWireframeColor_InColor_PropertyAddress.Address, InColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWireframeColor_FunctionAddress, intPtr, SetWireframeColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MRMesh.MRMeshComponent:SetUseWireframe")]
	public unsafe void SetUseWireframe(bool bUseWireframe)
	{
		CheckDestroyed();
		if (!SetUseWireframe_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MRMeshComponent:SetUseWireframe");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUseWireframe_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUseWireframe_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUseWireframe_bUseWireframe_Offset), 0, SetUseWireframe_bUseWireframe_PropertyAddress.Address, bUseWireframe);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUseWireframe_FunctionAddress, intPtr, SetUseWireframe_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MRMesh.MRMeshComponent:SetEnableMeshOcclusion")]
	public unsafe void SetEnableMeshOcclusion(bool bEnable)
	{
		CheckDestroyed();
		if (!SetEnableMeshOcclusion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MRMeshComponent:SetEnableMeshOcclusion");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableMeshOcclusion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableMeshOcclusion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableMeshOcclusion_bEnable_Offset), 0, SetEnableMeshOcclusion_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableMeshOcclusion_FunctionAddress, intPtr, SetEnableMeshOcclusion_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MRMesh.MRMeshComponent:RequestNavMeshUpdate")]
	public unsafe void RequestNavMeshUpdate()
	{
		CheckDestroyed();
		if (!RequestNavMeshUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MRMeshComponent:RequestNavMeshUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestNavMeshUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestNavMeshUpdate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestNavMeshUpdate_FunctionAddress, argsSize: RequestNavMeshUpdate_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MRMesh.MRMeshComponent:IsConnected")]
	public unsafe bool IsConnected()
	{
		CheckDestroyed();
		if (!IsConnected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MRMeshComponent:IsConnected");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsConnected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsConnected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsConnected_FunctionAddress, intPtr, IsConnected_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsConnected_ReturnValue_Offset), 0, IsConnected_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/MRMesh.MRMeshComponent:GetWireframeColor")]
	public unsafe FLinearColor GetWireframeColor()
	{
		CheckDestroyed();
		if (!GetWireframeColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MRMeshComponent:GetWireframeColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWireframeColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWireframeColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWireframeColor_FunctionAddress, intPtr, GetWireframeColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetWireframeColor_ReturnValue_Offset), 0, GetWireframeColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MRMesh.MRMeshComponent:GetUseWireframe")]
	public unsafe bool GetUseWireframe()
	{
		CheckDestroyed();
		if (!GetUseWireframe_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MRMeshComponent:GetUseWireframe");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUseWireframe_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUseWireframe_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUseWireframe_FunctionAddress, intPtr, GetUseWireframe_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetUseWireframe_ReturnValue_Offset), 0, GetUseWireframe_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MRMesh.MRMeshComponent:GetEnableMeshOcclusion")]
	public unsafe bool GetEnableMeshOcclusion()
	{
		CheckDestroyed();
		if (!GetEnableMeshOcclusion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MRMeshComponent:GetEnableMeshOcclusion");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEnableMeshOcclusion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEnableMeshOcclusion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEnableMeshOcclusion_FunctionAddress, intPtr, GetEnableMeshOcclusion_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetEnableMeshOcclusion_ReturnValue_Offset), 0, GetEnableMeshOcclusion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MRMesh.MRMeshComponent:ForceNavMeshUpdate")]
	public unsafe void ForceNavMeshUpdate()
	{
		CheckDestroyed();
		if (!ForceNavMeshUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MRMeshComponent:ForceNavMeshUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceNavMeshUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceNavMeshUpdate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceNavMeshUpdate_FunctionAddress, argsSize: ForceNavMeshUpdate_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MRMesh.MRMeshComponent:Clear")]
	public unsafe void Clear()
	{
		CheckDestroyed();
		if (!Clear_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MRMeshComponent:Clear");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Clear_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Clear_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Clear_FunctionAddress, argsSize: Clear_ParamsSize);
	}

	static UMRMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMRMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMRMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MRMesh.MRMeshComponent");
		SetWireframeMaterial_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetWireframeMaterial");
		SetWireframeMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWireframeMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWireframeMaterial_InMaterial_PropertyAddress, SetWireframeMaterial_FunctionAddress, "InMaterial");
		SetWireframeMaterial_InMaterial_Offset = NativeReflectionCached.GetPropertyOffset(SetWireframeMaterial_FunctionAddress, "InMaterial");
		SetWireframeMaterial_InMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWireframeMaterial_FunctionAddress, "InMaterial", Classes.FObjectProperty);
		SetWireframeMaterial_IsValid = SetWireframeMaterial_FunctionAddress != IntPtr.Zero && SetWireframeMaterial_InMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MRMeshComponent:SetWireframeMaterial", SetWireframeMaterial_IsValid);
		SetWireframeColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetWireframeColor");
		SetWireframeColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWireframeColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWireframeColor_InColor_PropertyAddress, SetWireframeColor_FunctionAddress, "InColor");
		SetWireframeColor_InColor_Offset = NativeReflectionCached.GetPropertyOffset(SetWireframeColor_FunctionAddress, "InColor");
		SetWireframeColor_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWireframeColor_FunctionAddress, "InColor", Classes.FStructProperty);
		SetWireframeColor_IsValid = SetWireframeColor_FunctionAddress != IntPtr.Zero && SetWireframeColor_InColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MRMeshComponent:SetWireframeColor", SetWireframeColor_IsValid);
		SetUseWireframe_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetUseWireframe");
		SetUseWireframe_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUseWireframe_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUseWireframe_bUseWireframe_PropertyAddress, SetUseWireframe_FunctionAddress, "bUseWireframe");
		SetUseWireframe_bUseWireframe_Offset = NativeReflectionCached.GetPropertyOffset(SetUseWireframe_FunctionAddress, "bUseWireframe");
		SetUseWireframe_bUseWireframe_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUseWireframe_FunctionAddress, "bUseWireframe", Classes.FBoolProperty);
		SetUseWireframe_IsValid = SetUseWireframe_FunctionAddress != IntPtr.Zero && SetUseWireframe_bUseWireframe_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MRMeshComponent:SetUseWireframe", SetUseWireframe_IsValid);
		SetEnableMeshOcclusion_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEnableMeshOcclusion");
		SetEnableMeshOcclusion_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableMeshOcclusion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableMeshOcclusion_bEnable_PropertyAddress, SetEnableMeshOcclusion_FunctionAddress, "bEnable");
		SetEnableMeshOcclusion_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableMeshOcclusion_FunctionAddress, "bEnable");
		SetEnableMeshOcclusion_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableMeshOcclusion_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetEnableMeshOcclusion_IsValid = SetEnableMeshOcclusion_FunctionAddress != IntPtr.Zero && SetEnableMeshOcclusion_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MRMeshComponent:SetEnableMeshOcclusion", SetEnableMeshOcclusion_IsValid);
		RequestNavMeshUpdate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RequestNavMeshUpdate");
		RequestNavMeshUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestNavMeshUpdate_FunctionAddress);
		RequestNavMeshUpdate_IsValid = RequestNavMeshUpdate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MRMeshComponent:RequestNavMeshUpdate", RequestNavMeshUpdate_IsValid);
		IsConnected_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsConnected");
		IsConnected_ParamsSize = NativeReflection.GetFunctionParamsSize(IsConnected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsConnected_ReturnValue_PropertyAddress, IsConnected_FunctionAddress, "ReturnValue");
		IsConnected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsConnected_FunctionAddress, "ReturnValue");
		IsConnected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsConnected_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsConnected_IsValid = IsConnected_FunctionAddress != IntPtr.Zero && IsConnected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MRMeshComponent:IsConnected", IsConnected_IsValid);
		GetWireframeColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWireframeColor");
		GetWireframeColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWireframeColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWireframeColor_ReturnValue_PropertyAddress, GetWireframeColor_FunctionAddress, "ReturnValue");
		GetWireframeColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWireframeColor_FunctionAddress, "ReturnValue");
		GetWireframeColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWireframeColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWireframeColor_IsValid = GetWireframeColor_FunctionAddress != IntPtr.Zero && GetWireframeColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MRMeshComponent:GetWireframeColor", GetWireframeColor_IsValid);
		GetUseWireframe_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUseWireframe");
		GetUseWireframe_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUseWireframe_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUseWireframe_ReturnValue_PropertyAddress, GetUseWireframe_FunctionAddress, "ReturnValue");
		GetUseWireframe_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUseWireframe_FunctionAddress, "ReturnValue");
		GetUseWireframe_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUseWireframe_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetUseWireframe_IsValid = GetUseWireframe_FunctionAddress != IntPtr.Zero && GetUseWireframe_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MRMeshComponent:GetUseWireframe", GetUseWireframe_IsValid);
		GetEnableMeshOcclusion_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEnableMeshOcclusion");
		GetEnableMeshOcclusion_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEnableMeshOcclusion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEnableMeshOcclusion_ReturnValue_PropertyAddress, GetEnableMeshOcclusion_FunctionAddress, "ReturnValue");
		GetEnableMeshOcclusion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEnableMeshOcclusion_FunctionAddress, "ReturnValue");
		GetEnableMeshOcclusion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEnableMeshOcclusion_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetEnableMeshOcclusion_IsValid = GetEnableMeshOcclusion_FunctionAddress != IntPtr.Zero && GetEnableMeshOcclusion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MRMeshComponent:GetEnableMeshOcclusion", GetEnableMeshOcclusion_IsValid);
		ForceNavMeshUpdate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ForceNavMeshUpdate");
		ForceNavMeshUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceNavMeshUpdate_FunctionAddress);
		ForceNavMeshUpdate_IsValid = ForceNavMeshUpdate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MRMeshComponent:ForceNavMeshUpdate", ForceNavMeshUpdate_IsValid);
		Clear_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Clear");
		Clear_ParamsSize = NativeReflection.GetFunctionParamsSize(Clear_FunctionAddress);
		Clear_IsValid = Clear_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MRMeshComponent:Clear", Clear_IsValid);
	}
}
