using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraBaselineController", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraBaselineController : UObject
{
	private static bool TestDuration_IsValid;

	private static int TestDuration_Offset;

	private static bool EffectType_IsValid;

	private static int EffectType_Offset;

	private static bool Owner_IsValid;

	private static int Owner_Offset;

	private static bool OnTickTest_IsValid;

	private IntPtr OnTickTest_InstanceFunctionAddress;

	private static IntPtr OnTickTest_FunctionAddress;

	private static int OnTickTest_ParamsSize;

	private static bool OnTickTest_ReturnValue_IsValid;

	private static FFieldAddress OnTickTest_ReturnValue_PropertyAddress;

	private static int OnTickTest_ReturnValue_Offset;

	private static bool OnOwnerTick_IsValid;

	private IntPtr OnOwnerTick_InstanceFunctionAddress;

	private static IntPtr OnOwnerTick_FunctionAddress;

	private static int OnOwnerTick_ParamsSize;

	private static bool OnOwnerTick_DeltaTime_IsValid;

	private static FFieldAddress OnOwnerTick_DeltaTime_PropertyAddress;

	private static int OnOwnerTick_DeltaTime_Offset;

	private static bool OnEndTest_IsValid;

	private IntPtr OnEndTest_InstanceFunctionAddress;

	private static IntPtr OnEndTest_FunctionAddress;

	private static int OnEndTest_ParamsSize;

	private static bool OnEndTest_Stats_IsValid;

	private static FFieldAddress OnEndTest_Stats_PropertyAddress;

	private static int OnEndTest_Stats_Offset;

	private static bool OnBeginTest_IsValid;

	private IntPtr OnBeginTest_InstanceFunctionAddress;

	private static IntPtr OnBeginTest_FunctionAddress;

	private static int OnBeginTest_ParamsSize;

	private static bool GetSystem_IsValid;

	private static IntPtr GetSystem_FunctionAddress;

	private static int GetSystem_ParamsSize;

	private static bool GetSystem_ReturnValue_IsValid;

	private static FFieldAddress GetSystem_ReturnValue_PropertyAddress;

	private static int GetSystem_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Niagara.NiagaraBaselineController:TestDuration")]
	public float TestDuration
	{
		get
		{
			CheckDestroyed();
			if (!TestDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraBaselineController:TestDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TestDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TestDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraBaselineController:TestDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TestDuration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/Niagara.NiagaraBaselineController:EffectType")]
	public UNiagaraEffectType EffectType
	{
		get
		{
			CheckDestroyed();
			if (!EffectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraBaselineController:EffectType");
				return null;
			}
			return UObjectMarshaler<UNiagaraEffectType>.FromNative(IntPtr.Add(base.Address, EffectType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraBaselineController:EffectType");
			}
			else
			{
				UObjectMarshaler<UNiagaraEffectType>.ToNative(IntPtr.Add(base.Address, EffectType_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/Niagara.NiagaraBaselineController:Owner")]
	public ANiagaraPerfBaselineActor Owner
	{
		get
		{
			CheckDestroyed();
			if (!Owner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraBaselineController:Owner");
				return null;
			}
			return UObjectMarshaler<ANiagaraPerfBaselineActor>.FromNative(IntPtr.Add(base.Address, Owner_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Owner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraBaselineController:Owner");
			}
			else
			{
				UObjectMarshaler<ANiagaraPerfBaselineActor>.ToNative(IntPtr.Add(base.Address, Owner_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Niagara.NiagaraBaselineController:OnTickTest")]
	public unsafe bool OnTickTest()
	{
		CheckDestroyed();
		if (!OnTickTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraBaselineController:OnTickTest");
			return false;
		}
		if (OnTickTest_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTickTest_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTickTest");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTickTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTickTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTickTest_InstanceFunctionAddress, intPtr, OnTickTest_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnTickTest_ReturnValue_Offset), 0, OnTickTest_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool OnTickTest_Implementation()
	{
		CheckDestroyed();
		if (!OnTickTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraBaselineController:OnTickTest");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTickTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTickTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTickTest_FunctionAddress, intPtr, OnTickTest_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnTickTest_ReturnValue_Offset), 0, OnTickTest_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Niagara.NiagaraBaselineController:OnOwnerTick")]
	public unsafe void OnOwnerTick(float DeltaTime)
	{
		CheckDestroyed();
		if (!OnOwnerTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraBaselineController:OnOwnerTick");
			return;
		}
		if (OnOwnerTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnOwnerTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnOwnerTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnOwnerTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnOwnerTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnOwnerTick_DeltaTime_Offset), 0, OnOwnerTick_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnOwnerTick_InstanceFunctionAddress, intPtr, OnOwnerTick_ParamsSize);
	}

	protected unsafe virtual void OnOwnerTick_Implementation(float DeltaTime)
	{
		CheckDestroyed();
		if (!OnOwnerTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraBaselineController:OnOwnerTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnOwnerTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnOwnerTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnOwnerTick_DeltaTime_Offset), 0, OnOwnerTick_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnOwnerTick_FunctionAddress, intPtr, OnOwnerTick_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Niagara.NiagaraBaselineController:OnEndTest")]
	public unsafe void OnEndTest(FNiagaraPerfBaselineStats Stats)
	{
		CheckDestroyed();
		if (!OnEndTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraBaselineController:OnEndTest");
			return;
		}
		if (OnEndTest_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEndTest_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnEndTest");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEndTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEndTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnEndTest_Stats_PropertyAddress.Address, intPtr);
		FNiagaraPerfBaselineStats.ToNative(IntPtr.Add(intPtr, OnEndTest_Stats_Offset), 0, OnEndTest_Stats_PropertyAddress.Address, Stats);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEndTest_InstanceFunctionAddress, intPtr, OnEndTest_ParamsSize);
	}

	protected unsafe virtual void OnEndTest_Implementation(FNiagaraPerfBaselineStats Stats)
	{
		CheckDestroyed();
		if (!OnEndTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraBaselineController:OnEndTest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEndTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEndTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnEndTest_Stats_PropertyAddress.Address, intPtr);
		FNiagaraPerfBaselineStats.ToNative(IntPtr.Add(intPtr, OnEndTest_Stats_Offset), 0, OnEndTest_Stats_PropertyAddress.Address, Stats);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEndTest_FunctionAddress, intPtr, OnEndTest_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Niagara.NiagaraBaselineController:OnBeginTest")]
	public unsafe void OnBeginTest()
	{
		CheckDestroyed();
		if (!OnBeginTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraBaselineController:OnBeginTest");
			return;
		}
		if (OnBeginTest_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnBeginTest_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnBeginTest");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBeginTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBeginTest_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnBeginTest_InstanceFunctionAddress, argsSize: OnBeginTest_ParamsSize);
	}

	protected unsafe virtual void OnBeginTest_Implementation()
	{
		CheckDestroyed();
		if (!OnBeginTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraBaselineController:OnBeginTest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBeginTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBeginTest_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnBeginTest_FunctionAddress, argsSize: OnBeginTest_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraBaselineController:GetSystem")]
	public unsafe UNiagaraSystem GetSystem()
	{
		CheckDestroyed();
		if (!GetSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraBaselineController:GetSystem");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSystem_FunctionAddress, intPtr, GetSystem_ParamsSize);
		return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(intPtr, GetSystem_ReturnValue_Offset), 0, GetSystem_ReturnValue_PropertyAddress.Address);
	}

	static UNiagaraBaselineController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraBaselineController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraBaselineController));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Niagara.NiagaraBaselineController");
		TestDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TestDuration");
		TestDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TestDuration", Classes.FFloatProperty);
		EffectType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EffectType");
		EffectType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EffectType", Classes.FObjectProperty);
		Owner_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Owner");
		Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Owner", Classes.FObjectProperty);
		OnTickTest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTickTest");
		OnTickTest_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTickTest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTickTest_ReturnValue_PropertyAddress, OnTickTest_FunctionAddress, "ReturnValue");
		OnTickTest_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnTickTest_FunctionAddress, "ReturnValue");
		OnTickTest_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTickTest_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OnTickTest_IsValid = OnTickTest_FunctionAddress != IntPtr.Zero && OnTickTest_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraBaselineController:OnTickTest", OnTickTest_IsValid);
		OnOwnerTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnOwnerTick");
		OnOwnerTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnOwnerTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnOwnerTick_DeltaTime_PropertyAddress, OnOwnerTick_FunctionAddress, "DeltaTime");
		OnOwnerTick_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(OnOwnerTick_FunctionAddress, "DeltaTime");
		OnOwnerTick_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnOwnerTick_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		OnOwnerTick_IsValid = OnOwnerTick_FunctionAddress != IntPtr.Zero && OnOwnerTick_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraBaselineController:OnOwnerTick", OnOwnerTick_IsValid);
		OnEndTest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEndTest");
		OnEndTest_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEndTest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEndTest_Stats_PropertyAddress, OnEndTest_FunctionAddress, "Stats");
		OnEndTest_Stats_Offset = NativeReflectionCached.GetPropertyOffset(OnEndTest_FunctionAddress, "Stats");
		OnEndTest_Stats_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEndTest_FunctionAddress, "Stats", Classes.FStructProperty);
		OnEndTest_IsValid = OnEndTest_FunctionAddress != IntPtr.Zero && OnEndTest_Stats_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraBaselineController:OnEndTest", OnEndTest_IsValid);
		OnBeginTest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnBeginTest");
		OnBeginTest_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBeginTest_FunctionAddress);
		OnBeginTest_IsValid = OnBeginTest_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraBaselineController:OnBeginTest", OnBeginTest_IsValid);
		GetSystem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSystem");
		GetSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSystem_ReturnValue_PropertyAddress, GetSystem_FunctionAddress, "ReturnValue");
		GetSystem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSystem_FunctionAddress, "ReturnValue");
		GetSystem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSystem_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSystem_IsValid = GetSystem_FunctionAddress != IntPtr.Zero && GetSystem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraBaselineController:GetSystem", GetSystem_IsValid);
	}
}
