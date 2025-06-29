using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SynthSlateStyle", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSynthSlateStyle
{
	private static bool SizeType_IsValid;

	private static FFieldAddress SizeType_PropertyAddress;

	private static int SizeType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SynthSlateStyle:SizeType")]
	public ESynthSlateSizeType SizeType;

	private static bool ColorStyle_IsValid;

	private static FFieldAddress ColorStyle_PropertyAddress;

	private static int ColorStyle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SynthSlateStyle:ColorStyle")]
	public ESynthSlateColorStyle ColorStyle;

	private static bool FSynthSlateStyle_IsValid;

	private static int FSynthSlateStyle_StructSize;

	public FSynthSlateStyle Copy()
	{
		return this;
	}

	public static FSynthSlateStyle FromNative(IntPtr nativeBuffer)
	{
		return new FSynthSlateStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSynthSlateStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSynthSlateStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSynthSlateStyle(nativeBuffer + arrayIndex * FSynthSlateStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSynthSlateStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSynthSlateStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSynthSlateStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SynthSlateStyle");
			return;
		}
		EnumMarshaler<ESynthSlateSizeType>.ToNative(IntPtr.Add(nativeStruct, SizeType_Offset), 0, SizeType_PropertyAddress.Address, SizeType);
		EnumMarshaler<ESynthSlateColorStyle>.ToNative(IntPtr.Add(nativeStruct, ColorStyle_Offset), 0, ColorStyle_PropertyAddress.Address, ColorStyle);
	}

	public FSynthSlateStyle(IntPtr nativeStruct)
	{
		if (!FSynthSlateStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SynthSlateStyle");
			SizeType = ESynthSlateSizeType.Small;
			ColorStyle = ESynthSlateColorStyle.Light;
		}
		else
		{
			SizeType = EnumMarshaler<ESynthSlateSizeType>.FromNative(IntPtr.Add(nativeStruct, SizeType_Offset), 0, SizeType_PropertyAddress.Address);
			ColorStyle = EnumMarshaler<ESynthSlateColorStyle>.FromNative(IntPtr.Add(nativeStruct, ColorStyle_Offset), 0, ColorStyle_PropertyAddress.Address);
		}
	}

	static FSynthSlateStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSynthSlateStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSynthSlateStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SynthSlateStyle");
		FSynthSlateStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SizeType_PropertyAddress, intPtr, "SizeType");
		SizeType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SizeType");
		SizeType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SizeType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ColorStyle_PropertyAddress, intPtr, "ColorStyle");
		ColorStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorStyle");
		ColorStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorStyle", Classes.FEnumProperty);
		FSynthSlateStyle_IsValid = intPtr != IntPtr.Zero && SizeType_IsValid && ColorStyle_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SynthSlateStyle", FSynthSlateStyle_IsValid);
	}
}
