using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSConnectionInfo", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSConnectionInfo
{
	private static bool URLInfo_IsValid;

	private static int URLInfo_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealExtent.GSConnectionInfo:URLInfo")]
	public string URLInfo;

	private static bool InSpeedByte_IsValid;

	private static int InSpeedByte_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GSConnectionInfo:InSpeedByte")]
	public int InSpeedByte;

	private static bool OutSpeedByte_IsValid;

	private static int OutSpeedByte_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GSConnectionInfo:OutSpeedByte")]
	public int OutSpeedByte;

	private static bool NetLagMS_IsValid;

	private static int NetLagMS_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GSConnectionInfo:NetLagMS")]
	public double NetLagMS;

	private static bool PlayerId_IsValid;

	private static int PlayerId_Offset;

	[UProperty(Flags = (PropFlags)6755399441055748uL)]
	[UMetaPath("/Script/UnrealExtent.GSConnectionInfo:PlayerId")]
	public FUniqueNetIdRepl PlayerId;

	private static bool PktLostRate_IsValid;

	private static int PktLostRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GSConnectionInfo:PktLostRate")]
	public float PktLostRate;

	private static bool FGSConnectionInfo_IsValid;

	private static int FGSConnectionInfo_StructSize;

	public FGSConnectionInfo Copy()
	{
		return this;
	}

	public static FGSConnectionInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSConnectionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSConnectionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSConnectionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSConnectionInfo(nativeBuffer + arrayIndex * FGSConnectionInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSConnectionInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSConnectionInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSConnectionInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSConnectionInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, URLInfo_Offset), URLInfo);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InSpeedByte_Offset), InSpeedByte);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OutSpeedByte_Offset), OutSpeedByte);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, NetLagMS_Offset), NetLagMS);
		FUniqueNetIdRepl.ToNative(IntPtr.Add(nativeStruct, PlayerId_Offset), PlayerId);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PktLostRate_Offset), PktLostRate);
	}

	public FGSConnectionInfo(IntPtr nativeStruct)
	{
		if (!FGSConnectionInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSConnectionInfo");
			URLInfo = FStringMarshaler.DefaultString;
			InSpeedByte = 0;
			OutSpeedByte = 0;
			NetLagMS = 0.0;
			PlayerId = default(FUniqueNetIdRepl);
			PktLostRate = 0f;
		}
		else
		{
			URLInfo = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, URLInfo_Offset));
			InSpeedByte = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InSpeedByte_Offset));
			OutSpeedByte = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OutSpeedByte_Offset));
			NetLagMS = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(nativeStruct, NetLagMS_Offset));
			PlayerId = FUniqueNetIdRepl.FromNative(IntPtr.Add(nativeStruct, PlayerId_Offset));
			PktLostRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PktLostRate_Offset));
		}
	}

	static FGSConnectionInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSConnectionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSConnectionInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GSConnectionInfo");
		FGSConnectionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		URLInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "URLInfo");
		URLInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "URLInfo", Classes.FStrProperty);
		InSpeedByte_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InSpeedByte");
		InSpeedByte_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InSpeedByte", Classes.FIntProperty);
		OutSpeedByte_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutSpeedByte");
		OutSpeedByte_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutSpeedByte", Classes.FIntProperty);
		NetLagMS_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NetLagMS");
		NetLagMS_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NetLagMS", Classes.FDoubleProperty);
		PlayerId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerId");
		PlayerId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerId", Classes.FStructProperty);
		PktLostRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PktLostRate");
		PktLostRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PktLostRate", Classes.FFloatProperty);
		FGSConnectionInfo_IsValid = intPtr != IntPtr.Zero && URLInfo_IsValid && InSpeedByte_IsValid && OutSpeedByte_IsValid && NetLagMS_IsValid && PlayerId_IsValid && PktLostRate_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GSConnectionInfo", FGSConnectionInfo_IsValid);
	}
}
