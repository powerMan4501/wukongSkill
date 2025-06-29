using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Renderer;

[UClass(Flags = (ClassFlags)820523172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Renderer.SparseVolumeTextureViewerComponent", "Renderer", UnrealModuleType.Engine)]
public class USparseVolumeTextureViewerComponent : UPrimitiveComponent
{
	private static bool SparseVolumeTexturePreview_IsValid;

	private static int SparseVolumeTexturePreview_Offset;

	private static bool Animate_IsValid;

	private static FFieldAddress Animate_PropertyAddress;

	private static int Animate_Offset;

	private static bool ReversePlayback_IsValid;

	private static FFieldAddress ReversePlayback_PropertyAddress;

	private static int ReversePlayback_Offset;

	private static bool BlockingStreamingRequests_IsValid;

	private static FFieldAddress BlockingStreamingRequests_PropertyAddress;

	private static int BlockingStreamingRequests_Offset;

	private static bool AnimationFrame_IsValid;

	private static int AnimationFrame_Offset;

	private static bool FrameRate_IsValid;

	private static int FrameRate_Offset;

	private static bool PreviewAttribute_IsValid;

	private static FFieldAddress PreviewAttribute_PropertyAddress;

	private static int PreviewAttribute_Offset;

	private static bool MipLevel_IsValid;

	private static int MipLevel_Offset;

	private static bool Extinction_IsValid;

	private static int Extinction_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Renderer.SparseVolumeTextureViewerComponent:SparseVolumeTexturePreview")]
	public USparseVolumeTexture SparseVolumeTexturePreview
	{
		get
		{
			CheckDestroyed();
			if (!SparseVolumeTexturePreview_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:SparseVolumeTexturePreview");
				return null;
			}
			return UObjectMarshaler<USparseVolumeTexture>.FromNative(IntPtr.Add(base.Address, SparseVolumeTexturePreview_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SparseVolumeTexturePreview_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:SparseVolumeTexturePreview");
			}
			else
			{
				UObjectMarshaler<USparseVolumeTexture>.ToNative(IntPtr.Add(base.Address, SparseVolumeTexturePreview_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Renderer.SparseVolumeTextureViewerComponent:bAnimate")]
	public bool Animate
	{
		get
		{
			CheckDestroyed();
			if (!Animate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:bAnimate");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Animate_Offset), 0, Animate_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Animate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:bAnimate");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Animate_Offset), 0, Animate_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Renderer.SparseVolumeTextureViewerComponent:bReversePlayback")]
	public bool ReversePlayback
	{
		get
		{
			CheckDestroyed();
			if (!ReversePlayback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:bReversePlayback");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReversePlayback_Offset), 0, ReversePlayback_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReversePlayback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:bReversePlayback");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReversePlayback_Offset), 0, ReversePlayback_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Renderer.SparseVolumeTextureViewerComponent:bBlockingStreamingRequests")]
	public bool BlockingStreamingRequests
	{
		get
		{
			CheckDestroyed();
			if (!BlockingStreamingRequests_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:bBlockingStreamingRequests");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BlockingStreamingRequests_Offset), 0, BlockingStreamingRequests_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlockingStreamingRequests_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:bBlockingStreamingRequests");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BlockingStreamingRequests_Offset), 0, BlockingStreamingRequests_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Renderer.SparseVolumeTextureViewerComponent:AnimationFrame")]
	public float AnimationFrame
	{
		get
		{
			CheckDestroyed();
			if (!AnimationFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:AnimationFrame");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnimationFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimationFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:AnimationFrame");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnimationFrame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Renderer.SparseVolumeTextureViewerComponent:FrameRate")]
	public float FrameRate
	{
		get
		{
			CheckDestroyed();
			if (!FrameRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:FrameRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FrameRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrameRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:FrameRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FrameRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Renderer.SparseVolumeTextureViewerComponent:PreviewAttribute")]
	public ESparseVolumeTexturePreviewAttribute PreviewAttribute
	{
		get
		{
			CheckDestroyed();
			if (!PreviewAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:PreviewAttribute");
				return ESparseVolumeTexturePreviewAttribute.ESVTPA_AttributesA_R;
			}
			return EnumMarshaler<ESparseVolumeTexturePreviewAttribute>.FromNative(IntPtr.Add(base.Address, PreviewAttribute_Offset), 0, PreviewAttribute_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PreviewAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:PreviewAttribute");
			}
			else
			{
				EnumMarshaler<ESparseVolumeTexturePreviewAttribute>.ToNative(IntPtr.Add(base.Address, PreviewAttribute_Offset), 0, PreviewAttribute_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Renderer.SparseVolumeTextureViewerComponent:MipLevel")]
	public int MipLevel
	{
		get
		{
			CheckDestroyed();
			if (!MipLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:MipLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MipLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MipLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:MipLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MipLevel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Renderer.SparseVolumeTextureViewerComponent:Extinction")]
	public float Extinction
	{
		get
		{
			CheckDestroyed();
			if (!Extinction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:Extinction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Extinction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Extinction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Renderer.SparseVolumeTextureViewerComponent:Extinction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Extinction_Offset), value);
			}
		}
	}

	static USparseVolumeTextureViewerComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USparseVolumeTextureViewerComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USparseVolumeTextureViewerComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Renderer.SparseVolumeTextureViewerComponent");
		SparseVolumeTexturePreview_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SparseVolumeTexturePreview");
		SparseVolumeTexturePreview_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SparseVolumeTexturePreview", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Animate_PropertyAddress, unrealStruct, "bAnimate");
		Animate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAnimate");
		Animate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAnimate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReversePlayback_PropertyAddress, unrealStruct, "bReversePlayback");
		ReversePlayback_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bReversePlayback");
		ReversePlayback_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bReversePlayback", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BlockingStreamingRequests_PropertyAddress, unrealStruct, "bBlockingStreamingRequests");
		BlockingStreamingRequests_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bBlockingStreamingRequests");
		BlockingStreamingRequests_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bBlockingStreamingRequests", Classes.FBoolProperty);
		AnimationFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AnimationFrame");
		AnimationFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AnimationFrame", Classes.FFloatProperty);
		FrameRate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FrameRate");
		FrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FrameRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PreviewAttribute_PropertyAddress, unrealStruct, "PreviewAttribute");
		PreviewAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PreviewAttribute");
		PreviewAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PreviewAttribute", Classes.FByteProperty);
		MipLevel_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MipLevel");
		MipLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MipLevel", Classes.FIntProperty);
		Extinction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Extinction");
		Extinction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Extinction", Classes.FFloatProperty);
	}
}
