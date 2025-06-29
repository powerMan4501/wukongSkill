using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.InteractiveToolsFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent", "GeometryFramework", UnrealModuleType.Engine)]
public class UBaseDynamicMeshComponent : UMeshComponent, IToolFrameworkComponent, IInterface, IMeshVertexCommandChangeTarget, IMeshCommandChangeTarget, IMeshReplacementCommandChangeTarget
{
	private static bool ExplicitShowWireframe_IsValid;

	private static FFieldAddress ExplicitShowWireframe_PropertyAddress;

	private static int ExplicitShowWireframe_Offset;

	private static bool EnableViewModeOverrides_IsValid;

	private static FFieldAddress EnableViewModeOverrides_PropertyAddress;

	private static int EnableViewModeOverrides_Offset;

	private static bool EnableRaytracing_IsValid;

	private static FFieldAddress EnableRaytracing_PropertyAddress;

	private static int EnableRaytracing_Offset;

	private static bool SetViewModeOverridesEnabled_IsValid;

	private static IntPtr SetViewModeOverridesEnabled_FunctionAddress;

	private static int SetViewModeOverridesEnabled_ParamsSize;

	private static bool SetViewModeOverridesEnabled_bEnabled_IsValid;

	private static FFieldAddress SetViewModeOverridesEnabled_bEnabled_PropertyAddress;

	private static int SetViewModeOverridesEnabled_bEnabled_Offset;

	private static bool SetShadowsEnabled_IsValid;

	private static IntPtr SetShadowsEnabled_FunctionAddress;

	private static int SetShadowsEnabled_ParamsSize;

	private static bool SetShadowsEnabled_bEnabled_IsValid;

	private static FFieldAddress SetShadowsEnabled_bEnabled_PropertyAddress;

	private static int SetShadowsEnabled_bEnabled_Offset;

	private static bool SetSecondaryRenderMaterial_IsValid;

	private static IntPtr SetSecondaryRenderMaterial_FunctionAddress;

	private static int SetSecondaryRenderMaterial_ParamsSize;

	private static bool SetSecondaryRenderMaterial_Material_IsValid;

	private static FFieldAddress SetSecondaryRenderMaterial_Material_PropertyAddress;

	private static int SetSecondaryRenderMaterial_Material_Offset;

	private static bool SetSecondaryBuffersVisibility_IsValid;

	private static IntPtr SetSecondaryBuffersVisibility_FunctionAddress;

	private static int SetSecondaryBuffersVisibility_ParamsSize;

	private static bool SetSecondaryBuffersVisibility_bSetVisible_IsValid;

	private static FFieldAddress SetSecondaryBuffersVisibility_bSetVisible_PropertyAddress;

	private static int SetSecondaryBuffersVisibility_bSetVisible_Offset;

	private static bool SetOverrideRenderMaterial_IsValid;

	private static IntPtr SetOverrideRenderMaterial_FunctionAddress;

	private static int SetOverrideRenderMaterial_ParamsSize;

	private static bool SetOverrideRenderMaterial_Material_IsValid;

	private static FFieldAddress SetOverrideRenderMaterial_Material_PropertyAddress;

	private static int SetOverrideRenderMaterial_Material_Offset;

	private static bool SetEnableWireframeRenderPass_IsValid;

	private static IntPtr SetEnableWireframeRenderPass_FunctionAddress;

	private static int SetEnableWireframeRenderPass_ParamsSize;

	private static bool SetEnableWireframeRenderPass_bEnable_IsValid;

	private static FFieldAddress SetEnableWireframeRenderPass_bEnable_PropertyAddress;

	private static int SetEnableWireframeRenderPass_bEnable_Offset;

	private static bool SetEnableRaytracing_IsValid;

	private static IntPtr SetEnableRaytracing_FunctionAddress;

	private static int SetEnableRaytracing_ParamsSize;

	private static bool SetEnableRaytracing_bSetEnabled_IsValid;

	private static FFieldAddress SetEnableRaytracing_bSetEnabled_PropertyAddress;

