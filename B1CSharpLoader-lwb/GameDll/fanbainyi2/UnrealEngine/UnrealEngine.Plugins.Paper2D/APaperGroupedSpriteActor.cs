using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Paper2D.PaperGroupedSpriteActor", "Paper2D", UnrealModuleType.EnginePlugin)]
public class APaperGroupedSpriteActor : AActor
{
	private static bool RenderComponent_IsValid;

	private static int RenderComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Paper2D.PaperGroupedSpriteActor:RenderComponent")]
	public UPaperGroupedSpriteComponent RenderComponent
	{
		get
		{
			CheckDestroyed();
			if (!RenderComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperGroupedSpriteActor:RenderComponent");
				return null;
			}
			return UObjectMarshaler<UPaperGroupedSpriteComponent>.FromNative(IntPtr.Add(base.Address, RenderComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperGroupedSpriteActor:RenderComponent");
			}
			else
			{
				UObjectMarshaler<UPaperGroupedSpriteComponent>.ToNative(IntPtr.Add(base.Address, RenderComponent_Offset), value);
			}
		}
	}

	static APaperGroupedSpriteActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APaperGroupedSpriteActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APaperGroupedSpriteActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Paper2D.PaperGroupedSpriteActor");
		RenderComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RenderComponent");
		RenderComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RenderComponent", Classes.FObjectProperty);
	}
}
