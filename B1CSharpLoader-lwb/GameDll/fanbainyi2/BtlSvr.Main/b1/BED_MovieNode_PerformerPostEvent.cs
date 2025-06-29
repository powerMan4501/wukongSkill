using System;
using System.Text;
using b1.Plugins.AkAudio;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("演员: 播放音频")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent")]
internal class BED_MovieNode_PerformerPostEvent : b1.BED_MovieNode_PerformerAction
{
	private static bool AkEvent_IsValid;

	private static int AkEvent_Offset;

	private static bool AttachPointName_IsValid;

	private static int AttachPointName_Offset;

	private static bool Follow_IsValid;

	private static int Follow_Offset;

	private static FFieldAddress Follow_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AkEvent")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:AkEvent")]
	public UAkAudioEvent AkEvent
	{
		get
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:AkEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:AkEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEvent_Offset), value);
			}
		}
	}

	[Category("AkEvent")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:AttachPointName")]
	public FName AttachPointName
	{
		get
		{
			CheckDestroyed();
			if (!AttachPointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:AttachPointName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttachPointName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachPointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:AttachPointName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttachPointName_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AkEvent")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:Follow")]
	public bool Follow
	{
		get
		{
			CheckDestroyed();
			if (!Follow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:Follow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Follow_Offset), 0, Follow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Follow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:Follow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Follow_Offset), 0, Follow_PropertyAddress.Address, value);
			}
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PerformerPostEvent;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("演员： " + base.Performer.TagName.PlainName);
		stringBuilder.Append("播放音频" + AkEvent.GetName());
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PerformerPostEvent
		{
			PerformerGuid = base.Performer.TagName.PlainName,
			AkEventPath = AkEvent.GetPathName(),
			AttachPointName = AttachPointName.ToString(),
			IsFollow = Follow
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PerformerPostEvent bED_MovieNode_PerformerPostEvent = GCHelper.Find<b1.BED_MovieNode_PerformerPostEvent>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PerformerPostEvent.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent");
		AkEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEvent");
		AkEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEvent", Classes.FObjectProperty);
		AttachPointName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachPointName");
		AttachPointName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachPointName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref Follow_PropertyAddress, intPtr, "Follow");
		Follow_Offset = NativeReflection.GetPropertyOffset(intPtr, "Follow");
		Follow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Follow", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PerformerPostEvent:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PerformerPostEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PerformerPostEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PerformerPostEvent));
	}
}
