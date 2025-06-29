using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimationCore.ConstraintDescription", "AnimationCore", UnrealModuleType.Engine)]
public struct FConstraintDescription
{
	private static bool Translation_IsValid;

	private static FFieldAddress Translation_PropertyAddress;

	private static int Translation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.ConstraintDescription:bTranslation")]
	public bool Translation;

	private static bool Rotation_IsValid;

	private static FFieldAddress Rotation_PropertyAddress;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.ConstraintDescription:bRotation")]
	public bool Rotation;

	private static bool Scale_IsValid;

	private static FFieldAddress Scale_PropertyAddress;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.ConstraintDescription:bScale")]
	public bool Scale;

	private static bool Parent_IsValid;

	private static FFieldAddress Parent_PropertyAddress;

	private static int Parent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.ConstraintDescription:bParent")]
	public bool Parent;

	private static bool TranslationAxes_IsValid;

	private static int TranslationAxes_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimationCore.ConstraintDescription:TranslationAxes")]
	public FFilterOptionPerAxis TranslationAxes;

	private static bool RotationAxes_IsValid;

	private static int RotationAxes_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimationCore.ConstraintDescription:RotationAxes")]
	public FFilterOptionPerAxis RotationAxes;

	private static bool ScaleAxes_IsValid;

	private static int ScaleAxes_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimationCore.ConstraintDescription:ScaleAxes")]
	public FFilterOptionPerAxis ScaleAxes;

	private static bool FConstraintDescription_IsValid;

	private static int FConstraintDescription_StructSize;

	public FConstraintDescription Copy()
	{
		return this;
	}

	public static FConstraintDescription FromNative(IntPtr nativeBuffer)
	{
		return new FConstraintDescription(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FConstraintDescription value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FConstraintDescription FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FConstraintDescription(nativeBuffer + arrayIndex * FConstraintDescription_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FConstraintDescription value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FConstraintDescription_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FConstraintDescription_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.ConstraintDescription");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Translation_Offset), 0, Translation_PropertyAddress.Address, Translation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), 0, Rotation_PropertyAddress.Address, Rotation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), 0, Scale_PropertyAddress.Address, Scale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Parent_Offset), 0, Parent_PropertyAddress.Address, Parent);
		FFilterOptionPerAxis.ToNative(IntPtr.Add(nativeStruct, TranslationAxes_Offset), TranslationAxes);
		FFilterOptionPerAxis.ToNative(IntPtr.Add(nativeStruct, RotationAxes_Offset), RotationAxes);
		FFilterOptionPerAxis.ToNative(IntPtr.Add(nativeStruct, ScaleAxes_Offset), ScaleAxes);
	}

	public FConstraintDescription(IntPtr nativeStruct)
	{
		if (!FConstraintDescription_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.ConstraintDescription");
			Translation = false;
			Rotation = false;
			Scale = false;
			Parent = false;
			TranslationAxes = default(FFilterOptionPerAxis);
			RotationAxes = default(FFilterOptionPerAxis);
			ScaleAxes = default(FFilterOptionPerAxis);
		}
		else
		{
			Translation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Translation_Offset), 0, Translation_PropertyAddress.Address);
			Rotation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset), 0, Rotation_PropertyAddress.Address);
			Scale = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Scale_Offset), 0, Scale_PropertyAddress.Address);
			Parent = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Parent_Offset), 0, Parent_PropertyAddress.Address);
			TranslationAxes = FFilterOptionPerAxis.FromNative(IntPtr.Add(nativeStruct, TranslationAxes_Offset));
			RotationAxes = FFilterOptionPerAxis.FromNative(IntPtr.Add(nativeStruct, RotationAxes_Offset));
			ScaleAxes = FFilterOptionPerAxis.FromNative(IntPtr.Add(nativeStruct, ScaleAxes_Offset));
		}
	}

	static FConstraintDescription()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FConstraintDescription)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FConstraintDescription));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimationCore.ConstraintDescription");
		FConstraintDescription_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Translation_PropertyAddress, intPtr, "bTranslation");
		Translation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTranslation");
		Translation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTranslation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Rotation_PropertyAddress, intPtr, "bRotation");
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRotation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Scale_PropertyAddress, intPtr, "bScale");
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bScale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Parent_PropertyAddress, intPtr, "bParent");
		Parent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bParent");
		Parent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bParent", Classes.FBoolProperty);
		TranslationAxes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TranslationAxes");
		TranslationAxes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TranslationAxes", Classes.FStructProperty);
		RotationAxes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationAxes");
		RotationAxes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationAxes", Classes.FStructProperty);
		ScaleAxes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScaleAxes");
		ScaleAxes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScaleAxes", Classes.FStructProperty);
		FConstraintDescription_IsValid = intPtr != IntPtr.Zero && Translation_IsValid && Rotation_IsValid && Scale_IsValid && Parent_IsValid && TranslationAxes_IsValid && RotationAxes_IsValid && ScaleAxes_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimationCore.ConstraintDescription", FConstraintDescription_IsValid);
	}
}
