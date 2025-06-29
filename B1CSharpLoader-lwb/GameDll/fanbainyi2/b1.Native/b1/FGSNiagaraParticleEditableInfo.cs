using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.GSNiagaraParticleEditableInfo", "FuncLibEditor", UnrealModuleType.Game)]
public struct FGSNiagaraParticleEditableInfo
{
	private static bool ParticleType_IsValid;

	private static int ParticleType_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/FuncLibEditor.GSNiagaraParticleEditableInfo:ParticleType")]
	public int ParticleType;

	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSNiagaraParticleEditableInfo:Position")]
	public FVector Position;

	private static bool Size_IsValid;

	private static int Size_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSNiagaraParticleEditableInfo:Size")]
	public float Size;

	private static bool FGSNiagaraParticleEditableInfo_IsValid;

	private static int FGSNiagaraParticleEditableInfo_StructSize;

	public FGSNiagaraParticleEditableInfo Copy()
	{
		return this;
	}

	public static FGSNiagaraParticleEditableInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSNiagaraParticleEditableInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSNiagaraParticleEditableInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSNiagaraParticleEditableInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSNiagaraParticleEditableInfo(nativeBuffer + arrayIndex * FGSNiagaraParticleEditableInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSNiagaraParticleEditableInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSNiagaraParticleEditableInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSNiagaraParticleEditableInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.GSNiagaraParticleEditableInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ParticleType_Offset), ParticleType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Size_Offset), Size);
	}

	public FGSNiagaraParticleEditableInfo(IntPtr nativeStruct)
	{
		if (!FGSNiagaraParticleEditableInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.GSNiagaraParticleEditableInfo");
			ParticleType = 0;
			Position = default(FVector);
			Size = 0f;
		}
		else
		{
			ParticleType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ParticleType_Offset));
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
			Size = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Size_Offset));
		}
	}

	static FGSNiagaraParticleEditableInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSNiagaraParticleEditableInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSNiagaraParticleEditableInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.GSNiagaraParticleEditableInfo");
		FGSNiagaraParticleEditableInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ParticleType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleType");
		ParticleType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleType", Classes.FIntProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Size", Classes.FFloatProperty);
		FGSNiagaraParticleEditableInfo_IsValid = intPtr != IntPtr.Zero && ParticleType_IsValid && Position_IsValid && Size_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.GSNiagaraParticleEditableInfo", FGSNiagaraParticleEditableInfo_IsValid);
	}
}
