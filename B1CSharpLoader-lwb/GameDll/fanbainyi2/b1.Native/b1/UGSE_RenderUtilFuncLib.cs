using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_RenderUtilFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_RenderUtilFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetRenderCustomDepth_IsValid;

	private static IntPtr SetRenderCustomDepth_FunctionAddress;

	private static int SetRenderCustomDepth_ParamsSize;

	private static bool SetRenderCustomDepth_AA_IsValid;

	private static FFieldAddress SetRenderCustomDepth_AA_PropertyAddress;

	private static int SetRenderCustomDepth_AA_Offset;

	private static bool SetRenderCustomDepth_bValue_IsValid;

	private static FFieldAddress SetRenderCustomDepth_bValue_PropertyAddress;

	private static int SetRenderCustomDepth_bValue_Offset;

	private static bool PlayCameraShake_IsValid;

	private static IntPtr PlayCameraShake_FunctionAddress;

	private static int PlayCameraShake_ParamsSize;

	private static bool PlayCameraShake_CameraShakeCls_IsValid;

	private static FFieldAddress PlayCameraShake_CameraShakeCls_PropertyAddress;

	private static int PlayCameraShake_CameraShakeCls_Offset;

	private static bool PlayCameraShake_Camera_IsValid;

	private static FFieldAddress PlayCameraShake_Camera_PropertyAddress;

	private static int PlayCameraShake_Camera_Offset;

	private static bool OverrideSystemUserVariableSKMFilteredSockets_IsValid;

	private static IntPtr OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress;

	private static int OverrideSystemUserVariableSKMFilteredSockets_ParamsSize;

	private static bool OverrideSystemUserVariableSKMFilteredSockets_NiagaraSystem_IsValid;

	private static FFieldAddress OverrideSystemUserVariableSKMFilteredSockets_NiagaraSystem_PropertyAddress;

	private static int OverrideSystemUserVariableSKMFilteredSockets_NiagaraSystem_Offset;

	private static bool OverrideSystemUserVariableSKMFilteredSockets_OverrideName_IsValid;

	private static FFieldAddress OverrideSystemUserVariableSKMFilteredSockets_OverrideName_PropertyAddress;

	private static int OverrideSystemUserVariableSKMFilteredSockets_OverrideName_Offset;

	private static bool OverrideSystemUserVariableSKMFilteredSockets_OverrideFilteredSockets_IsValid;

	private static FFieldAddress OverrideSystemUserVariableSKMFilteredSockets_OverrideFilteredSockets_PropertyAddress;

	private static int OverrideSystemUserVariableSKMFilteredSockets_OverrideFilteredSockets_Offset;

	private static bool OverrideSystemUserVariableSKMFilteredBones_IsValid;

	private static IntPtr OverrideSystemUserVariableSKMFilteredBones_FunctionAddress;

	private static int OverrideSystemUserVariableSKMFilteredBones_ParamsSize;

	private static bool OverrideSystemUserVariableSKMFilteredBones_NiagaraSystem_IsValid;

	private static FFieldAddress OverrideSystemUserVariableSKMFilteredBones_NiagaraSystem_PropertyAddress;

	private static int OverrideSystemUserVariableSKMFilteredBones_NiagaraSystem_Offset;

	private static bool OverrideSystemUserVariableSKMFilteredBones_OverrideName_IsValid;

	private static FFieldAddress OverrideSystemUserVariableSKMFilteredBones_OverrideName_PropertyAddress;

	private static int OverrideSystemUserVariableSKMFilteredBones_OverrideName_Offset;

	private static bool OverrideSystemUserVariableSKMFilteredBones_OverrideFilteredBones_IsValid;

	private static FFieldAddress OverrideSystemUserVariableSKMFilteredBones_OverrideFilteredBones_PropertyAddress;

	private static int OverrideSystemUserVariableSKMFilteredBones_OverrideFilteredBones_Offset;

	private static bool MarkRenderStateDirty_IsValid;

	private static IntPtr MarkRenderStateDirty_FunctionAddress;

	private static int MarkRenderStateDirty_ParamsSize;

	private static bool MarkRenderStateDirty_ActorComponent_IsValid;

	private static FFieldAddress MarkRenderStateDirty_ActorComponent_PropertyAddress;

	private static int MarkRenderStateDirty_ActorComponent_Offset;

	private static bool GetSceneViewPreExposure_IsValid;

	private static IntPtr GetSceneViewPreExposure_FunctionAddress;

	private static int GetSceneViewPreExposure_ParamsSize;

	private static bool GetSceneViewPreExposure_WorldContext_IsValid;

	private static FFieldAddress GetSceneViewPreExposure_WorldContext_PropertyAddress;

	private static int GetSceneViewPreExposure_WorldContext_Offset;

	private static bool GetSceneViewPreExposure_ReturnValue_IsValid;

	private static FFieldAddress GetSceneViewPreExposure_ReturnValue_PropertyAddress;

	private static int GetSceneViewPreExposure_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_RenderUtilFuncLib:SetRenderCustomDepth")]
	public unsafe static void SetRenderCustomDepth(AActor AA, bool bValue)
	{
		if (!SetRenderCustomDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_RenderUtilFuncLib:SetRenderCustomDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderCustomDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderCustomDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetRenderCustomDepth_AA_Offset), 0, SetRenderCustomDepth_AA_PropertyAddress.Address, AA);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRenderCustomDepth_bValue_Offset), 0, SetRenderCustomDepth_bValue_PropertyAddress.Address, bValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRenderCustomDepth_FunctionAddress, intPtr, SetRenderCustomDepth_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_RenderUtilFuncLib:PlayCameraShake")]
	public unsafe static void PlayCameraShake(TSubclassOf<UObject> CameraShakeCls, APlayerCameraManager Camera)
	{
		if (!PlayCameraShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_RenderUtilFuncLib:PlayCameraShake");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayCameraShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayCameraShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PlayCameraShake_CameraShakeCls_Offset), 0, PlayCameraShake_CameraShakeCls_PropertyAddress.Address, CameraShakeCls);
		UObjectMarshaler<APlayerCameraManager>.ToNative(IntPtr.Add(intPtr, PlayCameraShake_Camera_Offset), 0, PlayCameraShake_Camera_PropertyAddress.Address, Camera);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PlayCameraShake_FunctionAddress, intPtr, PlayCameraShake_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_RenderUtilFuncLib:OverrideSystemUserVariableSKMFilteredSockets")]
	public unsafe static void OverrideSystemUserVariableSKMFilteredSockets(UNiagaraComponent NiagaraSystem, string OverrideName, List<FName> OverrideFilteredSockets)
	{
		if (!OverrideSystemUserVariableSKMFilteredSockets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_RenderUtilFuncLib:OverrideSystemUserVariableSKMFilteredSockets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OverrideSystemUserVariableSKMFilteredSockets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OverrideSystemUserVariableSKMFilteredSockets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableSKMFilteredSockets_NiagaraSystem_Offset), 0, OverrideSystemUserVariableSKMFilteredSockets_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableSKMFilteredSockets_OverrideName_Offset), 0, OverrideSystemUserVariableSKMFilteredSockets_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<FName>(1, OverrideSystemUserVariableSKMFilteredSockets_OverrideFilteredSockets_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableSKMFilteredSockets_OverrideFilteredSockets_Offset), OverrideFilteredSockets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress, intPtr, OverrideSystemUserVariableSKMFilteredSockets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OverrideSystemUserVariableSKMFilteredSockets_OverrideName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OverrideSystemUserVariableSKMFilteredSockets_OverrideFilteredSockets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_RenderUtilFuncLib:OverrideSystemUserVariableSKMFilteredBones")]
	public unsafe static void OverrideSystemUserVariableSKMFilteredBones(UNiagaraComponent NiagaraSystem, string OverrideName, List<FName> OverrideFilteredBones)
	{
		if (!OverrideSystemUserVariableSKMFilteredBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_RenderUtilFuncLib:OverrideSystemUserVariableSKMFilteredBones");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OverrideSystemUserVariableSKMFilteredBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OverrideSystemUserVariableSKMFilteredBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableSKMFilteredBones_NiagaraSystem_Offset), 0, OverrideSystemUserVariableSKMFilteredBones_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableSKMFilteredBones_OverrideName_Offset), 0, OverrideSystemUserVariableSKMFilteredBones_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<FName>(1, OverrideSystemUserVariableSKMFilteredBones_OverrideFilteredBones_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableSKMFilteredBones_OverrideFilteredBones_Offset), OverrideFilteredBones);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OverrideSystemUserVariableSKMFilteredBones_FunctionAddress, intPtr, OverrideSystemUserVariableSKMFilteredBones_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OverrideSystemUserVariableSKMFilteredBones_OverrideName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OverrideSystemUserVariableSKMFilteredBones_OverrideFilteredBones_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_RenderUtilFuncLib:MarkRenderStateDirty")]
	public unsafe static void MarkRenderStateDirty(UActorComponent ActorComponent)
	{
		if (!MarkRenderStateDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_RenderUtilFuncLib:MarkRenderStateDirty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkRenderStateDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkRenderStateDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, MarkRenderStateDirty_ActorComponent_Offset), 0, MarkRenderStateDirty_ActorComponent_PropertyAddress.Address, ActorComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkRenderStateDirty_FunctionAddress, intPtr, MarkRenderStateDirty_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_RenderUtilFuncLib:GetSceneViewPreExposure")]
	public unsafe static float GetSceneViewPreExposure(AActor WorldContext)
	{
		if (!GetSceneViewPreExposure_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_RenderUtilFuncLib:GetSceneViewPreExposure");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSceneViewPreExposure_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSceneViewPreExposure_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetSceneViewPreExposure_WorldContext_Offset), 0, GetSceneViewPreExposure_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSceneViewPreExposure_FunctionAddress, intPtr, GetSceneViewPreExposure_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSceneViewPreExposure_ReturnValue_Offset), 0, GetSceneViewPreExposure_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_RenderUtilFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_RenderUtilFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_RenderUtilFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_RenderUtilFuncLib");
		SetRenderCustomDepth_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRenderCustomDepth");
		SetRenderCustomDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderCustomDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderCustomDepth_AA_PropertyAddress, SetRenderCustomDepth_FunctionAddress, "AA");
		SetRenderCustomDepth_AA_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderCustomDepth_FunctionAddress, "AA");
		SetRenderCustomDepth_AA_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderCustomDepth_FunctionAddress, "AA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRenderCustomDepth_bValue_PropertyAddress, SetRenderCustomDepth_FunctionAddress, "bValue");
		SetRenderCustomDepth_bValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderCustomDepth_FunctionAddress, "bValue");
		SetRenderCustomDepth_bValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderCustomDepth_FunctionAddress, "bValue", Classes.FBoolProperty);
		SetRenderCustomDepth_IsValid = SetRenderCustomDepth_FunctionAddress != IntPtr.Zero && SetRenderCustomDepth_AA_IsValid && SetRenderCustomDepth_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_RenderUtilFuncLib:SetRenderCustomDepth", SetRenderCustomDepth_IsValid);
		PlayCameraShake_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PlayCameraShake");
		PlayCameraShake_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayCameraShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraShake_CameraShakeCls_PropertyAddress, PlayCameraShake_FunctionAddress, "CameraShakeCls");
		PlayCameraShake_CameraShakeCls_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraShake_FunctionAddress, "CameraShakeCls");
		PlayCameraShake_CameraShakeCls_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraShake_FunctionAddress, "CameraShakeCls", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraShake_Camera_PropertyAddress, PlayCameraShake_FunctionAddress, "Camera");
		PlayCameraShake_Camera_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraShake_FunctionAddress, "Camera");
		PlayCameraShake_Camera_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraShake_FunctionAddress, "Camera", Classes.FObjectProperty);
		PlayCameraShake_IsValid = PlayCameraShake_FunctionAddress != IntPtr.Zero && PlayCameraShake_CameraShakeCls_IsValid && PlayCameraShake_Camera_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_RenderUtilFuncLib:PlayCameraShake", PlayCameraShake_IsValid);
		OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OverrideSystemUserVariableSKMFilteredSockets");
		OverrideSystemUserVariableSKMFilteredSockets_ParamsSize = NativeReflection.GetFunctionParamsSize(OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableSKMFilteredSockets_NiagaraSystem_PropertyAddress, OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress, "NiagaraSystem");
		OverrideSystemUserVariableSKMFilteredSockets_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress, "NiagaraSystem");
		OverrideSystemUserVariableSKMFilteredSockets_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableSKMFilteredSockets_OverrideName_PropertyAddress, OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress, "OverrideName");
		OverrideSystemUserVariableSKMFilteredSockets_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress, "OverrideName");
		OverrideSystemUserVariableSKMFilteredSockets_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress, "OverrideName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableSKMFilteredSockets_OverrideFilteredSockets_PropertyAddress, OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress, "OverrideFilteredSockets");
		OverrideSystemUserVariableSKMFilteredSockets_OverrideFilteredSockets_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress, "OverrideFilteredSockets");
		OverrideSystemUserVariableSKMFilteredSockets_OverrideFilteredSockets_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress, "OverrideFilteredSockets", Classes.FArrayProperty);
		OverrideSystemUserVariableSKMFilteredSockets_IsValid = OverrideSystemUserVariableSKMFilteredSockets_FunctionAddress != IntPtr.Zero && OverrideSystemUserVariableSKMFilteredSockets_NiagaraSystem_IsValid && OverrideSystemUserVariableSKMFilteredSockets_OverrideName_IsValid && OverrideSystemUserVariableSKMFilteredSockets_OverrideFilteredSockets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_RenderUtilFuncLib:OverrideSystemUserVariableSKMFilteredSockets", OverrideSystemUserVariableSKMFilteredSockets_IsValid);
		OverrideSystemUserVariableSKMFilteredBones_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OverrideSystemUserVariableSKMFilteredBones");
		OverrideSystemUserVariableSKMFilteredBones_ParamsSize = NativeReflection.GetFunctionParamsSize(OverrideSystemUserVariableSKMFilteredBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableSKMFilteredBones_NiagaraSystem_PropertyAddress, OverrideSystemUserVariableSKMFilteredBones_FunctionAddress, "NiagaraSystem");
		OverrideSystemUserVariableSKMFilteredBones_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableSKMFilteredBones_FunctionAddress, "NiagaraSystem");
		OverrideSystemUserVariableSKMFilteredBones_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableSKMFilteredBones_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableSKMFilteredBones_OverrideName_PropertyAddress, OverrideSystemUserVariableSKMFilteredBones_FunctionAddress, "OverrideName");
		OverrideSystemUserVariableSKMFilteredBones_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableSKMFilteredBones_FunctionAddress, "OverrideName");
		OverrideSystemUserVariableSKMFilteredBones_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableSKMFilteredBones_FunctionAddress, "OverrideName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableSKMFilteredBones_OverrideFilteredBones_PropertyAddress, OverrideSystemUserVariableSKMFilteredBones_FunctionAddress, "OverrideFilteredBones");
		OverrideSystemUserVariableSKMFilteredBones_OverrideFilteredBones_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableSKMFilteredBones_FunctionAddress, "OverrideFilteredBones");
		OverrideSystemUserVariableSKMFilteredBones_OverrideFilteredBones_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableSKMFilteredBones_FunctionAddress, "OverrideFilteredBones", Classes.FArrayProperty);
		OverrideSystemUserVariableSKMFilteredBones_IsValid = OverrideSystemUserVariableSKMFilteredBones_FunctionAddress != IntPtr.Zero && OverrideSystemUserVariableSKMFilteredBones_NiagaraSystem_IsValid && OverrideSystemUserVariableSKMFilteredBones_OverrideName_IsValid && OverrideSystemUserVariableSKMFilteredBones_OverrideFilteredBones_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_RenderUtilFuncLib:OverrideSystemUserVariableSKMFilteredBones", OverrideSystemUserVariableSKMFilteredBones_IsValid);
		MarkRenderStateDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkRenderStateDirty");
		MarkRenderStateDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkRenderStateDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkRenderStateDirty_ActorComponent_PropertyAddress, MarkRenderStateDirty_FunctionAddress, "ActorComponent");
		MarkRenderStateDirty_ActorComponent_Offset = NativeReflectionCached.GetPropertyOffset(MarkRenderStateDirty_FunctionAddress, "ActorComponent");
		MarkRenderStateDirty_ActorComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkRenderStateDirty_FunctionAddress, "ActorComponent", Classes.FObjectProperty);
		MarkRenderStateDirty_IsValid = MarkRenderStateDirty_FunctionAddress != IntPtr.Zero && MarkRenderStateDirty_ActorComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_RenderUtilFuncLib:MarkRenderStateDirty", MarkRenderStateDirty_IsValid);
		GetSceneViewPreExposure_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSceneViewPreExposure");
		GetSceneViewPreExposure_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSceneViewPreExposure_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSceneViewPreExposure_WorldContext_PropertyAddress, GetSceneViewPreExposure_FunctionAddress, "WorldContext");
		GetSceneViewPreExposure_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneViewPreExposure_FunctionAddress, "WorldContext");
		GetSceneViewPreExposure_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneViewPreExposure_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSceneViewPreExposure_ReturnValue_PropertyAddress, GetSceneViewPreExposure_FunctionAddress, "ReturnValue");
		GetSceneViewPreExposure_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneViewPreExposure_FunctionAddress, "ReturnValue");
		GetSceneViewPreExposure_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneViewPreExposure_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSceneViewPreExposure_IsValid = GetSceneViewPreExposure_FunctionAddress != IntPtr.Zero && GetSceneViewPreExposure_WorldContext_IsValid && GetSceneViewPreExposure_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_RenderUtilFuncLib:GetSceneViewPreExposure", GetSceneViewPreExposure_IsValid);
	}
}
