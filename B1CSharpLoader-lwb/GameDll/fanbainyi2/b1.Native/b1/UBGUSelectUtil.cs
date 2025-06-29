using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUSelectUtil", "b1", UnrealModuleType.Game)]
public class UBGUSelectUtil : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SphereOverlapBGUCharacters_IsValid;

	private static IntPtr SphereOverlapBGUCharacters_FunctionAddress;

	private static int SphereOverlapBGUCharacters_ParamsSize;

	private static bool SphereOverlapBGUCharacters_WorldContext_IsValid;

	private static FFieldAddress SphereOverlapBGUCharacters_WorldContext_PropertyAddress;

	private static int SphereOverlapBGUCharacters_WorldContext_Offset;

	private static bool SphereOverlapBGUCharacters_SphereCenter_IsValid;

	private static FFieldAddress SphereOverlapBGUCharacters_SphereCenter_PropertyAddress;

	private static int SphereOverlapBGUCharacters_SphereCenter_Offset;

	private static bool SphereOverlapBGUCharacters_Radius_IsValid;

	private static FFieldAddress SphereOverlapBGUCharacters_Radius_PropertyAddress;

	private static int SphereOverlapBGUCharacters_Radius_Offset;

	private static bool SphereOverlapBGUCharacters_OutArray_IsValid;

	private static FFieldAddress SphereOverlapBGUCharacters_OutArray_PropertyAddress;

	private static int SphereOverlapBGUCharacters_OutArray_Offset;

	private static bool SphereOverlapBGUCharacters_QueryChannel_IsValid;

	private static FFieldAddress SphereOverlapBGUCharacters_QueryChannel_PropertyAddress;

	private static int SphereOverlapBGUCharacters_QueryChannel_Offset;

	private static bool SphereOverlapBGUCharacters_ReturnValue_IsValid;

	private static FFieldAddress SphereOverlapBGUCharacters_ReturnValue_PropertyAddress;

	private static int SphereOverlapBGUCharacters_ReturnValue_Offset;

	private static bool SelectBGUCharactersInRect_IsValid;

	private static IntPtr SelectBGUCharactersInRect_FunctionAddress;

	private static int SelectBGUCharactersInRect_ParamsSize;

	private static bool SelectBGUCharactersInRect_WorldContextObject_IsValid;

	private static FFieldAddress SelectBGUCharactersInRect_WorldContextObject_PropertyAddress;

	private static int SelectBGUCharactersInRect_WorldContextObject_Offset;

	private static bool SelectBGUCharactersInRect_OutActors_IsValid;

	private static FFieldAddress SelectBGUCharactersInRect_OutActors_PropertyAddress;

	private static int SelectBGUCharactersInRect_OutActors_Offset;

	private static bool SelectBGUCharactersInRect_TargetBase_IsValid;

	private static FFieldAddress SelectBGUCharactersInRect_TargetBase_PropertyAddress;

	private static int SelectBGUCharactersInRect_TargetBase_Offset;

	private static bool SelectBGUCharactersInRect_TargetCount_IsValid;

	private static FFieldAddress SelectBGUCharactersInRect_TargetCount_PropertyAddress;

	private static int SelectBGUCharactersInRect_TargetCount_Offset;

	private static bool SelectBGUCharactersInRect_TargetFilter_IsValid;

	private static FFieldAddress SelectBGUCharactersInRect_TargetFilter_PropertyAddress;

	private static int SelectBGUCharactersInRect_TargetFilter_Offset;

	private static bool SelectBGUCharactersInRect_Params_IsValid;

	private static FFieldAddress SelectBGUCharactersInRect_Params_PropertyAddress;

	private static int SelectBGUCharactersInRect_Params_Offset;

	private static bool SelectBGUCharactersInRect_ReturnValue_IsValid;

	private static FFieldAddress SelectBGUCharactersInRect_ReturnValue_PropertyAddress;

	private static int SelectBGUCharactersInRect_ReturnValue_Offset;

	private static bool SelectBGUCharactersInCylinder_IsValid;

	private static IntPtr SelectBGUCharactersInCylinder_FunctionAddress;

	private static int SelectBGUCharactersInCylinder_ParamsSize;

	private static bool SelectBGUCharactersInCylinder_WorldContextObject_IsValid;

	private static FFieldAddress SelectBGUCharactersInCylinder_WorldContextObject_PropertyAddress;

	private static int SelectBGUCharactersInCylinder_WorldContextObject_Offset;

	private static bool SelectBGUCharactersInCylinder_OutActors_IsValid;

	private static FFieldAddress SelectBGUCharactersInCylinder_OutActors_PropertyAddress;

	private static int SelectBGUCharactersInCylinder_OutActors_Offset;

	private static bool SelectBGUCharactersInCylinder_TargetBase_IsValid;

	private static FFieldAddress SelectBGUCharactersInCylinder_TargetBase_PropertyAddress;

	private static int SelectBGUCharactersInCylinder_TargetBase_Offset;

	private static bool SelectBGUCharactersInCylinder_TargetCount_IsValid;

	private static FFieldAddress SelectBGUCharactersInCylinder_TargetCount_PropertyAddress;

	private static int SelectBGUCharactersInCylinder_TargetCount_Offset;

	private static bool SelectBGUCharactersInCylinder_TargetFilter_IsValid;

	private static FFieldAddress SelectBGUCharactersInCylinder_TargetFilter_PropertyAddress;

	private static int SelectBGUCharactersInCylinder_TargetFilter_Offset;

	private static bool SelectBGUCharactersInCylinder_Params_IsValid;

	private static FFieldAddress SelectBGUCharactersInCylinder_Params_PropertyAddress;

	private static int SelectBGUCharactersInCylinder_Params_Offset;

	private static bool SelectBGUCharactersInCylinder_ReturnValue_IsValid;

	private static FFieldAddress SelectBGUCharactersInCylinder_ReturnValue_PropertyAddress;

	private static int SelectBGUCharactersInCylinder_ReturnValue_Offset;

	private static bool SelectBGUCharactersInCircle_IsValid;

	private static IntPtr SelectBGUCharactersInCircle_FunctionAddress;

	private static int SelectBGUCharactersInCircle_ParamsSize;

	private static bool SelectBGUCharactersInCircle_WorldContextObject_IsValid;

	private static FFieldAddress SelectBGUCharactersInCircle_WorldContextObject_PropertyAddress;

	private static int SelectBGUCharactersInCircle_WorldContextObject_Offset;

	private static bool SelectBGUCharactersInCircle_OutActors_IsValid;

	private static FFieldAddress SelectBGUCharactersInCircle_OutActors_PropertyAddress;

	private static int SelectBGUCharactersInCircle_OutActors_Offset;

	private static bool SelectBGUCharactersInCircle_TargetBase_IsValid;

	private static FFieldAddress SelectBGUCharactersInCircle_TargetBase_PropertyAddress;

	private static int SelectBGUCharactersInCircle_TargetBase_Offset;

	private static bool SelectBGUCharactersInCircle_TargetCount_IsValid;

	private static FFieldAddress SelectBGUCharactersInCircle_TargetCount_PropertyAddress;

	private static int SelectBGUCharactersInCircle_TargetCount_Offset;

	private static bool SelectBGUCharactersInCircle_TargetFilter_IsValid;

	private static FFieldAddress SelectBGUCharactersInCircle_TargetFilter_PropertyAddress;

	private static int SelectBGUCharactersInCircle_TargetFilter_Offset;

	private static bool SelectBGUCharactersInCircle_Params_IsValid;

	private static FFieldAddress SelectBGUCharactersInCircle_Params_PropertyAddress;

	private static int SelectBGUCharactersInCircle_Params_Offset;

	private static bool SelectBGUCharactersInCircle_ReturnValue_IsValid;

	private static FFieldAddress SelectBGUCharactersInCircle_ReturnValue_PropertyAddress;

	private static int SelectBGUCharactersInCircle_ReturnValue_Offset;

	private static bool MultiSphereTraceForObjects_IsValid;

	private static IntPtr MultiSphereTraceForObjects_FunctionAddress;

	private static int MultiSphereTraceForObjects_ParamsSize;

	private static bool MultiSphereTraceForObjects_WorldContextObject_IsValid;

	private static FFieldAddress MultiSphereTraceForObjects_WorldContextObject_PropertyAddress;

	private static int MultiSphereTraceForObjects_WorldContextObject_Offset;

	private static bool MultiSphereTraceForObjects_StartTrace_IsValid;

	private static FFieldAddress MultiSphereTraceForObjects_StartTrace_PropertyAddress;

	private static int MultiSphereTraceForObjects_StartTrace_Offset;

	private static bool MultiSphereTraceForObjects_EndTrace_IsValid;

	private static FFieldAddress MultiSphereTraceForObjects_EndTrace_PropertyAddress;

	private static int MultiSphereTraceForObjects_EndTrace_Offset;

	private static bool MultiSphereTraceForObjects_Radius_IsValid;

	private static FFieldAddress MultiSphereTraceForObjects_Radius_PropertyAddress;

	private static int MultiSphereTraceForObjects_Radius_Offset;

	private static bool MultiSphereTraceForObjects_ObjectTypes_IsValid;

	private static FFieldAddress MultiSphereTraceForObjects_ObjectTypes_PropertyAddress;

	private static int MultiSphereTraceForObjects_ObjectTypes_Offset;

	private static bool MultiSphereTraceForObjects_bDebug_IsValid;

	private static FFieldAddress MultiSphereTraceForObjects_bDebug_PropertyAddress;

	private static int MultiSphereTraceForObjects_bDebug_Offset;

	private static bool MultiSphereTraceForObjects_HitResultList_IsValid;

	private static FFieldAddress MultiSphereTraceForObjects_HitResultList_PropertyAddress;

	private static int MultiSphereTraceForObjects_HitResultList_Offset;

	private static bool MultiSphereTraceForObjects_ReturnValue_IsValid;

	private static FFieldAddress MultiSphereTraceForObjects_ReturnValue_PropertyAddress;

	private static int MultiSphereTraceForObjects_ReturnValue_Offset;

	private static bool LineTraceSingleForObjects_IsValid;

	private static IntPtr LineTraceSingleForObjects_FunctionAddress;

	private static int LineTraceSingleForObjects_ParamsSize;

	private static bool LineTraceSingleForObjects_WorldContextObject_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_WorldContextObject_PropertyAddress;

	private static int LineTraceSingleForObjects_WorldContextObject_Offset;

	private static bool LineTraceSingleForObjects_Start_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_Start_PropertyAddress;

	private static int LineTraceSingleForObjects_Start_Offset;

	private static bool LineTraceSingleForObjects_End_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_End_PropertyAddress;

	private static int LineTraceSingleForObjects_End_Offset;

	private static bool LineTraceSingleForObjects_ObjectTypes_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_ObjectTypes_PropertyAddress;

	private static int LineTraceSingleForObjects_ObjectTypes_Offset;

	private static bool LineTraceSingleForObjects_bTraceComplex_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_bTraceComplex_PropertyAddress;

	private static int LineTraceSingleForObjects_bTraceComplex_Offset;

	private static bool LineTraceSingleForObjects_ActorsToIgnore_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_ActorsToIgnore_PropertyAddress;

	private static int LineTraceSingleForObjects_ActorsToIgnore_Offset;

	private static bool LineTraceSingleForObjects_DrawDebugType_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_DrawDebugType_PropertyAddress;

	private static int LineTraceSingleForObjects_DrawDebugType_Offset;

	private static bool LineTraceSingleForObjects_OutHit_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_OutHit_PropertyAddress;

	private static int LineTraceSingleForObjects_OutHit_Offset;

	private static bool LineTraceSingleForObjects_bIgnoreSelf_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_bIgnoreSelf_PropertyAddress;

	private static int LineTraceSingleForObjects_bIgnoreSelf_Offset;

	private static bool LineTraceSingleForObjects_TraceColor_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_TraceColor_PropertyAddress;

	private static int LineTraceSingleForObjects_TraceColor_Offset;

	private static bool LineTraceSingleForObjects_TraceHitColor_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_TraceHitColor_PropertyAddress;

	private static int LineTraceSingleForObjects_TraceHitColor_Offset;

	private static bool LineTraceSingleForObjects_DrawTime_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_DrawTime_PropertyAddress;

	private static int LineTraceSingleForObjects_DrawTime_Offset;

	private static bool LineTraceSingleForObjects_ReturnValue_IsValid;

	private static FFieldAddress LineTraceSingleForObjects_ReturnValue_PropertyAddress;

	private static int LineTraceSingleForObjects_ReturnValue_Offset;

	private static bool LineTraceSimple_IsValid;

	private static IntPtr LineTraceSimple_FunctionAddress;

	private static int LineTraceSimple_ParamsSize;

	private static bool LineTraceSimple_WorldContextObject_IsValid;

	private static FFieldAddress LineTraceSimple_WorldContextObject_PropertyAddress;

	private static int LineTraceSimple_WorldContextObject_Offset;

	private static bool LineTraceSimple_StartTrace_IsValid;

	private static FFieldAddress LineTraceSimple_StartTrace_PropertyAddress;

	private static int LineTraceSimple_StartTrace_Offset;

	private static bool LineTraceSimple_EndTrace_IsValid;

	private static FFieldAddress LineTraceSimple_EndTrace_PropertyAddress;

	private static int LineTraceSimple_EndTrace_Offset;

	private static bool LineTraceSimple_QueryChnl_IsValid;

	private static FFieldAddress LineTraceSimple_QueryChnl_PropertyAddress;

	private static int LineTraceSimple_QueryChnl_Offset;

	private static bool LineTraceSimple_bDebug_IsValid;

	private static FFieldAddress LineTraceSimple_bDebug_PropertyAddress;

	private static int LineTraceSimple_bDebug_Offset;

	private static bool LineTraceSimple_HitResult_IsValid;

	private static FFieldAddress LineTraceSimple_HitResult_PropertyAddress;

	private static int LineTraceSimple_HitResult_Offset;

	private static bool LineTraceSimple_Ingnores_IsValid;

	private static FFieldAddress LineTraceSimple_Ingnores_PropertyAddress;

	private static int LineTraceSimple_Ingnores_Offset;

	private static bool LineTraceSimple_bTraceComplex_IsValid;

	private static FFieldAddress LineTraceSimple_bTraceComplex_PropertyAddress;

	private static int LineTraceSimple_bTraceComplex_Offset;

	private static bool LineTraceSimple_ReturnValue_IsValid;

	private static FFieldAddress LineTraceSimple_ReturnValue_PropertyAddress;

	private static int LineTraceSimple_ReturnValue_Offset;

	private static bool LineTraceOnlyCheck_IsValid;

	private static IntPtr LineTraceOnlyCheck_FunctionAddress;

	private static int LineTraceOnlyCheck_ParamsSize;

	private static bool LineTraceOnlyCheck_WorldContextObject_IsValid;

	private static FFieldAddress LineTraceOnlyCheck_WorldContextObject_PropertyAddress;

	private static int LineTraceOnlyCheck_WorldContextObject_Offset;

	private static bool LineTraceOnlyCheck_StartTrace_IsValid;

	private static FFieldAddress LineTraceOnlyCheck_StartTrace_PropertyAddress;

	private static int LineTraceOnlyCheck_StartTrace_Offset;

	private static bool LineTraceOnlyCheck_EndTrace_IsValid;

	private static FFieldAddress LineTraceOnlyCheck_EndTrace_PropertyAddress;

	private static int LineTraceOnlyCheck_EndTrace_Offset;

	private static bool LineTraceOnlyCheck_QueryChnl_IsValid;

	private static FFieldAddress LineTraceOnlyCheck_QueryChnl_PropertyAddress;

	private static int LineTraceOnlyCheck_QueryChnl_Offset;

	private static bool LineTraceOnlyCheck_bDebug_IsValid;

	private static FFieldAddress LineTraceOnlyCheck_bDebug_PropertyAddress;

	private static int LineTraceOnlyCheck_bDebug_Offset;

	private static bool LineTraceOnlyCheck_HitResult_IsValid;

	private static FFieldAddress LineTraceOnlyCheck_HitResult_PropertyAddress;

	private static int LineTraceOnlyCheck_HitResult_Offset;

	private static bool LineTraceOnlyCheck_Ingnores_IsValid;

	private static FFieldAddress LineTraceOnlyCheck_Ingnores_PropertyAddress;

	private static int LineTraceOnlyCheck_Ingnores_Offset;

	private static bool LineTraceOnlyCheck_bTraceComplex_IsValid;

	private static FFieldAddress LineTraceOnlyCheck_bTraceComplex_PropertyAddress;

	private static int LineTraceOnlyCheck_bTraceComplex_Offset;

	private static bool LineTraceOnlyCheck_ReturnValue_IsValid;

	private static FFieldAddress LineTraceOnlyCheck_ReturnValue_PropertyAddress;

	private static int LineTraceOnlyCheck_ReturnValue_Offset;

	private static bool LineTraceMultiByObjType_IsValid;

	private static IntPtr LineTraceMultiByObjType_FunctionAddress;

	private static int LineTraceMultiByObjType_ParamsSize;

	private static bool LineTraceMultiByObjType_WorldContextObject_IsValid;

	private static FFieldAddress LineTraceMultiByObjType_WorldContextObject_PropertyAddress;

	private static int LineTraceMultiByObjType_WorldContextObject_Offset;

	private static bool LineTraceMultiByObjType_StartTrace_IsValid;

	private static FFieldAddress LineTraceMultiByObjType_StartTrace_PropertyAddress;

	private static int LineTraceMultiByObjType_StartTrace_Offset;

	private static bool LineTraceMultiByObjType_EndTrace_IsValid;

	private static FFieldAddress LineTraceMultiByObjType_EndTrace_PropertyAddress;

	private static int LineTraceMultiByObjType_EndTrace_Offset;

	private static bool LineTraceMultiByObjType_ObjectTypes_IsValid;

	private static FFieldAddress LineTraceMultiByObjType_ObjectTypes_PropertyAddress;

	private static int LineTraceMultiByObjType_ObjectTypes_Offset;

	private static bool LineTraceMultiByObjType_bDebug_IsValid;

	private static FFieldAddress LineTraceMultiByObjType_bDebug_PropertyAddress;

	private static int LineTraceMultiByObjType_bDebug_Offset;

	private static bool LineTraceMultiByObjType_HitResultList_IsValid;

	private static FFieldAddress LineTraceMultiByObjType_HitResultList_PropertyAddress;

	private static int LineTraceMultiByObjType_HitResultList_Offset;

	private static bool LineTraceMultiByObjType_ReturnValue_IsValid;

	private static FFieldAddress LineTraceMultiByObjType_ReturnValue_PropertyAddress;

	private static int LineTraceMultiByObjType_ReturnValue_Offset;

	private static bool LineTraceForObjectsTypeSimple_IsValid;

	private static IntPtr LineTraceForObjectsTypeSimple_FunctionAddress;

	private static int LineTraceForObjectsTypeSimple_ParamsSize;

	private static bool LineTraceForObjectsTypeSimple_WorldContextObject_IsValid;

	private static FFieldAddress LineTraceForObjectsTypeSimple_WorldContextObject_PropertyAddress;

	private static int LineTraceForObjectsTypeSimple_WorldContextObject_Offset;

	private static bool LineTraceForObjectsTypeSimple_StartTrace_IsValid;

	private static FFieldAddress LineTraceForObjectsTypeSimple_StartTrace_PropertyAddress;

	private static int LineTraceForObjectsTypeSimple_StartTrace_Offset;

	private static bool LineTraceForObjectsTypeSimple_EndTrace_IsValid;

	private static FFieldAddress LineTraceForObjectsTypeSimple_EndTrace_PropertyAddress;

	private static int LineTraceForObjectsTypeSimple_EndTrace_Offset;

	private static bool LineTraceForObjectsTypeSimple_ObjectTypes_IsValid;

	private static FFieldAddress LineTraceForObjectsTypeSimple_ObjectTypes_PropertyAddress;

	private static int LineTraceForObjectsTypeSimple_ObjectTypes_Offset;

	private static bool LineTraceForObjectsTypeSimple_bDebug_IsValid;

	private static FFieldAddress LineTraceForObjectsTypeSimple_bDebug_PropertyAddress;

	private static int LineTraceForObjectsTypeSimple_bDebug_Offset;

	private static bool LineTraceForObjectsTypeSimple_HitResult_IsValid;

	private static FFieldAddress LineTraceForObjectsTypeSimple_HitResult_PropertyAddress;

	private static int LineTraceForObjectsTypeSimple_HitResult_Offset;

	private static bool LineTraceForObjectsTypeSimple_bTraceComplex_IsValid;

	private static FFieldAddress LineTraceForObjectsTypeSimple_bTraceComplex_PropertyAddress;

	private static int LineTraceForObjectsTypeSimple_bTraceComplex_Offset;

	private static bool LineTraceForObjectsTypeSimple_ReturnValue_IsValid;

	private static FFieldAddress LineTraceForObjectsTypeSimple_ReturnValue_PropertyAddress;

	private static int LineTraceForObjectsTypeSimple_ReturnValue_Offset;

	private static bool LineTraceForObjects_IsValid;

	private static IntPtr LineTraceForObjects_FunctionAddress;

	private static int LineTraceForObjects_ParamsSize;

	private static bool LineTraceForObjects_WorldContextObject_IsValid;

	private static FFieldAddress LineTraceForObjects_WorldContextObject_PropertyAddress;

	private static int LineTraceForObjects_WorldContextObject_Offset;

	private static bool LineTraceForObjects_StartTrace_IsValid;

	private static FFieldAddress LineTraceForObjects_StartTrace_PropertyAddress;

	private static int LineTraceForObjects_StartTrace_Offset;

	private static bool LineTraceForObjects_EndTrace_IsValid;

	private static FFieldAddress LineTraceForObjects_EndTrace_PropertyAddress;

	private static int LineTraceForObjects_EndTrace_Offset;

	private static bool LineTraceForObjects_ObjectTypes_IsValid;

	private static FFieldAddress LineTraceForObjects_ObjectTypes_PropertyAddress;

	private static int LineTraceForObjects_ObjectTypes_Offset;

	private static bool LineTraceForObjects_bDebug_IsValid;

	private static FFieldAddress LineTraceForObjects_bDebug_PropertyAddress;

	private static int LineTraceForObjects_bDebug_Offset;

	private static bool LineTraceForObjects_HitResult_IsValid;

	private static FFieldAddress LineTraceForObjects_HitResult_PropertyAddress;

	private static int LineTraceForObjects_HitResult_Offset;

	private static bool LineTraceForObjects_ReturnValue_IsValid;

	private static FFieldAddress LineTraceForObjects_ReturnValue_PropertyAddress;

	private static int LineTraceForObjects_ReturnValue_Offset;

	private static bool GetHitUnderCursor_IsValid;

	private static IntPtr GetHitUnderCursor_FunctionAddress;

	private static int GetHitUnderCursor_ParamsSize;

	private static bool GetHitUnderCursor_PlayerCtrl_IsValid;

	private static FFieldAddress GetHitUnderCursor_PlayerCtrl_PropertyAddress;

	private static int GetHitUnderCursor_PlayerCtrl_Offset;

	private static bool GetHitUnderCursor_QueryChnl_IsValid;

	private static FFieldAddress GetHitUnderCursor_QueryChnl_PropertyAddress;

	private static int GetHitUnderCursor_QueryChnl_Offset;

	private static bool GetHitUnderCursor_bTraceComplex_IsValid;

	private static FFieldAddress GetHitUnderCursor_bTraceComplex_PropertyAddress;

	private static int GetHitUnderCursor_bTraceComplex_Offset;

	private static bool GetHitUnderCursor_HitResult_IsValid;

	private static FFieldAddress GetHitUnderCursor_HitResult_PropertyAddress;

	private static int GetHitUnderCursor_HitResult_Offset;

	private static bool GetHitUnderCursor_ReturnValue_IsValid;

	private static FFieldAddress GetHitUnderCursor_ReturnValue_PropertyAddress;

	private static int GetHitUnderCursor_ReturnValue_Offset;

	private static bool BoxOverlapV2BGUCharacters_IsValid;

	private static IntPtr BoxOverlapV2BGUCharacters_FunctionAddress;

	private static int BoxOverlapV2BGUCharacters_ParamsSize;

	private static bool BoxOverlapV2BGUCharacters_WorldContextObject_IsValid;

	private static FFieldAddress BoxOverlapV2BGUCharacters_WorldContextObject_PropertyAddress;

	private static int BoxOverlapV2BGUCharacters_WorldContextObject_Offset;

	private static bool BoxOverlapV2BGUCharacters_BoxPos_IsValid;

	private static FFieldAddress BoxOverlapV2BGUCharacters_BoxPos_PropertyAddress;

	private static int BoxOverlapV2BGUCharacters_BoxPos_Offset;

	private static bool BoxOverlapV2BGUCharacters_Rot_IsValid;

	private static FFieldAddress BoxOverlapV2BGUCharacters_Rot_PropertyAddress;

	private static int BoxOverlapV2BGUCharacters_Rot_Offset;

	private static bool BoxOverlapV2BGUCharacters_BoxExtent_IsValid;

	private static FFieldAddress BoxOverlapV2BGUCharacters_BoxExtent_PropertyAddress;

	private static int BoxOverlapV2BGUCharacters_BoxExtent_Offset;

	private static bool BoxOverlapV2BGUCharacters_OutArray_IsValid;

	private static FFieldAddress BoxOverlapV2BGUCharacters_OutArray_PropertyAddress;

	private static int BoxOverlapV2BGUCharacters_OutArray_Offset;

	private static bool BoxOverlapV2BGUCharacters_ReturnValue_IsValid;

	private static FFieldAddress BoxOverlapV2BGUCharacters_ReturnValue_PropertyAddress;

	private static int BoxOverlapV2BGUCharacters_ReturnValue_Offset;

	private static bool BoxOverlapBGUCharacters_IsValid;

	private static IntPtr BoxOverlapBGUCharacters_FunctionAddress;

	private static int BoxOverlapBGUCharacters_ParamsSize;

	private static bool BoxOverlapBGUCharacters_WorldContextObject_IsValid;

	private static FFieldAddress BoxOverlapBGUCharacters_WorldContextObject_PropertyAddress;

	private static int BoxOverlapBGUCharacters_WorldContextObject_Offset;

	private static bool BoxOverlapBGUCharacters_BoxPos_IsValid;

	private static FFieldAddress BoxOverlapBGUCharacters_BoxPos_PropertyAddress;

	private static int BoxOverlapBGUCharacters_BoxPos_Offset;

	private static bool BoxOverlapBGUCharacters_BoxExtent_IsValid;

	private static FFieldAddress BoxOverlapBGUCharacters_BoxExtent_PropertyAddress;

	private static int BoxOverlapBGUCharacters_BoxExtent_Offset;

	private static bool BoxOverlapBGUCharacters_OutArray_IsValid;

	private static FFieldAddress BoxOverlapBGUCharacters_OutArray_PropertyAddress;

	private static int BoxOverlapBGUCharacters_OutArray_Offset;

	private static bool BoxOverlapBGUCharacters_QueryChannel_IsValid;

	private static FFieldAddress BoxOverlapBGUCharacters_QueryChannel_PropertyAddress;

	private static int BoxOverlapBGUCharacters_QueryChannel_Offset;

	private static bool BoxOverlapBGUCharacters_ReturnValue_IsValid;

	private static FFieldAddress BoxOverlapBGUCharacters_ReturnValue_PropertyAddress;

	private static int BoxOverlapBGUCharacters_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:SphereOverlapBGUCharacters")]
	public unsafe static int SphereOverlapBGUCharacters(UObject WorldContext, FVector SphereCenter, float Radius, out List<ABGUCharacter> OutArray, ECollisionChannel QueryChannel = ECollisionChannel.ECC_Pawn)
	{
		if (!SphereOverlapBGUCharacters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:SphereOverlapBGUCharacters");
			OutArray = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SphereOverlapBGUCharacters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SphereOverlapBGUCharacters_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SphereOverlapBGUCharacters_WorldContext_Offset), 0, SphereOverlapBGUCharacters_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SphereOverlapBGUCharacters_SphereCenter_Offset), 0, SphereOverlapBGUCharacters_SphereCenter_PropertyAddress.Address, SphereCenter);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SphereOverlapBGUCharacters_Radius_Offset), 0, SphereOverlapBGUCharacters_Radius_PropertyAddress.Address, Radius);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, SphereOverlapBGUCharacters_QueryChannel_Offset), 0, SphereOverlapBGUCharacters_QueryChannel_PropertyAddress.Address, QueryChannel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SphereOverlapBGUCharacters_FunctionAddress, intPtr, SphereOverlapBGUCharacters_ParamsSize);
		OutArray = new TArrayCopyMarshaler<ABGUCharacter>(1, SphereOverlapBGUCharacters_OutArray_PropertyAddress, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.FromNative, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.ToNative).FromNative(IntPtr.Add(intPtr, SphereOverlapBGUCharacters_OutArray_Offset));
		NativeReflection.DestroyValue_InContainer(SphereOverlapBGUCharacters_OutArray_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, SphereOverlapBGUCharacters_ReturnValue_Offset), 0, SphereOverlapBGUCharacters_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:SelectBGUCharactersInRect")]
	public unsafe static int SelectBGUCharactersInRect(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, int TargetCount, int TargetFilter, List<int> Params)
	{
		if (!SelectBGUCharactersInRect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:SelectBGUCharactersInRect");
			OutActors = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectBGUCharactersInRect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectBGUCharactersInRect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInRect_WorldContextObject_Offset), 0, SelectBGUCharactersInRect_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInRect_TargetBase_Offset), 0, SelectBGUCharactersInRect_TargetBase_PropertyAddress.Address, TargetBase);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInRect_TargetCount_Offset), 0, SelectBGUCharactersInRect_TargetCount_PropertyAddress.Address, TargetCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInRect_TargetFilter_Offset), 0, SelectBGUCharactersInRect_TargetFilter_PropertyAddress.Address, TargetFilter);
		new TArrayCopyMarshaler<int>(1, SelectBGUCharactersInRect_Params_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInRect_Params_Offset), Params);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectBGUCharactersInRect_FunctionAddress, intPtr, SelectBGUCharactersInRect_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, SelectBGUCharactersInRect_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, SelectBGUCharactersInRect_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(SelectBGUCharactersInRect_OutActors_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SelectBGUCharactersInRect_Params_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, SelectBGUCharactersInRect_ReturnValue_Offset), 0, SelectBGUCharactersInRect_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:SelectBGUCharactersInCylinder")]
	public unsafe static int SelectBGUCharactersInCylinder(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, int TargetCount, int TargetFilter, List<int> Params)
	{
		if (!SelectBGUCharactersInCylinder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:SelectBGUCharactersInCylinder");
			OutActors = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectBGUCharactersInCylinder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectBGUCharactersInCylinder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInCylinder_WorldContextObject_Offset), 0, SelectBGUCharactersInCylinder_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInCylinder_TargetBase_Offset), 0, SelectBGUCharactersInCylinder_TargetBase_PropertyAddress.Address, TargetBase);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInCylinder_TargetCount_Offset), 0, SelectBGUCharactersInCylinder_TargetCount_PropertyAddress.Address, TargetCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInCylinder_TargetFilter_Offset), 0, SelectBGUCharactersInCylinder_TargetFilter_PropertyAddress.Address, TargetFilter);
		new TArrayCopyMarshaler<int>(1, SelectBGUCharactersInCylinder_Params_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInCylinder_Params_Offset), Params);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectBGUCharactersInCylinder_FunctionAddress, intPtr, SelectBGUCharactersInCylinder_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, SelectBGUCharactersInCylinder_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, SelectBGUCharactersInCylinder_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(SelectBGUCharactersInCylinder_OutActors_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SelectBGUCharactersInCylinder_Params_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, SelectBGUCharactersInCylinder_ReturnValue_Offset), 0, SelectBGUCharactersInCylinder_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:SelectBGUCharactersInCircle")]
	public unsafe static int SelectBGUCharactersInCircle(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, int TargetCount, int TargetFilter, List<int> Params)
	{
		if (!SelectBGUCharactersInCircle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:SelectBGUCharactersInCircle");
			OutActors = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectBGUCharactersInCircle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectBGUCharactersInCircle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInCircle_WorldContextObject_Offset), 0, SelectBGUCharactersInCircle_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInCircle_TargetBase_Offset), 0, SelectBGUCharactersInCircle_TargetBase_PropertyAddress.Address, TargetBase);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInCircle_TargetCount_Offset), 0, SelectBGUCharactersInCircle_TargetCount_PropertyAddress.Address, TargetCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInCircle_TargetFilter_Offset), 0, SelectBGUCharactersInCircle_TargetFilter_PropertyAddress.Address, TargetFilter);
		new TArrayCopyMarshaler<int>(1, SelectBGUCharactersInCircle_Params_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, SelectBGUCharactersInCircle_Params_Offset), Params);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectBGUCharactersInCircle_FunctionAddress, intPtr, SelectBGUCharactersInCircle_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, SelectBGUCharactersInCircle_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, SelectBGUCharactersInCircle_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(SelectBGUCharactersInCircle_OutActors_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SelectBGUCharactersInCircle_Params_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, SelectBGUCharactersInCircle_ReturnValue_Offset), 0, SelectBGUCharactersInCircle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:MultiSphereTraceForObjects")]
	public unsafe static int MultiSphereTraceForObjects(UObject WorldContextObject, FVector StartTrace, FVector EndTrace, float Radius, List<EObjectTypeQuery> ObjectTypes, bool bDebug, out List<FHitResultSimple> HitResultList)
	{
		if (!MultiSphereTraceForObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:MultiSphereTraceForObjects");
			HitResultList = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MultiSphereTraceForObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MultiSphereTraceForObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, MultiSphereTraceForObjects_WorldContextObject_Offset), 0, MultiSphereTraceForObjects_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MultiSphereTraceForObjects_StartTrace_Offset), 0, MultiSphereTraceForObjects_StartTrace_PropertyAddress.Address, StartTrace);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MultiSphereTraceForObjects_EndTrace_Offset), 0, MultiSphereTraceForObjects_EndTrace_PropertyAddress.Address, EndTrace);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MultiSphereTraceForObjects_Radius_Offset), 0, MultiSphereTraceForObjects_Radius_PropertyAddress.Address, Radius);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, MultiSphereTraceForObjects_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, MultiSphereTraceForObjects_ObjectTypes_Offset), ObjectTypes);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MultiSphereTraceForObjects_bDebug_Offset), 0, MultiSphereTraceForObjects_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MultiSphereTraceForObjects_FunctionAddress, intPtr, MultiSphereTraceForObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MultiSphereTraceForObjects_ObjectTypes_PropertyAddress.Address, intPtr);
		HitResultList = new TArrayCopyMarshaler<FHitResultSimple>(1, MultiSphereTraceForObjects_HitResultList_PropertyAddress, CachedMarshalingDelegates<FHitResultSimple, StructAsClassMarshaler<FHitResultSimple>>.FromNative, CachedMarshalingDelegates<FHitResultSimple, StructAsClassMarshaler<FHitResultSimple>>.ToNative).FromNative(IntPtr.Add(intPtr, MultiSphereTraceForObjects_HitResultList_Offset));
		NativeReflection.DestroyValue_InContainer(MultiSphereTraceForObjects_HitResultList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, MultiSphereTraceForObjects_ReturnValue_Offset), 0, MultiSphereTraceForObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:LineTraceSingleForObjects")]
	public unsafe static bool LineTraceSingleForObjects(UObject WorldContextObject, FVector Start, FVector End, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		if (!LineTraceSingleForObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:LineTraceSingleForObjects");
			OutHit = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LineTraceSingleForObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LineTraceSingleForObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_WorldContextObject_Offset), 0, LineTraceSingleForObjects_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_Start_Offset), 0, LineTraceSingleForObjects_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_End_Offset), 0, LineTraceSingleForObjects_End_PropertyAddress.Address, End);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, LineTraceSingleForObjects_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_ObjectTypes_Offset), ObjectTypes);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_bTraceComplex_Offset), 0, LineTraceSingleForObjects_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		new TArrayCopyMarshaler<AActor>(1, LineTraceSingleForObjects_ActorsToIgnore_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_ActorsToIgnore_Offset), ActorsToIgnore);
		EnumMarshaler<EDrawDebugTrace>.ToNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_DrawDebugType_Offset), 0, LineTraceSingleForObjects_DrawDebugType_PropertyAddress.Address, DrawDebugType);
		NativeReflection.InitializeValue_InContainer(LineTraceSingleForObjects_OutHit_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_bIgnoreSelf_Offset), 0, LineTraceSingleForObjects_bIgnoreSelf_PropertyAddress.Address, bIgnoreSelf);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_TraceColor_Offset), 0, LineTraceSingleForObjects_TraceColor_PropertyAddress.Address, TraceColor);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_TraceHitColor_Offset), 0, LineTraceSingleForObjects_TraceHitColor_PropertyAddress.Address, TraceHitColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_DrawTime_Offset), 0, LineTraceSingleForObjects_DrawTime_PropertyAddress.Address, DrawTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LineTraceSingleForObjects_FunctionAddress, intPtr, LineTraceSingleForObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LineTraceSingleForObjects_ObjectTypes_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(LineTraceSingleForObjects_ActorsToIgnore_PropertyAddress.Address, intPtr);
		OutHit = FHitResult.FromNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_OutHit_Offset), 0, LineTraceSingleForObjects_OutHit_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LineTraceSingleForObjects_ReturnValue_Offset), 0, LineTraceSingleForObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:LineTraceSimple")]
	public unsafe static int LineTraceSimple(UObject WorldContextObject, FVector StartTrace, FVector EndTrace, ETraceTypeQuery QueryChnl, bool bDebug, out FHitResultSimple HitResult, List<AActor> Ingnores, bool bTraceComplex = false)
	{
		if (!LineTraceSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:LineTraceSimple");
			HitResult = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LineTraceSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LineTraceSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LineTraceSimple_WorldContextObject_Offset), 0, LineTraceSimple_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceSimple_StartTrace_Offset), 0, LineTraceSimple_StartTrace_PropertyAddress.Address, StartTrace);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceSimple_EndTrace_Offset), 0, LineTraceSimple_EndTrace_PropertyAddress.Address, EndTrace);
		EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(intPtr, LineTraceSimple_QueryChnl_Offset), 0, LineTraceSimple_QueryChnl_PropertyAddress.Address, QueryChnl);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceSimple_bDebug_Offset), 0, LineTraceSimple_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InitializeValue_InContainer(LineTraceSimple_HitResult_PropertyAddress.Address, intPtr);
		new TArrayCopyMarshaler<AActor>(1, LineTraceSimple_Ingnores_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, LineTraceSimple_Ingnores_Offset), Ingnores);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceSimple_bTraceComplex_Offset), 0, LineTraceSimple_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LineTraceSimple_FunctionAddress, intPtr, LineTraceSimple_ParamsSize);
		HitResult = StructAsClassMarshaler<FHitResultSimple>.FromNative(IntPtr.Add(intPtr, LineTraceSimple_HitResult_Offset), 0, LineTraceSimple_HitResult_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LineTraceSimple_Ingnores_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, LineTraceSimple_ReturnValue_Offset), 0, LineTraceSimple_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:LineTraceOnlyCheck")]
	public unsafe static int LineTraceOnlyCheck(UObject WorldContextObject, FVector StartTrace, FVector EndTrace, ETraceTypeQuery QueryChnl, bool bDebug, out FHitResultSimple HitResult, List<AActor> Ingnores, bool bTraceComplex = false)
	{
		if (!LineTraceOnlyCheck_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:LineTraceOnlyCheck");
			HitResult = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LineTraceOnlyCheck_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LineTraceOnlyCheck_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LineTraceOnlyCheck_WorldContextObject_Offset), 0, LineTraceOnlyCheck_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceOnlyCheck_StartTrace_Offset), 0, LineTraceOnlyCheck_StartTrace_PropertyAddress.Address, StartTrace);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceOnlyCheck_EndTrace_Offset), 0, LineTraceOnlyCheck_EndTrace_PropertyAddress.Address, EndTrace);
		EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(intPtr, LineTraceOnlyCheck_QueryChnl_Offset), 0, LineTraceOnlyCheck_QueryChnl_PropertyAddress.Address, QueryChnl);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceOnlyCheck_bDebug_Offset), 0, LineTraceOnlyCheck_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InitializeValue_InContainer(LineTraceOnlyCheck_HitResult_PropertyAddress.Address, intPtr);
		new TArrayCopyMarshaler<AActor>(1, LineTraceOnlyCheck_Ingnores_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, LineTraceOnlyCheck_Ingnores_Offset), Ingnores);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceOnlyCheck_bTraceComplex_Offset), 0, LineTraceOnlyCheck_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LineTraceOnlyCheck_FunctionAddress, intPtr, LineTraceOnlyCheck_ParamsSize);
		HitResult = StructAsClassMarshaler<FHitResultSimple>.FromNative(IntPtr.Add(intPtr, LineTraceOnlyCheck_HitResult_Offset), 0, LineTraceOnlyCheck_HitResult_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LineTraceOnlyCheck_Ingnores_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, LineTraceOnlyCheck_ReturnValue_Offset), 0, LineTraceOnlyCheck_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:LineTraceMultiByObjType")]
	public unsafe static int LineTraceMultiByObjType(UObject WorldContextObject, FVector StartTrace, FVector EndTrace, List<EObjectTypeQuery> ObjectTypes, bool bDebug, out List<FHitResultSimple> HitResultList)
	{
		if (!LineTraceMultiByObjType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:LineTraceMultiByObjType");
			HitResultList = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LineTraceMultiByObjType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LineTraceMultiByObjType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LineTraceMultiByObjType_WorldContextObject_Offset), 0, LineTraceMultiByObjType_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceMultiByObjType_StartTrace_Offset), 0, LineTraceMultiByObjType_StartTrace_PropertyAddress.Address, StartTrace);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceMultiByObjType_EndTrace_Offset), 0, LineTraceMultiByObjType_EndTrace_PropertyAddress.Address, EndTrace);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, LineTraceMultiByObjType_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, LineTraceMultiByObjType_ObjectTypes_Offset), ObjectTypes);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceMultiByObjType_bDebug_Offset), 0, LineTraceMultiByObjType_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LineTraceMultiByObjType_FunctionAddress, intPtr, LineTraceMultiByObjType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LineTraceMultiByObjType_ObjectTypes_PropertyAddress.Address, intPtr);
		HitResultList = new TArrayCopyMarshaler<FHitResultSimple>(1, LineTraceMultiByObjType_HitResultList_PropertyAddress, CachedMarshalingDelegates<FHitResultSimple, StructAsClassMarshaler<FHitResultSimple>>.FromNative, CachedMarshalingDelegates<FHitResultSimple, StructAsClassMarshaler<FHitResultSimple>>.ToNative).FromNative(IntPtr.Add(intPtr, LineTraceMultiByObjType_HitResultList_Offset));
		NativeReflection.DestroyValue_InContainer(LineTraceMultiByObjType_HitResultList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, LineTraceMultiByObjType_ReturnValue_Offset), 0, LineTraceMultiByObjType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:LineTraceForObjectsTypeSimple")]
	public unsafe static int LineTraceForObjectsTypeSimple(UObject WorldContextObject, FVector StartTrace, FVector EndTrace, List<EObjectTypeQuery> ObjectTypes, bool bDebug, out FHitResultSimple HitResult, bool bTraceComplex = false)
	{
		if (!LineTraceForObjectsTypeSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:LineTraceForObjectsTypeSimple");
			HitResult = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LineTraceForObjectsTypeSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LineTraceForObjectsTypeSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LineTraceForObjectsTypeSimple_WorldContextObject_Offset), 0, LineTraceForObjectsTypeSimple_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceForObjectsTypeSimple_StartTrace_Offset), 0, LineTraceForObjectsTypeSimple_StartTrace_PropertyAddress.Address, StartTrace);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceForObjectsTypeSimple_EndTrace_Offset), 0, LineTraceForObjectsTypeSimple_EndTrace_PropertyAddress.Address, EndTrace);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, LineTraceForObjectsTypeSimple_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, LineTraceForObjectsTypeSimple_ObjectTypes_Offset), ObjectTypes);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceForObjectsTypeSimple_bDebug_Offset), 0, LineTraceForObjectsTypeSimple_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InitializeValue_InContainer(LineTraceForObjectsTypeSimple_HitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceForObjectsTypeSimple_bTraceComplex_Offset), 0, LineTraceForObjectsTypeSimple_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LineTraceForObjectsTypeSimple_FunctionAddress, intPtr, LineTraceForObjectsTypeSimple_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LineTraceForObjectsTypeSimple_ObjectTypes_PropertyAddress.Address, intPtr);
		HitResult = StructAsClassMarshaler<FHitResultSimple>.FromNative(IntPtr.Add(intPtr, LineTraceForObjectsTypeSimple_HitResult_Offset), 0, LineTraceForObjectsTypeSimple_HitResult_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, LineTraceForObjectsTypeSimple_ReturnValue_Offset), 0, LineTraceForObjectsTypeSimple_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:LineTraceForObjects")]
	public unsafe static int LineTraceForObjects(UObject WorldContextObject, FVector StartTrace, FVector EndTrace, List<EObjectTypeQuery> ObjectTypes, bool bDebug, out FHitResultSimple HitResult)
	{
		if (!LineTraceForObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:LineTraceForObjects");
			HitResult = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LineTraceForObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LineTraceForObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LineTraceForObjects_WorldContextObject_Offset), 0, LineTraceForObjects_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceForObjects_StartTrace_Offset), 0, LineTraceForObjects_StartTrace_PropertyAddress.Address, StartTrace);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceForObjects_EndTrace_Offset), 0, LineTraceForObjects_EndTrace_PropertyAddress.Address, EndTrace);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, LineTraceForObjects_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, LineTraceForObjects_ObjectTypes_Offset), ObjectTypes);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceForObjects_bDebug_Offset), 0, LineTraceForObjects_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InitializeValue_InContainer(LineTraceForObjects_HitResult_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LineTraceForObjects_FunctionAddress, intPtr, LineTraceForObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LineTraceForObjects_ObjectTypes_PropertyAddress.Address, intPtr);
		HitResult = StructAsClassMarshaler<FHitResultSimple>.FromNative(IntPtr.Add(intPtr, LineTraceForObjects_HitResult_Offset), 0, LineTraceForObjects_HitResult_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, LineTraceForObjects_ReturnValue_Offset), 0, LineTraceForObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:GetHitUnderCursor")]
	public unsafe static bool GetHitUnderCursor(APlayerController PlayerCtrl, ETraceTypeQuery QueryChnl, bool bTraceComplex, out FHitResultSimple HitResult)
	{
		if (!GetHitUnderCursor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:GetHitUnderCursor");
			HitResult = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHitUnderCursor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHitUnderCursor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetHitUnderCursor_PlayerCtrl_Offset), 0, GetHitUnderCursor_PlayerCtrl_PropertyAddress.Address, PlayerCtrl);
		EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(intPtr, GetHitUnderCursor_QueryChnl_Offset), 0, GetHitUnderCursor_QueryChnl_PropertyAddress.Address, QueryChnl);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetHitUnderCursor_bTraceComplex_Offset), 0, GetHitUnderCursor_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		NativeReflection.InitializeValue_InContainer(GetHitUnderCursor_HitResult_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetHitUnderCursor_FunctionAddress, intPtr, GetHitUnderCursor_ParamsSize);
		HitResult = StructAsClassMarshaler<FHitResultSimple>.FromNative(IntPtr.Add(intPtr, GetHitUnderCursor_HitResult_Offset), 0, GetHitUnderCursor_HitResult_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHitUnderCursor_ReturnValue_Offset), 0, GetHitUnderCursor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:BoxOverlapV2BGUCharacters")]
	public unsafe static int BoxOverlapV2BGUCharacters(UObject WorldContextObject, FVector BoxPos, FQuat Rot, FVector BoxExtent, out List<ABGUCharacter> OutArray)
	{
		if (!BoxOverlapV2BGUCharacters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:BoxOverlapV2BGUCharacters");
			OutArray = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BoxOverlapV2BGUCharacters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BoxOverlapV2BGUCharacters_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BoxOverlapV2BGUCharacters_WorldContextObject_Offset), 0, BoxOverlapV2BGUCharacters_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BoxOverlapV2BGUCharacters_BoxPos_Offset), 0, BoxOverlapV2BGUCharacters_BoxPos_PropertyAddress.Address, BoxPos);
		NativeReflection.InitializeValue_InContainer(BoxOverlapV2BGUCharacters_Rot_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, BoxOverlapV2BGUCharacters_Rot_Offset), 0, BoxOverlapV2BGUCharacters_Rot_PropertyAddress.Address, Rot);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BoxOverlapV2BGUCharacters_BoxExtent_Offset), 0, BoxOverlapV2BGUCharacters_BoxExtent_PropertyAddress.Address, BoxExtent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BoxOverlapV2BGUCharacters_FunctionAddress, intPtr, BoxOverlapV2BGUCharacters_ParamsSize);
		OutArray = new TArrayCopyMarshaler<ABGUCharacter>(1, BoxOverlapV2BGUCharacters_OutArray_PropertyAddress, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.FromNative, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.ToNative).FromNative(IntPtr.Add(intPtr, BoxOverlapV2BGUCharacters_OutArray_Offset));
		NativeReflection.DestroyValue_InContainer(BoxOverlapV2BGUCharacters_OutArray_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BoxOverlapV2BGUCharacters_ReturnValue_Offset), 0, BoxOverlapV2BGUCharacters_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUSelectUtil:BoxOverlapBGUCharacters")]
	public unsafe static int BoxOverlapBGUCharacters(UObject WorldContextObject, FVector BoxPos, FVector BoxExtent, out List<ABGUCharacter> OutArray, ECollisionChannel QueryChannel = ECollisionChannel.ECC_Pawn)
	{
		if (!BoxOverlapBGUCharacters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSelectUtil:BoxOverlapBGUCharacters");
			OutArray = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BoxOverlapBGUCharacters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BoxOverlapBGUCharacters_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BoxOverlapBGUCharacters_WorldContextObject_Offset), 0, BoxOverlapBGUCharacters_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BoxOverlapBGUCharacters_BoxPos_Offset), 0, BoxOverlapBGUCharacters_BoxPos_PropertyAddress.Address, BoxPos);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BoxOverlapBGUCharacters_BoxExtent_Offset), 0, BoxOverlapBGUCharacters_BoxExtent_PropertyAddress.Address, BoxExtent);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, BoxOverlapBGUCharacters_QueryChannel_Offset), 0, BoxOverlapBGUCharacters_QueryChannel_PropertyAddress.Address, QueryChannel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BoxOverlapBGUCharacters_FunctionAddress, intPtr, BoxOverlapBGUCharacters_ParamsSize);
		OutArray = new TArrayCopyMarshaler<ABGUCharacter>(1, BoxOverlapBGUCharacters_OutArray_PropertyAddress, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.FromNative, CachedMarshalingDelegates<ABGUCharacter, UObjectMarshaler<ABGUCharacter>>.ToNative).FromNative(IntPtr.Add(intPtr, BoxOverlapBGUCharacters_OutArray_Offset));
		NativeReflection.DestroyValue_InContainer(BoxOverlapBGUCharacters_OutArray_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BoxOverlapBGUCharacters_ReturnValue_Offset), 0, BoxOverlapBGUCharacters_ReturnValue_PropertyAddress.Address);
	}

	static UBGUSelectUtil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUSelectUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUSelectUtil));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUSelectUtil");
		SphereOverlapBGUCharacters_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SphereOverlapBGUCharacters");
		SphereOverlapBGUCharacters_ParamsSize = NativeReflection.GetFunctionParamsSize(SphereOverlapBGUCharacters_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapBGUCharacters_WorldContext_PropertyAddress, SphereOverlapBGUCharacters_FunctionAddress, "WorldContext");
		SphereOverlapBGUCharacters_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapBGUCharacters_FunctionAddress, "WorldContext");
		SphereOverlapBGUCharacters_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapBGUCharacters_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapBGUCharacters_SphereCenter_PropertyAddress, SphereOverlapBGUCharacters_FunctionAddress, "SphereCenter");
		SphereOverlapBGUCharacters_SphereCenter_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapBGUCharacters_FunctionAddress, "SphereCenter");
		SphereOverlapBGUCharacters_SphereCenter_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapBGUCharacters_FunctionAddress, "SphereCenter", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapBGUCharacters_Radius_PropertyAddress, SphereOverlapBGUCharacters_FunctionAddress, "Radius");
		SphereOverlapBGUCharacters_Radius_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapBGUCharacters_FunctionAddress, "Radius");
		SphereOverlapBGUCharacters_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapBGUCharacters_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapBGUCharacters_OutArray_PropertyAddress, SphereOverlapBGUCharacters_FunctionAddress, "OutArray");
		SphereOverlapBGUCharacters_OutArray_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapBGUCharacters_FunctionAddress, "OutArray");
		SphereOverlapBGUCharacters_OutArray_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapBGUCharacters_FunctionAddress, "OutArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapBGUCharacters_QueryChannel_PropertyAddress, SphereOverlapBGUCharacters_FunctionAddress, "QueryChannel");
		SphereOverlapBGUCharacters_QueryChannel_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapBGUCharacters_FunctionAddress, "QueryChannel");
		SphereOverlapBGUCharacters_QueryChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapBGUCharacters_FunctionAddress, "QueryChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapBGUCharacters_ReturnValue_PropertyAddress, SphereOverlapBGUCharacters_FunctionAddress, "ReturnValue");
		SphereOverlapBGUCharacters_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapBGUCharacters_FunctionAddress, "ReturnValue");
		SphereOverlapBGUCharacters_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapBGUCharacters_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SphereOverlapBGUCharacters_IsValid = SphereOverlapBGUCharacters_FunctionAddress != IntPtr.Zero && SphereOverlapBGUCharacters_WorldContext_IsValid && SphereOverlapBGUCharacters_SphereCenter_IsValid && SphereOverlapBGUCharacters_Radius_IsValid && SphereOverlapBGUCharacters_OutArray_IsValid && SphereOverlapBGUCharacters_QueryChannel_IsValid && SphereOverlapBGUCharacters_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:SphereOverlapBGUCharacters", SphereOverlapBGUCharacters_IsValid);
		SelectBGUCharactersInRect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectBGUCharactersInRect");
		SelectBGUCharactersInRect_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectBGUCharactersInRect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInRect_WorldContextObject_PropertyAddress, SelectBGUCharactersInRect_FunctionAddress, "WorldContextObject");
		SelectBGUCharactersInRect_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInRect_FunctionAddress, "WorldContextObject");
		SelectBGUCharactersInRect_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInRect_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInRect_OutActors_PropertyAddress, SelectBGUCharactersInRect_FunctionAddress, "OutActors");
		SelectBGUCharactersInRect_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInRect_FunctionAddress, "OutActors");
		SelectBGUCharactersInRect_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInRect_FunctionAddress, "OutActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInRect_TargetBase_PropertyAddress, SelectBGUCharactersInRect_FunctionAddress, "TargetBase");
		SelectBGUCharactersInRect_TargetBase_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInRect_FunctionAddress, "TargetBase");
		SelectBGUCharactersInRect_TargetBase_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInRect_FunctionAddress, "TargetBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInRect_TargetCount_PropertyAddress, SelectBGUCharactersInRect_FunctionAddress, "TargetCount");
		SelectBGUCharactersInRect_TargetCount_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInRect_FunctionAddress, "TargetCount");
		SelectBGUCharactersInRect_TargetCount_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInRect_FunctionAddress, "TargetCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInRect_TargetFilter_PropertyAddress, SelectBGUCharactersInRect_FunctionAddress, "TargetFilter");
		SelectBGUCharactersInRect_TargetFilter_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInRect_FunctionAddress, "TargetFilter");
		SelectBGUCharactersInRect_TargetFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInRect_FunctionAddress, "TargetFilter", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInRect_Params_PropertyAddress, SelectBGUCharactersInRect_FunctionAddress, "Params");
		SelectBGUCharactersInRect_Params_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInRect_FunctionAddress, "Params");
		SelectBGUCharactersInRect_Params_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInRect_FunctionAddress, "Params", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInRect_ReturnValue_PropertyAddress, SelectBGUCharactersInRect_FunctionAddress, "ReturnValue");
		SelectBGUCharactersInRect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInRect_FunctionAddress, "ReturnValue");
		SelectBGUCharactersInRect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInRect_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SelectBGUCharactersInRect_IsValid = SelectBGUCharactersInRect_FunctionAddress != IntPtr.Zero && SelectBGUCharactersInRect_WorldContextObject_IsValid && SelectBGUCharactersInRect_OutActors_IsValid && SelectBGUCharactersInRect_TargetBase_IsValid && SelectBGUCharactersInRect_TargetCount_IsValid && SelectBGUCharactersInRect_TargetFilter_IsValid && SelectBGUCharactersInRect_Params_IsValid && SelectBGUCharactersInRect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:SelectBGUCharactersInRect", SelectBGUCharactersInRect_IsValid);
		SelectBGUCharactersInCylinder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectBGUCharactersInCylinder");
		SelectBGUCharactersInCylinder_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectBGUCharactersInCylinder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCylinder_WorldContextObject_PropertyAddress, SelectBGUCharactersInCylinder_FunctionAddress, "WorldContextObject");
		SelectBGUCharactersInCylinder_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCylinder_FunctionAddress, "WorldContextObject");
		SelectBGUCharactersInCylinder_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCylinder_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCylinder_OutActors_PropertyAddress, SelectBGUCharactersInCylinder_FunctionAddress, "OutActors");
		SelectBGUCharactersInCylinder_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCylinder_FunctionAddress, "OutActors");
		SelectBGUCharactersInCylinder_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCylinder_FunctionAddress, "OutActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCylinder_TargetBase_PropertyAddress, SelectBGUCharactersInCylinder_FunctionAddress, "TargetBase");
		SelectBGUCharactersInCylinder_TargetBase_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCylinder_FunctionAddress, "TargetBase");
		SelectBGUCharactersInCylinder_TargetBase_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCylinder_FunctionAddress, "TargetBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCylinder_TargetCount_PropertyAddress, SelectBGUCharactersInCylinder_FunctionAddress, "TargetCount");
		SelectBGUCharactersInCylinder_TargetCount_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCylinder_FunctionAddress, "TargetCount");
		SelectBGUCharactersInCylinder_TargetCount_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCylinder_FunctionAddress, "TargetCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCylinder_TargetFilter_PropertyAddress, SelectBGUCharactersInCylinder_FunctionAddress, "TargetFilter");
		SelectBGUCharactersInCylinder_TargetFilter_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCylinder_FunctionAddress, "TargetFilter");
		SelectBGUCharactersInCylinder_TargetFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCylinder_FunctionAddress, "TargetFilter", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCylinder_Params_PropertyAddress, SelectBGUCharactersInCylinder_FunctionAddress, "Params");
		SelectBGUCharactersInCylinder_Params_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCylinder_FunctionAddress, "Params");
		SelectBGUCharactersInCylinder_Params_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCylinder_FunctionAddress, "Params", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCylinder_ReturnValue_PropertyAddress, SelectBGUCharactersInCylinder_FunctionAddress, "ReturnValue");
		SelectBGUCharactersInCylinder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCylinder_FunctionAddress, "ReturnValue");
		SelectBGUCharactersInCylinder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCylinder_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SelectBGUCharactersInCylinder_IsValid = SelectBGUCharactersInCylinder_FunctionAddress != IntPtr.Zero && SelectBGUCharactersInCylinder_WorldContextObject_IsValid && SelectBGUCharactersInCylinder_OutActors_IsValid && SelectBGUCharactersInCylinder_TargetBase_IsValid && SelectBGUCharactersInCylinder_TargetCount_IsValid && SelectBGUCharactersInCylinder_TargetFilter_IsValid && SelectBGUCharactersInCylinder_Params_IsValid && SelectBGUCharactersInCylinder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:SelectBGUCharactersInCylinder", SelectBGUCharactersInCylinder_IsValid);
		SelectBGUCharactersInCircle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectBGUCharactersInCircle");
		SelectBGUCharactersInCircle_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectBGUCharactersInCircle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCircle_WorldContextObject_PropertyAddress, SelectBGUCharactersInCircle_FunctionAddress, "WorldContextObject");
		SelectBGUCharactersInCircle_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCircle_FunctionAddress, "WorldContextObject");
		SelectBGUCharactersInCircle_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCircle_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCircle_OutActors_PropertyAddress, SelectBGUCharactersInCircle_FunctionAddress, "OutActors");
		SelectBGUCharactersInCircle_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCircle_FunctionAddress, "OutActors");
		SelectBGUCharactersInCircle_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCircle_FunctionAddress, "OutActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCircle_TargetBase_PropertyAddress, SelectBGUCharactersInCircle_FunctionAddress, "TargetBase");
		SelectBGUCharactersInCircle_TargetBase_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCircle_FunctionAddress, "TargetBase");
		SelectBGUCharactersInCircle_TargetBase_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCircle_FunctionAddress, "TargetBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCircle_TargetCount_PropertyAddress, SelectBGUCharactersInCircle_FunctionAddress, "TargetCount");
		SelectBGUCharactersInCircle_TargetCount_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCircle_FunctionAddress, "TargetCount");
		SelectBGUCharactersInCircle_TargetCount_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCircle_FunctionAddress, "TargetCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCircle_TargetFilter_PropertyAddress, SelectBGUCharactersInCircle_FunctionAddress, "TargetFilter");
		SelectBGUCharactersInCircle_TargetFilter_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCircle_FunctionAddress, "TargetFilter");
		SelectBGUCharactersInCircle_TargetFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCircle_FunctionAddress, "TargetFilter", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCircle_Params_PropertyAddress, SelectBGUCharactersInCircle_FunctionAddress, "Params");
		SelectBGUCharactersInCircle_Params_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCircle_FunctionAddress, "Params");
		SelectBGUCharactersInCircle_Params_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCircle_FunctionAddress, "Params", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectBGUCharactersInCircle_ReturnValue_PropertyAddress, SelectBGUCharactersInCircle_FunctionAddress, "ReturnValue");
		SelectBGUCharactersInCircle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SelectBGUCharactersInCircle_FunctionAddress, "ReturnValue");
		SelectBGUCharactersInCircle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectBGUCharactersInCircle_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SelectBGUCharactersInCircle_IsValid = SelectBGUCharactersInCircle_FunctionAddress != IntPtr.Zero && SelectBGUCharactersInCircle_WorldContextObject_IsValid && SelectBGUCharactersInCircle_OutActors_IsValid && SelectBGUCharactersInCircle_TargetBase_IsValid && SelectBGUCharactersInCircle_TargetCount_IsValid && SelectBGUCharactersInCircle_TargetFilter_IsValid && SelectBGUCharactersInCircle_Params_IsValid && SelectBGUCharactersInCircle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:SelectBGUCharactersInCircle", SelectBGUCharactersInCircle_IsValid);
		MultiSphereTraceForObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MultiSphereTraceForObjects");
		MultiSphereTraceForObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(MultiSphereTraceForObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MultiSphereTraceForObjects_WorldContextObject_PropertyAddress, MultiSphereTraceForObjects_FunctionAddress, "WorldContextObject");
		MultiSphereTraceForObjects_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(MultiSphereTraceForObjects_FunctionAddress, "WorldContextObject");
		MultiSphereTraceForObjects_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(MultiSphereTraceForObjects_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiSphereTraceForObjects_StartTrace_PropertyAddress, MultiSphereTraceForObjects_FunctionAddress, "StartTrace");
		MultiSphereTraceForObjects_StartTrace_Offset = NativeReflectionCached.GetPropertyOffset(MultiSphereTraceForObjects_FunctionAddress, "StartTrace");
		MultiSphereTraceForObjects_StartTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(MultiSphereTraceForObjects_FunctionAddress, "StartTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiSphereTraceForObjects_EndTrace_PropertyAddress, MultiSphereTraceForObjects_FunctionAddress, "EndTrace");
		MultiSphereTraceForObjects_EndTrace_Offset = NativeReflectionCached.GetPropertyOffset(MultiSphereTraceForObjects_FunctionAddress, "EndTrace");
		MultiSphereTraceForObjects_EndTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(MultiSphereTraceForObjects_FunctionAddress, "EndTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiSphereTraceForObjects_Radius_PropertyAddress, MultiSphereTraceForObjects_FunctionAddress, "Radius");
		MultiSphereTraceForObjects_Radius_Offset = NativeReflectionCached.GetPropertyOffset(MultiSphereTraceForObjects_FunctionAddress, "Radius");
		MultiSphereTraceForObjects_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(MultiSphereTraceForObjects_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiSphereTraceForObjects_ObjectTypes_PropertyAddress, MultiSphereTraceForObjects_FunctionAddress, "ObjectTypes");
		MultiSphereTraceForObjects_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(MultiSphereTraceForObjects_FunctionAddress, "ObjectTypes");
		MultiSphereTraceForObjects_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(MultiSphereTraceForObjects_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiSphereTraceForObjects_bDebug_PropertyAddress, MultiSphereTraceForObjects_FunctionAddress, "bDebug");
		MultiSphereTraceForObjects_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(MultiSphereTraceForObjects_FunctionAddress, "bDebug");
		MultiSphereTraceForObjects_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(MultiSphereTraceForObjects_FunctionAddress, "bDebug", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiSphereTraceForObjects_HitResultList_PropertyAddress, MultiSphereTraceForObjects_FunctionAddress, "HitResultList");
		MultiSphereTraceForObjects_HitResultList_Offset = NativeReflectionCached.GetPropertyOffset(MultiSphereTraceForObjects_FunctionAddress, "HitResultList");
		MultiSphereTraceForObjects_HitResultList_IsValid = NativeReflectionCached.ValidatePropertyClass(MultiSphereTraceForObjects_FunctionAddress, "HitResultList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiSphereTraceForObjects_ReturnValue_PropertyAddress, MultiSphereTraceForObjects_FunctionAddress, "ReturnValue");
		MultiSphereTraceForObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MultiSphereTraceForObjects_FunctionAddress, "ReturnValue");
		MultiSphereTraceForObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MultiSphereTraceForObjects_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		MultiSphereTraceForObjects_IsValid = MultiSphereTraceForObjects_FunctionAddress != IntPtr.Zero && MultiSphereTraceForObjects_WorldContextObject_IsValid && MultiSphereTraceForObjects_StartTrace_IsValid && MultiSphereTraceForObjects_EndTrace_IsValid && MultiSphereTraceForObjects_Radius_IsValid && MultiSphereTraceForObjects_ObjectTypes_IsValid && MultiSphereTraceForObjects_bDebug_IsValid && MultiSphereTraceForObjects_HitResultList_IsValid && MultiSphereTraceForObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:MultiSphereTraceForObjects", MultiSphereTraceForObjects_IsValid);
		LineTraceSingleForObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LineTraceSingleForObjects");
		LineTraceSingleForObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(LineTraceSingleForObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_WorldContextObject_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "WorldContextObject");
		LineTraceSingleForObjects_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "WorldContextObject");
		LineTraceSingleForObjects_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_Start_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "Start");
		LineTraceSingleForObjects_Start_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "Start");
		LineTraceSingleForObjects_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_End_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "End");
		LineTraceSingleForObjects_End_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "End");
		LineTraceSingleForObjects_End_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_ObjectTypes_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "ObjectTypes");
		LineTraceSingleForObjects_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "ObjectTypes");
		LineTraceSingleForObjects_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_bTraceComplex_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "bTraceComplex");
		LineTraceSingleForObjects_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "bTraceComplex");
		LineTraceSingleForObjects_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_ActorsToIgnore_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "ActorsToIgnore");
		LineTraceSingleForObjects_ActorsToIgnore_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "ActorsToIgnore");
		LineTraceSingleForObjects_ActorsToIgnore_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "ActorsToIgnore", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_DrawDebugType_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "DrawDebugType");
		LineTraceSingleForObjects_DrawDebugType_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "DrawDebugType");
		LineTraceSingleForObjects_DrawDebugType_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "DrawDebugType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_OutHit_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "OutHit");
		LineTraceSingleForObjects_OutHit_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "OutHit");
		LineTraceSingleForObjects_OutHit_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "OutHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_bIgnoreSelf_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "bIgnoreSelf");
		LineTraceSingleForObjects_bIgnoreSelf_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "bIgnoreSelf");
		LineTraceSingleForObjects_bIgnoreSelf_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "bIgnoreSelf", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_TraceColor_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "TraceColor");
		LineTraceSingleForObjects_TraceColor_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "TraceColor");
		LineTraceSingleForObjects_TraceColor_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "TraceColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_TraceHitColor_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "TraceHitColor");
		LineTraceSingleForObjects_TraceHitColor_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "TraceHitColor");
		LineTraceSingleForObjects_TraceHitColor_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "TraceHitColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_DrawTime_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "DrawTime");
		LineTraceSingleForObjects_DrawTime_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "DrawTime");
		LineTraceSingleForObjects_DrawTime_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "DrawTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSingleForObjects_ReturnValue_PropertyAddress, LineTraceSingleForObjects_FunctionAddress, "ReturnValue");
		LineTraceSingleForObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSingleForObjects_FunctionAddress, "ReturnValue");
		LineTraceSingleForObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSingleForObjects_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LineTraceSingleForObjects_IsValid = LineTraceSingleForObjects_FunctionAddress != IntPtr.Zero && LineTraceSingleForObjects_WorldContextObject_IsValid && LineTraceSingleForObjects_Start_IsValid && LineTraceSingleForObjects_End_IsValid && LineTraceSingleForObjects_ObjectTypes_IsValid && LineTraceSingleForObjects_bTraceComplex_IsValid && LineTraceSingleForObjects_ActorsToIgnore_IsValid && LineTraceSingleForObjects_DrawDebugType_IsValid && LineTraceSingleForObjects_OutHit_IsValid && LineTraceSingleForObjects_bIgnoreSelf_IsValid && LineTraceSingleForObjects_TraceColor_IsValid && LineTraceSingleForObjects_TraceHitColor_IsValid && LineTraceSingleForObjects_DrawTime_IsValid && LineTraceSingleForObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:LineTraceSingleForObjects", LineTraceSingleForObjects_IsValid);
		LineTraceSimple_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LineTraceSimple");
		LineTraceSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(LineTraceSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSimple_WorldContextObject_PropertyAddress, LineTraceSimple_FunctionAddress, "WorldContextObject");
		LineTraceSimple_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSimple_FunctionAddress, "WorldContextObject");
		LineTraceSimple_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSimple_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSimple_StartTrace_PropertyAddress, LineTraceSimple_FunctionAddress, "StartTrace");
		LineTraceSimple_StartTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSimple_FunctionAddress, "StartTrace");
		LineTraceSimple_StartTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSimple_FunctionAddress, "StartTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSimple_EndTrace_PropertyAddress, LineTraceSimple_FunctionAddress, "EndTrace");
		LineTraceSimple_EndTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSimple_FunctionAddress, "EndTrace");
		LineTraceSimple_EndTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSimple_FunctionAddress, "EndTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSimple_QueryChnl_PropertyAddress, LineTraceSimple_FunctionAddress, "QueryChnl");
		LineTraceSimple_QueryChnl_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSimple_FunctionAddress, "QueryChnl");
		LineTraceSimple_QueryChnl_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSimple_FunctionAddress, "QueryChnl", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSimple_bDebug_PropertyAddress, LineTraceSimple_FunctionAddress, "bDebug");
		LineTraceSimple_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSimple_FunctionAddress, "bDebug");
		LineTraceSimple_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSimple_FunctionAddress, "bDebug", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSimple_HitResult_PropertyAddress, LineTraceSimple_FunctionAddress, "HitResult");
		LineTraceSimple_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSimple_FunctionAddress, "HitResult");
		LineTraceSimple_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSimple_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSimple_Ingnores_PropertyAddress, LineTraceSimple_FunctionAddress, "Ingnores");
		LineTraceSimple_Ingnores_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSimple_FunctionAddress, "Ingnores");
		LineTraceSimple_Ingnores_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSimple_FunctionAddress, "Ingnores", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSimple_bTraceComplex_PropertyAddress, LineTraceSimple_FunctionAddress, "bTraceComplex");
		LineTraceSimple_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSimple_FunctionAddress, "bTraceComplex");
		LineTraceSimple_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSimple_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceSimple_ReturnValue_PropertyAddress, LineTraceSimple_FunctionAddress, "ReturnValue");
		LineTraceSimple_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceSimple_FunctionAddress, "ReturnValue");
		LineTraceSimple_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceSimple_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		LineTraceSimple_IsValid = LineTraceSimple_FunctionAddress != IntPtr.Zero && LineTraceSimple_WorldContextObject_IsValid && LineTraceSimple_StartTrace_IsValid && LineTraceSimple_EndTrace_IsValid && LineTraceSimple_QueryChnl_IsValid && LineTraceSimple_bDebug_IsValid && LineTraceSimple_HitResult_IsValid && LineTraceSimple_Ingnores_IsValid && LineTraceSimple_bTraceComplex_IsValid && LineTraceSimple_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:LineTraceSimple", LineTraceSimple_IsValid);
		LineTraceOnlyCheck_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LineTraceOnlyCheck");
		LineTraceOnlyCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(LineTraceOnlyCheck_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LineTraceOnlyCheck_WorldContextObject_PropertyAddress, LineTraceOnlyCheck_FunctionAddress, "WorldContextObject");
		LineTraceOnlyCheck_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceOnlyCheck_FunctionAddress, "WorldContextObject");
		LineTraceOnlyCheck_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceOnlyCheck_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceOnlyCheck_StartTrace_PropertyAddress, LineTraceOnlyCheck_FunctionAddress, "StartTrace");
		LineTraceOnlyCheck_StartTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceOnlyCheck_FunctionAddress, "StartTrace");
		LineTraceOnlyCheck_StartTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceOnlyCheck_FunctionAddress, "StartTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceOnlyCheck_EndTrace_PropertyAddress, LineTraceOnlyCheck_FunctionAddress, "EndTrace");
		LineTraceOnlyCheck_EndTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceOnlyCheck_FunctionAddress, "EndTrace");
		LineTraceOnlyCheck_EndTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceOnlyCheck_FunctionAddress, "EndTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceOnlyCheck_QueryChnl_PropertyAddress, LineTraceOnlyCheck_FunctionAddress, "QueryChnl");
		LineTraceOnlyCheck_QueryChnl_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceOnlyCheck_FunctionAddress, "QueryChnl");
		LineTraceOnlyCheck_QueryChnl_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceOnlyCheck_FunctionAddress, "QueryChnl", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceOnlyCheck_bDebug_PropertyAddress, LineTraceOnlyCheck_FunctionAddress, "bDebug");
		LineTraceOnlyCheck_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceOnlyCheck_FunctionAddress, "bDebug");
		LineTraceOnlyCheck_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceOnlyCheck_FunctionAddress, "bDebug", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceOnlyCheck_HitResult_PropertyAddress, LineTraceOnlyCheck_FunctionAddress, "HitResult");
		LineTraceOnlyCheck_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceOnlyCheck_FunctionAddress, "HitResult");
		LineTraceOnlyCheck_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceOnlyCheck_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceOnlyCheck_Ingnores_PropertyAddress, LineTraceOnlyCheck_FunctionAddress, "Ingnores");
		LineTraceOnlyCheck_Ingnores_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceOnlyCheck_FunctionAddress, "Ingnores");
		LineTraceOnlyCheck_Ingnores_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceOnlyCheck_FunctionAddress, "Ingnores", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceOnlyCheck_bTraceComplex_PropertyAddress, LineTraceOnlyCheck_FunctionAddress, "bTraceComplex");
		LineTraceOnlyCheck_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceOnlyCheck_FunctionAddress, "bTraceComplex");
		LineTraceOnlyCheck_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceOnlyCheck_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceOnlyCheck_ReturnValue_PropertyAddress, LineTraceOnlyCheck_FunctionAddress, "ReturnValue");
		LineTraceOnlyCheck_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceOnlyCheck_FunctionAddress, "ReturnValue");
		LineTraceOnlyCheck_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceOnlyCheck_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		LineTraceOnlyCheck_IsValid = LineTraceOnlyCheck_FunctionAddress != IntPtr.Zero && LineTraceOnlyCheck_WorldContextObject_IsValid && LineTraceOnlyCheck_StartTrace_IsValid && LineTraceOnlyCheck_EndTrace_IsValid && LineTraceOnlyCheck_QueryChnl_IsValid && LineTraceOnlyCheck_bDebug_IsValid && LineTraceOnlyCheck_HitResult_IsValid && LineTraceOnlyCheck_Ingnores_IsValid && LineTraceOnlyCheck_bTraceComplex_IsValid && LineTraceOnlyCheck_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:LineTraceOnlyCheck", LineTraceOnlyCheck_IsValid);
		LineTraceMultiByObjType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LineTraceMultiByObjType");
		LineTraceMultiByObjType_ParamsSize = NativeReflection.GetFunctionParamsSize(LineTraceMultiByObjType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LineTraceMultiByObjType_WorldContextObject_PropertyAddress, LineTraceMultiByObjType_FunctionAddress, "WorldContextObject");
		LineTraceMultiByObjType_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceMultiByObjType_FunctionAddress, "WorldContextObject");
		LineTraceMultiByObjType_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceMultiByObjType_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceMultiByObjType_StartTrace_PropertyAddress, LineTraceMultiByObjType_FunctionAddress, "StartTrace");
		LineTraceMultiByObjType_StartTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceMultiByObjType_FunctionAddress, "StartTrace");
		LineTraceMultiByObjType_StartTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceMultiByObjType_FunctionAddress, "StartTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceMultiByObjType_EndTrace_PropertyAddress, LineTraceMultiByObjType_FunctionAddress, "EndTrace");
		LineTraceMultiByObjType_EndTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceMultiByObjType_FunctionAddress, "EndTrace");
		LineTraceMultiByObjType_EndTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceMultiByObjType_FunctionAddress, "EndTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceMultiByObjType_ObjectTypes_PropertyAddress, LineTraceMultiByObjType_FunctionAddress, "ObjectTypes");
		LineTraceMultiByObjType_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceMultiByObjType_FunctionAddress, "ObjectTypes");
		LineTraceMultiByObjType_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceMultiByObjType_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceMultiByObjType_bDebug_PropertyAddress, LineTraceMultiByObjType_FunctionAddress, "bDebug");
		LineTraceMultiByObjType_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceMultiByObjType_FunctionAddress, "bDebug");
		LineTraceMultiByObjType_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceMultiByObjType_FunctionAddress, "bDebug", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceMultiByObjType_HitResultList_PropertyAddress, LineTraceMultiByObjType_FunctionAddress, "HitResultList");
		LineTraceMultiByObjType_HitResultList_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceMultiByObjType_FunctionAddress, "HitResultList");
		LineTraceMultiByObjType_HitResultList_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceMultiByObjType_FunctionAddress, "HitResultList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceMultiByObjType_ReturnValue_PropertyAddress, LineTraceMultiByObjType_FunctionAddress, "ReturnValue");
		LineTraceMultiByObjType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceMultiByObjType_FunctionAddress, "ReturnValue");
		LineTraceMultiByObjType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceMultiByObjType_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		LineTraceMultiByObjType_IsValid = LineTraceMultiByObjType_FunctionAddress != IntPtr.Zero && LineTraceMultiByObjType_WorldContextObject_IsValid && LineTraceMultiByObjType_StartTrace_IsValid && LineTraceMultiByObjType_EndTrace_IsValid && LineTraceMultiByObjType_ObjectTypes_IsValid && LineTraceMultiByObjType_bDebug_IsValid && LineTraceMultiByObjType_HitResultList_IsValid && LineTraceMultiByObjType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:LineTraceMultiByObjType", LineTraceMultiByObjType_IsValid);
		LineTraceForObjectsTypeSimple_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LineTraceForObjectsTypeSimple");
		LineTraceForObjectsTypeSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(LineTraceForObjectsTypeSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjectsTypeSimple_WorldContextObject_PropertyAddress, LineTraceForObjectsTypeSimple_FunctionAddress, "WorldContextObject");
		LineTraceForObjectsTypeSimple_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjectsTypeSimple_FunctionAddress, "WorldContextObject");
		LineTraceForObjectsTypeSimple_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjectsTypeSimple_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjectsTypeSimple_StartTrace_PropertyAddress, LineTraceForObjectsTypeSimple_FunctionAddress, "StartTrace");
		LineTraceForObjectsTypeSimple_StartTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjectsTypeSimple_FunctionAddress, "StartTrace");
		LineTraceForObjectsTypeSimple_StartTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjectsTypeSimple_FunctionAddress, "StartTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjectsTypeSimple_EndTrace_PropertyAddress, LineTraceForObjectsTypeSimple_FunctionAddress, "EndTrace");
		LineTraceForObjectsTypeSimple_EndTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjectsTypeSimple_FunctionAddress, "EndTrace");
		LineTraceForObjectsTypeSimple_EndTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjectsTypeSimple_FunctionAddress, "EndTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjectsTypeSimple_ObjectTypes_PropertyAddress, LineTraceForObjectsTypeSimple_FunctionAddress, "ObjectTypes");
		LineTraceForObjectsTypeSimple_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjectsTypeSimple_FunctionAddress, "ObjectTypes");
		LineTraceForObjectsTypeSimple_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjectsTypeSimple_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjectsTypeSimple_bDebug_PropertyAddress, LineTraceForObjectsTypeSimple_FunctionAddress, "bDebug");
		LineTraceForObjectsTypeSimple_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjectsTypeSimple_FunctionAddress, "bDebug");
		LineTraceForObjectsTypeSimple_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjectsTypeSimple_FunctionAddress, "bDebug", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjectsTypeSimple_HitResult_PropertyAddress, LineTraceForObjectsTypeSimple_FunctionAddress, "HitResult");
		LineTraceForObjectsTypeSimple_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjectsTypeSimple_FunctionAddress, "HitResult");
		LineTraceForObjectsTypeSimple_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjectsTypeSimple_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjectsTypeSimple_bTraceComplex_PropertyAddress, LineTraceForObjectsTypeSimple_FunctionAddress, "bTraceComplex");
		LineTraceForObjectsTypeSimple_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjectsTypeSimple_FunctionAddress, "bTraceComplex");
		LineTraceForObjectsTypeSimple_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjectsTypeSimple_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjectsTypeSimple_ReturnValue_PropertyAddress, LineTraceForObjectsTypeSimple_FunctionAddress, "ReturnValue");
		LineTraceForObjectsTypeSimple_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjectsTypeSimple_FunctionAddress, "ReturnValue");
		LineTraceForObjectsTypeSimple_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjectsTypeSimple_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		LineTraceForObjectsTypeSimple_IsValid = LineTraceForObjectsTypeSimple_FunctionAddress != IntPtr.Zero && LineTraceForObjectsTypeSimple_WorldContextObject_IsValid && LineTraceForObjectsTypeSimple_StartTrace_IsValid && LineTraceForObjectsTypeSimple_EndTrace_IsValid && LineTraceForObjectsTypeSimple_ObjectTypes_IsValid && LineTraceForObjectsTypeSimple_bDebug_IsValid && LineTraceForObjectsTypeSimple_HitResult_IsValid && LineTraceForObjectsTypeSimple_bTraceComplex_IsValid && LineTraceForObjectsTypeSimple_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:LineTraceForObjectsTypeSimple", LineTraceForObjectsTypeSimple_IsValid);
		LineTraceForObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LineTraceForObjects");
		LineTraceForObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(LineTraceForObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjects_WorldContextObject_PropertyAddress, LineTraceForObjects_FunctionAddress, "WorldContextObject");
		LineTraceForObjects_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjects_FunctionAddress, "WorldContextObject");
		LineTraceForObjects_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjects_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjects_StartTrace_PropertyAddress, LineTraceForObjects_FunctionAddress, "StartTrace");
		LineTraceForObjects_StartTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjects_FunctionAddress, "StartTrace");
		LineTraceForObjects_StartTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjects_FunctionAddress, "StartTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjects_EndTrace_PropertyAddress, LineTraceForObjects_FunctionAddress, "EndTrace");
		LineTraceForObjects_EndTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjects_FunctionAddress, "EndTrace");
		LineTraceForObjects_EndTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjects_FunctionAddress, "EndTrace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjects_ObjectTypes_PropertyAddress, LineTraceForObjects_FunctionAddress, "ObjectTypes");
		LineTraceForObjects_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjects_FunctionAddress, "ObjectTypes");
		LineTraceForObjects_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjects_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjects_bDebug_PropertyAddress, LineTraceForObjects_FunctionAddress, "bDebug");
		LineTraceForObjects_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjects_FunctionAddress, "bDebug");
		LineTraceForObjects_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjects_FunctionAddress, "bDebug", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjects_HitResult_PropertyAddress, LineTraceForObjects_FunctionAddress, "HitResult");
		LineTraceForObjects_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjects_FunctionAddress, "HitResult");
		LineTraceForObjects_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjects_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceForObjects_ReturnValue_PropertyAddress, LineTraceForObjects_FunctionAddress, "ReturnValue");
		LineTraceForObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceForObjects_FunctionAddress, "ReturnValue");
		LineTraceForObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceForObjects_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		LineTraceForObjects_IsValid = LineTraceForObjects_FunctionAddress != IntPtr.Zero && LineTraceForObjects_WorldContextObject_IsValid && LineTraceForObjects_StartTrace_IsValid && LineTraceForObjects_EndTrace_IsValid && LineTraceForObjects_ObjectTypes_IsValid && LineTraceForObjects_bDebug_IsValid && LineTraceForObjects_HitResult_IsValid && LineTraceForObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:LineTraceForObjects", LineTraceForObjects_IsValid);
		GetHitUnderCursor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHitUnderCursor");
		GetHitUnderCursor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHitUnderCursor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHitUnderCursor_PlayerCtrl_PropertyAddress, GetHitUnderCursor_FunctionAddress, "PlayerCtrl");
		GetHitUnderCursor_PlayerCtrl_Offset = NativeReflectionCached.GetPropertyOffset(GetHitUnderCursor_FunctionAddress, "PlayerCtrl");
		GetHitUnderCursor_PlayerCtrl_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitUnderCursor_FunctionAddress, "PlayerCtrl", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitUnderCursor_QueryChnl_PropertyAddress, GetHitUnderCursor_FunctionAddress, "QueryChnl");
		GetHitUnderCursor_QueryChnl_Offset = NativeReflectionCached.GetPropertyOffset(GetHitUnderCursor_FunctionAddress, "QueryChnl");
		GetHitUnderCursor_QueryChnl_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitUnderCursor_FunctionAddress, "QueryChnl", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitUnderCursor_bTraceComplex_PropertyAddress, GetHitUnderCursor_FunctionAddress, "bTraceComplex");
		GetHitUnderCursor_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(GetHitUnderCursor_FunctionAddress, "bTraceComplex");
		GetHitUnderCursor_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitUnderCursor_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitUnderCursor_HitResult_PropertyAddress, GetHitUnderCursor_FunctionAddress, "HitResult");
		GetHitUnderCursor_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(GetHitUnderCursor_FunctionAddress, "HitResult");
		GetHitUnderCursor_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitUnderCursor_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitUnderCursor_ReturnValue_PropertyAddress, GetHitUnderCursor_FunctionAddress, "ReturnValue");
		GetHitUnderCursor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHitUnderCursor_FunctionAddress, "ReturnValue");
		GetHitUnderCursor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitUnderCursor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHitUnderCursor_IsValid = GetHitUnderCursor_FunctionAddress != IntPtr.Zero && GetHitUnderCursor_PlayerCtrl_IsValid && GetHitUnderCursor_QueryChnl_IsValid && GetHitUnderCursor_bTraceComplex_IsValid && GetHitUnderCursor_HitResult_IsValid && GetHitUnderCursor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:GetHitUnderCursor", GetHitUnderCursor_IsValid);
		BoxOverlapV2BGUCharacters_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BoxOverlapV2BGUCharacters");
		BoxOverlapV2BGUCharacters_ParamsSize = NativeReflection.GetFunctionParamsSize(BoxOverlapV2BGUCharacters_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapV2BGUCharacters_WorldContextObject_PropertyAddress, BoxOverlapV2BGUCharacters_FunctionAddress, "WorldContextObject");
		BoxOverlapV2BGUCharacters_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapV2BGUCharacters_FunctionAddress, "WorldContextObject");
		BoxOverlapV2BGUCharacters_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapV2BGUCharacters_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapV2BGUCharacters_BoxPos_PropertyAddress, BoxOverlapV2BGUCharacters_FunctionAddress, "BoxPos");
		BoxOverlapV2BGUCharacters_BoxPos_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapV2BGUCharacters_FunctionAddress, "BoxPos");
		BoxOverlapV2BGUCharacters_BoxPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapV2BGUCharacters_FunctionAddress, "BoxPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapV2BGUCharacters_Rot_PropertyAddress, BoxOverlapV2BGUCharacters_FunctionAddress, "Rot");
		BoxOverlapV2BGUCharacters_Rot_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapV2BGUCharacters_FunctionAddress, "Rot");
		BoxOverlapV2BGUCharacters_Rot_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapV2BGUCharacters_FunctionAddress, "Rot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapV2BGUCharacters_BoxExtent_PropertyAddress, BoxOverlapV2BGUCharacters_FunctionAddress, "BoxExtent");
		BoxOverlapV2BGUCharacters_BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapV2BGUCharacters_FunctionAddress, "BoxExtent");
		BoxOverlapV2BGUCharacters_BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapV2BGUCharacters_FunctionAddress, "BoxExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapV2BGUCharacters_OutArray_PropertyAddress, BoxOverlapV2BGUCharacters_FunctionAddress, "OutArray");
		BoxOverlapV2BGUCharacters_OutArray_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapV2BGUCharacters_FunctionAddress, "OutArray");
		BoxOverlapV2BGUCharacters_OutArray_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapV2BGUCharacters_FunctionAddress, "OutArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapV2BGUCharacters_ReturnValue_PropertyAddress, BoxOverlapV2BGUCharacters_FunctionAddress, "ReturnValue");
		BoxOverlapV2BGUCharacters_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapV2BGUCharacters_FunctionAddress, "ReturnValue");
		BoxOverlapV2BGUCharacters_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapV2BGUCharacters_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BoxOverlapV2BGUCharacters_IsValid = BoxOverlapV2BGUCharacters_FunctionAddress != IntPtr.Zero && BoxOverlapV2BGUCharacters_WorldContextObject_IsValid && BoxOverlapV2BGUCharacters_BoxPos_IsValid && BoxOverlapV2BGUCharacters_Rot_IsValid && BoxOverlapV2BGUCharacters_BoxExtent_IsValid && BoxOverlapV2BGUCharacters_OutArray_IsValid && BoxOverlapV2BGUCharacters_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:BoxOverlapV2BGUCharacters", BoxOverlapV2BGUCharacters_IsValid);
		BoxOverlapBGUCharacters_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BoxOverlapBGUCharacters");
		BoxOverlapBGUCharacters_ParamsSize = NativeReflection.GetFunctionParamsSize(BoxOverlapBGUCharacters_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapBGUCharacters_WorldContextObject_PropertyAddress, BoxOverlapBGUCharacters_FunctionAddress, "WorldContextObject");
		BoxOverlapBGUCharacters_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapBGUCharacters_FunctionAddress, "WorldContextObject");
		BoxOverlapBGUCharacters_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapBGUCharacters_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapBGUCharacters_BoxPos_PropertyAddress, BoxOverlapBGUCharacters_FunctionAddress, "BoxPos");
		BoxOverlapBGUCharacters_BoxPos_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapBGUCharacters_FunctionAddress, "BoxPos");
		BoxOverlapBGUCharacters_BoxPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapBGUCharacters_FunctionAddress, "BoxPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapBGUCharacters_BoxExtent_PropertyAddress, BoxOverlapBGUCharacters_FunctionAddress, "BoxExtent");
		BoxOverlapBGUCharacters_BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapBGUCharacters_FunctionAddress, "BoxExtent");
		BoxOverlapBGUCharacters_BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapBGUCharacters_FunctionAddress, "BoxExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapBGUCharacters_OutArray_PropertyAddress, BoxOverlapBGUCharacters_FunctionAddress, "OutArray");
		BoxOverlapBGUCharacters_OutArray_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapBGUCharacters_FunctionAddress, "OutArray");
		BoxOverlapBGUCharacters_OutArray_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapBGUCharacters_FunctionAddress, "OutArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapBGUCharacters_QueryChannel_PropertyAddress, BoxOverlapBGUCharacters_FunctionAddress, "QueryChannel");
		BoxOverlapBGUCharacters_QueryChannel_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapBGUCharacters_FunctionAddress, "QueryChannel");
		BoxOverlapBGUCharacters_QueryChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapBGUCharacters_FunctionAddress, "QueryChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapBGUCharacters_ReturnValue_PropertyAddress, BoxOverlapBGUCharacters_FunctionAddress, "ReturnValue");
		BoxOverlapBGUCharacters_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapBGUCharacters_FunctionAddress, "ReturnValue");
		BoxOverlapBGUCharacters_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapBGUCharacters_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BoxOverlapBGUCharacters_IsValid = BoxOverlapBGUCharacters_FunctionAddress != IntPtr.Zero && BoxOverlapBGUCharacters_WorldContextObject_IsValid && BoxOverlapBGUCharacters_BoxPos_IsValid && BoxOverlapBGUCharacters_BoxExtent_IsValid && BoxOverlapBGUCharacters_OutArray_IsValid && BoxOverlapBGUCharacters_QueryChannel_IsValid && BoxOverlapBGUCharacters_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSelectUtil:BoxOverlapBGUCharacters", BoxOverlapBGUCharacters_IsValid);
	}
}
