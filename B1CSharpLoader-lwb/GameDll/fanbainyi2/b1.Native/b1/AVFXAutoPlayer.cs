using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)817889444uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer", "UnrealExtent", UnrealModuleType.Game)]
public class AVFXAutoPlayer : AActor
{
	private static bool PlayList_IsValid;

	private static FFieldAddress PlayList_PropertyAddress;

	private static int PlayList_Offset;

	private TArrayReadWriteMarshaler<string> PlayList_MarshalerCached;

	private static bool PlayingPtr_IsValid;

	private static int PlayingPtr_Offset;

	private static bool MaxLifeSpan_IsValid;

	private static int MaxLifeSpan_Offset;

	private static bool AutoMovingRange_IsValid;

	private static int AutoMovingRange_Offset;

	private static bool AutoMovingSpeed_IsValid;

	private static int AutoMovingSpeed_Offset;

	private static bool StopPlaying_IsValid;

	private static IntPtr StopPlaying_FunctionAddress;

	private static int StopPlaying_ParamsSize;

	private static bool StartPlaying_IsValid;

	private static IntPtr StartPlaying_FunctionAddress;

	private static int StartPlaying_ParamsSize;

	private static bool PlayNiagara_IsValid;

	private static IntPtr PlayNiagara_FunctionAddress;

	private static int PlayNiagara_ParamsSize;

	private static bool PlayNiagara_InTargetNiagaraPtr_IsValid;

	private static FFieldAddress PlayNiagara_InTargetNiagaraPtr_PropertyAddress;

	private static int PlayNiagara_InTargetNiagaraPtr_Offset;

	private static bool ListCompletedPlaying_IsValid;

	private static IntPtr ListCompletedPlaying_FunctionAddress;

	private static int ListCompletedPlaying_ParamsSize;

	private static bool ListCompletedPlaying_ReturnValue_IsValid;

	private static FFieldAddress ListCompletedPlaying_ReturnValue_PropertyAddress;

	private static int ListCompletedPlaying_ReturnValue_Offset;

	private static bool GetInternalPlayList_IsValid;

	private static IntPtr GetInternalPlayList_FunctionAddress;

	private static int GetInternalPlayList_ParamsSize;

	private static bool GetInternalPlayList_ReturnValue_IsValid;

	private static FFieldAddress GetInternalPlayList_ReturnValue_PropertyAddress;

	private static int GetInternalPlayList_ReturnValue_Offset;

	private static bool FlushPlaying_IsValid;

	private static IntPtr FlushPlaying_FunctionAddress;

	private static int FlushPlaying_ParamsSize;

	private static bool DestroyAllNiagaras_IsValid;

	private static IntPtr DestroyAllNiagaras_FunctionAddress;

	private static int DestroyAllNiagaras_ParamsSize;

	private static bool CurNiagaraStatusChanged_IsValid;

	private static IntPtr CurNiagaraStatusChanged_FunctionAddress;

	private static int CurNiagaraStatusChanged_ParamsSize;

	private static bool CurNiagaraStatusChanged_bNumDecreased_IsValid;

	private static FFieldAddress CurNiagaraStatusChanged_bNumDecreased_PropertyAddress;

	private static int CurNiagaraStatusChanged_bNumDecreased_Offset;

	private static bool CurNiagaraStatusChanged_ReturnValue_IsValid;

	private static FFieldAddress CurNiagaraStatusChanged_ReturnValue_PropertyAddress;

	private static int CurNiagaraStatusChanged_ReturnValue_Offset;

	private static bool BuildPlayList_IsValid;

	private static IntPtr BuildPlayList_FunctionAddress;

	private static int BuildPlayList_ParamsSize;

	private static bool BuildPlayList_InFolder_IsValid;

	private static FFieldAddress BuildPlayList_InFolder_PropertyAddress;

	private static int BuildPlayList_InFolder_Offset;

