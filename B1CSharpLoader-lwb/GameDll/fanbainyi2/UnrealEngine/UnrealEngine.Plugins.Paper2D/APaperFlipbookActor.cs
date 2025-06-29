using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Paper2D.PaperFlipbookActor", "Paper2D", UnrealModuleType.EnginePlugin)]
public class APaperFlipbookActor : AActor
{
	private static bool RenderComponent_IsValid;

	private static int RenderComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookActor:RenderComponent")]
	public UPaperFlipbookComponent RenderComponent
	{
		get
		{
			CheckDestroyed();
			if (!RenderComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperFlipbookActor:RenderComponent");
				return null;
			}
			return UObjectMarshaler<UPaperFlipbookComponent>.FromNative(IntPtr.Add(base.Address, RenderComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperFlipbookActor:RenderComponent");
			}
			else
			{
				UObjectMarshaler<UPaperFlipbookComponent>.ToNative(IntPtr.Add(base.Address, RenderComponent_Offset), value);
			}
		}
	}

	static APaperFlipbookActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APaperFlipbookActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APaperFlipbookActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Paper2D.PaperFlipbookActor");
		RenderComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RenderComponent");
		RenderComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RenderComponent", Classes.FObjectProperty);
	}
}