	private static int SetEnableRaytracing_bSetEnabled_Offset;

	private static bool HasOverrideRenderMaterial_IsValid;

	private static IntPtr HasOverrideRenderMaterial_FunctionAddress;

	private static int HasOverrideRenderMaterial_ParamsSize;

	private static bool HasOverrideRenderMaterial_k_IsValid;

	private static FFieldAddress HasOverrideRenderMaterial_k_PropertyAddress;

	private static int HasOverrideRenderMaterial_k_Offset;

	private static bool HasOverrideRenderMaterial_ReturnValue_IsValid;

	private static FFieldAddress HasOverrideRenderMaterial_ReturnValue_PropertyAddress;

	private static int HasOverrideRenderMaterial_ReturnValue_Offset;

	private static bool GetViewModeOverridesEnabled_IsValid;

	private static IntPtr GetViewModeOverridesEnabled_FunctionAddress;

	private static int GetViewModeOverridesEnabled_ParamsSize;

	private static bool GetViewModeOverridesEnabled_ReturnValue_IsValid;

	private static FFieldAddress GetViewModeOverridesEnabled_ReturnValue_PropertyAddress;

	private static int GetViewModeOverridesEnabled_ReturnValue_Offset;

	private static bool GetShadowsEnabled_IsValid;

	private static IntPtr GetShadowsEnabled_FunctionAddress;

	private static int GetShadowsEnabled_ParamsSize;

	private static bool GetShadowsEnabled_ReturnValue_IsValid;

	private static FFieldAddress GetShadowsEnabled_ReturnValue_PropertyAddress;

	private static int GetShadowsEnabled_ReturnValue_Offset;

	private static bool GetSecondaryRenderMaterial_IsValid;

	private static IntPtr GetSecondaryRenderMaterial_FunctionAddress;

	private static int GetSecondaryRenderMaterial_ParamsSize;

	private static bool GetSecondaryRenderMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetSecondaryRenderMaterial_ReturnValue_PropertyAddress;

	private static int GetSecondaryRenderMaterial_ReturnValue_Offset;

	private static bool GetSecondaryBuffersVisibility_IsValid;

	private static IntPtr GetSecondaryBuffersVisibility_FunctionAddress;

	private static int GetSecondaryBuffersVisibility_ParamsSize;

	private static bool GetSecondaryBuffersVisibility_ReturnValue_IsValid;

	private static FFieldAddress GetSecondaryBuffersVisibility_ReturnValue_PropertyAddress;

	private static int GetSecondaryBuffersVisibility_ReturnValue_Offset;

	private static bool GetOverrideRenderMaterial_IsValid;

	private static IntPtr GetOverrideRenderMaterial_FunctionAddress;

	private static int GetOverrideRenderMaterial_ParamsSize;

	private static bool GetOverrideRenderMaterial_MaterialIndex_IsValid;

	private static FFieldAddress GetOverrideRenderMaterial_MaterialIndex_PropertyAddress;

	private static int GetOverrideRenderMaterial_MaterialIndex_Offset;

	private static bool GetOverrideRenderMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetOverrideRenderMaterial_ReturnValue_PropertyAddress;

	private static int GetOverrideRenderMaterial_ReturnValue_Offset;

	private static bool GetEnableWireframeRenderPass_IsValid;

	private static IntPtr GetEnableWireframeRenderPass_FunctionAddress;

	private static int GetEnableWireframeRenderPass_ParamsSize;

	private static bool GetEnableWireframeRenderPass_ReturnValue_IsValid;

	private static FFieldAddress GetEnableWireframeRenderPass_ReturnValue_PropertyAddress;

	private static int GetEnableWireframeRenderPass_ReturnValue_Offset;

	private static bool GetEnableRaytracing_IsValid;

	private static IntPtr GetEnableRaytracing_FunctionAddress;

	private static int GetEnableRaytracing_ParamsSize;

	private static bool GetEnableRaytracing_ReturnValue_IsValid;

	private static FFieldAddress GetEnableRaytracing_ReturnValue_PropertyAddress;

