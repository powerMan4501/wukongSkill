using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.NiagaraUIRenderer;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget", "NiagaraUIRenderer", UnrealModuleType.GamePlugin)]
public class UNiagaraSystemWidget : UWidget
{
	private static bool NiagaraSystemReference_IsValid;

	private static int NiagaraSystemReference_Offset;

	private static bool AutoActivate_IsValid;

	private static FFieldAddress AutoActivate_PropertyAddress;

	private static int AutoActivate_Offset;

	private static bool TickWhenPaused_IsValid;

	private static FFieldAddress TickWhenPaused_PropertyAddress;

	private static int TickWhenPaused_Offset;

	private static bool FakeDepthScale_IsValid;

	private static FFieldAddress FakeDepthScale_PropertyAddress;

	private static int FakeDepthScale_Offset;

	private static bool FakeDepthScaleDistance_IsValid;

	private static int FakeDepthScaleDistance_Offset;

	private static bool GSIsNeedWidgetSizeParam_IsValid;

	private static FFieldAddress GSIsNeedWidgetSizeParam_PropertyAddress;

	private static int GSIsNeedWidgetSizeParam_Offset;

	private static bool GSVec4A_IsValid;

	private static int GSVec4A_Offset;

	private static bool GSVec4B_IsValid;

	private static int GSVec4B_Offset;

	private static bool GSColorA_IsValid;

	private static int GSColorA_Offset;

	private static bool GSColorB_IsValid;

	private static int GSColorB_Offset;

	private static bool UpdateTickWhenPaused_IsValid;

	private static IntPtr UpdateTickWhenPaused_FunctionAddress;

	private static int UpdateTickWhenPaused_ParamsSize;

	private static bool UpdateTickWhenPaused_NewTickWhenPaused_IsValid;

	private static FFieldAddress UpdateTickWhenPaused_NewTickWhenPaused_PropertyAddress;

	private static int UpdateTickWhenPaused_NewTickWhenPaused_Offset;

	private static bool UpdateNiagaraSystemReference_IsValid;

	private static IntPtr UpdateNiagaraSystemReference_FunctionAddress;

	private static int UpdateNiagaraSystemReference_ParamsSize;

	private static bool UpdateNiagaraSystemReference_NewNiagaraSystem_IsValid;

	private static FFieldAddress UpdateNiagaraSystemReference_NewNiagaraSystem_PropertyAddress;

	private static int UpdateNiagaraSystemReference_NewNiagaraSystem_Offset;

	private static bool SetGSVec4B_IsValid;

	private static IntPtr SetGSVec4B_FunctionAddress;

	private static int SetGSVec4B_ParamsSize;

	private static bool SetGSVec4B_InVec4_IsValid;

	private static FFieldAddress SetGSVec4B_InVec4_PropertyAddress;

	private static int SetGSVec4B_InVec4_Offset;

	private static bool SetGSVec4A_IsValid;

	private static IntPtr SetGSVec4A_FunctionAddress;

	private static int SetGSVec4A_ParamsSize;

	private static bool SetGSVec4A_InVec4_IsValid;

	private static FFieldAddress SetGSVec4A_InVec4_PropertyAddress;

	private static int SetGSVec4A_InVec4_Offset;

	private static bool SetGSColorB_IsValid;

	private static IntPtr SetGSColorB_FunctionAddress;

	private static int SetGSColorB_ParamsSize;

	private static bool SetGSColorB_InColor_IsValid;

	private static FFieldAddress SetGSColorB_InColor_PropertyAddress;

	private static int SetGSColorB_InColor_Offset;

	private static bool SetGSColorA_IsValid;

	private static IntPtr SetGSColorA_FunctionAddress;

	private static int SetGSColorA_ParamsSize;

	private static bool SetGSColorA_InColor_IsValid;

	private static FFieldAddress SetGSColorA_InColor_PropertyAddress;

	private static int SetGSColorA_InColor_Offset;

	private static bool ReInitSystem_IsValid;

	private static IntPtr ReInitSystem_FunctionAddress;

	private static int ReInitSystem_ParamsSize;

	private static bool GSStopFX_IsValid;

	private static IntPtr GSStopFX_FunctionAddress;

	private static int GSStopFX_ParamsSize;

	private static bool GSStopFX_IsReset_IsValid;

	private static FFieldAddress GSStopFX_IsReset_PropertyAddress;

	private static int GSStopFX_IsReset_Offset;

	private static bool GSSetNiagaraValVector4_IsValid;

	private static IntPtr GSSetNiagaraValVector4_FunctionAddress;

	private static int GSSetNiagaraValVector4_ParamsSize;

	private static bool GSSetNiagaraValVector4_InName_IsValid;

	private static FFieldAddress GSSetNiagaraValVector4_InName_PropertyAddress;

	private static int GSSetNiagaraValVector4_InName_Offset;

	private static bool GSSetNiagaraValVector4_InVal_IsValid;

	private static FFieldAddress GSSetNiagaraValVector4_InVal_PropertyAddress;

	private static int GSSetNiagaraValVector4_InVal_Offset;

	private static bool GSSetNiagaraValVector2_IsValid;

	private static IntPtr GSSetNiagaraValVector2_FunctionAddress;

	private static int GSSetNiagaraValVector2_ParamsSize;

	private static bool GSSetNiagaraValVector2_InName_IsValid;

	private static FFieldAddress GSSetNiagaraValVector2_InName_PropertyAddress;

	private static int GSSetNiagaraValVector2_InName_Offset;

	private static bool GSSetNiagaraValVector2_InVal_IsValid;

	private static FFieldAddress GSSetNiagaraValVector2_InVal_PropertyAddress;

	private static int GSSetNiagaraValVector2_InVal_Offset;

	private static bool GSSetNiagaraValVector_IsValid;

	private static IntPtr GSSetNiagaraValVector_FunctionAddress;

	private static int GSSetNiagaraValVector_ParamsSize;

	private static bool GSSetNiagaraValVector_InName_IsValid;

