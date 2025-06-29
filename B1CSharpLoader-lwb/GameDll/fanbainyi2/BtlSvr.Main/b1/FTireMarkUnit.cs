using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TireMarkUnit")]
public struct FTireMarkUnit
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.TireMarkUnit:DecalComp")]
	public UDecalComponent DecalComp;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TireMarkUnit:SocketName")]
	public FName SocketName;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TireMarkUnit:SpawnPos")]
	public FVector SpawnPos;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TireMarkUnit:OriDecalLength")]
	public float OriDecalLength;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TireMarkUnit:DelayFadeTimer")]
	public float DelayFadeTimer;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TireMarkUnit:FadeTime")]
	public float FadeTime;

	private static int TireMarkUnit_StructSize;

	private static int TireMarkUnit_IsValid;

	private static bool DecalComp_IsValid;

	private static int DecalComp_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool SpawnPos_IsValid;

	private static int SpawnPos_Offset;

	private static bool OriDecalLength_IsValid;

	private static int OriDecalLength_Offset;

	private static bool DelayFadeTimer_IsValid;

	private static int DelayFadeTimer_Offset;

	private static bool FadeTime_IsValid;

	private static int FadeTime_Offset;

	public FTireMarkUnit Copy()
	{
		return this;
	}

	public static FTireMarkUnit FromNative(IntPtr nativeBuffer)
	{
		return new FTireMarkUnit(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTireMarkUnit value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTireMarkUnit FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTireMarkUnit(IntPtr.Add(nativeBuffer, arrayIndex * TireMarkUnit_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTireMarkUnit value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TireMarkUnit_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TireMarkUnit_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TireMarkUnit");
			return;
		}
		UObjectMarshaler<UDecalComponent>.ToNative(IntPtr.Add(nativeStruct, DecalComp_Offset), DecalComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SpawnPos_Offset), SpawnPos);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OriDecalLength_Offset), OriDecalLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayFadeTimer_Offset), DelayFadeTimer);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FadeTime_Offset), FadeTime);
	}

	public FTireMarkUnit(IntPtr nativeStruct)
	{
		if (TireMarkUnit_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TireMarkUnit");
			DecalComp = null;
			SocketName = default(FName);
			SpawnPos = default(FVector);
			OriDecalLength = 0f;
			DelayFadeTimer = 0f;
			FadeTime = 0f;
		}
		else
		{
			DecalComp = UObjectMarshaler<UDecalComponent>.FromNative(IntPtr.Add(nativeStruct, DecalComp_Offset));
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			SpawnPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SpawnPos_Offset));
			OriDecalLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OriDecalLength_Offset));
			DelayFadeTimer = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayFadeTimer_Offset));
			FadeTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FadeTime_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TireMarkUnit");
		TireMarkUnit_StructSize = NativeReflection.GetStructSize(intPtr);
		DecalComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DecalComp");
		DecalComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DecalComp", Classes.FObjectProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		SpawnPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPos");
		SpawnPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPos", Classes.FStructProperty);
		OriDecalLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "OriDecalLength");
		OriDecalLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OriDecalLength", Classes.FFloatProperty);
		DelayFadeTimer_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayFadeTimer");
		DelayFadeTimer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayFadeTimer", Classes.FFloatProperty);
		FadeTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "FadeTime");
		FadeTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FadeTime", Classes.FFloatProperty);
		TireMarkUnit_IsValid = ((intPtr != IntPtr.Zero && DecalComp_IsValid && SocketName_IsValid && SpawnPos_IsValid && OriDecalLength_IsValid && DelayFadeTimer_IsValid && FadeTime_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TireMarkUnit", (byte)TireMarkUnit_IsValid != 0);
	}

	static FTireMarkUnit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTireMarkUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTireMarkUnit));
	}
}