	private static int GetEnableRaytracing_ReturnValue_Offset;

	private static bool GetDynamicMesh_IsValid;

	private static IntPtr GetDynamicMesh_FunctionAddress;

	private static int GetDynamicMesh_ParamsSize;

	private static bool GetDynamicMesh_ReturnValue_IsValid;

	private static FFieldAddress GetDynamicMesh_ReturnValue_PropertyAddress;

	private static int GetDynamicMesh_ReturnValue_Offset;

	private static bool ClearSecondaryRenderMaterial_IsValid;

	private static IntPtr ClearSecondaryRenderMaterial_FunctionAddress;

	private static int ClearSecondaryRenderMaterial_ParamsSize;

	private static bool ClearOverrideRenderMaterial_IsValid;

	private static IntPtr ClearOverrideRenderMaterial_FunctionAddress;

	private static int ClearOverrideRenderMaterial_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:bExplicitShowWireframe")]
	public bool ExplicitShowWireframe
	{
		get
		{
			CheckDestroyed();
			if (!ExplicitShowWireframe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:bExplicitShowWireframe");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExplicitShowWireframe_Offset), 0, ExplicitShowWireframe_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExplicitShowWireframe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:bExplicitShowWireframe");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExplicitShowWireframe_Offset), 0, ExplicitShowWireframe_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:bEnableViewModeOverrides")]
	public bool EnableViewModeOverrides
	{
		get
		{
			CheckDestroyed();
			if (!EnableViewModeOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:bEnableViewModeOverrides");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableViewModeOverrides_Offset), 0, EnableViewModeOverrides_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableViewModeOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:bEnableViewModeOverrides");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableViewModeOverrides_Offset), 0, EnableViewModeOverrides_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:bEnableRaytracing")]
	public bool EnableRaytracing
	{
		get
		{
			CheckDestroyed();
			if (!EnableRaytracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:bEnableRaytracing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRaytracing_Offset), 0, EnableRaytracing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRaytracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:bEnableRaytracing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRaytracing_Offset), 0, EnableRaytracing_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:SetViewModeOverridesEnabled")]
	public unsafe void SetViewModeOverridesEnabled(bool bEnabled)
	{
		CheckDestroyed();
		if (!SetViewModeOverridesEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:SetViewModeOverridesEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewModeOverridesEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewModeOverridesEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetViewModeOverridesEnabled_bEnabled_Offset), 0, SetViewModeOverridesEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewModeOverridesEnabled_FunctionAddress, intPtr, SetViewModeOverridesEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:SetShadowsEnabled")]
	public unsafe void SetShadowsEnabled(bool bEnabled)
	{
		CheckDestroyed();
		if (!SetShadowsEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:SetShadowsEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowsEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowsEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetShadowsEnabled_bEnabled_Offset), 0, SetShadowsEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowsEnabled_FunctionAddress, intPtr, SetShadowsEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:SetSecondaryRenderMaterial")]
	public unsafe void SetSecondaryRenderMaterial(UMaterialInterface Material)
	{
		CheckDestroyed();
		if (!SetSecondaryRenderMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:SetSecondaryRenderMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSecondaryRenderMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSecondaryRenderMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetSecondaryRenderMaterial_Material_Offset), 0, SetSecondaryRenderMaterial_Material_PropertyAddress.Address, Material);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSecondaryRenderMaterial_FunctionAddress, intPtr, SetSecondaryRenderMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:SetSecondaryBuffersVisibility")]
	public unsafe void SetSecondaryBuffersVisibility(bool bSetVisible)
	{
		CheckDestroyed();
		if (!SetSecondaryBuffersVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:SetSecondaryBuffersVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSecondaryBuffersVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSecondaryBuffersVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSecondaryBuffersVisibility_bSetVisible_Offset), 0, SetSecondaryBuffersVisibility_bSetVisible_PropertyAddress.Address, bSetVisible);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSecondaryBuffersVisibility_FunctionAddress, intPtr, SetSecondaryBuffersVisibility_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:SetOverrideRenderMaterial")]
	public unsafe void SetOverrideRenderMaterial(UMaterialInterface Material)
	{
		CheckDestroyed();
		if (!SetOverrideRenderMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:SetOverrideRenderMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOverrideRenderMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOverrideRenderMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetOverrideRenderMaterial_Material_Offset), 0, SetOverrideRenderMaterial_Material_PropertyAddress.Address, Material);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOverrideRenderMaterial_FunctionAddress, intPtr, SetOverrideRenderMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:SetEnableWireframeRenderPass")]
	public unsafe void SetEnableWireframeRenderPass(bool bEnable)
	{
		CheckDestroyed();
		if (!SetEnableWireframeRenderPass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:SetEnableWireframeRenderPass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableWireframeRenderPass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableWireframeRenderPass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableWireframeRenderPass_bEnable_Offset), 0, SetEnableWireframeRenderPass_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableWireframeRenderPass_FunctionAddress, intPtr, SetEnableWireframeRenderPass_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:SetEnableRaytracing")]
	public unsafe void SetEnableRaytracing(bool bSetEnabled)
	{
		CheckDestroyed();
		if (!SetEnableRaytracing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:SetEnableRaytracing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableRaytracing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableRaytracing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableRaytracing_bSetEnabled_Offset), 0, SetEnableRaytracing_bSetEnabled_PropertyAddress.Address, bSetEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableRaytracing_FunctionAddress, intPtr, SetEnableRaytracing_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:HasOverrideRenderMaterial")]
	public unsafe bool HasOverrideRenderMaterial(int k)
	{
		CheckDestroyed();
		if (!HasOverrideRenderMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:HasOverrideRenderMaterial");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasOverrideRenderMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasOverrideRenderMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, HasOverrideRenderMaterial_k_Offset), 0, HasOverrideRenderMaterial_k_PropertyAddress.Address, k);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasOverrideRenderMaterial_FunctionAddress, intPtr, HasOverrideRenderMaterial_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasOverrideRenderMaterial_ReturnValue_Offset), 0, HasOverrideRenderMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:GetViewModeOverridesEnabled")]
	public unsafe bool GetViewModeOverridesEnabled()
	{
		CheckDestroyed();
		if (!GetViewModeOverridesEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:GetViewModeOverridesEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewModeOverridesEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewModeOverridesEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewModeOverridesEnabled_FunctionAddress, intPtr, GetViewModeOverridesEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetViewModeOverridesEnabled_ReturnValue_Offset), 0, GetViewModeOverridesEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:GetShadowsEnabled")]
	public unsafe bool GetShadowsEnabled()
	{
		CheckDestroyed();
		if (!GetShadowsEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:GetShadowsEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShadowsEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShadowsEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShadowsEnabled_FunctionAddress, intPtr, GetShadowsEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetShadowsEnabled_ReturnValue_Offset), 0, GetShadowsEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:GetSecondaryRenderMaterial")]
	public unsafe UMaterialInterface GetSecondaryRenderMaterial()
	{
		CheckDestroyed();
		if (!GetSecondaryRenderMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:GetSecondaryRenderMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSecondaryRenderMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSecondaryRenderMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSecondaryRenderMaterial_FunctionAddress, intPtr, GetSecondaryRenderMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(intPtr, GetSecondaryRenderMaterial_ReturnValue_Offset), 0, GetSecondaryRenderMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:GetSecondaryBuffersVisibility")]
	public unsafe bool GetSecondaryBuffersVisibility()
	{
		CheckDestroyed();
		if (!GetSecondaryBuffersVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:GetSecondaryBuffersVisibility");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSecondaryBuffersVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSecondaryBuffersVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSecondaryBuffersVisibility_FunctionAddress, intPtr, GetSecondaryBuffersVisibility_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetSecondaryBuffersVisibility_ReturnValue_Offset), 0, GetSecondaryBuffersVisibility_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:GetOverrideRenderMaterial")]
	public unsafe UMaterialInterface GetOverrideRenderMaterial(int MaterialIndex)
	{
		CheckDestroyed();
		if (!GetOverrideRenderMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:GetOverrideRenderMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOverrideRenderMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOverrideRenderMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetOverrideRenderMaterial_MaterialIndex_Offset), 0, GetOverrideRenderMaterial_MaterialIndex_PropertyAddress.Address, MaterialIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOverrideRenderMaterial_FunctionAddress, intPtr, GetOverrideRenderMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(intPtr, GetOverrideRenderMaterial_ReturnValue_Offset), 0, GetOverrideRenderMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:GetEnableWireframeRenderPass")]
	public unsafe bool GetEnableWireframeRenderPass()
	{
		CheckDestroyed();
		if (!GetEnableWireframeRenderPass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:GetEnableWireframeRenderPass");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEnableWireframeRenderPass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEnableWireframeRenderPass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEnableWireframeRenderPass_FunctionAddress, intPtr, GetEnableWireframeRenderPass_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetEnableWireframeRenderPass_ReturnValue_Offset), 0, GetEnableWireframeRenderPass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:GetEnableRaytracing")]
	public unsafe bool GetEnableRaytracing()
	{
		CheckDestroyed();
		if (!GetEnableRaytracing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:GetEnableRaytracing");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEnableRaytracing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEnableRaytracing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEnableRaytracing_FunctionAddress, intPtr, GetEnableRaytracing_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetEnableRaytracing_ReturnValue_Offset), 0, GetEnableRaytracing_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:GetDynamicMesh")]
	public unsafe UDynamicMesh GetDynamicMesh()
	{
		CheckDestroyed();
		if (!GetDynamicMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:GetDynamicMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDynamicMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDynamicMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDynamicMesh_FunctionAddress, intPtr, GetDynamicMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetDynamicMesh_ReturnValue_Offset), 0, GetDynamicMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:ClearSecondaryRenderMaterial")]
	public unsafe void ClearSecondaryRenderMaterial()
	{
		CheckDestroyed();
		if (!ClearSecondaryRenderMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:ClearSecondaryRenderMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSecondaryRenderMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSecondaryRenderMaterial_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearSecondaryRenderMaterial_FunctionAddress, argsSize: ClearSecondaryRenderMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GeometryFramework.BaseDynamicMeshComponent:ClearOverrideRenderMaterial")]
	public unsafe void ClearOverrideRenderMaterial()
	{
		CheckDestroyed();
		if (!ClearOverrideRenderMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.BaseDynamicMeshComponent:ClearOverrideRenderMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearOverrideRenderMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearOverrideRenderMaterial_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearOverrideRenderMaterial_FunctionAddress, argsSize: ClearOverrideRenderMaterial_ParamsSize);
	}

	static UBaseDynamicMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBaseDynamicMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBaseDynamicMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryFramework.BaseDynamicMeshComponent");
		NativeReflectionCached.GetPropertyRef(ref ExplicitShowWireframe_PropertyAddress, intPtr, "bExplicitShowWireframe");
		ExplicitShowWireframe_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bExplicitShowWireframe");
		ExplicitShowWireframe_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bExplicitShowWireframe", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableViewModeOverrides_PropertyAddress, intPtr, "bEnableViewModeOverrides");
		EnableViewModeOverrides_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableViewModeOverrides");
		EnableViewModeOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableViewModeOverrides", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableRaytracing_PropertyAddress, intPtr, "bEnableRaytracing");
		EnableRaytracing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableRaytracing");
		EnableRaytracing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableRaytracing", Classes.FBoolProperty);
		SetViewModeOverridesEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetViewModeOverridesEnabled");
		SetViewModeOverridesEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewModeOverridesEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewModeOverridesEnabled_bEnabled_PropertyAddress, SetViewModeOverridesEnabled_FunctionAddress, "bEnabled");
		SetViewModeOverridesEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetViewModeOverridesEnabled_FunctionAddress, "bEnabled");
		SetViewModeOverridesEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewModeOverridesEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetViewModeOverridesEnabled_IsValid = SetViewModeOverridesEnabled_FunctionAddress != IntPtr.Zero && SetViewModeOverridesEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:SetViewModeOverridesEnabled", SetViewModeOverridesEnabled_IsValid);
		SetShadowsEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowsEnabled");
		SetShadowsEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowsEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowsEnabled_bEnabled_PropertyAddress, SetShadowsEnabled_FunctionAddress, "bEnabled");
		SetShadowsEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowsEnabled_FunctionAddress, "bEnabled");
		SetShadowsEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowsEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetShadowsEnabled_IsValid = SetShadowsEnabled_FunctionAddress != IntPtr.Zero && SetShadowsEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:SetShadowsEnabled", SetShadowsEnabled_IsValid);
		SetSecondaryRenderMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSecondaryRenderMaterial");
		SetSecondaryRenderMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSecondaryRenderMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSecondaryRenderMaterial_Material_PropertyAddress, SetSecondaryRenderMaterial_FunctionAddress, "Material");
		SetSecondaryRenderMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetSecondaryRenderMaterial_FunctionAddress, "Material");
		SetSecondaryRenderMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSecondaryRenderMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		SetSecondaryRenderMaterial_IsValid = SetSecondaryRenderMaterial_FunctionAddress != IntPtr.Zero && SetSecondaryRenderMaterial_Material_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:SetSecondaryRenderMaterial", SetSecondaryRenderMaterial_IsValid);
		SetSecondaryBuffersVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSecondaryBuffersVisibility");
		SetSecondaryBuffersVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSecondaryBuffersVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSecondaryBuffersVisibility_bSetVisible_PropertyAddress, SetSecondaryBuffersVisibility_FunctionAddress, "bSetVisible");
		SetSecondaryBuffersVisibility_bSetVisible_Offset = NativeReflectionCached.GetPropertyOffset(SetSecondaryBuffersVisibility_FunctionAddress, "bSetVisible");
		SetSecondaryBuffersVisibility_bSetVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSecondaryBuffersVisibility_FunctionAddress, "bSetVisible", Classes.FBoolProperty);
		SetSecondaryBuffersVisibility_IsValid = SetSecondaryBuffersVisibility_FunctionAddress != IntPtr.Zero && SetSecondaryBuffersVisibility_bSetVisible_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:SetSecondaryBuffersVisibility", SetSecondaryBuffersVisibility_IsValid);
		SetOverrideRenderMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOverrideRenderMaterial");
		SetOverrideRenderMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOverrideRenderMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOverrideRenderMaterial_Material_PropertyAddress, SetOverrideRenderMaterial_FunctionAddress, "Material");
		SetOverrideRenderMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetOverrideRenderMaterial_FunctionAddress, "Material");
		SetOverrideRenderMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverrideRenderMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		SetOverrideRenderMaterial_IsValid = SetOverrideRenderMaterial_FunctionAddress != IntPtr.Zero && SetOverrideRenderMaterial_Material_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:SetOverrideRenderMaterial", SetOverrideRenderMaterial_IsValid);
		SetEnableWireframeRenderPass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableWireframeRenderPass");
		SetEnableWireframeRenderPass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableWireframeRenderPass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableWireframeRenderPass_bEnable_PropertyAddress, SetEnableWireframeRenderPass_FunctionAddress, "bEnable");
		SetEnableWireframeRenderPass_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableWireframeRenderPass_FunctionAddress, "bEnable");
		SetEnableWireframeRenderPass_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableWireframeRenderPass_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetEnableWireframeRenderPass_IsValid = SetEnableWireframeRenderPass_FunctionAddress != IntPtr.Zero && SetEnableWireframeRenderPass_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:SetEnableWireframeRenderPass", SetEnableWireframeRenderPass_IsValid);
		SetEnableRaytracing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableRaytracing");
		SetEnableRaytracing_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableRaytracing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableRaytracing_bSetEnabled_PropertyAddress, SetEnableRaytracing_FunctionAddress, "bSetEnabled");
		SetEnableRaytracing_bSetEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableRaytracing_FunctionAddress, "bSetEnabled");
		SetEnableRaytracing_bSetEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableRaytracing_FunctionAddress, "bSetEnabled", Classes.FBoolProperty);
		SetEnableRaytracing_IsValid = SetEnableRaytracing_FunctionAddress != IntPtr.Zero && SetEnableRaytracing_bSetEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:SetEnableRaytracing", SetEnableRaytracing_IsValid);
		HasOverrideRenderMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasOverrideRenderMaterial");
		HasOverrideRenderMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(HasOverrideRenderMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasOverrideRenderMaterial_k_PropertyAddress, HasOverrideRenderMaterial_FunctionAddress, "k");
		HasOverrideRenderMaterial_k_Offset = NativeReflectionCached.GetPropertyOffset(HasOverrideRenderMaterial_FunctionAddress, "k");
		HasOverrideRenderMaterial_k_IsValid = NativeReflectionCached.ValidatePropertyClass(HasOverrideRenderMaterial_FunctionAddress, "k", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref HasOverrideRenderMaterial_ReturnValue_PropertyAddress, HasOverrideRenderMaterial_FunctionAddress, "ReturnValue");
		HasOverrideRenderMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasOverrideRenderMaterial_FunctionAddress, "ReturnValue");
		HasOverrideRenderMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasOverrideRenderMaterial_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasOverrideRenderMaterial_IsValid = HasOverrideRenderMaterial_FunctionAddress != IntPtr.Zero && HasOverrideRenderMaterial_k_IsValid && HasOverrideRenderMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:HasOverrideRenderMaterial", HasOverrideRenderMaterial_IsValid);
		GetViewModeOverridesEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewModeOverridesEnabled");
		GetViewModeOverridesEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewModeOverridesEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewModeOverridesEnabled_ReturnValue_PropertyAddress, GetViewModeOverridesEnabled_FunctionAddress, "ReturnValue");
		GetViewModeOverridesEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewModeOverridesEnabled_FunctionAddress, "ReturnValue");
		GetViewModeOverridesEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewModeOverridesEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetViewModeOverridesEnabled_IsValid = GetViewModeOverridesEnabled_FunctionAddress != IntPtr.Zero && GetViewModeOverridesEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:GetViewModeOverridesEnabled", GetViewModeOverridesEnabled_IsValid);
		GetShadowsEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetShadowsEnabled");
		GetShadowsEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShadowsEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShadowsEnabled_ReturnValue_PropertyAddress, GetShadowsEnabled_FunctionAddress, "ReturnValue");
		GetShadowsEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShadowsEnabled_FunctionAddress, "ReturnValue");
		GetShadowsEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShadowsEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetShadowsEnabled_IsValid = GetShadowsEnabled_FunctionAddress != IntPtr.Zero && GetShadowsEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:GetShadowsEnabled", GetShadowsEnabled_IsValid);
		GetSecondaryRenderMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSecondaryRenderMaterial");
		GetSecondaryRenderMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSecondaryRenderMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSecondaryRenderMaterial_ReturnValue_PropertyAddress, GetSecondaryRenderMaterial_FunctionAddress, "ReturnValue");
		GetSecondaryRenderMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSecondaryRenderMaterial_FunctionAddress, "ReturnValue");
		GetSecondaryRenderMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSecondaryRenderMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSecondaryRenderMaterial_IsValid = GetSecondaryRenderMaterial_FunctionAddress != IntPtr.Zero && GetSecondaryRenderMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:GetSecondaryRenderMaterial", GetSecondaryRenderMaterial_IsValid);
		GetSecondaryBuffersVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSecondaryBuffersVisibility");
		GetSecondaryBuffersVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSecondaryBuffersVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSecondaryBuffersVisibility_ReturnValue_PropertyAddress, GetSecondaryBuffersVisibility_FunctionAddress, "ReturnValue");
		GetSecondaryBuffersVisibility_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSecondaryBuffersVisibility_FunctionAddress, "ReturnValue");
		GetSecondaryBuffersVisibility_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSecondaryBuffersVisibility_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetSecondaryBuffersVisibility_IsValid = GetSecondaryBuffersVisibility_FunctionAddress != IntPtr.Zero && GetSecondaryBuffersVisibility_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:GetSecondaryBuffersVisibility", GetSecondaryBuffersVisibility_IsValid);
		GetOverrideRenderMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOverrideRenderMaterial");
		GetOverrideRenderMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOverrideRenderMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOverrideRenderMaterial_MaterialIndex_PropertyAddress, GetOverrideRenderMaterial_FunctionAddress, "MaterialIndex");
		GetOverrideRenderMaterial_MaterialIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetOverrideRenderMaterial_FunctionAddress, "MaterialIndex");
		GetOverrideRenderMaterial_MaterialIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverrideRenderMaterial_FunctionAddress, "MaterialIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOverrideRenderMaterial_ReturnValue_PropertyAddress, GetOverrideRenderMaterial_FunctionAddress, "ReturnValue");
		GetOverrideRenderMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOverrideRenderMaterial_FunctionAddress, "ReturnValue");
		GetOverrideRenderMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverrideRenderMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOverrideRenderMaterial_IsValid = GetOverrideRenderMaterial_FunctionAddress != IntPtr.Zero && GetOverrideRenderMaterial_MaterialIndex_IsValid && GetOverrideRenderMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:GetOverrideRenderMaterial", GetOverrideRenderMaterial_IsValid);
		GetEnableWireframeRenderPass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetEnableWireframeRenderPass");
		GetEnableWireframeRenderPass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEnableWireframeRenderPass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEnableWireframeRenderPass_ReturnValue_PropertyAddress, GetEnableWireframeRenderPass_FunctionAddress, "ReturnValue");
		GetEnableWireframeRenderPass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEnableWireframeRenderPass_FunctionAddress, "ReturnValue");
		GetEnableWireframeRenderPass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEnableWireframeRenderPass_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetEnableWireframeRenderPass_IsValid = GetEnableWireframeRenderPass_FunctionAddress != IntPtr.Zero && GetEnableWireframeRenderPass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:GetEnableWireframeRenderPass", GetEnableWireframeRenderPass_IsValid);
		GetEnableRaytracing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetEnableRaytracing");
		GetEnableRaytracing_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEnableRaytracing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEnableRaytracing_ReturnValue_PropertyAddress, GetEnableRaytracing_FunctionAddress, "ReturnValue");
		GetEnableRaytracing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEnableRaytracing_FunctionAddress, "ReturnValue");
		GetEnableRaytracing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEnableRaytracing_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetEnableRaytracing_IsValid = GetEnableRaytracing_FunctionAddress != IntPtr.Zero && GetEnableRaytracing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:GetEnableRaytracing", GetEnableRaytracing_IsValid);
		GetDynamicMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDynamicMesh");
		GetDynamicMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDynamicMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDynamicMesh_ReturnValue_PropertyAddress, GetDynamicMesh_FunctionAddress, "ReturnValue");
		GetDynamicMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDynamicMesh_FunctionAddress, "ReturnValue");
		GetDynamicMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDynamicMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDynamicMesh_IsValid = GetDynamicMesh_FunctionAddress != IntPtr.Zero && GetDynamicMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:GetDynamicMesh", GetDynamicMesh_IsValid);
		ClearSecondaryRenderMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearSecondaryRenderMaterial");
		ClearSecondaryRenderMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSecondaryRenderMaterial_FunctionAddress);
		ClearSecondaryRenderMaterial_IsValid = ClearSecondaryRenderMaterial_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:ClearSecondaryRenderMaterial", ClearSecondaryRenderMaterial_IsValid);
		ClearOverrideRenderMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearOverrideRenderMaterial");
		ClearOverrideRenderMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearOverrideRenderMaterial_FunctionAddress);
		ClearOverrideRenderMaterial_IsValid = ClearOverrideRenderMaterial_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.BaseDynamicMeshComponent:ClearOverrideRenderMaterial", ClearOverrideRenderMaterial_IsValid);
	}
}
