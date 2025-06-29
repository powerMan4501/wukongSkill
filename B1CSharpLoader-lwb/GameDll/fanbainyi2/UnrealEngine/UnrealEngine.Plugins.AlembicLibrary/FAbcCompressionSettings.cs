using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.AbcCompressionSettings", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public struct FAbcCompressionSettings
{
	private static bool MergeMeshes_IsValid;

	private static FFieldAddress MergeMeshes_PropertyAddress;

	private static int MergeMeshes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcCompressionSettings:bMergeMeshes")]
	public bool MergeMeshes;

	private static bool BakeMatrixAnimation_IsValid;

	private static FFieldAddress BakeMatrixAnimation_PropertyAddress;

	private static int BakeMatrixAnimation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcCompressionSettings:bBakeMatrixAnimation")]
	public bool BakeMatrixAnimation;

	private static bool BaseCalculationType_IsValid;

	private static FFieldAddress BaseCalculationType_PropertyAddress;

	private static int BaseCalculationType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcCompressionSettings:BaseCalculationType")]
	public EBaseCalculationType BaseCalculationType;

	private static bool PercentageOfTotalBases_IsValid;

	private static int PercentageOfTotalBases_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcCompressionSettings:PercentageOfTotalBases")]
	public float PercentageOfTotalBases;

	private static bool MaxNumberOfBases_IsValid;

	private static int MaxNumberOfBases_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcCompressionSettings:MaxNumberOfBases")]
	public int MaxNumberOfBases;

	private static bool MinimumNumberOfVertexInfluencePercentage_IsValid;

	private static int MinimumNumberOfVertexInfluencePercentage_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcCompressionSettings:MinimumNumberOfVertexInfluencePercentage")]
	public float MinimumNumberOfVertexInfluencePercentage;

	private static bool FAbcCompressionSettings_IsValid;

	private static int FAbcCompressionSettings_StructSize;

	public FAbcCompressionSettings Copy()
	{
		return this;
	}

	public static FAbcCompressionSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAbcCompressionSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAbcCompressionSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAbcCompressionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAbcCompressionSettings(nativeBuffer + arrayIndex * FAbcCompressionSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAbcCompressionSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAbcCompressionSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAbcCompressionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcCompressionSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MergeMeshes_Offset), 0, MergeMeshes_PropertyAddress.Address, MergeMeshes);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BakeMatrixAnimation_Offset), 0, BakeMatrixAnimation_PropertyAddress.Address, BakeMatrixAnimation);
		EnumMarshaler<EBaseCalculationType>.ToNative(IntPtr.Add(nativeStruct, BaseCalculationType_Offset), 0, BaseCalculationType_PropertyAddress.Address, BaseCalculationType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PercentageOfTotalBases_Offset), PercentageOfTotalBases);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxNumberOfBases_Offset), MaxNumberOfBases);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinimumNumberOfVertexInfluencePercentage_Offset), MinimumNumberOfVertexInfluencePercentage);
	}

	public FAbcCompressionSettings(IntPtr nativeStruct)
	{
		if (!FAbcCompressionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcCompressionSettings");
			MergeMeshes = false;
			BakeMatrixAnimation = false;
			BaseCalculationType = EBaseCalculationType.None;
			PercentageOfTotalBases = 0f;
			MaxNumberOfBases = 0;
			MinimumNumberOfVertexInfluencePercentage = 0f;
		}
		else
		{
			MergeMeshes = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MergeMeshes_Offset), 0, MergeMeshes_PropertyAddress.Address);
			BakeMatrixAnimation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BakeMatrixAnimation_Offset), 0, BakeMatrixAnimation_PropertyAddress.Address);
			BaseCalculationType = EnumMarshaler<EBaseCalculationType>.FromNative(IntPtr.Add(nativeStruct, BaseCalculationType_Offset), 0, BaseCalculationType_PropertyAddress.Address);
			PercentageOfTotalBases = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PercentageOfTotalBases_Offset));
			MaxNumberOfBases = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxNumberOfBases_Offset));
			MinimumNumberOfVertexInfluencePercentage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinimumNumberOfVertexInfluencePercentage_Offset));
		}
	}

	static FAbcCompressionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAbcCompressionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAbcCompressionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AlembicLibrary.AbcCompressionSettings");
		FAbcCompressionSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref MergeMeshes_PropertyAddress, intPtr, "bMergeMeshes");
		MergeMeshes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMergeMeshes");
		MergeMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMergeMeshes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BakeMatrixAnimation_PropertyAddress, intPtr, "bBakeMatrixAnimation");
		BakeMatrixAnimation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBakeMatrixAnimation");
		BakeMatrixAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBakeMatrixAnimation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BaseCalculationType_PropertyAddress, intPtr, "BaseCalculationType");
		BaseCalculationType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaseCalculationType");
		BaseCalculationType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaseCalculationType", Classes.FEnumProperty);
		PercentageOfTotalBases_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PercentageOfTotalBases");
		PercentageOfTotalBases_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PercentageOfTotalBases", Classes.FFloatProperty);
		MaxNumberOfBases_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxNumberOfBases");
		MaxNumberOfBases_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxNumberOfBases", Classes.FIntProperty);
		MinimumNumberOfVertexInfluencePercentage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinimumNumberOfVertexInfluencePercentage");
		MinimumNumberOfVertexInfluencePercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinimumNumberOfVertexInfluencePercentage", Classes.FFloatProperty);
		FAbcCompressionSettings_IsValid = intPtr != IntPtr.Zero && MergeMeshes_IsValid && BakeMatrixAnimation_IsValid && BaseCalculationType_IsValid && PercentageOfTotalBases_IsValid && MaxNumberOfBases_IsValid && MinimumNumberOfVertexInfluencePercentage_IsValid;
		NativeReflection.LogStructIsValid("/Script/AlembicLibrary.AbcCompressionSettings", FAbcCompressionSettings_IsValid);
	}
}
