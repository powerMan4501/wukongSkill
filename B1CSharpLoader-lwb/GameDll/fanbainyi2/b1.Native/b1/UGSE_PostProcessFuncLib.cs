using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_PostProcessFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_PostProcessFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetPPVWeightedBlendableWeightByIndex_IsValid;

	private static IntPtr SetPPVWeightedBlendableWeightByIndex_FunctionAddress;

	private static int SetPPVWeightedBlendableWeightByIndex_ParamsSize;

	private static bool SetPPVWeightedBlendableWeightByIndex_PPV_IsValid;

	private static FFieldAddress SetPPVWeightedBlendableWeightByIndex_PPV_PropertyAddress;

	private static int SetPPVWeightedBlendableWeightByIndex_PPV_Offset;

	private static bool SetPPVWeightedBlendableWeightByIndex_PPMatIndex_IsValid;

	private static FFieldAddress SetPPVWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress;

	private static int SetPPVWeightedBlendableWeightByIndex_PPMatIndex_Offset;

	private static bool SetPPVWeightedBlendableWeightByIndex_Weight_IsValid;

	private static FFieldAddress SetPPVWeightedBlendableWeightByIndex_Weight_PropertyAddress;

	private static int SetPPVWeightedBlendableWeightByIndex_Weight_Offset;

	private static bool SetPPVWeightedBlendableWeight_IsValid;

	private static IntPtr SetPPVWeightedBlendableWeight_FunctionAddress;

	private static int SetPPVWeightedBlendableWeight_ParamsSize;

	private static bool SetPPVWeightedBlendableWeight_PPV_IsValid;

	private static FFieldAddress SetPPVWeightedBlendableWeight_PPV_PropertyAddress;

	private static int SetPPVWeightedBlendableWeight_PPV_Offset;

	private static bool SetPPVWeightedBlendableWeight_PPMaterialInterface_IsValid;

	private static FFieldAddress SetPPVWeightedBlendableWeight_PPMaterialInterface_PropertyAddress;

	private static int SetPPVWeightedBlendableWeight_PPMaterialInterface_Offset;

	private static bool SetPPVWeightedBlendableWeight_Weight_IsValid;

	private static FFieldAddress SetPPVWeightedBlendableWeight_Weight_PropertyAddress;

	private static int SetPPVWeightedBlendableWeight_Weight_Offset;

	private static bool SetPPCompWeightedBlendableWeightByIndex_IsValid;

	private static IntPtr SetPPCompWeightedBlendableWeightByIndex_FunctionAddress;

	private static int SetPPCompWeightedBlendableWeightByIndex_ParamsSize;

	private static bool SetPPCompWeightedBlendableWeightByIndex_PPComp_IsValid;

	private static FFieldAddress SetPPCompWeightedBlendableWeightByIndex_PPComp_PropertyAddress;

	private static int SetPPCompWeightedBlendableWeightByIndex_PPComp_Offset;

	private static bool SetPPCompWeightedBlendableWeightByIndex_PPMatIndex_IsValid;

	private static FFieldAddress SetPPCompWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress;

	private static int SetPPCompWeightedBlendableWeightByIndex_PPMatIndex_Offset;

	private static bool SetPPCompWeightedBlendableWeightByIndex_Weight_IsValid;

	private static FFieldAddress SetPPCompWeightedBlendableWeightByIndex_Weight_PropertyAddress;

	private static int SetPPCompWeightedBlendableWeightByIndex_Weight_Offset;

	private static bool SetPPCompWeightedBlendableWeight_IsValid;

	private static IntPtr SetPPCompWeightedBlendableWeight_FunctionAddress;

	private static int SetPPCompWeightedBlendableWeight_ParamsSize;

	private static bool SetPPCompWeightedBlendableWeight_PPComp_IsValid;

	private static FFieldAddress SetPPCompWeightedBlendableWeight_PPComp_PropertyAddress;

	private static int SetPPCompWeightedBlendableWeight_PPComp_Offset;

	private static bool SetPPCompWeightedBlendableWeight_PPMaterialInterface_IsValid;

	private static FFieldAddress SetPPCompWeightedBlendableWeight_PPMaterialInterface_PropertyAddress;

	private static int SetPPCompWeightedBlendableWeight_PPMaterialInterface_Offset;

	private static bool SetPPCompWeightedBlendableWeight_Weight_IsValid;

	private static FFieldAddress SetPPCompWeightedBlendableWeight_Weight_PropertyAddress;

	private static int SetPPCompWeightedBlendableWeight_Weight_Offset;

	private static bool SetCameraWeightedBlendableWeightByIndex_IsValid;

	private static IntPtr SetCameraWeightedBlendableWeightByIndex_FunctionAddress;

	private static int SetCameraWeightedBlendableWeightByIndex_ParamsSize;

	private static bool SetCameraWeightedBlendableWeightByIndex_CameraActor_IsValid;

	private static FFieldAddress SetCameraWeightedBlendableWeightByIndex_CameraActor_PropertyAddress;

	private static int SetCameraWeightedBlendableWeightByIndex_CameraActor_Offset;

	private static bool SetCameraWeightedBlendableWeightByIndex_PPMatIndex_IsValid;

	private static FFieldAddress SetCameraWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress;

	private static int SetCameraWeightedBlendableWeightByIndex_PPMatIndex_Offset;

	private static bool SetCameraWeightedBlendableWeightByIndex_Weight_IsValid;

	private static FFieldAddress SetCameraWeightedBlendableWeightByIndex_Weight_PropertyAddress;

	private static int SetCameraWeightedBlendableWeightByIndex_Weight_Offset;

	private static bool SetCameraCompWeightedBlendableWeightByIndex_IsValid;

	private static IntPtr SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress;

	private static int SetCameraCompWeightedBlendableWeightByIndex_ParamsSize;

	private static bool SetCameraCompWeightedBlendableWeightByIndex_CameraComp_IsValid;

	private static FFieldAddress SetCameraCompWeightedBlendableWeightByIndex_CameraComp_PropertyAddress;

	private static int SetCameraCompWeightedBlendableWeightByIndex_CameraComp_Offset;

	private static bool SetCameraCompWeightedBlendableWeightByIndex_PPMatIndex_IsValid;

	private static FFieldAddress SetCameraCompWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress;

	private static int SetCameraCompWeightedBlendableWeightByIndex_PPMatIndex_Offset;

	private static bool SetCameraCompWeightedBlendableWeightByIndex_Weight_IsValid;

	private static FFieldAddress SetCameraCompWeightedBlendableWeightByIndex_Weight_PropertyAddress;

	private static int SetCameraCompWeightedBlendableWeightByIndex_Weight_Offset;

	private static bool RemovePPVWeightBlendable_IsValid;

	private static IntPtr RemovePPVWeightBlendable_FunctionAddress;

	private static int RemovePPVWeightBlendable_ParamsSize;

	private static bool RemovePPVWeightBlendable_PPV_IsValid;

	private static FFieldAddress RemovePPVWeightBlendable_PPV_PropertyAddress;

	private static int RemovePPVWeightBlendable_PPV_Offset;

	private static bool RemovePPVWeightBlendable_PPMaterialInterface_IsValid;

	private static FFieldAddress RemovePPVWeightBlendable_PPMaterialInterface_PropertyAddress;

	private static int RemovePPVWeightBlendable_PPMaterialInterface_Offset;

	private static bool RemovePPCompWeightBlendable_IsValid;

	private static IntPtr RemovePPCompWeightBlendable_FunctionAddress;

	private static int RemovePPCompWeightBlendable_ParamsSize;

	private static bool RemovePPCompWeightBlendable_PPComp_IsValid;

	private static FFieldAddress RemovePPCompWeightBlendable_PPComp_PropertyAddress;

	private static int RemovePPCompWeightBlendable_PPComp_Offset;

	private static bool RemovePPCompWeightBlendable_PPMaterialInterface_IsValid;

	private static FFieldAddress RemovePPCompWeightBlendable_PPMaterialInterface_PropertyAddress;

	private static int RemovePPCompWeightBlendable_PPMaterialInterface_Offset;

	private static bool GetSceneViewFinalPostProcessSettings_IsValid;

	private static IntPtr GetSceneViewFinalPostProcessSettings_FunctionAddress;

	private static int GetSceneViewFinalPostProcessSettings_ParamsSize;

	private static bool GetSceneViewFinalPostProcessSettings_WorldContext_IsValid;

	private static FFieldAddress GetSceneViewFinalPostProcessSettings_WorldContext_PropertyAddress;

	private static int GetSceneViewFinalPostProcessSettings_WorldContext_Offset;

	private static bool GetSceneViewFinalPostProcessSettings_ReturnValue_IsValid;

	private static FFieldAddress GetSceneViewFinalPostProcessSettings_ReturnValue_PropertyAddress;

	private static int GetSceneViewFinalPostProcessSettings_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPVWeightedBlendableWeightByIndex")]
	public unsafe static void SetPPVWeightedBlendableWeightByIndex(APostProcessVolume PPV, int PPMatIndex, float Weight)
	{
		if (!SetPPVWeightedBlendableWeightByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPVWeightedBlendableWeightByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPPVWeightedBlendableWeightByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPPVWeightedBlendableWeightByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APostProcessVolume>.ToNative(IntPtr.Add(intPtr, SetPPVWeightedBlendableWeightByIndex_PPV_Offset), 0, SetPPVWeightedBlendableWeightByIndex_PPV_PropertyAddress.Address, PPV);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPPVWeightedBlendableWeightByIndex_PPMatIndex_Offset), 0, SetPPVWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress.Address, PPMatIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPPVWeightedBlendableWeightByIndex_Weight_Offset), 0, SetPPVWeightedBlendableWeightByIndex_Weight_PropertyAddress.Address, Weight);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPPVWeightedBlendableWeightByIndex_FunctionAddress, intPtr, SetPPVWeightedBlendableWeightByIndex_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPVWeightedBlendableWeight")]
	public unsafe static void SetPPVWeightedBlendableWeight(APostProcessVolume PPV, UMaterialInterface PPMaterialInterface, float Weight)
	{
		if (!SetPPVWeightedBlendableWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPVWeightedBlendableWeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPPVWeightedBlendableWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPPVWeightedBlendableWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APostProcessVolume>.ToNative(IntPtr.Add(intPtr, SetPPVWeightedBlendableWeight_PPV_Offset), 0, SetPPVWeightedBlendableWeight_PPV_PropertyAddress.Address, PPV);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetPPVWeightedBlendableWeight_PPMaterialInterface_Offset), 0, SetPPVWeightedBlendableWeight_PPMaterialInterface_PropertyAddress.Address, PPMaterialInterface);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPPVWeightedBlendableWeight_Weight_Offset), 0, SetPPVWeightedBlendableWeight_Weight_PropertyAddress.Address, Weight);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPPVWeightedBlendableWeight_FunctionAddress, intPtr, SetPPVWeightedBlendableWeight_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPCompWeightedBlendableWeightByIndex")]
	public unsafe static void SetPPCompWeightedBlendableWeightByIndex(UPostProcessComponent PPComp, int PPMatIndex, float Weight)
	{
		if (!SetPPCompWeightedBlendableWeightByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPCompWeightedBlendableWeightByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPPCompWeightedBlendableWeightByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPPCompWeightedBlendableWeightByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPostProcessComponent>.ToNative(IntPtr.Add(intPtr, SetPPCompWeightedBlendableWeightByIndex_PPComp_Offset), 0, SetPPCompWeightedBlendableWeightByIndex_PPComp_PropertyAddress.Address, PPComp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPPCompWeightedBlendableWeightByIndex_PPMatIndex_Offset), 0, SetPPCompWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress.Address, PPMatIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPPCompWeightedBlendableWeightByIndex_Weight_Offset), 0, SetPPCompWeightedBlendableWeightByIndex_Weight_PropertyAddress.Address, Weight);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPPCompWeightedBlendableWeightByIndex_FunctionAddress, intPtr, SetPPCompWeightedBlendableWeightByIndex_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPCompWeightedBlendableWeight")]
	public unsafe static void SetPPCompWeightedBlendableWeight(UPostProcessComponent PPComp, UMaterialInterface PPMaterialInterface, float Weight)
	{
		if (!SetPPCompWeightedBlendableWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPCompWeightedBlendableWeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPPCompWeightedBlendableWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPPCompWeightedBlendableWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPostProcessComponent>.ToNative(IntPtr.Add(intPtr, SetPPCompWeightedBlendableWeight_PPComp_Offset), 0, SetPPCompWeightedBlendableWeight_PPComp_PropertyAddress.Address, PPComp);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetPPCompWeightedBlendableWeight_PPMaterialInterface_Offset), 0, SetPPCompWeightedBlendableWeight_PPMaterialInterface_PropertyAddress.Address, PPMaterialInterface);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPPCompWeightedBlendableWeight_Weight_Offset), 0, SetPPCompWeightedBlendableWeight_Weight_PropertyAddress.Address, Weight);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPPCompWeightedBlendableWeight_FunctionAddress, intPtr, SetPPCompWeightedBlendableWeight_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetCameraWeightedBlendableWeightByIndex")]
	public unsafe static void SetCameraWeightedBlendableWeightByIndex(AActor CameraActor, int PPMatIndex, float Weight)
	{
		if (!SetCameraWeightedBlendableWeightByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetCameraWeightedBlendableWeightByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCameraWeightedBlendableWeightByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCameraWeightedBlendableWeightByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetCameraWeightedBlendableWeightByIndex_CameraActor_Offset), 0, SetCameraWeightedBlendableWeightByIndex_CameraActor_PropertyAddress.Address, CameraActor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCameraWeightedBlendableWeightByIndex_PPMatIndex_Offset), 0, SetCameraWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress.Address, PPMatIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCameraWeightedBlendableWeightByIndex_Weight_Offset), 0, SetCameraWeightedBlendableWeightByIndex_Weight_PropertyAddress.Address, Weight);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCameraWeightedBlendableWeightByIndex_FunctionAddress, intPtr, SetCameraWeightedBlendableWeightByIndex_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetCameraCompWeightedBlendableWeightByIndex")]
	public unsafe static void SetCameraCompWeightedBlendableWeightByIndex(UCameraComponent CameraComp, int PPMatIndex, float Weight)
	{
		if (!SetCameraCompWeightedBlendableWeightByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetCameraCompWeightedBlendableWeightByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCameraCompWeightedBlendableWeightByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCameraCompWeightedBlendableWeightByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraComponent>.ToNative(IntPtr.Add(intPtr, SetCameraCompWeightedBlendableWeightByIndex_CameraComp_Offset), 0, SetCameraCompWeightedBlendableWeightByIndex_CameraComp_PropertyAddress.Address, CameraComp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCameraCompWeightedBlendableWeightByIndex_PPMatIndex_Offset), 0, SetCameraCompWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress.Address, PPMatIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCameraCompWeightedBlendableWeightByIndex_Weight_Offset), 0, SetCameraCompWeightedBlendableWeightByIndex_Weight_PropertyAddress.Address, Weight);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress, intPtr, SetCameraCompWeightedBlendableWeightByIndex_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_PostProcessFuncLib:RemovePPVWeightBlendable")]
	public unsafe static void RemovePPVWeightBlendable(APostProcessVolume PPV, UMaterialInterface PPMaterialInterface)
	{
		if (!RemovePPVWeightBlendable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_PostProcessFuncLib:RemovePPVWeightBlendable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemovePPVWeightBlendable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemovePPVWeightBlendable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APostProcessVolume>.ToNative(IntPtr.Add(intPtr, RemovePPVWeightBlendable_PPV_Offset), 0, RemovePPVWeightBlendable_PPV_PropertyAddress.Address, PPV);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, RemovePPVWeightBlendable_PPMaterialInterface_Offset), 0, RemovePPVWeightBlendable_PPMaterialInterface_PropertyAddress.Address, PPMaterialInterface);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemovePPVWeightBlendable_FunctionAddress, intPtr, RemovePPVWeightBlendable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_PostProcessFuncLib:RemovePPCompWeightBlendable")]
	public unsafe static void RemovePPCompWeightBlendable(UPostProcessComponent PPComp, UMaterialInterface PPMaterialInterface)
	{
		if (!RemovePPCompWeightBlendable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_PostProcessFuncLib:RemovePPCompWeightBlendable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemovePPCompWeightBlendable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemovePPCompWeightBlendable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPostProcessComponent>.ToNative(IntPtr.Add(intPtr, RemovePPCompWeightBlendable_PPComp_Offset), 0, RemovePPCompWeightBlendable_PPComp_PropertyAddress.Address, PPComp);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, RemovePPCompWeightBlendable_PPMaterialInterface_Offset), 0, RemovePPCompWeightBlendable_PPMaterialInterface_PropertyAddress.Address, PPMaterialInterface);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemovePPCompWeightBlendable_FunctionAddress, intPtr, RemovePPCompWeightBlendable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_PostProcessFuncLib:GetSceneViewFinalPostProcessSettings")]
	public unsafe static FPostProcessSettings GetSceneViewFinalPostProcessSettings(AActor WorldContext)
	{
		if (!GetSceneViewFinalPostProcessSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_PostProcessFuncLib:GetSceneViewFinalPostProcessSettings");
			return default(FPostProcessSettings);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSceneViewFinalPostProcessSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSceneViewFinalPostProcessSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetSceneViewFinalPostProcessSettings_WorldContext_Offset), 0, GetSceneViewFinalPostProcessSettings_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSceneViewFinalPostProcessSettings_FunctionAddress, intPtr, GetSceneViewFinalPostProcessSettings_ParamsSize);
		FPostProcessSettings result = FPostProcessSettings.FromNative(IntPtr.Add(intPtr, GetSceneViewFinalPostProcessSettings_ReturnValue_Offset), 0, GetSceneViewFinalPostProcessSettings_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSceneViewFinalPostProcessSettings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGSE_PostProcessFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_PostProcessFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_PostProcessFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_PostProcessFuncLib");
		SetPPVWeightedBlendableWeightByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPPVWeightedBlendableWeightByIndex");
		SetPPVWeightedBlendableWeightByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPPVWeightedBlendableWeightByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPPVWeightedBlendableWeightByIndex_PPV_PropertyAddress, SetPPVWeightedBlendableWeightByIndex_FunctionAddress, "PPV");
		SetPPVWeightedBlendableWeightByIndex_PPV_Offset = NativeReflectionCached.GetPropertyOffset(SetPPVWeightedBlendableWeightByIndex_FunctionAddress, "PPV");
		SetPPVWeightedBlendableWeightByIndex_PPV_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPVWeightedBlendableWeightByIndex_FunctionAddress, "PPV", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPPVWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress, SetPPVWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex");
		SetPPVWeightedBlendableWeightByIndex_PPMatIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetPPVWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex");
		SetPPVWeightedBlendableWeightByIndex_PPMatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPVWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPPVWeightedBlendableWeightByIndex_Weight_PropertyAddress, SetPPVWeightedBlendableWeightByIndex_FunctionAddress, "Weight");
		SetPPVWeightedBlendableWeightByIndex_Weight_Offset = NativeReflectionCached.GetPropertyOffset(SetPPVWeightedBlendableWeightByIndex_FunctionAddress, "Weight");
		SetPPVWeightedBlendableWeightByIndex_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPVWeightedBlendableWeightByIndex_FunctionAddress, "Weight", Classes.FFloatProperty);
		SetPPVWeightedBlendableWeightByIndex_IsValid = SetPPVWeightedBlendableWeightByIndex_FunctionAddress != IntPtr.Zero && SetPPVWeightedBlendableWeightByIndex_PPV_IsValid && SetPPVWeightedBlendableWeightByIndex_PPMatIndex_IsValid && SetPPVWeightedBlendableWeightByIndex_Weight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPVWeightedBlendableWeightByIndex", SetPPVWeightedBlendableWeightByIndex_IsValid);
		SetPPVWeightedBlendableWeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPPVWeightedBlendableWeight");
		SetPPVWeightedBlendableWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPPVWeightedBlendableWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPPVWeightedBlendableWeight_PPV_PropertyAddress, SetPPVWeightedBlendableWeight_FunctionAddress, "PPV");
		SetPPVWeightedBlendableWeight_PPV_Offset = NativeReflectionCached.GetPropertyOffset(SetPPVWeightedBlendableWeight_FunctionAddress, "PPV");
		SetPPVWeightedBlendableWeight_PPV_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPVWeightedBlendableWeight_FunctionAddress, "PPV", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPPVWeightedBlendableWeight_PPMaterialInterface_PropertyAddress, SetPPVWeightedBlendableWeight_FunctionAddress, "PPMaterialInterface");
		SetPPVWeightedBlendableWeight_PPMaterialInterface_Offset = NativeReflectionCached.GetPropertyOffset(SetPPVWeightedBlendableWeight_FunctionAddress, "PPMaterialInterface");
		SetPPVWeightedBlendableWeight_PPMaterialInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPVWeightedBlendableWeight_FunctionAddress, "PPMaterialInterface", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPPVWeightedBlendableWeight_Weight_PropertyAddress, SetPPVWeightedBlendableWeight_FunctionAddress, "Weight");
		SetPPVWeightedBlendableWeight_Weight_Offset = NativeReflectionCached.GetPropertyOffset(SetPPVWeightedBlendableWeight_FunctionAddress, "Weight");
		SetPPVWeightedBlendableWeight_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPVWeightedBlendableWeight_FunctionAddress, "Weight", Classes.FFloatProperty);
		SetPPVWeightedBlendableWeight_IsValid = SetPPVWeightedBlendableWeight_FunctionAddress != IntPtr.Zero && SetPPVWeightedBlendableWeight_PPV_IsValid && SetPPVWeightedBlendableWeight_PPMaterialInterface_IsValid && SetPPVWeightedBlendableWeight_Weight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPVWeightedBlendableWeight", SetPPVWeightedBlendableWeight_IsValid);
		SetPPCompWeightedBlendableWeightByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPPCompWeightedBlendableWeightByIndex");
		SetPPCompWeightedBlendableWeightByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPPCompWeightedBlendableWeightByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPPCompWeightedBlendableWeightByIndex_PPComp_PropertyAddress, SetPPCompWeightedBlendableWeightByIndex_FunctionAddress, "PPComp");
		SetPPCompWeightedBlendableWeightByIndex_PPComp_Offset = NativeReflectionCached.GetPropertyOffset(SetPPCompWeightedBlendableWeightByIndex_FunctionAddress, "PPComp");
		SetPPCompWeightedBlendableWeightByIndex_PPComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPCompWeightedBlendableWeightByIndex_FunctionAddress, "PPComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPPCompWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress, SetPPCompWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex");
		SetPPCompWeightedBlendableWeightByIndex_PPMatIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetPPCompWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex");
		SetPPCompWeightedBlendableWeightByIndex_PPMatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPCompWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPPCompWeightedBlendableWeightByIndex_Weight_PropertyAddress, SetPPCompWeightedBlendableWeightByIndex_FunctionAddress, "Weight");
		SetPPCompWeightedBlendableWeightByIndex_Weight_Offset = NativeReflectionCached.GetPropertyOffset(SetPPCompWeightedBlendableWeightByIndex_FunctionAddress, "Weight");
		SetPPCompWeightedBlendableWeightByIndex_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPCompWeightedBlendableWeightByIndex_FunctionAddress, "Weight", Classes.FFloatProperty);
		SetPPCompWeightedBlendableWeightByIndex_IsValid = SetPPCompWeightedBlendableWeightByIndex_FunctionAddress != IntPtr.Zero && SetPPCompWeightedBlendableWeightByIndex_PPComp_IsValid && SetPPCompWeightedBlendableWeightByIndex_PPMatIndex_IsValid && SetPPCompWeightedBlendableWeightByIndex_Weight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPCompWeightedBlendableWeightByIndex", SetPPCompWeightedBlendableWeightByIndex_IsValid);
		SetPPCompWeightedBlendableWeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPPCompWeightedBlendableWeight");
		SetPPCompWeightedBlendableWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPPCompWeightedBlendableWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPPCompWeightedBlendableWeight_PPComp_PropertyAddress, SetPPCompWeightedBlendableWeight_FunctionAddress, "PPComp");
		SetPPCompWeightedBlendableWeight_PPComp_Offset = NativeReflectionCached.GetPropertyOffset(SetPPCompWeightedBlendableWeight_FunctionAddress, "PPComp");
		SetPPCompWeightedBlendableWeight_PPComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPCompWeightedBlendableWeight_FunctionAddress, "PPComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPPCompWeightedBlendableWeight_PPMaterialInterface_PropertyAddress, SetPPCompWeightedBlendableWeight_FunctionAddress, "PPMaterialInterface");
		SetPPCompWeightedBlendableWeight_PPMaterialInterface_Offset = NativeReflectionCached.GetPropertyOffset(SetPPCompWeightedBlendableWeight_FunctionAddress, "PPMaterialInterface");
		SetPPCompWeightedBlendableWeight_PPMaterialInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPCompWeightedBlendableWeight_FunctionAddress, "PPMaterialInterface", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPPCompWeightedBlendableWeight_Weight_PropertyAddress, SetPPCompWeightedBlendableWeight_FunctionAddress, "Weight");
		SetPPCompWeightedBlendableWeight_Weight_Offset = NativeReflectionCached.GetPropertyOffset(SetPPCompWeightedBlendableWeight_FunctionAddress, "Weight");
		SetPPCompWeightedBlendableWeight_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPPCompWeightedBlendableWeight_FunctionAddress, "Weight", Classes.FFloatProperty);
		SetPPCompWeightedBlendableWeight_IsValid = SetPPCompWeightedBlendableWeight_FunctionAddress != IntPtr.Zero && SetPPCompWeightedBlendableWeight_PPComp_IsValid && SetPPCompWeightedBlendableWeight_PPMaterialInterface_IsValid && SetPPCompWeightedBlendableWeight_Weight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetPPCompWeightedBlendableWeight", SetPPCompWeightedBlendableWeight_IsValid);
		SetCameraWeightedBlendableWeightByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCameraWeightedBlendableWeightByIndex");
		SetCameraWeightedBlendableWeightByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCameraWeightedBlendableWeightByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCameraWeightedBlendableWeightByIndex_CameraActor_PropertyAddress, SetCameraWeightedBlendableWeightByIndex_FunctionAddress, "CameraActor");
		SetCameraWeightedBlendableWeightByIndex_CameraActor_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraWeightedBlendableWeightByIndex_FunctionAddress, "CameraActor");
		SetCameraWeightedBlendableWeightByIndex_CameraActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraWeightedBlendableWeightByIndex_FunctionAddress, "CameraActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCameraWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress, SetCameraWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex");
		SetCameraWeightedBlendableWeightByIndex_PPMatIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex");
		SetCameraWeightedBlendableWeightByIndex_PPMatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCameraWeightedBlendableWeightByIndex_Weight_PropertyAddress, SetCameraWeightedBlendableWeightByIndex_FunctionAddress, "Weight");
		SetCameraWeightedBlendableWeightByIndex_Weight_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraWeightedBlendableWeightByIndex_FunctionAddress, "Weight");
		SetCameraWeightedBlendableWeightByIndex_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraWeightedBlendableWeightByIndex_FunctionAddress, "Weight", Classes.FFloatProperty);
		SetCameraWeightedBlendableWeightByIndex_IsValid = SetCameraWeightedBlendableWeightByIndex_FunctionAddress != IntPtr.Zero && SetCameraWeightedBlendableWeightByIndex_CameraActor_IsValid && SetCameraWeightedBlendableWeightByIndex_PPMatIndex_IsValid && SetCameraWeightedBlendableWeightByIndex_Weight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetCameraWeightedBlendableWeightByIndex", SetCameraWeightedBlendableWeightByIndex_IsValid);
		SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCameraCompWeightedBlendableWeightByIndex");
		SetCameraCompWeightedBlendableWeightByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCameraCompWeightedBlendableWeightByIndex_CameraComp_PropertyAddress, SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress, "CameraComp");
		SetCameraCompWeightedBlendableWeightByIndex_CameraComp_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress, "CameraComp");
		SetCameraCompWeightedBlendableWeightByIndex_CameraComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress, "CameraComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCameraCompWeightedBlendableWeightByIndex_PPMatIndex_PropertyAddress, SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex");
		SetCameraCompWeightedBlendableWeightByIndex_PPMatIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex");
		SetCameraCompWeightedBlendableWeightByIndex_PPMatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress, "PPMatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCameraCompWeightedBlendableWeightByIndex_Weight_PropertyAddress, SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress, "Weight");
		SetCameraCompWeightedBlendableWeightByIndex_Weight_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress, "Weight");
		SetCameraCompWeightedBlendableWeightByIndex_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress, "Weight", Classes.FFloatProperty);
		SetCameraCompWeightedBlendableWeightByIndex_IsValid = SetCameraCompWeightedBlendableWeightByIndex_FunctionAddress != IntPtr.Zero && SetCameraCompWeightedBlendableWeightByIndex_CameraComp_IsValid && SetCameraCompWeightedBlendableWeightByIndex_PPMatIndex_IsValid && SetCameraCompWeightedBlendableWeightByIndex_Weight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_PostProcessFuncLib:SetCameraCompWeightedBlendableWeightByIndex", SetCameraCompWeightedBlendableWeightByIndex_IsValid);
		RemovePPVWeightBlendable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemovePPVWeightBlendable");
		RemovePPVWeightBlendable_ParamsSize = NativeReflection.GetFunctionParamsSize(RemovePPVWeightBlendable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemovePPVWeightBlendable_PPV_PropertyAddress, RemovePPVWeightBlendable_FunctionAddress, "PPV");
		RemovePPVWeightBlendable_PPV_Offset = NativeReflectionCached.GetPropertyOffset(RemovePPVWeightBlendable_FunctionAddress, "PPV");
		RemovePPVWeightBlendable_PPV_IsValid = NativeReflectionCached.ValidatePropertyClass(RemovePPVWeightBlendable_FunctionAddress, "PPV", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemovePPVWeightBlendable_PPMaterialInterface_PropertyAddress, RemovePPVWeightBlendable_FunctionAddress, "PPMaterialInterface");
		RemovePPVWeightBlendable_PPMaterialInterface_Offset = NativeReflectionCached.GetPropertyOffset(RemovePPVWeightBlendable_FunctionAddress, "PPMaterialInterface");
		RemovePPVWeightBlendable_PPMaterialInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(RemovePPVWeightBlendable_FunctionAddress, "PPMaterialInterface", Classes.FObjectProperty);
		RemovePPVWeightBlendable_IsValid = RemovePPVWeightBlendable_FunctionAddress != IntPtr.Zero && RemovePPVWeightBlendable_PPV_IsValid && RemovePPVWeightBlendable_PPMaterialInterface_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_PostProcessFuncLib:RemovePPVWeightBlendable", RemovePPVWeightBlendable_IsValid);
		RemovePPCompWeightBlendable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemovePPCompWeightBlendable");
		RemovePPCompWeightBlendable_ParamsSize = NativeReflection.GetFunctionParamsSize(RemovePPCompWeightBlendable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemovePPCompWeightBlendable_PPComp_PropertyAddress, RemovePPCompWeightBlendable_FunctionAddress, "PPComp");
		RemovePPCompWeightBlendable_PPComp_Offset = NativeReflectionCached.GetPropertyOffset(RemovePPCompWeightBlendable_FunctionAddress, "PPComp");
		RemovePPCompWeightBlendable_PPComp_IsValid = NativeReflectionCached.ValidatePropertyClass(RemovePPCompWeightBlendable_FunctionAddress, "PPComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemovePPCompWeightBlendable_PPMaterialInterface_PropertyAddress, RemovePPCompWeightBlendable_FunctionAddress, "PPMaterialInterface");
		RemovePPCompWeightBlendable_PPMaterialInterface_Offset = NativeReflectionCached.GetPropertyOffset(RemovePPCompWeightBlendable_FunctionAddress, "PPMaterialInterface");
		RemovePPCompWeightBlendable_PPMaterialInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(RemovePPCompWeightBlendable_FunctionAddress, "PPMaterialInterface", Classes.FObjectProperty);
		RemovePPCompWeightBlendable_IsValid = RemovePPCompWeightBlendable_FunctionAddress != IntPtr.Zero && RemovePPCompWeightBlendable_PPComp_IsValid && RemovePPCompWeightBlendable_PPMaterialInterface_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_PostProcessFuncLib:RemovePPCompWeightBlendable", RemovePPCompWeightBlendable_IsValid);
		GetSceneViewFinalPostProcessSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSceneViewFinalPostProcessSettings");
		GetSceneViewFinalPostProcessSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSceneViewFinalPostProcessSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSceneViewFinalPostProcessSettings_WorldContext_PropertyAddress, GetSceneViewFinalPostProcessSettings_FunctionAddress, "WorldContext");
		GetSceneViewFinalPostProcessSettings_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneViewFinalPostProcessSettings_FunctionAddress, "WorldContext");
		GetSceneViewFinalPostProcessSettings_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneViewFinalPostProcessSettings_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSceneViewFinalPostProcessSettings_ReturnValue_PropertyAddress, GetSceneViewFinalPostProcessSettings_FunctionAddress, "ReturnValue");
		GetSceneViewFinalPostProcessSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneViewFinalPostProcessSettings_FunctionAddress, "ReturnValue");
		GetSceneViewFinalPostProcessSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneViewFinalPostProcessSettings_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSceneViewFinalPostProcessSettings_IsValid = GetSceneViewFinalPostProcessSettings_FunctionAddress != IntPtr.Zero && GetSceneViewFinalPostProcessSettings_WorldContext_IsValid && GetSceneViewFinalPostProcessSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_PostProcessFuncLib:GetSceneViewFinalPostProcessSettings", GetSceneViewFinalPostProcessSettings_IsValid);
	}
}
