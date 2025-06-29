using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ForceFeedbackComponent", "Engine", UnrealModuleType.Engine)]
public class UForceFeedbackComponent : USceneComponent
{
	private static bool ForceFeedbackEffect_IsValid;

	private static int ForceFeedbackEffect_Offset;

	private static bool Looping_IsValid;

	private static FFieldAddress Looping_PropertyAddress;

	private static int Looping_Offset;

	private static bool IgnoreTimeDilation_IsValid;

	private static FFieldAddress IgnoreTimeDilation_PropertyAddress;

	private static int IgnoreTimeDilation_Offset;

	private static bool OverrideAttenuation_IsValid;

	private static FFieldAddress OverrideAttenuation_PropertyAddress;

	private static int OverrideAttenuation_Offset;

	private static bool IntensityMultiplier_IsValid;

	private static int IntensityMultiplier_Offset;

	private static bool AttenuationSettings_IsValid;

	private static int AttenuationSettings_Offset;

	private static bool AttenuationOverrides_IsValid;

	private static int AttenuationOverrides_Offset;

	private static bool OnForceFeedbackFinished_IsValid;

	private static int OnForceFeedbackFinished_Offset;

	private FOnForceFeedbackFinished OnForceFeedbackFinished_DelegateCached;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool SetIntensityMultiplier_IsValid;

	private static IntPtr SetIntensityMultiplier_FunctionAddress;

	private static int SetIntensityMultiplier_ParamsSize;

	private static bool SetIntensityMultiplier_NewIntensityMultiplier_IsValid;

	private static FFieldAddress SetIntensityMultiplier_NewIntensityMultiplier_PropertyAddress;

	private static int SetIntensityMultiplier_NewIntensityMultiplier_Offset;

	private static bool SetForceFeedbackEffect_IsValid;

	private static IntPtr SetForceFeedbackEffect_FunctionAddress;

	private static int SetForceFeedbackEffect_ParamsSize;

	private static bool SetForceFeedbackEffect_NewForceFeedbackEffect_IsValid;

	private static FFieldAddress SetForceFeedbackEffect_NewForceFeedbackEffect_PropertyAddress;

	private static int SetForceFeedbackEffect_NewForceFeedbackEffect_Offset;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool Play_StartTime_IsValid;

	private static FFieldAddress Play_StartTime_PropertyAddress;

	private static int Play_StartTime_Offset;

	private static bool GetAttenuationSettingsToApply_IsValid;

	private static IntPtr GetAttenuationSettingsToApply_FunctionAddress;

	private static int GetAttenuationSettingsToApply_ParamsSize;

	private static bool GetAttenuationSettingsToApply_OutAttenuationSettings_IsValid;

	private static FFieldAddress GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress;

	private static int GetAttenuationSettingsToApply_OutAttenuationSettings_Offset;

	private static bool GetAttenuationSettingsToApply_ReturnValue_IsValid;

	private static FFieldAddress GetAttenuationSettingsToApply_ReturnValue_PropertyAddress;

	private static int GetAttenuationSettingsToApply_ReturnValue_Offset;

	private static bool AdjustAttenuation_IsValid;

	private static IntPtr AdjustAttenuation_FunctionAddress;

	private static int AdjustAttenuation_ParamsSize;

	private static bool AdjustAttenuation_InAttenuationSettings_IsValid;

	private static FFieldAddress AdjustAttenuation_InAttenuationSettings_PropertyAddress;

