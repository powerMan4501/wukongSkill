using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Paper2D.PaperSpriteActor", "Paper2D", UnrealModuleType.EnginePlugin)]
public class APaperSpriteActor : AActor
{
	private static bool RenderComponent_IsValid;

	private static int RenderComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Paper2D.PaperSpriteActor:RenderComponent")]
	public UPaperSpriteComponent RenderComponent
	{
		get
		{
			CheckDestroyed();
			if (!RenderComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperSpriteActor:RenderComponent");
				return null;
			}
			return UObjectMarshaler<UPaperSpriteComponent>.FromNative(IntPtr.Add(base.Address, RenderComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperSpriteActor:RenderComponent");
			}
			else
			{
				UObjectMarshaler<UPaperSpriteComponent>.ToNative(IntPtr.Add(base.Address, RenderComponent_Offset), value);
			}
		}
	}

	static APaperSpriteActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APaperSpriteActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APaperSpriteActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Paper2D.PaperSpriteActor");
		RenderComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RenderComponent");
		RenderComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RenderComponent", Classes.FObjectProperty);
	}
}
