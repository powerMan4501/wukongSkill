using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.Note", "Engine", UnrealModuleType.Engine)]
public class ANote : AActor
{
	private static bool Text_IsValid;

	private static int Text_Offset;

	[UProperty(Flags = (PropFlags)6755433800794629uL)]
	[UMetaPath("/Script/Engine.Note:Text")]
	public string Text
	{
		get
		{
			CheckDestroyed();
			if (!Text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Note:Text");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Text_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Note:Text");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Text_Offset), value);
			}
		}
	}

	static ANote()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ANote)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ANote));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.Note");
		Text_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Text");
		Text_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Text", Classes.FStrProperty);
	}
}
