using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp")]
internal class BUS_JJSObstacleConfigComp : UActorEditCompBase
{
	private BUC_JJSObstacleData ConfigData;

	private static bool bDefaultEnable_IsValid;

	private static int bDefaultEnable_Offset;

	private static FFieldAddress bDefaultEnable_PropertyAddress;

	private static bool bOpenWhenSpecialSkillHit_IsValid;

	private static int bOpenWhenSpecialSkillHit_Offset;

	private static FFieldAddress bOpenWhenSpecialSkillHit_PropertyAddress;

	private static bool SpecialSkillList_IsValid;

	private static int SpecialSkillList_Offset;

	private static FFieldAddress SpecialSkillList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SpecialSkillList_Marshaler;

	private static bool OpenFx_IsValid;

	private static int OpenFx_Offset;

	private static bool OpenFxTransform_IsValid;

	private static int OpenFxTransform_Offset;

	private static bool OpenAudio_IsValid;

	private static int OpenAudio_Offset;

	private static bool OpenStateLoopAudio_IsValid;

	private static int OpenStateLoopAudio_Offset;

	private static bool CloseFx_IsValid;

	private static int CloseFx_Offset;

	private static bool CloseFxTransform_IsValid;

	private static int CloseFxTransform_Offset;

	private static bool CloseAudio_IsValid;

	private static int CloseAudio_Offset;

	private static bool CloseStateLoopAudio_IsValid;

	private static int CloseStateLoopAudio_Offset;

