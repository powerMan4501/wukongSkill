using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_PlaceholderActorConfigComp")]
public class BUS_PlaceholderActorConfigComp : UActorEditCompBase
{
	private static bool Describe_IsValid;

	private static int Describe_Offset;

	[DisplayName("描述")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_PlaceholderActorConfigComp:Describe")]
	public string Describe
	{
		get
		{
			CheckDestroyed();
			if (!Describe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PlaceholderActorConfigComp:Describe");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Describe_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Describe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PlaceholderActorConfigComp:Describe");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Describe_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_PlaceholderActorConfigComp");
		Describe_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Describe");
		Describe_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Describe", Classes.FStrProperty);
	}

	static BUS_PlaceholderActorConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_PlaceholderActorConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_PlaceholderActorConfigComp));
	}
}
