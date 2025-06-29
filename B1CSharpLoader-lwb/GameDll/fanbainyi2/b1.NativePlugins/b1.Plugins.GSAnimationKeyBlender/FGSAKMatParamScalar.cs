using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamScalar", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKMatParamScalar
{
	private static bool BrushPropertyNamePath_IsValid;

	private static FFieldAddress BrushPropertyNamePath_PropertyAddress;

	private static int BrushPropertyNamePath_Offset;

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamScalar:BrushPropertyNamePath")]
	public List<FName> BrushPropertyNamePath;

	private static bool ComponentMaterialIndex_IsValid;

	private static int ComponentMaterialIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamScalar:ComponentMaterialIndex")]
	public int ComponentMaterialIndex;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamScalar:ParamName")]
	public FName ParamName;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAKMatParamScalar:Value")]
	public float Value;

	private static bool FGSAKMatParamScalar_IsValid;

	private static int FGSAKMatParamScalar_StructSize;

	public FGSAKMatParamScalar Copy()
	{
		FGSAKMatParamScalar result = this;
		if (BrushPropertyNamePath != null)
		{
			result.BrushPropertyNamePath = new List<FName>(BrushPropertyNamePath);
		}
		return result;
	}

	public static FGSAKMatParamScalar FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKMatParamScalar(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKMatParamScalar value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKMatParamScalar FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKMatParamScalar(nativeBuffer + arrayIndex * FGSAKMatParamScalar_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKMatParamScalar value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKMatParamScalar_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKMatParamScalar_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKMatParamScalar");
			return;
		}
		new TArrayCopyMarshaler<FName>(1, BrushPropertyNamePath_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BrushPropertyNamePath_Offset), BrushPropertyNamePath);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ComponentMaterialIndex_Offset), ComponentMaterialIndex);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public FGSAKMatParamScalar(IntPtr nativeStruct)
	{
		if (!FGSAKMatParamScalar_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKMatParamScalar");
			BrushPropertyNamePath = null;
			ComponentMaterialIndex = 0;
			ParamName = default(FName);
			Value = 0f;
		}
		else
		{
			BrushPropertyNamePath = new TArrayCopyMarshaler<FName>(1, BrushPropertyNamePath_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BrushPropertyNamePath_Offset));
			ComponentMaterialIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ComponentMaterialIndex_Offset));
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FGSAKMatParamScalar()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKMatParamScalar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKMatParamScalar));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKMatParamScalar");
		FGSAKMatParamScalar_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref BrushPropertyNamePath_PropertyAddress, intPtr, "BrushPropertyNamePath");
		BrushPropertyNamePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushPropertyNamePath");
		BrushPropertyNamePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushPropertyNamePath", Classes.FArrayProperty);
		ComponentMaterialIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentMaterialIndex");
		ComponentMaterialIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentMaterialIndex", Classes.FIntProperty);
		ParamName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		FGSAKMatParamScalar_IsValid = intPtr != IntPtr.Zero && BrushPropertyNamePath_IsValid && ComponentMaterialIndex_IsValid && ParamName_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKMatParamScalar", FGSAKMatParamScalar_IsValid);
	}
}
