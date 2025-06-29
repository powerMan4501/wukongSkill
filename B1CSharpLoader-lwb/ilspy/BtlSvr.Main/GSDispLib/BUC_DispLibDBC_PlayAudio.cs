using System;
using System.Collections.Generic;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio")]
public struct BUC_DispLibDBC_PlayAudio
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("延迟时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio:Delay")]
	public float Delay;

	[EditAnywhere]
	[UMeta(MD.ToolTip, "【自动销毁】可能导致无限循环的声音无法停止")]
	[BlueprintReadWrite]
	[DisplayName("结束模式")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio:EndMode")]
	public DispLibDBCEndMode EndMode;

	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::ProcedureNotity")]
	[DisplayName("持续时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio:Duration")]
	public float Duration;

	[DisplayName("跟随Actor")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio:FollowActor")]
	public bool FollowActor;

	[Tooltip("填写目标comp的tag，为None表示以master作为目标，否则查找tag对应的骨骼，多个结果只取第一个")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("目标MeshComp")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio:CompTag")]
	public FName CompTag;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("SocketName")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio:SocketName")]
	public FName SocketName;

	[UMeta(MDProp.EditCondition, "FollowActor")]
	[DisplayName("Actor销毁时停止播放")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio:StopOnFollowActorDestroy")]
	public bool StopOnFollowActorDestroy;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio:AkAudioEvent")]
	public UAkAudioEvent AkAudioEvent;

	[UMeta(MD.DisplayName, "设置RTPC")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio:RTPC")]
	public List<BUC_DispLibUtil_DBCAdvProcessScalarParam> RTPC;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("淡出时间(秒)")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::AutoRelease")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio:FadeOutTime")]
	public float FadeOutTime;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "当触发暂停时会给定一个优先级，如果此参数大于优先级则不会被暂停")]
	[DisplayName("暂停优先级")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio:PausePriority")]
	public int PausePriority;

	private static int BUC_DispLibDBC_PlayAudio_StructSize;

	private static int BUC_DispLibDBC_PlayAudio_IsValid;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool FollowActor_IsValid;

	private static int FollowActor_Offset;

	private static FFieldAddress FollowActor_PropertyAddress;

	private static bool CompTag_IsValid;

	private static int CompTag_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool StopOnFollowActorDestroy_IsValid;

	private static int StopOnFollowActorDestroy_Offset;

	private static FFieldAddress StopOnFollowActorDestroy_PropertyAddress;

	private static bool AkAudioEvent_IsValid;

	private static int AkAudioEvent_Offset;

	private static bool RTPC_IsValid;

	private static int RTPC_Offset;

	private static FFieldAddress RTPC_PropertyAddress;

	private static bool FadeOutTime_IsValid;

	private static int FadeOutTime_Offset;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	public BUC_DispLibDBC_PlayAudio SetCustomData(float _Delay, DispLibDBCEndMode _EndMode, float _Duration, bool _FollowActor, FName _CompTag, FName _SocketName, bool _StopOnFollowActorDestroy, UAkAudioEvent _AkAudioEvent, List<BUC_DispLibUtil_DBCAdvProcessScalarParam> _RTPC, float _FadeOutTime, int _PausePriority)
	{
		Delay = _Delay;
		EndMode = _EndMode;
		Duration = _Duration;
		FollowActor = _FollowActor;
		CompTag = _CompTag;
		SocketName = _SocketName;
		StopOnFollowActorDestroy = _StopOnFollowActorDestroy;
		AkAudioEvent = _AkAudioEvent;
		RTPC = _RTPC;
		FadeOutTime = _FadeOutTime;
		PausePriority = _PausePriority;
		return this;
	}

	public BUC_DispLibDBC_PlayAudio Copy()
	{
		BUC_DispLibDBC_PlayAudio result = this;
		if (RTPC != null)
		{
			result.RTPC = new List<BUC_DispLibUtil_DBCAdvProcessScalarParam>(RTPC);
		}
		return result;
	}

	public static BUC_DispLibDBC_PlayAudio FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_PlayAudio(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_PlayAudio value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_PlayAudio FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_PlayAudio(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayAudio_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_PlayAudio value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayAudio_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayAudio_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FollowActor_Offset), 0, FollowActor_PropertyAddress.Address, FollowActor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, CompTag_Offset), CompTag);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, StopOnFollowActorDestroy_Offset), 0, StopOnFollowActorDestroy_PropertyAddress.Address, StopOnFollowActorDestroy);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkAudioEvent_Offset), AkAudioEvent);
		new TArrayCopyMarshaler<BUC_DispLibUtil_DBCAdvProcessScalarParam>(1, RTPC_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarParam, BUC_DispLibUtil_DBCAdvProcessScalarParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarParam, BUC_DispLibUtil_DBCAdvProcessScalarParam>.ToNative).ToNative(IntPtr.Add(nativeStruct, RTPC_Offset), RTPC);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FadeOutTime_Offset), FadeOutTime);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
	}

	public BUC_DispLibDBC_PlayAudio(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayAudio_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio");
			Delay = 0f;
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			FollowActor = false;
			CompTag = default(FName);
			SocketName = default(FName);
			StopOnFollowActorDestroy = false;
			AkAudioEvent = null;
			RTPC = null;
			FadeOutTime = 0f;
			PausePriority = 0;
		}
		else
		{
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			FollowActor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FollowActor_Offset), 0, FollowActor_PropertyAddress.Address);
			CompTag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, CompTag_Offset));
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			StopOnFollowActorDestroy = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, StopOnFollowActorDestroy_Offset), 0, StopOnFollowActorDestroy_PropertyAddress.Address);
			AkAudioEvent = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkAudioEvent_Offset));
			RTPC = new TArrayCopyMarshaler<BUC_DispLibUtil_DBCAdvProcessScalarParam>(1, RTPC_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarParam, BUC_DispLibUtil_DBCAdvProcessScalarParam>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_DBCAdvProcessScalarParam, BUC_DispLibUtil_DBCAdvProcessScalarParam>.ToNative).FromNative(IntPtr.Add(nativeStruct, RTPC_Offset));
			FadeOutTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FadeOutTime_Offset));
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio");
		BUC_DispLibDBC_PlayAudio_StructSize = NativeReflection.GetStructSize(intPtr);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref FollowActor_PropertyAddress, intPtr, "FollowActor");
		FollowActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "FollowActor");
		FollowActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FollowActor", Classes.FBoolProperty);
		CompTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompTag");
		CompTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompTag", Classes.FNameProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref StopOnFollowActorDestroy_PropertyAddress, intPtr, "StopOnFollowActorDestroy");
		StopOnFollowActorDestroy_Offset = NativeReflection.GetPropertyOffset(intPtr, "StopOnFollowActorDestroy");
		StopOnFollowActorDestroy_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StopOnFollowActorDestroy", Classes.FBoolProperty);
		AkAudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkAudioEvent");
		AkAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkAudioEvent", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref RTPC_PropertyAddress, intPtr, "RTPC");
		RTPC_Offset = NativeReflection.GetPropertyOffset(intPtr, "RTPC");
		RTPC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RTPC", Classes.FArrayProperty);
		FadeOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "FadeOutTime");
		FadeOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FadeOutTime", Classes.FFloatProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		BUC_DispLibDBC_PlayAudio_IsValid = ((intPtr != IntPtr.Zero && Delay_IsValid && EndMode_IsValid && Duration_IsValid && FollowActor_IsValid && CompTag_IsValid && SocketName_IsValid && StopOnFollowActorDestroy_IsValid && AkAudioEvent_IsValid && RTPC_IsValid && FadeOutTime_IsValid && PausePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_PlayAudio", (byte)BUC_DispLibDBC_PlayAudio_IsValid != 0);
	}

	static BUC_DispLibDBC_PlayAudio()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_PlayAudio)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_PlayAudio));
	}
}
