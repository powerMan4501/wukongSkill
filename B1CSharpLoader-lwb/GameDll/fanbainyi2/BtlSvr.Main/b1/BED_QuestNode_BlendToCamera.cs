using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BlendToCamera")]
[NotBlueprintable]
[USharpPath("/Script/b1-Managed.BED_QuestNode_BlendToCamera")]
public class BED_QuestNode_BlendToCamera : BED_QuestNode
{
	private static bool bPlayerAsViewTarget_IsValid;

	private static int bPlayerAsViewTarget_Offset;

	private static FFieldAddress bPlayerAsViewTarget_PropertyAddress;

	private static bool ViewTarget_IsValid;

	private static int ViewTarget_Offset;

	private static bool BlendTime_IsValid;

	private static int BlendTime_Offset;

	private static bool BlendFunc_IsValid;

	private static int BlendFunc_Offset;

	private static FFieldAddress BlendFunc_PropertyAddress;

	private static bool BlendExp_IsValid;

	private static int BlendExp_Offset;

	private static bool bLockOutgoing_IsValid;

	private static int bLockOutgoing_Offset;

	private static FFieldAddress bLockOutgoing_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditDefaultsOnly]
	[Category("Quest")]
	[Tooltip("new actor to set as view target")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_BlendToCamera:bPlayerAsViewTarget")]
	private bool bPlayerAsViewTarget
	{
		get
		{
			CheckDestroyed();
			if (!bPlayerAsViewTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:bPlayerAsViewTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPlayerAsViewTarget_Offset), 0, bPlayerAsViewTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPlayerAsViewTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:bPlayerAsViewTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPlayerAsViewTarget_Offset), 0, bPlayerAsViewTarget_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!bPlayerAsViewTarget")]
	[Tooltip("new actor to set as view target")]
	[EditDefaultsOnly]
	[UProperty]
	[Category("Quest")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_BlendToCamera:ViewTarget")]
	private TSoftObject<AActor> ViewTarget
	{
		get
		{
			CheckDestroyed();
			if (!ViewTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:ViewTarget");
				return default(TSoftObject<AActor>);
			}
			return TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, ViewTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:ViewTarget");
			}
			else
			{
				TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, ViewTarget_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("time taken to blend")]
	[Category("Quest")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_BlendToCamera:BlendTime")]
	private float BlendTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:BlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:BlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Quest")]
	[EditDefaultsOnly]
	[Tooltip("Cubic, Linear etc functions for blending")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_BlendToCamera:BlendFunc")]
	private EViewTargetBlendFunction BlendFunc
	{
		get
		{
			CheckDestroyed();
			if (!BlendFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:BlendFunc");
				return EViewTargetBlendFunction.VTBlend_Linear;
			}
			return EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(base.Address, BlendFunc_Offset), 0, BlendFunc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:BlendFunc");
			}
			else
			{
				EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(base.Address, BlendFunc_Offset), 0, BlendFunc_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("Quest")]
	[Tooltip("Exponent, used by certain blend functions to control the shape of the curve.")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_BlendToCamera:BlendExp")]
	private float BlendExp
	{
		get
		{
			CheckDestroyed();
			if (!BlendExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:BlendExp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendExp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:BlendExp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendExp_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Quest")]
	[Tooltip("If true, lock outgoing viewtarget to last frame's camera position for the remainder of the blend.")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_BlendToCamera:bLockOutgoing")]
	private bool bLockOutgoing
	{
		get
		{
			CheckDestroyed();
			if (!bLockOutgoing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:bLockOutgoing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockOutgoing_Offset), 0, bLockOutgoing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockOutgoing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BlendToCamera:bLockOutgoing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockOutgoing_Offset), 0, bLockOutgoing_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Notifies");
		BlendTime = 0f;
		BlendFunc = EViewTargetBlendFunction.VTBlend_Linear;
		BlendExp = 0f;
		bLockOutgoing = false;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.BlendToCamera;
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_BlendToCameraV1 questCustom_BlendToCameraV = new QuestCustom_BlendToCameraV1();
		if (ViewTarget.IsValid)
		{
			AActor value = ViewTarget.Value;
			foreach (FName tag in value.Tags)
			{
				questCustom_BlendToCameraV.ViewTargetTags.Add(tag.PlainName);
			}
			questCustom_BlendToCameraV.ViewTargetClass = value.GetClass().PathName;
		}
		questCustom_BlendToCameraV.BlendTime = BlendTime;
		questCustom_BlendToCameraV.BlendFunc = (int)BlendFunc;
		questCustom_BlendToCameraV.BlendExp = BlendExp;
		questCustom_BlendToCameraV.LockOutgoing = bLockOutgoing;
		questCustom_BlendToCameraV.PlayerAsViewTarget = bPlayerAsViewTarget;
		return questCustom_BlendToCameraV.ToByteArray();
	}

	public override uint GetCustomDataVersion()
	{
		return 1u;
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_BlendToCamera:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		string text = (bPlayerAsViewTarget ? "Player" : (ViewTarget.IsValid ? ViewTarget.SubPathString : "No actors found!"));
		return $"Blend To :{text}\nBlendTime: {BlendTime}\nBlendFunc:{BlendFunc}\nBlendExp:{BlendExp}\nbLockOutgoing:{bLockOutgoing}";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_BlendToCamera:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_BlendToCamera bED_QuestNode_BlendToCamera = GCHelper.Find<BED_QuestNode_BlendToCamera>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_BlendToCamera.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_BlendToCamera");
		NativeReflection.GetPropertyRef(ref bPlayerAsViewTarget_PropertyAddress, intPtr, "bPlayerAsViewTarget");
		bPlayerAsViewTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPlayerAsViewTarget");
		bPlayerAsViewTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPlayerAsViewTarget", Classes.FBoolProperty);
		ViewTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "ViewTarget");
		ViewTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ViewTarget", Classes.FSoftObjectProperty);
		BlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendTime");
		BlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BlendFunc_PropertyAddress, intPtr, "BlendFunc");
		BlendFunc_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendFunc");
		BlendFunc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendFunc", Classes.FEnumProperty);
		BlendExp_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendExp");
		BlendExp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendExp", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bLockOutgoing_PropertyAddress, intPtr, "bLockOutgoing");
		bLockOutgoing_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockOutgoing");
		bLockOutgoing_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockOutgoing", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_BlendToCamera:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_BlendToCamera()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_BlendToCamera)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_BlendToCamera));
	}
}
