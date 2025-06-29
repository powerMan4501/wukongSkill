using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BasicActionBase")]
internal class BasicActionBase : UObject
{
	protected BUC_AIRequestManageData AIRequestManageData;

	protected BaseActionMsg BAMsg;

	private static bool OwnCharacter_IsValid;

	private static int OwnCharacter_Offset;

	private static bool CurAIRequest_IsValid;

	private static int CurAIRequest_Offset;

	private static bool AIBasicActionType_IsValid;

	private static int AIBasicActionType_Offset;

	private static FFieldAddress AIBasicActionType_PropertyAddress;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BasicActionBase:OwnCharacter")]
	protected ACharacter OwnCharacter
	{
		get
		{
			CheckDestroyed();
			if (!OwnCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BasicActionBase:OwnCharacter");
				return null;
			}
			return UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(base.Address, OwnCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BasicActionBase:OwnCharacter");
			}
			else
			{
				UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(base.Address, OwnCharacter_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BasicActionBase:CurAIRequest")]
	protected AIRequestBase CurAIRequest
	{
		get
		{
			CheckDestroyed();
			if (!CurAIRequest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BasicActionBase:CurAIRequest");
				return null;
			}
			return UObjectMarshaler<AIRequestBase>.FromNative(IntPtr.Add(base.Address, CurAIRequest_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurAIRequest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BasicActionBase:CurAIRequest");
			}
			else
			{
				UObjectMarshaler<AIRequestBase>.ToNative(IntPtr.Add(base.Address, CurAIRequest_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BasicActionBase:AIBasicActionType")]
	protected EAIBasicActionType AIBasicActionType
	{
		get
		{
			CheckDestroyed();
			if (!AIBasicActionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BasicActionBase:AIBasicActionType");
				return EAIBasicActionType.DirectionMove;
			}
			return EnumMarshaler<EAIBasicActionType>.FromNative(IntPtr.Add(base.Address, AIBasicActionType_Offset), 0, AIBasicActionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AIBasicActionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BasicActionBase:AIBasicActionType");
			}
			else
			{
				EnumMarshaler<EAIBasicActionType>.ToNative(IntPtr.Add(base.Address, AIBasicActionType_Offset), 0, AIBasicActionType_PropertyAddress.Address, value);
			}
		}
	}

	public virtual void StartExecute(ACharacter Character, AIRequestBase AIRequest)
	{
		OwnCharacter = Character;
		CurAIRequest = AIRequest;
		AIRequestManageData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIRequestManageData>(OwnCharacter);
		AIRequestManageData.SetLastActionState(EAIBasicActionState.Executing);
	}

	public virtual void ExecuteTick(float DeltaTime)
	{
	}

	public virtual void ExecuteAbort()
	{
	}

	protected bool StartExecuteBySkill(BaseActionMsg BAMsg)
	{
		if (BGUFuncLibAICS.BGURequestAIUseSkillWithSkillID_CSharp(OwnCharacter, BAMsg.SkillID, ECastSkillSourceType.BT) == 0)
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.SkillNotFound);
			return false;
		}
		return true;
	}

	protected bool ExecuteTickBySkill()
	{
		if (!BGUFunctionLibraryCS.BGUHasUnitState(OwnCharacter, EBGUUnitState.Attacking))
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.Finish);
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BasicActionBase");
		OwnCharacter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OwnCharacter");
		OwnCharacter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OwnCharacter", Classes.FObjectProperty);
		CurAIRequest_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurAIRequest");
		CurAIRequest_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurAIRequest", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AIBasicActionType_PropertyAddress, unrealStruct, "AIBasicActionType");
		AIBasicActionType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AIBasicActionType");
		AIBasicActionType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AIBasicActionType", Classes.FEnumProperty);
	}

	static BasicActionBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BasicActionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BasicActionBase));
	}
}
