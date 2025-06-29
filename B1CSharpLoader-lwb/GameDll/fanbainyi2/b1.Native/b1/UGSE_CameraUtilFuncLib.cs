using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_CameraUtilFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_CameraUtilFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetLocalPlayerAspectRatioAxisConstraint_IsValid;

	private static IntPtr SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress;

	private static int SetLocalPlayerAspectRatioAxisConstraint_ParamsSize;

	private static bool SetLocalPlayerAspectRatioAxisConstraint_PlayerController_IsValid;

	private static FFieldAddress SetLocalPlayerAspectRatioAxisConstraint_PlayerController_PropertyAddress;

	private static int SetLocalPlayerAspectRatioAxisConstraint_PlayerController_Offset;

	private static bool SetLocalPlayerAspectRatioAxisConstraint_TargetAspectRatioAxisConstraint_IsValid;

	private static FFieldAddress SetLocalPlayerAspectRatioAxisConstraint_TargetAspectRatioAxisConstraint_PropertyAddress;

	private static int SetLocalPlayerAspectRatioAxisConstraint_TargetAspectRatioAxisConstraint_Offset;

	private static bool SetLocalPlayerAspectRatioAxisConstraint_ReturnValue_IsValid;

	private static FFieldAddress SetLocalPlayerAspectRatioAxisConstraint_ReturnValue_PropertyAddress;

	private static int SetLocalPlayerAspectRatioAxisConstraint_ReturnValue_Offset;

	private static bool SetCameraFocalParams_IsValid;

	private static IntPtr SetCameraFocalParams_FunctionAddress;

	private static int SetCameraFocalParams_ParamsSize;

	private static bool SetCameraFocalParams_InCamera_IsValid;

	private static FFieldAddress SetCameraFocalParams_InCamera_PropertyAddress;

	private static int SetCameraFocalParams_InCamera_Offset;

	private static bool SetCameraFocalParams_InFocalDistance_IsValid;

	private static FFieldAddress SetCameraFocalParams_InFocalDistance_PropertyAddress;

	private static int SetCameraFocalParams_InFocalDistance_Offset;

	private static bool SetCameraFocalParams_InDepthBlurKm_IsValid;

	private static FFieldAddress SetCameraFocalParams_InDepthBlurKm_PropertyAddress;

	private static int SetCameraFocalParams_InDepthBlurKm_Offset;

	private static bool SetCameraFocalParams_DepthBlurRadius_IsValid;

	private static FFieldAddress SetCameraFocalParams_DepthBlurRadius_PropertyAddress;

	private static int SetCameraFocalParams_DepthBlurRadius_Offset;

	private static bool IsPositionInScreenViewport_IsValid;

	private static IntPtr IsPositionInScreenViewport_FunctionAddress;

	private static int IsPositionInScreenViewport_ParamsSize;

	private static bool IsPositionInScreenViewport_WorldContext_IsValid;

	private static FFieldAddress IsPositionInScreenViewport_WorldContext_PropertyAddress;

	private static int IsPositionInScreenViewport_WorldContext_Offset;

	private static bool IsPositionInScreenViewport_Position_IsValid;

	private static FFieldAddress IsPositionInScreenViewport_Position_PropertyAddress;

	private static int IsPositionInScreenViewport_Position_Offset;

	private static bool IsPositionInScreenViewport_ReturnValue_IsValid;

	private static FFieldAddress IsPositionInScreenViewport_ReturnValue_PropertyAddress;

	private static int IsPositionInScreenViewport_ReturnValue_Offset;

	private static bool GetCameraViewTarget_IsValid;

	private static IntPtr GetCameraViewTarget_FunctionAddress;

	private static int GetCameraViewTarget_ParamsSize;

	private static bool GetCameraViewTarget_CameraManager_IsValid;

	private static FFieldAddress GetCameraViewTarget_CameraManager_PropertyAddress;

	private static int GetCameraViewTarget_CameraManager_Offset;

	private static bool GetCameraViewTarget_ReturnValue_IsValid;

	private static FFieldAddress GetCameraViewTarget_ReturnValue_PropertyAddress;

	private static int GetCameraViewTarget_ReturnValue_Offset;

	private static bool GetCameraFocalParams_IsValid;

	private static IntPtr GetCameraFocalParams_FunctionAddress;

	private static int GetCameraFocalParams_ParamsSize;

	private static bool GetCameraFocalParams_InCamera_IsValid;

	private static FFieldAddress GetCameraFocalParams_InCamera_PropertyAddress;

	private static int GetCameraFocalParams_InCamera_Offset;

	private static bool GetCameraFocalParams_OutFocalDistance_IsValid;

	private static FFieldAddress GetCameraFocalParams_OutFocalDistance_PropertyAddress;

	private static int GetCameraFocalParams_OutFocalDistance_Offset;

	private static bool GetCameraFocalParams_OutDepthBlurKm_IsValid;

	private static FFieldAddress GetCameraFocalParams_OutDepthBlurKm_PropertyAddress;

	private static int GetCameraFocalParams_OutDepthBlurKm_Offset;

	private static bool GetCameraFocalParams_OutDepthBlurRadius_IsValid;

	private static FFieldAddress GetCameraFocalParams_OutDepthBlurRadius_PropertyAddress;

	private static int GetCameraFocalParams_OutDepthBlurRadius_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CameraUtilFuncLib:SetLocalPlayerAspectRatioAxisConstraint")]
	public unsafe static bool SetLocalPlayerAspectRatioAxisConstraint(APlayerController PlayerController, EAspectRatioAxisConstraint TargetAspectRatioAxisConstraint)
	{
		if (!SetLocalPlayerAspectRatioAxisConstraint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CameraUtilFuncLib:SetLocalPlayerAspectRatioAxisConstraint");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalPlayerAspectRatioAxisConstraint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalPlayerAspectRatioAxisConstraint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetLocalPlayerAspectRatioAxisConstraint_PlayerController_Offset), 0, SetLocalPlayerAspectRatioAxisConstraint_PlayerController_PropertyAddress.Address, PlayerController);
		EnumMarshaler<EAspectRatioAxisConstraint>.ToNative(IntPtr.Add(intPtr, SetLocalPlayerAspectRatioAxisConstraint_TargetAspectRatioAxisConstraint_Offset), 0, SetLocalPlayerAspectRatioAxisConstraint_TargetAspectRatioAxisConstraint_PropertyAddress.Address, TargetAspectRatioAxisConstraint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress, intPtr, SetLocalPlayerAspectRatioAxisConstraint_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetLocalPlayerAspectRatioAxisConstraint_ReturnValue_Offset), 0, SetLocalPlayerAspectRatioAxisConstraint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CameraUtilFuncLib:SetCameraFocalParams")]
	public unsafe static void SetCameraFocalParams(UCameraComponent InCamera, float InFocalDistance, float InDepthBlurKm, float DepthBlurRadius)
	{
		if (!SetCameraFocalParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CameraUtilFuncLib:SetCameraFocalParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCameraFocalParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCameraFocalParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraComponent>.ToNative(IntPtr.Add(intPtr, SetCameraFocalParams_InCamera_Offset), 0, SetCameraFocalParams_InCamera_PropertyAddress.Address, InCamera);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCameraFocalParams_InFocalDistance_Offset), 0, SetCameraFocalParams_InFocalDistance_PropertyAddress.Address, InFocalDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCameraFocalParams_InDepthBlurKm_Offset), 0, SetCameraFocalParams_InDepthBlurKm_PropertyAddress.Address, InDepthBlurKm);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCameraFocalParams_DepthBlurRadius_Offset), 0, SetCameraFocalParams_DepthBlurRadius_PropertyAddress.Address, DepthBlurRadius);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCameraFocalParams_FunctionAddress, intPtr, SetCameraFocalParams_ParamsSize);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CameraUtilFuncLib:IsPositionInScreenViewport")]
	public unsafe static bool IsPositionInScreenViewport(UObject WorldContext, FVector Position)
	{
		if (!IsPositionInScreenViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CameraUtilFuncLib:IsPositionInScreenViewport");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPositionInScreenViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPositionInScreenViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsPositionInScreenViewport_WorldContext_Offset), 0, IsPositionInScreenViewport_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsPositionInScreenViewport_Position_Offset), 0, IsPositionInScreenViewport_Position_PropertyAddress.Address, Position);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPositionInScreenViewport_FunctionAddress, intPtr, IsPositionInScreenViewport_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPositionInScreenViewport_ReturnValue_Offset), 0, IsPositionInScreenViewport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CameraUtilFuncLib:GetCameraViewTarget")]
	public unsafe static AActor GetCameraViewTarget(APlayerCameraManager CameraManager)
	{
		if (!GetCameraViewTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CameraUtilFuncLib:GetCameraViewTarget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraViewTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraViewTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerCameraManager>.ToNative(IntPtr.Add(intPtr, GetCameraViewTarget_CameraManager_Offset), 0, GetCameraViewTarget_CameraManager_PropertyAddress.Address, CameraManager);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCameraViewTarget_FunctionAddress, intPtr, GetCameraViewTarget_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetCameraViewTarget_ReturnValue_Offset), 0, GetCameraViewTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CameraUtilFuncLib:GetCameraFocalParams")]
	public unsafe static void GetCameraFocalParams(UCameraComponent InCamera, out float OutFocalDistance, out float OutDepthBlurKm, out float OutDepthBlurRadius)
	{
		if (!GetCameraFocalParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CameraUtilFuncLib:GetCameraFocalParams");
			OutFocalDistance = 0f;
			OutDepthBlurKm = 0f;
			OutDepthBlurRadius = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraFocalParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraFocalParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraComponent>.ToNative(IntPtr.Add(intPtr, GetCameraFocalParams_InCamera_Offset), 0, GetCameraFocalParams_InCamera_PropertyAddress.Address, InCamera);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCameraFocalParams_FunctionAddress, intPtr, GetCameraFocalParams_ParamsSize);
		OutFocalDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCameraFocalParams_OutFocalDistance_Offset), 0, GetCameraFocalParams_OutFocalDistance_PropertyAddress.Address);
		OutDepthBlurKm = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCameraFocalParams_OutDepthBlurKm_Offset), 0, GetCameraFocalParams_OutDepthBlurKm_PropertyAddress.Address);
		OutDepthBlurRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCameraFocalParams_OutDepthBlurRadius_Offset), 0, GetCameraFocalParams_OutDepthBlurRadius_PropertyAddress.Address);
	}

	static UGSE_CameraUtilFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_CameraUtilFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_CameraUtilFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_CameraUtilFuncLib");
		SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLocalPlayerAspectRatioAxisConstraint");
		SetLocalPlayerAspectRatioAxisConstraint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocalPlayerAspectRatioAxisConstraint_PlayerController_PropertyAddress, SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress, "PlayerController");
		SetLocalPlayerAspectRatioAxisConstraint_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress, "PlayerController");
		SetLocalPlayerAspectRatioAxisConstraint_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalPlayerAspectRatioAxisConstraint_TargetAspectRatioAxisConstraint_PropertyAddress, SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress, "TargetAspectRatioAxisConstraint");
		SetLocalPlayerAspectRatioAxisConstraint_TargetAspectRatioAxisConstraint_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress, "TargetAspectRatioAxisConstraint");
		SetLocalPlayerAspectRatioAxisConstraint_TargetAspectRatioAxisConstraint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress, "TargetAspectRatioAxisConstraint", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalPlayerAspectRatioAxisConstraint_ReturnValue_PropertyAddress, SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress, "ReturnValue");
		SetLocalPlayerAspectRatioAxisConstraint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress, "ReturnValue");
		SetLocalPlayerAspectRatioAxisConstraint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetLocalPlayerAspectRatioAxisConstraint_IsValid = SetLocalPlayerAspectRatioAxisConstraint_FunctionAddress != IntPtr.Zero && SetLocalPlayerAspectRatioAxisConstraint_PlayerController_IsValid && SetLocalPlayerAspectRatioAxisConstraint_TargetAspectRatioAxisConstraint_IsValid && SetLocalPlayerAspectRatioAxisConstraint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CameraUtilFuncLib:SetLocalPlayerAspectRatioAxisConstraint", SetLocalPlayerAspectRatioAxisConstraint_IsValid);
		SetCameraFocalParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCameraFocalParams");
		SetCameraFocalParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCameraFocalParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCameraFocalParams_InCamera_PropertyAddress, SetCameraFocalParams_FunctionAddress, "InCamera");
		SetCameraFocalParams_InCamera_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraFocalParams_FunctionAddress, "InCamera");
		SetCameraFocalParams_InCamera_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraFocalParams_FunctionAddress, "InCamera", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCameraFocalParams_InFocalDistance_PropertyAddress, SetCameraFocalParams_FunctionAddress, "InFocalDistance");
		SetCameraFocalParams_InFocalDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraFocalParams_FunctionAddress, "InFocalDistance");
		SetCameraFocalParams_InFocalDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraFocalParams_FunctionAddress, "InFocalDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCameraFocalParams_InDepthBlurKm_PropertyAddress, SetCameraFocalParams_FunctionAddress, "InDepthBlurKm");
		SetCameraFocalParams_InDepthBlurKm_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraFocalParams_FunctionAddress, "InDepthBlurKm");
		SetCameraFocalParams_InDepthBlurKm_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraFocalParams_FunctionAddress, "InDepthBlurKm", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCameraFocalParams_DepthBlurRadius_PropertyAddress, SetCameraFocalParams_FunctionAddress, "DepthBlurRadius");
		SetCameraFocalParams_DepthBlurRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraFocalParams_FunctionAddress, "DepthBlurRadius");
		SetCameraFocalParams_DepthBlurRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraFocalParams_FunctionAddress, "DepthBlurRadius", Classes.FFloatProperty);
		SetCameraFocalParams_IsValid = SetCameraFocalParams_FunctionAddress != IntPtr.Zero && SetCameraFocalParams_InCamera_IsValid && SetCameraFocalParams_InFocalDistance_IsValid && SetCameraFocalParams_InDepthBlurKm_IsValid && SetCameraFocalParams_DepthBlurRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CameraUtilFuncLib:SetCameraFocalParams", SetCameraFocalParams_IsValid);
		IsPositionInScreenViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPositionInScreenViewport");
		IsPositionInScreenViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPositionInScreenViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPositionInScreenViewport_WorldContext_PropertyAddress, IsPositionInScreenViewport_FunctionAddress, "WorldContext");
		IsPositionInScreenViewport_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(IsPositionInScreenViewport_FunctionAddress, "WorldContext");
		IsPositionInScreenViewport_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPositionInScreenViewport_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPositionInScreenViewport_Position_PropertyAddress, IsPositionInScreenViewport_FunctionAddress, "Position");
		IsPositionInScreenViewport_Position_Offset = NativeReflectionCached.GetPropertyOffset(IsPositionInScreenViewport_FunctionAddress, "Position");
		IsPositionInScreenViewport_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPositionInScreenViewport_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPositionInScreenViewport_ReturnValue_PropertyAddress, IsPositionInScreenViewport_FunctionAddress, "ReturnValue");
		IsPositionInScreenViewport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPositionInScreenViewport_FunctionAddress, "ReturnValue");
		IsPositionInScreenViewport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPositionInScreenViewport_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPositionInScreenViewport_IsValid = IsPositionInScreenViewport_FunctionAddress != IntPtr.Zero && IsPositionInScreenViewport_WorldContext_IsValid && IsPositionInScreenViewport_Position_IsValid && IsPositionInScreenViewport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CameraUtilFuncLib:IsPositionInScreenViewport", IsPositionInScreenViewport_IsValid);
		GetCameraViewTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCameraViewTarget");
		GetCameraViewTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraViewTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraViewTarget_CameraManager_PropertyAddress, GetCameraViewTarget_FunctionAddress, "CameraManager");
		GetCameraViewTarget_CameraManager_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraViewTarget_FunctionAddress, "CameraManager");
		GetCameraViewTarget_CameraManager_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraViewTarget_FunctionAddress, "CameraManager", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCameraViewTarget_ReturnValue_PropertyAddress, GetCameraViewTarget_FunctionAddress, "ReturnValue");
		GetCameraViewTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraViewTarget_FunctionAddress, "ReturnValue");
		GetCameraViewTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraViewTarget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCameraViewTarget_IsValid = GetCameraViewTarget_FunctionAddress != IntPtr.Zero && GetCameraViewTarget_CameraManager_IsValid && GetCameraViewTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CameraUtilFuncLib:GetCameraViewTarget", GetCameraViewTarget_IsValid);
		GetCameraFocalParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCameraFocalParams");
		GetCameraFocalParams_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraFocalParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraFocalParams_InCamera_PropertyAddress, GetCameraFocalParams_FunctionAddress, "InCamera");
		GetCameraFocalParams_InCamera_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraFocalParams_FunctionAddress, "InCamera");
		GetCameraFocalParams_InCamera_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraFocalParams_FunctionAddress, "InCamera", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCameraFocalParams_OutFocalDistance_PropertyAddress, GetCameraFocalParams_FunctionAddress, "OutFocalDistance");
		GetCameraFocalParams_OutFocalDistance_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraFocalParams_FunctionAddress, "OutFocalDistance");
		GetCameraFocalParams_OutFocalDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraFocalParams_FunctionAddress, "OutFocalDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCameraFocalParams_OutDepthBlurKm_PropertyAddress, GetCameraFocalParams_FunctionAddress, "OutDepthBlurKm");
		GetCameraFocalParams_OutDepthBlurKm_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraFocalParams_FunctionAddress, "OutDepthBlurKm");
		GetCameraFocalParams_OutDepthBlurKm_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraFocalParams_FunctionAddress, "OutDepthBlurKm", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCameraFocalParams_OutDepthBlurRadius_PropertyAddress, GetCameraFocalParams_FunctionAddress, "OutDepthBlurRadius");
		GetCameraFocalParams_OutDepthBlurRadius_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraFocalParams_FunctionAddress, "OutDepthBlurRadius");
		GetCameraFocalParams_OutDepthBlurRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraFocalParams_FunctionAddress, "OutDepthBlurRadius", Classes.FFloatProperty);
		GetCameraFocalParams_IsValid = GetCameraFocalParams_FunctionAddress != IntPtr.Zero && GetCameraFocalParams_InCamera_IsValid && GetCameraFocalParams_OutFocalDistance_IsValid && GetCameraFocalParams_OutDepthBlurKm_IsValid && GetCameraFocalParams_OutDepthBlurRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CameraUtilFuncLib:GetCameraFocalParams", GetCameraFocalParams_IsValid);
	}
}
