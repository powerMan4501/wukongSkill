using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DatasmithContent.DatasmithRetessellationOptions", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public struct FDatasmithRetessellationOptions
{
	private static bool ChordTolerance_IsValid;

	private static int ChordTolerance_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithTessellationOptions:ChordTolerance")]
	public float ChordTolerance;

	private static bool MaxEdgeLength_IsValid;

	private static int MaxEdgeLength_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithTessellationOptions:MaxEdgeLength")]
	public float MaxEdgeLength;

	private static bool NormalTolerance_IsValid;

	private static int NormalTolerance_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithTessellationOptions:NormalTolerance")]
	public float NormalTolerance;

	private static bool StitchingTechnique_IsValid;

	private static FFieldAddress StitchingTechnique_PropertyAddress;

	private static int StitchingTechnique_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithTessellationOptions:StitchingTechnique")]
	public EDatasmithCADStitchingTechnique StitchingTechnique;

	private static bool RetessellationRule_IsValid;

	private static FFieldAddress RetessellationRule_PropertyAddress;

	private static int RetessellationRule_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithRetessellationOptions:RetessellationRule")]
	public EDatasmithCADRetessellationRule RetessellationRule;

	private static bool FDatasmithRetessellationOptions_IsValid;

	private static int FDatasmithRetessellationOptions_StructSize;

	public FDatasmithRetessellationOptions Copy()
	{
		return this;
	}

	public static FDatasmithRetessellationOptions FromNative(IntPtr nativeBuffer)
	{
		return new FDatasmithRetessellationOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDatasmithRetessellationOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDatasmithRetessellationOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDatasmithRetessellationOptions(nativeBuffer + arrayIndex * FDatasmithRetessellationOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDatasmithRetessellationOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDatasmithRetessellationOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDatasmithRetessellationOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithRetessellationOptions");
			return;
		}
		EnumMarshaler<EDatasmithCADRetessellationRule>.ToNative(IntPtr.Add(nativeStruct, RetessellationRule_Offset), 0, RetessellationRule_PropertyAddress.Address, RetessellationRule);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ChordTolerance_Offset), ChordTolerance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxEdgeLength_Offset), MaxEdgeLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalTolerance_Offset), NormalTolerance);
		EnumMarshaler<EDatasmithCADStitchingTechnique>.ToNative(IntPtr.Add(nativeStruct, StitchingTechnique_Offset), 0, StitchingTechnique_PropertyAddress.Address, StitchingTechnique);
	}

	public FDatasmithRetessellationOptions(IntPtr nativeStruct)
	{
		if (!FDatasmithRetessellationOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithRetessellationOptions");
			RetessellationRule = EDatasmithCADRetessellationRule.All;
			ChordTolerance = 0f;
			MaxEdgeLength = 0f;
			NormalTolerance = 0f;
			StitchingTechnique = EDatasmithCADStitchingTechnique.StitchingNone;
		}
		else
		{
			RetessellationRule = EnumMarshaler<EDatasmithCADRetessellationRule>.FromNative(IntPtr.Add(nativeStruct, RetessellationRule_Offset), 0, RetessellationRule_PropertyAddress.Address);
			ChordTolerance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ChordTolerance_Offset));
			MaxEdgeLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxEdgeLength_Offset));
			NormalTolerance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalTolerance_Offset));
			StitchingTechnique = EnumMarshaler<EDatasmithCADStitchingTechnique>.FromNative(IntPtr.Add(nativeStruct, StitchingTechnique_Offset), 0, StitchingTechnique_PropertyAddress.Address);
		}
	}

	static FDatasmithRetessellationOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDatasmithRetessellationOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDatasmithRetessellationOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DatasmithContent.DatasmithRetessellationOptions");
		FDatasmithRetessellationOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		ChordTolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChordTolerance");
		ChordTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChordTolerance", Classes.FFloatProperty);
		MaxEdgeLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxEdgeLength");
		MaxEdgeLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxEdgeLength", Classes.FFloatProperty);
		NormalTolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalTolerance");
		NormalTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalTolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StitchingTechnique_PropertyAddress, intPtr, "StitchingTechnique");
		StitchingTechnique_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StitchingTechnique");
		StitchingTechnique_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StitchingTechnique", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref RetessellationRule_PropertyAddress, intPtr, "RetessellationRule");
		RetessellationRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RetessellationRule");
		RetessellationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RetessellationRule", Classes.FEnumProperty);
		FDatasmithRetessellationOptions_IsValid = intPtr != IntPtr.Zero && RetessellationRule_IsValid && ChordTolerance_IsValid && MaxEdgeLength_IsValid && NormalTolerance_IsValid && StitchingTechnique_IsValid;
		NativeReflection.LogStructIsValid("/Script/DatasmithContent.DatasmithRetessellationOptions", FDatasmithRetessellationOptions_IsValid);
	}
}
