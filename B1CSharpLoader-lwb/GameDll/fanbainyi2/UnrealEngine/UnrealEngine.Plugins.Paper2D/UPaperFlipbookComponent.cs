using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperFlipbookComponent", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UPaperFlipbookComponent : UMeshComponent
{
	private static bool SpriteColor_IsValid;

	private static int SpriteColor_Offset;

	private static bool OnFinishedPlaying_IsValid;

	private static int OnFinishedPlaying_Offset;

	private FFlipbookFinishedPlaySignature OnFinishedPlaying_DelegateCached;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool SetSpriteColor_IsValid;

	private static IntPtr SetSpriteColor_FunctionAddress;

	private static int SetSpriteColor_ParamsSize;

	private static bool SetSpriteColor_NewColor_IsValid;

	private static FFieldAddress SetSpriteColor_NewColor_PropertyAddress;

	private static int SetSpriteColor_NewColor_Offset;

	private static bool SetPlayRate_IsValid;

	private static IntPtr SetPlayRate_FunctionAddress;

	private static int SetPlayRate_ParamsSize;

	private static bool SetPlayRate_NewRate_IsValid;

	private static FFieldAddress SetPlayRate_NewRate_PropertyAddress;

	private static int SetPlayRate_NewRate_Offset;

	private static bool SetPlaybackPositionInFrames_IsValid;

	private static IntPtr SetPlaybackPositionInFrames_FunctionAddress;

	private static int SetPlaybackPositionInFrames_ParamsSize;

	private static bool SetPlaybackPositionInFrames_NewFramePosition_IsValid;

	private static FFieldAddress SetPlaybackPositionInFrames_NewFramePosition_PropertyAddress;

	private static int SetPlaybackPositionInFrames_NewFramePosition_Offset;

	private static bool SetPlaybackPositionInFrames_bFireEvents_IsValid;

	private static FFieldAddress SetPlaybackPositionInFrames_bFireEvents_PropertyAddress;

	private static int SetPlaybackPositionInFrames_bFireEvents_Offset;

	private static bool SetPlaybackPosition_IsValid;

	private static IntPtr SetPlaybackPosition_FunctionAddress;

	private static int SetPlaybackPosition_ParamsSize;

	private static bool SetPlaybackPosition_NewPosition_IsValid;

	private static FFieldAddress SetPlaybackPosition_NewPosition_PropertyAddress;

	private static int SetPlaybackPosition_NewPosition_Offset;

	private static bool SetPlaybackPosition_bFireEvents_IsValid;

	private static FFieldAddress SetPlaybackPosition_bFireEvents_PropertyAddress;

	private static int SetPlaybackPosition_bFireEvents_Offset;

	private static bool SetNewTime_IsValid;

	private static IntPtr SetNewTime_FunctionAddress;

	private static int SetNewTime_ParamsSize;

	private static bool SetNewTime_NewTime_IsValid;

	private static FFieldAddress SetNewTime_NewTime_PropertyAddress;

	private static int SetNewTime_NewTime_Offset;

	private static bool SetLooping_IsValid;

	private static IntPtr SetLooping_FunctionAddress;

	private static int SetLooping_ParamsSize;

	private static bool SetLooping_bNewLooping_IsValid;

	private static FFieldAddress SetLooping_bNewLooping_PropertyAddress;

	private static int SetLooping_bNewLooping_Offset;

	private static bool SetFlipbook_IsValid;

	private static IntPtr SetFlipbook_FunctionAddress;

	private static int SetFlipbook_ParamsSize;

	private static bool SetFlipbook_NewFlipbook_IsValid;

	private static FFieldAddress SetFlipbook_NewFlipbook_PropertyAddress;

	private static int SetFlipbook_NewFlipbook_Offset;

	private static bool SetFlipbook_ReturnValue_IsValid;

	private static FFieldAddress SetFlipbook_ReturnValue_PropertyAddress;

	private static int SetFlipbook_ReturnValue_Offset;

	private static bool ReverseFromEnd_IsValid;

	private static IntPtr ReverseFromEnd_FunctionAddress;

	private static int ReverseFromEnd_ParamsSize;

	private static bool Reverse_IsValid;

	private static IntPtr Reverse_FunctionAddress;

	private static int Reverse_ParamsSize;

	private static bool PlayFromStart_IsValid;

	private static IntPtr PlayFromStart_FunctionAddress;

	private static int PlayFromStart_ParamsSize;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool IsReversing_IsValid;

	private static IntPtr IsReversing_FunctionAddress;

	private static int IsReversing_ParamsSize;

	private static bool IsReversing_ReturnValue_IsValid;

	private static FFieldAddress IsReversing_ReturnValue_PropertyAddress;

	private static int IsReversing_ReturnValue_Offset;

	private static bool IsPlaying_IsValid;

	private static IntPtr IsPlaying_FunctionAddress;

	private static int IsPlaying_ParamsSize;

	private static bool IsPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsPlaying_ReturnValue_PropertyAddress;

	private static int IsPlaying_ReturnValue_Offset;

	private static bool IsLooping_IsValid;

	private static IntPtr IsLooping_FunctionAddress;

	private static int IsLooping_ParamsSize;

	private static bool IsLooping_ReturnValue_IsValid;

	private static FFieldAddress IsLooping_ReturnValue_PropertyAddress;

	private static int IsLooping_ReturnValue_Offset;

	private static bool GetSpriteColor_IsValid;

	private static IntPtr GetSpriteColor_FunctionAddress;

	private static int GetSpriteColor_ParamsSize;

	private static bool GetSpriteColor_ReturnValue_IsValid;

	private static FFieldAddress GetSpriteColor_ReturnValue_PropertyAddress;

	private static int GetSpriteColor_ReturnValue_Offset;

	private static bool GetPlayRate_IsValid;

	private static IntPtr GetPlayRate_FunctionAddress;

	private static int GetPlayRate_ParamsSize;

	private static bool GetPlayRate_ReturnValue_IsValid;

	private static FFieldAddress GetPlayRate_ReturnValue_PropertyAddress;

	private static int GetPlayRate_ReturnValue_Offset;

	private static bool GetPlaybackPositionInFrames_IsValid;

	private static IntPtr GetPlaybackPositionInFrames_FunctionAddress;

	private static int GetPlaybackPositionInFrames_ParamsSize;

	private static bool GetPlaybackPositionInFrames_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackPositionInFrames_ReturnValue_PropertyAddress;

	private static int GetPlaybackPositionInFrames_ReturnValue_Offset;

	private static bool GetPlaybackPosition_IsValid;

	private static IntPtr GetPlaybackPosition_FunctionAddress;

	private static int GetPlaybackPosition_ParamsSize;

	private static bool GetPlaybackPosition_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackPosition_ReturnValue_PropertyAddress;

	private static int GetPlaybackPosition_ReturnValue_Offset;

	private static bool GetFlipbookLengthInFrames_IsValid;

	private static IntPtr GetFlipbookLengthInFrames_FunctionAddress;

	private static int GetFlipbookLengthInFrames_ParamsSize;

	private static bool GetFlipbookLengthInFrames_ReturnValue_IsValid;

	private static FFieldAddress GetFlipbookLengthInFrames_ReturnValue_PropertyAddress;

	private static int GetFlipbookLengthInFrames_ReturnValue_Offset;

	private static bool GetFlipbookLength_IsValid;

	private static IntPtr GetFlipbookLength_FunctionAddress;

	private static int GetFlipbookLength_ParamsSize;

	private static bool GetFlipbookLength_ReturnValue_IsValid;

	private static FFieldAddress GetFlipbookLength_ReturnValue_PropertyAddress;

	private static int GetFlipbookLength_ReturnValue_Offset;

	private static bool GetFlipbookFramerate_IsValid;

	private static IntPtr GetFlipbookFramerate_FunctionAddress;

	private static int GetFlipbookFramerate_ParamsSize;

	private static bool GetFlipbookFramerate_ReturnValue_IsValid;

	private static FFieldAddress GetFlipbookFramerate_ReturnValue_PropertyAddress;

	private static int GetFlipbookFramerate_ReturnValue_Offset;

	private static bool GetFlipbook_IsValid;

	private static IntPtr GetFlipbook_FunctionAddress;

	private static int GetFlipbook_ParamsSize;

	private static bool GetFlipbook_ReturnValue_IsValid;

	private static FFieldAddress GetFlipbook_ReturnValue_PropertyAddress;

	private static int GetFlipbook_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267873544602133uL)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:SpriteColor")]
	protected FLinearColor SpriteColor
	{
		get
		{
			CheckDestroyed();
			if (!SpriteColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperFlipbookComponent:SpriteColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, SpriteColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpriteColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperFlipbookComponent:SpriteColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, SpriteColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:OnFinishedPlaying")]
	public FFlipbookFinishedPlaySignature OnFinishedPlaying
	{
		get
		{
			CheckDestroyed();
			if (!OnFinishedPlaying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperFlipbookComponent:OnFinishedPlaying");
				return new FFlipbookFinishedPlaySignature();
			}
			if (OnFinishedPlaying_DelegateCached == null)
			{
				OnFinishedPlaying_DelegateCached = new FFlipbookFinishedPlaySignature();
				OnFinishedPlaying_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnFinishedPlaying_Offset));
			}
			return OnFinishedPlaying_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:SetSpriteColor")]
	public unsafe void SetSpriteColor(FLinearColor NewColor)
	{
		CheckDestroyed();
		if (!SetSpriteColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:SetSpriteColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpriteColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpriteColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetSpriteColor_NewColor_Offset), 0, SetSpriteColor_NewColor_PropertyAddress.Address, NewColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSpriteColor_FunctionAddress, intPtr, SetSpriteColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:SetPlayRate")]
	public unsafe void SetPlayRate(float NewRate)
	{
		CheckDestroyed();
		if (!SetPlayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:SetPlayRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlayRate_NewRate_Offset), 0, SetPlayRate_NewRate_PropertyAddress.Address, NewRate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlayRate_FunctionAddress, intPtr, SetPlayRate_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:SetPlaybackPositionInFrames")]
	public unsafe void SetPlaybackPositionInFrames(int NewFramePosition, bool bFireEvents)
	{
		CheckDestroyed();
		if (!SetPlaybackPositionInFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:SetPlaybackPositionInFrames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackPositionInFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackPositionInFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPlaybackPositionInFrames_NewFramePosition_Offset), 0, SetPlaybackPositionInFrames_NewFramePosition_PropertyAddress.Address, NewFramePosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPlaybackPositionInFrames_bFireEvents_Offset), 0, SetPlaybackPositionInFrames_bFireEvents_PropertyAddress.Address, bFireEvents);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaybackPositionInFrames_FunctionAddress, intPtr, SetPlaybackPositionInFrames_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:SetPlaybackPosition")]
	public unsafe void SetPlaybackPosition(float NewPosition, bool bFireEvents)
	{
		CheckDestroyed();
		if (!SetPlaybackPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:SetPlaybackPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaybackPosition_NewPosition_Offset), 0, SetPlaybackPosition_NewPosition_PropertyAddress.Address, NewPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPlaybackPosition_bFireEvents_Offset), 0, SetPlaybackPosition_bFireEvents_PropertyAddress.Address, bFireEvents);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaybackPosition_FunctionAddress, intPtr, SetPlaybackPosition_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:SetNewTime")]
	public unsafe void SetNewTime(float NewTime)
	{
		CheckDestroyed();
		if (!SetNewTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:SetNewTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNewTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNewTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNewTime_NewTime_Offset), 0, SetNewTime_NewTime_PropertyAddress.Address, NewTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNewTime_FunctionAddress, intPtr, SetNewTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:SetLooping")]
	public unsafe void SetLooping(bool bNewLooping)
	{
		CheckDestroyed();
		if (!SetLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:SetLooping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLooping_bNewLooping_Offset), 0, SetLooping_bNewLooping_PropertyAddress.Address, bNewLooping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLooping_FunctionAddress, intPtr, SetLooping_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:SetFlipbook")]
	public unsafe bool SetFlipbook(UPaperFlipbook NewFlipbook)
	{
		CheckDestroyed();
		if (!SetFlipbook_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:SetFlipbook");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFlipbook_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFlipbook_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPaperFlipbook>.ToNative(IntPtr.Add(intPtr, SetFlipbook_NewFlipbook_Offset), 0, SetFlipbook_NewFlipbook_PropertyAddress.Address, NewFlipbook);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFlipbook_FunctionAddress, intPtr, SetFlipbook_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetFlipbook_ReturnValue_Offset), 0, SetFlipbook_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:ReverseFromEnd")]
	public unsafe void ReverseFromEnd()
	{
		CheckDestroyed();
		if (!ReverseFromEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:ReverseFromEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReverseFromEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReverseFromEnd_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReverseFromEnd_FunctionAddress, argsSize: ReverseFromEnd_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:Reverse")]
	public unsafe void Reverse()
	{
		CheckDestroyed();
		if (!Reverse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:Reverse");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Reverse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Reverse_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Reverse_FunctionAddress, argsSize: Reverse_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:PlayFromStart")]
	public unsafe void PlayFromStart()
	{
		CheckDestroyed();
		if (!PlayFromStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:PlayFromStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayFromStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayFromStart_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PlayFromStart_FunctionAddress, argsSize: PlayFromStart_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:Play")]
	public unsafe void Play()
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:Play");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Play_FunctionAddress, argsSize: Play_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:IsReversing")]
	public unsafe bool IsReversing()
	{
		CheckDestroyed();
		if (!IsReversing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:IsReversing");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsReversing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsReversing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsReversing_FunctionAddress, intPtr, IsReversing_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsReversing_ReturnValue_Offset), 0, IsReversing_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:IsPlaying")]
	public unsafe bool IsPlaying()
	{
		CheckDestroyed();
		if (!IsPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:IsPlaying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlaying_FunctionAddress, intPtr, IsPlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlaying_ReturnValue_Offset), 0, IsPlaying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:IsLooping")]
	public unsafe bool IsLooping()
	{
		CheckDestroyed();
		if (!IsLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:IsLooping");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLooping_FunctionAddress, intPtr, IsLooping_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLooping_ReturnValue_Offset), 0, IsLooping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:GetSpriteColor")]
	public unsafe FLinearColor GetSpriteColor()
	{
		CheckDestroyed();
		if (!GetSpriteColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:GetSpriteColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpriteColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpriteColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpriteColor_FunctionAddress, intPtr, GetSpriteColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetSpriteColor_ReturnValue_Offset), 0, GetSpriteColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:GetPlayRate")]
	public unsafe float GetPlayRate()
	{
		CheckDestroyed();
		if (!GetPlayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:GetPlayRate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayRate_FunctionAddress, intPtr, GetPlayRate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlayRate_ReturnValue_Offset), 0, GetPlayRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:GetPlaybackPositionInFrames")]
	public unsafe int GetPlaybackPositionInFrames()
	{
		CheckDestroyed();
		if (!GetPlaybackPositionInFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:GetPlaybackPositionInFrames");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackPositionInFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackPositionInFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaybackPositionInFrames_FunctionAddress, intPtr, GetPlaybackPositionInFrames_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPlaybackPositionInFrames_ReturnValue_Offset), 0, GetPlaybackPositionInFrames_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:GetPlaybackPosition")]
	public unsafe float GetPlaybackPosition()
	{
		CheckDestroyed();
		if (!GetPlaybackPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:GetPlaybackPosition");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaybackPosition_FunctionAddress, intPtr, GetPlaybackPosition_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlaybackPosition_ReturnValue_Offset), 0, GetPlaybackPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:GetFlipbookLengthInFrames")]
	public unsafe int GetFlipbookLengthInFrames()
	{
		CheckDestroyed();
		if (!GetFlipbookLengthInFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:GetFlipbookLengthInFrames");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFlipbookLengthInFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFlipbookLengthInFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFlipbookLengthInFrames_FunctionAddress, intPtr, GetFlipbookLengthInFrames_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetFlipbookLengthInFrames_ReturnValue_Offset), 0, GetFlipbookLengthInFrames_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:GetFlipbookLength")]
	public unsafe float GetFlipbookLength()
	{
		CheckDestroyed();
		if (!GetFlipbookLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:GetFlipbookLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFlipbookLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFlipbookLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFlipbookLength_FunctionAddress, intPtr, GetFlipbookLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFlipbookLength_ReturnValue_Offset), 0, GetFlipbookLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:GetFlipbookFramerate")]
	public unsafe float GetFlipbookFramerate()
	{
		CheckDestroyed();
		if (!GetFlipbookFramerate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:GetFlipbookFramerate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFlipbookFramerate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFlipbookFramerate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFlipbookFramerate_FunctionAddress, intPtr, GetFlipbookFramerate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFlipbookFramerate_ReturnValue_Offset), 0, GetFlipbookFramerate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676416u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbookComponent:GetFlipbook")]
	public unsafe UPaperFlipbook GetFlipbook()
	{
		CheckDestroyed();
		if (!GetFlipbook_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbookComponent:GetFlipbook");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFlipbook_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFlipbook_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFlipbook_FunctionAddress, intPtr, GetFlipbook_ParamsSize);
		return UObjectMarshaler<UPaperFlipbook>.FromNative(IntPtr.Add(intPtr, GetFlipbook_ReturnValue_Offset), 0, GetFlipbook_ReturnValue_PropertyAddress.Address);
	}

	static UPaperFlipbookComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaperFlipbookComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaperFlipbookComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Paper2D.PaperFlipbookComponent");
		SpriteColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpriteColor");
		SpriteColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpriteColor", Classes.FStructProperty);
		OnFinishedPlaying_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnFinishedPlaying");
		OnFinishedPlaying_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnFinishedPlaying", Classes.FMulticastDelegateProperty);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:Stop", Stop_IsValid);
		SetSpriteColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSpriteColor");
		SetSpriteColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpriteColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpriteColor_NewColor_PropertyAddress, SetSpriteColor_FunctionAddress, "NewColor");
		SetSpriteColor_NewColor_Offset = NativeReflectionCached.GetPropertyOffset(SetSpriteColor_FunctionAddress, "NewColor");
		SetSpriteColor_NewColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpriteColor_FunctionAddress, "NewColor", Classes.FStructProperty);
		SetSpriteColor_IsValid = SetSpriteColor_FunctionAddress != IntPtr.Zero && SetSpriteColor_NewColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:SetSpriteColor", SetSpriteColor_IsValid);
		SetPlayRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlayRate");
		SetPlayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlayRate_NewRate_PropertyAddress, SetPlayRate_FunctionAddress, "NewRate");
		SetPlayRate_NewRate_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayRate_FunctionAddress, "NewRate");
		SetPlayRate_NewRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayRate_FunctionAddress, "NewRate", Classes.FFloatProperty);
		SetPlayRate_IsValid = SetPlayRate_FunctionAddress != IntPtr.Zero && SetPlayRate_NewRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:SetPlayRate", SetPlayRate_IsValid);
		SetPlaybackPositionInFrames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaybackPositionInFrames");
		SetPlaybackPositionInFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackPositionInFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackPositionInFrames_NewFramePosition_PropertyAddress, SetPlaybackPositionInFrames_FunctionAddress, "NewFramePosition");
		SetPlaybackPositionInFrames_NewFramePosition_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackPositionInFrames_FunctionAddress, "NewFramePosition");
		SetPlaybackPositionInFrames_NewFramePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackPositionInFrames_FunctionAddress, "NewFramePosition", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackPositionInFrames_bFireEvents_PropertyAddress, SetPlaybackPositionInFrames_FunctionAddress, "bFireEvents");
		SetPlaybackPositionInFrames_bFireEvents_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackPositionInFrames_FunctionAddress, "bFireEvents");
		SetPlaybackPositionInFrames_bFireEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackPositionInFrames_FunctionAddress, "bFireEvents", Classes.FBoolProperty);
		SetPlaybackPositionInFrames_IsValid = SetPlaybackPositionInFrames_FunctionAddress != IntPtr.Zero && SetPlaybackPositionInFrames_NewFramePosition_IsValid && SetPlaybackPositionInFrames_bFireEvents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:SetPlaybackPositionInFrames", SetPlaybackPositionInFrames_IsValid);
		SetPlaybackPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaybackPosition");
		SetPlaybackPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackPosition_NewPosition_PropertyAddress, SetPlaybackPosition_FunctionAddress, "NewPosition");
		SetPlaybackPosition_NewPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackPosition_FunctionAddress, "NewPosition");
		SetPlaybackPosition_NewPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackPosition_FunctionAddress, "NewPosition", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackPosition_bFireEvents_PropertyAddress, SetPlaybackPosition_FunctionAddress, "bFireEvents");
		SetPlaybackPosition_bFireEvents_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackPosition_FunctionAddress, "bFireEvents");
		SetPlaybackPosition_bFireEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackPosition_FunctionAddress, "bFireEvents", Classes.FBoolProperty);
		SetPlaybackPosition_IsValid = SetPlaybackPosition_FunctionAddress != IntPtr.Zero && SetPlaybackPosition_NewPosition_IsValid && SetPlaybackPosition_bFireEvents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:SetPlaybackPosition", SetPlaybackPosition_IsValid);
		SetNewTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNewTime");
		SetNewTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNewTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNewTime_NewTime_PropertyAddress, SetNewTime_FunctionAddress, "NewTime");
		SetNewTime_NewTime_Offset = NativeReflectionCached.GetPropertyOffset(SetNewTime_FunctionAddress, "NewTime");
		SetNewTime_NewTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNewTime_FunctionAddress, "NewTime", Classes.FFloatProperty);
		SetNewTime_IsValid = SetNewTime_FunctionAddress != IntPtr.Zero && SetNewTime_NewTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:SetNewTime", SetNewTime_IsValid);
		SetLooping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLooping");
		SetLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLooping_bNewLooping_PropertyAddress, SetLooping_FunctionAddress, "bNewLooping");
		SetLooping_bNewLooping_Offset = NativeReflectionCached.GetPropertyOffset(SetLooping_FunctionAddress, "bNewLooping");
		SetLooping_bNewLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLooping_FunctionAddress, "bNewLooping", Classes.FBoolProperty);
		SetLooping_IsValid = SetLooping_FunctionAddress != IntPtr.Zero && SetLooping_bNewLooping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:SetLooping", SetLooping_IsValid);
		SetFlipbook_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFlipbook");
		SetFlipbook_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFlipbook_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFlipbook_NewFlipbook_PropertyAddress, SetFlipbook_FunctionAddress, "NewFlipbook");
		SetFlipbook_NewFlipbook_Offset = NativeReflectionCached.GetPropertyOffset(SetFlipbook_FunctionAddress, "NewFlipbook");
		SetFlipbook_NewFlipbook_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFlipbook_FunctionAddress, "NewFlipbook", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFlipbook_ReturnValue_PropertyAddress, SetFlipbook_FunctionAddress, "ReturnValue");
		SetFlipbook_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetFlipbook_FunctionAddress, "ReturnValue");
		SetFlipbook_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFlipbook_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetFlipbook_IsValid = SetFlipbook_FunctionAddress != IntPtr.Zero && SetFlipbook_NewFlipbook_IsValid && SetFlipbook_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:SetFlipbook", SetFlipbook_IsValid);
		ReverseFromEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReverseFromEnd");
		ReverseFromEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(ReverseFromEnd_FunctionAddress);
		ReverseFromEnd_IsValid = ReverseFromEnd_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:ReverseFromEnd", ReverseFromEnd_IsValid);
		Reverse_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Reverse");
		Reverse_ParamsSize = NativeReflection.GetFunctionParamsSize(Reverse_FunctionAddress);
		Reverse_IsValid = Reverse_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:Reverse", Reverse_IsValid);
		PlayFromStart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayFromStart");
		PlayFromStart_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayFromStart_FunctionAddress);
		PlayFromStart_IsValid = PlayFromStart_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:PlayFromStart", PlayFromStart_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:Play", Play_IsValid);
		IsReversing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsReversing");
		IsReversing_ParamsSize = NativeReflection.GetFunctionParamsSize(IsReversing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsReversing_ReturnValue_PropertyAddress, IsReversing_FunctionAddress, "ReturnValue");
		IsReversing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsReversing_FunctionAddress, "ReturnValue");
		IsReversing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsReversing_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsReversing_IsValid = IsReversing_FunctionAddress != IntPtr.Zero && IsReversing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:IsReversing", IsReversing_IsValid);
		IsPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlaying");
		IsPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_ReturnValue_PropertyAddress, IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlaying_IsValid = IsPlaying_FunctionAddress != IntPtr.Zero && IsPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:IsPlaying", IsPlaying_IsValid);
		IsLooping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLooping");
		IsLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLooping_ReturnValue_PropertyAddress, IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLooping_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLooping_IsValid = IsLooping_FunctionAddress != IntPtr.Zero && IsLooping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:IsLooping", IsLooping_IsValid);
		GetSpriteColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSpriteColor");
		GetSpriteColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpriteColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpriteColor_ReturnValue_PropertyAddress, GetSpriteColor_FunctionAddress, "ReturnValue");
		GetSpriteColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpriteColor_FunctionAddress, "ReturnValue");
		GetSpriteColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpriteColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSpriteColor_IsValid = GetSpriteColor_FunctionAddress != IntPtr.Zero && GetSpriteColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:GetSpriteColor", GetSpriteColor_IsValid);
		GetPlayRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayRate");
		GetPlayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayRate_ReturnValue_PropertyAddress, GetPlayRate_FunctionAddress, "ReturnValue");
		GetPlayRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayRate_FunctionAddress, "ReturnValue");
		GetPlayRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayRate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlayRate_IsValid = GetPlayRate_FunctionAddress != IntPtr.Zero && GetPlayRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:GetPlayRate", GetPlayRate_IsValid);
		GetPlaybackPositionInFrames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlaybackPositionInFrames");
		GetPlaybackPositionInFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackPositionInFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackPositionInFrames_ReturnValue_PropertyAddress, GetPlaybackPositionInFrames_FunctionAddress, "ReturnValue");
		GetPlaybackPositionInFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackPositionInFrames_FunctionAddress, "ReturnValue");
		GetPlaybackPositionInFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackPositionInFrames_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPlaybackPositionInFrames_IsValid = GetPlaybackPositionInFrames_FunctionAddress != IntPtr.Zero && GetPlaybackPositionInFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:GetPlaybackPositionInFrames", GetPlaybackPositionInFrames_IsValid);
		GetPlaybackPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlaybackPosition");
		GetPlaybackPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackPosition_ReturnValue_PropertyAddress, GetPlaybackPosition_FunctionAddress, "ReturnValue");
		GetPlaybackPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackPosition_FunctionAddress, "ReturnValue");
		GetPlaybackPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackPosition_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlaybackPosition_IsValid = GetPlaybackPosition_FunctionAddress != IntPtr.Zero && GetPlaybackPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:GetPlaybackPosition", GetPlaybackPosition_IsValid);
		GetFlipbookLengthInFrames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFlipbookLengthInFrames");
		GetFlipbookLengthInFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFlipbookLengthInFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFlipbookLengthInFrames_ReturnValue_PropertyAddress, GetFlipbookLengthInFrames_FunctionAddress, "ReturnValue");
		GetFlipbookLengthInFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFlipbookLengthInFrames_FunctionAddress, "ReturnValue");
		GetFlipbookLengthInFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFlipbookLengthInFrames_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetFlipbookLengthInFrames_IsValid = GetFlipbookLengthInFrames_FunctionAddress != IntPtr.Zero && GetFlipbookLengthInFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:GetFlipbookLengthInFrames", GetFlipbookLengthInFrames_IsValid);
		GetFlipbookLength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFlipbookLength");
		GetFlipbookLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFlipbookLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFlipbookLength_ReturnValue_PropertyAddress, GetFlipbookLength_FunctionAddress, "ReturnValue");
		GetFlipbookLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFlipbookLength_FunctionAddress, "ReturnValue");
		GetFlipbookLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFlipbookLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFlipbookLength_IsValid = GetFlipbookLength_FunctionAddress != IntPtr.Zero && GetFlipbookLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:GetFlipbookLength", GetFlipbookLength_IsValid);
		GetFlipbookFramerate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFlipbookFramerate");
		GetFlipbookFramerate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFlipbookFramerate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFlipbookFramerate_ReturnValue_PropertyAddress, GetFlipbookFramerate_FunctionAddress, "ReturnValue");
		GetFlipbookFramerate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFlipbookFramerate_FunctionAddress, "ReturnValue");
		GetFlipbookFramerate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFlipbookFramerate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFlipbookFramerate_IsValid = GetFlipbookFramerate_FunctionAddress != IntPtr.Zero && GetFlipbookFramerate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:GetFlipbookFramerate", GetFlipbookFramerate_IsValid);
		GetFlipbook_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFlipbook");
		GetFlipbook_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFlipbook_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFlipbook_ReturnValue_PropertyAddress, GetFlipbook_FunctionAddress, "ReturnValue");
		GetFlipbook_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFlipbook_FunctionAddress, "ReturnValue");
		GetFlipbook_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFlipbook_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetFlipbook_IsValid = GetFlipbook_FunctionAddress != IntPtr.Zero && GetFlipbook_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbookComponent:GetFlipbook", GetFlipbook_IsValid);
	}
}
