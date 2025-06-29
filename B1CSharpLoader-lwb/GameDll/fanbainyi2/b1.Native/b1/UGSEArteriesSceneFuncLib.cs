using System;
using System.Runtime.CompilerServices;
using b1.Plugins.Arteries;
using b1.Plugins.GSEArteries;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEArteriesSceneFuncLib", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEArteriesSceneFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TranslatePoints_IsValid;

	private static IntPtr TranslatePoints_FunctionAddress;

	private static int TranslatePoints_ParamsSize;

	private static bool TranslatePoints_Obj_IsValid;

	private static FFieldAddress TranslatePoints_Obj_PropertyAddress;

	private static int TranslatePoints_Obj_Offset;

	private static bool TranslatePoints_Translate_IsValid;

	private static FFieldAddress TranslatePoints_Translate_PropertyAddress;

	private static int TranslatePoints_Translate_Offset;

	private static bool TranslatePoints_bUseScale_IsValid;

	private static FFieldAddress TranslatePoints_bUseScale_PropertyAddress;

	private static int TranslatePoints_bUseScale_Offset;

	private static bool TranslatePoints_ReturnValue_IsValid;

	private static FFieldAddress TranslatePoints_ReturnValue_PropertyAddress;

	private static int TranslatePoints_ReturnValue_Offset;

	private static bool SurroundLandScapeBySpline_IsValid;

	private static IntPtr SurroundLandScapeBySpline_FunctionAddress;

	private static int SurroundLandScapeBySpline_ParamsSize;

	private static bool SurroundLandScapeBySpline_OwnerActor_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_OwnerActor_PropertyAddress;

	private static int SurroundLandScapeBySpline_OwnerActor_Offset;

	private static bool SurroundLandScapeBySpline_LandscapeReader_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_LandscapeReader_PropertyAddress;

	private static int SurroundLandScapeBySpline_LandscapeReader_Offset;

	private static bool SurroundLandScapeBySpline_SplineComp_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_SplineComp_PropertyAddress;

	private static int SurroundLandScapeBySpline_SplineComp_Offset;

	private static bool SurroundLandScapeBySpline_Extent_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_Extent_PropertyAddress;

	private static int SurroundLandScapeBySpline_Extent_Offset;

	private static bool SurroundLandScapeBySpline_MaxStep_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_MaxStep_PropertyAddress;

	private static int SurroundLandScapeBySpline_MaxStep_Offset;

	private static bool SurroundLandScapeBySpline_MinStep_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_MinStep_PropertyAddress;

	private static int SurroundLandScapeBySpline_MinStep_Offset;

	private static bool SurroundLandScapeBySpline_OverlapMax_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_OverlapMax_PropertyAddress;

	private static int SurroundLandScapeBySpline_OverlapMax_Offset;

	private static bool SurroundLandScapeBySpline_OverlapMin_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_OverlapMin_PropertyAddress;

	private static int SurroundLandScapeBySpline_OverlapMin_Offset;

	private static bool SurroundLandScapeBySpline_ExposeBias_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_ExposeBias_PropertyAddress;

	private static int SurroundLandScapeBySpline_ExposeBias_Offset;

	private static bool SurroundLandScapeBySpline_Close_Tolerate_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_Close_Tolerate_PropertyAddress;

	private static int SurroundLandScapeBySpline_Close_Tolerate_Offset;

	private static bool SurroundLandScapeBySpline_Far_Tolerate_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_Far_Tolerate_PropertyAddress;

	private static int SurroundLandScapeBySpline_Far_Tolerate_Offset;

	private static bool SurroundLandScapeBySpline_Debug_MainIter_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_Debug_MainIter_PropertyAddress;

	private static int SurroundLandScapeBySpline_Debug_MainIter_Offset;

	private static bool SurroundLandScapeBySpline_Debug_OverlapIter_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_Debug_OverlapIter_PropertyAddress;

	private static int SurroundLandScapeBySpline_Debug_OverlapIter_Offset;

	private static bool SurroundLandScapeBySpline_Debug_LenIter_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_Debug_LenIter_PropertyAddress;

	private static int SurroundLandScapeBySpline_Debug_LenIter_Offset;

	private static bool SurroundLandScapeBySpline_Debug_XOffsetIter_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_Debug_XOffsetIter_PropertyAddress;

	private static int SurroundLandScapeBySpline_Debug_XOffsetIter_Offset;

	private static bool SurroundLandScapeBySpline_bEnableDebug_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_bEnableDebug_PropertyAddress;

	private static int SurroundLandScapeBySpline_bEnableDebug_Offset;

	private static bool SurroundLandScapeBySpline_ReturnValue_IsValid;

	private static FFieldAddress SurroundLandScapeBySpline_ReturnValue_PropertyAddress;

	private static int SurroundLandScapeBySpline_ReturnValue_Offset;

	private static bool ScatterPointsBySpline_IsValid;

	private static IntPtr ScatterPointsBySpline_FunctionAddress;

	private static int ScatterPointsBySpline_ParamsSize;

	private static bool ScatterPointsBySpline_OwnerActor_IsValid;

	private static FFieldAddress ScatterPointsBySpline_OwnerActor_PropertyAddress;

	private static int ScatterPointsBySpline_OwnerActor_Offset;

	private static bool ScatterPointsBySpline_LandscapeReader_IsValid;

	private static FFieldAddress ScatterPointsBySpline_LandscapeReader_PropertyAddress;

	private static int ScatterPointsBySpline_LandscapeReader_Offset;

	private static bool ScatterPointsBySpline_SplineComp_IsValid;

	private static FFieldAddress ScatterPointsBySpline_SplineComp_PropertyAddress;

	private static int ScatterPointsBySpline_SplineComp_Offset;

	private static bool ScatterPointsBySpline_StepLen_IsValid;

	private static FFieldAddress ScatterPointsBySpline_StepLen_PropertyAddress;

	private static int ScatterPointsBySpline_StepLen_Offset;

	private static bool ScatterPointsBySpline_FallOff_IsValid;

	private static FFieldAddress ScatterPointsBySpline_FallOff_PropertyAddress;

	private static int ScatterPointsBySpline_FallOff_Offset;

	private static bool ScatterPointsBySpline_MinDis_IsValid;

	private static FFieldAddress ScatterPointsBySpline_MinDis_PropertyAddress;

	private static int ScatterPointsBySpline_MinDis_Offset;

	private static bool ScatterPointsBySpline_MaxDis_IsValid;

	private static FFieldAddress ScatterPointsBySpline_MaxDis_PropertyAddress;

	private static int ScatterPointsBySpline_MaxDis_Offset;

	private static bool ScatterPointsBySpline_RandRot_IsValid;

	private static FFieldAddress ScatterPointsBySpline_RandRot_PropertyAddress;

	private static int ScatterPointsBySpline_RandRot_Offset;

	private static bool ScatterPointsBySpline_RandScale_IsValid;

	private static FFieldAddress ScatterPointsBySpline_RandScale_PropertyAddress;

	private static int ScatterPointsBySpline_RandScale_Offset;

	private static bool ScatterPointsBySpline_ReturnValue_IsValid;

	private static FFieldAddress ScatterPointsBySpline_ReturnValue_PropertyAddress;

	private static int ScatterPointsBySpline_ReturnValue_Offset;

	private static bool ScalePoints_IsValid;

	private static IntPtr ScalePoints_FunctionAddress;

	private static int ScalePoints_ParamsSize;

	private static bool ScalePoints_Obj_IsValid;

	private static FFieldAddress ScalePoints_Obj_PropertyAddress;

	private static int ScalePoints_Obj_Offset;

	private static bool ScalePoints_Weight_IsValid;

	private static FFieldAddress ScalePoints_Weight_PropertyAddress;

	private static int ScalePoints_Weight_Offset;

	private static bool ScalePoints_Bias_IsValid;

	private static FFieldAddress ScalePoints_Bias_PropertyAddress;

	private static int ScalePoints_Bias_Offset;

	private static bool ScalePoints_ReturnValue_IsValid;

	private static FFieldAddress ScalePoints_ReturnValue_PropertyAddress;

	private static int ScalePoints_ReturnValue_Offset;

	private static bool GetExtent_IsValid;

	private static IntPtr GetExtent_FunctionAddress;

	private static int GetExtent_ParamsSize;

	private static bool GetExtent_SM_IsValid;

	private static FFieldAddress GetExtent_SM_PropertyAddress;

	private static int GetExtent_SM_Offset;

	private static bool GetExtent_ReturnValue_IsValid;

	private static FFieldAddress GetExtent_ReturnValue_PropertyAddress;

	private static int GetExtent_ReturnValue_Offset;

	private static bool CreateHISMComp_IsValid;

	private static IntPtr CreateHISMComp_FunctionAddress;

	private static int CreateHISMComp_ParamsSize;

	private static bool CreateHISMComp_Actor_IsValid;

	private static FFieldAddress CreateHISMComp_Actor_PropertyAddress;

	private static int CreateHISMComp_Actor_Offset;

	private static bool CreateHISMComp_Object_IsValid;

	private static FFieldAddress CreateHISMComp_Object_PropertyAddress;

	private static int CreateHISMComp_Object_Offset;

	private static bool CopyToPoints_IsValid;

	private static IntPtr CopyToPoints_FunctionAddress;

	private static int CopyToPoints_ParamsSize;

	private static bool CopyToPoints_Obj_IsValid;

	private static FFieldAddress CopyToPoints_Obj_PropertyAddress;

	private static int CopyToPoints_Obj_Offset;

	private static bool CopyToPoints_SrcObject_IsValid;

	private static FFieldAddress CopyToPoints_SrcObject_PropertyAddress;

	private static int CopyToPoints_SrcObject_Offset;

	private static bool CopyToPoints_ReturnValue_IsValid;

	private static FFieldAddress CopyToPoints_ReturnValue_PropertyAddress;

	private static int CopyToPoints_ReturnValue_Offset;

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:TranslatePoints")]
	public unsafe static UArteriesObject TranslatePoints(UArteriesObject Obj, FVector Translate, bool bUseScale)
	{
		if (!TranslatePoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:TranslatePoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TranslatePoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TranslatePoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(intPtr, TranslatePoints_Obj_Offset), 0, TranslatePoints_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TranslatePoints_Translate_Offset), 0, TranslatePoints_Translate_PropertyAddress.Address, Translate);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TranslatePoints_bUseScale_Offset), 0, TranslatePoints_bUseScale_PropertyAddress.Address, bUseScale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TranslatePoints_FunctionAddress, intPtr, TranslatePoints_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, TranslatePoints_ReturnValue_Offset), 0, TranslatePoints_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:SurroundLandScapeBySpline")]
	public unsafe static UArteriesObject SurroundLandScapeBySpline(AGSEArteriesActor OwnerActor, ULandscapeReader LandscapeReader, USplineComponent SplineComp, FVector Extent, float MaxStep, float MinStep, float OverlapMax, float OverlapMin, FVector ExposeBias, float Close_Tolerate, float Far_Tolerate, int Debug_MainIter, int Debug_OverlapIter, int Debug_LenIter, int Debug_XOffsetIter, bool bEnableDebug)
	{
		if (!SurroundLandScapeBySpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:SurroundLandScapeBySpline");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SurroundLandScapeBySpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SurroundLandScapeBySpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AGSEArteriesActor>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_OwnerActor_Offset), 0, SurroundLandScapeBySpline_OwnerActor_PropertyAddress.Address, OwnerActor);
		UObjectMarshaler<ULandscapeReader>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_LandscapeReader_Offset), 0, SurroundLandScapeBySpline_LandscapeReader_PropertyAddress.Address, LandscapeReader);
		UObjectMarshaler<USplineComponent>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_SplineComp_Offset), 0, SurroundLandScapeBySpline_SplineComp_PropertyAddress.Address, SplineComp);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_Extent_Offset), 0, SurroundLandScapeBySpline_Extent_PropertyAddress.Address, Extent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_MaxStep_Offset), 0, SurroundLandScapeBySpline_MaxStep_PropertyAddress.Address, MaxStep);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_MinStep_Offset), 0, SurroundLandScapeBySpline_MinStep_PropertyAddress.Address, MinStep);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_OverlapMax_Offset), 0, SurroundLandScapeBySpline_OverlapMax_PropertyAddress.Address, OverlapMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_OverlapMin_Offset), 0, SurroundLandScapeBySpline_OverlapMin_PropertyAddress.Address, OverlapMin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_ExposeBias_Offset), 0, SurroundLandScapeBySpline_ExposeBias_PropertyAddress.Address, ExposeBias);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_Close_Tolerate_Offset), 0, SurroundLandScapeBySpline_Close_Tolerate_PropertyAddress.Address, Close_Tolerate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_Far_Tolerate_Offset), 0, SurroundLandScapeBySpline_Far_Tolerate_PropertyAddress.Address, Far_Tolerate);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_Debug_MainIter_Offset), 0, SurroundLandScapeBySpline_Debug_MainIter_PropertyAddress.Address, Debug_MainIter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_Debug_OverlapIter_Offset), 0, SurroundLandScapeBySpline_Debug_OverlapIter_PropertyAddress.Address, Debug_OverlapIter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_Debug_LenIter_Offset), 0, SurroundLandScapeBySpline_Debug_LenIter_PropertyAddress.Address, Debug_LenIter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_Debug_XOffsetIter_Offset), 0, SurroundLandScapeBySpline_Debug_XOffsetIter_PropertyAddress.Address, Debug_XOffsetIter);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_bEnableDebug_Offset), 0, SurroundLandScapeBySpline_bEnableDebug_PropertyAddress.Address, bEnableDebug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SurroundLandScapeBySpline_FunctionAddress, intPtr, SurroundLandScapeBySpline_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, SurroundLandScapeBySpline_ReturnValue_Offset), 0, SurroundLandScapeBySpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:ScatterPointsBySpline")]
	public unsafe static UArteriesObject ScatterPointsBySpline(AGSEArteriesActor OwnerActor, ULandscapeReader LandscapeReader, USplineComponent SplineComp, float StepLen, float FallOff, float MinDis, float MaxDis, float RandRot, float RandScale)
	{
		if (!ScatterPointsBySpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:ScatterPointsBySpline");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScatterPointsBySpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScatterPointsBySpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AGSEArteriesActor>.ToNative(IntPtr.Add(intPtr, ScatterPointsBySpline_OwnerActor_Offset), 0, ScatterPointsBySpline_OwnerActor_PropertyAddress.Address, OwnerActor);
		UObjectMarshaler<ULandscapeReader>.ToNative(IntPtr.Add(intPtr, ScatterPointsBySpline_LandscapeReader_Offset), 0, ScatterPointsBySpline_LandscapeReader_PropertyAddress.Address, LandscapeReader);
		UObjectMarshaler<USplineComponent>.ToNative(IntPtr.Add(intPtr, ScatterPointsBySpline_SplineComp_Offset), 0, ScatterPointsBySpline_SplineComp_PropertyAddress.Address, SplineComp);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScatterPointsBySpline_StepLen_Offset), 0, ScatterPointsBySpline_StepLen_PropertyAddress.Address, StepLen);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScatterPointsBySpline_FallOff_Offset), 0, ScatterPointsBySpline_FallOff_PropertyAddress.Address, FallOff);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScatterPointsBySpline_MinDis_Offset), 0, ScatterPointsBySpline_MinDis_PropertyAddress.Address, MinDis);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScatterPointsBySpline_MaxDis_Offset), 0, ScatterPointsBySpline_MaxDis_PropertyAddress.Address, MaxDis);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScatterPointsBySpline_RandRot_Offset), 0, ScatterPointsBySpline_RandRot_PropertyAddress.Address, RandRot);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScatterPointsBySpline_RandScale_Offset), 0, ScatterPointsBySpline_RandScale_PropertyAddress.Address, RandScale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScatterPointsBySpline_FunctionAddress, intPtr, ScatterPointsBySpline_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, ScatterPointsBySpline_ReturnValue_Offset), 0, ScatterPointsBySpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:ScalePoints")]
	public unsafe static UArteriesObject ScalePoints(UArteriesObject Obj, FVector Weight, FVector Bias)
	{
		if (!ScalePoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:ScalePoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScalePoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScalePoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(intPtr, ScalePoints_Obj_Offset), 0, ScalePoints_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ScalePoints_Weight_Offset), 0, ScalePoints_Weight_PropertyAddress.Address, Weight);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ScalePoints_Bias_Offset), 0, ScalePoints_Bias_PropertyAddress.Address, Bias);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScalePoints_FunctionAddress, intPtr, ScalePoints_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, ScalePoints_ReturnValue_Offset), 0, ScalePoints_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:GetExtent")]
	public unsafe static FVector GetExtent(UStaticMesh SM)
	{
		if (!GetExtent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:GetExtent");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetExtent_SM_Offset), 0, GetExtent_SM_PropertyAddress.Address, SM);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetExtent_FunctionAddress, intPtr, GetExtent_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetExtent_ReturnValue_Offset), 0, GetExtent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:CreateHISMComp")]
	public unsafe static void CreateHISMComp(AArteriesActor Actor, UArteriesObject Object)
	{
		if (!CreateHISMComp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:CreateHISMComp");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateHISMComp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateHISMComp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AArteriesActor>.ToNative(IntPtr.Add(intPtr, CreateHISMComp_Actor_Offset), 0, CreateHISMComp_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(intPtr, CreateHISMComp_Object_Offset), 0, CreateHISMComp_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateHISMComp_FunctionAddress, intPtr, CreateHISMComp_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:CopyToPoints")]
	public unsafe static UArteriesObject CopyToPoints(UArteriesObject Obj, UObject SrcObject)
	{
		if (!CopyToPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:CopyToPoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyToPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyToPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(intPtr, CopyToPoints_Obj_Offset), 0, CopyToPoints_Obj_PropertyAddress.Address, Obj);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CopyToPoints_SrcObject_Offset), 0, CopyToPoints_SrcObject_PropertyAddress.Address, SrcObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyToPoints_FunctionAddress, intPtr, CopyToPoints_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, CopyToPoints_ReturnValue_Offset), 0, CopyToPoints_ReturnValue_PropertyAddress.Address);
	}

	static UGSEArteriesSceneFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEArteriesSceneFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEArteriesSceneFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEArteriesSceneFuncLib");
		TranslatePoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TranslatePoints");
		TranslatePoints_ParamsSize = NativeReflection.GetFunctionParamsSize(TranslatePoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TranslatePoints_Obj_PropertyAddress, TranslatePoints_FunctionAddress, "Obj");
		TranslatePoints_Obj_Offset = NativeReflectionCached.GetPropertyOffset(TranslatePoints_FunctionAddress, "Obj");
		TranslatePoints_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslatePoints_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslatePoints_Translate_PropertyAddress, TranslatePoints_FunctionAddress, "Translate");
		TranslatePoints_Translate_Offset = NativeReflectionCached.GetPropertyOffset(TranslatePoints_FunctionAddress, "Translate");
		TranslatePoints_Translate_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslatePoints_FunctionAddress, "Translate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslatePoints_bUseScale_PropertyAddress, TranslatePoints_FunctionAddress, "bUseScale");
		TranslatePoints_bUseScale_Offset = NativeReflectionCached.GetPropertyOffset(TranslatePoints_FunctionAddress, "bUseScale");
		TranslatePoints_bUseScale_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslatePoints_FunctionAddress, "bUseScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslatePoints_ReturnValue_PropertyAddress, TranslatePoints_FunctionAddress, "ReturnValue");
		TranslatePoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TranslatePoints_FunctionAddress, "ReturnValue");
		TranslatePoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslatePoints_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		TranslatePoints_IsValid = TranslatePoints_FunctionAddress != IntPtr.Zero && TranslatePoints_Obj_IsValid && TranslatePoints_Translate_IsValid && TranslatePoints_bUseScale_IsValid && TranslatePoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:TranslatePoints", TranslatePoints_IsValid);
		SurroundLandScapeBySpline_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SurroundLandScapeBySpline");
		SurroundLandScapeBySpline_ParamsSize = NativeReflection.GetFunctionParamsSize(SurroundLandScapeBySpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_OwnerActor_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "OwnerActor");
		SurroundLandScapeBySpline_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "OwnerActor");
		SurroundLandScapeBySpline_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_LandscapeReader_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "LandscapeReader");
		SurroundLandScapeBySpline_LandscapeReader_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "LandscapeReader");
		SurroundLandScapeBySpline_LandscapeReader_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "LandscapeReader", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_SplineComp_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "SplineComp");
		SurroundLandScapeBySpline_SplineComp_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "SplineComp");
		SurroundLandScapeBySpline_SplineComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "SplineComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_Extent_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "Extent");
		SurroundLandScapeBySpline_Extent_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "Extent");
		SurroundLandScapeBySpline_Extent_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "Extent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_MaxStep_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "MaxStep");
		SurroundLandScapeBySpline_MaxStep_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "MaxStep");
		SurroundLandScapeBySpline_MaxStep_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "MaxStep", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_MinStep_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "MinStep");
		SurroundLandScapeBySpline_MinStep_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "MinStep");
		SurroundLandScapeBySpline_MinStep_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "MinStep", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_OverlapMax_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "OverlapMax");
		SurroundLandScapeBySpline_OverlapMax_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "OverlapMax");
		SurroundLandScapeBySpline_OverlapMax_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "OverlapMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_OverlapMin_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "OverlapMin");
		SurroundLandScapeBySpline_OverlapMin_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "OverlapMin");
		SurroundLandScapeBySpline_OverlapMin_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "OverlapMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_ExposeBias_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "ExposeBias");
		SurroundLandScapeBySpline_ExposeBias_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "ExposeBias");
		SurroundLandScapeBySpline_ExposeBias_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "ExposeBias", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_Close_Tolerate_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "Close_Tolerate");
		SurroundLandScapeBySpline_Close_Tolerate_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "Close_Tolerate");
		SurroundLandScapeBySpline_Close_Tolerate_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "Close_Tolerate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_Far_Tolerate_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "Far_Tolerate");
		SurroundLandScapeBySpline_Far_Tolerate_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "Far_Tolerate");
		SurroundLandScapeBySpline_Far_Tolerate_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "Far_Tolerate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_Debug_MainIter_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "Debug_MainIter");
		SurroundLandScapeBySpline_Debug_MainIter_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "Debug_MainIter");
		SurroundLandScapeBySpline_Debug_MainIter_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "Debug_MainIter", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_Debug_OverlapIter_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "Debug_OverlapIter");
		SurroundLandScapeBySpline_Debug_OverlapIter_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "Debug_OverlapIter");
		SurroundLandScapeBySpline_Debug_OverlapIter_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "Debug_OverlapIter", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_Debug_LenIter_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "Debug_LenIter");
		SurroundLandScapeBySpline_Debug_LenIter_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "Debug_LenIter");
		SurroundLandScapeBySpline_Debug_LenIter_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "Debug_LenIter", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_Debug_XOffsetIter_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "Debug_XOffsetIter");
		SurroundLandScapeBySpline_Debug_XOffsetIter_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "Debug_XOffsetIter");
		SurroundLandScapeBySpline_Debug_XOffsetIter_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "Debug_XOffsetIter", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_bEnableDebug_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "bEnableDebug");
		SurroundLandScapeBySpline_bEnableDebug_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "bEnableDebug");
		SurroundLandScapeBySpline_bEnableDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "bEnableDebug", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundLandScapeBySpline_ReturnValue_PropertyAddress, SurroundLandScapeBySpline_FunctionAddress, "ReturnValue");
		SurroundLandScapeBySpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SurroundLandScapeBySpline_FunctionAddress, "ReturnValue");
		SurroundLandScapeBySpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SurroundLandScapeBySpline_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SurroundLandScapeBySpline_IsValid = SurroundLandScapeBySpline_FunctionAddress != IntPtr.Zero && SurroundLandScapeBySpline_OwnerActor_IsValid && SurroundLandScapeBySpline_LandscapeReader_IsValid && SurroundLandScapeBySpline_SplineComp_IsValid && SurroundLandScapeBySpline_Extent_IsValid && SurroundLandScapeBySpline_MaxStep_IsValid && SurroundLandScapeBySpline_MinStep_IsValid && SurroundLandScapeBySpline_OverlapMax_IsValid && SurroundLandScapeBySpline_OverlapMin_IsValid && SurroundLandScapeBySpline_ExposeBias_IsValid && SurroundLandScapeBySpline_Close_Tolerate_IsValid && SurroundLandScapeBySpline_Far_Tolerate_IsValid && SurroundLandScapeBySpline_Debug_MainIter_IsValid && SurroundLandScapeBySpline_Debug_OverlapIter_IsValid && SurroundLandScapeBySpline_Debug_LenIter_IsValid && SurroundLandScapeBySpline_Debug_XOffsetIter_IsValid && SurroundLandScapeBySpline_bEnableDebug_IsValid && SurroundLandScapeBySpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:SurroundLandScapeBySpline", SurroundLandScapeBySpline_IsValid);
		ScatterPointsBySpline_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScatterPointsBySpline");
		ScatterPointsBySpline_ParamsSize = NativeReflection.GetFunctionParamsSize(ScatterPointsBySpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScatterPointsBySpline_OwnerActor_PropertyAddress, ScatterPointsBySpline_FunctionAddress, "OwnerActor");
		ScatterPointsBySpline_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ScatterPointsBySpline_FunctionAddress, "OwnerActor");
		ScatterPointsBySpline_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterPointsBySpline_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterPointsBySpline_LandscapeReader_PropertyAddress, ScatterPointsBySpline_FunctionAddress, "LandscapeReader");
		ScatterPointsBySpline_LandscapeReader_Offset = NativeReflectionCached.GetPropertyOffset(ScatterPointsBySpline_FunctionAddress, "LandscapeReader");
		ScatterPointsBySpline_LandscapeReader_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterPointsBySpline_FunctionAddress, "LandscapeReader", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterPointsBySpline_SplineComp_PropertyAddress, ScatterPointsBySpline_FunctionAddress, "SplineComp");
		ScatterPointsBySpline_SplineComp_Offset = NativeReflectionCached.GetPropertyOffset(ScatterPointsBySpline_FunctionAddress, "SplineComp");
		ScatterPointsBySpline_SplineComp_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterPointsBySpline_FunctionAddress, "SplineComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterPointsBySpline_StepLen_PropertyAddress, ScatterPointsBySpline_FunctionAddress, "StepLen");
		ScatterPointsBySpline_StepLen_Offset = NativeReflectionCached.GetPropertyOffset(ScatterPointsBySpline_FunctionAddress, "StepLen");
		ScatterPointsBySpline_StepLen_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterPointsBySpline_FunctionAddress, "StepLen", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterPointsBySpline_FallOff_PropertyAddress, ScatterPointsBySpline_FunctionAddress, "FallOff");
		ScatterPointsBySpline_FallOff_Offset = NativeReflectionCached.GetPropertyOffset(ScatterPointsBySpline_FunctionAddress, "FallOff");
		ScatterPointsBySpline_FallOff_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterPointsBySpline_FunctionAddress, "FallOff", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterPointsBySpline_MinDis_PropertyAddress, ScatterPointsBySpline_FunctionAddress, "MinDis");
		ScatterPointsBySpline_MinDis_Offset = NativeReflectionCached.GetPropertyOffset(ScatterPointsBySpline_FunctionAddress, "MinDis");
		ScatterPointsBySpline_MinDis_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterPointsBySpline_FunctionAddress, "MinDis", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterPointsBySpline_MaxDis_PropertyAddress, ScatterPointsBySpline_FunctionAddress, "MaxDis");
		ScatterPointsBySpline_MaxDis_Offset = NativeReflectionCached.GetPropertyOffset(ScatterPointsBySpline_FunctionAddress, "MaxDis");
		ScatterPointsBySpline_MaxDis_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterPointsBySpline_FunctionAddress, "MaxDis", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterPointsBySpline_RandRot_PropertyAddress, ScatterPointsBySpline_FunctionAddress, "RandRot");
		ScatterPointsBySpline_RandRot_Offset = NativeReflectionCached.GetPropertyOffset(ScatterPointsBySpline_FunctionAddress, "RandRot");
		ScatterPointsBySpline_RandRot_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterPointsBySpline_FunctionAddress, "RandRot", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterPointsBySpline_RandScale_PropertyAddress, ScatterPointsBySpline_FunctionAddress, "RandScale");
		ScatterPointsBySpline_RandScale_Offset = NativeReflectionCached.GetPropertyOffset(ScatterPointsBySpline_FunctionAddress, "RandScale");
		ScatterPointsBySpline_RandScale_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterPointsBySpline_FunctionAddress, "RandScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterPointsBySpline_ReturnValue_PropertyAddress, ScatterPointsBySpline_FunctionAddress, "ReturnValue");
		ScatterPointsBySpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScatterPointsBySpline_FunctionAddress, "ReturnValue");
		ScatterPointsBySpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterPointsBySpline_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ScatterPointsBySpline_IsValid = ScatterPointsBySpline_FunctionAddress != IntPtr.Zero && ScatterPointsBySpline_OwnerActor_IsValid && ScatterPointsBySpline_LandscapeReader_IsValid && ScatterPointsBySpline_SplineComp_IsValid && ScatterPointsBySpline_StepLen_IsValid && ScatterPointsBySpline_FallOff_IsValid && ScatterPointsBySpline_MinDis_IsValid && ScatterPointsBySpline_MaxDis_IsValid && ScatterPointsBySpline_RandRot_IsValid && ScatterPointsBySpline_RandScale_IsValid && ScatterPointsBySpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:ScatterPointsBySpline", ScatterPointsBySpline_IsValid);
		ScalePoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScalePoints");
		ScalePoints_ParamsSize = NativeReflection.GetFunctionParamsSize(ScalePoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScalePoints_Obj_PropertyAddress, ScalePoints_FunctionAddress, "Obj");
		ScalePoints_Obj_Offset = NativeReflectionCached.GetPropertyOffset(ScalePoints_FunctionAddress, "Obj");
		ScalePoints_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(ScalePoints_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScalePoints_Weight_PropertyAddress, ScalePoints_FunctionAddress, "Weight");
		ScalePoints_Weight_Offset = NativeReflectionCached.GetPropertyOffset(ScalePoints_FunctionAddress, "Weight");
		ScalePoints_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(ScalePoints_FunctionAddress, "Weight", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScalePoints_Bias_PropertyAddress, ScalePoints_FunctionAddress, "Bias");
		ScalePoints_Bias_Offset = NativeReflectionCached.GetPropertyOffset(ScalePoints_FunctionAddress, "Bias");
		ScalePoints_Bias_IsValid = NativeReflectionCached.ValidatePropertyClass(ScalePoints_FunctionAddress, "Bias", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScalePoints_ReturnValue_PropertyAddress, ScalePoints_FunctionAddress, "ReturnValue");
		ScalePoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScalePoints_FunctionAddress, "ReturnValue");
		ScalePoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScalePoints_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ScalePoints_IsValid = ScalePoints_FunctionAddress != IntPtr.Zero && ScalePoints_Obj_IsValid && ScalePoints_Weight_IsValid && ScalePoints_Bias_IsValid && ScalePoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:ScalePoints", ScalePoints_IsValid);
		GetExtent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExtent");
		GetExtent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExtent_SM_PropertyAddress, GetExtent_FunctionAddress, "SM");
		GetExtent_SM_Offset = NativeReflectionCached.GetPropertyOffset(GetExtent_FunctionAddress, "SM");
		GetExtent_SM_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtent_FunctionAddress, "SM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExtent_ReturnValue_PropertyAddress, GetExtent_FunctionAddress, "ReturnValue");
		GetExtent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExtent_FunctionAddress, "ReturnValue");
		GetExtent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetExtent_IsValid = GetExtent_FunctionAddress != IntPtr.Zero && GetExtent_SM_IsValid && GetExtent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:GetExtent", GetExtent_IsValid);
		CreateHISMComp_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateHISMComp");
		CreateHISMComp_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateHISMComp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateHISMComp_Actor_PropertyAddress, CreateHISMComp_FunctionAddress, "Actor");
		CreateHISMComp_Actor_Offset = NativeReflectionCached.GetPropertyOffset(CreateHISMComp_FunctionAddress, "Actor");
		CreateHISMComp_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateHISMComp_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateHISMComp_Object_PropertyAddress, CreateHISMComp_FunctionAddress, "Object");
		CreateHISMComp_Object_Offset = NativeReflectionCached.GetPropertyOffset(CreateHISMComp_FunctionAddress, "Object");
		CreateHISMComp_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateHISMComp_FunctionAddress, "Object", Classes.FObjectProperty);
		CreateHISMComp_IsValid = CreateHISMComp_FunctionAddress != IntPtr.Zero && CreateHISMComp_Actor_IsValid && CreateHISMComp_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:CreateHISMComp", CreateHISMComp_IsValid);
		CopyToPoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyToPoints");
		CopyToPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyToPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyToPoints_Obj_PropertyAddress, CopyToPoints_FunctionAddress, "Obj");
		CopyToPoints_Obj_Offset = NativeReflectionCached.GetPropertyOffset(CopyToPoints_FunctionAddress, "Obj");
		CopyToPoints_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyToPoints_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyToPoints_SrcObject_PropertyAddress, CopyToPoints_FunctionAddress, "SrcObject");
		CopyToPoints_SrcObject_Offset = NativeReflectionCached.GetPropertyOffset(CopyToPoints_FunctionAddress, "SrcObject");
		CopyToPoints_SrcObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyToPoints_FunctionAddress, "SrcObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyToPoints_ReturnValue_PropertyAddress, CopyToPoints_FunctionAddress, "ReturnValue");
		CopyToPoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyToPoints_FunctionAddress, "ReturnValue");
		CopyToPoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyToPoints_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CopyToPoints_IsValid = CopyToPoints_FunctionAddress != IntPtr.Zero && CopyToPoints_Obj_IsValid && CopyToPoints_SrcObject_IsValid && CopyToPoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEArteriesSceneFuncLib:CopyToPoints", CopyToPoints_IsValid);
	}
}
