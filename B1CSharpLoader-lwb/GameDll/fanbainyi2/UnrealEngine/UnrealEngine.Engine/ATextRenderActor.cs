using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.TextRenderActor", "Engine", UnrealModuleType.Engine)]
public class ATextRenderActor : AActor
{
	private static bool TextRender_IsValid;

	private static int TextRender_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.TextRenderActor:TextRender")]
	public UTextRenderComponent TextRender
	{
		get
		{
			CheckDestroyed();
			if (!TextRender_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderActor:TextRender");
				return null;
			}
			return UObjectMarshaler<UTextRenderComponent>.FromNative(IntPtr.Add(base.Address, TextRender_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextRender_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderActor:TextRender");
			}
			else
			{
				UObjectMarshaler<UTextRenderComponent>.ToNative(IntPtr.Add(base.Address, TextRender_Offset), value);
			}
		}
	}

	static ATextRenderActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ATextRenderActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ATextRenderActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.TextRenderActor");
		TextRender_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TextRender");
		TextRender_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TextRender", Classes.FObjectProperty);
	}
}
