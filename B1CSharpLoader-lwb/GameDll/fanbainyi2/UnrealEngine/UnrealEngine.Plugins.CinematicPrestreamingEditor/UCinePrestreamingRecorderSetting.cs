using System;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CinematicPrestreamingEditor;

[UClass(Flags = (ClassFlags)817889440uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting", "CinematicPrestreamingEditor", UnrealModuleType.EnginePlugin)]
public class UCinePrestreamingRecorderSetting : UMoviePipelineOutputBase
{
	private static bool PackageDirectory_IsValid;

	private static int PackageDirectory_Offset;

	private static bool EnableVirtualTexture_IsValid;

	private static FFieldAddress EnableVirtualTexture_PropertyAddress;

	private static int EnableVirtualTexture_Offset;

	private static bool EnableNanite_IsValid;

	private static FFieldAddress EnableNanite_PropertyAddress;

	private static int EnableNanite_Offset;

	private static bool ModifyTargetSequence_IsValid;

	private static FFieldAddress ModifyTargetSequence_PropertyAddress;

	private static int ModifyTargetSequence_Offset;

	private static bool DisableAdvanceRenderFeatures_IsValid;

	private static FFieldAddress DisableAdvanceRenderFeatures_PropertyAddress;

	private static int DisableAdvanceRenderFeatures_Offset;

	private static bool StartFrame_IsValid;

	private static int StartFrame_Offset;

	private static bool EndFrame_IsValid;

	private static int EndFrame_Offset;

	private static bool OnGenerateData_IsValid;

	private static int OnGenerateData_Offset;

	private FOnCinePrestreamingGenerateData OnGenerateData_DelegateCached;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:PackageDirectory")]
	public FDirectoryPath PackageDirectory
	{
		get
		{
			CheckDestroyed();
			if (!PackageDirectory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:PackageDirectory");
				return default(FDirectoryPath);
			}
			return FDirectoryPath.FromNative(IntPtr.Add(base.Address, PackageDirectory_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PackageDirectory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:PackageDirectory");
			}
			else
			{
				FDirectoryPath.ToNative(IntPtr.Add(base.Address, PackageDirectory_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bEnableVirtualTexture")]
	public bool EnableVirtualTexture
	{
		get
		{
			CheckDestroyed();
			if (!EnableVirtualTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bEnableVirtualTexture");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableVirtualTexture_Offset), 0, EnableVirtualTexture_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableVirtualTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bEnableVirtualTexture");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableVirtualTexture_Offset), 0, EnableVirtualTexture_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bEnableNanite")]
	public bool EnableNanite
	{
		get
		{
			CheckDestroyed();
			if (!EnableNanite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bEnableNanite");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableNanite_Offset), 0, EnableNanite_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableNanite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bEnableNanite");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableNanite_Offset), 0, EnableNanite_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bModifyTargetSequence")]
	public bool ModifyTargetSequence
	{
		get
		{
			CheckDestroyed();
			if (!ModifyTargetSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bModifyTargetSequence");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ModifyTargetSequence_Offset), 0, ModifyTargetSequence_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ModifyTargetSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bModifyTargetSequence");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ModifyTargetSequence_Offset), 0, ModifyTargetSequence_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bDisableAdvanceRenderFeatures")]
	public bool DisableAdvanceRenderFeatures
	{
		get
		{
			CheckDestroyed();
			if (!DisableAdvanceRenderFeatures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bDisableAdvanceRenderFeatures");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableAdvanceRenderFeatures_Offset), 0, DisableAdvanceRenderFeatures_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableAdvanceRenderFeatures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:bDisableAdvanceRenderFeatures");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableAdvanceRenderFeatures_Offset), 0, DisableAdvanceRenderFeatures_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:StartFrame")]
	public int StartFrame
	{
		get
		{
			CheckDestroyed();
			if (!StartFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:StartFrame");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:StartFrame");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartFrame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:EndFrame")]
	public int EndFrame
	{
		get
		{
			CheckDestroyed();
			if (!EndFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:EndFrame");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EndFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:EndFrame");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EndFrame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:OnGenerateData")]
	public FOnCinePrestreamingGenerateData OnGenerateData
	{
		get
		{
			CheckDestroyed();
			if (!OnGenerateData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting:OnGenerateData");
				return new FOnCinePrestreamingGenerateData();
			}
			if (OnGenerateData_DelegateCached == null)
			{
				OnGenerateData_DelegateCached = new FOnCinePrestreamingGenerateData();
				OnGenerateData_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGenerateData_Offset));
			}
			return OnGenerateData_DelegateCached;
		}
	}

	static UCinePrestreamingRecorderSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCinePrestreamingRecorderSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCinePrestreamingRecorderSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/CinematicPrestreamingEditor.CinePrestreamingRecorderSetting");
		PackageDirectory_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PackageDirectory");
		PackageDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PackageDirectory", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableVirtualTexture_PropertyAddress, unrealStruct, "bEnableVirtualTexture");
		EnableVirtualTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableVirtualTexture");
		EnableVirtualTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableVirtualTexture", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableNanite_PropertyAddress, unrealStruct, "bEnableNanite");
		EnableNanite_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableNanite");
		EnableNanite_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableNanite", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyTargetSequence_PropertyAddress, unrealStruct, "bModifyTargetSequence");
		ModifyTargetSequence_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bModifyTargetSequence");
		ModifyTargetSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bModifyTargetSequence", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableAdvanceRenderFeatures_PropertyAddress, unrealStruct, "bDisableAdvanceRenderFeatures");
		DisableAdvanceRenderFeatures_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDisableAdvanceRenderFeatures");
		DisableAdvanceRenderFeatures_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDisableAdvanceRenderFeatures", Classes.FBoolProperty);
		StartFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StartFrame");
		StartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StartFrame", Classes.FIntProperty);
		EndFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EndFrame");
		EndFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EndFrame", Classes.FIntProperty);
		OnGenerateData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnGenerateData");
		OnGenerateData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnGenerateData", Classes.FMulticastDelegateProperty);
	}
}
