using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamVector4", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKMatParamVector4
{
	private static bool BrushPropertyNamePath_IsValid;

	private static FFieldAddress BrushPropertyNamePath_PropertyAddress;

	private static int BrushPropertyNamePath_Offset;

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamVector4:BrushPropertyNamePath")]
	public List<FName> BrushPropertyNamePath;

	private static bool ComponentMaterialIndex_IsValid;

	private static int ComponentMaterialIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamVector4:ComponentMaterialIndex")]
	public int ComponentMaterialIndex;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamVector4:ParamName")]
	public FName ParamName;

	private static bool ValueFactor_IsValid;

	private static int ValueFactor_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamVector4:ValueFactor")]
	public FLinearColor ValueFactor;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamVector4:Value")]
	public FLinearColor Value;

	private static bool FGSAKMatParamVector4_IsValid;

	private static int FGSAKMatParamVector4_StructSize;

	public FGSAKMatParamVector4 Copy()
	{
		FGSAKMatParamVector4 result = this;
		if (BrushPropertyNamePath != null)
		{
			result.BrushPropertyNamePath = new List<FName>(BrushPropertyNamePath);
		}
		return result;
	}

	public static FGSAKMatParamVector4 FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKMatParamVector4(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKMatParamVector4 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKMatParamVector4 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKMatParamVector4(nativeBuffer + arrayIndex * FGSAKMatParamVector4_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKMatParamVector4 value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKMatParamVector4_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKMatParamVector4_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKMatParamVector4");
			return;
		}
		new TArrayCopyMarshaler<FName>(1, BrushPropertyNamePath_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BrushPropertyNamePath_Offset), BrushPropertyNamePath);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ComponentMaterialIndex_Offset), ComponentMaterialIndex);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, ValueFactor_Offset), ValueFactor);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public FGSAKMatParamVector4(IntPtr nativeStruct)
	{
		if (!FGSAKMatParamVector4_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKMatParamVector4");
			BrushPropertyNamePath = null;
			ComponentMaterialIndex = 0;
			ParamName = default(FName);
			ValueFactor = default(FLinearColor);
			Value = default(FLinearColor);
		}
		else
		{
			BrushPropertyNamePath = new TArrayCopyMarshaler<FName>(1, BrushPropertyNamePath_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BrushPropertyNamePath_Offset));
			ComponentMaterialIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ComponentMaterialIndex_Offset));
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			ValueFactor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, ValueFactor_Offset));
			Value = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FGSAKMatParamVector4()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKMatParamVector4)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKMatParamVector4));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKMatParamVector4");
		FGSAKMatParamVector4_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref BrushPropertyNamePath_PropertyAddress, intPtr, "BrushPropertyNamePath");
		BrushPropertyNamePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushPropertyNamePath");
		BrushPropertyNamePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushPropertyNamePath", Classes.FArrayProperty);
		ComponentMaterialIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentMaterialIndex");
		ComponentMaterialIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentMaterialIndex", Classes.FIntProperty);
		ParamName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		ValueFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValueFactor");
		ValueFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValueFactor", Classes.FStructProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		FGSAKMatParamVector4_IsValid = intPtr != IntPtr.Zero && BrushPropertyNamePath_IsValid && ComponentMaterialIndex_IsValid && ParamName_IsValid && ValueFactor_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKMatParamVector4", FGSAKMatParamVector4_IsValid);
	}
}
