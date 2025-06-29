using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_NiagaraFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_NiagaraFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetTextureParameterValueOnMeshRenderMaterials_IsValid;

	private static IntPtr SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress;

	private static int SetTextureParameterValueOnMeshRenderMaterials_ParamsSize;

	private static bool SetTextureParameterValueOnMeshRenderMaterials_NiagaraComponent_IsValid;

	private static FFieldAddress SetTextureParameterValueOnMeshRenderMaterials_NiagaraComponent_PropertyAddress;

	private static int SetTextureParameterValueOnMeshRenderMaterials_NiagaraComponent_Offset;

	private static bool SetTextureParameterValueOnMeshRenderMaterials_ParameterName_IsValid;

	private static FFieldAddress SetTextureParameterValueOnMeshRenderMaterials_ParameterName_PropertyAddress;

	private static int SetTextureParameterValueOnMeshRenderMaterials_ParameterName_Offset;

	private static bool SetTextureParameterValueOnMeshRenderMaterials_ParameterValue_IsValid;

	private static FFieldAddress SetTextureParameterValueOnMeshRenderMaterials_ParameterValue_PropertyAddress;

	private static int SetTextureParameterValueOnMeshRenderMaterials_ParameterValue_Offset;

	private static bool SetEffectTypeManagerState_IsValid;

	private static IntPtr SetEffectTypeManagerState_FunctionAddress;

	private static int SetEffectTypeManagerState_ParamsSize;

	private static bool SetEffectTypeManagerState_NewMode_IsValid;

	private static FFieldAddress SetEffectTypeManagerState_NewMode_PropertyAddress;

	private static int SetEffectTypeManagerState_NewMode_Offset;

	private static bool GetNiagaraComponentPoolMethod_IsValid;

	private static IntPtr GetNiagaraComponentPoolMethod_FunctionAddress;

	private static int GetNiagaraComponentPoolMethod_ParamsSize;

	private static bool GetNiagaraComponentPoolMethod_NC_IsValid;

	private static FFieldAddress GetNiagaraComponentPoolMethod_NC_PropertyAddress;

	private static int GetNiagaraComponentPoolMethod_NC_Offset;

	private static bool GetNiagaraComponentPoolMethod_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraComponentPoolMethod_ReturnValue_PropertyAddress;

	private static int GetNiagaraComponentPoolMethod_ReturnValue_Offset;

	private static bool ForceDestroyNiagaraComponent_IsValid;

	private static IntPtr ForceDestroyNiagaraComponent_FunctionAddress;

	private static int ForceDestroyNiagaraComponent_ParamsSize;

	private static bool ForceDestroyNiagaraComponent_NC_IsValid;

	private static FFieldAddress ForceDestroyNiagaraComponent_NC_PropertyAddress;

	private static int ForceDestroyNiagaraComponent_NC_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_NiagaraFuncLib:SetTextureParameterValueOnMeshRenderMaterials")]
	public unsafe static void SetTextureParameterValueOnMeshRenderMaterials(UNiagaraComponent NiagaraComponent, FName ParameterName, UTexture ParameterValue)
	{
		if (!SetTextureParameterValueOnMeshRenderMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_NiagaraFuncLib:SetTextureParameterValueOnMeshRenderMaterials");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextureParameterValueOnMeshRenderMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextureParameterValueOnMeshRenderMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetTextureParameterValueOnMeshRenderMaterials_NiagaraComponent_Offset), 0, SetTextureParameterValueOnMeshRenderMaterials_NiagaraComponent_PropertyAddress.Address, NiagaraComponent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetTextureParameterValueOnMeshRenderMaterials_ParameterName_Offset), 0, SetTextureParameterValueOnMeshRenderMaterials_ParameterName_PropertyAddress.Address, ParameterName);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, SetTextureParameterValueOnMeshRenderMaterials_ParameterValue_Offset), 0, SetTextureParameterValueOnMeshRenderMaterials_ParameterValue_PropertyAddress.Address, ParameterValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress, intPtr, SetTextureParameterValueOnMeshRenderMaterials_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_NiagaraFuncLib:SetEffectTypeManagerState")]
	public unsafe static void SetEffectTypeManagerState(EEffectTypeManagerCullMode NewMode)
	{
		if (!SetEffectTypeManagerState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_NiagaraFuncLib:SetEffectTypeManagerState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEffectTypeManagerState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEffectTypeManagerState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EEffectTypeManagerCullMode>.ToNative(IntPtr.Add(intPtr, SetEffectTypeManagerState_NewMode_Offset), 0, SetEffectTypeManagerState_NewMode_PropertyAddress.Address, NewMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEffectTypeManagerState_FunctionAddress, intPtr, SetEffectTypeManagerState_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_NiagaraFuncLib:GetNiagaraComponentPoolMethod")]
	public unsafe static ENCPoolMethod GetNiagaraComponentPoolMethod(UNiagaraComponent NC)
	{
		if (!GetNiagaraComponentPoolMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_NiagaraFuncLib:GetNiagaraComponentPoolMethod");
			return ENCPoolMethod.None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraComponentPoolMethod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraComponentPoolMethod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraComponentPoolMethod_NC_Offset), 0, GetNiagaraComponentPoolMethod_NC_PropertyAddress.Address, NC);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraComponentPoolMethod_FunctionAddress, intPtr, GetNiagaraComponentPoolMethod_ParamsSize);
		return EnumMarshaler<ENCPoolMethod>.FromNative(IntPtr.Add(intPtr, GetNiagaraComponentPoolMethod_ReturnValue_Offset), 0, GetNiagaraComponentPoolMethod_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_NiagaraFuncLib:ForceDestroyNiagaraComponent")]
	public unsafe static void ForceDestroyNiagaraComponent(UNiagaraComponent NC)
	{
		if (!ForceDestroyNiagaraComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_NiagaraFuncLib:ForceDestroyNiagaraComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceDestroyNiagaraComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceDestroyNiagaraComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, ForceDestroyNiagaraComponent_NC_Offset), 0, ForceDestroyNiagaraComponent_NC_PropertyAddress.Address, NC);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ForceDestroyNiagaraComponent_FunctionAddress, intPtr, ForceDestroyNiagaraComponent_ParamsSize);
	}

	static UGSE_NiagaraFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_NiagaraFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_NiagaraFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_NiagaraFuncLib");
		SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTextureParameterValueOnMeshRenderMaterials");
		SetTextureParameterValueOnMeshRenderMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextureParameterValueOnMeshRenderMaterials_NiagaraComponent_PropertyAddress, SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress, "NiagaraComponent");
		SetTextureParameterValueOnMeshRenderMaterials_NiagaraComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress, "NiagaraComponent");
		SetTextureParameterValueOnMeshRenderMaterials_NiagaraComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress, "NiagaraComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTextureParameterValueOnMeshRenderMaterials_ParameterName_PropertyAddress, SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress, "ParameterName");
		SetTextureParameterValueOnMeshRenderMaterials_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress, "ParameterName");
		SetTextureParameterValueOnMeshRenderMaterials_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTextureParameterValueOnMeshRenderMaterials_ParameterValue_PropertyAddress, SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress, "ParameterValue");
		SetTextureParameterValueOnMeshRenderMaterials_ParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress, "ParameterValue");
		SetTextureParameterValueOnMeshRenderMaterials_ParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress, "ParameterValue", Classes.FObjectProperty);
		SetTextureParameterValueOnMeshRenderMaterials_IsValid = SetTextureParameterValueOnMeshRenderMaterials_FunctionAddress != IntPtr.Zero && SetTextureParameterValueOnMeshRenderMaterials_NiagaraComponent_IsValid && SetTextureParameterValueOnMeshRenderMaterials_ParameterName_IsValid && SetTextureParameterValueOnMeshRenderMaterials_ParameterValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_NiagaraFuncLib:SetTextureParameterValueOnMeshRenderMaterials", SetTextureParameterValueOnMeshRenderMaterials_IsValid);
		SetEffectTypeManagerState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEffectTypeManagerState");
		SetEffectTypeManagerState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEffectTypeManagerState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEffectTypeManagerState_NewMode_PropertyAddress, SetEffectTypeManagerState_FunctionAddress, "NewMode");
		SetEffectTypeManagerState_NewMode_Offset = NativeReflectionCached.GetPropertyOffset(SetEffectTypeManagerState_FunctionAddress, "NewMode");
		SetEffectTypeManagerState_NewMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEffectTypeManagerState_FunctionAddress, "NewMode", Classes.FEnumProperty);
		SetEffectTypeManagerState_IsValid = SetEffectTypeManagerState_FunctionAddress != IntPtr.Zero && SetEffectTypeManagerState_NewMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_NiagaraFuncLib:SetEffectTypeManagerState", SetEffectTypeManagerState_IsValid);
		GetNiagaraComponentPoolMethod_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraComponentPoolMethod");
		GetNiagaraComponentPoolMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraComponentPoolMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraComponentPoolMethod_NC_PropertyAddress, GetNiagaraComponentPoolMethod_FunctionAddress, "NC");
		GetNiagaraComponentPoolMethod_NC_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraComponentPoolMethod_FunctionAddress, "NC");
		GetNiagaraComponentPoolMethod_NC_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraComponentPoolMethod_FunctionAddress, "NC", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraComponentPoolMethod_ReturnValue_PropertyAddress, GetNiagaraComponentPoolMethod_FunctionAddress, "ReturnValue");
		GetNiagaraComponentPoolMethod_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraComponentPoolMethod_FunctionAddress, "ReturnValue");
		GetNiagaraComponentPoolMethod_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraComponentPoolMethod_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetNiagaraComponentPoolMethod_IsValid = GetNiagaraComponentPoolMethod_FunctionAddress != IntPtr.Zero && GetNiagaraComponentPoolMethod_NC_IsValid && GetNiagaraComponentPoolMethod_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_NiagaraFuncLib:GetNiagaraComponentPoolMethod", GetNiagaraComponentPoolMethod_IsValid);
		ForceDestroyNiagaraComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ForceDestroyNiagaraComponent");
		ForceDestroyNiagaraComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceDestroyNiagaraComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForceDestroyNiagaraComponent_NC_PropertyAddress, ForceDestroyNiagaraComponent_FunctionAddress, "NC");
		ForceDestroyNiagaraComponent_NC_Offset = NativeReflectionCached.GetPropertyOffset(ForceDestroyNiagaraComponent_FunctionAddress, "NC");
		ForceDestroyNiagaraComponent_NC_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceDestroyNiagaraComponent_FunctionAddress, "NC", Classes.FObjectProperty);
		ForceDestroyNiagaraComponent_IsValid = ForceDestroyNiagaraComponent_FunctionAddress != IntPtr.Zero && ForceDestroyNiagaraComponent_NC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_NiagaraFuncLib:ForceDestroyNiagaraComponent", ForceDestroyNiagaraComponent_IsValid);
	}
}
