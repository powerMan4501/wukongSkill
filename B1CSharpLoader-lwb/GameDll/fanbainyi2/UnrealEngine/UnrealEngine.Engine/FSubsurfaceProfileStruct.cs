using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SubsurfaceProfileStruct", "Engine", UnrealModuleType.Engine)]
public struct FSubsurfaceProfileStruct
{
	private static bool SurfaceAlbedo_IsValid;

	private static int SurfaceAlbedo_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:SurfaceAlbedo")]
	public FLinearColor SurfaceAlbedo;

	private static bool MeanFreePathColor_IsValid;

	private static int MeanFreePathColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:MeanFreePathColor")]
	public FLinearColor MeanFreePathColor;

	private static bool MeanFreePathDistance_IsValid;

	private static int MeanFreePathDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:MeanFreePathDistance")]
	public float MeanFreePathDistance;

	private static bool WorldUnitScale_IsValid;

	private static int WorldUnitScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:WorldUnitScale")]
	public float WorldUnitScale;

	private static bool EnableBurley_IsValid;

	private static FFieldAddress EnableBurley_PropertyAddress;

	private static int EnableBurley_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:bEnableBurley")]
	public bool EnableBurley;

	private static bool Tint_IsValid;

	private static int Tint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:Tint")]
	public FLinearColor Tint;

	private static bool ScatterRadius_IsValid;

	private static int ScatterRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:ScatterRadius")]
	public float ScatterRadius;

	private static bool SubsurfaceColor_IsValid;

	private static int SubsurfaceColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:SubsurfaceColor")]
	public FLinearColor SubsurfaceColor;

	private static bool FalloffColor_IsValid;

	private static int FalloffColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:FalloffColor")]
	public FLinearColor FalloffColor;

	private static bool BoundaryColorBleed_IsValid;

	private static int BoundaryColorBleed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:BoundaryColorBleed")]
	public FLinearColor BoundaryColorBleed;

	private static bool ExtinctionScale_IsValid;

	private static int ExtinctionScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:ExtinctionScale")]
	public float ExtinctionScale;

	private static bool NormalScale_IsValid;

	private static int NormalScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:NormalScale")]
	public float NormalScale;

	private static bool ScatteringDistribution_IsValid;

	private static int ScatteringDistribution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:ScatteringDistribution")]
	public float ScatteringDistribution;

	private static bool IOR_IsValid;

	private static int IOR_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:IOR")]
	public float IOR;

	private static bool Roughness0_IsValid;

	private static int Roughness0_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:Roughness0")]
	public float Roughness0;

	private static bool Roughness1_IsValid;

	private static int Roughness1_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:Roughness1")]
	public float Roughness1;

	private static bool LobeMix_IsValid;

	private static int LobeMix_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:LobeMix")]
	public float LobeMix;

	private static bool TransmissionTintColor_IsValid;

	private static int TransmissionTintColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubsurfaceProfileStruct:TransmissionTintColor")]
	public FLinearColor TransmissionTintColor;

	private static bool FSubsurfaceProfileStruct_IsValid;

	private static int FSubsurfaceProfileStruct_StructSize;

	public FSubsurfaceProfileStruct Copy()
	{
		return this;
	}

