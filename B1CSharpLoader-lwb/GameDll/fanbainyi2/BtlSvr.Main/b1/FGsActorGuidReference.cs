using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.GsActorGuidReference")]
public struct FGsActorGuidReference
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GsActorGuidReference:ActorRef")]
	public TSoftObject<AActor> ActorRef;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GsActorGuidReference:ActorGuid")]
	public string ActorGuid;

	private static int GsActorGuidReference_StructSize;

	private static int GsActorGuidReference_IsValid;

	private static bool ActorRef_IsValid;

	private static int ActorRef_Offset;

	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	public static bool GetGuidRef(TSoftObject<BUTamerActor> SoftRef, out FGsActorGuidReference GuidRef)
	{
		if (SoftRef.Value != null && SoftRef.Value.GetActorGuid(out var OutActorGuid))
		{
			GuidRef = new FGsActorGuidReference
			{
				ActorRef = new TSoftObject<AActor>(SoftRef.ObjectPath),
				ActorGuid = OutActorGuid
			};
			return true;
		}
		GuidRef = new FGsActorGuidReference
		{
			ActorRef = new TSoftObject<AActor>(SoftRef.ObjectPath)
		};
		return false;
	}

	public static bool GetGuidRef<T>(TSoftObject<T> SoftRef, out FGsActorGuidReference GuidRef) where T : ABGUActorBase
	{
		if (SoftRef.Value != null && SoftRef.Value.GetActorGuid(out var OutActorGuid))
		{
			GuidRef = new FGsActorGuidReference
			{
				ActorRef = new TSoftObject<AActor>(SoftRef.ObjectPath),
				ActorGuid = OutActorGuid
			};
			return true;
		}
		GuidRef = new FGsActorGuidReference
		{
			ActorRef = new TSoftObject<AActor>(SoftRef.ObjectPath)
		};
		return false;
	}

	public static bool GetGuidRef(BUTamerActor Actor, out FGsActorGuidReference GuidRef)
	{
		if (Actor != null && Actor.GetActorGuid(out var OutActorGuid))
		{
			GuidRef = new FGsActorGuidReference
			{
				ActorRef = new TSoftObject<AActor>(Actor),
				ActorGuid = OutActorGuid
			};
			return true;
		}
		GuidRef = new FGsActorGuidReference
		{
			ActorRef = new TSoftObject<AActor>(Actor)
		};
		return false;
	}

	public static bool GetGuidRef<T>(T Actor, out FGsActorGuidReference GuidRef) where T : ABGUActorBase
	{
		if (Actor != null && Actor.GetActorGuid(out var OutActorGuid))
		{
			GuidRef = new FGsActorGuidReference
			{
				ActorRef = new TSoftObject<AActor>(Actor),
				ActorGuid = OutActorGuid
			};
			return true;
		}
		GuidRef = new FGsActorGuidReference
		{
			ActorRef = new TSoftObject<AActor>(Actor)
		};
		return false;
	}

	public FGsActorGuidReference Copy()
	{
		return this;
	}

	public static FGsActorGuidReference FromNative(IntPtr nativeBuffer)
	{
		return new FGsActorGuidReference(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsActorGuidReference value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsActorGuidReference FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsActorGuidReference(IntPtr.Add(nativeBuffer, arrayIndex * GsActorGuidReference_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsActorGuidReference value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GsActorGuidReference_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GsActorGuidReference_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GsActorGuidReference");
			return;
		}
		TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, ActorRef_Offset), ActorRef);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
	}

	public FGsActorGuidReference(IntPtr nativeStruct)
	{
		if (GsActorGuidReference_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GsActorGuidReference");
			ActorRef = default(TSoftObject<AActor>);
			ActorGuid = null;
		}
		else
		{
			ActorRef = TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, ActorRef_Offset));
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GsActorGuidReference");
		GsActorGuidReference_StructSize = NativeReflection.GetStructSize(intPtr);
		ActorRef_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorRef");
		ActorRef_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorRef", Classes.FSoftObjectProperty);
		ActorGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		GsActorGuidReference_IsValid = ((intPtr != IntPtr.Zero && ActorRef_IsValid && ActorGuid_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GsActorGuidReference", (byte)GsActorGuidReference_IsValid != 0);
	}

	static FGsActorGuidReference()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGsActorGuidReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsActorGuidReference));
	}
}
