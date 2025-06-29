using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DatasmithContent.DatasmithTessellationOptions", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public struct FDatasmithTessellationOptions
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

	private static bool FDatasmithTessellationOptions_IsValid;

	private static int FDatasmithTessellationOptions_StructSize;

	public FDatasmithTessellationOptions Copy()
	{
		return this;
	}

	public static FDatasmithTessellationOptions FromNative(IntPtr nativeBuffer)
	{
		return new FDatasmithTessellationOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDatasmithTessellationOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDatasmithTessellationOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDatasmithTessellationOptions(nativeBuffer + arrayIndex * FDatasmithTessellationOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDatasmithTessellationOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDatasmithTessellationOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDatasmithTessellationOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithTessellationOptions");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ChordTolerance_Offset), ChordTolerance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxEdgeLength_Offset), MaxEdgeLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalTolerance_Offset), NormalTolerance);
		EnumMarshaler<EDatasmithCADStitchingTechnique>.ToNative(IntPtr.Add(nativeStruct, StitchingTechnique_Offset), 0, StitchingTechnique_PropertyAddress.Address, StitchingTechnique);
	}

	public FDatasmithTessellationOptions(IntPtr nativeStruct)
	{
		if (!FDatasmithTessellationOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithTessellationOptions");
			ChordTolerance = 0f;
			MaxEdgeLength = 0f;
			NormalTolerance = 0f;
			StitchingTechnique = EDatasmithCADStitchingTechnique.StitchingNone;
		}
		else
		{
			ChordTolerance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ChordTolerance_Offset));
			MaxEdgeLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxEdgeLength_Offset));
			NormalTolerance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalTolerance_Offset));
			StitchingTechnique = EnumMarshaler<EDatasmithCADStitchingTechnique>.FromNative(IntPtr.Add(nativeStruct, StitchingTechnique_Offset), 0, StitchingTechnique_PropertyAddress.Address);
		}
	}

	static FDatasmithTessellationOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDatasmithTessellationOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDatasmithTessellationOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DatasmithContent.DatasmithTessellationOptions");
		FDatasmithTessellationOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		ChordTolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChordTolerance");
		ChordTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChordTolerance", Classes.FFloatProperty);
		MaxEdgeLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxEdgeLength");
		MaxEdgeLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxEdgeLength", Classes.FFloatProperty);
		NormalTolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalTolerance");
		NormalTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalTolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StitchingTechnique_PropertyAddress, intPtr, "StitchingTechnique");
		StitchingTechnique_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StitchingTechnique");
		StitchingTechnique_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StitchingTechnique", Classes.FEnumProperty);
		FDatasmithTessellationOptions_IsValid = intPtr != IntPtr.Zero && ChordTolerance_IsValid && MaxEdgeLength_IsValid && NormalTolerance_IsValid && StitchingTechnique_IsValid;
		NativeReflection.LogStructIsValid("/Script/DatasmithContent.DatasmithTessellationOptions", FDatasmithTessellationOptions_IsValid);
	}
}
