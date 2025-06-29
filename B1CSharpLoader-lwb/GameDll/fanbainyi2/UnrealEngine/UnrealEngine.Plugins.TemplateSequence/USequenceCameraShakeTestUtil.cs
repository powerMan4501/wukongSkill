using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.TemplateSequence;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/TemplateSequence.SequenceCameraShakeTestUtil", "TemplateSequence", UnrealModuleType.EnginePlugin)]
public class USequenceCameraShakeTestUtil : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetPostProcessBlendCache_IsValid;

	private static IntPtr GetPostProcessBlendCache_FunctionAddress;

	private static int GetPostProcessBlendCache_ParamsSize;

	private static bool GetPostProcessBlendCache_PlayerController_IsValid;

	private static FFieldAddress GetPostProcessBlendCache_PlayerController_PropertyAddress;

	private static int GetPostProcessBlendCache_PlayerController_Offset;

	private static bool GetPostProcessBlendCache_PPIndex_IsValid;

	private static FFieldAddress GetPostProcessBlendCache_PPIndex_PropertyAddress;

	private static int GetPostProcessBlendCache_PPIndex_Offset;

	private static bool GetPostProcessBlendCache_OutPPSettings_IsValid;

	private static FFieldAddress GetPostProcessBlendCache_OutPPSettings_PropertyAddress;

	private static int GetPostProcessBlendCache_OutPPSettings_Offset;

	private static bool GetPostProcessBlendCache_OutPPBlendWeight_IsValid;

	private static FFieldAddress GetPostProcessBlendCache_OutPPBlendWeight_PropertyAddress;

	private static int GetPostProcessBlendCache_OutPPBlendWeight_Offset;

	private static bool GetPostProcessBlendCache_ReturnValue_IsValid;

	private static FFieldAddress GetPostProcessBlendCache_ReturnValue_PropertyAddress;

	private static int GetPostProcessBlendCache_ReturnValue_Offset;

	private static bool GetLastFrameCameraCachePOV_IsValid;

	private static IntPtr GetLastFrameCameraCachePOV_FunctionAddress;

	private static int GetLastFrameCameraCachePOV_ParamsSize;

	private static bool GetLastFrameCameraCachePOV_PlayerController_IsValid;

	private static FFieldAddress GetLastFrameCameraCachePOV_PlayerController_PropertyAddress;

	private static int GetLastFrameCameraCachePOV_PlayerController_Offset;

	private static bool GetLastFrameCameraCachePOV_ReturnValue_IsValid;

	private static FFieldAddress GetLastFrameCameraCachePOV_ReturnValue_PropertyAddress;

	private static int GetLastFrameCameraCachePOV_ReturnValue_Offset;

	private static bool GetCameraCachePOV_IsValid;

	private static IntPtr GetCameraCachePOV_FunctionAddress;

	private static int GetCameraCachePOV_ParamsSize;

	private static bool GetCameraCachePOV_PlayerController_IsValid;

	private static FFieldAddress GetCameraCachePOV_PlayerController_PropertyAddress;

	private static int GetCameraCachePOV_PlayerController_Offset;

	private static bool GetCameraCachePOV_ReturnValue_IsValid;

	private static FFieldAddress GetCameraCachePOV_ReturnValue_PropertyAddress;

	private static int GetCameraCachePOV_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/TemplateSequence.SequenceCameraShakeTestUtil:GetPostProcessBlendCache")]
	public unsafe static bool GetPostProcessBlendCache(APlayerController PlayerController, int PPIndex, out FPostProcessSettings OutPPSettings, out float OutPPBlendWeight)
	{
		if (!GetPostProcessBlendCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TemplateSequence.SequenceCameraShakeTestUtil:GetPostProcessBlendCache");
			OutPPSettings = default(FPostProcessSettings);
			OutPPBlendWeight = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPostProcessBlendCache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPostProcessBlendCache_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetPostProcessBlendCache_PlayerController_Offset), 0, GetPostProcessBlendCache_PlayerController_PropertyAddress.Address, PlayerController);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetPostProcessBlendCache_PPIndex_Offset), 0, GetPostProcessBlendCache_PPIndex_PropertyAddress.Address, PPIndex);
		NativeReflection.InitializeValue_InContainer(GetPostProcessBlendCache_OutPPSettings_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPostProcessBlendCache_FunctionAddress, intPtr, GetPostProcessBlendCache_ParamsSize);
		OutPPSettings = FPostProcessSettings.FromNative(IntPtr.Add(intPtr, GetPostProcessBlendCache_OutPPSettings_Offset), 0, GetPostProcessBlendCache_OutPPSettings_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPostProcessBlendCache_OutPPSettings_PropertyAddress.Address, intPtr);
		OutPPBlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPostProcessBlendCache_OutPPBlendWeight_Offset), 0, GetPostProcessBlendCache_OutPPBlendWeight_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetPostProcessBlendCache_ReturnValue_Offset), 0, GetPostProcessBlendCache_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/TemplateSequence.SequenceCameraShakeTestUtil:GetLastFrameCameraCachePOV")]
	public unsafe static FMinimalViewInfo GetLastFrameCameraCachePOV(APlayerController PlayerController)
	{
		if (!GetLastFrameCameraCachePOV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TemplateSequence.SequenceCameraShakeTestUtil:GetLastFrameCameraCachePOV");
			return default(FMinimalViewInfo);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastFrameCameraCachePOV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastFrameCameraCachePOV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetLastFrameCameraCachePOV_PlayerController_Offset), 0, GetLastFrameCameraCachePOV_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLastFrameCameraCachePOV_FunctionAddress, intPtr, GetLastFrameCameraCachePOV_ParamsSize);
		FMinimalViewInfo result = FMinimalViewInfo.FromNative(IntPtr.Add(intPtr, GetLastFrameCameraCachePOV_ReturnValue_Offset), 0, GetLastFrameCameraCachePOV_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLastFrameCameraCachePOV_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/TemplateSequence.SequenceCameraShakeTestUtil:GetCameraCachePOV")]
	public unsafe static FMinimalViewInfo GetCameraCachePOV(APlayerController PlayerController)
	{
		if (!GetCameraCachePOV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TemplateSequence.SequenceCameraShakeTestUtil:GetCameraCachePOV");
			return default(FMinimalViewInfo);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraCachePOV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraCachePOV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetCameraCachePOV_PlayerController_Offset), 0, GetCameraCachePOV_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCameraCachePOV_FunctionAddress, intPtr, GetCameraCachePOV_ParamsSize);
		FMinimalViewInfo result = FMinimalViewInfo.FromNative(IntPtr.Add(intPtr, GetCameraCachePOV_ReturnValue_Offset), 0, GetCameraCachePOV_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCameraCachePOV_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static USequenceCameraShakeTestUtil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USequenceCameraShakeTestUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USequenceCameraShakeTestUtil));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/TemplateSequence.SequenceCameraShakeTestUtil");
		GetPostProcessBlendCache_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPostProcessBlendCache");
		GetPostProcessBlendCache_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPostProcessBlendCache_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPostProcessBlendCache_PlayerController_PropertyAddress, GetPostProcessBlendCache_FunctionAddress, "PlayerController");
		GetPostProcessBlendCache_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetPostProcessBlendCache_FunctionAddress, "PlayerController");
		GetPostProcessBlendCache_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPostProcessBlendCache_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPostProcessBlendCache_PPIndex_PropertyAddress, GetPostProcessBlendCache_FunctionAddress, "PPIndex");
		GetPostProcessBlendCache_PPIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetPostProcessBlendCache_FunctionAddress, "PPIndex");
		GetPostProcessBlendCache_PPIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPostProcessBlendCache_FunctionAddress, "PPIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPostProcessBlendCache_OutPPSettings_PropertyAddress, GetPostProcessBlendCache_FunctionAddress, "OutPPSettings");
		GetPostProcessBlendCache_OutPPSettings_Offset = NativeReflectionCached.GetPropertyOffset(GetPostProcessBlendCache_FunctionAddress, "OutPPSettings");
		GetPostProcessBlendCache_OutPPSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPostProcessBlendCache_FunctionAddress, "OutPPSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPostProcessBlendCache_OutPPBlendWeight_PropertyAddress, GetPostProcessBlendCache_FunctionAddress, "OutPPBlendWeight");
		GetPostProcessBlendCache_OutPPBlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(GetPostProcessBlendCache_FunctionAddress, "OutPPBlendWeight");
		GetPostProcessBlendCache_OutPPBlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPostProcessBlendCache_FunctionAddress, "OutPPBlendWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPostProcessBlendCache_ReturnValue_PropertyAddress, GetPostProcessBlendCache_FunctionAddress, "ReturnValue");
		GetPostProcessBlendCache_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPostProcessBlendCache_FunctionAddress, "ReturnValue");
		GetPostProcessBlendCache_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPostProcessBlendCache_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetPostProcessBlendCache_IsValid = GetPostProcessBlendCache_FunctionAddress != IntPtr.Zero && GetPostProcessBlendCache_PlayerController_IsValid && GetPostProcessBlendCache_PPIndex_IsValid && GetPostProcessBlendCache_OutPPSettings_IsValid && GetPostProcessBlendCache_OutPPBlendWeight_IsValid && GetPostProcessBlendCache_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TemplateSequence.SequenceCameraShakeTestUtil:GetPostProcessBlendCache", GetPostProcessBlendCache_IsValid);
		GetLastFrameCameraCachePOV_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLastFrameCameraCachePOV");
		GetLastFrameCameraCachePOV_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastFrameCameraCachePOV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastFrameCameraCachePOV_PlayerController_PropertyAddress, GetLastFrameCameraCachePOV_FunctionAddress, "PlayerController");
		GetLastFrameCameraCachePOV_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetLastFrameCameraCachePOV_FunctionAddress, "PlayerController");
		GetLastFrameCameraCachePOV_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastFrameCameraCachePOV_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLastFrameCameraCachePOV_ReturnValue_PropertyAddress, GetLastFrameCameraCachePOV_FunctionAddress, "ReturnValue");
		GetLastFrameCameraCachePOV_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastFrameCameraCachePOV_FunctionAddress, "ReturnValue");
		GetLastFrameCameraCachePOV_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastFrameCameraCachePOV_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastFrameCameraCachePOV_IsValid = GetLastFrameCameraCachePOV_FunctionAddress != IntPtr.Zero && GetLastFrameCameraCachePOV_PlayerController_IsValid && GetLastFrameCameraCachePOV_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TemplateSequence.SequenceCameraShakeTestUtil:GetLastFrameCameraCachePOV", GetLastFrameCameraCachePOV_IsValid);
		GetCameraCachePOV_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCameraCachePOV");
		GetCameraCachePOV_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraCachePOV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraCachePOV_PlayerController_PropertyAddress, GetCameraCachePOV_FunctionAddress, "PlayerController");
		GetCameraCachePOV_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraCachePOV_FunctionAddress, "PlayerController");
		GetCameraCachePOV_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraCachePOV_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCameraCachePOV_ReturnValue_PropertyAddress, GetCameraCachePOV_FunctionAddress, "ReturnValue");
		GetCameraCachePOV_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraCachePOV_FunctionAddress, "ReturnValue");
		GetCameraCachePOV_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraCachePOV_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCameraCachePOV_IsValid = GetCameraCachePOV_FunctionAddress != IntPtr.Zero && GetCameraCachePOV_PlayerController_IsValid && GetCameraCachePOV_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TemplateSequence.SequenceCameraShakeTestUtil:GetCameraCachePOV", GetCameraCachePOV_IsValid);
	}
}
