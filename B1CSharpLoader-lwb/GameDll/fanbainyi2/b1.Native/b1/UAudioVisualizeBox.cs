using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821039264uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox", "UnrealExtent", UnrealModuleType.Game)]
public class UAudioVisualizeBox : UUserWidget
{
	private static bool LayoutWidget_IsValid;

	private static int LayoutWidget_Offset;

	private static bool FreqNum_IsValid;

	private static int FreqNum_Offset;

	private static bool LoudnessNum_IsValid;

	private static int LoudnessNum_Offset;

	private static bool FreqSpecInfoArray_IsValid;

	private static FFieldAddress FreqSpecInfoArray_PropertyAddress;

	private static int FreqSpecInfoArray_Offset;

	private TArrayReadWriteMarshaler<float> FreqSpecInfoArray_MarshalerCached;

	private static bool LoudnessInfoArray_IsValid;

	private static FFieldAddress LoudnessInfoArray_PropertyAddress;

	private static int LoudnessInfoArray_Offset;

	private TArrayReadWriteMarshaler<FVector2D> LoudnessInfoArray_MarshalerCached;

	private static bool FreqThickness_IsValid;

	private static int FreqThickness_Offset;

	private static bool FreqColor_IsValid;

	private static int FreqColor_Offset;

	private static bool FreqHeightFinalScale_IsValid;

	private static int FreqHeightFinalScale_Offset;

	private static bool FreqHeightScale_IsValid;

	private static int FreqHeightScale_Offset;

	private static bool FreqPaintPower_IsValid;

	private static int FreqPaintPower_Offset;

	private static bool LoudnessThickness_IsValid;

	private static int LoudnessThickness_Offset;

	private static bool LoudnessColor_IsValid;

	private static int LoudnessColor_Offset;

	private static bool LoudnessHeightRange_IsValid;

	private static int LoudnessHeightRange_Offset;

	private static bool LoudnessRandomScaleFactor_IsValid;

	private static int LoudnessRandomScaleFactor_Offset;

	private static bool OffsetInWidget_IsValid;

	private static int OffsetInWidget_Offset;

	private static bool PaintFreq_IsValid;

	private static FFieldAddress PaintFreq_PropertyAddress;

	private static int PaintFreq_Offset;

	private static bool PaintLoudness_IsValid;

	private static FFieldAddress PaintLoudness_PropertyAddress;

	private static int PaintLoudness_Offset;

	private static bool FreqDisturbInterval_IsValid;

	private static int FreqDisturbInterval_Offset;

	private static bool StopPainting_IsValid;

	private static IntPtr StopPainting_FunctionAddress;

	private static int StopPainting_ParamsSize;

	private static bool StartPainting_IsValid;

	private static IntPtr StartPainting_FunctionAddress;

	private static int StartPainting_ParamsSize;

	private static bool SetLoudnessInfo_IsValid;

	private static IntPtr SetLoudnessInfo_FunctionAddress;

	private static int SetLoudnessInfo_ParamsSize;

	private static bool SetLoudnessInfo_InLoudness_IsValid;

	private static FFieldAddress SetLoudnessInfo_InLoudness_PropertyAddress;

	private static int SetLoudnessInfo_InLoudness_Offset;

	private static bool SetFreqNum_IsValid;

	private static IntPtr SetFreqNum_FunctionAddress;

	private static int SetFreqNum_ParamsSize;

	private static bool SetFreqNum_InFreqNum_IsValid;

	private static FFieldAddress SetFreqNum_InFreqNum_PropertyAddress;

	private static int SetFreqNum_InFreqNum_Offset;

	private static bool SetFreqInfo_IsValid;

	private static IntPtr SetFreqInfo_FunctionAddress;

	private static int SetFreqInfo_ParamsSize;

	private static bool SetFreqInfo_InConstantInfo_IsValid;

	private static FFieldAddress SetFreqInfo_InConstantInfo_PropertyAddress;

	private static int SetFreqInfo_InConstantInfo_Offset;

	private static bool SetAudioInfo_IsValid;

	private static IntPtr SetAudioInfo_FunctionAddress;

	private static int SetAudioInfo_ParamsSize;