	[UProperty(Flags = (PropFlags)4503599627502085uL)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:PlayList")]
	public TArrayReadWrite<string> PlayList
	{
		get
		{
			CheckDestroyed();
			if (!PlayList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VFXAutoPlayer:PlayList");
				return null;
			}
			if (PlayList_MarshalerCached == null)
			{
				PlayList_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, PlayList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return PlayList_MarshalerCached.FromNative(IntPtr.Add(base.Address, PlayList_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:PlayingPtr")]
	public int PlayingPtr
	{
		get
		{
			CheckDestroyed();
			if (!PlayingPtr_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VFXAutoPlayer:PlayingPtr");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlayingPtr_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayingPtr_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VFXAutoPlayer:PlayingPtr");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlayingPtr_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:MaxLifeSpan")]
	public float MaxLifeSpan
	{
		get
		{
			CheckDestroyed();
			if (!MaxLifeSpan_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VFXAutoPlayer:MaxLifeSpan");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxLifeSpan_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxLifeSpan_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VFXAutoPlayer:MaxLifeSpan");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxLifeSpan_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:AutoMovingRange")]
	public float AutoMovingRange
	{
		get
		{
			CheckDestroyed();
			if (!AutoMovingRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VFXAutoPlayer:AutoMovingRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AutoMovingRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoMovingRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VFXAutoPlayer:AutoMovingRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AutoMovingRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:AutoMovingSpeed")]
	public float AutoMovingSpeed
	{
		get
		{
			CheckDestroyed();
			if (!AutoMovingSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VFXAutoPlayer:AutoMovingSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AutoMovingSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoMovingSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VFXAutoPlayer:AutoMovingSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AutoMovingSpeed_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:StopPlaying")]
	public unsafe void StopPlaying()
	{
		CheckDestroyed();
		if (!StopPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VFXAutoPlayer:StopPlaying");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopPlaying_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopPlaying_FunctionAddress, argsSize: StopPlaying_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:StartPlaying")]
	public unsafe void StartPlaying()
	{
		CheckDestroyed();
		if (!StartPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VFXAutoPlayer:StartPlaying");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartPlaying_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartPlaying_FunctionAddress, argsSize: StartPlaying_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:PlayNiagara")]
	public unsafe void PlayNiagara(int InTargetNiagaraPtr)
	{
		CheckDestroyed();
		if (!PlayNiagara_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VFXAutoPlayer:PlayNiagara");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayNiagara_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayNiagara_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PlayNiagara_InTargetNiagaraPtr_Offset), 0, PlayNiagara_InTargetNiagaraPtr_PropertyAddress.Address, InTargetNiagaraPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayNiagara_FunctionAddress, intPtr, PlayNiagara_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:ListCompletedPlaying")]
	public unsafe bool ListCompletedPlaying()
	{
		CheckDestroyed();
		if (!ListCompletedPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VFXAutoPlayer:ListCompletedPlaying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ListCompletedPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ListCompletedPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ListCompletedPlaying_FunctionAddress, intPtr, ListCompletedPlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ListCompletedPlaying_ReturnValue_Offset), 0, ListCompletedPlaying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:GetInternalPlayList")]
	public unsafe List<UNiagaraSystem> GetInternalPlayList()
	{
		CheckDestroyed();
		if (!GetInternalPlayList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VFXAutoPlayer:GetInternalPlayList");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInternalPlayList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInternalPlayList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInternalPlayList_FunctionAddress, intPtr, GetInternalPlayList_ParamsSize);
		List<UNiagaraSystem> result = new TArrayCopyMarshaler<UNiagaraSystem>(1, GetInternalPlayList_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UNiagaraSystem, UObjectMarshaler<UNiagaraSystem>>.FromNative, CachedMarshalingDelegates<UNiagaraSystem, UObjectMarshaler<UNiagaraSystem>>.ToNative).FromNative(IntPtr.Add(intPtr, GetInternalPlayList_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInternalPlayList_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:FlushPlaying")]
	public unsafe void FlushPlaying()
	{
		CheckDestroyed();
		if (!FlushPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VFXAutoPlayer:FlushPlaying");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FlushPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FlushPlaying_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FlushPlaying_FunctionAddress, argsSize: FlushPlaying_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:DestroyAllNiagaras")]
	public unsafe void DestroyAllNiagaras()
	{
		CheckDestroyed();
		if (!DestroyAllNiagaras_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VFXAutoPlayer:DestroyAllNiagaras");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyAllNiagaras_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyAllNiagaras_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DestroyAllNiagaras_FunctionAddress, argsSize: DestroyAllNiagaras_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:CurNiagaraStatusChanged")]
	public unsafe bool CurNiagaraStatusChanged(out bool bNumDecreased)
	{
		CheckDestroyed();
		if (!CurNiagaraStatusChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VFXAutoPlayer:CurNiagaraStatusChanged");
			bNumDecreased = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CurNiagaraStatusChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CurNiagaraStatusChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CurNiagaraStatusChanged_FunctionAddress, intPtr, CurNiagaraStatusChanged_ParamsSize);
		bNumDecreased = BoolMarshaler.FromNative(IntPtr.Add(intPtr, CurNiagaraStatusChanged_bNumDecreased_Offset), 0, CurNiagaraStatusChanged_bNumDecreased_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CurNiagaraStatusChanged_ReturnValue_Offset), 0, CurNiagaraStatusChanged_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VFXAutoPlayer:BuildPlayList")]
	public unsafe void BuildPlayList(string InFolder)
	{
		CheckDestroyed();
		if (!BuildPlayList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VFXAutoPlayer:BuildPlayList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildPlayList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildPlayList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildPlayList_InFolder_Offset), 0, BuildPlayList_InFolder_PropertyAddress.Address, InFolder);
		NativeReflection.InvokeFunctionOptimized(base.Address, BuildPlayList_FunctionAddress, intPtr, BuildPlayList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildPlayList_InFolder_PropertyAddress.Address, intPtr);
	}

	static AVFXAutoPlayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AVFXAutoPlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AVFXAutoPlayer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.VFXAutoPlayer");
		NativeReflectionCached.GetPropertyRef(ref PlayList_PropertyAddress, intPtr, "PlayList");
		PlayList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayList");
		PlayList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayList", Classes.FArrayProperty);
		PlayingPtr_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayingPtr");
		PlayingPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayingPtr", Classes.FIntProperty);
		MaxLifeSpan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxLifeSpan");
		MaxLifeSpan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxLifeSpan", Classes.FFloatProperty);
		AutoMovingRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoMovingRange");
		AutoMovingRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoMovingRange", Classes.FFloatProperty);
		AutoMovingSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoMovingSpeed");
		AutoMovingSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoMovingSpeed", Classes.FFloatProperty);
		StopPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopPlaying");
		StopPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(StopPlaying_FunctionAddress);
		StopPlaying_IsValid = StopPlaying_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VFXAutoPlayer:StopPlaying", StopPlaying_IsValid);
		StartPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartPlaying");
		StartPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(StartPlaying_FunctionAddress);
		StartPlaying_IsValid = StartPlaying_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VFXAutoPlayer:StartPlaying", StartPlaying_IsValid);
		PlayNiagara_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayNiagara");
		PlayNiagara_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayNiagara_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayNiagara_InTargetNiagaraPtr_PropertyAddress, PlayNiagara_FunctionAddress, "InTargetNiagaraPtr");
		PlayNiagara_InTargetNiagaraPtr_Offset = NativeReflectionCached.GetPropertyOffset(PlayNiagara_FunctionAddress, "InTargetNiagaraPtr");
		PlayNiagara_InTargetNiagaraPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayNiagara_FunctionAddress, "InTargetNiagaraPtr", Classes.FIntProperty);
		PlayNiagara_IsValid = PlayNiagara_FunctionAddress != IntPtr.Zero && PlayNiagara_InTargetNiagaraPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VFXAutoPlayer:PlayNiagara", PlayNiagara_IsValid);
		ListCompletedPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ListCompletedPlaying");
		ListCompletedPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(ListCompletedPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ListCompletedPlaying_ReturnValue_PropertyAddress, ListCompletedPlaying_FunctionAddress, "ReturnValue");
		ListCompletedPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ListCompletedPlaying_FunctionAddress, "ReturnValue");
		ListCompletedPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ListCompletedPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ListCompletedPlaying_IsValid = ListCompletedPlaying_FunctionAddress != IntPtr.Zero && ListCompletedPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VFXAutoPlayer:ListCompletedPlaying", ListCompletedPlaying_IsValid);
		GetInternalPlayList_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInternalPlayList");
		GetInternalPlayList_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInternalPlayList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInternalPlayList_ReturnValue_PropertyAddress, GetInternalPlayList_FunctionAddress, "ReturnValue");
		GetInternalPlayList_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInternalPlayList_FunctionAddress, "ReturnValue");
		GetInternalPlayList_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInternalPlayList_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInternalPlayList_IsValid = GetInternalPlayList_FunctionAddress != IntPtr.Zero && GetInternalPlayList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VFXAutoPlayer:GetInternalPlayList", GetInternalPlayList_IsValid);
		FlushPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FlushPlaying");
		FlushPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(FlushPlaying_FunctionAddress);
		FlushPlaying_IsValid = FlushPlaying_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VFXAutoPlayer:FlushPlaying", FlushPlaying_IsValid);
		DestroyAllNiagaras_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DestroyAllNiagaras");
		DestroyAllNiagaras_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyAllNiagaras_FunctionAddress);
		DestroyAllNiagaras_IsValid = DestroyAllNiagaras_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VFXAutoPlayer:DestroyAllNiagaras", DestroyAllNiagaras_IsValid);
		CurNiagaraStatusChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CurNiagaraStatusChanged");
		CurNiagaraStatusChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CurNiagaraStatusChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CurNiagaraStatusChanged_bNumDecreased_PropertyAddress, CurNiagaraStatusChanged_FunctionAddress, "bNumDecreased");
		CurNiagaraStatusChanged_bNumDecreased_Offset = NativeReflectionCached.GetPropertyOffset(CurNiagaraStatusChanged_FunctionAddress, "bNumDecreased");
		CurNiagaraStatusChanged_bNumDecreased_IsValid = NativeReflectionCached.ValidatePropertyClass(CurNiagaraStatusChanged_FunctionAddress, "bNumDecreased", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CurNiagaraStatusChanged_ReturnValue_PropertyAddress, CurNiagaraStatusChanged_FunctionAddress, "ReturnValue");
		CurNiagaraStatusChanged_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CurNiagaraStatusChanged_FunctionAddress, "ReturnValue");
		CurNiagaraStatusChanged_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CurNiagaraStatusChanged_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CurNiagaraStatusChanged_IsValid = CurNiagaraStatusChanged_FunctionAddress != IntPtr.Zero && CurNiagaraStatusChanged_bNumDecreased_IsValid && CurNiagaraStatusChanged_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VFXAutoPlayer:CurNiagaraStatusChanged", CurNiagaraStatusChanged_IsValid);
		BuildPlayList_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BuildPlayList");
		BuildPlayList_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildPlayList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildPlayList_InFolder_PropertyAddress, BuildPlayList_FunctionAddress, "InFolder");
		BuildPlayList_InFolder_Offset = NativeReflectionCached.GetPropertyOffset(BuildPlayList_FunctionAddress, "InFolder");
		BuildPlayList_InFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildPlayList_FunctionAddress, "InFolder", Classes.FStrProperty);
		BuildPlayList_IsValid = BuildPlayList_FunctionAddress != IntPtr.Zero && BuildPlayList_InFolder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VFXAutoPlayer:BuildPlayList", BuildPlayList_IsValid);
	}
}
