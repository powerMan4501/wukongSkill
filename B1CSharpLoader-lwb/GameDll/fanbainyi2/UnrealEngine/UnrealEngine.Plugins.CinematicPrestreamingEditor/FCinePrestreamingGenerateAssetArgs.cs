using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CinematicPrestreamingEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingGenerateAssetArgs", "CinematicPrestreamingEditor", UnrealModuleType.EnginePlugin)]
public struct FCinePrestreamingGenerateAssetArgs
{
	private static bool OutputDirectoryOverride_IsValid;

	private static int OutputDirectoryOverride_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingGenerateAssetArgs:OutputDirectoryOverride")]
	public FDirectoryPath OutputDirectoryOverride;

	private static bool Sequence_IsValid;

	private static int Sequence_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingGenerateAssetArgs:Sequence")]
	public FSoftObjectPath Sequence;

	private static bool Map_IsValid;

	private static int Map_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingGenerateAssetArgs:Map")]
	public FSoftObjectPath Map;

	private static bool Resolution_IsValid;

	private static int Resolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingGenerateAssetArgs:Resolution")]
	public FIntPoint Resolution;

	private static bool FCinePrestreamingGenerateAssetArgs_IsValid;

	private static int FCinePrestreamingGenerateAssetArgs_StructSize;

	public FCinePrestreamingGenerateAssetArgs Copy()
	{
		return this;
	}

	public static FCinePrestreamingGenerateAssetArgs FromNative(IntPtr nativeBuffer)
	{
		return new FCinePrestreamingGenerateAssetArgs(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCinePrestreamingGenerateAssetArgs value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCinePrestreamingGenerateAssetArgs FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCinePrestreamingGenerateAssetArgs(nativeBuffer + arrayIndex * FCinePrestreamingGenerateAssetArgs_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCinePrestreamingGenerateAssetArgs value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCinePrestreamingGenerateAssetArgs_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCinePrestreamingGenerateAssetArgs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingGenerateAssetArgs");
			return;
		}
		FDirectoryPath.ToNative(IntPtr.Add(nativeStruct, OutputDirectoryOverride_Offset), OutputDirectoryOverride);
		FSoftObjectPath.ToNative(IntPtr.Add(nativeStruct, Sequence_Offset), Sequence);
		FSoftObjectPath.ToNative(IntPtr.Add(nativeStruct, Map_Offset), Map);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, Resolution_Offset), Resolution);
	}

	public FCinePrestreamingGenerateAssetArgs(IntPtr nativeStruct)
	{
		if (!FCinePrestreamingGenerateAssetArgs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingGenerateAssetArgs");
			OutputDirectoryOverride = default(FDirectoryPath);
			Sequence = default(FSoftObjectPath);
			Map = default(FSoftObjectPath);
			Resolution = default(FIntPoint);
		}
		else
		{
			OutputDirectoryOverride = FDirectoryPath.FromNative(IntPtr.Add(nativeStruct, OutputDirectoryOverride_Offset));
			Sequence = FSoftObjectPath.FromNative(IntPtr.Add(nativeStruct, Sequence_Offset));
			Map = FSoftObjectPath.FromNative(IntPtr.Add(nativeStruct, Map_Offset));
			Resolution = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, Resolution_Offset));
		}
	}

	static FCinePrestreamingGenerateAssetArgs()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCinePrestreamingGenerateAssetArgs)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCinePrestreamingGenerateAssetArgs));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CinematicPrestreamingEditor.CinePrestreamingGenerateAssetArgs");
		FCinePrestreamingGenerateAssetArgs_StructSize = NativeReflection.GetStructSize(intPtr);
		OutputDirectoryOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputDirectoryOverride");
		OutputDirectoryOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputDirectoryOverride", Classes.FStructProperty);
		Sequence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Sequence");
		Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Sequence", Classes.FStructProperty);
		Map_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Map");
		Map_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Map", Classes.FStructProperty);
		Resolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Resolution");
		Resolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Resolution", Classes.FStructProperty);
		FCinePrestreamingGenerateAssetArgs_IsValid = intPtr != IntPtr.Zero && OutputDirectoryOverride_IsValid && Sequence_IsValid && Map_IsValid && Resolution_IsValid;
		NativeReflection.LogStructIsValid("/Script/CinematicPrestreamingEditor.CinePrestreamingGenerateAssetArgs", FCinePrestreamingGenerateAssetArgs_IsValid);
	}
}
