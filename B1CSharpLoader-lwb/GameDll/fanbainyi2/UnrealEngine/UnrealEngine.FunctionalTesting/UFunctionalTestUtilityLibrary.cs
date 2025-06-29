using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FunctionalTesting.FunctionalTestUtilityLibrary", "FunctionalTesting", UnrealModuleType.Engine)]
public class UFunctionalTestUtilityLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TraceChannelTestUtil_IsValid;

	private static IntPtr TraceChannelTestUtil_FunctionAddress;

	private static int TraceChannelTestUtil_ParamsSize;

	private static bool TraceChannelTestUtil_WorldContextObject_IsValid;

	private static FFieldAddress TraceChannelTestUtil_WorldContextObject_PropertyAddress;

	private static int TraceChannelTestUtil_WorldContextObject_Offset;

	private static bool TraceChannelTestUtil_BatchOptions_IsValid;

	private static FFieldAddress TraceChannelTestUtil_BatchOptions_PropertyAddress;

	private static int TraceChannelTestUtil_BatchOptions_Offset;

	private static bool TraceChannelTestUtil_Start_IsValid;

	private static FFieldAddress TraceChannelTestUtil_Start_PropertyAddress;

	private static int TraceChannelTestUtil_Start_Offset;

	private static bool TraceChannelTestUtil_End_IsValid;

	private static FFieldAddress TraceChannelTestUtil_End_PropertyAddress;

	private static int TraceChannelTestUtil_End_Offset;

	private static bool TraceChannelTestUtil_SphereCapsuleRadius_IsValid;

	private static FFieldAddress TraceChannelTestUtil_SphereCapsuleRadius_PropertyAddress;

	private static int TraceChannelTestUtil_SphereCapsuleRadius_Offset;

	private static bool TraceChannelTestUtil_CapsuleHalfHeight_IsValid;

	private static FFieldAddress TraceChannelTestUtil_CapsuleHalfHeight_PropertyAddress;

	private static int TraceChannelTestUtil_CapsuleHalfHeight_Offset;

	private static bool TraceChannelTestUtil_BoxHalfSize_IsValid;

	private static FFieldAddress TraceChannelTestUtil_BoxHalfSize_PropertyAddress;

	private static int TraceChannelTestUtil_BoxHalfSize_Offset;

	private static bool TraceChannelTestUtil_Orientation_IsValid;

	private static FFieldAddress TraceChannelTestUtil_Orientation_PropertyAddress;

	private static int TraceChannelTestUtil_Orientation_Offset;

	private static bool TraceChannelTestUtil_TraceChannel_IsValid;

	private static FFieldAddress TraceChannelTestUtil_TraceChannel_PropertyAddress;

	private static int TraceChannelTestUtil_TraceChannel_Offset;

	private static bool TraceChannelTestUtil_ObjectTypes_IsValid;

	private static FFieldAddress TraceChannelTestUtil_ObjectTypes_PropertyAddress;

	private static int TraceChannelTestUtil_ObjectTypes_Offset;

	private static bool TraceChannelTestUtil_ProfileName_IsValid;

	private static FFieldAddress TraceChannelTestUtil_ProfileName_PropertyAddress;

	private static int TraceChannelTestUtil_ProfileName_Offset;

	private static bool TraceChannelTestUtil_bTraceComplex_IsValid;

	private static FFieldAddress TraceChannelTestUtil_bTraceComplex_PropertyAddress;

	private static int TraceChannelTestUtil_bTraceComplex_Offset;

	private static bool TraceChannelTestUtil_ActorsToIgnore_IsValid;

	private static FFieldAddress TraceChannelTestUtil_ActorsToIgnore_PropertyAddress;

	private static int TraceChannelTestUtil_ActorsToIgnore_Offset;

	private static bool TraceChannelTestUtil_bIgnoreSelf_IsValid;

	private static FFieldAddress TraceChannelTestUtil_bIgnoreSelf_PropertyAddress;

	private static int TraceChannelTestUtil_bIgnoreSelf_Offset;

	private static bool TraceChannelTestUtil_DrawDebugType_IsValid;

	private static FFieldAddress TraceChannelTestUtil_DrawDebugType_PropertyAddress;

	private static int TraceChannelTestUtil_DrawDebugType_Offset;

	private static bool TraceChannelTestUtil_TraceColor_IsValid;

	private static FFieldAddress TraceChannelTestUtil_TraceColor_PropertyAddress;

	private static int TraceChannelTestUtil_TraceColor_Offset;

	private static bool TraceChannelTestUtil_TraceHitColor_IsValid;

	private static FFieldAddress TraceChannelTestUtil_TraceHitColor_PropertyAddress;

	private static int TraceChannelTestUtil_TraceHitColor_Offset;

	private static bool TraceChannelTestUtil_DrawTime_IsValid;

	private static FFieldAddress TraceChannelTestUtil_DrawTime_PropertyAddress;

	private static int TraceChannelTestUtil_DrawTime_Offset;

	private static bool TraceChannelTestUtil_ReturnValue_IsValid;

	private static FFieldAddress TraceChannelTestUtil_ReturnValue_PropertyAddress;

	private static int TraceChannelTestUtil_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTestUtilityLibrary:TraceChannelTestUtil")]
	public unsafe static UTraceQueryTestResults TraceChannelTestUtil(UObject WorldContextObject, FTraceChannelTestBatchOptions BatchOptions, FVector Start, FVector End, float SphereCapsuleRadius, float CapsuleHalfHeight, FVector BoxHalfSize, FRotator Orientation, ETraceTypeQuery TraceChannel, List<EObjectTypeQuery> ObjectTypes, FName ProfileName, bool bTraceComplex, List<AActor> ActorsToIgnore, bool bIgnoreSelf, EDrawDebugTrace DrawDebugType, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		if (!TraceChannelTestUtil_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTestUtilityLibrary:TraceChannelTestUtil");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TraceChannelTestUtil_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TraceChannelTestUtil_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_WorldContextObject_Offset), 0, TraceChannelTestUtil_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(TraceChannelTestUtil_BatchOptions_PropertyAddress.Address, intPtr);
		FTraceChannelTestBatchOptions.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_BatchOptions_Offset), 0, TraceChannelTestUtil_BatchOptions_PropertyAddress.Address, BatchOptions);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_Start_Offset), 0, TraceChannelTestUtil_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_End_Offset), 0, TraceChannelTestUtil_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_SphereCapsuleRadius_Offset), 0, TraceChannelTestUtil_SphereCapsuleRadius_PropertyAddress.Address, SphereCapsuleRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_CapsuleHalfHeight_Offset), 0, TraceChannelTestUtil_CapsuleHalfHeight_PropertyAddress.Address, CapsuleHalfHeight);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_BoxHalfSize_Offset), 0, TraceChannelTestUtil_BoxHalfSize_PropertyAddress.Address, BoxHalfSize);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_Orientation_Offset), 0, TraceChannelTestUtil_Orientation_PropertyAddress.Address, Orientation);
		EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_TraceChannel_Offset), 0, TraceChannelTestUtil_TraceChannel_PropertyAddress.Address, TraceChannel);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, TraceChannelTestUtil_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_ObjectTypes_Offset), ObjectTypes);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_ProfileName_Offset), 0, TraceChannelTestUtil_ProfileName_PropertyAddress.Address, ProfileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_bTraceComplex_Offset), 0, TraceChannelTestUtil_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		new TArrayCopyMarshaler<AActor>(1, TraceChannelTestUtil_ActorsToIgnore_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_ActorsToIgnore_Offset), ActorsToIgnore);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_bIgnoreSelf_Offset), 0, TraceChannelTestUtil_bIgnoreSelf_PropertyAddress.Address, bIgnoreSelf);
		EnumMarshaler<EDrawDebugTrace>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_DrawDebugType_Offset), 0, TraceChannelTestUtil_DrawDebugType_PropertyAddress.Address, DrawDebugType);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_TraceColor_Offset), 0, TraceChannelTestUtil_TraceColor_PropertyAddress.Address, TraceColor);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_TraceHitColor_Offset), 0, TraceChannelTestUtil_TraceHitColor_PropertyAddress.Address, TraceHitColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TraceChannelTestUtil_DrawTime_Offset), 0, TraceChannelTestUtil_DrawTime_PropertyAddress.Address, DrawTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TraceChannelTestUtil_FunctionAddress, intPtr, TraceChannelTestUtil_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TraceChannelTestUtil_ObjectTypes_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(TraceChannelTestUtil_ActorsToIgnore_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UTraceQueryTestResults>.FromNative(IntPtr.Add(intPtr, TraceChannelTestUtil_ReturnValue_Offset), 0, TraceChannelTestUtil_ReturnValue_PropertyAddress.Address);
	}

	static UFunctionalTestUtilityLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFunctionalTestUtilityLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFunctionalTestUtilityLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FunctionalTesting.FunctionalTestUtilityLibrary");
		TraceChannelTestUtil_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TraceChannelTestUtil");
		TraceChannelTestUtil_ParamsSize = NativeReflection.GetFunctionParamsSize(TraceChannelTestUtil_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_WorldContextObject_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "WorldContextObject");
		TraceChannelTestUtil_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "WorldContextObject");
		TraceChannelTestUtil_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_BatchOptions_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "BatchOptions");
		TraceChannelTestUtil_BatchOptions_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "BatchOptions");
		TraceChannelTestUtil_BatchOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "BatchOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_Start_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "Start");
		TraceChannelTestUtil_Start_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "Start");
		TraceChannelTestUtil_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_End_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "End");
		TraceChannelTestUtil_End_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "End");
		TraceChannelTestUtil_End_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_SphereCapsuleRadius_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "SphereCapsuleRadius");
		TraceChannelTestUtil_SphereCapsuleRadius_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "SphereCapsuleRadius");
		TraceChannelTestUtil_SphereCapsuleRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "SphereCapsuleRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_CapsuleHalfHeight_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "CapsuleHalfHeight");
		TraceChannelTestUtil_CapsuleHalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "CapsuleHalfHeight");
		TraceChannelTestUtil_CapsuleHalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "CapsuleHalfHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_BoxHalfSize_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "BoxHalfSize");
		TraceChannelTestUtil_BoxHalfSize_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "BoxHalfSize");
		TraceChannelTestUtil_BoxHalfSize_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "BoxHalfSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_Orientation_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "Orientation");
		TraceChannelTestUtil_Orientation_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "Orientation");
		TraceChannelTestUtil_Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "Orientation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_TraceChannel_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "TraceChannel");
		TraceChannelTestUtil_TraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "TraceChannel");
		TraceChannelTestUtil_TraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "TraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_ObjectTypes_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "ObjectTypes");
		TraceChannelTestUtil_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "ObjectTypes");
		TraceChannelTestUtil_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_ProfileName_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "ProfileName");
		TraceChannelTestUtil_ProfileName_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "ProfileName");
		TraceChannelTestUtil_ProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "ProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_bTraceComplex_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "bTraceComplex");
		TraceChannelTestUtil_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "bTraceComplex");
		TraceChannelTestUtil_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_ActorsToIgnore_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "ActorsToIgnore");
		TraceChannelTestUtil_ActorsToIgnore_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "ActorsToIgnore");
		TraceChannelTestUtil_ActorsToIgnore_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "ActorsToIgnore", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_bIgnoreSelf_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "bIgnoreSelf");
		TraceChannelTestUtil_bIgnoreSelf_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "bIgnoreSelf");
		TraceChannelTestUtil_bIgnoreSelf_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "bIgnoreSelf", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_DrawDebugType_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "DrawDebugType");
		TraceChannelTestUtil_DrawDebugType_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "DrawDebugType");
		TraceChannelTestUtil_DrawDebugType_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "DrawDebugType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_TraceColor_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "TraceColor");
		TraceChannelTestUtil_TraceColor_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "TraceColor");
		TraceChannelTestUtil_TraceColor_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "TraceColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_TraceHitColor_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "TraceHitColor");
		TraceChannelTestUtil_TraceHitColor_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "TraceHitColor");
		TraceChannelTestUtil_TraceHitColor_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "TraceHitColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_DrawTime_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "DrawTime");
		TraceChannelTestUtil_DrawTime_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "DrawTime");
		TraceChannelTestUtil_DrawTime_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "DrawTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannelTestUtil_ReturnValue_PropertyAddress, TraceChannelTestUtil_FunctionAddress, "ReturnValue");
		TraceChannelTestUtil_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TraceChannelTestUtil_FunctionAddress, "ReturnValue");
		TraceChannelTestUtil_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceChannelTestUtil_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		TraceChannelTestUtil_IsValid = TraceChannelTestUtil_FunctionAddress != IntPtr.Zero && TraceChannelTestUtil_WorldContextObject_IsValid && TraceChannelTestUtil_BatchOptions_IsValid && TraceChannelTestUtil_Start_IsValid && TraceChannelTestUtil_End_IsValid && TraceChannelTestUtil_SphereCapsuleRadius_IsValid && TraceChannelTestUtil_CapsuleHalfHeight_IsValid && TraceChannelTestUtil_BoxHalfSize_IsValid && TraceChannelTestUtil_Orientation_IsValid && TraceChannelTestUtil_TraceChannel_IsValid && TraceChannelTestUtil_ObjectTypes_IsValid && TraceChannelTestUtil_ProfileName_IsValid && TraceChannelTestUtil_bTraceComplex_IsValid && TraceChannelTestUtil_ActorsToIgnore_IsValid && TraceChannelTestUtil_bIgnoreSelf_IsValid && TraceChannelTestUtil_DrawDebugType_IsValid && TraceChannelTestUtil_TraceColor_IsValid && TraceChannelTestUtil_TraceHitColor_IsValid && TraceChannelTestUtil_DrawTime_IsValid && TraceChannelTestUtil_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTestUtilityLibrary:TraceChannelTestUtil", TraceChannelTestUtil_IsValid);
	}
}
