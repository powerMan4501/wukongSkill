using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSNiagara;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfo", "GSNiagara", UnrealModuleType.GamePlugin)]
public struct FGSNiagaraParticleInfo
{
	private static bool ParticleType_IsValid;

	private static int ParticleType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfo:ParticleType")]
	public int ParticleType;

	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfo:Position")]
	public FVector Position;

	private static bool Size_IsValid;

	private static int Size_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfo:Size")]
	public FVector Size;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfo:Duration")]
	public float Duration;

	private static bool Color_IsValid;

	private static int Color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfo:Color")]
	public FLinearColor Color;

	private static bool Intensity_IsValid;

	private static int Intensity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfo:Intensity")]
	public float Intensity;

	private static bool FGSNiagaraParticleInfo_IsValid;

	private static int FGSNiagaraParticleInfo_StructSize;

	public FGSNiagaraParticleInfo Copy()
	{
		return this;
	}

	public static FGSNiagaraParticleInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSNiagaraParticleInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSNiagaraParticleInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSNiagaraParticleInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSNiagaraParticleInfo(nativeBuffer + arrayIndex * FGSNiagaraParticleInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSNiagaraParticleInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSNiagaraParticleInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSNiagaraParticleInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSNiagara.GSNiagaraParticleInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ParticleType_Offset), ParticleType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Size_Offset), Size);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Color_Offset), Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Intensity_Offset), Intensity);
	}

	public FGSNiagaraParticleInfo(IntPtr nativeStruct)
	{
		if (!FGSNiagaraParticleInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSNiagara.GSNiagaraParticleInfo");
			ParticleType = 0;
			Position = default(FVector);
			Size = default(FVector);
			Duration = 0f;
			Color = default(FLinearColor);
			Intensity = 0f;
		}
		else
		{
			ParticleType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ParticleType_Offset));
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
			Size = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Size_Offset));
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			Color = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Color_Offset));
			Intensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Intensity_Offset));
		}
	}

	static FGSNiagaraParticleInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSNiagaraParticleInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSNiagaraParticleInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSNiagara.GSNiagaraParticleInfo");
		FGSNiagaraParticleInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ParticleType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleType");
		ParticleType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleType", Classes.FIntProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Size", Classes.FStructProperty);
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		Color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Color");
		Color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Color", Classes.FStructProperty);
		Intensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Intensity");
		Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Intensity", Classes.FFloatProperty);
		FGSNiagaraParticleInfo_IsValid = intPtr != IntPtr.Zero && ParticleType_IsValid && Position_IsValid && Size_IsValid && Duration_IsValid && Color_IsValid && Intensity_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSNiagara.GSNiagaraParticleInfo", FGSNiagaraParticleInfo_IsValid);
	}
}
