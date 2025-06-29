using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor", "FuncLibEditor", UnrealModuleType.Game)]
public class AGSRTAvatarEditingUtilActor : AGSEditorUtilActor
{
	private static bool EditingRTCamera_IsValid;

	private static int EditingRTCamera_Offset;

	private static bool EditingHeroActor_IsValid;

	private static int EditingHeroActor_Offset;

	private static bool PresetSavingPath_IsValid;

	private static int PresetSavingPath_Offset;

	private static bool PresetSavingName_IsValid;

	private static int PresetSavingName_Offset;

	private static bool TargetAnimFrame_IsValid;

	private static int TargetAnimFrame_Offset;

	private static bool PreviewPreset_IsValid;

	private static int PreviewPreset_Offset;

	private static bool TakeShot_IsValid;

	private static IntPtr TakeShot_FunctionAddress;

	private static int TakeShot_ParamsSize;

	private static bool StopAnimating_IsValid;

	private static IntPtr StopAnimating_FunctionAddress;

	private static int StopAnimating_ParamsSize;

	private static bool ResumeAnimating_IsValid;

	private static IntPtr ResumeAnimating_FunctionAddress;

	private static int ResumeAnimating_ParamsSize;

	private static bool PreviewSelectingAvatar_IsValid;

	private static IntPtr PreviewSelectingAvatar_FunctionAddress;

	private static int PreviewSelectingAvatar_ParamsSize;

	private static bool IsAnimPlaying_IsValid;

	private static IntPtr IsAnimPlaying_FunctionAddress;

	private static int IsAnimPlaying_ParamsSize;

	private static bool IsAnimPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsAnimPlaying_ReturnValue_PropertyAddress;

	private static int IsAnimPlaying_ReturnValue_Offset;

	private static bool GenerateDAPreset_IsValid;

	private static IntPtr GenerateDAPreset_FunctionAddress;

