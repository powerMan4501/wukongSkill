using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamBool", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKMatParamBool
{
	private static bool BrushPropertyNamePath_IsValid;

	private static FFieldAddress BrushPropertyNamePath_PropertyAddress;

	private static int BrushPropertyNamePath_Offset;

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamBool:BrushPropertyNamePath")]
	public List<FName> BrushPropertyNamePath;

	private static bool ComponentMaterialIndex_IsValid;

	private static int ComponentMaterialIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamBool:ComponentMaterialIndex")]
	public int ComponentMaterialIndex;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamBool:ParamName")]
	public FName ParamName;

	private static bool Value_IsValid;

	private static FFieldAddress Value_PropertyAddress;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamBool:Value")]
	public bool Value;

	private static bool FGSAKMatParamBool_IsValid;

	private static int FGSAKMatParamBool_StructSize;

	public FGSAKMatParamBool Copy()
	{
		FGSAKMatParamBool result = this;
		if (BrushPropertyNamePath != null)
		{
			result.BrushPropertyNamePath = new List<FName>(BrushPropertyNamePath);
		}
		return result;
	}

	public static FGSAKMatParamBool FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKMatParamBool(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKMatParamBool value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKMatParamBool FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKMatParamBool(nativeBuffer + arrayIndex * FGSAKMatParamBool_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKMatParamBool value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKMatParamBool_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKMatParamBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKMatParamBool");
			return;
		}
		new TArrayCopyMarshaler<FName>(1, BrushPropertyNamePath_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BrushPropertyNamePath_Offset), BrushPropertyNamePath);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ComponentMaterialIndex_Offset), ComponentMaterialIndex);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Value_Offset), 0, Value_PropertyAddress.Address, Value);
	}

	public FGSAKMatParamBool(IntPtr nativeStruct)
	{
		if (!FGSAKMatParamBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKMatParamBool");
			BrushPropertyNamePath = null;
			ComponentMaterialIndex = 0;
			ParamName = default(FName);
			Value = false;
		}
		else
		{
			BrushPropertyNamePath = new TArrayCopyMarshaler<FName>(1, BrushPropertyNamePath_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BrushPropertyNamePath_Offset));
			ComponentMaterialIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ComponentMaterialIndex_Offset));
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			Value = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Value_Offset), 0, Value_PropertyAddress.Address);
		}
	}

	static FGSAKMatParamBool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKMatParamBool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKMatParamBool));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKMatParamBool");
		FGSAKMatParamBool_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref BrushPropertyNamePath_PropertyAddress, intPtr, "BrushPropertyNamePath");
		BrushPropertyNamePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushPropertyNamePath");
		BrushPropertyNamePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushPropertyNamePath", Classes.FArrayProperty);
		ComponentMaterialIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentMaterialIndex");
		ComponentMaterialIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentMaterialIndex", Classes.FIntProperty);
		ParamName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Value_PropertyAddress, intPtr, "Value");
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FBoolProperty);
		FGSAKMatParamBool_IsValid = intPtr != IntPtr.Zero && BrushPropertyNamePath_IsValid && ComponentMaterialIndex_IsValid && ParamName_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKMatParamBool", FGSAKMatParamBool_IsValid);
	}
}
