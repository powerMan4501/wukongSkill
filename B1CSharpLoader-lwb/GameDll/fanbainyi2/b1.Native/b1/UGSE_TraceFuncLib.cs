using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_TraceFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_TraceFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool CharacterCapsuleTraceSingleByProfile_IsValid;

	private static IntPtr CharacterCapsuleTraceSingleByProfile_FunctionAddress;

	private static int CharacterCapsuleTraceSingleByProfile_ParamsSize;

	private static bool CharacterCapsuleTraceSingleByProfile_WorldContextObject_IsValid;

	private static FFieldAddress CharacterCapsuleTraceSingleByProfile_WorldContextObject_PropertyAddress;

	private static int CharacterCapsuleTraceSingleByProfile_WorldContextObject_Offset;

	private static bool CharacterCapsuleTraceSingleByProfile_Start_IsValid;

	private static FFieldAddress CharacterCapsuleTraceSingleByProfile_Start_PropertyAddress;

	private static int CharacterCapsuleTraceSingleByProfile_Start_Offset;

	private static bool CharacterCapsuleTraceSingleByProfile_End_IsValid;

	private static FFieldAddress CharacterCapsuleTraceSingleByProfile_End_PropertyAddress;

	private static int CharacterCapsuleTraceSingleByProfile_End_Offset;

	private static bool CharacterCapsuleTraceSingleByProfile_Radius_IsValid;

	private static FFieldAddress CharacterCapsuleTraceSingleByProfile_Radius_PropertyAddress;

	private static int CharacterCapsuleTraceSingleByProfile_Radius_Offset;

	private static bool CharacterCapsuleTraceSingleByProfile_HalfHeight_IsValid;

	private static FFieldAddress CharacterCapsuleTraceSingleByProfile_HalfHeight_PropertyAddress;

	private static int CharacterCapsuleTraceSingleByProfile_HalfHeight_Offset;

	private static bool CharacterCapsuleTraceSingleByProfile_ProfileName_IsValid;

	private static FFieldAddress CharacterCapsuleTraceSingleByProfile_ProfileName_PropertyAddress;

	private static int CharacterCapsuleTraceSingleByProfile_ProfileName_Offset;

	private static bool CharacterCapsuleTraceSingleByProfile_bTraceComplex_IsValid;

	private static FFieldAddress CharacterCapsuleTraceSingleByProfile_bTraceComplex_PropertyAddress;

	private static int CharacterCapsuleTraceSingleByProfile_bTraceComplex_Offset;

	private static bool CharacterCapsuleTraceSingleByProfile_IgnoreActor_IsValid;

	private static FFieldAddress CharacterCapsuleTraceSingleByProfile_IgnoreActor_PropertyAddress;

	private static int CharacterCapsuleTraceSingleByProfile_IgnoreActor_Offset;

	private static bool CharacterCapsuleTraceSingleByProfile_OutHitLocation_IsValid;

	private static FFieldAddress CharacterCapsuleTraceSingleByProfile_OutHitLocation_PropertyAddress;

	private static int CharacterCapsuleTraceSingleByProfile_OutHitLocation_Offset;

	private static bool CharacterCapsuleTraceSingleByProfile_ReturnValue_IsValid;

	private static FFieldAddress CharacterCapsuleTraceSingleByProfile_ReturnValue_PropertyAddress;

	private static int CharacterCapsuleTraceSingleByProfile_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TraceFuncLib:CharacterCapsuleTraceSingleByProfile")]
	public unsafe static bool CharacterCapsuleTraceSingleByProfile(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, AActor IgnoreActor, out FVector OutHitLocation)
	{
		if (!CharacterCapsuleTraceSingleByProfile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TraceFuncLib:CharacterCapsuleTraceSingleByProfile");
			OutHitLocation = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CharacterCapsuleTraceSingleByProfile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CharacterCapsuleTraceSingleByProfile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CharacterCapsuleTraceSingleByProfile_WorldContextObject_Offset), 0, CharacterCapsuleTraceSingleByProfile_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CharacterCapsuleTraceSingleByProfile_Start_Offset), 0, CharacterCapsuleTraceSingleByProfile_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CharacterCapsuleTraceSingleByProfile_End_Offset), 0, CharacterCapsuleTraceSingleByProfile_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CharacterCapsuleTraceSingleByProfile_Radius_Offset), 0, CharacterCapsuleTraceSingleByProfile_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CharacterCapsuleTraceSingleByProfile_HalfHeight_Offset), 0, CharacterCapsuleTraceSingleByProfile_HalfHeight_PropertyAddress.Address, HalfHeight);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CharacterCapsuleTraceSingleByProfile_ProfileName_Offset), 0, CharacterCapsuleTraceSingleByProfile_ProfileName_PropertyAddress.Address, ProfileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CharacterCapsuleTraceSingleByProfile_bTraceComplex_Offset), 0, CharacterCapsuleTraceSingleByProfile_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CharacterCapsuleTraceSingleByProfile_IgnoreActor_Offset), 0, CharacterCapsuleTraceSingleByProfile_IgnoreActor_PropertyAddress.Address, IgnoreActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CharacterCapsuleTraceSingleByProfile_FunctionAddress, intPtr, CharacterCapsuleTraceSingleByProfile_ParamsSize);
		OutHitLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, CharacterCapsuleTraceSingleByProfile_OutHitLocation_Offset), 0, CharacterCapsuleTraceSingleByProfile_OutHitLocation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CharacterCapsuleTraceSingleByProfile_ReturnValue_Offset), 0, CharacterCapsuleTraceSingleByProfile_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_TraceFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_TraceFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_TraceFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_TraceFuncLib");
		CharacterCapsuleTraceSingleByProfile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CharacterCapsuleTraceSingleByProfile");
		CharacterCapsuleTraceSingleByProfile_ParamsSize = NativeReflection.GetFunctionParamsSize(CharacterCapsuleTraceSingleByProfile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CharacterCapsuleTraceSingleByProfile_WorldContextObject_PropertyAddress, CharacterCapsuleTraceSingleByProfile_FunctionAddress, "WorldContextObject");
		CharacterCapsuleTraceSingleByProfile_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "WorldContextObject");
		CharacterCapsuleTraceSingleByProfile_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CharacterCapsuleTraceSingleByProfile_Start_PropertyAddress, CharacterCapsuleTraceSingleByProfile_FunctionAddress, "Start");
		CharacterCapsuleTraceSingleByProfile_Start_Offset = NativeReflectionCached.GetPropertyOffset(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "Start");
		CharacterCapsuleTraceSingleByProfile_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CharacterCapsuleTraceSingleByProfile_End_PropertyAddress, CharacterCapsuleTraceSingleByProfile_FunctionAddress, "End");
		CharacterCapsuleTraceSingleByProfile_End_Offset = NativeReflectionCached.GetPropertyOffset(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "End");
		CharacterCapsuleTraceSingleByProfile_End_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CharacterCapsuleTraceSingleByProfile_Radius_PropertyAddress, CharacterCapsuleTraceSingleByProfile_FunctionAddress, "Radius");
		CharacterCapsuleTraceSingleByProfile_Radius_Offset = NativeReflectionCached.GetPropertyOffset(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "Radius");
		CharacterCapsuleTraceSingleByProfile_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CharacterCapsuleTraceSingleByProfile_HalfHeight_PropertyAddress, CharacterCapsuleTraceSingleByProfile_FunctionAddress, "HalfHeight");
		CharacterCapsuleTraceSingleByProfile_HalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "HalfHeight");
		CharacterCapsuleTraceSingleByProfile_HalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "HalfHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CharacterCapsuleTraceSingleByProfile_ProfileName_PropertyAddress, CharacterCapsuleTraceSingleByProfile_FunctionAddress, "ProfileName");
		CharacterCapsuleTraceSingleByProfile_ProfileName_Offset = NativeReflectionCached.GetPropertyOffset(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "ProfileName");
		CharacterCapsuleTraceSingleByProfile_ProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "ProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CharacterCapsuleTraceSingleByProfile_bTraceComplex_PropertyAddress, CharacterCapsuleTraceSingleByProfile_FunctionAddress, "bTraceComplex");
		CharacterCapsuleTraceSingleByProfile_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "bTraceComplex");
		CharacterCapsuleTraceSingleByProfile_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CharacterCapsuleTraceSingleByProfile_IgnoreActor_PropertyAddress, CharacterCapsuleTraceSingleByProfile_FunctionAddress, "IgnoreActor");
		CharacterCapsuleTraceSingleByProfile_IgnoreActor_Offset = NativeReflectionCached.GetPropertyOffset(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "IgnoreActor");
		CharacterCapsuleTraceSingleByProfile_IgnoreActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "IgnoreActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CharacterCapsuleTraceSingleByProfile_OutHitLocation_PropertyAddress, CharacterCapsuleTraceSingleByProfile_FunctionAddress, "OutHitLocation");
		CharacterCapsuleTraceSingleByProfile_OutHitLocation_Offset = NativeReflectionCached.GetPropertyOffset(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "OutHitLocation");
		CharacterCapsuleTraceSingleByProfile_OutHitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "OutHitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CharacterCapsuleTraceSingleByProfile_ReturnValue_PropertyAddress, CharacterCapsuleTraceSingleByProfile_FunctionAddress, "ReturnValue");
		CharacterCapsuleTraceSingleByProfile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "ReturnValue");
		CharacterCapsuleTraceSingleByProfile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterCapsuleTraceSingleByProfile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CharacterCapsuleTraceSingleByProfile_IsValid = CharacterCapsuleTraceSingleByProfile_FunctionAddress != IntPtr.Zero && CharacterCapsuleTraceSingleByProfile_WorldContextObject_IsValid && CharacterCapsuleTraceSingleByProfile_Start_IsValid && CharacterCapsuleTraceSingleByProfile_End_IsValid && CharacterCapsuleTraceSingleByProfile_Radius_IsValid && CharacterCapsuleTraceSingleByProfile_HalfHeight_IsValid && CharacterCapsuleTraceSingleByProfile_ProfileName_IsValid && CharacterCapsuleTraceSingleByProfile_bTraceComplex_IsValid && CharacterCapsuleTraceSingleByProfile_IgnoreActor_IsValid && CharacterCapsuleTraceSingleByProfile_OutHitLocation_IsValid && CharacterCapsuleTraceSingleByProfile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TraceFuncLib:CharacterCapsuleTraceSingleByProfile", CharacterCapsuleTraceSingleByProfile_IsValid);
	}
}
