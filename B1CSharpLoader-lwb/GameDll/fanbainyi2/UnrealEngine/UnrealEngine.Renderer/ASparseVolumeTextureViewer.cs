using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Renderer;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Renderer.SparseVolumeTextureViewer", "Renderer", UnrealModuleType.Engine)]
public class ASparseVolumeTextureViewer : AInfo
{
	private static bool SparseVolumeTextureViewerComponent_IsValid;

	private static int SparseVolumeTextureViewerComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Renderer.SparseVolumeTextureViewer:SparseVolumeTextureViewerComponent")]
	public USparseVolumeTextureViewerComponent SparseVolumeTextureViewerComponent
	{
		get
		{
			CheckDestroyed();
			if (!SparseVolumeTextureViewerComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewer:SparseVolumeTextureViewerComponent");
				return null;
			}
			return UObjectMarshaler<USparseVolumeTextureViewerComponent>.FromNative(IntPtr.Add(base.Address, SparseVolumeTextureViewerComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SparseVolumeTextureViewerComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewer:SparseVolumeTextureViewerComponent");
			}
			else
			{
				UObjectMarshaler<USparseVolumeTextureViewerComponent>.ToNative(IntPtr.Add(base.Address, SparseVolumeTextureViewerComponent_Offset), value);
			}
		}
	}

	static ASparseVolumeTextureViewer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ASparseVolumeTextureViewer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ASparseVolumeTextureViewer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Renderer.SparseVolumeTextureViewer");
		SparseVolumeTextureViewerComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SparseVolumeTextureViewerComponent");
		SparseVolumeTextureViewerComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SparseVolumeTextureViewerComponent", Classes.FObjectProperty);
	}
}
