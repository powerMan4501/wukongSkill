using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsNPCReferenceInfo", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsNPCReferenceInfo
{
	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsNPCReferenceInfo:ConfigGuid")]
	public Guid ConfigGuid;

	private static bool Tamer_IsValid;

	private static int Tamer_Offset;

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/Calliope.GsNPCReferenceInfo:Tamer")]
	public TSoftObject<AActor> Tamer;

	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/Calliope.GsNPCReferenceInfo:ActorGuid")]
	public string ActorGuid;

	private static bool AliasName_IsValid;

	private static int AliasName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsNPCReferenceInfo:AliasName")]
	public FName AliasName;

	private static bool FGsNPCReferenceInfo_IsValid;

	private static int FGsNPCReferenceInfo_StructSize;

	public FGsNPCReferenceInfo Copy()
	{
		return this;
	}

	public static FGsNPCReferenceInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGsNPCReferenceInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsNPCReferenceInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsNPCReferenceInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsNPCReferenceInfo(nativeBuffer + arrayIndex * FGsNPCReferenceInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsNPCReferenceInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsNPCReferenceInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsNPCReferenceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCReferenceInfo");
			return;
		}
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Tamer_Offset), Tamer);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsNPCReferenceInfo(IntPtr nativeStruct)
	{
		if (!FGsNPCReferenceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCReferenceInfo");
			ConfigGuid = default(Guid);
			Tamer = default(TSoftObject<AActor>);
			ActorGuid = FStringMarshaler.DefaultString;
			AliasName = default(FName);
		}
		else
		{
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			Tamer = TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Tamer_Offset));
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsNPCReferenceInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsNPCReferenceInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsNPCReferenceInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsNPCReferenceInfo");
		FGsNPCReferenceInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		Tamer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tamer");
		Tamer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tamer", Classes.FSoftObjectProperty);
		ActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		FGsNPCReferenceInfo_IsValid = intPtr != IntPtr.Zero && ConfigGuid_IsValid && Tamer_IsValid && ActorGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsNPCReferenceInfo", FGsNPCReferenceInfo_IsValid);
	}
}
