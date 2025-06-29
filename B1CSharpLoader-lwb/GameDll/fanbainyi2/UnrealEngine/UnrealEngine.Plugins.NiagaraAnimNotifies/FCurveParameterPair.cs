using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraAnimNotifies;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/NiagaraAnimNotifies.CurveParameterPair", "NiagaraAnimNotifies", UnrealModuleType.EnginePlugin)]
public struct FCurveParameterPair
{
	private static bool AnimCurveName_IsValid;

	private static int AnimCurveName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/NiagaraAnimNotifies.CurveParameterPair:AnimCurveName")]
	public FName AnimCurveName;

	private static bool UserVariableName_IsValid;

	private static int UserVariableName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/NiagaraAnimNotifies.CurveParameterPair:UserVariableName")]
	public FName UserVariableName;

	private static bool FCurveParameterPair_IsValid;

	private static int FCurveParameterPair_StructSize;

	public FCurveParameterPair Copy()
	{
		return this;
	}

	public static FCurveParameterPair FromNative(IntPtr nativeBuffer)
	{
		return new FCurveParameterPair(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCurveParameterPair value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCurveParameterPair FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCurveParameterPair(nativeBuffer + arrayIndex * FCurveParameterPair_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCurveParameterPair value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCurveParameterPair_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCurveParameterPair_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/NiagaraAnimNotifies.CurveParameterPair");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AnimCurveName_Offset), AnimCurveName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, UserVariableName_Offset), UserVariableName);
	}

	public FCurveParameterPair(IntPtr nativeStruct)
	{
		if (!FCurveParameterPair_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/NiagaraAnimNotifies.CurveParameterPair");
			AnimCurveName = default(FName);
			UserVariableName = default(FName);
		}
		else
		{
			AnimCurveName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AnimCurveName_Offset));
			UserVariableName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, UserVariableName_Offset));
		}
	}

	static FCurveParameterPair()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCurveParameterPair)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCurveParameterPair));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/NiagaraAnimNotifies.CurveParameterPair");
		FCurveParameterPair_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimCurveName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimCurveName");
		AnimCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimCurveName", Classes.FNameProperty);
		UserVariableName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UserVariableName");
		UserVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UserVariableName", Classes.FNameProperty);
		FCurveParameterPair_IsValid = intPtr != IntPtr.Zero && AnimCurveName_IsValid && UserVariableName_IsValid;
		NativeReflection.LogStructIsValid("/Script/NiagaraAnimNotifies.CurveParameterPair", FCurveParameterPair_IsValid);
	}
}