	private static bool SetAudioInfo_InLoudness_IsValid;

	private static FFieldAddress SetAudioInfo_InLoudness_PropertyAddress;

	private static int SetAudioInfo_InLoudness_Offset;

	private static bool SetAudioInfo_InConstantInfo_IsValid;

	private static FFieldAddress SetAudioInfo_InConstantInfo_PropertyAddress;

	private static int SetAudioInfo_InConstantInfo_Offset;

	private static bool ResetVisualizing_IsValid;

	private static IntPtr ResetVisualizing_FunctionAddress;

	private static int ResetVisualizing_ParamsSize;

	private static bool PausePainting_IsValid;

	private static IntPtr PausePainting_FunctionAddress;

	private static int PausePainting_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234799116uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:LayoutWidget")]
	public UImage LayoutWidget
	{
		get
		{
			CheckDestroyed();
			if (!LayoutWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LayoutWidget");
				return null;
			}
			return UObjectMarshaler<UImage>.FromNative(IntPtr.Add(base.Address, LayoutWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LayoutWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LayoutWidget");
			}
			else
			{
				UObjectMarshaler<UImage>.ToNative(IntPtr.Add(base.Address, LayoutWidget_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:FreqNum")]
	public int FreqNum
	{
		get
		{
			CheckDestroyed();
			if (!FreqNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FreqNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreqNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FreqNum_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:LoudnessNum")]
	public int LoudnessNum
	{
		get
		{
			CheckDestroyed();
			if (!LoudnessNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LoudnessNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LoudnessNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoudnessNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LoudnessNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LoudnessNum_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:FreqSpecInfoArray")]
	public TArrayReadWrite<float> FreqSpecInfoArray
	{
		get
		{
			CheckDestroyed();
			if (!FreqSpecInfoArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqSpecInfoArray");
				return null;
			}
			if (FreqSpecInfoArray_MarshalerCached == null)
			{
				FreqSpecInfoArray_MarshalerCached = new TArrayReadWriteMarshaler<float>(1, FreqSpecInfoArray_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return FreqSpecInfoArray_MarshalerCached.FromNative(IntPtr.Add(base.Address, FreqSpecInfoArray_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:LoudnessInfoArray")]
	public TArrayReadWrite<FVector2D> LoudnessInfoArray
	{
		get
		{
			CheckDestroyed();
			if (!LoudnessInfoArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LoudnessInfoArray");
				return null;
			}
			if (LoudnessInfoArray_MarshalerCached == null)
			{
				LoudnessInfoArray_MarshalerCached = new TArrayReadWriteMarshaler<FVector2D>(1, LoudnessInfoArray_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative);
			}
			return LoudnessInfoArray_MarshalerCached.FromNative(IntPtr.Add(base.Address, LoudnessInfoArray_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:FreqThickness")]
	public float FreqThickness
	{
		get
		{
			CheckDestroyed();
			if (!FreqThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FreqThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreqThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FreqThickness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:FreqColor")]
	public FLinearColor FreqColor
	{
		get
		{
			CheckDestroyed();
			if (!FreqColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, FreqColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreqColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, FreqColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:FreqHeightFinalScale")]
	public float FreqHeightFinalScale
	{
		get
		{
			CheckDestroyed();
			if (!FreqHeightFinalScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqHeightFinalScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FreqHeightFinalScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreqHeightFinalScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqHeightFinalScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FreqHeightFinalScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:FreqHeightScale")]
	public float FreqHeightScale
	{
		get
		{
			CheckDestroyed();
			if (!FreqHeightScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqHeightScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FreqHeightScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreqHeightScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqHeightScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FreqHeightScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:FreqPaintPower")]
	public float FreqPaintPower
	{
		get
		{
			CheckDestroyed();
			if (!FreqPaintPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqPaintPower");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FreqPaintPower_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreqPaintPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqPaintPower");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FreqPaintPower_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:LoudnessThickness")]
	public float LoudnessThickness
	{
		get
		{
			CheckDestroyed();
			if (!LoudnessThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LoudnessThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LoudnessThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoudnessThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LoudnessThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LoudnessThickness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:LoudnessColor")]
	public FLinearColor LoudnessColor
	{
		get
		{
			CheckDestroyed();
			if (!LoudnessColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LoudnessColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, LoudnessColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoudnessColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LoudnessColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, LoudnessColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:LoudnessHeightRange")]
	public FVector2D LoudnessHeightRange
	{
		get
		{
			CheckDestroyed();
			if (!LoudnessHeightRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LoudnessHeightRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, LoudnessHeightRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoudnessHeightRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LoudnessHeightRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, LoudnessHeightRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:LoudnessRandomScaleFactor")]
	public float LoudnessRandomScaleFactor
	{
		get
		{
			CheckDestroyed();
			if (!LoudnessRandomScaleFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LoudnessRandomScaleFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LoudnessRandomScaleFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoudnessRandomScaleFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:LoudnessRandomScaleFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LoudnessRandomScaleFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:OffsetInWidget")]
	public FVector2D OffsetInWidget
	{
		get
		{
			CheckDestroyed();
			if (!OffsetInWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:OffsetInWidget");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, OffsetInWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OffsetInWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:OffsetInWidget");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, OffsetInWidget_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:PaintFreq")]
	public bool PaintFreq
	{
		get
		{
			CheckDestroyed();
			if (!PaintFreq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:PaintFreq");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PaintFreq_Offset), 0, PaintFreq_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PaintFreq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:PaintFreq");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PaintFreq_Offset), 0, PaintFreq_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:PaintLoudness")]
	public bool PaintLoudness
	{
		get
		{
			CheckDestroyed();
			if (!PaintLoudness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:PaintLoudness");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PaintLoudness_Offset), 0, PaintLoudness_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PaintLoudness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:PaintLoudness");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PaintLoudness_Offset), 0, PaintLoudness_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:FreqDisturbInterval")]
	public float FreqDisturbInterval
	{
		get
		{
			CheckDestroyed();
			if (!FreqDisturbInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqDisturbInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FreqDisturbInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreqDisturbInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AudioVisualizeBox:FreqDisturbInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FreqDisturbInterval_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:StopPainting")]
	public unsafe void StopPainting()
	{
		CheckDestroyed();
		if (!StopPainting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AudioVisualizeBox:StopPainting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopPainting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopPainting_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopPainting_FunctionAddress, argsSize: StopPainting_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:StartPainting")]
	public unsafe void StartPainting()
	{
		CheckDestroyed();
		if (!StartPainting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AudioVisualizeBox:StartPainting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartPainting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartPainting_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartPainting_FunctionAddress, argsSize: StartPainting_ParamsSize);
	}

	[UFunction(Flags = 76022785u)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:SetLoudnessInfo")]
	protected unsafe void SetLoudnessInfo(FVector2D InLoudness)
	{
		CheckDestroyed();
		if (!SetLoudnessInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AudioVisualizeBox:SetLoudnessInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLoudnessInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLoudnessInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetLoudnessInfo_InLoudness_Offset), 0, SetLoudnessInfo_InLoudness_PropertyAddress.Address, InLoudness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLoudnessInfo_FunctionAddress, intPtr, SetLoudnessInfo_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:SetFreqNum")]
	public unsafe void SetFreqNum(int InFreqNum)
	{
		CheckDestroyed();
		if (!SetFreqNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AudioVisualizeBox:SetFreqNum");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFreqNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFreqNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetFreqNum_InFreqNum_Offset), 0, SetFreqNum_InFreqNum_PropertyAddress.Address, InFreqNum);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFreqNum_FunctionAddress, intPtr, SetFreqNum_ParamsSize);
	}

	[UFunction(Flags = 71828481u)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:SetFreqInfo")]
	protected unsafe void SetFreqInfo(List<float> InConstantInfo)
	{
		CheckDestroyed();
		if (!SetFreqInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AudioVisualizeBox:SetFreqInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFreqInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFreqInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<float>(1, SetFreqInfo_InConstantInfo_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SetFreqInfo_InConstantInfo_Offset), InConstantInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFreqInfo_FunctionAddress, intPtr, SetFreqInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetFreqInfo_InConstantInfo_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:SetAudioInfo")]
	public unsafe void SetAudioInfo(FVector2D InLoudness, List<float> InConstantInfo)
	{
		CheckDestroyed();
		if (!SetAudioInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AudioVisualizeBox:SetAudioInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAudioInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAudioInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetAudioInfo_InLoudness_Offset), 0, SetAudioInfo_InLoudness_PropertyAddress.Address, InLoudness);
		new TArrayCopyMarshaler<float>(1, SetAudioInfo_InConstantInfo_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SetAudioInfo_InConstantInfo_Offset), InConstantInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAudioInfo_FunctionAddress, intPtr, SetAudioInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAudioInfo_InConstantInfo_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:ResetVisualizing")]
	public unsafe void ResetVisualizing()
	{
		CheckDestroyed();
		if (!ResetVisualizing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AudioVisualizeBox:ResetVisualizing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetVisualizing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetVisualizing_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetVisualizing_FunctionAddress, argsSize: ResetVisualizing_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AudioVisualizeBox:PausePainting")]
	public unsafe void PausePainting()
	{
		CheckDestroyed();
		if (!PausePainting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AudioVisualizeBox:PausePainting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PausePainting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PausePainting_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PausePainting_FunctionAddress, argsSize: PausePainting_ParamsSize);
	}

	static UAudioVisualizeBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAudioVisualizeBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAudioVisualizeBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.AudioVisualizeBox");
		LayoutWidget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LayoutWidget");
		LayoutWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LayoutWidget", Classes.FObjectProperty);
		FreqNum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FreqNum");
		FreqNum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FreqNum", Classes.FIntProperty);
		LoudnessNum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoudnessNum");
		LoudnessNum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoudnessNum", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FreqSpecInfoArray_PropertyAddress, intPtr, "FreqSpecInfoArray");
		FreqSpecInfoArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FreqSpecInfoArray");
		FreqSpecInfoArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FreqSpecInfoArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LoudnessInfoArray_PropertyAddress, intPtr, "LoudnessInfoArray");
		LoudnessInfoArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoudnessInfoArray");
		LoudnessInfoArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoudnessInfoArray", Classes.FArrayProperty);
		FreqThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FreqThickness");
		FreqThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FreqThickness", Classes.FFloatProperty);
		FreqColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FreqColor");
		FreqColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FreqColor", Classes.FStructProperty);
		FreqHeightFinalScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FreqHeightFinalScale");
		FreqHeightFinalScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FreqHeightFinalScale", Classes.FFloatProperty);
		FreqHeightScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FreqHeightScale");
		FreqHeightScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FreqHeightScale", Classes.FFloatProperty);
		FreqPaintPower_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FreqPaintPower");
		FreqPaintPower_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FreqPaintPower", Classes.FFloatProperty);
		LoudnessThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoudnessThickness");
		LoudnessThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoudnessThickness", Classes.FFloatProperty);
		LoudnessColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoudnessColor");
		LoudnessColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoudnessColor", Classes.FStructProperty);
		LoudnessHeightRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoudnessHeightRange");
		LoudnessHeightRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoudnessHeightRange", Classes.FStructProperty);
		LoudnessRandomScaleFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoudnessRandomScaleFactor");
		LoudnessRandomScaleFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoudnessRandomScaleFactor", Classes.FFloatProperty);
		OffsetInWidget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OffsetInWidget");
		OffsetInWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OffsetInWidget", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PaintFreq_PropertyAddress, intPtr, "PaintFreq");
		PaintFreq_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PaintFreq");
		PaintFreq_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PaintFreq", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PaintLoudness_PropertyAddress, intPtr, "PaintLoudness");
		PaintLoudness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PaintLoudness");
		PaintLoudness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PaintLoudness", Classes.FBoolProperty);
		FreqDisturbInterval_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FreqDisturbInterval");
		FreqDisturbInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FreqDisturbInterval", Classes.FFloatProperty);
		StopPainting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopPainting");
		StopPainting_ParamsSize = NativeReflection.GetFunctionParamsSize(StopPainting_FunctionAddress);
		StopPainting_IsValid = StopPainting_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AudioVisualizeBox:StopPainting", StopPainting_IsValid);
		StartPainting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartPainting");
		StartPainting_ParamsSize = NativeReflection.GetFunctionParamsSize(StartPainting_FunctionAddress);
		StartPainting_IsValid = StartPainting_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AudioVisualizeBox:StartPainting", StartPainting_IsValid);
		SetLoudnessInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLoudnessInfo");
		SetLoudnessInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLoudnessInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLoudnessInfo_InLoudness_PropertyAddress, SetLoudnessInfo_FunctionAddress, "InLoudness");
		SetLoudnessInfo_InLoudness_Offset = NativeReflectionCached.GetPropertyOffset(SetLoudnessInfo_FunctionAddress, "InLoudness");
		SetLoudnessInfo_InLoudness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLoudnessInfo_FunctionAddress, "InLoudness", Classes.FStructProperty);
		SetLoudnessInfo_IsValid = SetLoudnessInfo_FunctionAddress != IntPtr.Zero && SetLoudnessInfo_InLoudness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AudioVisualizeBox:SetLoudnessInfo", SetLoudnessInfo_IsValid);
		SetFreqNum_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFreqNum");
		SetFreqNum_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFreqNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFreqNum_InFreqNum_PropertyAddress, SetFreqNum_FunctionAddress, "InFreqNum");
		SetFreqNum_InFreqNum_Offset = NativeReflectionCached.GetPropertyOffset(SetFreqNum_FunctionAddress, "InFreqNum");
		SetFreqNum_InFreqNum_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFreqNum_FunctionAddress, "InFreqNum", Classes.FIntProperty);
		SetFreqNum_IsValid = SetFreqNum_FunctionAddress != IntPtr.Zero && SetFreqNum_InFreqNum_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AudioVisualizeBox:SetFreqNum", SetFreqNum_IsValid);
		SetFreqInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFreqInfo");
		SetFreqInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFreqInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFreqInfo_InConstantInfo_PropertyAddress, SetFreqInfo_FunctionAddress, "InConstantInfo");
		SetFreqInfo_InConstantInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetFreqInfo_FunctionAddress, "InConstantInfo");
		SetFreqInfo_InConstantInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFreqInfo_FunctionAddress, "InConstantInfo", Classes.FArrayProperty);
		SetFreqInfo_IsValid = SetFreqInfo_FunctionAddress != IntPtr.Zero && SetFreqInfo_InConstantInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AudioVisualizeBox:SetFreqInfo", SetFreqInfo_IsValid);
		SetAudioInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAudioInfo");
		SetAudioInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAudioInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAudioInfo_InLoudness_PropertyAddress, SetAudioInfo_FunctionAddress, "InLoudness");
		SetAudioInfo_InLoudness_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioInfo_FunctionAddress, "InLoudness");
		SetAudioInfo_InLoudness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioInfo_FunctionAddress, "InLoudness", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAudioInfo_InConstantInfo_PropertyAddress, SetAudioInfo_FunctionAddress, "InConstantInfo");
		SetAudioInfo_InConstantInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioInfo_FunctionAddress, "InConstantInfo");
		SetAudioInfo_InConstantInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioInfo_FunctionAddress, "InConstantInfo", Classes.FArrayProperty);
		SetAudioInfo_IsValid = SetAudioInfo_FunctionAddress != IntPtr.Zero && SetAudioInfo_InLoudness_IsValid && SetAudioInfo_InConstantInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AudioVisualizeBox:SetAudioInfo", SetAudioInfo_IsValid);
		ResetVisualizing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetVisualizing");
		ResetVisualizing_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetVisualizing_FunctionAddress);
		ResetVisualizing_IsValid = ResetVisualizing_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AudioVisualizeBox:ResetVisualizing", ResetVisualizing_IsValid);
		PausePainting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PausePainting");
		PausePainting_ParamsSize = NativeReflection.GetFunctionParamsSize(PausePainting_FunctionAddress);
		PausePainting_IsValid = PausePainting_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AudioVisualizeBox:PausePainting", PausePainting_IsValid);
	}
}