	private static int AdjustAttenuation_InAttenuationSettings_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:ForceFeedbackEffect")]
	public UForceFeedbackEffect ForceFeedbackEffect
	{
		get
		{
			CheckDestroyed();
			if (!ForceFeedbackEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:ForceFeedbackEffect");
				return null;
			}
			return UObjectMarshaler<UForceFeedbackEffect>.FromNative(IntPtr.Add(base.Address, ForceFeedbackEffect_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceFeedbackEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:ForceFeedbackEffect");
			}
			else
			{
				UObjectMarshaler<UForceFeedbackEffect>.ToNative(IntPtr.Add(base.Address, ForceFeedbackEffect_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:bLooping")]
	public bool Looping
	{
		get
		{
			CheckDestroyed();
			if (!Looping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:bLooping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Looping_Offset), 0, Looping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Looping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:bLooping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Looping_Offset), 0, Looping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:bIgnoreTimeDilation")]
	public bool IgnoreTimeDilation
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreTimeDilation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:bIgnoreTimeDilation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreTimeDilation_Offset), 0, IgnoreTimeDilation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreTimeDilation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:bIgnoreTimeDilation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreTimeDilation_Offset), 0, IgnoreTimeDilation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:bOverrideAttenuation")]
	public bool OverrideAttenuation
	{
		get
		{
			CheckDestroyed();
			if (!OverrideAttenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:bOverrideAttenuation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideAttenuation_Offset), 0, OverrideAttenuation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideAttenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:bOverrideAttenuation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideAttenuation_Offset), 0, OverrideAttenuation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:IntensityMultiplier")]
	public float IntensityMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!IntensityMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:IntensityMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IntensityMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntensityMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:IntensityMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IntensityMultiplier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:AttenuationSettings")]
	public UForceFeedbackAttenuation AttenuationSettings
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:AttenuationSettings");
				return null;
			}
			return UObjectMarshaler<UForceFeedbackAttenuation>.FromNative(IntPtr.Add(base.Address, AttenuationSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:AttenuationSettings");
			}
			else
			{
				UObjectMarshaler<UForceFeedbackAttenuation>.ToNative(IntPtr.Add(base.Address, AttenuationSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:AttenuationOverrides")]
	public FForceFeedbackAttenuationSettings AttenuationOverrides
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:AttenuationOverrides");
				return default(FForceFeedbackAttenuationSettings);
			}
			return FForceFeedbackAttenuationSettings.FromNative(IntPtr.Add(base.Address, AttenuationOverrides_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:AttenuationOverrides");
			}
			else
			{
				FForceFeedbackAttenuationSettings.ToNative(IntPtr.Add(base.Address, AttenuationOverrides_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:OnForceFeedbackFinished")]
	public FOnForceFeedbackFinished OnForceFeedbackFinished
	{
		get
		{
			CheckDestroyed();
			if (!OnForceFeedbackFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackComponent:OnForceFeedbackFinished");
				return new FOnForceFeedbackFinished();
			}
			if (OnForceFeedbackFinished_DelegateCached == null)
			{
				OnForceFeedbackFinished_DelegateCached = new FOnForceFeedbackFinished();
				OnForceFeedbackFinished_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnForceFeedbackFinished_Offset));
			}
			return OnForceFeedbackFinished_DelegateCached;
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ForceFeedbackComponent:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:SetIntensityMultiplier")]
	public unsafe void SetIntensityMultiplier(float NewIntensityMultiplier)
	{
		CheckDestroyed();
		if (!SetIntensityMultiplier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ForceFeedbackComponent:SetIntensityMultiplier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIntensityMultiplier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIntensityMultiplier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetIntensityMultiplier_NewIntensityMultiplier_Offset), 0, SetIntensityMultiplier_NewIntensityMultiplier_PropertyAddress.Address, NewIntensityMultiplier);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIntensityMultiplier_FunctionAddress, intPtr, SetIntensityMultiplier_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:SetForceFeedbackEffect")]
	public unsafe void SetForceFeedbackEffect(UForceFeedbackEffect NewForceFeedbackEffect)
	{
		CheckDestroyed();
		if (!SetForceFeedbackEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ForceFeedbackComponent:SetForceFeedbackEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForceFeedbackEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForceFeedbackEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UForceFeedbackEffect>.ToNative(IntPtr.Add(intPtr, SetForceFeedbackEffect_NewForceFeedbackEffect_Offset), 0, SetForceFeedbackEffect_NewForceFeedbackEffect_PropertyAddress.Address, NewForceFeedbackEffect);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForceFeedbackEffect_FunctionAddress, intPtr, SetForceFeedbackEffect_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:Play")]
	public unsafe void Play(float StartTime = 0f)
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ForceFeedbackComponent:Play");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Play_StartTime_Offset), 0, Play_StartTime_PropertyAddress.Address, StartTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, Play_FunctionAddress, intPtr, Play_ParamsSize);
	}

	[UFunction(Flags = 1413612545u, OriginalName = "BP_GetAttenuationSettingsToApply")]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:BP_GetAttenuationSettingsToApply")]
	public unsafe bool GetAttenuationSettingsToApply(out FForceFeedbackAttenuationSettings OutAttenuationSettings)
	{
		CheckDestroyed();
		if (!GetAttenuationSettingsToApply_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ForceFeedbackComponent:BP_GetAttenuationSettingsToApply");
			OutAttenuationSettings = default(FForceFeedbackAttenuationSettings);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttenuationSettingsToApply_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttenuationSettingsToApply_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttenuationSettingsToApply_FunctionAddress, intPtr, GetAttenuationSettingsToApply_ParamsSize);
		OutAttenuationSettings = FForceFeedbackAttenuationSettings.FromNative(IntPtr.Add(intPtr, GetAttenuationSettingsToApply_OutAttenuationSettings_Offset), 0, GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAttenuationSettingsToApply_ReturnValue_Offset), 0, GetAttenuationSettingsToApply_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.ForceFeedbackComponent:AdjustAttenuation")]
	public unsafe void AdjustAttenuation(FForceFeedbackAttenuationSettings InAttenuationSettings)
	{
		CheckDestroyed();
		if (!AdjustAttenuation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ForceFeedbackComponent:AdjustAttenuation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AdjustAttenuation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AdjustAttenuation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AdjustAttenuation_InAttenuationSettings_PropertyAddress.Address, intPtr);
		FForceFeedbackAttenuationSettings.ToNative(IntPtr.Add(intPtr, AdjustAttenuation_InAttenuationSettings_Offset), 0, AdjustAttenuation_InAttenuationSettings_PropertyAddress.Address, InAttenuationSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, AdjustAttenuation_FunctionAddress, intPtr, AdjustAttenuation_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AdjustAttenuation_InAttenuationSettings_PropertyAddress.Address, intPtr);
	}

	static UForceFeedbackComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UForceFeedbackComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UForceFeedbackComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.ForceFeedbackComponent");
		ForceFeedbackEffect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForceFeedbackEffect");
		ForceFeedbackEffect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForceFeedbackEffect", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Looping_PropertyAddress, intPtr, "bLooping");
		Looping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLooping");
		Looping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLooping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreTimeDilation_PropertyAddress, intPtr, "bIgnoreTimeDilation");
		IgnoreTimeDilation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreTimeDilation");
		IgnoreTimeDilation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreTimeDilation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideAttenuation_PropertyAddress, intPtr, "bOverrideAttenuation");
		OverrideAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideAttenuation");
		OverrideAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideAttenuation", Classes.FBoolProperty);
		IntensityMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IntensityMultiplier");
		IntensityMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IntensityMultiplier", Classes.FFloatProperty);
		AttenuationSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationSettings");
		AttenuationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationSettings", Classes.FObjectProperty);
		AttenuationOverrides_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationOverrides");
		AttenuationOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationOverrides", Classes.FStructProperty);
		OnForceFeedbackFinished_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnForceFeedbackFinished");
		OnForceFeedbackFinished_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnForceFeedbackFinished", Classes.FMulticastDelegateProperty);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ForceFeedbackComponent:Stop", Stop_IsValid);
		SetIntensityMultiplier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIntensityMultiplier");
		SetIntensityMultiplier_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIntensityMultiplier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIntensityMultiplier_NewIntensityMultiplier_PropertyAddress, SetIntensityMultiplier_FunctionAddress, "NewIntensityMultiplier");
		SetIntensityMultiplier_NewIntensityMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(SetIntensityMultiplier_FunctionAddress, "NewIntensityMultiplier");
		SetIntensityMultiplier_NewIntensityMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntensityMultiplier_FunctionAddress, "NewIntensityMultiplier", Classes.FFloatProperty);
		SetIntensityMultiplier_IsValid = SetIntensityMultiplier_FunctionAddress != IntPtr.Zero && SetIntensityMultiplier_NewIntensityMultiplier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ForceFeedbackComponent:SetIntensityMultiplier", SetIntensityMultiplier_IsValid);
		SetForceFeedbackEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForceFeedbackEffect");
		SetForceFeedbackEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceFeedbackEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceFeedbackEffect_NewForceFeedbackEffect_PropertyAddress, SetForceFeedbackEffect_FunctionAddress, "NewForceFeedbackEffect");
		SetForceFeedbackEffect_NewForceFeedbackEffect_Offset = NativeReflectionCached.GetPropertyOffset(SetForceFeedbackEffect_FunctionAddress, "NewForceFeedbackEffect");
		SetForceFeedbackEffect_NewForceFeedbackEffect_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceFeedbackEffect_FunctionAddress, "NewForceFeedbackEffect", Classes.FObjectProperty);
		SetForceFeedbackEffect_IsValid = SetForceFeedbackEffect_FunctionAddress != IntPtr.Zero && SetForceFeedbackEffect_NewForceFeedbackEffect_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ForceFeedbackComponent:SetForceFeedbackEffect", SetForceFeedbackEffect_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Play_StartTime_PropertyAddress, Play_FunctionAddress, "StartTime");
		Play_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(Play_FunctionAddress, "StartTime");
		Play_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Play_FunctionAddress, "StartTime", Classes.FFloatProperty);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero && Play_StartTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ForceFeedbackComponent:Play", Play_IsValid);
		GetAttenuationSettingsToApply_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_GetAttenuationSettingsToApply");
		GetAttenuationSettingsToApply_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttenuationSettingsToApply_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress, GetAttenuationSettingsToApply_FunctionAddress, "OutAttenuationSettings");
		GetAttenuationSettingsToApply_OutAttenuationSettings_Offset = NativeReflectionCached.GetPropertyOffset(GetAttenuationSettingsToApply_FunctionAddress, "OutAttenuationSettings");
		GetAttenuationSettingsToApply_OutAttenuationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttenuationSettingsToApply_FunctionAddress, "OutAttenuationSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAttenuationSettingsToApply_ReturnValue_PropertyAddress, GetAttenuationSettingsToApply_FunctionAddress, "ReturnValue");
		GetAttenuationSettingsToApply_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttenuationSettingsToApply_FunctionAddress, "ReturnValue");
		GetAttenuationSettingsToApply_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttenuationSettingsToApply_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAttenuationSettingsToApply_IsValid = GetAttenuationSettingsToApply_FunctionAddress != IntPtr.Zero && GetAttenuationSettingsToApply_OutAttenuationSettings_IsValid && GetAttenuationSettingsToApply_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ForceFeedbackComponent:BP_GetAttenuationSettingsToApply", GetAttenuationSettingsToApply_IsValid);
		AdjustAttenuation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AdjustAttenuation");
		AdjustAttenuation_ParamsSize = NativeReflection.GetFunctionParamsSize(AdjustAttenuation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AdjustAttenuation_InAttenuationSettings_PropertyAddress, AdjustAttenuation_FunctionAddress, "InAttenuationSettings");
		AdjustAttenuation_InAttenuationSettings_Offset = NativeReflectionCached.GetPropertyOffset(AdjustAttenuation_FunctionAddress, "InAttenuationSettings");
		AdjustAttenuation_InAttenuationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(AdjustAttenuation_FunctionAddress, "InAttenuationSettings", Classes.FStructProperty);
		AdjustAttenuation_IsValid = AdjustAttenuation_FunctionAddress != IntPtr.Zero && AdjustAttenuation_InAttenuationSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ForceFeedbackComponent:AdjustAttenuation", AdjustAttenuation_IsValid);
	}
}
