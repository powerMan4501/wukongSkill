using System;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieSceneCapture;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTools;

[UClass(Flags = (ClassFlags)818939044uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture", "MovieSceneTools", UnrealModuleType.Engine)]
public class UAutomatedLevelSequenceCapture : UMovieSceneCapture
{
	private static bool LevelSequenceAsset_IsValid;

	private static int LevelSequenceAsset_Offset;

	private static bool ShotName_IsValid;

	private static int ShotName_Offset;

	private static bool UseCustomStartFrame_IsValid;

	private static FFieldAddress UseCustomStartFrame_PropertyAddress;

	private static int UseCustomStartFrame_Offset;

	private static bool CustomStartFrame_IsValid;

	private static int CustomStartFrame_Offset;

	private static bool UseCustomEndFrame_IsValid;

	private static FFieldAddress UseCustomEndFrame_PropertyAddress;

	private static int UseCustomEndFrame_Offset;

	private static bool CustomEndFrame_IsValid;

	private static int CustomEndFrame_Offset;

	private static bool WarmUpFrameCount_IsValid;

	private static int WarmUpFrameCount_Offset;

	private static bool DelayBeforeWarmUp_IsValid;

	private static int DelayBeforeWarmUp_Offset;

	private static bool DelayBeforeShotWarmUp_IsValid;

	private static int DelayBeforeShotWarmUp_Offset;

	private static bool DelayEveryFrame_IsValid;

	private static int DelayEveryFrame_Offset;

	private static bool BurnInOptions_IsValid;

	private static int BurnInOptions_Offset;

	private static bool WriteEditDecisionList_IsValid;

	private static FFieldAddress WriteEditDecisionList_PropertyAddress;

	private static int WriteEditDecisionList_Offset;

	private static bool WriteFinalCutProXML_IsValid;

	private static FFieldAddress WriteFinalCutProXML_PropertyAddress;

	private static int WriteFinalCutProXML_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:LevelSequenceAsset")]
	public FSoftObjectPath LevelSequenceAsset
	{
		get
		{
			CheckDestroyed();
			if (!LevelSequenceAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:LevelSequenceAsset");
				return default(FSoftObjectPath);
			}
			return FSoftObjectPath.FromNative(IntPtr.Add(base.Address, LevelSequenceAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelSequenceAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:LevelSequenceAsset");
			}
			else
			{
				FSoftObjectPath.ToNative(IntPtr.Add(base.Address, LevelSequenceAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:ShotName")]
	public string ShotName
	{
		get
		{
			CheckDestroyed();
			if (!ShotName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:ShotName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ShotName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShotName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:ShotName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ShotName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bUseCustomStartFrame")]
	public bool UseCustomStartFrame
	{
		get
		{
			CheckDestroyed();
			if (!UseCustomStartFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bUseCustomStartFrame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCustomStartFrame_Offset), 0, UseCustomStartFrame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCustomStartFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bUseCustomStartFrame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCustomStartFrame_Offset), 0, UseCustomStartFrame_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:CustomStartFrame")]
	public FFrameNumber CustomStartFrame
	{
		get
		{
			CheckDestroyed();
			if (!CustomStartFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:CustomStartFrame");
				return default(FFrameNumber);
			}
			return FFrameNumber.FromNative(IntPtr.Add(base.Address, CustomStartFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomStartFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:CustomStartFrame");
			}
			else
			{
				FFrameNumber.ToNative(IntPtr.Add(base.Address, CustomStartFrame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bUseCustomEndFrame")]
	public bool UseCustomEndFrame
	{
		get
		{
			CheckDestroyed();
			if (!UseCustomEndFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bUseCustomEndFrame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCustomEndFrame_Offset), 0, UseCustomEndFrame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCustomEndFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bUseCustomEndFrame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCustomEndFrame_Offset), 0, UseCustomEndFrame_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:CustomEndFrame")]
	public FFrameNumber CustomEndFrame
	{
		get
		{
			CheckDestroyed();
			if (!CustomEndFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:CustomEndFrame");
				return default(FFrameNumber);
			}
			return FFrameNumber.FromNative(IntPtr.Add(base.Address, CustomEndFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomEndFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:CustomEndFrame");
			}
			else
			{
				FFrameNumber.ToNative(IntPtr.Add(base.Address, CustomEndFrame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:WarmUpFrameCount")]
	public int WarmUpFrameCount
	{
		get
		{
			CheckDestroyed();
			if (!WarmUpFrameCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:WarmUpFrameCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WarmUpFrameCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WarmUpFrameCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:WarmUpFrameCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WarmUpFrameCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayBeforeWarmUp")]
	public float DelayBeforeWarmUp
	{
		get
		{
			CheckDestroyed();
			if (!DelayBeforeWarmUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayBeforeWarmUp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayBeforeWarmUp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayBeforeWarmUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayBeforeWarmUp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayBeforeWarmUp_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayBeforeShotWarmUp")]
	public float DelayBeforeShotWarmUp
	{
		get
		{
			CheckDestroyed();
			if (!DelayBeforeShotWarmUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayBeforeShotWarmUp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayBeforeShotWarmUp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayBeforeShotWarmUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayBeforeShotWarmUp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayBeforeShotWarmUp_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayEveryFrame")]
	public float DelayEveryFrame
	{
		get
		{
			CheckDestroyed();
			if (!DelayEveryFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayEveryFrame");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayEveryFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayEveryFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayEveryFrame");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayEveryFrame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885767188161037uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:BurnInOptions")]
	public ULevelSequenceBurnInOptions BurnInOptions
	{
		get
		{
			CheckDestroyed();
			if (!BurnInOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:BurnInOptions");
				return null;
			}
			return UObjectMarshaler<ULevelSequenceBurnInOptions>.FromNative(IntPtr.Add(base.Address, BurnInOptions_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BurnInOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:BurnInOptions");
			}
			else
			{
				UObjectMarshaler<ULevelSequenceBurnInOptions>.ToNative(IntPtr.Add(base.Address, BurnInOptions_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bWriteEditDecisionList")]
	public bool WriteEditDecisionList
	{
		get
		{
			CheckDestroyed();
			if (!WriteEditDecisionList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bWriteEditDecisionList");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WriteEditDecisionList_Offset), 0, WriteEditDecisionList_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WriteEditDecisionList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bWriteEditDecisionList");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WriteEditDecisionList_Offset), 0, WriteEditDecisionList_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bWriteFinalCutProXML")]
	public bool WriteFinalCutProXML
	{
		get
		{
			CheckDestroyed();
			if (!WriteFinalCutProXML_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bWriteFinalCutProXML");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WriteFinalCutProXML_Offset), 0, WriteFinalCutProXML_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WriteFinalCutProXML_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTools.AutomatedLevelSequenceCapture:bWriteFinalCutProXML");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WriteFinalCutProXML_Offset), 0, WriteFinalCutProXML_PropertyAddress.Address, value);
			}
		}
	}

	static UAutomatedLevelSequenceCapture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAutomatedLevelSequenceCapture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAutomatedLevelSequenceCapture));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieSceneTools.AutomatedLevelSequenceCapture");
		LevelSequenceAsset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LevelSequenceAsset");
		LevelSequenceAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LevelSequenceAsset", Classes.FStructProperty);
		ShotName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ShotName");
		ShotName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ShotName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCustomStartFrame_PropertyAddress, unrealStruct, "bUseCustomStartFrame");
		UseCustomStartFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseCustomStartFrame");
		UseCustomStartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseCustomStartFrame", Classes.FBoolProperty);
		CustomStartFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomStartFrame");
		CustomStartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomStartFrame", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCustomEndFrame_PropertyAddress, unrealStruct, "bUseCustomEndFrame");
		UseCustomEndFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseCustomEndFrame");
		UseCustomEndFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseCustomEndFrame", Classes.FBoolProperty);
		CustomEndFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomEndFrame");
		CustomEndFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomEndFrame", Classes.FStructProperty);
		WarmUpFrameCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WarmUpFrameCount");
		WarmUpFrameCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WarmUpFrameCount", Classes.FIntProperty);
		DelayBeforeWarmUp_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DelayBeforeWarmUp");
		DelayBeforeWarmUp_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DelayBeforeWarmUp", Classes.FFloatProperty);
		DelayBeforeShotWarmUp_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DelayBeforeShotWarmUp");
		DelayBeforeShotWarmUp_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DelayBeforeShotWarmUp", Classes.FFloatProperty);
		DelayEveryFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DelayEveryFrame");
		DelayEveryFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DelayEveryFrame", Classes.FFloatProperty);
		BurnInOptions_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BurnInOptions");
		BurnInOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BurnInOptions", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteEditDecisionList_PropertyAddress, unrealStruct, "bWriteEditDecisionList");
		WriteEditDecisionList_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bWriteEditDecisionList");
		WriteEditDecisionList_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bWriteEditDecisionList", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteFinalCutProXML_PropertyAddress, unrealStruct, "bWriteFinalCutProXML");
		WriteFinalCutProXML_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bWriteFinalCutProXML");
		WriteFinalCutProXML_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bWriteFinalCutProXML", Classes.FBoolProperty);
	}
}
