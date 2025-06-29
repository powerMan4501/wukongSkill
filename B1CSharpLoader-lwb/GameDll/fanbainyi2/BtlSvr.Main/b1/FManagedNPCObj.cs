using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ManagedNPCObj")]
public struct FManagedNPCObj
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("单位")]
	[USharpPath("/Script/b1-Managed.ManagedNPCObj:Actor")]
	public TSoftObject<BGUActorBaseCS> Actor;

	[DisplayName("单位GUID")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ManagedNPCObj:ActorGuid")]
	public string ActorGuid;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("别名")]
	[USharpPath("/Script/b1-Managed.ManagedNPCObj:AliasName")]
	public FName AliasName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("类型")]
	[USharpPath("/Script/b1-Managed.ManagedNPCObj:ManagedNPCUnitType")]
	public EManagedNPCUnitType ManagedNPCUnitType;

	private static int ManagedNPCObj_StructSize;

	private static int ManagedNPCObj_IsValid;

	private static bool Actor_IsValid;

	private static int Actor_Offset;

	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	private static bool AliasName_IsValid;

	private static int AliasName_Offset;

	private static bool ManagedNPCUnitType_IsValid;

	private static int ManagedNPCUnitType_Offset;

	private static FFieldAddress ManagedNPCUnitType_PropertyAddress;

	public string GetDisplayName()
	{
		if (AliasName != FName.None)
		{
			return AliasName.PlainName;
		}
		return ActorGuid;
	}

	public FManagedNPCObj Copy()
	{
		return this;
	}

	public static FManagedNPCObj FromNative(IntPtr nativeBuffer)
	{
		return new FManagedNPCObj(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FManagedNPCObj value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FManagedNPCObj FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FManagedNPCObj(IntPtr.Add(nativeBuffer, arrayIndex * ManagedNPCObj_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FManagedNPCObj value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ManagedNPCObj_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ManagedNPCObj_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedNPCObj");
			return;
		}
		TSoftObjectMarshaler<BGUActorBaseCS>.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
		EnumMarshaler<EManagedNPCUnitType>.ToNative(IntPtr.Add(nativeStruct, ManagedNPCUnitType_Offset), 0, ManagedNPCUnitType_PropertyAddress.Address, ManagedNPCUnitType);
	}

	public FManagedNPCObj(IntPtr nativeStruct)
	{
		if (ManagedNPCObj_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedNPCObj");
			Actor = default(TSoftObject<BGUActorBaseCS>);
			ActorGuid = null;
			AliasName = default(FName);
			ManagedNPCUnitType = EManagedNPCUnitType.None;
		}
		else
		{
			Actor = TSoftObjectMarshaler<BGUActorBaseCS>.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
			ManagedNPCUnitType = EnumMarshaler<EManagedNPCUnitType>.FromNative(IntPtr.Add(nativeStruct, ManagedNPCUnitType_Offset), 0, ManagedNPCUnitType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ManagedNPCObj");
		ManagedNPCObj_StructSize = NativeReflection.GetStructSize(intPtr);
		Actor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Actor", Classes.FSoftObjectProperty);
		ActorGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		AliasName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref ManagedNPCUnitType_PropertyAddress, intPtr, "ManagedNPCUnitType");
		ManagedNPCUnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ManagedNPCUnitType");
		ManagedNPCUnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ManagedNPCUnitType", Classes.FEnumProperty);
		ManagedNPCObj_IsValid = ((intPtr != IntPtr.Zero && Actor_IsValid && ActorGuid_IsValid && AliasName_IsValid && ManagedNPCUnitType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ManagedNPCObj", (byte)ManagedNPCObj_IsValid != 0);
	}

	static FManagedNPCObj()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FManagedNPCObj)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FManagedNPCObj));
	}
}
