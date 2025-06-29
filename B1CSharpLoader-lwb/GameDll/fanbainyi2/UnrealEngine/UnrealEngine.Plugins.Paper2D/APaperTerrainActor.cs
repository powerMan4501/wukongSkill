using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Paper2D.PaperTerrainActor", "Paper2D", UnrealModuleType.EnginePlugin)]
public class APaperTerrainActor : AActor
{
	private static bool RenderComponent_IsValid;

	private static int RenderComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Paper2D.PaperTerrainActor:RenderComponent")]
	public UPaperTerrainComponent RenderComponent
	{
		get
		{
			CheckDestroyed();
			if (!RenderComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTerrainActor:RenderComponent");
				return null;
			}
			return UObjectMarshaler<UPaperTerrainComponent>.FromNative(IntPtr.Add(base.Address, RenderComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTerrainActor:RenderComponent");
			}
			else
			{
				UObjectMarshaler<UPaperTerrainComponent>.ToNative(IntPtr.Add(base.Address, RenderComponent_Offset), value);
			}
		}
	}

	static APaperTerrainActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APaperTerrainActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APaperTerrainActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Paper2D.PaperTerrainActor");
		RenderComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RenderComponent");
		RenderComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RenderComponent", Classes.FObjectProperty);
	}
}
