using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ManagedNPCUnit")]
public struct FManagedNPCUnit
{
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[DisplayName("单位")]
	[USharpPath("/Script/b1-Managed.ManagedNPCUnit:Actor")]
	public TSoftObject<BGUCharacterCS> Actor;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ManagedNPCUnit:Tamer")]
	public TSoftObject<BUTamerActor> Tamer;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("单位GUID")]
	[USharpPath("/Script/b1-Managed.ManagedNPCUnit:ActorGuid")]
	public string ActorGuid;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("别名")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ManagedNPCUnit:AliasName")]
	public FName AliasName;

	private static int ManagedNPCUnit_StructSize;

	private static int ManagedNPCUnit_IsValid;

	private static bool Actor_IsValid;

	private static int Actor_Offset;

	private static bool Tamer_IsValid;

	private static int Tamer_Offset;

	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	private static bool AliasName_IsValid;

	private static int AliasName_Offset;

	public string GetDisplayName()
	{
		if (AliasName != FName.None)
		{
			return AliasName.PlainName;
		}
		return ActorGuid;
	}

	public FManagedNPCUnit Copy()
	{
		return this;
	}

	public static FManagedNPCUnit FromNative(IntPtr nativeBuffer)
	{
		return new FManagedNPCUnit(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FManagedNPCUnit value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FManagedNPCUnit FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FManagedNPCUnit(IntPtr.Add(nativeBuffer, arrayIndex * ManagedNPCUnit_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FManagedNPCUnit value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ManagedNPCUnit_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ManagedNPCUnit_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedNPCUnit");
			return;
		}
		TSoftObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		TSoftObjectMarshaler<BUTamerActor>.ToNative(IntPtr.Add(nativeStruct, Tamer_Offset), Tamer);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FManagedNPCUnit(IntPtr nativeStruct)
	{
		if (ManagedNPCUnit_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedNPCUnit");
			Actor = default(TSoftObject<BGUCharacterCS>);
			Tamer = default(TSoftObject<BUTamerActor>);
			ActorGuid = null;
			AliasName = default(FName);
		}
		else
		{
			Actor = TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			Tamer = TSoftObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(nativeStruct, Tamer_Offset));
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ManagedNPCUnit");
		ManagedNPCUnit_StructSize = NativeReflection.GetStructSize(intPtr);
		Actor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Actor", Classes.FSoftObjectProperty);
		Tamer_Offset = NativeReflection.GetPropertyOffset(intPtr, "Tamer");
		Tamer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Tamer", Classes.FSoftObjectProperty);
		ActorGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		AliasName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		ManagedNPCUnit_IsValid = ((intPtr != IntPtr.Zero && Actor_IsValid && Tamer_IsValid && ActorGuid_IsValid && AliasName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ManagedNPCUnit", (byte)ManagedNPCUnit_IsValid != 0);
	}

	static FManagedNPCUnit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FManagedNPCUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FManagedNPCUnit));
	}
}
