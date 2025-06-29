using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.ScatterPattern", "FuncLibEditor", UnrealModuleType.Game)]
public struct FScatterPattern
{
	private static bool TargetFile_IsValid;

	private static int TargetFile_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.ScatterPattern:TargetFile")]
	public string TargetFile;

	private static bool SourceFiles_IsValid;

	private static FFieldAddress SourceFiles_PropertyAddress;

	private static int SourceFiles_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.ScatterPattern:SourceFiles")]
	public List<string> SourceFiles;

	private static bool ScatterStartPoints_IsValid;

	private static FFieldAddress ScatterStartPoints_PropertyAddress;

	private static int ScatterStartPoints_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.ScatterPattern:ScatterStartPoints")]
	public List<FVector> ScatterStartPoints;

	private static bool ScatterIntensity_IsValid;

	private static int ScatterIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.ScatterPattern:ScatterIntensity")]
	public float ScatterIntensity;

	private static bool ScatterInstanceUniformScale_IsValid;

	private static int ScatterInstanceUniformScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.ScatterPattern:ScatterInstanceUniformScale")]
	public float ScatterInstanceUniformScale;

	private static bool ScatterQueryExtent_IsValid;

	private static int ScatterQueryExtent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/FuncLibEditor.ScatterPattern:ScatterQueryExtent")]
	public FVector ScatterQueryExtent;

	private static bool FillZDimension_IsValid;

	private static FFieldAddress FillZDimension_PropertyAddress;

	private static int FillZDimension_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.ScatterPattern:bFillZDimension")]
	public bool FillZDimension;

	private static bool ScatterPointsZAlignment_IsValid;

	private static FFieldAddress ScatterPointsZAlignment_PropertyAddress;

	private static int ScatterPointsZAlignment_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/FuncLibEditor.ScatterPattern:ScatterPointsZAlignment")]
	public ENavigablePointsZAlignment ScatterPointsZAlignment;

	private static bool FScatterPattern_IsValid;

	private static int FScatterPattern_StructSize;

	public FScatterPattern Copy()
	{
		FScatterPattern result = this;
		if (SourceFiles != null)
		{
			result.SourceFiles = new List<string>(SourceFiles);
		}
		if (ScatterStartPoints != null)
		{
			result.ScatterStartPoints = new List<FVector>(ScatterStartPoints);
		}
		return result;
	}

	public static FScatterPattern FromNative(IntPtr nativeBuffer)
	{
		return new FScatterPattern(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FScatterPattern value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FScatterPattern FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FScatterPattern(nativeBuffer + arrayIndex * FScatterPattern_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FScatterPattern value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FScatterPattern_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FScatterPattern_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.ScatterPattern");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, TargetFile_Offset), TargetFile);
		new TArrayCopyMarshaler<string>(1, SourceFiles_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, SourceFiles_Offset), SourceFiles);
		new TArrayCopyMarshaler<FVector>(1, ScatterStartPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ScatterStartPoints_Offset), ScatterStartPoints);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScatterIntensity_Offset), ScatterIntensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScatterInstanceUniformScale_Offset), ScatterInstanceUniformScale);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, ScatterQueryExtent_Offset), ScatterQueryExtent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FillZDimension_Offset), 0, FillZDimension_PropertyAddress.Address, FillZDimension);
		EnumMarshaler<ENavigablePointsZAlignment>.ToNative(IntPtr.Add(nativeStruct, ScatterPointsZAlignment_Offset), 0, ScatterPointsZAlignment_PropertyAddress.Address, ScatterPointsZAlignment);
	}

	public FScatterPattern(IntPtr nativeStruct)
	{
		if (!FScatterPattern_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.ScatterPattern");
			TargetFile = FStringMarshaler.DefaultString;
			SourceFiles = null;
			ScatterStartPoints = null;
			ScatterIntensity = 0f;
			ScatterInstanceUniformScale = 0f;
			ScatterQueryExtent = default(FVector);
			FillZDimension = false;
			ScatterPointsZAlignment = ENavigablePointsZAlignment.TOP;
		}
		else
		{
			TargetFile = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, TargetFile_Offset));
			SourceFiles = new TArrayCopyMarshaler<string>(1, SourceFiles_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, SourceFiles_Offset));
			ScatterStartPoints = new TArrayCopyMarshaler<FVector>(1, ScatterStartPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ScatterStartPoints_Offset));
			ScatterIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScatterIntensity_Offset));
			ScatterInstanceUniformScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScatterInstanceUniformScale_Offset));
			ScatterQueryExtent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, ScatterQueryExtent_Offset));
			FillZDimension = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FillZDimension_Offset), 0, FillZDimension_PropertyAddress.Address);
			ScatterPointsZAlignment = EnumMarshaler<ENavigablePointsZAlignment>.FromNative(IntPtr.Add(nativeStruct, ScatterPointsZAlignment_Offset), 0, ScatterPointsZAlignment_PropertyAddress.Address);
		}
	}

	static FScatterPattern()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FScatterPattern)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FScatterPattern));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.ScatterPattern");
		FScatterPattern_StructSize = NativeReflection.GetStructSize(intPtr);
		TargetFile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetFile");
		TargetFile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetFile", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SourceFiles_PropertyAddress, intPtr, "SourceFiles");
		SourceFiles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceFiles");
		SourceFiles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceFiles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterStartPoints_PropertyAddress, intPtr, "ScatterStartPoints");
		ScatterStartPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScatterStartPoints");
		ScatterStartPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScatterStartPoints", Classes.FArrayProperty);
		ScatterIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScatterIntensity");
		ScatterIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScatterIntensity", Classes.FFloatProperty);
		ScatterInstanceUniformScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScatterInstanceUniformScale");
		ScatterInstanceUniformScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScatterInstanceUniformScale", Classes.FFloatProperty);
		ScatterQueryExtent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScatterQueryExtent");
		ScatterQueryExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScatterQueryExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FillZDimension_PropertyAddress, intPtr, "bFillZDimension");
		FillZDimension_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFillZDimension");
		FillZDimension_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFillZDimension", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterPointsZAlignment_PropertyAddress, intPtr, "ScatterPointsZAlignment");
		ScatterPointsZAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScatterPointsZAlignment");
		ScatterPointsZAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScatterPointsZAlignment", Classes.FEnumProperty);
		FScatterPattern_IsValid = intPtr != IntPtr.Zero && TargetFile_IsValid && SourceFiles_IsValid && ScatterStartPoints_IsValid && ScatterIntensity_IsValid && ScatterInstanceUniformScale_IsValid && ScatterQueryExtent_IsValid && FillZDimension_IsValid && ScatterPointsZAlignment_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.ScatterPattern", FScatterPattern_IsValid);
	}
}
