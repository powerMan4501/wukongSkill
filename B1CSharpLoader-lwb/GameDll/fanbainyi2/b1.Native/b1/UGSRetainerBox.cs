using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSRetainerBox", "UnrealExtent", UnrealModuleType.Game)]
public class UGSRetainerBox : UContentWidget
{
	private static bool RenderOnInvalidation_IsValid;

	private static FFieldAddress RenderOnInvalidation_PropertyAddress;

	private static int RenderOnInvalidation_Offset;

	private static bool RenderOnPhase_IsValid;

	private static FFieldAddress RenderOnPhase_PropertyAddress;

	private static int RenderOnPhase_Offset;

	private static bool Phase_IsValid;

	private static int Phase_Offset;

	private static bool PhaseCount_IsValid;

	private static int PhaseCount_Offset;

	private static bool IsGSPixToPix_IsValid;

	private static FFieldAddress IsGSPixToPix_PropertyAddress;

	private static int IsGSPixToPix_Offset;

	private static bool EffectMaterial_IsValid;

	private static int EffectMaterial_Offset;

	private static bool TextureParameter_IsValid;

	private static int TextureParameter_Offset;

	private static bool SetTextureParameter_IsValid;

	private static IntPtr SetTextureParameter_FunctionAddress;

	private static int SetTextureParameter_ParamsSize;

	private static bool SetTextureParameter_TextureParameter_IsValid;

	private static FFieldAddress SetTextureParameter_TextureParameter_PropertyAddress;

	private static int SetTextureParameter_TextureParameter_Offset;

	private static bool SetRetainRendering_IsValid;

	private static IntPtr SetRetainRendering_FunctionAddress;

	private static int SetRetainRendering_ParamsSize;

	private static bool SetRetainRendering_bInRetainRendering_IsValid;

	private static FFieldAddress SetRetainRendering_bInRetainRendering_PropertyAddress;

	private static int SetRetainRendering_bInRetainRendering_Offset;

	private static bool SetRenderingPhase_IsValid;

	private static IntPtr SetRenderingPhase_FunctionAddress;

	private static int SetRenderingPhase_ParamsSize;

	private static bool SetRenderingPhase_RenderPhase_IsValid;

	private static FFieldAddress SetRenderingPhase_RenderPhase_PropertyAddress;

	private static int SetRenderingPhase_RenderPhase_Offset;

	private static bool SetRenderingPhase_TotalPhases_IsValid;

	private static FFieldAddress SetRenderingPhase_TotalPhases_PropertyAddress;

	private static int SetRenderingPhase_TotalPhases_Offset;

	private static bool SetEffectMaterial_IsValid;

	private static IntPtr SetEffectMaterial_FunctionAddress;

	private static int SetEffectMaterial_ParamsSize;

	private static bool SetEffectMaterial_EffectMaterial_IsValid;

	private static FFieldAddress SetEffectMaterial_EffectMaterial_PropertyAddress;

	private static int SetEffectMaterial_EffectMaterial_Offset;

	private static bool RequestRender_IsValid;

	private static IntPtr RequestRender_FunctionAddress;

	private static int RequestRender_ParamsSize;

	private static bool OnViewWidgetSizeChangedEvent_IsValid;

	private IntPtr OnViewWidgetSizeChangedEvent_InstanceFunctionAddress;

	private static IntPtr OnViewWidgetSizeChangedEvent_FunctionAddress;

	private static int OnViewWidgetSizeChangedEvent_ParamsSize;

	private static bool OnViewWidgetSizeChangedEvent_Size_IsValid;

	private static FFieldAddress OnViewWidgetSizeChangedEvent_Size_PropertyAddress;

	private static int OnViewWidgetSizeChangedEvent_Size_Offset;

	private static bool GetEffectMaterial_IsValid;

	private static IntPtr GetEffectMaterial_FunctionAddress;

	private static int GetEffectMaterial_ParamsSize;

	private static bool GetEffectMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetEffectMaterial_ReturnValue_PropertyAddress;

