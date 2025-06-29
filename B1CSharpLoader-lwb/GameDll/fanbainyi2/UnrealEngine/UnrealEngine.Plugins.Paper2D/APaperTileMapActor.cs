using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Paper2D.PaperTileMapActor", "Paper2D", UnrealModuleType.EnginePlugin)]
public class APaperTileMapActor : AActor
{
	private static bool RenderComponent_IsValid;

	private static int RenderComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMapActor:RenderComponent")]
	public UPaperTileMapComponent RenderComponent
	{
		get
		{
			CheckDestroyed();
			if (!RenderComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMapActor:RenderComponent");
				return null;
			}
			return UObjectMarshaler<UPaperTileMapComponent>.FromNative(IntPtr.Add(base.Address, RenderComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMapActor:RenderComponent");
			}
			else
			{
				UObjectMarshaler<UPaperTileMapComponent>.ToNative(IntPtr.Add(base.Address, RenderComponent_Offset), value);
			}
		}
	}

	static APaperTileMapActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APaperTileMapActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APaperTileMapActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Paper2D.PaperTileMapActor");
		RenderComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RenderComponent");
		RenderComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RenderComponent", Classes.FObjectProperty);
	}
}