	[UProperty]
	[EditAnywhere]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp:bDefaultEnable")]
	public bool bDefaultEnable
	{
		get
		{
			CheckDestroyed();
			if (!bDefaultEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:bDefaultEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDefaultEnable_Offset), 0, bDefaultEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDefaultEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:bDefaultEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDefaultEnable_Offset), 0, bDefaultEnable_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Config")]
	[UProperty]
	[DisplayName("特定SkillEffect命中后开启(可通过)")]
	[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp:bOpenWhenSpecialSkillHit")]
	public bool bOpenWhenSpecialSkillHit
	{
		get
		{
			CheckDestroyed();
			if (!bOpenWhenSpecialSkillHit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:bOpenWhenSpecialSkillHit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bOpenWhenSpecialSkillHit_Offset), 0, bOpenWhenSpecialSkillHit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bOpenWhenSpecialSkillHit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:bOpenWhenSpecialSkillHit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bOpenWhenSpecialSkillHit_Offset), 0, bOpenWhenSpecialSkillHit_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Config")]
	[DisplayName("特定SkillEffect列表")]
	[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp:SpecialSkillList")]
	public TArrayReadWrite<int> SpecialSkillList
	{
		get
		{
			CheckDestroyed();
			if (!SpecialSkillList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:SpecialSkillList");
				return null;
			}
			if (SpecialSkillList_Marshaler == null)
			{
				SpecialSkillList_Marshaler = new TArrayReadWriteMarshaler<int>(1, SpecialSkillList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SpecialSkillList_Marshaler.FromNative(IntPtr.Add(base.Address, SpecialSkillList_Offset));
		}
	}

	[UProperty]
	[DisplayName("开启瞬间特效")]
	[EditAnywhere]
	[Category("Config|开启(可通过)时配置")]
	[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenFx")]
	public TSoftObject<UNiagaraSystem> OpenFx
	{
		get
		{
			CheckDestroyed();
			if (!OpenFx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenFx");
				return default(TSoftObject<UNiagaraSystem>);
			}
			return TSoftObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, OpenFx_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OpenFx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenFx");
			}
			else
			{
				TSoftObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, OpenFx_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Config|开启(可通过)时配置")]
	[DisplayName("特效本地偏移")]
	[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenFxTransform")]
	public FTransform OpenFxTransform
	{
		get
		{
			CheckDestroyed();
			if (!OpenFxTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenFxTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, OpenFxTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OpenFxTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenFxTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, OpenFxTransform_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Config|开启(可通过)时配置")]
	[DisplayName("开启瞬间声音")]
	[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenAudio")]
	public TSoftObject<UAkAudioEvent> OpenAudio
	{
		get
		{
			CheckDestroyed();
			if (!OpenAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenAudio");
				return default(TSoftObject<UAkAudioEvent>);
			}
			return TSoftObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, OpenAudio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OpenAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenAudio");
			}
			else
			{
				TSoftObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, OpenAudio_Offset), value);
			}
		}
	}

	[Category("Config|开启(可通过)时配置")]
	[UProperty]
	[DisplayName("开启状态持续声音")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenStateLoopAudio")]
	public TSoftObject<UAkAudioEvent> OpenStateLoopAudio
	{
		get
		{
			CheckDestroyed();
			if (!OpenStateLoopAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenStateLoopAudio");
				return default(TSoftObject<UAkAudioEvent>);
			}
			return TSoftObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, OpenStateLoopAudio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OpenStateLoopAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:OpenStateLoopAudio");
			}
			else
			{
				TSoftObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, OpenStateLoopAudio_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Config|关闭(不可通过)时配置")]
	[DisplayName("关闭瞬间特效")]
	[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseFx")]
	public TSoftObject<UNiagaraSystem> CloseFx
	{
		get
		{
			CheckDestroyed();
			if (!CloseFx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseFx");
				return default(TSoftObject<UNiagaraSystem>);
			}
			return TSoftObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, CloseFx_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloseFx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseFx");
			}
			else
			{
				TSoftObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, CloseFx_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Config|关闭(不可通过)时配置")]
	[DisplayName("特效本地偏移")]
	[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseFxTransform")]
	public FTransform CloseFxTransform
	{
		get
		{
			CheckDestroyed();
			if (!CloseFxTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseFxTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, CloseFxTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloseFxTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseFxTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, CloseFxTransform_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Config|关闭(不可通过)时配置")]
	[DisplayName("关闭瞬间声音")]
	[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseAudio")]
	public TSoftObject<UAkAudioEvent> CloseAudio
	{
		get
		{
			CheckDestroyed();
			if (!CloseAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseAudio");
				return default(TSoftObject<UAkAudioEvent>);
			}
			return TSoftObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, CloseAudio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloseAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseAudio");
			}
			else
			{
				TSoftObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, CloseAudio_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("关闭状态持续声音")]
	[Category("Config|关闭(不可通过)时配置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseStateLoopAudio")]
	public TSoftObject<UAkAudioEvent> CloseStateLoopAudio
	{
		get
		{
			CheckDestroyed();
			if (!CloseStateLoopAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseStateLoopAudio");
				return default(TSoftObject<UAkAudioEvent>);
			}
			return TSoftObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, CloseStateLoopAudio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloseStateLoopAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_JJSObstacleConfigComp:CloseStateLoopAudio");
			}
			else
			{
				TSoftObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, CloseStateLoopAudio_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_JJSObstacleData bUC_JJSObstacleData = RequireWritableData<BUC_JJSObstacleData>();
		bUC_JJSObstacleData.bDefaultEnable = bDefaultEnable;
		bUC_JJSObstacleData.bOpenWhenSpecialSkillHit = bOpenWhenSpecialSkillHit;
		bUC_JJSObstacleData.SpecialSkillList = SpecialSkillList.ToList();
		bUC_JJSObstacleData.OpenStateFx = OpenFx.Value;
		bUC_JJSObstacleData.OpenFxTransform = OpenFxTransform;
		bUC_JJSObstacleData.OpenStateAudio = OpenAudio.Value;
		bUC_JJSObstacleData.OpenStateLoopAudio = OpenStateLoopAudio.Value;
		bUC_JJSObstacleData.CloseStateFx = CloseFx.Value;
		bUC_JJSObstacleData.CloseFxTransform = CloseFxTransform;
		bUC_JJSObstacleData.CloseStateAudio = CloseAudio.Value;
		bUC_JJSObstacleData.CloseStateLoopAudio = CloseStateLoopAudio.Value;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_JJSObstacleConfigComp");
		NativeReflection.GetPropertyRef(ref bDefaultEnable_PropertyAddress, unrealStruct, "bDefaultEnable");
		bDefaultEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDefaultEnable");
		bDefaultEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDefaultEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bOpenWhenSpecialSkillHit_PropertyAddress, unrealStruct, "bOpenWhenSpecialSkillHit");
		bOpenWhenSpecialSkillHit_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bOpenWhenSpecialSkillHit");
		bOpenWhenSpecialSkillHit_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bOpenWhenSpecialSkillHit", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SpecialSkillList_PropertyAddress, unrealStruct, "SpecialSkillList");
		SpecialSkillList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialSkillList");
		SpecialSkillList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialSkillList", Classes.FArrayProperty);
		OpenFx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenFx");
		OpenFx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenFx", Classes.FSoftObjectProperty);
		OpenFxTransform_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenFxTransform");
		OpenFxTransform_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenFxTransform", Classes.FStructProperty);
		OpenAudio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenAudio");
		OpenAudio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenAudio", Classes.FSoftObjectProperty);
		OpenStateLoopAudio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenStateLoopAudio");
		OpenStateLoopAudio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenStateLoopAudio", Classes.FSoftObjectProperty);
		CloseFx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloseFx");
		CloseFx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloseFx", Classes.FSoftObjectProperty);
		CloseFxTransform_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloseFxTransform");
		CloseFxTransform_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloseFxTransform", Classes.FStructProperty);
		CloseAudio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloseAudio");
		CloseAudio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloseAudio", Classes.FSoftObjectProperty);
		CloseStateLoopAudio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloseStateLoopAudio");
		CloseStateLoopAudio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloseStateLoopAudio", Classes.FSoftObjectProperty);
	}

	static BUS_JJSObstacleConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_JJSObstacleConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_JJSObstacleConfigComp));
	}
}
