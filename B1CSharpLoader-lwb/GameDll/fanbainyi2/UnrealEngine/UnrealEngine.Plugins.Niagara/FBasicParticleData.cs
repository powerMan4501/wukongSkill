using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Niagara.BasicParticleData", "Niagara", UnrealModuleType.EnginePlugin)]
public struct FBasicParticleData
{
	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Niagara.BasicParticleData:Position")]
	public FVector Position;

	private static bool Size_IsValid;

	private static int Size_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Niagara.BasicParticleData:Size")]
	public float Size;

	private static bool Velocity_IsValid;

	private static int Velocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Niagara.BasicParticleData:Velocity")]
	public FVector Velocity;

	private static bool FBasicParticleData_IsValid;

	private static int FBasicParticleData_StructSize;

	public FBasicParticleData Copy()
	{
		return this;
	}

	public static FBasicParticleData FromNative(IntPtr nativeBuffer)
	{
		return new FBasicParticleData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBasicParticleData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBasicParticleData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBasicParticleData(nativeBuffer + arrayIndex * FBasicParticleData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBasicParticleData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBasicParticleData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBasicParticleData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Niagara.BasicParticleData");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Size_Offset), Size);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Velocity_Offset), Velocity);
	}

	public FBasicParticleData(IntPtr nativeStruct)
	{
		if (!FBasicParticleData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Niagara.BasicParticleData");
			Position = default(FVector);
			Size = 0f;
			Velocity = default(FVector);
		}
		else
		{
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
			Size = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Size_Offset));
			Velocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Velocity_Offset));
		}
	}

	static FBasicParticleData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBasicParticleData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBasicParticleData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Niagara.BasicParticleData");
		FBasicParticleData_StructSize = NativeReflection.GetStructSize(intPtr);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Size", Classes.FFloatProperty);
		Velocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Velocity");
		Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Velocity", Classes.FStructProperty);
		FBasicParticleData_IsValid = intPtr != IntPtr.Zero && Position_IsValid && Size_IsValid && Velocity_IsValid;
		NativeReflection.LogStructIsValid("/Script/Niagara.BasicParticleData", FBasicParticleData_IsValid);
	}
}
