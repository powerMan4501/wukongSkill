using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Paper2D.PaperCharacter", "Paper2D", UnrealModuleType.EnginePlugin)]
public class APaperCharacter : ACharacter
{
	private static bool Sprite_IsValid;

	private static int Sprite_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Paper2D.PaperCharacter:Sprite")]
	public UPaperFlipbookComponent Sprite
	{
		get
		{
			CheckDestroyed();
			if (!Sprite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperCharacter:Sprite");
				return null;
			}
			return UObjectMarshaler<UPaperFlipbookComponent>.FromNative(IntPtr.Add(base.Address, Sprite_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Sprite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperCharacter:Sprite");
			}
			else
			{
				UObjectMarshaler<UPaperFlipbookComponent>.ToNative(IntPtr.Add(base.Address, Sprite_Offset), value);
			}
		}
	}

	static APaperCharacter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APaperCharacter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APaperCharacter));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Paper2D.PaperCharacter");
		Sprite_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Sprite");
		Sprite_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Sprite", Classes.FObjectProperty);
	}
}
