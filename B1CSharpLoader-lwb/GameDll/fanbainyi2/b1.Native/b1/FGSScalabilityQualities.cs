using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSScalabilityQualities
{
	private static bool ResolutionQualityScale_IsValid;

	private static int ResolutionQualityScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities:ResolutionQualityScale")]
	public float ResolutionQualityScale;

	private static bool ViewDistanceQuality_IsValid;

	private static FFieldAddress ViewDistanceQuality_PropertyAddress;

	private static int ViewDistanceQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities:ViewDistanceQuality")]
	public EScalabilityQuality ViewDistanceQuality;

	private static bool AntiAliasingQuality_IsValid;

	private static FFieldAddress AntiAliasingQuality_PropertyAddress;

	private static int AntiAliasingQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities:AntiAliasingQuality")]
	public EScalabilityQuality AntiAliasingQuality;

	private static bool ShadowQuality_IsValid;

	private static FFieldAddress ShadowQuality_PropertyAddress;

	private static int ShadowQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities:ShadowQuality")]
	public EScalabilityQuality ShadowQuality;

	private static bool PostProcessQuality_IsValid;

	private static FFieldAddress PostProcessQuality_PropertyAddress;

	private static int PostProcessQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities:PostProcessQuality")]
	public EScalabilityQuality PostProcessQuality;

	private static bool TextureQuality_IsValid;

	private static FFieldAddress TextureQuality_PropertyAddress;

	private static int TextureQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities:TextureQuality")]
	public EScalabilityQuality TextureQuality;

	private static bool EffectsQuality_IsValid;

	private static FFieldAddress EffectsQuality_PropertyAddress;

	private static int EffectsQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities:EffectsQuality")]
	public EScalabilityQuality EffectsQuality;

	private static bool FoliageQuality_IsValid;

	private static FFieldAddress FoliageQuality_PropertyAddress;

	private static int FoliageQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities:FoliageQuality")]
	public EScalabilityQuality FoliageQuality;

	private static bool ShadingQuality_IsValid;

	private static FFieldAddress ShadingQuality_PropertyAddress;

	private static int ShadingQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities:ShadingQuality")]
	public EScalabilityQuality ShadingQuality;

	private static bool GlobalIlluminationQuality_IsValid;

	private static FFieldAddress GlobalIlluminationQuality_PropertyAddress;

	private static int GlobalIlluminationQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities:GlobalIlluminationQuality")]
	public EScalabilityQuality GlobalIlluminationQuality;

	private static bool ReflectionQuality_IsValid;

	private static FFieldAddress ReflectionQuality_PropertyAddress;

	private static int ReflectionQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSScalabilityQualities:ReflectionQuality")]
	public EScalabilityQuality ReflectionQuality;

	private static int FGSScalabilityQualities_StructSize;

	public FGSScalabilityQualities Copy()
	{
		return this;
	}

	static FGSScalabilityQualities()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSScalabilityQualities)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSScalabilityQualities));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/UnrealExtent.GSScalabilityQualities");
		FGSScalabilityQualities_StructSize = NativeReflection.GetStructSize(unrealStruct);
		ResolutionQualityScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ResolutionQualityScale");
		ResolutionQualityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ResolutionQualityScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ViewDistanceQuality_PropertyAddress, unrealStruct, "ViewDistanceQuality");
		ViewDistanceQuality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ViewDistanceQuality");
		ViewDistanceQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ViewDistanceQuality", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AntiAliasingQuality_PropertyAddress, unrealStruct, "AntiAliasingQuality");
		AntiAliasingQuality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AntiAliasingQuality");
		AntiAliasingQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AntiAliasingQuality", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ShadowQuality_PropertyAddress, unrealStruct, "ShadowQuality");
		ShadowQuality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ShadowQuality");
		ShadowQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ShadowQuality", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref PostProcessQuality_PropertyAddress, unrealStruct, "PostProcessQuality");
		PostProcessQuality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PostProcessQuality");
		PostProcessQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PostProcessQuality", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref TextureQuality_PropertyAddress, unrealStruct, "TextureQuality");
		TextureQuality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TextureQuality");
		TextureQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TextureQuality", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EffectsQuality_PropertyAddress, unrealStruct, "EffectsQuality");
		EffectsQuality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EffectsQuality");
		EffectsQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EffectsQuality", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FoliageQuality_PropertyAddress, unrealStruct, "FoliageQuality");
		FoliageQuality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FoliageQuality");
		FoliageQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FoliageQuality", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ShadingQuality_PropertyAddress, unrealStruct, "ShadingQuality");
		ShadingQuality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ShadingQuality");
		ShadingQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ShadingQuality", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GlobalIlluminationQuality_PropertyAddress, unrealStruct, "GlobalIlluminationQuality");
		GlobalIlluminationQuality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GlobalIlluminationQuality");
		GlobalIlluminationQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GlobalIlluminationQuality", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ReflectionQuality_PropertyAddress, unrealStruct, "ReflectionQuality");
		ReflectionQuality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ReflectionQuality");
		ReflectionQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ReflectionQuality", Classes.FEnumProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGSScalabilityQualities));
	}
}