	private static int GenerateDAPreset_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:EditingRTCamera")]
	public ACameraActor EditingRTCamera
	{
		get
		{
			CheckDestroyed();
			if (!EditingRTCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:EditingRTCamera");
				return null;
			}
			return UObjectMarshaler<ACameraActor>.FromNative(IntPtr.Add(base.Address, EditingRTCamera_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EditingRTCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:EditingRTCamera");
			}
			else
			{
				UObjectMarshaler<ACameraActor>.ToNative(IntPtr.Add(base.Address, EditingRTCamera_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:EditingHeroActor")]
	public AActor EditingHeroActor
	{
		get
		{
			CheckDestroyed();
			if (!EditingHeroActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:EditingHeroActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, EditingHeroActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EditingHeroActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:EditingHeroActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, EditingHeroActor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PresetSavingPath")]
	public string PresetSavingPath
	{
		get
		{
			CheckDestroyed();
			if (!PresetSavingPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PresetSavingPath");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PresetSavingPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PresetSavingPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PresetSavingPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PresetSavingPath_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PresetSavingName")]
	public string PresetSavingName
	{
		get
		{
			CheckDestroyed();
			if (!PresetSavingName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PresetSavingName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PresetSavingName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PresetSavingName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PresetSavingName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PresetSavingName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:TargetAnimFrame")]
	public int TargetAnimFrame
	{
		get
		{
			CheckDestroyed();
			if (!TargetAnimFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:TargetAnimFrame");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetAnimFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetAnimFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:TargetAnimFrame");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetAnimFrame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PreviewPreset")]
	public UGSRTAvatarConfigPreset PreviewPreset
	{
		get
		{
			CheckDestroyed();
			if (!PreviewPreset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PreviewPreset");
				return null;
			}
			return UObjectMarshaler<UGSRTAvatarConfigPreset>.FromNative(IntPtr.Add(base.Address, PreviewPreset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviewPreset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PreviewPreset");
			}
			else
			{
				UObjectMarshaler<UGSRTAvatarConfigPreset>.ToNative(IntPtr.Add(base.Address, PreviewPreset_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:TakeShot")]
	public unsafe void TakeShot()
	{
		CheckDestroyed();
		if (!TakeShot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:TakeShot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TakeShot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TakeShot_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: TakeShot_FunctionAddress, argsSize: TakeShot_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:StopAnimating")]
	public unsafe void StopAnimating()
	{
		CheckDestroyed();
		if (!StopAnimating_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:StopAnimating");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAnimating_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAnimating_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopAnimating_FunctionAddress, argsSize: StopAnimating_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:ResumeAnimating")]
	public unsafe void ResumeAnimating()
	{
		CheckDestroyed();
		if (!ResumeAnimating_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:ResumeAnimating");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResumeAnimating_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResumeAnimating_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResumeAnimating_FunctionAddress, argsSize: ResumeAnimating_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PreviewSelectingAvatar")]
	public unsafe void PreviewSelectingAvatar()
	{
		CheckDestroyed();
		if (!PreviewSelectingAvatar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PreviewSelectingAvatar");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreviewSelectingAvatar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreviewSelectingAvatar_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreviewSelectingAvatar_FunctionAddress, argsSize: PreviewSelectingAvatar_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:IsAnimPlaying")]
	public unsafe bool IsAnimPlaying()
	{
		CheckDestroyed();
		if (!IsAnimPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:IsAnimPlaying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAnimPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAnimPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsAnimPlaying_FunctionAddress, intPtr, IsAnimPlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAnimPlaying_ReturnValue_Offset), 0, IsAnimPlaying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:GenerateDAPreset")]
	public unsafe void GenerateDAPreset()
	{
		CheckDestroyed();
		if (!GenerateDAPreset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:GenerateDAPreset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateDAPreset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateDAPreset_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GenerateDAPreset_FunctionAddress, argsSize: GenerateDAPreset_ParamsSize);
	}

	static AGSRTAvatarEditingUtilActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSRTAvatarEditingUtilActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSRTAvatarEditingUtilActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor");
		EditingRTCamera_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EditingRTCamera");
		EditingRTCamera_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EditingRTCamera", Classes.FObjectProperty);
		EditingHeroActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EditingHeroActor");
		EditingHeroActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EditingHeroActor", Classes.FObjectProperty);
		PresetSavingPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PresetSavingPath");
		PresetSavingPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PresetSavingPath", Classes.FStrProperty);
		PresetSavingName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PresetSavingName");
		PresetSavingName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PresetSavingName", Classes.FStrProperty);
		TargetAnimFrame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetAnimFrame");
		TargetAnimFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetAnimFrame", Classes.FIntProperty);
		PreviewPreset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreviewPreset");
		PreviewPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreviewPreset", Classes.FObjectProperty);
		TakeShot_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TakeShot");
		TakeShot_ParamsSize = NativeReflection.GetFunctionParamsSize(TakeShot_FunctionAddress);
		TakeShot_IsValid = TakeShot_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:TakeShot", TakeShot_IsValid);
		StopAnimating_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAnimating");
		StopAnimating_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAnimating_FunctionAddress);
		StopAnimating_IsValid = StopAnimating_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:StopAnimating", StopAnimating_IsValid);
		ResumeAnimating_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResumeAnimating");
		ResumeAnimating_ParamsSize = NativeReflection.GetFunctionParamsSize(ResumeAnimating_FunctionAddress);
		ResumeAnimating_IsValid = ResumeAnimating_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:ResumeAnimating", ResumeAnimating_IsValid);
		PreviewSelectingAvatar_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreviewSelectingAvatar");
		PreviewSelectingAvatar_ParamsSize = NativeReflection.GetFunctionParamsSize(PreviewSelectingAvatar_FunctionAddress);
		PreviewSelectingAvatar_IsValid = PreviewSelectingAvatar_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:PreviewSelectingAvatar", PreviewSelectingAvatar_IsValid);
		IsAnimPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsAnimPlaying");
		IsAnimPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAnimPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAnimPlaying_ReturnValue_PropertyAddress, IsAnimPlaying_FunctionAddress, "ReturnValue");
		IsAnimPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAnimPlaying_FunctionAddress, "ReturnValue");
		IsAnimPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnimPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAnimPlaying_IsValid = IsAnimPlaying_FunctionAddress != IntPtr.Zero && IsAnimPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:IsAnimPlaying", IsAnimPlaying_IsValid);
		GenerateDAPreset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenerateDAPreset");
		GenerateDAPreset_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateDAPreset_FunctionAddress);
		GenerateDAPreset_IsValid = GenerateDAPreset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSRTAvatarEditingUtilActor:GenerateDAPreset", GenerateDAPreset_IsValid);
	}
}
