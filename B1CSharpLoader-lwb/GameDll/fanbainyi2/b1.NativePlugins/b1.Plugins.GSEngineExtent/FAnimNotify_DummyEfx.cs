using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.AnimNotify_DummyEfx", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public struct FAnimNotify_DummyEfx
{
	private static bool PSTemplate_IsValid;

	private static int PSTemplate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNotify_DummyEfx:PSTemplate")]
	public UParticleSystem PSTemplate;

	private static bool Socket_IsValid;

	private static FFieldAddress Socket_PropertyAddress;

	private static int Socket_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNotify_DummyEfx:Socket")]
	public EDummySocket Socket;

	private static bool LocationOffset_IsValid;

	private static int LocationOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNotify_DummyEfx:LocationOffset")]
	public FVector LocationOffset;

	private static bool RotationOffset_IsValid;

	private static int RotationOffset_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNotify_DummyEfx:RotationOffset")]
	public FRotator RotationOffset;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNotify_DummyEfx:Scale")]
	public FVector Scale;

	private static bool FAnimNotify_DummyEfx_IsValid;

	private static int FAnimNotify_DummyEfx_StructSize;

	public FAnimNotify_DummyEfx Copy()
	{
		return this;
	}

	public static FAnimNotify_DummyEfx FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNotify_DummyEfx(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNotify_DummyEfx value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNotify_DummyEfx FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNotify_DummyEfx(nativeBuffer + arrayIndex * FAnimNotify_DummyEfx_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNotify_DummyEfx value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNotify_DummyEfx_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNotify_DummyEfx_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.AnimNotify_DummyEfx");
			return;
		}
		UObjectMarshaler<UParticleSystem>.ToNative(IntPtr.Add(nativeStruct, PSTemplate_Offset), PSTemplate);
		EnumMarshaler<EDummySocket>.ToNative(IntPtr.Add(nativeStruct, Socket_Offset), 0, Socket_PropertyAddress.Address, Socket);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LocationOffset_Offset), LocationOffset);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, RotationOffset_Offset), RotationOffset);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
	}

	public FAnimNotify_DummyEfx(IntPtr nativeStruct)
	{
		if (!FAnimNotify_DummyEfx_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.AnimNotify_DummyEfx");
			PSTemplate = null;
			Socket = EDummySocket.Pt01_Socket;
			LocationOffset = default(FVector);
			RotationOffset = default(FRotator);
			Scale = default(FVector);
		}
		else
		{
			PSTemplate = UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(nativeStruct, PSTemplate_Offset));
			Socket = EnumMarshaler<EDummySocket>.FromNative(IntPtr.Add(nativeStruct, Socket_Offset), 0, Socket_PropertyAddress.Address);
			LocationOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LocationOffset_Offset));
			RotationOffset = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, RotationOffset_Offset));
			Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
		}
	}

	static FAnimNotify_DummyEfx()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNotify_DummyEfx)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNotify_DummyEfx));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEngineExtent.AnimNotify_DummyEfx");
		FAnimNotify_DummyEfx_StructSize = NativeReflection.GetStructSize(intPtr);
		PSTemplate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PSTemplate");
		PSTemplate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PSTemplate", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Socket_PropertyAddress, intPtr, "Socket");
		Socket_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Socket");
		Socket_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Socket", Classes.FEnumProperty);
		LocationOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocationOffset");
		LocationOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocationOffset", Classes.FStructProperty);
		RotationOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationOffset");
		RotationOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationOffset", Classes.FStructProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		FAnimNotify_DummyEfx_IsValid = intPtr != IntPtr.Zero && PSTemplate_IsValid && Socket_IsValid && LocationOffset_IsValid && RotationOffset_IsValid && Scale_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSEngineExtent.AnimNotify_DummyEfx", FAnimNotify_DummyEfx_IsValid);
	}
}
