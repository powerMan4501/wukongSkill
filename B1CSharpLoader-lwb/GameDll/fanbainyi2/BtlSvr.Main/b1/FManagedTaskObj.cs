using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ManagedTaskObj")]
public struct FManagedTaskObj
{
	[UProperty]
	[DisplayName("单位")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ManagedTaskObj:Actor")]
	public TSoftObject<BGUActorBaseCS> Actor;

	[DisplayName("单位GUID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ManagedTaskObj:ActorGuid")]
	public string ActorGuid;

	[DisplayName("别名")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ManagedTaskObj:AliasName")]
	public FName AliasName;

	private static int ManagedTaskObj_StructSize;

	private static int ManagedTaskObj_IsValid;

	private static bool Actor_IsValid;

	private static int Actor_Offset;

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

	public FManagedTaskObj Copy()
	{
		return this;
	}

	public static FManagedTaskObj FromNative(IntPtr nativeBuffer)
	{
		return new FManagedTaskObj(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FManagedTaskObj value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FManagedTaskObj FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FManagedTaskObj(IntPtr.Add(nativeBuffer, arrayIndex * ManagedTaskObj_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FManagedTaskObj value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ManagedTaskObj_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ManagedTaskObj_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedTaskObj");
			return;
		}
		TSoftObjectMarshaler<BGUActorBaseCS>.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FManagedTaskObj(IntPtr nativeStruct)
	{
		if (ManagedTaskObj_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedTaskObj");
			Actor = default(TSoftObject<BGUActorBaseCS>);
			ActorGuid = null;
			AliasName = default(FName);
		}
		else
		{
			Actor = TSoftObjectMarshaler<BGUActorBaseCS>.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ManagedTaskObj");
		ManagedTaskObj_StructSize = NativeReflection.GetStructSize(intPtr);
		Actor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Actor", Classes.FSoftObjectProperty);
		ActorGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		AliasName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		ManagedTaskObj_IsValid = ((intPtr != IntPtr.Zero && Actor_IsValid && ActorGuid_IsValid && AliasName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ManagedTaskObj", (byte)ManagedTaskObj_IsValid != 0);
	}

	static FManagedTaskObj()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FManagedTaskObj)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FManagedTaskObj));
	}
}
