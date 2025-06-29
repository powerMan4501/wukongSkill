using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.FontGSSoftShadowCfg", "SlateCore", UnrealModuleType.Engine)]
public struct FFontGSSoftShadowCfg
{
	private static bool GSSoftShadowV2Layout_IsValid;

	private static FFieldAddress GSSoftShadowV2Layout_PropertyAddress;

	private static int GSSoftShadowV2Layout_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.FontGSSoftShadowCfg:GSSoftShadowV2Layout")]
	public bool GSSoftShadowV2Layout;

	private static bool GSSoftShadowType_IsValid;

	private static FFieldAddress GSSoftShadowType_PropertyAddress;

	private static int GSSoftShadowType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.FontGSSoftShadowCfg:GSSoftShadowType")]
	public EGSSoftShadowType GSSoftShadowType;

	private static bool GSSoftShadowSize_IsValid;

	private static int GSSoftShadowSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.FontGSSoftShadowCfg:GSSoftShadowSize")]
	public int GSSoftShadowSize;

	private static bool GSSoftShadowOffset_IsValid;

	private static int GSSoftShadowOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.FontGSSoftShadowCfg:GSSoftShadowOffset")]
	public FIntPoint GSSoftShadowOffset;

	private static bool GSSoftShadowFactor_IsValid;

	private static int GSSoftShadowFactor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.FontGSSoftShadowCfg:GSSoftShadowFactor")]
	public int GSSoftShadowFactor;

	private static bool GSSoftShadowColor_IsValid;

	private static int GSSoftShadowColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.FontGSSoftShadowCfg:GSSoftShadowColor")]
	public FLinearColor GSSoftShadowColor;

	private static bool FFontGSSoftShadowCfg_IsValid;

	private static int FFontGSSoftShadowCfg_StructSize;

	public FFontGSSoftShadowCfg Copy()
	{
		return this;
	}

	public static FFontGSSoftShadowCfg FromNative(IntPtr nativeBuffer)
	{
		return new FFontGSSoftShadowCfg(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFontGSSoftShadowCfg value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFontGSSoftShadowCfg FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFontGSSoftShadowCfg(nativeBuffer + arrayIndex * FFontGSSoftShadowCfg_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFontGSSoftShadowCfg value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFontGSSoftShadowCfg_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFontGSSoftShadowCfg_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.FontGSSoftShadowCfg");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GSSoftShadowV2Layout_Offset), 0, GSSoftShadowV2Layout_PropertyAddress.Address, GSSoftShadowV2Layout);
		EnumMarshaler<EGSSoftShadowType>.ToNative(IntPtr.Add(nativeStruct, GSSoftShadowType_Offset), 0, GSSoftShadowType_PropertyAddress.Address, GSSoftShadowType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GSSoftShadowSize_Offset), GSSoftShadowSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, GSSoftShadowOffset_Offset), GSSoftShadowOffset);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GSSoftShadowFactor_Offset), GSSoftShadowFactor);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, GSSoftShadowColor_Offset), GSSoftShadowColor);
	}

	public FFontGSSoftShadowCfg(IntPtr nativeStruct)
	{
		if (!FFontGSSoftShadowCfg_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.FontGSSoftShadowCfg");
			GSSoftShadowV2Layout = false;
			GSSoftShadowType = EGSSoftShadowType.EGSSoftShadowNone;
			GSSoftShadowSize = 0;
			GSSoftShadowOffset = default(FIntPoint);
			GSSoftShadowFactor = 0;
			GSSoftShadowColor = default(FLinearColor);
		}
		else
		{
			GSSoftShadowV2Layout = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GSSoftShadowV2Layout_Offset), 0, GSSoftShadowV2Layout_PropertyAddress.Address);
			GSSoftShadowType = EnumMarshaler<EGSSoftShadowType>.FromNative(IntPtr.Add(nativeStruct, GSSoftShadowType_Offset), 0, GSSoftShadowType_PropertyAddress.Address);
			GSSoftShadowSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GSSoftShadowSize_Offset));
			GSSoftShadowOffset = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, GSSoftShadowOffset_Offset));
			GSSoftShadowFactor = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GSSoftShadowFactor_Offset));
			GSSoftShadowColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, GSSoftShadowColor_Offset));
		}
	}

	static FFontGSSoftShadowCfg()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFontGSSoftShadowCfg)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFontGSSoftShadowCfg));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.FontGSSoftShadowCfg");
		FFontGSSoftShadowCfg_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref GSSoftShadowV2Layout_PropertyAddress, intPtr, "GSSoftShadowV2Layout");
		GSSoftShadowV2Layout_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSSoftShadowV2Layout");
		GSSoftShadowV2Layout_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSSoftShadowV2Layout", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GSSoftShadowType_PropertyAddress, intPtr, "GSSoftShadowType");
		GSSoftShadowType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSSoftShadowType");
		GSSoftShadowType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSSoftShadowType", Classes.FEnumProperty);
		GSSoftShadowSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSSoftShadowSize");
		GSSoftShadowSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSSoftShadowSize", Classes.FIntProperty);
		GSSoftShadowOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSSoftShadowOffset");
		GSSoftShadowOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSSoftShadowOffset", Classes.FStructProperty);
		GSSoftShadowFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSSoftShadowFactor");
		GSSoftShadowFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSSoftShadowFactor", Classes.FIntProperty);
		GSSoftShadowColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSSoftShadowColor");
		GSSoftShadowColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSSoftShadowColor", Classes.FStructProperty);
		FFontGSSoftShadowCfg_IsValid = intPtr != IntPtr.Zero && GSSoftShadowV2Layout_IsValid && GSSoftShadowType_IsValid && GSSoftShadowSize_IsValid && GSSoftShadowOffset_IsValid && GSSoftShadowFactor_IsValid && GSSoftShadowColor_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.FontGSSoftShadowCfg", FFontGSSoftShadowCfg_IsValid);
	}
}