	public static FSubsurfaceProfileStruct FromNative(IntPtr nativeBuffer)
	{
		return new FSubsurfaceProfileStruct(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubsurfaceProfileStruct value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubsurfaceProfileStruct FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubsurfaceProfileStruct(nativeBuffer + arrayIndex * FSubsurfaceProfileStruct_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubsurfaceProfileStruct value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubsurfaceProfileStruct_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubsurfaceProfileStruct_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SubsurfaceProfileStruct");
			return;
		}
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, SurfaceAlbedo_Offset), SurfaceAlbedo);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, MeanFreePathColor_Offset), MeanFreePathColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MeanFreePathDistance_Offset), MeanFreePathDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WorldUnitScale_Offset), WorldUnitScale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableBurley_Offset), 0, EnableBurley_PropertyAddress.Address, EnableBurley);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Tint_Offset), Tint);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScatterRadius_Offset), ScatterRadius);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, SubsurfaceColor_Offset), SubsurfaceColor);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, FalloffColor_Offset), FalloffColor);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, BoundaryColorBleed_Offset), BoundaryColorBleed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ExtinctionScale_Offset), ExtinctionScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalScale_Offset), NormalScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScatteringDistribution_Offset), ScatteringDistribution);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, IOR_Offset), IOR);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Roughness0_Offset), Roughness0);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Roughness1_Offset), Roughness1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LobeMix_Offset), LobeMix);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, TransmissionTintColor_Offset), TransmissionTintColor);
	}

	public FSubsurfaceProfileStruct(IntPtr nativeStruct)
	{
		if (!FSubsurfaceProfileStruct_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SubsurfaceProfileStruct");
			SurfaceAlbedo = default(FLinearColor);
			MeanFreePathColor = default(FLinearColor);
			MeanFreePathDistance = 0f;
			WorldUnitScale = 0f;
			EnableBurley = false;
			Tint = default(FLinearColor);
			ScatterRadius = 0f;
			SubsurfaceColor = default(FLinearColor);
			FalloffColor = default(FLinearColor);
			BoundaryColorBleed = default(FLinearColor);
			ExtinctionScale = 0f;
			NormalScale = 0f;
			ScatteringDistribution = 0f;
			IOR = 0f;
			Roughness0 = 0f;
			Roughness1 = 0f;
			LobeMix = 0f;
			TransmissionTintColor = default(FLinearColor);
		}
		else
		{
			SurfaceAlbedo = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, SurfaceAlbedo_Offset));
			MeanFreePathColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, MeanFreePathColor_Offset));
			MeanFreePathDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MeanFreePathDistance_Offset));
			WorldUnitScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WorldUnitScale_Offset));
			EnableBurley = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableBurley_Offset), 0, EnableBurley_PropertyAddress.Address);
			Tint = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Tint_Offset));
			ScatterRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScatterRadius_Offset));
			SubsurfaceColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, SubsurfaceColor_Offset));
			FalloffColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, FalloffColor_Offset));
			BoundaryColorBleed = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, BoundaryColorBleed_Offset));
			ExtinctionScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ExtinctionScale_Offset));
			NormalScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalScale_Offset));
			ScatteringDistribution = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScatteringDistribution_Offset));
			IOR = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, IOR_Offset));
			Roughness0 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Roughness0_Offset));
			Roughness1 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Roughness1_Offset));
			LobeMix = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LobeMix_Offset));
			TransmissionTintColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, TransmissionTintColor_Offset));
		}
	}

	static FSubsurfaceProfileStruct()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubsurfaceProfileStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubsurfaceProfileStruct));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SubsurfaceProfileStruct");
		FSubsurfaceProfileStruct_StructSize = NativeReflection.GetStructSize(intPtr);
		SurfaceAlbedo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SurfaceAlbedo");
		SurfaceAlbedo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SurfaceAlbedo", Classes.FStructProperty);
		MeanFreePathColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeanFreePathColor");
		MeanFreePathColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeanFreePathColor", Classes.FStructProperty);
		MeanFreePathDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeanFreePathDistance");
		MeanFreePathDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeanFreePathDistance", Classes.FFloatProperty);
		WorldUnitScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WorldUnitScale");
		WorldUnitScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WorldUnitScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableBurley_PropertyAddress, intPtr, "bEnableBurley");
		EnableBurley_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableBurley");
		EnableBurley_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableBurley", Classes.FBoolProperty);
		Tint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tint");
		Tint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tint", Classes.FStructProperty);
		ScatterRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScatterRadius");
		ScatterRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScatterRadius", Classes.FFloatProperty);
		SubsurfaceColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubsurfaceColor");
		SubsurfaceColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubsurfaceColor", Classes.FStructProperty);
		FalloffColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FalloffColor");
		FalloffColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FalloffColor", Classes.FStructProperty);
		BoundaryColorBleed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoundaryColorBleed");
		BoundaryColorBleed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoundaryColorBleed", Classes.FStructProperty);
		ExtinctionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExtinctionScale");
		ExtinctionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExtinctionScale", Classes.FFloatProperty);
		NormalScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalScale");
		NormalScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalScale", Classes.FFloatProperty);
		ScatteringDistribution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScatteringDistribution");
		ScatteringDistribution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScatteringDistribution", Classes.FFloatProperty);
		IOR_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IOR");
		IOR_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IOR", Classes.FFloatProperty);
		Roughness0_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Roughness0");
		Roughness0_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Roughness0", Classes.FFloatProperty);
		Roughness1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Roughness1");
		Roughness1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Roughness1", Classes.FFloatProperty);
		LobeMix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LobeMix");
		LobeMix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LobeMix", Classes.FFloatProperty);
		TransmissionTintColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransmissionTintColor");
		TransmissionTintColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransmissionTintColor", Classes.FStructProperty);
		FSubsurfaceProfileStruct_IsValid = intPtr != IntPtr.Zero && SurfaceAlbedo_IsValid && MeanFreePathColor_IsValid && MeanFreePathDistance_IsValid && WorldUnitScale_IsValid && EnableBurley_IsValid && Tint_IsValid && ScatterRadius_IsValid && SubsurfaceColor_IsValid && FalloffColor_IsValid && BoundaryColorBleed_IsValid && ExtinctionScale_IsValid && NormalScale_IsValid && ScatteringDistribution_IsValid && IOR_IsValid && Roughness0_IsValid && Roughness1_IsValid && LobeMix_IsValid && TransmissionTintColor_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SubsurfaceProfileStruct", FSubsurfaceProfileStruct_IsValid);
	}
}