	private static int GetEffectMaterial_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:RenderOnInvalidation")]
	public bool RenderOnInvalidation
	{
		get
		{
			CheckDestroyed();
			if (!RenderOnInvalidation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:RenderOnInvalidation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderOnInvalidation_Offset), 0, RenderOnInvalidation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderOnInvalidation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:RenderOnInvalidation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderOnInvalidation_Offset), 0, RenderOnInvalidation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:RenderOnPhase")]
	public bool RenderOnPhase
	{
		get
		{
			CheckDestroyed();
			if (!RenderOnPhase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:RenderOnPhase");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderOnPhase_Offset), 0, RenderOnPhase_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderOnPhase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:RenderOnPhase");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderOnPhase_Offset), 0, RenderOnPhase_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:Phase")]
	public int Phase
	{
		get
		{
			CheckDestroyed();
			if (!Phase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:Phase");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Phase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Phase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:Phase");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Phase_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:PhaseCount")]
	public int PhaseCount
	{
		get
		{
			CheckDestroyed();
			if (!PhaseCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:PhaseCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PhaseCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhaseCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:PhaseCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PhaseCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:IsGSPixToPix")]
	public bool IsGSPixToPix
	{
		get
		{
			CheckDestroyed();
			if (!IsGSPixToPix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:IsGSPixToPix");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsGSPixToPix_Offset), 0, IsGSPixToPix_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsGSPixToPix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:IsGSPixToPix");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsGSPixToPix_Offset), 0, IsGSPixToPix_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510165uL)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:EffectMaterial")]
	protected UMaterialInterface EffectMaterial
	{
		get
		{
			CheckDestroyed();
			if (!EffectMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:EffectMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, EffectMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:EffectMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, EffectMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:TextureParameter")]
	protected FName TextureParameter
	{
		get
		{
			CheckDestroyed();
			if (!TextureParameter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:TextureParameter");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TextureParameter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextureParameter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRetainerBox:TextureParameter");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TextureParameter_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:SetTextureParameter")]
	public unsafe void SetTextureParameter(FName TextureParameter)
	{
		CheckDestroyed();
		if (!SetTextureParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRetainerBox:SetTextureParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextureParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextureParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetTextureParameter_TextureParameter_Offset), 0, SetTextureParameter_TextureParameter_PropertyAddress.Address, TextureParameter);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextureParameter_FunctionAddress, intPtr, SetTextureParameter_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:SetRetainRendering")]
	public unsafe void SetRetainRendering(bool bInRetainRendering)
	{
		CheckDestroyed();
		if (!SetRetainRendering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRetainerBox:SetRetainRendering");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRetainRendering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRetainRendering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRetainRendering_bInRetainRendering_Offset), 0, SetRetainRendering_bInRetainRendering_PropertyAddress.Address, bInRetainRendering);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRetainRendering_FunctionAddress, intPtr, SetRetainRendering_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:SetRenderingPhase")]
	public unsafe void SetRenderingPhase(int RenderPhase, int TotalPhases)
	{
		CheckDestroyed();
		if (!SetRenderingPhase_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRetainerBox:SetRenderingPhase");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderingPhase_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderingPhase_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRenderingPhase_RenderPhase_Offset), 0, SetRenderingPhase_RenderPhase_PropertyAddress.Address, RenderPhase);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRenderingPhase_TotalPhases_Offset), 0, SetRenderingPhase_TotalPhases_PropertyAddress.Address, TotalPhases);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderingPhase_FunctionAddress, intPtr, SetRenderingPhase_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:SetEffectMaterial")]
	public unsafe void SetEffectMaterial(UMaterialInterface EffectMaterial)
	{
		CheckDestroyed();
		if (!SetEffectMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRetainerBox:SetEffectMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEffectMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEffectMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetEffectMaterial_EffectMaterial_Offset), 0, SetEffectMaterial_EffectMaterial_PropertyAddress.Address, EffectMaterial);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEffectMaterial_FunctionAddress, intPtr, SetEffectMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:RequestRender")]
	public unsafe void RequestRender()
	{
		CheckDestroyed();
		if (!RequestRender_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRetainerBox:RequestRender");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestRender_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestRender_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestRender_FunctionAddress, argsSize: RequestRender_ParamsSize);
	}

	[UFunction(Flags = 142739456u)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:OnViewWidgetSizeChangedEvent")]
	public unsafe void OnViewWidgetSizeChangedEvent(FVector2D Size)
	{
		CheckDestroyed();
		if (!OnViewWidgetSizeChangedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRetainerBox:OnViewWidgetSizeChangedEvent");
			return;
		}
		if (OnViewWidgetSizeChangedEvent_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnViewWidgetSizeChangedEvent_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnViewWidgetSizeChangedEvent");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnViewWidgetSizeChangedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnViewWidgetSizeChangedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, OnViewWidgetSizeChangedEvent_Size_Offset), 0, OnViewWidgetSizeChangedEvent_Size_PropertyAddress.Address, Size);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnViewWidgetSizeChangedEvent_InstanceFunctionAddress, intPtr, OnViewWidgetSizeChangedEvent_ParamsSize);
	}

	protected unsafe virtual void OnViewWidgetSizeChangedEvent_Implementation(FVector2D Size)
	{
		CheckDestroyed();
		if (!OnViewWidgetSizeChangedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRetainerBox:OnViewWidgetSizeChangedEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnViewWidgetSizeChangedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnViewWidgetSizeChangedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, OnViewWidgetSizeChangedEvent_Size_Offset), 0, OnViewWidgetSizeChangedEvent_Size_PropertyAddress.Address, Size);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnViewWidgetSizeChangedEvent_FunctionAddress, intPtr, OnViewWidgetSizeChangedEvent_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSRetainerBox:GetEffectMaterial")]
	public unsafe UMaterialInstanceDynamic GetEffectMaterial()
	{
		CheckDestroyed();
		if (!GetEffectMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRetainerBox:GetEffectMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEffectMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEffectMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEffectMaterial_FunctionAddress, intPtr, GetEffectMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetEffectMaterial_ReturnValue_Offset), 0, GetEffectMaterial_ReturnValue_PropertyAddress.Address);
	}

	static UGSRetainerBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSRetainerBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSRetainerBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.GSRetainerBox");
		NativeReflectionCached.GetPropertyRef(ref RenderOnInvalidation_PropertyAddress, intPtr, "RenderOnInvalidation");
		RenderOnInvalidation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RenderOnInvalidation");
		RenderOnInvalidation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RenderOnInvalidation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderOnPhase_PropertyAddress, intPtr, "RenderOnPhase");
		RenderOnPhase_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RenderOnPhase");
		RenderOnPhase_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RenderOnPhase", Classes.FBoolProperty);
		Phase_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Phase");
		Phase_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Phase", Classes.FIntProperty);
		PhaseCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PhaseCount");
		PhaseCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PhaseCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsGSPixToPix_PropertyAddress, intPtr, "IsGSPixToPix");
		IsGSPixToPix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsGSPixToPix");
		IsGSPixToPix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsGSPixToPix", Classes.FBoolProperty);
		EffectMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EffectMaterial");
		EffectMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EffectMaterial", Classes.FObjectProperty);
		TextureParameter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureParameter");
		TextureParameter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureParameter", Classes.FNameProperty);
		SetTextureParameter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTextureParameter");
		SetTextureParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextureParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextureParameter_TextureParameter_PropertyAddress, SetTextureParameter_FunctionAddress, "TextureParameter");
		SetTextureParameter_TextureParameter_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureParameter_FunctionAddress, "TextureParameter");
		SetTextureParameter_TextureParameter_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureParameter_FunctionAddress, "TextureParameter", Classes.FNameProperty);
		SetTextureParameter_IsValid = SetTextureParameter_FunctionAddress != IntPtr.Zero && SetTextureParameter_TextureParameter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRetainerBox:SetTextureParameter", SetTextureParameter_IsValid);
		SetRetainRendering_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRetainRendering");
		SetRetainRendering_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRetainRendering_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRetainRendering_bInRetainRendering_PropertyAddress, SetRetainRendering_FunctionAddress, "bInRetainRendering");
		SetRetainRendering_bInRetainRendering_Offset = NativeReflectionCached.GetPropertyOffset(SetRetainRendering_FunctionAddress, "bInRetainRendering");
		SetRetainRendering_bInRetainRendering_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRetainRendering_FunctionAddress, "bInRetainRendering", Classes.FBoolProperty);
		SetRetainRendering_IsValid = SetRetainRendering_FunctionAddress != IntPtr.Zero && SetRetainRendering_bInRetainRendering_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRetainerBox:SetRetainRendering", SetRetainRendering_IsValid);
		SetRenderingPhase_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderingPhase");
		SetRenderingPhase_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderingPhase_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderingPhase_RenderPhase_PropertyAddress, SetRenderingPhase_FunctionAddress, "RenderPhase");
		SetRenderingPhase_RenderPhase_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderingPhase_FunctionAddress, "RenderPhase");
		SetRenderingPhase_RenderPhase_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderingPhase_FunctionAddress, "RenderPhase", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRenderingPhase_TotalPhases_PropertyAddress, SetRenderingPhase_FunctionAddress, "TotalPhases");
		SetRenderingPhase_TotalPhases_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderingPhase_FunctionAddress, "TotalPhases");
		SetRenderingPhase_TotalPhases_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderingPhase_FunctionAddress, "TotalPhases", Classes.FIntProperty);
		SetRenderingPhase_IsValid = SetRenderingPhase_FunctionAddress != IntPtr.Zero && SetRenderingPhase_RenderPhase_IsValid && SetRenderingPhase_TotalPhases_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRetainerBox:SetRenderingPhase", SetRenderingPhase_IsValid);
		SetEffectMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEffectMaterial");
		SetEffectMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEffectMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEffectMaterial_EffectMaterial_PropertyAddress, SetEffectMaterial_FunctionAddress, "EffectMaterial");
		SetEffectMaterial_EffectMaterial_Offset = NativeReflectionCached.GetPropertyOffset(SetEffectMaterial_FunctionAddress, "EffectMaterial");
		SetEffectMaterial_EffectMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEffectMaterial_FunctionAddress, "EffectMaterial", Classes.FObjectProperty);
		SetEffectMaterial_IsValid = SetEffectMaterial_FunctionAddress != IntPtr.Zero && SetEffectMaterial_EffectMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRetainerBox:SetEffectMaterial", SetEffectMaterial_IsValid);
		RequestRender_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RequestRender");
		RequestRender_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestRender_FunctionAddress);
		RequestRender_IsValid = RequestRender_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRetainerBox:RequestRender", RequestRender_IsValid);
		OnViewWidgetSizeChangedEvent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnViewWidgetSizeChangedEvent");
		OnViewWidgetSizeChangedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewWidgetSizeChangedEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnViewWidgetSizeChangedEvent_Size_PropertyAddress, OnViewWidgetSizeChangedEvent_FunctionAddress, "Size");
		OnViewWidgetSizeChangedEvent_Size_Offset = NativeReflectionCached.GetPropertyOffset(OnViewWidgetSizeChangedEvent_FunctionAddress, "Size");
		OnViewWidgetSizeChangedEvent_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewWidgetSizeChangedEvent_FunctionAddress, "Size", Classes.FStructProperty);
		OnViewWidgetSizeChangedEvent_IsValid = OnViewWidgetSizeChangedEvent_FunctionAddress != IntPtr.Zero && OnViewWidgetSizeChangedEvent_Size_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRetainerBox:OnViewWidgetSizeChangedEvent", OnViewWidgetSizeChangedEvent_IsValid);
		GetEffectMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetEffectMaterial");
		GetEffectMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEffectMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEffectMaterial_ReturnValue_PropertyAddress, GetEffectMaterial_FunctionAddress, "ReturnValue");
		GetEffectMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEffectMaterial_FunctionAddress, "ReturnValue");
		GetEffectMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEffectMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetEffectMaterial_IsValid = GetEffectMaterial_FunctionAddress != IntPtr.Zero && GetEffectMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRetainerBox:GetEffectMaterial", GetEffectMaterial_IsValid);
	}
}