	private static FFieldAddress GSSetNiagaraValVector_InName_PropertyAddress;

	private static int GSSetNiagaraValVector_InName_Offset;

	private static bool GSSetNiagaraValVector_InVal_IsValid;

	private static FFieldAddress GSSetNiagaraValVector_InVal_PropertyAddress;

	private static int GSSetNiagaraValVector_InVal_Offset;

	private static bool GSSetNiagaraValLinearColor_IsValid;

	private static IntPtr GSSetNiagaraValLinearColor_FunctionAddress;

	private static int GSSetNiagaraValLinearColor_ParamsSize;

	private static bool GSSetNiagaraValLinearColor_InName_IsValid;

	private static FFieldAddress GSSetNiagaraValLinearColor_InName_PropertyAddress;

	private static int GSSetNiagaraValLinearColor_InName_Offset;

	private static bool GSSetNiagaraValLinearColor_InVal_IsValid;

	private static FFieldAddress GSSetNiagaraValLinearColor_InVal_PropertyAddress;

	private static int GSSetNiagaraValLinearColor_InVal_Offset;

	private static bool GSSetNiagaraValInt_IsValid;

	private static IntPtr GSSetNiagaraValInt_FunctionAddress;

	private static int GSSetNiagaraValInt_ParamsSize;

	private static bool GSSetNiagaraValInt_InName_IsValid;

	private static FFieldAddress GSSetNiagaraValInt_InName_PropertyAddress;

	private static int GSSetNiagaraValInt_InName_Offset;

	private static bool GSSetNiagaraValInt_InVal_IsValid;

	private static FFieldAddress GSSetNiagaraValInt_InVal_PropertyAddress;

	private static int GSSetNiagaraValInt_InVal_Offset;

	private static bool GSSetNiagaraValFloat_IsValid;

	private static IntPtr GSSetNiagaraValFloat_FunctionAddress;

	private static int GSSetNiagaraValFloat_ParamsSize;

	private static bool GSSetNiagaraValFloat_InName_IsValid;

	private static FFieldAddress GSSetNiagaraValFloat_InName_PropertyAddress;

	private static int GSSetNiagaraValFloat_InName_Offset;

	private static bool GSSetNiagaraValFloat_InVal_IsValid;

	private static FFieldAddress GSSetNiagaraValFloat_InVal_PropertyAddress;

	private static int GSSetNiagaraValFloat_InVal_Offset;

	private static bool GSSetNiagaraValBool_IsValid;

	private static IntPtr GSSetNiagaraValBool_FunctionAddress;

	private static int GSSetNiagaraValBool_ParamsSize;

	private static bool GSSetNiagaraValBool_InName_IsValid;

	private static FFieldAddress GSSetNiagaraValBool_InName_PropertyAddress;

	private static int GSSetNiagaraValBool_InName_Offset;

	private static bool GSSetNiagaraValBool_InVal_IsValid;

	private static FFieldAddress GSSetNiagaraValBool_InVal_PropertyAddress;

	private static int GSSetNiagaraValBool_InVal_Offset;

	private static bool GSResumeFX_IsValid;

	private static IntPtr GSResumeFX_FunctionAddress;

	private static int GSResumeFX_ParamsSize;

	private static bool GSPlayFX_IsValid;

	private static IntPtr GSPlayFX_FunctionAddress;

	private static int GSPlayFX_ParamsSize;

	private static bool GSPlayFX_IsReset_IsValid;

	private static FFieldAddress GSPlayFX_IsReset_PropertyAddress;

	private static int GSPlayFX_IsReset_Offset;

	private static bool GSPauseFX_IsValid;

	private static IntPtr GSPauseFX_FunctionAddress;

	private static int GSPauseFX_ParamsSize;

	private static bool GSDestoryFX_IsValid;

	private static IntPtr GSDestoryFX_FunctionAddress;

	private static int GSDestoryFX_ParamsSize;

	private static bool GSDebugStop_IsValid;

	private static IntPtr GSDebugStop_FunctionAddress;

	private static int GSDebugStop_ParamsSize;

	private static bool GSDebugResume_IsValid;

	private static IntPtr GSDebugResume_FunctionAddress;

	private static int GSDebugResume_ParamsSize;

	private static bool GSDebugReset_IsValid;

	private static IntPtr GSDebugReset_FunctionAddress;

	private static int GSDebugReset_ParamsSize;

	private static bool GSDebugPlay_IsValid;

	private static IntPtr GSDebugPlay_FunctionAddress;

	private static int GSDebugPlay_ParamsSize;

	private static bool GSDebugPause_IsValid;

	private static IntPtr GSDebugPause_FunctionAddress;

	private static int GSDebugPause_ParamsSize;

	private static bool GSActiveFX_IsValid;

	private static IntPtr GSActiveFX_FunctionAddress;

	private static int GSActiveFX_ParamsSize;

	private static bool GSActiveFX_IsActive_IsValid;

	private static FFieldAddress GSActiveFX_IsActive_PropertyAddress;

	private static int GSActiveFX_IsActive_Offset;

	private static bool GSActiveFX_IsReset_IsValid;

	private static FFieldAddress GSActiveFX_IsReset_PropertyAddress;

	private static int GSActiveFX_IsReset_Offset;

	private static bool GetNiagaraComponent_IsValid;

	private static IntPtr GetNiagaraComponent_FunctionAddress;

	private static int GetNiagaraComponent_ParamsSize;

	private static bool GetNiagaraComponent_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraComponent_ReturnValue_PropertyAddress;

	private static int GetNiagaraComponent_ReturnValue_Offset;

	private static bool DeactivateSystem_IsValid;

	private static IntPtr DeactivateSystem_FunctionAddress;

	private static int DeactivateSystem_ParamsSize;

	private static bool ActivateSystem_IsValid;

	private static IntPtr ActivateSystem_FunctionAddress;

	private static int ActivateSystem_ParamsSize;

	private static bool ActivateSystem_Reset_IsValid;

