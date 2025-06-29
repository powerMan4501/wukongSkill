using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 6657)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimationAttributeIdentifier", "Engine", UnrealModuleType.Engine)]
public struct FAnimationAttributeIdentifier
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/Engine.AnimationAttributeIdentifier:Name")]
	public FName Name;

	private static bool BoneName_IsValid;

	private static int BoneName_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/Engine.AnimationAttributeIdentifier:BoneName")]
	public FName BoneName;

	private static bool BoneIndex_IsValid;

	private static int BoneIndex_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/Engine.AnimationAttributeIdentifier:BoneIndex")]
	public int BoneIndex;

	private static bool ScriptStruct_IsValid;

	private static int ScriptStruct_Offset;

	[UProperty(Flags = (PropFlags)12393764861518356uL)]
	[UMetaPath("/Script/Engine.AnimationAttributeIdentifier:ScriptStruct")]
	public UScriptStruct ScriptStruct;

	private static bool ScriptStructPath_IsValid;

	private static int ScriptStructPath_Offset;

	[UProperty(Flags = (PropFlags)11267795161448980uL)]
	[UMetaPath("/Script/Engine.AnimationAttributeIdentifier:ScriptStructPath")]
	public FSoftObjectPath ScriptStructPath;

	private static bool FAnimationAttributeIdentifier_IsValid;

	private static int FAnimationAttributeIdentifier_StructSize;

	public FAnimationAttributeIdentifier Copy()
	{
		return this;
	}

	public static FAnimationAttributeIdentifier FromNative(IntPtr nativeBuffer)
	{
		return new FAnimationAttributeIdentifier(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimationAttributeIdentifier value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimationAttributeIdentifier FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimationAttributeIdentifier(nativeBuffer + arrayIndex * FAnimationAttributeIdentifier_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimationAttributeIdentifier value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimationAttributeIdentifier_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimationAttributeIdentifier_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimationAttributeIdentifier");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, BoneName_Offset), BoneName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BoneIndex_Offset), BoneIndex);
		UObjectMarshaler<UScriptStruct>.ToNative(IntPtr.Add(nativeStruct, ScriptStruct_Offset), ScriptStruct);
		FSoftObjectPath.ToNative(IntPtr.Add(nativeStruct, ScriptStructPath_Offset), ScriptStructPath);
	}

	public FAnimationAttributeIdentifier(IntPtr nativeStruct)
	{
		if (!FAnimationAttributeIdentifier_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimationAttributeIdentifier");
			Name = default(FName);
			BoneName = default(FName);
			BoneIndex = 0;
			ScriptStruct = null;
			ScriptStructPath = default(FSoftObjectPath);
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			BoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, BoneName_Offset));
			BoneIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BoneIndex_Offset));
			ScriptStruct = UObjectMarshaler<UScriptStruct>.FromNative(IntPtr.Add(nativeStruct, ScriptStruct_Offset));
			ScriptStructPath = FSoftObjectPath.FromNative(IntPtr.Add(nativeStruct, ScriptStructPath_Offset));
		}
	}

	static FAnimationAttributeIdentifier()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimationAttributeIdentifier)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimationAttributeIdentifier));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimationAttributeIdentifier");
		FAnimationAttributeIdentifier_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		BoneName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneName");
		BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneName", Classes.FNameProperty);
		BoneIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneIndex");
		BoneIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneIndex", Classes.FIntProperty);
		ScriptStruct_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScriptStruct");
		ScriptStruct_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScriptStruct", Classes.FObjectProperty);
		ScriptStructPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScriptStructPath");
		ScriptStructPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScriptStructPath", Classes.FStructProperty);
		FAnimationAttributeIdentifier_IsValid = intPtr != IntPtr.Zero && Name_IsValid && BoneName_IsValid && BoneIndex_IsValid && ScriptStruct_IsValid && ScriptStructPath_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimationAttributeIdentifier", FAnimationAttributeIdentifier_IsValid);
	}
}