	private static FFieldAddress ActivateSystem_Reset_PropertyAddress;

	private static int ActivateSystem_Reset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:NiagaraSystemReference")]
	public UNiagaraSystem NiagaraSystemReference
	{
		get
		{
			CheckDestroyed();
			if (!NiagaraSystemReference_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:NiagaraSystemReference");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, NiagaraSystemReference_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NiagaraSystemReference_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:NiagaraSystemReference");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, NiagaraSystemReference_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:AutoActivate")]
	public bool AutoActivate
	{
		get
		{
			CheckDestroyed();
			if (!AutoActivate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:AutoActivate");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoActivate_Offset), 0, AutoActivate_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoActivate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:AutoActivate");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoActivate_Offset), 0, AutoActivate_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:TickWhenPaused")]
	public bool TickWhenPaused
	{
		get
		{
			CheckDestroyed();
			if (!TickWhenPaused_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:TickWhenPaused");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TickWhenPaused_Offset), 0, TickWhenPaused_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TickWhenPaused_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:TickWhenPaused");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TickWhenPaused_Offset), 0, TickWhenPaused_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:FakeDepthScale")]
	public bool FakeDepthScale
	{
		get
		{
			CheckDestroyed();
			if (!FakeDepthScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:FakeDepthScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FakeDepthScale_Offset), 0, FakeDepthScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FakeDepthScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:FakeDepthScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FakeDepthScale_Offset), 0, FakeDepthScale_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:FakeDepthScaleDistance")]
	public float FakeDepthScaleDistance
	{
		get
		{
			CheckDestroyed();
			if (!FakeDepthScaleDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:FakeDepthScaleDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FakeDepthScaleDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FakeDepthScaleDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:FakeDepthScaleDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FakeDepthScaleDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSIsNeedWidgetSizeParam")]
	public bool GSIsNeedWidgetSizeParam
	{
		get
		{
			CheckDestroyed();
			if (!GSIsNeedWidgetSizeParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSIsNeedWidgetSizeParam");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSIsNeedWidgetSizeParam_Offset), 0, GSIsNeedWidgetSizeParam_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSIsNeedWidgetSizeParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSIsNeedWidgetSizeParam");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSIsNeedWidgetSizeParam_Offset), 0, GSIsNeedWidgetSizeParam_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSVec4A")]
	public FVector4 GSVec4A
	{
		get
		{
			CheckDestroyed();
			if (!GSVec4A_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSVec4A");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, GSVec4A_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSVec4A_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSVec4A");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, GSVec4A_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSVec4B")]
	public FVector4 GSVec4B
	{
		get
		{
			CheckDestroyed();
			if (!GSVec4B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSVec4B");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, GSVec4B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSVec4B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSVec4B");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, GSVec4B_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSColorA")]
	public FLinearColor GSColorA
	{
		get
		{
			CheckDestroyed();
			if (!GSColorA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSColorA");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, GSColorA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSColorA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSColorA");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, GSColorA_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSColorB")]
	public FLinearColor GSColorB
	{
		get
		{
			CheckDestroyed();
			if (!GSColorB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSColorB");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, GSColorB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSColorB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSColorB");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, GSColorB_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:UpdateTickWhenPaused")]
	public unsafe void UpdateTickWhenPaused(bool NewTickWhenPaused)
	{
		CheckDestroyed();
		if (!UpdateTickWhenPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:UpdateTickWhenPaused");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateTickWhenPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateTickWhenPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UpdateTickWhenPaused_NewTickWhenPaused_Offset), 0, UpdateTickWhenPaused_NewTickWhenPaused_PropertyAddress.Address, NewTickWhenPaused);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateTickWhenPaused_FunctionAddress, intPtr, UpdateTickWhenPaused_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:UpdateNiagaraSystemReference")]
	public unsafe void UpdateNiagaraSystemReference(UNiagaraSystem NewNiagaraSystem)
	{
		CheckDestroyed();
		if (!UpdateNiagaraSystemReference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:UpdateNiagaraSystemReference");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateNiagaraSystemReference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateNiagaraSystemReference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, UpdateNiagaraSystemReference_NewNiagaraSystem_Offset), 0, UpdateNiagaraSystemReference_NewNiagaraSystem_PropertyAddress.Address, NewNiagaraSystem);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateNiagaraSystemReference_FunctionAddress, intPtr, UpdateNiagaraSystemReference_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSVec4B")]
	public unsafe void SetGSVec4B(FVector4 InVec4)
	{
		CheckDestroyed();
		if (!SetGSVec4B_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSVec4B");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSVec4B_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSVec4B_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetGSVec4B_InVec4_Offset), 0, SetGSVec4B_InVec4_PropertyAddress.Address, InVec4);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSVec4B_FunctionAddress, intPtr, SetGSVec4B_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSVec4A")]
	public unsafe void SetGSVec4A(FVector4 InVec4)
	{
		CheckDestroyed();
		if (!SetGSVec4A_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSVec4A");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSVec4A_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSVec4A_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetGSVec4A_InVec4_Offset), 0, SetGSVec4A_InVec4_PropertyAddress.Address, InVec4);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSVec4A_FunctionAddress, intPtr, SetGSVec4A_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSColorB")]
	public unsafe void SetGSColorB(FLinearColor InColor)
	{
		CheckDestroyed();
		if (!SetGSColorB_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSColorB");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSColorB_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSColorB_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetGSColorB_InColor_Offset), 0, SetGSColorB_InColor_PropertyAddress.Address, InColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSColorB_FunctionAddress, intPtr, SetGSColorB_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSColorA")]
	public unsafe void SetGSColorA(FLinearColor InColor)
	{
		CheckDestroyed();
		if (!SetGSColorA_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSColorA");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSColorA_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSColorA_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetGSColorA_InColor_Offset), 0, SetGSColorA_InColor_PropertyAddress.Address, InColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSColorA_FunctionAddress, intPtr, SetGSColorA_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:ReInitSystem")]
	public unsafe void ReInitSystem()
	{
		CheckDestroyed();
		if (!ReInitSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:ReInitSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReInitSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReInitSystem_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReInitSystem_FunctionAddress, argsSize: ReInitSystem_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSStopFX")]
	public unsafe void GSStopFX(bool IsReset = false)
	{
		CheckDestroyed();
		if (!GSStopFX_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSStopFX");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSStopFX_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSStopFX_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GSStopFX_IsReset_Offset), 0, GSStopFX_IsReset_PropertyAddress.Address, IsReset);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSStopFX_FunctionAddress, intPtr, GSStopFX_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValVector4")]
	public unsafe void GSSetNiagaraValVector4(string InName, FVector4 InVal)
	{
		CheckDestroyed();
		if (!GSSetNiagaraValVector4_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValVector4");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSSetNiagaraValVector4_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSSetNiagaraValVector4_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValVector4_InName_Offset), 0, GSSetNiagaraValVector4_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValVector4_InVal_Offset), 0, GSSetNiagaraValVector4_InVal_PropertyAddress.Address, InVal);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSSetNiagaraValVector4_FunctionAddress, intPtr, GSSetNiagaraValVector4_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSSetNiagaraValVector4_InName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValVector2")]
	public unsafe void GSSetNiagaraValVector2(string InName, FVector2D InVal)
	{
		CheckDestroyed();
		if (!GSSetNiagaraValVector2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValVector2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSSetNiagaraValVector2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSSetNiagaraValVector2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValVector2_InName_Offset), 0, GSSetNiagaraValVector2_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValVector2_InVal_Offset), 0, GSSetNiagaraValVector2_InVal_PropertyAddress.Address, InVal);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSSetNiagaraValVector2_FunctionAddress, intPtr, GSSetNiagaraValVector2_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSSetNiagaraValVector2_InName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValVector")]
	public unsafe void GSSetNiagaraValVector(string InName, FVector InVal)
	{
		CheckDestroyed();
		if (!GSSetNiagaraValVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSSetNiagaraValVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSSetNiagaraValVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValVector_InName_Offset), 0, GSSetNiagaraValVector_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValVector_InVal_Offset), 0, GSSetNiagaraValVector_InVal_PropertyAddress.Address, InVal);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSSetNiagaraValVector_FunctionAddress, intPtr, GSSetNiagaraValVector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSSetNiagaraValVector_InName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValLinearColor")]
	public unsafe void GSSetNiagaraValLinearColor(string InName, FLinearColor InVal)
	{
		CheckDestroyed();
		if (!GSSetNiagaraValLinearColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValLinearColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSSetNiagaraValLinearColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSSetNiagaraValLinearColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValLinearColor_InName_Offset), 0, GSSetNiagaraValLinearColor_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValLinearColor_InVal_Offset), 0, GSSetNiagaraValLinearColor_InVal_PropertyAddress.Address, InVal);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSSetNiagaraValLinearColor_FunctionAddress, intPtr, GSSetNiagaraValLinearColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSSetNiagaraValLinearColor_InName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValInt")]
	public unsafe void GSSetNiagaraValInt(string InName, int InVal)
	{
		CheckDestroyed();
		if (!GSSetNiagaraValInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValInt");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSSetNiagaraValInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSSetNiagaraValInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValInt_InName_Offset), 0, GSSetNiagaraValInt_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValInt_InVal_Offset), 0, GSSetNiagaraValInt_InVal_PropertyAddress.Address, InVal);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSSetNiagaraValInt_FunctionAddress, intPtr, GSSetNiagaraValInt_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSSetNiagaraValInt_InName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValFloat")]
	public unsafe void GSSetNiagaraValFloat(string InName, float InVal)
	{
		CheckDestroyed();
		if (!GSSetNiagaraValFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSSetNiagaraValFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSSetNiagaraValFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValFloat_InName_Offset), 0, GSSetNiagaraValFloat_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValFloat_InVal_Offset), 0, GSSetNiagaraValFloat_InVal_PropertyAddress.Address, InVal);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSSetNiagaraValFloat_FunctionAddress, intPtr, GSSetNiagaraValFloat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSSetNiagaraValFloat_InName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValBool")]
	public unsafe void GSSetNiagaraValBool(string InName, bool InVal)
	{
		CheckDestroyed();
		if (!GSSetNiagaraValBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValBool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSSetNiagaraValBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSSetNiagaraValBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValBool_InName_Offset), 0, GSSetNiagaraValBool_InName_PropertyAddress.Address, InName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GSSetNiagaraValBool_InVal_Offset), 0, GSSetNiagaraValBool_InVal_PropertyAddress.Address, InVal);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSSetNiagaraValBool_FunctionAddress, intPtr, GSSetNiagaraValBool_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSSetNiagaraValBool_InName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSResumeFX")]
	public unsafe void GSResumeFX()
	{
		CheckDestroyed();
		if (!GSResumeFX_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSResumeFX");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSResumeFX_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSResumeFX_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GSResumeFX_FunctionAddress, argsSize: GSResumeFX_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSPlayFX")]
	public unsafe void GSPlayFX(bool IsReset = true)
	{
		CheckDestroyed();
		if (!GSPlayFX_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSPlayFX");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSPlayFX_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSPlayFX_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GSPlayFX_IsReset_Offset), 0, GSPlayFX_IsReset_PropertyAddress.Address, IsReset);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSPlayFX_FunctionAddress, intPtr, GSPlayFX_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSPauseFX")]
	public unsafe void GSPauseFX()
	{
		CheckDestroyed();
		if (!GSPauseFX_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSPauseFX");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSPauseFX_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSPauseFX_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GSPauseFX_FunctionAddress, argsSize: GSPauseFX_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDestoryFX")]
	public unsafe void GSDestoryFX()
	{
		CheckDestroyed();
		if (!GSDestoryFX_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDestoryFX");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSDestoryFX_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSDestoryFX_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GSDestoryFX_FunctionAddress, argsSize: GSDestoryFX_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugStop")]
	public unsafe void GSDebugStop()
	{
		CheckDestroyed();
		if (!GSDebugStop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugStop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSDebugStop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSDebugStop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GSDebugStop_FunctionAddress, argsSize: GSDebugStop_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugResume")]
	public unsafe void GSDebugResume()
	{
		CheckDestroyed();
		if (!GSDebugResume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugResume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSDebugResume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSDebugResume_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GSDebugResume_FunctionAddress, argsSize: GSDebugResume_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugReset")]
	public unsafe void GSDebugReset()
	{
		CheckDestroyed();
		if (!GSDebugReset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugReset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSDebugReset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSDebugReset_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GSDebugReset_FunctionAddress, argsSize: GSDebugReset_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugPlay")]
	public unsafe void GSDebugPlay()
	{
		CheckDestroyed();
		if (!GSDebugPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSDebugPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSDebugPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GSDebugPlay_FunctionAddress, argsSize: GSDebugPlay_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugPause")]
	public unsafe void GSDebugPause()
	{
		CheckDestroyed();
		if (!GSDebugPause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugPause");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSDebugPause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSDebugPause_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GSDebugPause_FunctionAddress, argsSize: GSDebugPause_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSActiveFX")]
	public unsafe void GSActiveFX(bool IsActive, bool IsReset = false)
	{
		CheckDestroyed();
		if (!GSActiveFX_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSActiveFX");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSActiveFX_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSActiveFX_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GSActiveFX_IsActive_Offset), 0, GSActiveFX_IsActive_PropertyAddress.Address, IsActive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GSActiveFX_IsReset_Offset), 0, GSActiveFX_IsReset_PropertyAddress.Address, IsReset);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSActiveFX_FunctionAddress, intPtr, GSActiveFX_ParamsSize);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GetNiagaraComponent")]
	public unsafe UNiagaraUIComponent GetNiagaraComponent()
	{
		CheckDestroyed();
		if (!GetNiagaraComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GetNiagaraComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNiagaraComponent_FunctionAddress, intPtr, GetNiagaraComponent_ParamsSize);
		return UObjectMarshaler<UNiagaraUIComponent>.FromNative(IntPtr.Add(intPtr, GetNiagaraComponent_ReturnValue_Offset), 0, GetNiagaraComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:DeactivateSystem")]
	public unsafe void DeactivateSystem()
	{
		CheckDestroyed();
		if (!DeactivateSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:DeactivateSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeactivateSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeactivateSystem_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DeactivateSystem_FunctionAddress, argsSize: DeactivateSystem_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraUIRenderer.NiagaraSystemWidget:ActivateSystem")]
	public unsafe void ActivateSystem(bool Reset)
	{
		CheckDestroyed();
		if (!ActivateSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraUIRenderer.NiagaraSystemWidget:ActivateSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActivateSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActivateSystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ActivateSystem_Reset_Offset), 0, ActivateSystem_Reset_PropertyAddress.Address, Reset);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActivateSystem_FunctionAddress, intPtr, ActivateSystem_ParamsSize);
	}

	static UNiagaraSystemWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraSystemWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraSystemWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/NiagaraUIRenderer.NiagaraSystemWidget");
		NiagaraSystemReference_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NiagaraSystemReference");
		NiagaraSystemReference_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NiagaraSystemReference", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoActivate_PropertyAddress, intPtr, "AutoActivate");
		AutoActivate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoActivate");
		AutoActivate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoActivate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TickWhenPaused_PropertyAddress, intPtr, "TickWhenPaused");
		TickWhenPaused_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TickWhenPaused");
		TickWhenPaused_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TickWhenPaused", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FakeDepthScale_PropertyAddress, intPtr, "FakeDepthScale");
		FakeDepthScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FakeDepthScale");
		FakeDepthScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FakeDepthScale", Classes.FBoolProperty);
		FakeDepthScaleDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FakeDepthScaleDistance");
		FakeDepthScaleDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FakeDepthScaleDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GSIsNeedWidgetSizeParam_PropertyAddress, intPtr, "GSIsNeedWidgetSizeParam");
		GSIsNeedWidgetSizeParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSIsNeedWidgetSizeParam");
		GSIsNeedWidgetSizeParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSIsNeedWidgetSizeParam", Classes.FBoolProperty);
		GSVec4A_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSVec4A");
		GSVec4A_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSVec4A", Classes.FStructProperty);
		GSVec4B_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSVec4B");
		GSVec4B_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSVec4B", Classes.FStructProperty);
		GSColorA_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSColorA");
		GSColorA_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSColorA", Classes.FStructProperty);
		GSColorB_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSColorB");
		GSColorB_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSColorB", Classes.FStructProperty);
		UpdateTickWhenPaused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateTickWhenPaused");
		UpdateTickWhenPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateTickWhenPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateTickWhenPaused_NewTickWhenPaused_PropertyAddress, UpdateTickWhenPaused_FunctionAddress, "NewTickWhenPaused");
		UpdateTickWhenPaused_NewTickWhenPaused_Offset = NativeReflectionCached.GetPropertyOffset(UpdateTickWhenPaused_FunctionAddress, "NewTickWhenPaused");
		UpdateTickWhenPaused_NewTickWhenPaused_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateTickWhenPaused_FunctionAddress, "NewTickWhenPaused", Classes.FBoolProperty);
		UpdateTickWhenPaused_IsValid = UpdateTickWhenPaused_FunctionAddress != IntPtr.Zero && UpdateTickWhenPaused_NewTickWhenPaused_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:UpdateTickWhenPaused", UpdateTickWhenPaused_IsValid);
		UpdateNiagaraSystemReference_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateNiagaraSystemReference");
		UpdateNiagaraSystemReference_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateNiagaraSystemReference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateNiagaraSystemReference_NewNiagaraSystem_PropertyAddress, UpdateNiagaraSystemReference_FunctionAddress, "NewNiagaraSystem");
		UpdateNiagaraSystemReference_NewNiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(UpdateNiagaraSystemReference_FunctionAddress, "NewNiagaraSystem");
		UpdateNiagaraSystemReference_NewNiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateNiagaraSystemReference_FunctionAddress, "NewNiagaraSystem", Classes.FObjectProperty);
		UpdateNiagaraSystemReference_IsValid = UpdateNiagaraSystemReference_FunctionAddress != IntPtr.Zero && UpdateNiagaraSystemReference_NewNiagaraSystem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:UpdateNiagaraSystemReference", UpdateNiagaraSystemReference_IsValid);
		SetGSVec4B_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSVec4B");
		SetGSVec4B_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSVec4B_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSVec4B_InVec4_PropertyAddress, SetGSVec4B_FunctionAddress, "InVec4");
		SetGSVec4B_InVec4_Offset = NativeReflectionCached.GetPropertyOffset(SetGSVec4B_FunctionAddress, "InVec4");
		SetGSVec4B_InVec4_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSVec4B_FunctionAddress, "InVec4", Classes.FStructProperty);
		SetGSVec4B_IsValid = SetGSVec4B_FunctionAddress != IntPtr.Zero && SetGSVec4B_InVec4_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSVec4B", SetGSVec4B_IsValid);
		SetGSVec4A_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSVec4A");
		SetGSVec4A_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSVec4A_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSVec4A_InVec4_PropertyAddress, SetGSVec4A_FunctionAddress, "InVec4");
		SetGSVec4A_InVec4_Offset = NativeReflectionCached.GetPropertyOffset(SetGSVec4A_FunctionAddress, "InVec4");
		SetGSVec4A_InVec4_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSVec4A_FunctionAddress, "InVec4", Classes.FStructProperty);
		SetGSVec4A_IsValid = SetGSVec4A_FunctionAddress != IntPtr.Zero && SetGSVec4A_InVec4_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSVec4A", SetGSVec4A_IsValid);
		SetGSColorB_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSColorB");
		SetGSColorB_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSColorB_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSColorB_InColor_PropertyAddress, SetGSColorB_FunctionAddress, "InColor");
		SetGSColorB_InColor_Offset = NativeReflectionCached.GetPropertyOffset(SetGSColorB_FunctionAddress, "InColor");
		SetGSColorB_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSColorB_FunctionAddress, "InColor", Classes.FStructProperty);
		SetGSColorB_IsValid = SetGSColorB_FunctionAddress != IntPtr.Zero && SetGSColorB_InColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSColorB", SetGSColorB_IsValid);
		SetGSColorA_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSColorA");
		SetGSColorA_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSColorA_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSColorA_InColor_PropertyAddress, SetGSColorA_FunctionAddress, "InColor");
		SetGSColorA_InColor_Offset = NativeReflectionCached.GetPropertyOffset(SetGSColorA_FunctionAddress, "InColor");
		SetGSColorA_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSColorA_FunctionAddress, "InColor", Classes.FStructProperty);
		SetGSColorA_IsValid = SetGSColorA_FunctionAddress != IntPtr.Zero && SetGSColorA_InColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:SetGSColorA", SetGSColorA_IsValid);
		ReInitSystem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReInitSystem");
		ReInitSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(ReInitSystem_FunctionAddress);
		ReInitSystem_IsValid = ReInitSystem_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:ReInitSystem", ReInitSystem_IsValid);
		GSStopFX_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSStopFX");
		GSStopFX_ParamsSize = NativeReflection.GetFunctionParamsSize(GSStopFX_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSStopFX_IsReset_PropertyAddress, GSStopFX_FunctionAddress, "IsReset");
		GSStopFX_IsReset_Offset = NativeReflectionCached.GetPropertyOffset(GSStopFX_FunctionAddress, "IsReset");
		GSStopFX_IsReset_IsValid = NativeReflectionCached.ValidatePropertyClass(GSStopFX_FunctionAddress, "IsReset", Classes.FBoolProperty);
		GSStopFX_IsValid = GSStopFX_FunctionAddress != IntPtr.Zero && GSStopFX_IsReset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSStopFX", GSStopFX_IsValid);
		GSSetNiagaraValVector4_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSSetNiagaraValVector4");
		GSSetNiagaraValVector4_ParamsSize = NativeReflection.GetFunctionParamsSize(GSSetNiagaraValVector4_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValVector4_InName_PropertyAddress, GSSetNiagaraValVector4_FunctionAddress, "InName");
		GSSetNiagaraValVector4_InName_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValVector4_FunctionAddress, "InName");
		GSSetNiagaraValVector4_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValVector4_FunctionAddress, "InName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValVector4_InVal_PropertyAddress, GSSetNiagaraValVector4_FunctionAddress, "InVal");
		GSSetNiagaraValVector4_InVal_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValVector4_FunctionAddress, "InVal");
		GSSetNiagaraValVector4_InVal_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValVector4_FunctionAddress, "InVal", Classes.FStructProperty);
		GSSetNiagaraValVector4_IsValid = GSSetNiagaraValVector4_FunctionAddress != IntPtr.Zero && GSSetNiagaraValVector4_InName_IsValid && GSSetNiagaraValVector4_InVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValVector4", GSSetNiagaraValVector4_IsValid);
		GSSetNiagaraValVector2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSSetNiagaraValVector2");
		GSSetNiagaraValVector2_ParamsSize = NativeReflection.GetFunctionParamsSize(GSSetNiagaraValVector2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValVector2_InName_PropertyAddress, GSSetNiagaraValVector2_FunctionAddress, "InName");
		GSSetNiagaraValVector2_InName_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValVector2_FunctionAddress, "InName");
		GSSetNiagaraValVector2_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValVector2_FunctionAddress, "InName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValVector2_InVal_PropertyAddress, GSSetNiagaraValVector2_FunctionAddress, "InVal");
		GSSetNiagaraValVector2_InVal_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValVector2_FunctionAddress, "InVal");
		GSSetNiagaraValVector2_InVal_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValVector2_FunctionAddress, "InVal", Classes.FStructProperty);
		GSSetNiagaraValVector2_IsValid = GSSetNiagaraValVector2_FunctionAddress != IntPtr.Zero && GSSetNiagaraValVector2_InName_IsValid && GSSetNiagaraValVector2_InVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValVector2", GSSetNiagaraValVector2_IsValid);
		GSSetNiagaraValVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSSetNiagaraValVector");
		GSSetNiagaraValVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GSSetNiagaraValVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValVector_InName_PropertyAddress, GSSetNiagaraValVector_FunctionAddress, "InName");
		GSSetNiagaraValVector_InName_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValVector_FunctionAddress, "InName");
		GSSetNiagaraValVector_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValVector_FunctionAddress, "InName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValVector_InVal_PropertyAddress, GSSetNiagaraValVector_FunctionAddress, "InVal");
		GSSetNiagaraValVector_InVal_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValVector_FunctionAddress, "InVal");
		GSSetNiagaraValVector_InVal_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValVector_FunctionAddress, "InVal", Classes.FStructProperty);
		GSSetNiagaraValVector_IsValid = GSSetNiagaraValVector_FunctionAddress != IntPtr.Zero && GSSetNiagaraValVector_InName_IsValid && GSSetNiagaraValVector_InVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValVector", GSSetNiagaraValVector_IsValid);
		GSSetNiagaraValLinearColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSSetNiagaraValLinearColor");
		GSSetNiagaraValLinearColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GSSetNiagaraValLinearColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValLinearColor_InName_PropertyAddress, GSSetNiagaraValLinearColor_FunctionAddress, "InName");
		GSSetNiagaraValLinearColor_InName_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValLinearColor_FunctionAddress, "InName");
		GSSetNiagaraValLinearColor_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValLinearColor_FunctionAddress, "InName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValLinearColor_InVal_PropertyAddress, GSSetNiagaraValLinearColor_FunctionAddress, "InVal");
		GSSetNiagaraValLinearColor_InVal_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValLinearColor_FunctionAddress, "InVal");
		GSSetNiagaraValLinearColor_InVal_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValLinearColor_FunctionAddress, "InVal", Classes.FStructProperty);
		GSSetNiagaraValLinearColor_IsValid = GSSetNiagaraValLinearColor_FunctionAddress != IntPtr.Zero && GSSetNiagaraValLinearColor_InName_IsValid && GSSetNiagaraValLinearColor_InVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValLinearColor", GSSetNiagaraValLinearColor_IsValid);
		GSSetNiagaraValInt_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSSetNiagaraValInt");
		GSSetNiagaraValInt_ParamsSize = NativeReflection.GetFunctionParamsSize(GSSetNiagaraValInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValInt_InName_PropertyAddress, GSSetNiagaraValInt_FunctionAddress, "InName");
		GSSetNiagaraValInt_InName_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValInt_FunctionAddress, "InName");
		GSSetNiagaraValInt_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValInt_FunctionAddress, "InName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValInt_InVal_PropertyAddress, GSSetNiagaraValInt_FunctionAddress, "InVal");
		GSSetNiagaraValInt_InVal_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValInt_FunctionAddress, "InVal");
		GSSetNiagaraValInt_InVal_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValInt_FunctionAddress, "InVal", Classes.FIntProperty);
		GSSetNiagaraValInt_IsValid = GSSetNiagaraValInt_FunctionAddress != IntPtr.Zero && GSSetNiagaraValInt_InName_IsValid && GSSetNiagaraValInt_InVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValInt", GSSetNiagaraValInt_IsValid);
		GSSetNiagaraValFloat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSSetNiagaraValFloat");
		GSSetNiagaraValFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(GSSetNiagaraValFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValFloat_InName_PropertyAddress, GSSetNiagaraValFloat_FunctionAddress, "InName");
		GSSetNiagaraValFloat_InName_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValFloat_FunctionAddress, "InName");
		GSSetNiagaraValFloat_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValFloat_FunctionAddress, "InName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValFloat_InVal_PropertyAddress, GSSetNiagaraValFloat_FunctionAddress, "InVal");
		GSSetNiagaraValFloat_InVal_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValFloat_FunctionAddress, "InVal");
		GSSetNiagaraValFloat_InVal_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValFloat_FunctionAddress, "InVal", Classes.FFloatProperty);
		GSSetNiagaraValFloat_IsValid = GSSetNiagaraValFloat_FunctionAddress != IntPtr.Zero && GSSetNiagaraValFloat_InName_IsValid && GSSetNiagaraValFloat_InVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValFloat", GSSetNiagaraValFloat_IsValid);
		GSSetNiagaraValBool_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSSetNiagaraValBool");
		GSSetNiagaraValBool_ParamsSize = NativeReflection.GetFunctionParamsSize(GSSetNiagaraValBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValBool_InName_PropertyAddress, GSSetNiagaraValBool_FunctionAddress, "InName");
		GSSetNiagaraValBool_InName_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValBool_FunctionAddress, "InName");
		GSSetNiagaraValBool_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValBool_FunctionAddress, "InName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSSetNiagaraValBool_InVal_PropertyAddress, GSSetNiagaraValBool_FunctionAddress, "InVal");
		GSSetNiagaraValBool_InVal_Offset = NativeReflectionCached.GetPropertyOffset(GSSetNiagaraValBool_FunctionAddress, "InVal");
		GSSetNiagaraValBool_InVal_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSetNiagaraValBool_FunctionAddress, "InVal", Classes.FBoolProperty);
		GSSetNiagaraValBool_IsValid = GSSetNiagaraValBool_FunctionAddress != IntPtr.Zero && GSSetNiagaraValBool_InName_IsValid && GSSetNiagaraValBool_InVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSSetNiagaraValBool", GSSetNiagaraValBool_IsValid);
		GSResumeFX_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSResumeFX");
		GSResumeFX_ParamsSize = NativeReflection.GetFunctionParamsSize(GSResumeFX_FunctionAddress);
		GSResumeFX_IsValid = GSResumeFX_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSResumeFX", GSResumeFX_IsValid);
		GSPlayFX_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSPlayFX");
		GSPlayFX_ParamsSize = NativeReflection.GetFunctionParamsSize(GSPlayFX_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSPlayFX_IsReset_PropertyAddress, GSPlayFX_FunctionAddress, "IsReset");
		GSPlayFX_IsReset_Offset = NativeReflectionCached.GetPropertyOffset(GSPlayFX_FunctionAddress, "IsReset");
		GSPlayFX_IsReset_IsValid = NativeReflectionCached.ValidatePropertyClass(GSPlayFX_FunctionAddress, "IsReset", Classes.FBoolProperty);
		GSPlayFX_IsValid = GSPlayFX_FunctionAddress != IntPtr.Zero && GSPlayFX_IsReset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSPlayFX", GSPlayFX_IsValid);
		GSPauseFX_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSPauseFX");
		GSPauseFX_ParamsSize = NativeReflection.GetFunctionParamsSize(GSPauseFX_FunctionAddress);
		GSPauseFX_IsValid = GSPauseFX_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSPauseFX", GSPauseFX_IsValid);
		GSDestoryFX_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSDestoryFX");
		GSDestoryFX_ParamsSize = NativeReflection.GetFunctionParamsSize(GSDestoryFX_FunctionAddress);
		GSDestoryFX_IsValid = GSDestoryFX_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDestoryFX", GSDestoryFX_IsValid);
		GSDebugStop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSDebugStop");
		GSDebugStop_ParamsSize = NativeReflection.GetFunctionParamsSize(GSDebugStop_FunctionAddress);
		GSDebugStop_IsValid = GSDebugStop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugStop", GSDebugStop_IsValid);
		GSDebugResume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSDebugResume");
		GSDebugResume_ParamsSize = NativeReflection.GetFunctionParamsSize(GSDebugResume_FunctionAddress);
		GSDebugResume_IsValid = GSDebugResume_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugResume", GSDebugResume_IsValid);
		GSDebugReset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSDebugReset");
		GSDebugReset_ParamsSize = NativeReflection.GetFunctionParamsSize(GSDebugReset_FunctionAddress);
		GSDebugReset_IsValid = GSDebugReset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugReset", GSDebugReset_IsValid);
		GSDebugPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSDebugPlay");
		GSDebugPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(GSDebugPlay_FunctionAddress);
		GSDebugPlay_IsValid = GSDebugPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugPlay", GSDebugPlay_IsValid);
		GSDebugPause_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSDebugPause");
		GSDebugPause_ParamsSize = NativeReflection.GetFunctionParamsSize(GSDebugPause_FunctionAddress);
		GSDebugPause_IsValid = GSDebugPause_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSDebugPause", GSDebugPause_IsValid);
		GSActiveFX_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSActiveFX");
		GSActiveFX_ParamsSize = NativeReflection.GetFunctionParamsSize(GSActiveFX_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSActiveFX_IsActive_PropertyAddress, GSActiveFX_FunctionAddress, "IsActive");
		GSActiveFX_IsActive_Offset = NativeReflectionCached.GetPropertyOffset(GSActiveFX_FunctionAddress, "IsActive");
		GSActiveFX_IsActive_IsValid = NativeReflectionCached.ValidatePropertyClass(GSActiveFX_FunctionAddress, "IsActive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GSActiveFX_IsReset_PropertyAddress, GSActiveFX_FunctionAddress, "IsReset");
		GSActiveFX_IsReset_Offset = NativeReflectionCached.GetPropertyOffset(GSActiveFX_FunctionAddress, "IsReset");
		GSActiveFX_IsReset_IsValid = NativeReflectionCached.ValidatePropertyClass(GSActiveFX_FunctionAddress, "IsReset", Classes.FBoolProperty);
		GSActiveFX_IsValid = GSActiveFX_FunctionAddress != IntPtr.Zero && GSActiveFX_IsActive_IsValid && GSActiveFX_IsReset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GSActiveFX", GSActiveFX_IsValid);
		GetNiagaraComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNiagaraComponent");
		GetNiagaraComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraComponent_ReturnValue_PropertyAddress, GetNiagaraComponent_FunctionAddress, "ReturnValue");
		GetNiagaraComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraComponent_FunctionAddress, "ReturnValue");
		GetNiagaraComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetNiagaraComponent_IsValid = GetNiagaraComponent_FunctionAddress != IntPtr.Zero && GetNiagaraComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:GetNiagaraComponent", GetNiagaraComponent_IsValid);
		DeactivateSystem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DeactivateSystem");
		DeactivateSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(DeactivateSystem_FunctionAddress);
		DeactivateSystem_IsValid = DeactivateSystem_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:DeactivateSystem", DeactivateSystem_IsValid);
		ActivateSystem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ActivateSystem");
		ActivateSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(ActivateSystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActivateSystem_Reset_PropertyAddress, ActivateSystem_FunctionAddress, "Reset");
		ActivateSystem_Reset_Offset = NativeReflectionCached.GetPropertyOffset(ActivateSystem_FunctionAddress, "Reset");
		ActivateSystem_Reset_IsValid = NativeReflectionCached.ValidatePropertyClass(ActivateSystem_FunctionAddress, "Reset", Classes.FBoolProperty);
		ActivateSystem_IsValid = ActivateSystem_FunctionAddress != IntPtr.Zero && ActivateSystem_Reset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraUIRenderer.NiagaraSystemWidget:ActivateSystem", ActivateSystem_IsValid);
	}
}
