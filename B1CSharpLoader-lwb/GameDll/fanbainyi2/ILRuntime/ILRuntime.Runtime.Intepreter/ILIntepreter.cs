using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Mono.Cecil;
using ILRuntime.Mono.Cecil.Cil;
using ILRuntime.Other;
using ILRuntime.Runtime.Debugger;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter.OpCodes;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Intepreter;

public class ILIntepreter
{
	private ILRuntime.Runtime.Enviorment.AppDomain domain;

	private RuntimeStack stack;

	private object _lockObj;

	private bool allowUnboundCLRMethod;

	private unsafe StackObject* ValueTypeBasePointer;

	private bool mainthreadLock;

	internal RuntimeStack Stack => stack;

	public bool ShouldBreak { get; set; }

	public StepTypes CurrentStepType { get; set; }

	public unsafe StackObject* LastStepFrameBase { get; set; }

	public int LastStepInstructionIndex { get; set; }

	public ILRuntime.Runtime.Enviorment.AppDomain AppDomain => domain;

	public ILIntepreter(ILRuntime.Runtime.Enviorment.AppDomain domain)
	{
		this.domain = domain;
		stack = new RuntimeStack(this);
		allowUnboundCLRMethod = domain.AllowUnboundCLRMethod;
	}

	public void Break()
	{
		ClearDebugState();
		lock (_lockObj)
		{
			Monitor.Wait(_lockObj);
		}
	}

	public void Resume()
	{
		mainthreadLock = false;
		lock (_lockObj)
		{
			Monitor.Pulse(_lockObj);
		}
	}

	public unsafe void ClearDebugState()
	{
		ShouldBreak = false;
		CurrentStepType = StepTypes.None;
		LastStepFrameBase = null;
		LastStepInstructionIndex = 0;
	}

	public unsafe object Run(ILMethod method, object instance, object[] p)
	{
		UncheckedList<object> managedStack = stack.ManagedStack;
		int count = managedStack.Count;
		StackObject* esp = stack.StackBase;
		stack.ResetValueTypePointer();
		if (method.HasThis)
		{
			if (instance is CrossBindingAdaptorType)
			{
				instance = ((CrossBindingAdaptorType)instance).ILInstance;
			}
			if (instance == null)
			{
				throw new NullReferenceException("instance should not be null!");
			}
			esp = PushObject(esp, managedStack, instance);
		}
		bool shouldUseRegisterVM = method.ShouldUseRegisterVM;
		esp = PushParameters(method, esp, p, shouldUseRegisterVM);
		esp = ((!shouldUseRegisterVM) ? Execute(method, esp, out var unhandledException) : ExecuteR(method, esp, out unhandledException));
		object result = ((method.ReturnType != domain.VoidType) ? method.ReturnType.TypeForCLR.CheckCLRTypes(StackObject.ToObject(esp - 1, domain, managedStack)) : null);
		managedStack.RemoveRange(count, managedStack.Count - count);
		return result;
	}

	internal unsafe StackObject* Execute(ILMethod method, StackObject* esp, out bool unhandledException)
	{
		allowUnboundCLRMethod = domain.AllowUnboundCLRMethod;
		ILRuntime.Runtime.Intepreter.OpCodes.OpCode[] body = method.Body;
		stack.InitializeFrame(method, esp, out var res);
		StackObject* localVarPointer = res.LocalVarPointer;
		StackObject* ptr = res.LocalVarPointer + 1;
		StackObject* ptr2 = res.LocalVarPointer + 1 + 1;
		StackObject* ptr3 = Add(res.LocalVarPointer, 3);
		Exception ex = null;
		int num = 0;
		ILRuntime.CLR.Method.ExceptionHandler[] exceptionHandler = method.ExceptionHandler;
		esp = res.BasePointer;
		StackObject* ptr4 = Minus(res.LocalVarPointer, method.ParameterCount);
		UncheckedList<object> managedStack = stack.ManagedStack;
		int num2 = method.ParameterCount;
		if (method.HasThis)
		{
			ptr4--;
			num2++;
		}
		unhandledException = false;
		object target = null;
		for (int i = 0; i < num2; i++)
		{
			StackObject* ptr5 = Add(ptr4, i);
			switch (ptr5->ObjectType)
			{
			case ObjectTypes.Null:
				ptr5->ObjectType = ObjectTypes.Object;
				ptr5->Value = managedStack.Count;
				managedStack.Add(null);
				break;
			case ObjectTypes.Object:
			case ObjectTypes.FieldReference:
			case ObjectTypes.ArrayReference:
				if (i > 0 || !method.HasThis)
				{
					managedStack[ptr5->Value] = CheckAndCloneValueType(managedStack[ptr5->Value], AppDomain);
				}
				res.ManagedStackBase--;
				break;
			}
		}
		stack.PushFrame(ref res);
		int count = managedStack.Count;
		for (int j = 0; j < method.LocalVariableCount; j++)
		{
			managedStack.Add(null);
		}
		for (int k = 0; k < method.LocalVariableCount; k++)
		{
			VariableDefinition variableDefinition = method.Variables[k];
			bool flag = false;
			TypeReference variableType = variableDefinition.VariableType;
			IType type = ((!variableType.IsGenericParameter) ? AppDomain.GetType(variableDefinition.VariableType, method.DeclearingType, method) : method.FindGenericArgument(variableType.Name));
			flag = type.IsEnum;
			if (!type.IsByRef && type.IsValueType && !type.IsPrimitive && !flag)
			{
				if (type is ILType)
				{
					StackObject* ptr6 = Add(localVarPointer, k);
					stack.AllocValueType(ptr6, type);
					continue;
				}
				CLRType obj = (CLRType)type;
				StackObject* ptr7 = Add(localVarPointer, k);
				if (obj.ValueTypeBinder != null)
				{
					stack.AllocValueType(ptr7, type);
					continue;
				}
				target = ((CLRType)type).CreateDefaultInstance();
				ptr7->ObjectType = ObjectTypes.Object;
				ptr7->Value = count + k;
				managedStack[count + k] = target;
			}
			else if (type.IsPrimitive || flag)
			{
				StackObject.Initialized(Add(localVarPointer, k), type);
			}
			else
			{
				StackObject* intPtr = Add(localVarPointer, k);
				intPtr->ObjectType = ObjectTypes.Object;
				intPtr->Value = count + k;
			}
		}
		StackObject* valueTypeBasePointer = (ValueTypeBasePointer = stack.ValueTypeStackPointer);
		fixed (ILRuntime.Runtime.Intepreter.OpCodes.OpCode* ptr8 = body)
		{
			ILRuntime.Runtime.Intepreter.OpCodes.OpCode* ptr9 = ptr8;
			OpCodeEnum code = ptr9->Code;
			bool flag2 = false;
			while (!flag2)
			{
				try
				{
					code = ptr9->Code;
					ILTypeInstance instance;
					switch (code)
					{
					case OpCodeEnum.Ldarg_0:
						CopyToStack(esp, ptr4, managedStack);
						esp++;
						break;
					case OpCodeEnum.Ldarg_1:
						CopyToStack(esp, ptr4 + 1, managedStack);
						esp++;
						break;
					case OpCodeEnum.Ldarg_2:
						CopyToStack(esp, ptr4 + 1 + 1, managedStack);
						esp++;
						break;
					case OpCodeEnum.Ldarg_3:
						CopyToStack(esp, ptr4 + 1 + 1 + 1, managedStack);
						esp++;
						break;
					case OpCodeEnum.Ldarg_S:
					case OpCodeEnum.Ldarg:
						CopyToStack(esp, Add(ptr4, ptr9->TokenInteger), managedStack);
						esp++;
						break;
					case OpCodeEnum.Ldarga_S:
					case OpCodeEnum.Ldarga:
					{
						StackObject* ptr5 = Add(ptr4, ptr9->TokenInteger);
						esp->ObjectType = ObjectTypes.StackObjectReference;
						*(long*)(&esp->Value) = (long)ptr5;
						esp++;
						break;
					}
					case OpCodeEnum.Starg_S:
					case OpCodeEnum.Starg:
					{
						StackObject* ptr5 = Add(ptr4, ptr9->TokenInteger);
						StackObject* ptr11 = esp - 1;
						int value = ptr5->Value;
						bool flag9 = ptr5->ObjectType >= ObjectTypes.Object;
						if (ptr11->ObjectType >= ObjectTypes.Object)
						{
							if (ptr5->ObjectType == ObjectTypes.ValueTypeObjectReference)
							{
								StackObject* dst = ResolveReference(ptr5);
								CopyValueTypeToStack(dst, managedStack[ptr11->Value], managedStack);
							}
							else
							{
								ptr5->ObjectType = ptr11->ObjectType;
								managedStack[ptr5->Value] = managedStack[ptr11->Value];
								ptr5->ValueLow = ptr11->ValueLow;
							}
						}
						else if (ptr5->ObjectType == ObjectTypes.ValueTypeObjectReference)
						{
							if (ptr11->ObjectType != ObjectTypes.ValueTypeObjectReference)
							{
								throw new NotSupportedException();
							}
							CopyStackValueType(ptr11, ptr5, managedStack);
							FreeStackValueType(ptr11);
						}
						else if (ptr11->ObjectType == ObjectTypes.ValueTypeObjectReference)
						{
							if (!flag9)
							{
								throw new NotSupportedException();
							}
							managedStack[ptr5->Value] = StackObject.ToObject(ptr11, domain, managedStack);
						}
						else
						{
							*ptr5 = *ptr11;
							if (flag9)
							{
								ptr5->Value = value;
								if (ptr11->ObjectType == ObjectTypes.Null)
								{
									managedStack[ptr5->Value] = null;
								}
							}
						}
						Free(ptr11);
						esp--;
						break;
					}
					case OpCodeEnum.Stloc_0:
					{
						esp--;
						int value = count;
						StLocSub(esp, localVarPointer, value, managedStack);
						break;
					}
					case OpCodeEnum.Ldloc_0:
						CopyToStack(esp, localVarPointer, managedStack);
						esp++;
						break;
					case OpCodeEnum.Stloc_1:
					{
						esp--;
						int value = count + 1;
						StLocSub(esp, ptr, value, managedStack);
						break;
					}
					case OpCodeEnum.Ldloc_1:
						CopyToStack(esp, ptr, managedStack);
						esp++;
						break;
					case OpCodeEnum.Stloc_2:
					{
						esp--;
						int value = count + 2;
						StLocSub(esp, ptr2, value, managedStack);
						break;
					}
					case OpCodeEnum.Ldloc_2:
						CopyToStack(esp, ptr2, managedStack);
						esp++;
						break;
					case OpCodeEnum.Stloc_3:
					{
						esp--;
						int value = count + 3;
						StLocSub(esp, ptr3, value, managedStack);
						break;
					}
					case OpCodeEnum.Ldloc_3:
						CopyToStack(esp, ptr3, managedStack);
						esp++;
						break;
					case OpCodeEnum.Stloc_S:
					case OpCodeEnum.Stloc:
					{
						esp--;
						StackObject* v = Add(res.LocalVarPointer, ptr9->TokenInteger);
						int value = count + ptr9->TokenInteger;
						StLocSub(esp, v, value, managedStack);
						break;
					}
					case OpCodeEnum.Ldloc_S:
					case OpCodeEnum.Ldloc:
					{
						StackObject* src = Add(res.LocalVarPointer, ptr9->TokenInteger);
						CopyToStack(esp, src, managedStack);
						esp++;
						break;
					}
					case OpCodeEnum.Ldloca_S:
					case OpCodeEnum.Ldloca:
					{
						StackObject* ptr17 = Add(res.LocalVarPointer, ptr9->TokenInteger);
						esp->ObjectType = ObjectTypes.StackObjectReference;
						*(long*)(&esp->Value) = (long)ptr17;
						esp++;
						break;
					}
					case OpCodeEnum.Ldobj:
					{
						StackObject* objectAndResolveReference = esp - 1;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.ArrayReference:
						{
							IType type9 = AppDomain.GetType(ptr9->TokenInteger);
							target = managedStack[objectAndResolveReference->Value];
							int value = objectAndResolveReference->ValueLow;
							Free(objectAndResolveReference);
							LoadFromArrayReference(target, value, objectAndResolveReference, type9, managedStack);
							break;
						}
						case ObjectTypes.StackObjectReference:
							CopyToStack(objectAndResolveReference, GetObjectAndResolveReference(objectAndResolveReference), managedStack);
							break;
						case ObjectTypes.FieldReference:
						{
							target = managedStack[objectAndResolveReference->Value];
							int valueLow4 = objectAndResolveReference->ValueLow;
							Free(objectAndResolveReference);
							if (target is ILTypeInstance)
							{
								((ILTypeInstance)target).PushToStack(valueLow4, objectAndResolveReference, this, managedStack);
								break;
							}
							IType type8 = AppDomain.GetType(ptr9->TokenInteger);
							if (!((CLRType)type8).CopyFieldToStack(valueLow4, target, this, ref objectAndResolveReference, managedStack))
							{
								target = ((CLRType)type8).GetFieldValue(valueLow4, target);
								PushObject(objectAndResolveReference, managedStack, target);
							}
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type7 = AppDomain.GetType(objectAndResolveReference->Value);
							int valueLow3 = objectAndResolveReference->ValueLow;
							Free(objectAndResolveReference);
							if (type7 is ILType)
							{
								((ILType)type7).StaticInstance.PushToStack(valueLow3, objectAndResolveReference, this, managedStack);
							}
							else if (!((CLRType)type7).CopyFieldToStack(valueLow3, null, this, ref objectAndResolveReference, managedStack))
							{
								target = ((CLRType)type7).GetFieldValue(valueLow3, null);
								PushObject(objectAndResolveReference, managedStack, target);
							}
							break;
						}
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeEnum.Stobj:
					{
						StackObject* objectAndResolveReference = esp - 1 - 1;
						StackObject* ptr11 = esp - 1;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.ArrayReference:
						{
							IType type5 = AppDomain.GetType(ptr9->TokenInteger);
							StoreValueToArrayReference(objectAndResolveReference, ptr11, type5, managedStack);
							break;
						}
						case ObjectTypes.StackObjectReference:
							objectAndResolveReference = GetObjectAndResolveReference(objectAndResolveReference);
							if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
							{
								switch (ptr11->ObjectType)
								{
								case ObjectTypes.Object:
								{
									StackObject* dst = ResolveReference(objectAndResolveReference);
									CopyValueTypeToStack(dst, managedStack[ptr11->Value], managedStack);
									break;
								}
								case ObjectTypes.ValueTypeObjectReference:
									CopyStackValueType(ptr11, objectAndResolveReference, managedStack);
									break;
								default:
									throw new NotImplementedException();
								}
							}
							else if (ptr11->ObjectType >= ObjectTypes.Object)
							{
								managedStack[objectAndResolveReference->Value] = managedStack[ptr11->Value];
								objectAndResolveReference->ValueLow = ptr11->ValueLow;
							}
							else if (ptr11->ObjectType == ObjectTypes.Null && objectAndResolveReference->ObjectType == ObjectTypes.Object)
							{
								managedStack[objectAndResolveReference->Value] = null;
							}
							else
							{
								*objectAndResolveReference = *ptr11;
							}
							break;
						case ObjectTypes.FieldReference:
						{
							target = managedStack[objectAndResolveReference->Value];
							int valueLow2 = objectAndResolveReference->ValueLow;
							if (target is ILTypeInstance)
							{
								((ILTypeInstance)target).AssignFromStack(valueLow2, ptr11, AppDomain, managedStack);
								break;
							}
							IType type4 = AppDomain.GetType(ptr9->TokenInteger);
							if (!((CLRType)type4).AssignFieldFromStack(valueLow2, ref target, this, ptr11, managedStack))
							{
								((CLRType)type4).SetFieldValue(valueLow2, ref target, type4.TypeForCLR.CheckCLRTypes(StackObject.ToObject(ptr11, AppDomain, managedStack)));
							}
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type3 = AppDomain.GetType(objectAndResolveReference->Value);
							if (type3 is ILType)
							{
								((ILType)type3).StaticInstance.AssignFromStack(objectAndResolveReference->ValueLow, ptr11, AppDomain, managedStack);
								break;
							}
							target = null;
							if (!((CLRType)type3).AssignFieldFromStack(objectAndResolveReference->ValueLow, ref target, this, ptr11, managedStack))
							{
								((CLRType)type3).SetStaticFieldValue(objectAndResolveReference->ValueLow, type3.TypeForCLR.CheckCLRTypes(StackObject.ToObject(ptr11, AppDomain, managedStack)));
							}
							break;
						}
						default:
							throw new NotImplementedException();
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						esp = esp - 1 - 1;
						break;
					}
					case OpCodeEnum.Ldc_I4_M1:
						esp->Value = -1;
						esp->ObjectType = ObjectTypes.Integer;
						esp++;
						break;
					case OpCodeEnum.Ldc_I4_0:
						esp->Value = 0;
						esp->ObjectType = ObjectTypes.Integer;
						esp++;
						break;
					case OpCodeEnum.Ldc_I4_1:
						esp->Value = 1;
						esp->ObjectType = ObjectTypes.Integer;
						esp++;
						break;
					case OpCodeEnum.Ldc_I4_2:
						esp->Value = 2;
						esp->ObjectType = ObjectTypes.Integer;
						esp++;
						break;
					case OpCodeEnum.Ldc_I4_3:
						esp->Value = 3;
						esp->ObjectType = ObjectTypes.Integer;
						esp++;
						break;
					case OpCodeEnum.Ldc_I4_4:
						esp->Value = 4;
						esp->ObjectType = ObjectTypes.Integer;
						esp++;
						break;
					case OpCodeEnum.Ldc_I4_5:
						esp->Value = 5;
						esp->ObjectType = ObjectTypes.Integer;
						esp++;
						break;
					case OpCodeEnum.Ldc_I4_6:
						esp->Value = 6;
						esp->ObjectType = ObjectTypes.Integer;
						esp++;
						break;
					case OpCodeEnum.Ldc_I4_7:
						esp->Value = 7;
						esp->ObjectType = ObjectTypes.Integer;
						esp++;
						break;
					case OpCodeEnum.Ldc_I4_8:
						esp->Value = 8;
						esp->ObjectType = ObjectTypes.Integer;
						esp++;
						break;
					case OpCodeEnum.Ldc_I4_S:
					case OpCodeEnum.Ldc_I4:
						esp->Value = ptr9->TokenInteger;
						esp->ObjectType = ObjectTypes.Integer;
						esp++;
						break;
					case OpCodeEnum.Ldc_I8:
						*(long*)(&esp->Value) = ptr9->TokenLong;
						esp->ObjectType = ObjectTypes.Long;
						esp++;
						break;
					case OpCodeEnum.Ldc_R4:
						*(float*)(&esp->Value) = *(float*)(&ptr9->TokenInteger);
						esp->ObjectType = ObjectTypes.Float;
						esp++;
						break;
					case OpCodeEnum.Ldc_R8:
						*(double*)(&esp->Value) = *(double*)(&ptr9->TokenLong);
						esp->ObjectType = ObjectTypes.Double;
						esp++;
						break;
					case OpCodeEnum.Ldnull:
						esp = PushNull(esp);
						break;
					case OpCodeEnum.Ldind_I1:
					case OpCodeEnum.Ldind_U1:
					case OpCodeEnum.Ldind_I2:
					case OpCodeEnum.Ldind_U2:
					case OpCodeEnum.Ldind_I4:
					case OpCodeEnum.Ldind_U4:
					case OpCodeEnum.Ldind_I:
					{
						StackObject* ptr11 = GetObjectAndResolveReference(esp - 1);
						StackObject* dst = esp - 1;
						switch (ptr11->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							target = managedStack[ptr11->Value];
							int value = ptr11->ValueLow;
							Free(dst);
							LoadFromFieldReference(target, value, dst, managedStack);
							break;
						}
						case ObjectTypes.ArrayReference:
						{
							target = managedStack[ptr11->Value];
							int value = ptr11->ValueLow;
							Free(dst);
							LoadFromArrayReference(target, value, dst, target.GetType().GetElementType(), managedStack);
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type16 = AppDomain.GetType(ptr11->Value);
							int valueLow7 = ptr11->ValueLow;
							Free(dst);
							if (type16 is ILType)
							{
								((ILType)type16).StaticInstance.PushToStack(valueLow7, dst, this, managedStack);
							}
							else if (!((CLRType)type16).CopyFieldToStack(valueLow7, null, this, ref dst, managedStack))
							{
								target = ((CLRType)type16).GetFieldValue(valueLow7, null);
								PushObject(dst, managedStack, target);
							}
							break;
						}
						default:
							dst->ObjectType = ObjectTypes.Integer;
							dst->Value = ptr11->Value;
							dst->ValueLow = 0;
							break;
						}
						break;
					}
					case OpCodeEnum.Ldind_I8:
					{
						StackObject* ptr11 = GetObjectAndResolveReference(esp - 1);
						StackObject* dst = esp - 1;
						switch (ptr11->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							target = managedStack[ptr11->Value];
							int value = ptr11->ValueLow;
							Free(dst);
							LoadFromFieldReference(target, value, dst, managedStack);
							break;
						}
						case ObjectTypes.ArrayReference:
						{
							target = managedStack[ptr11->Value];
							int value = ptr11->ValueLow;
							Free(dst);
							LoadFromArrayReference(target, value, dst, target.GetType().GetElementType(), managedStack);
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type14 = AppDomain.GetType(ptr11->Value);
							int value = ptr11->ValueLow;
							Free(dst);
							if (type14 is ILType)
							{
								((ILType)type14).StaticInstance.PushToStack(value, dst, this, managedStack);
							}
							else if (!((CLRType)type14).CopyFieldToStack(value, null, this, ref dst, managedStack))
							{
								target = ((CLRType)type14).GetFieldValue(value, null);
								PushObject(dst, managedStack, target);
							}
							break;
						}
						default:
							*dst = *ptr11;
							dst->ObjectType = ObjectTypes.Long;
							break;
						}
						break;
					}
					case OpCodeEnum.Ldind_R4:
					{
						StackObject* ptr11 = GetObjectAndResolveReference(esp - 1);
						StackObject* dst = esp - 1;
						switch (ptr11->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							target = managedStack[ptr11->Value];
							int value = ptr11->ValueLow;
							Free(dst);
							LoadFromFieldReference(target, value, dst, managedStack);
							break;
						}
						case ObjectTypes.ArrayReference:
						{
							target = managedStack[ptr11->Value];
							int value = ptr11->ValueLow;
							Free(dst);
							LoadFromArrayReference(target, value, dst, target.GetType().GetElementType(), managedStack);
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type13 = AppDomain.GetType(ptr11->Value);
							int value = ptr11->ValueLow;
							Free(dst);
							if (type13 is ILType)
							{
								((ILType)type13).StaticInstance.PushToStack(value, dst, this, managedStack);
							}
							else if (!((CLRType)type13).CopyFieldToStack(value, null, this, ref dst, managedStack))
							{
								target = ((CLRType)type13).GetFieldValue(value, null);
								PushObject(dst, managedStack, target);
							}
							break;
						}
						default:
							dst->ObjectType = ObjectTypes.Float;
							dst->Value = ptr11->Value;
							dst->ValueLow = 0;
							break;
						}
						break;
					}
					case OpCodeEnum.Ldind_R8:
					{
						StackObject* ptr11 = GetObjectAndResolveReference(esp - 1);
						StackObject* dst = esp - 1;
						switch (ptr11->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							target = managedStack[ptr11->Value];
							int value = ptr11->ValueLow;
							Free(dst);
							LoadFromFieldReference(target, value, dst, managedStack);
							break;
						}
						case ObjectTypes.ArrayReference:
						{
							target = managedStack[ptr11->Value];
							int value = ptr11->ValueLow;
							Free(dst);
							LoadFromArrayReference(target, value, dst, target.GetType().GetElementType(), managedStack);
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type15 = AppDomain.GetType(ptr11->Value);
							int value = ptr11->ValueLow;
							Free(dst);
							if (type15 is ILType)
							{
								((ILType)type15).StaticInstance.PushToStack(value, dst, this, managedStack);
							}
							else if (!((CLRType)type15).CopyFieldToStack(value, null, this, ref dst, managedStack))
							{
								target = ((CLRType)type15).GetFieldValue(value, null);
								PushObject(dst, managedStack, target);
							}
							break;
						}
						default:
							*dst = *ptr11;
							dst->ObjectType = ObjectTypes.Double;
							break;
						}
						break;
					}
					case OpCodeEnum.Ldind_Ref:
					{
						StackObject* ptr11 = GetObjectAndResolveReference(esp - 1);
						StackObject* dst = esp - 1;
						switch (ptr11->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							target = managedStack[ptr11->Value];
							int value = ptr11->ValueLow;
							Free(dst);
							LoadFromFieldReference(target, value, dst, managedStack);
							break;
						}
						case ObjectTypes.ArrayReference:
						{
							target = managedStack[ptr11->Value];
							int value = ptr11->ValueLow;
							Free(dst);
							LoadFromArrayReference(target, value, dst, target.GetType().GetElementType(), managedStack);
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type17 = AppDomain.GetType(ptr11->Value);
							int value = ptr11->ValueLow;
							Free(dst);
							if (type17 is ILType)
							{
								((ILType)type17).StaticInstance.PushToStack(value, dst, this, managedStack);
							}
							else if (!((CLRType)type17).CopyFieldToStack(value, null, this, ref dst, managedStack))
							{
								target = ((CLRType)type17).GetFieldValue(value, null);
								PushObject(dst, managedStack, target);
							}
							break;
						}
						default:
							dst->ObjectType = ObjectTypes.Object;
							dst->Value = managedStack.Count;
							managedStack.Add(managedStack[ptr11->Value]);
							break;
						}
						break;
					}
					case OpCodeEnum.Stind_I1:
					case OpCodeEnum.Stind_I2:
					case OpCodeEnum.Stind_I4:
					case OpCodeEnum.Stind_R4:
					case OpCodeEnum.Stind_I:
					{
						StackObject* dst = GetObjectAndResolveReference(esp - 1 - 1);
						StackObject* ptr11 = esp - 1;
						switch (dst->ObjectType)
						{
						case ObjectTypes.FieldReference:
							target = managedStack[dst->Value];
							StoreValueToFieldReference(ref target, dst->ValueLow, ptr11, managedStack);
							managedStack[dst->Value] = target;
							break;
						case ObjectTypes.ArrayReference:
							StoreValueToArrayReference(dst, ptr11, managedStack[dst->Value].GetType().GetElementType(), managedStack);
							break;
						case ObjectTypes.StaticFieldReference:
						{
							IType type2 = AppDomain.GetType(dst->Value);
							int value = dst->ValueLow;
							if (type2 != null)
							{
								if (type2 is ILType)
								{
									(type2 as ILType).StaticInstance.AssignFromStack(value, ptr11, AppDomain, managedStack);
									break;
								}
								CLRType cLRType5 = type2 as CLRType;
								FieldInfo field6 = cLRType5.GetField(value);
								target = null;
								if (!cLRType5.AssignFieldFromStack(value, ref target, this, ptr11, managedStack))
								{
									cLRType5.SetStaticFieldValue(value, field6.FieldType.CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr11, domain, managedStack), domain)));
								}
								break;
							}
							throw new TypeLoadException();
						}
						default:
							dst->Value = ptr11->Value;
							break;
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						esp = esp - 1 - 1;
						break;
					}
					case OpCodeEnum.Stind_I8:
					{
						StackObject* dst = GetObjectAndResolveReference(esp - 1 - 1);
						StackObject* ptr11 = esp - 1;
						switch (dst->ObjectType)
						{
						case ObjectTypes.FieldReference:
							target = managedStack[dst->Value];
							StoreValueToFieldReference(ref target, dst->ValueLow, ptr11, managedStack);
							managedStack[dst->Value] = target;
							break;
						case ObjectTypes.ArrayReference:
							StoreValueToArrayReference(dst, ptr11, typeof(long), managedStack);
							break;
						case ObjectTypes.StaticFieldReference:
						{
							IType type2 = AppDomain.GetType(dst->Value);
							int value = dst->ValueLow;
							if (type2 != null)
							{
								if (type2 is ILType)
								{
									(type2 as ILType).StaticInstance.AssignFromStack(value, ptr11, AppDomain, managedStack);
									break;
								}
								CLRType cLRType6 = type2 as CLRType;
								target = null;
								if (!cLRType6.AssignFieldFromStack(value, ref target, this, ptr11, managedStack))
								{
									cLRType6.SetStaticFieldValue(value, typeof(long).CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr11, domain, managedStack), domain)));
								}
								break;
							}
							throw new TypeLoadException();
						}
						default:
							dst->Value = ptr11->Value;
							dst->ValueLow = ptr11->ValueLow;
							break;
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						esp = esp - 1 - 1;
						break;
					}
					case OpCodeEnum.Stind_R8:
					{
						StackObject* dst = GetObjectAndResolveReference(esp - 1 - 1);
						StackObject* ptr11 = esp - 1;
						switch (dst->ObjectType)
						{
						case ObjectTypes.FieldReference:
							target = managedStack[dst->Value];
							StoreValueToFieldReference(ref target, dst->ValueLow, ptr11, managedStack);
							managedStack[dst->Value] = target;
							break;
						case ObjectTypes.ArrayReference:
							StoreValueToArrayReference(dst, ptr11, typeof(double), managedStack);
							break;
						case ObjectTypes.StaticFieldReference:
						{
							IType type2 = AppDomain.GetType(dst->Value);
							int value = dst->ValueLow;
							if (type2 != null)
							{
								if (type2 is ILType)
								{
									(type2 as ILType).StaticInstance.AssignFromStack(value, ptr11, AppDomain, managedStack);
									break;
								}
								CLRType cLRType4 = type2 as CLRType;
								target = null;
								if (!cLRType4.AssignFieldFromStack(value, ref target, this, ptr11, managedStack))
								{
									cLRType4.SetStaticFieldValue(value, typeof(double).CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr11, domain, managedStack), domain)));
								}
								break;
							}
							throw new TypeLoadException();
						}
						default:
							dst->Value = ptr11->Value;
							dst->ValueLow = ptr11->ValueLow;
							break;
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						esp = esp - 1 - 1;
						break;
					}
					case OpCodeEnum.Stind_Ref:
					{
						StackObject* dst = GetObjectAndResolveReference(esp - 1 - 1);
						StackObject* ptr11 = esp - 1;
						switch (dst->ObjectType)
						{
						case ObjectTypes.FieldReference:
							target = managedStack[dst->Value];
							StoreValueToFieldReference(ref target, dst->ValueLow, ptr11, managedStack);
							managedStack[dst->Value] = target;
							break;
						case ObjectTypes.ArrayReference:
							StoreValueToArrayReference(dst, ptr11, typeof(object), managedStack);
							break;
						case ObjectTypes.StaticFieldReference:
						{
							IType type2 = AppDomain.GetType(dst->Value);
							int value = dst->ValueLow;
							if (type2 != null)
							{
								if (type2 is ILType)
								{
									(type2 as ILType).StaticInstance.AssignFromStack(value, ptr11, AppDomain, managedStack);
									break;
								}
								CLRType cLRType2 = type2 as CLRType;
								FieldInfo field3 = cLRType2.GetField(value);
								target = null;
								if (!cLRType2.AssignFieldFromStack(value, ref target, this, ptr11, managedStack))
								{
									cLRType2.SetStaticFieldValue(value, field3.FieldType.CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr11, domain, managedStack), domain)));
								}
								break;
							}
							throw new TypeLoadException();
						}
						default:
							switch (ptr11->ObjectType)
							{
							case ObjectTypes.Object:
								managedStack[dst->Value] = managedStack[ptr11->Value];
								break;
							case ObjectTypes.Null:
								managedStack[dst->Value] = null;
								break;
							default:
								throw new NotImplementedException();
							}
							break;
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						esp = esp - 1 - 1;
						break;
					}
					case OpCodeEnum.Ldstr:
						esp = PushObject(esp, managedStack, AppDomain.GetString(ptr9->TokenLong));
						break;
					case OpCodeEnum.Add:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&esp->Value) = *(long*)(&ptr5->Value) + *(long*)(&ptr18->Value);
							break;
						case ObjectTypes.Integer:
							esp->Value = ptr5->Value + ptr18->Value;
							break;
						case ObjectTypes.Float:
							*(float*)(&esp->Value) = *(float*)(&ptr5->Value) + *(float*)(&ptr18->Value);
							break;
						case ObjectTypes.Double:
							*(double*)(&esp->Value) = *(double*)(&ptr5->Value) + *(double*)(&ptr18->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Sub:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&esp->Value) = *(long*)(&ptr5->Value) - *(long*)(&ptr18->Value);
							break;
						case ObjectTypes.Integer:
							esp->Value = ptr5->Value - ptr18->Value;
							break;
						case ObjectTypes.Float:
							*(float*)(&esp->Value) = *(float*)(&ptr5->Value) - *(float*)(&ptr18->Value);
							break;
						case ObjectTypes.Double:
							*(double*)(&esp->Value) = *(double*)(&ptr5->Value) - *(double*)(&ptr18->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Mul:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&esp->Value) = *(long*)(&ptr5->Value) * *(long*)(&ptr18->Value);
							break;
						case ObjectTypes.Integer:
							esp->Value = ptr5->Value * ptr18->Value;
							break;
						case ObjectTypes.Float:
							*(float*)(&esp->Value) = *(float*)(&ptr5->Value) * *(float*)(&ptr18->Value);
							break;
						case ObjectTypes.Double:
							*(double*)(&esp->Value) = *(double*)(&ptr5->Value) * *(double*)(&ptr18->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Div:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&esp->Value) = *(long*)(&ptr5->Value) / *(long*)(&ptr18->Value);
							break;
						case ObjectTypes.Integer:
							esp->Value = ptr5->Value / ptr18->Value;
							break;
						case ObjectTypes.Float:
							*(float*)(&esp->Value) = *(float*)(&ptr5->Value) / *(float*)(&ptr18->Value);
							break;
						case ObjectTypes.Double:
							*(double*)(&esp->Value) = *(double*)(&ptr5->Value) / *(double*)(&ptr18->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Div_Un:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(ulong*)(&esp->Value) = (ulong)(*(long*)(&ptr5->Value)) / (ulong)(*(long*)(&ptr18->Value));
							break;
						case ObjectTypes.Integer:
							esp->Value = (int)((uint)ptr5->Value / (uint)ptr18->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Rem:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&esp->Value) = *(long*)(&ptr5->Value) % *(long*)(&ptr18->Value);
							break;
						case ObjectTypes.Integer:
							esp->Value = ptr5->Value % ptr18->Value;
							break;
						case ObjectTypes.Float:
							*(float*)(&esp->Value) = *(float*)(&ptr5->Value) % *(float*)(&ptr18->Value);
							break;
						case ObjectTypes.Double:
							*(double*)(&esp->Value) = *(double*)(&ptr5->Value) % *(double*)(&ptr18->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Rem_Un:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(ulong*)(&esp->Value) = (ulong)(*(long*)(&ptr5->Value)) % (ulong)(*(long*)(&ptr18->Value));
							break;
						case ObjectTypes.Integer:
							esp->Value = (int)((uint)ptr5->Value % (uint)ptr18->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Xor:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&esp->Value) = *(long*)(&ptr5->Value) ^ *(long*)(&ptr18->Value);
							break;
						case ObjectTypes.Integer:
							esp->Value = ptr5->Value ^ ptr18->Value;
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.And:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&esp->Value) = *(long*)(&ptr5->Value) & *(long*)(&ptr18->Value);
							break;
						case ObjectTypes.Integer:
							esp->Value = ptr5->Value & ptr18->Value;
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Or:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&esp->Value) = *(long*)(&ptr5->Value) | *(long*)(&ptr18->Value);
							break;
						case ObjectTypes.Integer:
							esp->Value = ptr5->Value | ptr18->Value;
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Shl:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						int value16 = ptr18->Value;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&esp->Value) = *(long*)(&ptr5->Value) << value16;
							break;
						case ObjectTypes.Integer:
							esp->Value = ptr5->Value << value16;
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Shr:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						int value19 = ptr18->Value;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&esp->Value) = *(long*)(&ptr5->Value) >> value19;
							break;
						case ObjectTypes.Integer:
							esp->Value = ptr5->Value >> value19;
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Shr_Un:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = ptr5;
						int value18 = ptr18->Value;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&esp->Value) = *(long*)(&ptr5->Value) >>> value18;
							break;
						case ObjectTypes.Integer:
							esp->Value = ptr5->Value >>> value18;
							break;
						default:
							throw new NotImplementedException();
						}
						esp++;
						break;
					}
					case OpCodeEnum.Not:
					{
						StackObject* ptr5 = esp - 1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&ptr5->Value) = ~(*(long*)(&ptr5->Value));
							break;
						case ObjectTypes.Integer:
							ptr5->Value = ~ptr5->Value;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeEnum.Neg:
					{
						StackObject* ptr5 = esp - 1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							*(long*)(&ptr5->Value) = -(*(long*)(&ptr5->Value));
							break;
						case ObjectTypes.Integer:
							ptr5->Value = -ptr5->Value;
							break;
						case ObjectTypes.Float:
							*(float*)(&ptr5->Value) = 0f - *(float*)(&ptr5->Value);
							break;
						case ObjectTypes.Double:
							*(double*)(&ptr5->Value) = 0.0 - *(double*)(&ptr5->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeEnum.Ret:
						flag2 = true;
						break;
					case OpCodeEnum.Brtrue_S:
					case OpCodeEnum.Brtrue:
					{
						esp--;
						bool flag8 = false;
						switch (esp->ObjectType)
						{
						case ObjectTypes.Integer:
							flag8 = esp->Value != 0;
							break;
						case ObjectTypes.Long:
							flag8 = *(long*)(&esp->Value) != 0;
							break;
						case ObjectTypes.Object:
							flag8 = managedStack[esp->Value] != null;
							break;
						}
						if (flag8)
						{
							ptr9 = ptr8 + ptr9->TokenInteger;
							Free(esp);
							continue;
						}
						Free(esp);
						break;
					}
					case OpCodeEnum.Brfalse_S:
					case OpCodeEnum.Brfalse:
					{
						esp--;
						bool flag6 = false;
						switch (esp->ObjectType)
						{
						case ObjectTypes.Null:
							flag6 = true;
							break;
						case ObjectTypes.Integer:
							flag6 = esp->Value == 0;
							break;
						case ObjectTypes.Long:
							flag6 = *(long*)(&esp->Value) == 0;
							break;
						case ObjectTypes.Object:
							flag6 = managedStack[esp->Value] == null;
							Free(esp);
							break;
						default:
							Free(esp);
							break;
						}
						if (!flag6)
						{
							break;
						}
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					case OpCodeEnum.Beq_S:
					case OpCodeEnum.Beq:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						bool flag26 = false;
						if (ptr5->ObjectType == ptr18->ObjectType)
						{
							flag26 = ptr5->ObjectType switch
							{
								ObjectTypes.Null => true, 
								ObjectTypes.Integer => ptr5->Value == ptr18->Value, 
								ObjectTypes.Long => *(long*)(&ptr5->Value) == *(long*)(&ptr18->Value), 
								ObjectTypes.Float => *(float*)(&ptr5->Value) == *(float*)(&ptr18->Value), 
								ObjectTypes.Double => *(double*)(&ptr5->Value) == *(double*)(&ptr18->Value), 
								ObjectTypes.Object => managedStack[ptr5->Value] == managedStack[ptr18->Value], 
								_ => throw new NotImplementedException(), 
							};
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						esp = esp - 1 - 1;
						if (!flag26)
						{
							break;
						}
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					case OpCodeEnum.Bne_Un_S:
					case OpCodeEnum.Bne_Un:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						bool flag7 = false;
						flag7 = ptr5->ObjectType != ptr18->ObjectType || ptr5->ObjectType switch
						{
							ObjectTypes.Null => false, 
							ObjectTypes.Integer => ptr5->Value != ptr18->Value, 
							ObjectTypes.Float => *(float*)(&ptr5->Value) != *(float*)(&ptr18->Value), 
							ObjectTypes.Long => *(long*)(&ptr5->Value) != *(long*)(&ptr18->Value), 
							ObjectTypes.Double => *(double*)(&ptr5->Value) != *(double*)(&ptr18->Value), 
							ObjectTypes.Object => managedStack[ptr5->Value] != managedStack[ptr18->Value], 
							_ => throw new NotImplementedException(), 
						};
						Free(esp - 1);
						Free(esp - 1 - 1);
						esp = esp - 1 - 1;
						if (!flag7)
						{
							break;
						}
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					case OpCodeEnum.Bgt_S:
					case OpCodeEnum.Bgt:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = esp - 1 - 1;
						bool flag24 = false;
						if (esp->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value > ptr18->Value) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) > *(long*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) > *(float*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) > *(double*)(&ptr18->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					case OpCodeEnum.Bgt_Un_S:
					case OpCodeEnum.Bgt_Un:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = esp - 1 - 1;
						bool flag17 = false;
						if (esp->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value > (uint)ptr18->Value) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) > (ulong)(*(long*)(&ptr18->Value))) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) > *(float*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) > *(double*)(&ptr18->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					case OpCodeEnum.Bge_S:
					case OpCodeEnum.Bge:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = esp - 1 - 1;
						bool flag23 = false;
						if (esp->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value >= ptr18->Value) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) >= *(long*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) >= *(float*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) >= *(double*)(&ptr18->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					case OpCodeEnum.Bge_Un_S:
					case OpCodeEnum.Bge_Un:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = esp - 1 - 1;
						bool flag13 = false;
						if (esp->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value >= (uint)ptr18->Value) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) >= (ulong)(*(long*)(&ptr18->Value))) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) >= *(float*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) >= *(double*)(&ptr18->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					case OpCodeEnum.Blt_S:
					case OpCodeEnum.Blt:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = esp - 1 - 1;
						bool flag14 = false;
						if (esp->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value < ptr18->Value) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) < *(long*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) < *(float*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) < *(double*)(&ptr18->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					case OpCodeEnum.Blt_Un_S:
					case OpCodeEnum.Blt_Un:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = esp - 1 - 1;
						bool flag12 = false;
						if (esp->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value < (uint)ptr18->Value) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) < (ulong)(*(long*)(&ptr18->Value))) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) < *(float*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) < *(double*)(&ptr18->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					case OpCodeEnum.Ble_S:
					case OpCodeEnum.Ble:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = esp - 1 - 1;
						bool flag10 = false;
						if (esp->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value <= ptr18->Value) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) <= *(long*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) <= *(float*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) <= *(double*)(&ptr18->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					case OpCodeEnum.Ble_Un_S:
					case OpCodeEnum.Ble_Un:
					{
						StackObject* ptr18 = esp - 1;
						StackObject* ptr5 = esp - 1 - 1;
						esp = esp - 1 - 1;
						bool flag11 = false;
						if (esp->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value <= (uint)ptr18->Value) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) <= (ulong)(*(long*)(&ptr18->Value))) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) <= *(float*)(&ptr18->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) <= *(double*)(&ptr18->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					case OpCodeEnum.Br_S:
					case OpCodeEnum.Br:
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					case OpCodeEnum.Switch:
					{
						int value = (esp - 1)->Value;
						Free(esp - 1);
						esp--;
						int[] array21 = method.JumpTables[ptr9->TokenInteger];
						if (value < 0 || value >= array21.Length)
						{
							break;
						}
						ptr9 = ptr8 + array21[value];
						goto end_IL_0334;
					}
					case OpCodeEnum.Leave:
					case OpCodeEnum.Leave_S:
					{
						if (exceptionHandler == null)
						{
							goto IL_3213;
						}
						ILRuntime.CLR.Method.ExceptionHandler exceptionHandler2 = null;
						int addr = (int)(ptr9 - ptr8);
						exceptionHandler2 = FindExceptionHandlerByBranchTarget(addr, ptr9->TokenInteger, exceptionHandler);
						if (exceptionHandler2 == null)
						{
							goto IL_3213;
						}
						num = ptr9->TokenInteger;
						ptr9 = ptr8 + exceptionHandler2.HandlerStart;
						goto end_IL_0334;
					}
					case OpCodeEnum.Endfinally:
					{
						if (num < 0)
						{
							unhandledException = true;
							num = 0;
							throw ex;
						}
						int value = (int)(ptr9 - ptr8);
						ILRuntime.CLR.Method.ExceptionHandler exceptionHandler3 = FindExceptionHandlerByBranchTarget(value, num, exceptionHandler);
						if (exceptionHandler3 != null)
						{
							ptr9 = ptr8 + exceptionHandler3.HandlerStart;
							continue;
						}
						ptr9 = ptr8 + num;
						num = 0;
						goto end_IL_0334;
					}
					case OpCodeEnum.Call:
					case OpCodeEnum.Callvirt:
					{
						IMethod method8 = domain.GetMethod(ptr9->TokenInteger);
						if (method8 == null)
						{
							int num15 = (int)ptr9->TokenLong;
							for (int num16 = 0; num16 < num15; num16++)
							{
								Free(esp - 1);
								esp--;
							}
							break;
						}
						if (method8 is ILMethod)
						{
							ILMethod iLMethod2 = (ILMethod)method8;
							bool flag20 = false;
							if (method8.IsDelegateInvoke)
							{
								target = StackObject.ToObject(Minus(esp, method8.ParameterCount + 1), domain, managedStack);
								if (target is IDelegateAdapter)
								{
									esp = ((IDelegateAdapter)target).ILInvoke(this, esp, managedStack);
									flag20 = true;
								}
							}
							else if (iLMethod2.IsEventAdd)
							{
								StackObject* objectAndResolveReference = PrepareEventHandler(esp, iLMethod2, managedStack, out instance);
								esp = CLRRedirections.DelegateCombine(this, objectAndResolveReference, managedStack, null, isNewObj: false);
								target = StackObject.ToObject(esp - 1, domain, managedStack);
								instance[iLMethod2.EventFieldIndex] = target;
								Free(esp - 1);
								esp--;
								flag20 = true;
							}
							else if (iLMethod2.IsEventRemove)
							{
								StackObject* objectAndResolveReference = PrepareEventHandler(esp, iLMethod2, managedStack, out instance);
								esp = CLRRedirections.DelegateRemove(this, objectAndResolveReference, managedStack, null, isNewObj: false);
								target = StackObject.ToObject(esp - 1, domain, managedStack);
								instance[iLMethod2.EventFieldIndex] = target;
								Free(esp - 1);
								esp--;
								flag20 = true;
							}
							if (flag20)
							{
								break;
							}
							if (code == OpCodeEnum.Callvirt)
							{
								StackObject* objectAndResolveReference = GetObjectAndResolveReference(Minus(esp, iLMethod2.ParameterCount + 1));
								if (objectAndResolveReference->ObjectType == ObjectTypes.Null)
								{
									throw new NullReferenceException();
								}
								if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
								{
									StackObject* dst = ResolveReference(objectAndResolveReference);
									iLMethod2 = (domain.GetTypeByIndex(dst->Value) as ILType).GetVirtualMethod(iLMethod2) as ILMethod;
								}
								else
								{
									target = managedStack[objectAndResolveReference->Value];
									if (target == null)
									{
										throw new NullReferenceException();
									}
									iLMethod2 = ((ILTypeInstance)target).Type.GetVirtualMethod(iLMethod2) as ILMethod;
								}
							}
							if (iLMethod2.ShouldUseRegisterVM)
							{
								PrepareRegisterCallStack(esp, managedStack, iLMethod2);
								esp = ExecuteR(iLMethod2, esp, out unhandledException);
							}
							else
							{
								esp = Execute(iLMethod2, esp, out unhandledException);
							}
							ValueTypeBasePointer = valueTypeBasePointer;
							if (unhandledException)
							{
								flag2 = true;
							}
							break;
						}
						CLRMethod cLRMethod2 = (CLRMethod)method8;
						bool flag21 = false;
						if (cLRMethod2.IsDelegateInvoke)
						{
							target = StackObject.ToObject(Minus(esp, cLRMethod2.ParameterCount + 1), domain, managedStack);
							if (target is IDelegateAdapter)
							{
								if (cLRMethod2.IsDelegateDynamicInvoke)
								{
									StackObject* ptr10 = esp - 1;
									object[] array22 = StackObject.ToObject(ptr10, domain, managedStack) as object[];
									Free(ptr10);
									if (array22 != null)
									{
										if (array22.Length != cLRMethod2.ParameterCount)
										{
											throw new ArgumentException($"{cLRMethod2.DeclearingType.FullName}.{cLRMethod2.Name} has {cLRMethod2.ParameterCount} arguments, but got {array22.Length}");
										}
										esp = ptr10;
										for (int value = 0; value < array22.Length; value++)
										{
											esp = PushObject(esp, managedStack, array22[value], cLRMethod2.Parameters[value] == domain.ObjectType);
										}
									}
								}
								esp = ((IDelegateAdapter)target).ILInvoke(this, esp, managedStack);
								flag21 = true;
							}
						}
						if (flag21)
						{
							break;
						}
						CLRRedirectionDelegate redirection2 = cLRMethod2.Redirection;
						if (redirection2 != null)
						{
							esp = redirection2(this, esp, managedStack, cLRMethod2, isNewObj: false);
							break;
						}
						object obj11 = cLRMethod2.Invoke(this, esp, managedStack);
						if (obj11 is CrossBindingAdaptorType)
						{
							obj11 = ((CrossBindingAdaptorType)obj11).ILInstance;
						}
						int parameterCount2 = cLRMethod2.ParameterCount;
						for (int num17 = 1; num17 <= parameterCount2; num17++)
						{
							Free(Minus(esp, num17));
						}
						esp = Minus(esp, parameterCount2);
						if (cLRMethod2.HasThis)
						{
							Free(esp - 1);
							esp--;
						}
						if (cLRMethod2.ReturnType != AppDomain.VoidType && !cLRMethod2.IsConstructor)
						{
							esp = PushObject(esp, managedStack, obj11, cLRMethod2.ReturnType.TypeForCLR == typeof(object));
						}
						break;
					}
					case OpCodeEnum.Stfld:
					{
						StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp - 1 - 1);
						if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
						{
							StackObject* dst = ResolveReference(objectAndResolveReference);
							IType typeByIndex3 = domain.GetTypeByIndex(dst->Value);
							if (typeByIndex3 is ILType)
							{
								CopyToValueTypeField(dst, (int)ptr9->TokenLong, esp - 1, managedStack);
							}
							else
							{
								CopyToValueTypeField(dst, ((CLRType)typeByIndex3).FieldIndexMapping[(int)ptr9->TokenLong], esp - 1, managedStack);
							}
						}
						else
						{
							target = RetriveObject(objectAndResolveReference, managedStack);
							if (target == null)
							{
								throw new NullReferenceException();
							}
							instance = null;
							if (target is ILTypeInstance)
							{
								instance = target as ILTypeInstance;
							}
							else if (target is CrossBindingAdaptorType)
							{
								instance = (target as CrossBindingAdaptorType).ILInstance;
							}
							if (instance != null)
							{
								StackObject* ptr11 = esp - 1;
								instance.AssignFromStack((int)ptr9->TokenLong, ptr11, AppDomain, managedStack);
							}
							else
							{
								Type type11 = target.GetType();
								IType type2 = AppDomain.GetType((int)(ptr9->TokenLong >> 32));
								if (type2 == null)
								{
									throw new TypeLoadException();
								}
								StackObject* ptr11 = esp - 1;
								int hash4 = (int)ptr9->TokenLong;
								FieldInfo field5 = ((CLRType)type2).GetField(hash4);
								if (!((CLRType)type2).AssignFieldFromStack(hash4, ref target, this, ptr11, managedStack))
								{
									((CLRType)type2).SetFieldValue(hash4, ref target, field5.FieldType.CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr11, domain, managedStack), domain)));
								}
								if (type11.IsValueType)
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Object:
										managedStack[objectAndResolveReference->Value] = target;
										break;
									case ObjectTypes.FieldReference:
									{
										object target2 = managedStack[objectAndResolveReference->Value];
										int valueLow6 = objectAndResolveReference->ValueLow;
										if (target2 is ILTypeInstance)
										{
											((ILTypeInstance)target2)[valueLow6] = target;
										}
										else
										{
											((CLRType)AppDomain.GetType(target2.GetType())).SetFieldValue(valueLow6, ref target2, target);
										}
										break;
									}
									case ObjectTypes.ArrayReference:
										(managedStack[objectAndResolveReference->Value] as Array).SetValue(index: objectAndResolveReference->ValueLow, value: target);
										break;
									case ObjectTypes.StaticFieldReference:
									{
										IType type12 = AppDomain.GetType(objectAndResolveReference->Value);
										int valueLow5 = objectAndResolveReference->ValueLow;
										if (type12 is ILType)
										{
											((ILType)type12).StaticInstance[valueLow5] = target;
										}
										else
										{
											((CLRType)type12).SetStaticFieldValue(valueLow5, target);
										}
										break;
									}
									case ObjectTypes.ValueTypeObjectReference:
									{
										StackObject* dst = ResolveReference(objectAndResolveReference);
										(domain.GetTypeByIndex(dst->Value) as CLRType).ValueTypeBinder.CopyValueTypeToStack(target, dst, managedStack);
										break;
									}
									default:
										throw new NotImplementedException();
									}
								}
							}
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						esp = esp - 1 - 1;
						break;
					}
					case OpCodeEnum.Ldfld:
					{
						StackObject* esp2 = esp - 1;
						StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp2);
						if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
						{
							StackObject* dst = ResolveReference(objectAndResolveReference);
							IType typeByIndex = domain.GetTypeByIndex(dst->Value);
							StackObject* ptr11 = ((!(typeByIndex is ILType)) ? Minus(dst, ((CLRType)typeByIndex).FieldIndexMapping[(int)ptr9->TokenLong] + 1) : Minus(dst, (int)ptr9->TokenLong + 1));
							if (ptr11->ObjectType == ObjectTypes.ValueTypeObjectReference && esp2->ObjectType == ObjectTypes.ValueTypeObjectReference)
							{
								stack.RelocateValueTypeAndFreeAfterDst(ptr11, esp2);
								break;
							}
							if (ptr11->ObjectType == ObjectTypes.ValueTypeObjectReference)
							{
								Free(esp2);
								CopyToStack(esp2, ptr11, managedStack);
								break;
							}
							StackObject stackObject2 = *ptr11;
							if (ptr11->ObjectType >= ObjectTypes.Object)
							{
								target = managedStack[ptr11->Value];
							}
							Free(esp2);
							if (stackObject2.ObjectType >= ObjectTypes.Object)
							{
								stackObject2.Value = managedStack.Count;
								managedStack.Add(target);
							}
							*esp2 = stackObject2;
							break;
						}
						target = RetriveObject(objectAndResolveReference, managedStack);
						Free(esp2);
						if (target != null)
						{
							instance = null;
							if (target is ILTypeInstance)
							{
								instance = target as ILTypeInstance;
							}
							else if (target is CrossBindingAdaptorType)
							{
								instance = (target as CrossBindingAdaptorType).ILInstance;
							}
							if (instance != null)
							{
								instance.PushToStack((int)ptr9->TokenLong, esp2, this, managedStack);
								break;
							}
							IType type2 = AppDomain.GetType((int)(ptr9->TokenLong >> 32));
							if (type2 != null)
							{
								int hash2 = (int)ptr9->TokenLong;
								if (!((CLRType)type2).CopyFieldToStack(hash2, target, this, ref esp2, managedStack))
								{
									FieldInfo field2 = ((CLRType)type2).GetField(hash2);
									target = ((CLRType)type2).GetFieldValue(hash2, target);
									if (target is CrossBindingAdaptorType)
									{
										target = ((CrossBindingAdaptorType)target).ILInstance;
									}
									PushObject(esp2, managedStack, target, field2.FieldType == typeof(object));
								}
								break;
							}
							throw new TypeLoadException();
						}
						throw new NullReferenceException();
					}
					case OpCodeEnum.Ldflda:
					{
						StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp - 1);
						if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
						{
							StackObject* dst = esp - 1;
							IType type10 = domain.GetType((int)(ptr9->TokenLong >> 32));
							StackObject* ptr19 = ((!(type10 is ILType)) ? Minus(ResolveReference(objectAndResolveReference), ((CLRType)type10).FieldIndexMapping[(int)ptr9->TokenLong] + 1) : Minus(ResolveReference(objectAndResolveReference), (int)ptr9->TokenLong + 1));
							StackObject stackObject = *dst;
							dst->ObjectType = ObjectTypes.StackObjectReference;
							*(long*)(&dst->Value) = (long)ptr19;
							FreeStackValueType(&stackObject);
							break;
						}
						target = RetriveObject(objectAndResolveReference, managedStack);
						Free(esp - 1);
						if (target != null)
						{
							if (target is ILTypeInstance)
							{
								instance = target as ILTypeInstance;
								instance.PushFieldAddress((int)ptr9->TokenLong, esp - 1, managedStack);
								break;
							}
							objectAndResolveReference = esp - 1;
							objectAndResolveReference->ObjectType = ObjectTypes.FieldReference;
							objectAndResolveReference->Value = managedStack.Count;
							managedStack.Add(target);
							objectAndResolveReference->ValueLow = (int)ptr9->TokenLong;
							break;
						}
						throw new NullReferenceException();
					}
					case OpCodeEnum.Stsfld:
					{
						IType type2 = AppDomain.GetType((int)(ptr9->TokenLong >> 32));
						if (type2 != null)
						{
							if (type2 is ILType)
							{
								ILType obj8 = type2 as ILType;
								StackObject* ptr11 = esp - 1;
								obj8.StaticInstance.AssignFromStack((int)ptr9->TokenLong, ptr11, AppDomain, managedStack);
							}
							else
							{
								CLRType cLRType3 = type2 as CLRType;
								int hash3 = (int)ptr9->TokenLong;
								FieldInfo field4 = cLRType3.GetField(hash3);
								StackObject* ptr11 = esp - 1;
								target = null;
								if (!cLRType3.AssignFieldFromStack(hash3, ref target, this, ptr11, managedStack))
								{
									cLRType3.SetStaticFieldValue(hash3, field4.FieldType.CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr11, domain, managedStack), domain)));
								}
							}
							Free(esp - 1);
							esp--;
							break;
						}
						throw new TypeLoadException();
					}
					case OpCodeEnum.Ldsfld:
					{
						IType type2 = AppDomain.GetType((int)(ptr9->TokenLong >> 32));
						if (type2 != null)
						{
							if (type2 is ILType)
							{
								(type2 as ILType).StaticInstance.PushToStack((int)ptr9->TokenLong, esp, this, managedStack);
								esp++;
								break;
							}
							CLRType cLRType = type2 as CLRType;
							int hash = (int)ptr9->TokenLong;
							if (!((CLRType)type2).CopyFieldToStack(hash, null, this, ref esp, managedStack))
							{
								FieldInfo field = cLRType.GetField(hash);
								target = cLRType.GetFieldValue(hash, null);
								if (target is CrossBindingAdaptorType)
								{
									target = ((CrossBindingAdaptorType)target).ILInstance;
								}
								esp = PushObject(esp, managedStack, target, field.FieldType == typeof(object));
							}
							break;
						}
						throw new TypeLoadException();
					}
					case OpCodeEnum.Ldsflda:
					{
						int value2 = (int)(ptr9->TokenLong >> 32);
						int valueLow = (int)ptr9->TokenLong;
						esp->ObjectType = ObjectTypes.StaticFieldReference;
						esp->Value = value2;
						esp->ValueLow = valueLow;
						esp++;
						break;
					}
					case OpCodeEnum.Ldtoken:
						switch (ptr9->TokenInteger)
						{
						case 0:
						{
							IType type2 = AppDomain.GetType((int)(ptr9->TokenLong >> 32));
							if (type2 != null)
							{
								if (!(type2 is ILType))
								{
									throw new NotImplementedException();
								}
								(type2 as ILType).StaticInstance.PushToStack((int)ptr9->TokenLong, esp, this, managedStack);
							}
							esp++;
							break;
						}
						case 1:
						{
							IType type2 = AppDomain.GetType((int)ptr9->TokenLong);
							if (type2 != null)
							{
								esp = PushObject(esp, managedStack, type2.ReflectionType);
								break;
							}
							throw new TypeLoadException();
						}
						default:
							throw new NotImplementedException();
						}
						break;
					case OpCodeEnum.Ldftn:
					{
						IMethod method2 = domain.GetMethod(ptr9->TokenInteger);
						esp = PushObject(esp, managedStack, method2);
						break;
					}
					case OpCodeEnum.Ldvirtftn:
					{
						IMethod method9 = domain.GetMethod(ptr9->TokenInteger);
						StackObject* objectAndResolveReference = esp - 1;
						if (method9 is ILMethod)
						{
							ILMethod method10 = (ILMethod)method9;
							target = managedStack[objectAndResolveReference->Value];
							method9 = ((ILTypeInstance)target).Type.GetVirtualMethod(method10) as ILMethod;
						}
						else
						{
							target = managedStack[objectAndResolveReference->Value];
							if (target is ILTypeInstance)
							{
								method9 = ((ILTypeInstance)target).Type.GetVirtualMethod(method9);
							}
							else if (target is CrossBindingAdaptorType)
							{
								method9 = ((CrossBindingAdaptorType)target).ILInstance.Type.BaseType.GetVirtualMethod(method9);
							}
						}
						Free(objectAndResolveReference);
						esp = PushObject(objectAndResolveReference, managedStack, method9);
						break;
					}
					case OpCodeEnum.Ceq:
					{
						StackObject* ptr38 = esp - 1 - 1;
						StackObject* ptr39 = esp - 1;
						bool flag22 = false;
						if (ptr38->ObjectType == ptr39->ObjectType)
						{
							switch (ptr38->ObjectType)
							{
							case ObjectTypes.Integer:
							case ObjectTypes.Float:
								flag22 = ptr38->Value == ptr39->Value;
								break;
							case ObjectTypes.Object:
								flag22 = managedStack[ptr38->Value] == managedStack[ptr39->Value];
								break;
							case ObjectTypes.FieldReference:
								flag22 = managedStack[ptr38->Value] == managedStack[ptr39->Value] && ptr38->ValueLow == ptr39->ValueLow;
								break;
							case ObjectTypes.Null:
								flag22 = true;
								break;
							default:
								flag22 = ptr38->Value == ptr39->Value && ptr38->ValueLow == ptr39->ValueLow;
								break;
							}
						}
						else
						{
							switch (ptr38->ObjectType)
							{
							case ObjectTypes.Object:
								flag22 = managedStack[ptr38->Value] == null && ptr39->ObjectType == ObjectTypes.Null;
								break;
							case ObjectTypes.Null:
								flag22 = ptr39->ObjectType == ObjectTypes.Object && managedStack[ptr39->Value] == null;
								break;
							}
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						esp = ((!flag22) ? PushZero(esp - 1 - 1) : PushOne(esp - 1 - 1));
						break;
					}
					case OpCodeEnum.Clt:
					{
						StackObject* ptr36 = esp - 1 - 1;
						StackObject* ptr37 = esp - 1;
						bool flag19 = false;
						esp = ((ptr36->ObjectType switch
						{
							ObjectTypes.Integer => (ptr36->Value < ptr37->Value) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr36->Value) < *(long*)(&ptr37->Value)) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr36->Value) < *(float*)(&ptr37->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr36->Value) < *(double*)(&ptr37->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0) ? PushZero(esp - 1 - 1) : PushOne(esp - 1 - 1));
						break;
					}
					case OpCodeEnum.Clt_Un:
					{
						StackObject* ptr34 = esp - 1 - 1;
						StackObject* ptr35 = esp - 1;
						bool flag18 = false;
						esp = ((ptr34->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr34->Value < (uint)ptr35->Value && ptr35->ObjectType != ObjectTypes.Null) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr34->Value)) < (ulong)(*(long*)(&ptr35->Value)) && ptr35->ObjectType != ObjectTypes.Null) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr34->Value) < *(float*)(&ptr35->Value) && ptr35->ObjectType != ObjectTypes.Null) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr34->Value) < *(double*)(&ptr35->Value) && ptr35->ObjectType != ObjectTypes.Null) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0) ? PushZero(esp - 1 - 1) : PushOne(esp - 1 - 1));
						break;
					}
					case OpCodeEnum.Cgt:
					{
						StackObject* ptr31 = esp - 1 - 1;
						StackObject* ptr32 = esp - 1;
						bool flag16 = false;
						esp = ((ptr31->ObjectType switch
						{
							ObjectTypes.Integer => (ptr31->Value > ptr32->Value || ptr32->ObjectType == ObjectTypes.Null) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr31->Value) > *(long*)(&ptr32->Value) || ptr32->ObjectType == ObjectTypes.Null) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr31->Value) > *(float*)(&ptr32->Value) || ptr32->ObjectType == ObjectTypes.Null) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr31->Value) > *(double*)(&ptr32->Value) || ptr32->ObjectType == ObjectTypes.Null) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0) ? PushZero(esp - 1 - 1) : PushOne(esp - 1 - 1));
						break;
					}
					case OpCodeEnum.Cgt_Un:
					{
						StackObject* ptr29 = esp - 1 - 1;
						StackObject* ptr30 = esp - 1;
						bool flag15 = false;
						esp = ((ptr29->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr29->Value > (uint)ptr30->Value || ptr30->ObjectType == ObjectTypes.Null) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr29->Value)) > (ulong)(*(long*)(&ptr30->Value)) || ptr30->ObjectType == ObjectTypes.Null) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr29->Value) > *(float*)(&ptr30->Value) || ptr30->ObjectType == ObjectTypes.Null) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr29->Value) > *(double*)(&ptr30->Value) || ptr30->ObjectType == ObjectTypes.Null) ? 1 : 0, 
							ObjectTypes.Object => (managedStack[ptr29->Value] != null && ptr30->ObjectType == ObjectTypes.Null) ? 1 : 0, 
							ObjectTypes.Null => 0, 
							_ => throw new NotImplementedException(), 
						} == 0) ? PushZero(esp - 1 - 1) : PushOne(esp - 1 - 1));
						break;
					}
					case OpCodeEnum.Newobj:
					{
						IMethod method3 = domain.GetMethod(ptr9->TokenInteger);
						if (method3 is ILMethod)
						{
							IType type2 = method3.DeclearingType as ILType;
							if (type2.IsDelegate)
							{
								StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp - 1 - 1);
								IMethod method4 = (IMethod)managedStack[(esp - 1)->Value];
								object obj3 = ((objectAndResolveReference->ObjectType != ObjectTypes.Null) ? managedStack[objectAndResolveReference->Value] : null);
								Free(esp - 1);
								Free(esp - 1 - 1);
								esp = esp - 1 - 1;
								if (!(method4 is ILMethod iLMethod))
								{
									throw new NotImplementedException();
								}
								object obj4;
								if (obj3 != null)
								{
									obj4 = ((ILTypeInstance)obj3).GetDelegateAdapter(iLMethod);
									if (obj4 == null)
									{
										IMethod method5 = type2.GetMethod("Invoke", method4.ParameterCount);
										if (method5 == null && iLMethod.IsExtend)
										{
											method5 = type2.GetMethod("Invoke", method4.ParameterCount - 1);
										}
										obj4 = domain.DelegateManager.FindDelegateAdapter((ILTypeInstance)obj3, iLMethod, method5);
									}
								}
								else
								{
									if (iLMethod.DelegateAdapter == null)
									{
										IMethod method6 = type2.GetMethod("Invoke", method4.ParameterCount);
										iLMethod.DelegateAdapter = domain.DelegateManager.FindDelegateAdapter(null, iLMethod, method6);
									}
									obj4 = iLMethod.DelegateAdapter;
								}
								esp = PushObject(esp, managedStack, obj4);
							}
							else
							{
								int value = method3.ParameterCount;
								StackObject* ptr5 = esp - value;
								target = null;
								bool isValueType = type2.IsValueType;
								ILIntepreter iLIntepreter;
								UncheckedList<object> uncheckedList;
								if (isValueType && value > 0)
								{
									iLIntepreter = domain.RequestILIntepreter();
									iLIntepreter.stack.ResetValueTypePointer();
									esp = iLIntepreter.stack.StackBase;
									uncheckedList = iLIntepreter.stack.ManagedStack;
								}
								else
								{
									iLIntepreter = this;
									uncheckedList = managedStack;
								}
								StackObject* objectAndResolveReference;
								if (isValueType)
								{
									iLIntepreter.stack.AllocValueType(esp, type2);
									objectAndResolveReference = esp + 1;
									objectAndResolveReference->ObjectType = ObjectTypes.StackObjectReference;
									*(long*)(&objectAndResolveReference->Value) = (long)esp;
									objectAndResolveReference++;
								}
								else
								{
									target = ((ILType)type2).Instantiate(callDefaultConstructor: false);
									objectAndResolveReference = PushObject(esp, uncheckedList, target);
								}
								esp = objectAndResolveReference;
								for (int l = 0; l < value; l++)
								{
									iLIntepreter.CopyToStack(esp, ptr5 + l, managedStack, uncheckedList);
									esp++;
								}
								if (((ILMethod)method3).ShouldUseRegisterVM)
								{
									PrepareRegisterCallStack(esp, uncheckedList, (ILMethod)method3);
									esp = iLIntepreter.ExecuteR((ILMethod)method3, esp, out unhandledException);
								}
								else
								{
									esp = iLIntepreter.Execute((ILMethod)method3, esp, out unhandledException);
								}
								ValueTypeBasePointer = valueTypeBasePointer;
								for (int num14 = value - 1; num14 >= 0; num14--)
								{
									Free(Add(ptr5, num14));
								}
								if (isValueType)
								{
									if (value > 0)
									{
										stack.AllocValueType(ptr5, type2);
										CopyStackValueType(esp - 1, ptr5, iLIntepreter.stack.ManagedStack, managedStack);
										domain.FreeILIntepreter(iLIntepreter);
									}
									else
									{
										StackObject* ptr25 = objectAndResolveReference - 1 - 1;
										*ptr5 = *ptr25;
									}
									esp = ptr5 + 1;
								}
								else
								{
									esp = PushObject(ptr5, managedStack, target);
								}
							}
							if (unhandledException)
							{
								flag2 = true;
							}
							break;
						}
						CLRMethod cLRMethod = (CLRMethod)method3;
						if (cLRMethod == null)
						{
							esp = PushObject(esp, managedStack, new object());
							break;
						}
						if (cLRMethod.DeclearingType.IsDelegate)
						{
							StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp - 1 - 1);
							IMethod method7 = (IMethod)managedStack[(esp - 1)->Value];
							object obj5 = ((objectAndResolveReference->ObjectType != ObjectTypes.Null) ? managedStack[objectAndResolveReference->Value] : null);
							Free(esp - 1);
							Free(esp - 1 - 1);
							esp = esp - 1 - 1;
							object obj6;
							if (method7 is ILMethod ilMethod)
							{
								obj6 = domain.DelegateManager.FindDelegateAdapter((CLRType)cLRMethod.DeclearingType, (ILTypeInstance)obj5, ilMethod);
							}
							else
							{
								if (obj5 is ILTypeInstance)
								{
									obj5 = ((ILTypeInstance)obj5).CLRInstance;
								}
								obj6 = Delegate.CreateDelegate(cLRMethod.DeclearingType.TypeForCLR, obj5, ((CLRMethod)method7).MethodInfo);
							}
							esp = PushObject(esp, managedStack, obj6);
							break;
						}
						CLRRedirectionDelegate redirection = cLRMethod.Redirection;
						if (redirection != null)
						{
							esp = redirection(this, esp, managedStack, cLRMethod, isNewObj: true);
							break;
						}
						object obj7 = cLRMethod.Invoke(this, esp, managedStack, isNewObj: true);
						int parameterCount = cLRMethod.ParameterCount;
						for (int m = 1; m <= parameterCount; m++)
						{
							Free(esp - m);
						}
						esp = Minus(esp, parameterCount);
						esp = PushObject(esp, managedStack, obj7);
						break;
					}
					case OpCodeEnum.Constrained:
					{
						IType type2 = domain.GetType(ptr9->TokenInteger);
						int parameterCount3 = domain.GetMethod((int)ptr9->TokenLong).ParameterCount;
						StackObject* objectAndResolveReference = Minus(esp, parameterCount3 + 1);
						int num18 = managedStack.Count;
						if (objectAndResolveReference->ObjectType < ObjectTypes.Object)
						{
							bool flag25 = false;
							for (int num19 = 0; num19 < parameterCount3; num19++)
							{
								StackObject* ptr40 = Minus(esp, num19 + 1);
								if (ptr40->ObjectType >= ObjectTypes.Object)
								{
									int value20 = ptr40->Value;
									num18--;
									if (!flag25)
									{
										ptr40->Value = managedStack.Count;
										managedStack.Add(managedStack[value20]);
										managedStack[value20] = null;
										flag25 = true;
									}
									else
									{
										managedStack[value20 + 1] = managedStack[value20];
										managedStack[value20] = null;
										ptr40->Value = value20 + 1;
									}
								}
							}
							if (!flag25)
							{
								managedStack.Add(null);
							}
						}
						else
						{
							num18 = objectAndResolveReference->Value;
						}
						StackObject* objectAndResolveReference2 = GetObjectAndResolveReference(objectAndResolveReference);
						if (type2 != null)
						{
							if (type2 is ILType)
							{
								ILType iLType2 = (ILType)type2;
								if (iLType2.IsEnum)
								{
									ILEnumTypeInstance iLEnumTypeInstance2 = new ILEnumTypeInstance(iLType2);
									switch (objectAndResolveReference2->ObjectType)
									{
									case ObjectTypes.FieldReference:
									{
										ILTypeInstance obj14 = managedStack[objectAndResolveReference2->Value] as ILTypeInstance;
										int valueLow11 = objectAndResolveReference2->ValueLow;
										obj14.PushToStack(valueLow11, objectAndResolveReference, this, managedStack);
										iLEnumTypeInstance2.AssignFromStack(0, objectAndResolveReference, AppDomain, managedStack);
										iLEnumTypeInstance2.Boxed = true;
										break;
									}
									case ObjectTypes.StaticFieldReference:
									{
										ILType obj13 = AppDomain.GetType(objectAndResolveReference2->Value) as ILType;
										int valueLow10 = objectAndResolveReference2->ValueLow;
										obj13.StaticInstance.PushToStack(valueLow10, objectAndResolveReference, this, managedStack);
										iLEnumTypeInstance2.AssignFromStack(0, objectAndResolveReference, AppDomain, managedStack);
										iLEnumTypeInstance2.Boxed = true;
										break;
									}
									case ObjectTypes.ArrayReference:
									{
										object obj12 = managedStack[objectAndResolveReference2->Value];
										int valueLow9 = objectAndResolveReference2->ValueLow;
										LoadFromArrayReference(obj12, valueLow9, objectAndResolveReference, iLType2, managedStack);
										iLEnumTypeInstance2.AssignFromStack(0, objectAndResolveReference, AppDomain, managedStack);
										iLEnumTypeInstance2.Boxed = true;
										break;
									}
									default:
										iLEnumTypeInstance2.AssignFromStack(0, objectAndResolveReference2, AppDomain, managedStack);
										iLEnumTypeInstance2.Boxed = true;
										break;
									}
									objectAndResolveReference->ObjectType = ObjectTypes.Object;
									objectAndResolveReference->Value = num18;
									managedStack[num18] = iLEnumTypeInstance2;
								}
								else if (objectAndResolveReference2->ObjectType != ObjectTypes.ValueTypeObjectReference)
								{
									object value21 = RetriveObject(objectAndResolveReference2, managedStack);
									objectAndResolveReference->ObjectType = ObjectTypes.Object;
									objectAndResolveReference->Value = num18;
									managedStack[num18] = value21;
								}
							}
							else
							{
								Type typeForCLR4 = type2.TypeForCLR;
								if (typeForCLR4.IsEnum)
								{
									managedStack[num18] = Enum.ToObject(typeForCLR4, StackObject.ToObject(objectAndResolveReference2, AppDomain, managedStack));
									objectAndResolveReference->ObjectType = ObjectTypes.Object;
									objectAndResolveReference->Value = num18;
								}
								else if (typeForCLR4.IsPrimitive)
								{
									managedStack[num18] = typeForCLR4.CheckCLRTypes(StackObject.ToObject(objectAndResolveReference2, AppDomain, managedStack));
									objectAndResolveReference->ObjectType = ObjectTypes.Object;
									objectAndResolveReference->Value = num18;
								}
								else if (objectAndResolveReference2->ObjectType != ObjectTypes.ValueTypeObjectReference)
								{
									object value22 = RetriveObject(objectAndResolveReference2, managedStack);
									objectAndResolveReference->ObjectType = ObjectTypes.Object;
									objectAndResolveReference->Value = num18;
									managedStack[num18] = value22;
								}
							}
							break;
						}
						throw new NullReferenceException();
					}
					case OpCodeEnum.Box:
					{
						StackObject* objectAndResolveReference = esp - 1;
						IType type2 = domain.GetType(ptr9->TokenInteger);
						if (type2 != null)
						{
							if (type2 is ILType)
							{
								if (((ILType)type2).IsEnum)
								{
									ILEnumTypeInstance iLEnumTypeInstance = new ILEnumTypeInstance((ILType)type2);
									iLEnumTypeInstance.AssignFromStack(0, objectAndResolveReference, AppDomain, managedStack);
									iLEnumTypeInstance.Boxed = true;
									esp = PushObject(objectAndResolveReference, managedStack, iLEnumTypeInstance, isBox: true);
									break;
								}
								switch (objectAndResolveReference->ObjectType)
								{
								case ObjectTypes.ValueTypeObjectReference:
								{
									ILTypeInstance iLTypeInstance4 = ((ILType)type2).Instantiate(callDefaultConstructor: false);
									iLTypeInstance4.AssignFromStack(objectAndResolveReference, domain, managedStack);
									FreeStackValueType(objectAndResolveReference);
									esp = PushObject(objectAndResolveReference, managedStack, iLTypeInstance4, isBox: true);
									break;
								}
								default:
								{
									target = managedStack[objectAndResolveReference->Value];
									Free(objectAndResolveReference);
									if (type2.IsArray)
									{
										esp = PushObject(objectAndResolveReference, managedStack, target, isBox: true);
										break;
									}
									ILTypeInstance iLTypeInstance3 = (ILTypeInstance)target;
									if (iLTypeInstance3 != null)
									{
										if (iLTypeInstance3.IsValueType)
										{
											iLTypeInstance3.Boxed = true;
										}
										esp = PushObject(objectAndResolveReference, managedStack, iLTypeInstance3, isBox: true);
									}
									else
									{
										esp = PushNull(objectAndResolveReference);
									}
									break;
								}
								case ObjectTypes.Null:
									break;
								}
							}
							else if (type2.TypeForCLR.IsPrimitive)
							{
								Type typeForCLR2 = type2.TypeForCLR;
								if (typeForCLR2 == typeof(int))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										esp = PushObject(objectAndResolveReference, managedStack, objectAndResolveReference->Value, isBox: true);
										break;
									case ObjectTypes.Null:
										esp = PushObject(objectAndResolveReference, managedStack, 0, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR2 == typeof(bool))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										esp = PushObject(objectAndResolveReference, managedStack, objectAndResolveReference->Value == 1, isBox: true);
										break;
									case ObjectTypes.Null:
										esp = PushObject(objectAndResolveReference, managedStack, false, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR2 == typeof(byte))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										esp = PushObject(objectAndResolveReference, managedStack, (byte)objectAndResolveReference->Value, isBox: true);
										break;
									case ObjectTypes.Null:
										esp = PushObject(objectAndResolveReference, managedStack, 0L, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR2 == typeof(short))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										esp = PushObject(objectAndResolveReference, managedStack, (short)objectAndResolveReference->Value, isBox: true);
										break;
									case ObjectTypes.Null:
										esp = PushObject(objectAndResolveReference, managedStack, (short)0, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR2 == typeof(long))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Long:
										esp = PushObject(objectAndResolveReference, managedStack, *(long*)(&objectAndResolveReference->Value), isBox: true);
										break;
									case ObjectTypes.Null:
										esp = PushObject(objectAndResolveReference, managedStack, 0L, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR2 == typeof(float))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Float:
										esp = PushObject(objectAndResolveReference, managedStack, *(float*)(&objectAndResolveReference->Value), isBox: true);
										break;
									case ObjectTypes.Null:
										esp = PushObject(objectAndResolveReference, managedStack, 0f, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR2 == typeof(double))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Double:
										esp = PushObject(objectAndResolveReference, managedStack, *(double*)(&objectAndResolveReference->Value), isBox: true);
										break;
									case ObjectTypes.Null:
										esp = PushObject(objectAndResolveReference, managedStack, 0.0, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR2 == typeof(char))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										esp = PushObject(objectAndResolveReference, managedStack, (char)objectAndResolveReference->Value, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR2 == typeof(uint))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										esp = PushObject(objectAndResolveReference, managedStack, (uint)objectAndResolveReference->Value, isBox: true);
										break;
									case ObjectTypes.Null:
										esp = PushObject(objectAndResolveReference, managedStack, 0u, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR2 == typeof(ushort))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										esp = PushObject(objectAndResolveReference, managedStack, (ushort)objectAndResolveReference->Value, isBox: true);
										break;
									case ObjectTypes.Null:
										esp = PushObject(objectAndResolveReference, managedStack, (ushort)0, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR2 == typeof(ulong))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Long:
										esp = PushObject(objectAndResolveReference, managedStack, *(ulong*)(&objectAndResolveReference->Value), isBox: true);
										break;
									case ObjectTypes.Null:
										esp = PushObject(objectAndResolveReference, managedStack, 0uL, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (!(typeForCLR2 == typeof(sbyte)))
								{
									throw new NotImplementedException();
								}
								switch (objectAndResolveReference->ObjectType)
								{
								case ObjectTypes.Integer:
									esp = PushObject(objectAndResolveReference, managedStack, (sbyte)objectAndResolveReference->Value, isBox: true);
									break;
								case ObjectTypes.Null:
									esp = PushObject(objectAndResolveReference, managedStack, (sbyte)0, isBox: true);
									break;
								default:
									throw new NotImplementedException();
								case ObjectTypes.Object:
									break;
								}
							}
							else if (type2.TypeForCLR.IsEnum)
							{
								esp = PushObject(objectAndResolveReference, managedStack, Enum.ToObject(type2.TypeForCLR, StackObject.ToObject(objectAndResolveReference, AppDomain, managedStack)), isBox: true);
							}
							else if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
							{
								StackObject* dst = ResolveReference(objectAndResolveReference);
								IType typeByIndex2 = domain.GetTypeByIndex(dst->Value);
								if (typeByIndex2 != type2)
								{
									throw new InvalidCastException();
								}
								object obj9 = ((CLRType)typeByIndex2).ValueTypeBinder.ToObject(dst, managedStack);
								FreeStackValueType(objectAndResolveReference);
								esp = PushObject(objectAndResolveReference, managedStack, obj9, isBox: true);
							}
							break;
						}
						throw new NullReferenceException();
					}
					case OpCodeEnum.Unbox:
					case OpCodeEnum.Unbox_Any:
					{
						StackObject* objectAndResolveReference = esp - 1;
						if (objectAndResolveReference->ObjectType == ObjectTypes.Object)
						{
							target = managedStack[objectAndResolveReference->Value];
							Free(objectAndResolveReference);
							if (target == null)
							{
								break;
							}
							IType type6 = domain.GetType(ptr9->TokenInteger);
							if (type6 == null)
							{
								throw new TypeLoadException();
							}
							Type typeForCLR = type6.TypeForCLR;
							bool flag4 = target is ILEnumTypeInstance;
							if (type6 is CLRType && typeForCLR.IsPrimitive && !flag4)
							{
								if (typeForCLR == typeof(int))
								{
									int value7 = target.ToInt32();
									objectAndResolveReference->ObjectType = ObjectTypes.Integer;
									objectAndResolveReference->Value = value7;
									break;
								}
								if (typeForCLR == typeof(bool))
								{
									bool flag5 = (bool)target;
									objectAndResolveReference->ObjectType = ObjectTypes.Integer;
									objectAndResolveReference->Value = (flag5 ? 1 : 0);
									break;
								}
								if (typeForCLR == typeof(short))
								{
									short value8 = target.ToInt16();
									objectAndResolveReference->ObjectType = ObjectTypes.Integer;
									objectAndResolveReference->Value = value8;
									break;
								}
								if (typeForCLR == typeof(long))
								{
									long num10 = target.ToInt64();
									objectAndResolveReference->ObjectType = ObjectTypes.Long;
									*(long*)(&objectAndResolveReference->Value) = num10;
									break;
								}
								if (typeForCLR == typeof(float))
								{
									float num11 = target.ToFloat();
									objectAndResolveReference->ObjectType = ObjectTypes.Float;
									*(float*)(&objectAndResolveReference->Value) = num11;
									break;
								}
								if (typeForCLR == typeof(byte))
								{
									byte value9 = (byte)target;
									objectAndResolveReference->ObjectType = ObjectTypes.Integer;
									objectAndResolveReference->Value = value9;
									break;
								}
								if (typeForCLR == typeof(double))
								{
									double num12 = target.ToDouble();
									objectAndResolveReference->ObjectType = ObjectTypes.Double;
									*(double*)(&objectAndResolveReference->Value) = num12;
									break;
								}
								if (typeForCLR == typeof(char))
								{
									char c = (char)target;
									objectAndResolveReference->ObjectType = ObjectTypes.Integer;
									objectAndResolveReference->Value = c;
									break;
								}
								if (typeForCLR == typeof(uint))
								{
									uint value10 = (uint)target;
									objectAndResolveReference->ObjectType = ObjectTypes.Integer;
									objectAndResolveReference->Value = (int)value10;
									break;
								}
								if (typeForCLR == typeof(ushort))
								{
									ushort value11 = (ushort)target;
									objectAndResolveReference->ObjectType = ObjectTypes.Integer;
									objectAndResolveReference->Value = value11;
									break;
								}
								if (typeForCLR == typeof(ulong))
								{
									ulong num13 = (ulong)target;
									objectAndResolveReference->ObjectType = ObjectTypes.Long;
									*(ulong*)(&objectAndResolveReference->Value) = num13;
									break;
								}
								if (!(typeForCLR == typeof(sbyte)))
								{
									throw new NotImplementedException();
								}
								sbyte value12 = (sbyte)target;
								objectAndResolveReference->ObjectType = ObjectTypes.Integer;
								objectAndResolveReference->Value = value12;
							}
							else if (type6.IsValueType)
							{
								if (target is ILTypeInstance)
								{
									ILTypeInstance iLTypeInstance = (ILTypeInstance)target;
									if (iLTypeInstance is ILEnumTypeInstance)
									{
										iLTypeInstance.PushToStack(0, objectAndResolveReference, this, managedStack);
										break;
									}
									if (iLTypeInstance.Boxed)
									{
										iLTypeInstance = iLTypeInstance.Clone();
										iLTypeInstance.Boxed = false;
									}
									PushObject(objectAndResolveReference, managedStack, iLTypeInstance);
								}
								else
								{
									PushObject(objectAndResolveReference, managedStack, target);
								}
							}
							else
							{
								PushObject(objectAndResolveReference, managedStack, target);
							}
						}
						else if (objectAndResolveReference->ObjectType >= ObjectTypes.StackObjectReference && objectAndResolveReference->ObjectType != ObjectTypes.ValueTypeObjectReference)
						{
							throw new InvalidCastException();
						}
						break;
					}
					case OpCodeEnum.Initobj:
					{
						StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp - 1);
						IType type2 = domain.GetType(ptr9->TokenInteger);
						if (type2 is ILType)
						{
							ILType iLType = (ILType)type2;
							if (iLType.IsValueType)
							{
								switch (objectAndResolveReference->ObjectType)
								{
								case ObjectTypes.Null:
									throw new NullReferenceException();
								case ObjectTypes.Integer:
								case ObjectTypes.Float:
									objectAndResolveReference->Value = 0;
									break;
								case ObjectTypes.Long:
								case ObjectTypes.Double:
									*(long*)(&objectAndResolveReference->Value) = 0L;
									break;
								case ObjectTypes.ValueTypeObjectReference:
									stack.ClearValueTypeObject(type2, ResolveReference(objectAndResolveReference));
									break;
								case ObjectTypes.Object:
									target = managedStack[objectAndResolveReference->Value];
									if (target != null)
									{
										if (target is ILTypeInstance)
										{
											instance = target as ILTypeInstance;
											instance.Clear();
											break;
										}
										throw new NotSupportedException();
									}
									throw new NullReferenceException();
								case ObjectTypes.ArrayReference:
								{
									Array array23 = managedStack[objectAndResolveReference->Value] as Array;
									int value = objectAndResolveReference->ValueLow;
									target = array23.GetValue(value);
									if (target == null)
									{
										array23.SetValue(iLType.Instantiate(), value);
										break;
									}
									if (target is ILTypeInstance)
									{
										instance = target as ILTypeInstance;
										instance.Clear();
										break;
									}
									throw new NotImplementedException();
								}
								case ObjectTypes.FieldReference:
									target = managedStack[objectAndResolveReference->Value];
									if (target != null)
									{
										if (target is ILTypeInstance)
										{
											instance = target as ILTypeInstance;
											if (instance[objectAndResolveReference->ValueLow] is ILTypeInstance iLTypeInstance6)
											{
												iLTypeInstance6.Clear();
												break;
											}
											throw new NotSupportedException();
										}
										throw new NotSupportedException();
									}
									throw new NullReferenceException();
								case ObjectTypes.StaticFieldReference:
								{
									IType type18 = AppDomain.GetType(objectAndResolveReference->Value);
									int valueLow8 = objectAndResolveReference->ValueLow;
									if (type18 is ILType)
									{
										if (((ILType)type18).StaticInstance[valueLow8] is ILTypeInstance iLTypeInstance5)
										{
											iLTypeInstance5.Clear();
											break;
										}
										throw new NotSupportedException();
									}
									throw new NotSupportedException();
								}
								default:
									throw new NotImplementedException();
								}
							}
							else
							{
								PushNull(esp);
								switch (objectAndResolveReference->ObjectType)
								{
								case ObjectTypes.StaticFieldReference:
									(AppDomain.GetType(objectAndResolveReference->Value) as ILType).StaticInstance.AssignFromStack(objectAndResolveReference->ValueLow, esp, AppDomain, managedStack);
									break;
								case ObjectTypes.FieldReference:
									instance = managedStack[objectAndResolveReference->Value] as ILTypeInstance;
									instance.AssignFromStack(objectAndResolveReference->ValueLow, esp, AppDomain, managedStack);
									break;
								default:
									if (objectAndResolveReference->ObjectType >= ObjectTypes.Object)
									{
										managedStack[objectAndResolveReference->Value] = null;
									}
									else
									{
										PushNull(objectAndResolveReference);
									}
									break;
								}
							}
						}
						else if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
						{
							stack.ClearValueTypeObject(type2, ResolveReference(objectAndResolveReference));
						}
						else if (objectAndResolveReference->ObjectType == ObjectTypes.FieldReference)
						{
							instance = managedStack[objectAndResolveReference->Value] as ILTypeInstance;
							if (instance == null)
							{
								throw new NotImplementedException();
							}
							instance.InitializeField(objectAndResolveReference->ValueLow);
						}
						else if (type2.IsPrimitive)
						{
							StackObject.Initialized(objectAndResolveReference, type2);
						}
						else if (!type2.IsValueType)
						{
							if (objectAndResolveReference->ObjectType >= ObjectTypes.Object)
							{
								managedStack[objectAndResolveReference->Value] = null;
							}
							else
							{
								PushNull(objectAndResolveReference);
							}
						}
						else if (objectAndResolveReference->ObjectType >= ObjectTypes.Object)
						{
							managedStack[objectAndResolveReference->Value] = ((CLRType)type2).CreateDefaultInstance();
						}
						Free(esp - 1);
						esp--;
						break;
					}
					case OpCodeEnum.Castclass:
					{
						StackObject* objectAndResolveReference = esp - 1;
						StackObject* ptr33 = objectAndResolveReference;
						IType type2 = domain.GetType(ptr9->TokenInteger);
						if (type2 != null)
						{
							objectAndResolveReference = GetObjectAndResolveReference(objectAndResolveReference);
							if (objectAndResolveReference->ObjectType <= ObjectTypes.Double)
							{
								if (objectAndResolveReference->ObjectType != ObjectTypes.Null)
								{
									throw new NotImplementedException();
								}
								break;
							}
							target = RetriveObject(objectAndResolveReference, managedStack);
							Free(ptr33);
							if (target != null)
							{
								if (target is ILTypeInstance)
								{
									if (!((ILTypeInstance)target).CanAssignTo(type2))
									{
										throw new InvalidCastException($"Cannot Cast {((ILTypeInstance)target).Type.FullName} to {type2.FullName}");
									}
									esp = PushObject(ptr33, managedStack, target);
								}
								else
								{
									if (!type2.TypeForCLR.IsAssignableFrom(target.GetType()))
									{
										throw new InvalidCastException($"Cannot Cast {target.GetType().FullName} to {type2.FullName}");
									}
									esp = PushObject(ptr33, managedStack, target, isBox: true);
								}
							}
							else
							{
								ptr33->ObjectType = ObjectTypes.Null;
								ptr33->Value = -1;
								ptr33->ValueLow = 0;
							}
							break;
						}
						throw new NullReferenceException();
					}
					case OpCodeEnum.Isinst:
					{
						StackObject* objectAndResolveReference = esp - 1;
						StackObject* ptr28 = objectAndResolveReference;
						IType type2 = domain.GetType(ptr9->TokenInteger);
						if (type2 != null)
						{
							objectAndResolveReference = GetObjectAndResolveReference(objectAndResolveReference);
							if (objectAndResolveReference->ObjectType <= ObjectTypes.Double)
							{
								Type typeForCLR3 = type2.TypeForCLR;
								switch (objectAndResolveReference->ObjectType)
								{
								case ObjectTypes.Integer:
									if (typeForCLR3 != typeof(int) && typeForCLR3 != typeof(bool) && typeForCLR3 != typeof(short) && typeForCLR3 != typeof(byte) && typeForCLR3 != typeof(ushort) && typeForCLR3 != typeof(uint))
									{
										ptr28->ObjectType = ObjectTypes.Null;
										ptr28->Value = -1;
										ptr28->ValueLow = 0;
									}
									break;
								case ObjectTypes.Long:
									if (typeForCLR3 != typeof(long) && typeForCLR3 != typeof(ulong))
									{
										ptr28->ObjectType = ObjectTypes.Null;
										ptr28->Value = -1;
										ptr28->ValueLow = 0;
									}
									break;
								case ObjectTypes.Float:
									if (typeForCLR3 != typeof(float))
									{
										ptr28->ObjectType = ObjectTypes.Null;
										ptr28->Value = -1;
										ptr28->ValueLow = 0;
									}
									break;
								case ObjectTypes.Double:
									if (typeForCLR3 != typeof(double))
									{
										ptr28->ObjectType = ObjectTypes.Null;
										ptr28->Value = -1;
										ptr28->ValueLow = 0;
									}
									break;
								case ObjectTypes.Null:
									ptr28->ObjectType = ObjectTypes.Null;
									ptr28->Value = -1;
									ptr28->ValueLow = 0;
									break;
								}
								break;
							}
							target = RetriveObject(objectAndResolveReference, managedStack);
							Free(ptr28);
							if (target != null)
							{
								if (target is ILTypeInstance)
								{
									if (((ILTypeInstance)target).CanAssignTo(type2))
									{
										esp = PushObject(ptr28, managedStack, target);
										break;
									}
									ptr28->ObjectType = ObjectTypes.Null;
									ptr28->Value = -1;
									ptr28->ValueLow = 0;
								}
								else if (type2.TypeForCLR.IsAssignableFrom(target.GetType()))
								{
									esp = PushObject(ptr28, managedStack, target, isBox: true);
								}
								else
								{
									ptr28->ObjectType = ObjectTypes.Null;
									ptr28->Value = -1;
									ptr28->ValueLow = 0;
								}
							}
							else
							{
								ptr28->ObjectType = ObjectTypes.Null;
								ptr28->Value = -1;
								ptr28->ValueLow = 0;
							}
							break;
						}
						throw new NullReferenceException();
					}
					case OpCodeEnum.Newarr:
					{
						StackObject* ptr27 = esp - 1;
						IType type2 = domain.GetType(ptr9->TokenInteger);
						object obj10 = null;
						if (type2 != null)
						{
							if (type2.TypeForCLR != typeof(ILTypeInstance))
							{
								obj10 = ((!(type2 is CLRType)) ? Array.CreateInstance(type2.TypeForCLR, ptr27->Value) : ((CLRType)type2).CreateArrayInstance(ptr27->Value));
								AppDomain.GetType(obj10.GetType());
							}
							else
							{
								obj10 = new ILTypeInstance[ptr27->Value];
								ILTypeInstance[] array20 = (ILTypeInstance[])obj10;
								if (type2.IsValueType)
								{
									for (int n = 0; n < ptr27->Value; n++)
									{
										array20[n] = ((ILType)type2).Instantiate();
									}
								}
							}
						}
						ptr27->ObjectType = ObjectTypes.Object;
						ptr27->Value = managedStack.Count;
						managedStack.Add(obj10);
						break;
					}
					case OpCodeEnum.Stelem_Ref:
					case OpCodeEnum.Stelem_Any:
					{
						StackObject* ptr11 = GetObjectAndResolveReference(esp - 1);
						StackObject* ptr26 = esp - 1 - 1;
						StackObject* ptr10 = esp - 1 - 1 - 1;
						Array array19 = managedStack[ptr10->Value] as Array;
						if (array19 is object[])
						{
							switch (ptr11->ObjectType)
							{
							case ObjectTypes.Null:
								array19.SetValue(null, ptr26->Value);
								break;
							case ObjectTypes.Object:
								ArraySetValue(array19, managedStack[ptr11->Value], ptr26->Value);
								break;
							case ObjectTypes.Integer:
								array19.SetValue(ptr11->Value, ptr26->Value);
								break;
							case ObjectTypes.Long:
								array19.SetValue(*(long*)(&ptr11->Value), ptr26->Value);
								break;
							case ObjectTypes.Float:
								array19.SetValue(*(float*)(&ptr11->Value), ptr26->Value);
								break;
							case ObjectTypes.Double:
								array19.SetValue(*(double*)(&ptr11->Value), ptr26->Value);
								break;
							case ObjectTypes.ValueTypeObjectReference:
								ArraySetValue(array19, StackObject.ToObject(ptr11, domain, managedStack), ptr26->Value);
								FreeStackValueType(esp - 1);
								break;
							default:
								throw new NotImplementedException();
							}
						}
						else
						{
							switch (ptr11->ObjectType)
							{
							case ObjectTypes.Object:
								ArraySetValue(array19, managedStack[ptr11->Value], ptr26->Value);
								break;
							case ObjectTypes.Integer:
								StoreIntValueToArray(array19, ptr11, ptr26);
								break;
							case ObjectTypes.Long:
								if (array19 is long[])
								{
									((long[])array19)[ptr26->Value] = *(long*)(&ptr11->Value);
								}
								else
								{
									((ulong[])array19)[ptr26->Value] = *(ulong*)(&ptr11->Value);
								}
								break;
							case ObjectTypes.Float:
								((float[])array19)[ptr26->Value] = *(float*)(&ptr11->Value);
								break;
							case ObjectTypes.Double:
								((double[])array19)[ptr26->Value] = *(double*)(&ptr11->Value);
								break;
							case ObjectTypes.ValueTypeObjectReference:
								ArraySetValue(array19, StackObject.ToObject(ptr11, domain, managedStack), ptr26->Value);
								FreeStackValueType(esp - 1);
								break;
							default:
								throw new NotImplementedException();
							}
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						Free(esp - 1 - 1 - 1);
						esp = esp - 1 - 1 - 1;
						break;
					}
					case OpCodeEnum.Ldelem_Ref:
					case OpCodeEnum.Ldelem_Any:
					{
						StackObject* ptr24 = esp - 1;
						StackObject* ptr10 = esp - 1 - 1;
						Array array17 = managedStack[ptr10->Value] as Array;
						target = ((array17 is ILTypeInstance[] array18) ? array18[ptr24->Value] : array17.GetValue(ptr24->Value));
						if (target is CrossBindingAdaptorType)
						{
							target = ((CrossBindingAdaptorType)target).ILInstance;
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						if (target is ILTypeInstance)
						{
							ILTypeInstance iLTypeInstance2 = (ILTypeInstance)target;
							if (!(iLTypeInstance2 is DelegateAdapter) && iLTypeInstance2.Type.IsValueType && !iLTypeInstance2.Boxed)
							{
								AllocValueType(ptr10, iLTypeInstance2.Type);
								StackObject* dst = ResolveReference(ptr10);
								iLTypeInstance2.CopyValueTypeToStack(dst, managedStack);
								esp = ptr24;
							}
							else
							{
								esp = PushObject(esp - 1 - 1, managedStack, target, isBox: true);
							}
						}
						else
						{
							esp = PushObject(esp - 1 - 1, managedStack, target, !array17.GetType().GetElementType().IsPrimitive);
						}
						break;
					}
					case OpCodeEnum.Stelem_I1:
					{
						StackObject* ptr11 = esp - 1;
						StackObject* ptr23 = esp - 1 - 1;
						StackObject* ptr10 = esp - 1 - 1 - 1;
						if (managedStack[ptr10->Value] is byte[] array15)
						{
							array15[ptr23->Value] = (byte)ptr11->Value;
						}
						else if (managedStack[ptr10->Value] is bool[] array16)
						{
							array16[ptr23->Value] = ptr11->Value == 1;
						}
						else
						{
							(managedStack[ptr10->Value] as sbyte[])[ptr23->Value] = (sbyte)ptr11->Value;
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						Free(esp - 1 - 1 - 1);
						esp = esp - 1 - 1 - 1;
						break;
					}
					case OpCodeEnum.Ldelem_I1:
					{
						StackObject* ptr22 = esp - 1;
						StackObject* ptr10 = esp - 1 - 1;
						int value = ((!(managedStack[ptr10->Value] is bool[] array14)) ? ((int)(managedStack[ptr10->Value] as sbyte[])[ptr22->Value]) : (array14[ptr22->Value] ? 1 : 0));
						Free(esp - 1);
						Free(esp - 1 - 1);
						ptr10->ObjectType = ObjectTypes.Integer;
						ptr10->Value = value;
						esp--;
						break;
					}
					case OpCodeEnum.Ldelem_U1:
					{
						StackObject* ptr21 = esp - 1;
						StackObject* ptr10 = esp - 1 - 1;
						int value = ((!(managedStack[ptr10->Value] is byte[] array13)) ? ((managedStack[ptr10->Value] as bool[])[ptr21->Value] ? 1 : 0) : ((int)array13[ptr21->Value]));
						Free(esp - 1);
						Free(esp - 1 - 1);
						ptr10->ObjectType = ObjectTypes.Integer;
						ptr10->Value = value;
						esp--;
						break;
					}
					case OpCodeEnum.Stelem_I2:
					{
						StackObject* ptr11 = esp - 1;
						StackObject* ptr20 = esp - 1 - 1;
						StackObject* ptr10 = esp - 1 - 1 - 1;
						if (managedStack[ptr10->Value] is short[] array11)
						{
							array11[ptr20->Value] = (short)ptr11->Value;
						}
						else if (managedStack[ptr10->Value] is ushort[] array12)
						{
							array12[ptr20->Value] = (ushort)ptr11->Value;
						}
						else
						{
							(managedStack[ptr10->Value] as char[])[ptr20->Value] = (char)ptr11->Value;
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						Free(esp - 1 - 1 - 1);
						esp = esp - 1 - 1 - 1;
						break;
					}
					case OpCodeEnum.Ldelem_I2:
					{
						int value17 = (esp - 1)->Value;
						StackObject* ptr10 = esp - 1 - 1;
						int value = ((!(managedStack[ptr10->Value] is short[] array10)) ? ((int)(managedStack[ptr10->Value] as char[])[value17]) : ((int)array10[value17]));
						Free(esp - 1);
						Free(esp - 1 - 1);
						ptr10->ObjectType = ObjectTypes.Integer;
						ptr10->Value = value;
						esp--;
						break;
					}
					case OpCodeEnum.Ldelem_U2:
					{
						int value15 = (esp - 1)->Value;
						StackObject* ptr10 = esp - 1 - 1;
						int value = ((!(managedStack[ptr10->Value] is ushort[] array9)) ? (managedStack[ptr10->Value] as char[])[value15] : array9[value15]);
						Free(esp - 1);
						Free(esp - 1 - 1);
						ptr10->ObjectType = ObjectTypes.Integer;
						ptr10->Value = value;
						esp--;
						break;
					}
					case OpCodeEnum.Stelem_I4:
					{
						StackObject* ptr11 = esp - 1;
						StackObject* ptr16 = esp - 1 - 1;
						StackObject* ptr10 = esp - 1 - 1 - 1;
						if (managedStack[ptr10->Value] is int[] array8)
						{
							array8[ptr16->Value] = ptr11->Value;
						}
						else
						{
							(managedStack[ptr10->Value] as uint[])[ptr16->Value] = (uint)ptr11->Value;
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						Free(esp - 1 - 1 - 1);
						esp = esp - 1 - 1 - 1;
						break;
					}
					case OpCodeEnum.Ldelem_I4:
					{
						int value14 = (esp - 1)->Value;
						StackObject* ptr10 = esp - 1 - 1;
						int[] array7 = managedStack[ptr10->Value] as int[];
						Free(esp - 1);
						Free(esp - 1 - 1);
						ptr10->ObjectType = ObjectTypes.Integer;
						ptr10->Value = array7[value14];
						esp--;
						break;
					}
					case OpCodeEnum.Ldelem_U4:
					{
						int value13 = (esp - 1)->Value;
						StackObject* ptr10 = esp - 1 - 1;
						uint[] array6 = managedStack[ptr10->Value] as uint[];
						Free(esp - 1);
						Free(esp - 1 - 1);
						ptr10->ObjectType = ObjectTypes.Integer;
						ptr10->Value = (int)array6[value13];
						esp--;
						break;
					}
					case OpCodeEnum.Stelem_I8:
					{
						StackObject* ptr11 = esp - 1;
						StackObject* ptr15 = esp - 1 - 1;
						StackObject* ptr10 = esp - 1 - 1 - 1;
						if (managedStack[ptr10->Value] is long[] array5)
						{
							array5[ptr15->Value] = *(long*)(&ptr11->Value);
						}
						else
						{
							(managedStack[ptr10->Value] as ulong[])[ptr15->Value] = *(ulong*)(&ptr11->Value);
						}
						Free(esp - 1);
						Free(esp - 1 - 1);
						Free(esp - 1 - 1 - 1);
						esp = esp - 1 - 1 - 1;
						break;
					}
					case OpCodeEnum.Ldelem_I8:
					{
						StackObject* ptr14 = esp - 1;
						StackObject* ptr10 = esp - 1 - 1;
						long num9 = ((!(managedStack[ptr10->Value] is long[] array4)) ? ((long)(managedStack[ptr10->Value] as ulong[])[ptr14->Value]) : array4[ptr14->Value]);
						Free(esp - 1);
						Free(esp - 1 - 1);
						ptr10->ObjectType = ObjectTypes.Long;
						*(long*)(&ptr10->Value) = num9;
						esp--;
						break;
					}
					case OpCodeEnum.Stelem_R4:
					{
						StackObject* ptr11 = esp - 1;
						StackObject* ptr13 = esp - 1 - 1;
						StackObject* ptr10 = esp - 1 - 1 - 1;
						(managedStack[ptr10->Value] as float[])[ptr13->Value] = *(float*)(&ptr11->Value);
						Free(esp - 1);
						Free(esp - 1 - 1);
						Free(esp - 1 - 1 - 1);
						esp = esp - 1 - 1 - 1;
						break;
					}
					case OpCodeEnum.Ldelem_R4:
					{
						int value6 = (esp - 1)->Value;
						StackObject* ptr10 = esp - 1 - 1;
						float[] array3 = managedStack[ptr10->Value] as float[];
						Free(esp - 1);
						Free(esp - 1 - 1);
						ptr10->ObjectType = ObjectTypes.Float;
						*(float*)(&ptr10->Value) = array3[value6];
						esp--;
						break;
					}
					case OpCodeEnum.Stelem_R8:
					{
						StackObject* ptr11 = esp - 1;
						StackObject* ptr12 = esp - 1 - 1;
						StackObject* ptr10 = esp - 1 - 1 - 1;
						(managedStack[ptr10->Value] as double[])[ptr12->Value] = *(double*)(&ptr11->Value);
						Free(esp - 1);
						Free(esp - 1 - 1);
						Free(esp - 1 - 1 - 1);
						esp = esp - 1 - 1 - 1;
						break;
					}
					case OpCodeEnum.Ldelem_R8:
					{
						int value5 = (esp - 1)->Value;
						StackObject* ptr10 = esp - 1 - 1;
						double[] array2 = managedStack[ptr10->Value] as double[];
						Free(esp - 1);
						Free(esp - 1 - 1);
						ptr10->ObjectType = ObjectTypes.Double;
						*(double*)(&ptr10->Value) = array2[value5];
						esp--;
						break;
					}
					case OpCodeEnum.Ldlen:
					{
						StackObject* ptr10 = esp - 1;
						Array array = managedStack[ptr10->Value] as Array;
						Free(esp - 1);
						ptr10->ObjectType = ObjectTypes.Integer;
						ptr10->Value = array.Length;
						break;
					}
					case OpCodeEnum.Ldelema:
					{
						StackObject* ptr10 = esp - 1 - 1;
						int value4 = (esp - 1)->Value;
						Array item = managedStack[ptr10->Value] as Array;
						Free(esp - 1);
						Free(esp - 1 - 1);
						ptr10->ObjectType = ObjectTypes.ArrayReference;
						ptr10->Value = managedStack.Count;
						managedStack.Add(item);
						ptr10->ValueLow = value4;
						esp--;
						break;
					}
					case OpCodeEnum.Conv_Ovf_U1_Un:
					case OpCodeEnum.Conv_Ovf_U1:
					case OpCodeEnum.Conv_U1:
					{
						StackObject* objectAndResolveReference = esp - 1;
						int value;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.Integer:
						case ObjectTypes.Long:
							value = (byte)objectAndResolveReference->Value;
							break;
						case ObjectTypes.Float:
							value = (byte)(*(float*)(&objectAndResolveReference->Value));
							break;
						case ObjectTypes.Double:
							value = (byte)(*(double*)(&objectAndResolveReference->Value));
							break;
						default:
							throw new NotImplementedException();
						}
						objectAndResolveReference->ObjectType = ObjectTypes.Integer;
						objectAndResolveReference->Value = value;
						objectAndResolveReference->ValueLow = 0;
						break;
					}
					case OpCodeEnum.Conv_I1:
					case OpCodeEnum.Conv_Ovf_I1_Un:
					case OpCodeEnum.Conv_Ovf_I1:
					{
						StackObject* objectAndResolveReference = esp - 1;
						int value;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.Integer:
						case ObjectTypes.Long:
							value = (sbyte)objectAndResolveReference->Value;
							break;
						case ObjectTypes.Float:
							value = (sbyte)(*(float*)(&objectAndResolveReference->Value));
							break;
						case ObjectTypes.Double:
							value = (sbyte)(*(double*)(&objectAndResolveReference->Value));
							break;
						default:
							throw new NotImplementedException();
						}
						objectAndResolveReference->ObjectType = ObjectTypes.Integer;
						objectAndResolveReference->Value = value;
						objectAndResolveReference->ValueLow = 0;
						break;
					}
					case OpCodeEnum.Conv_Ovf_U2_Un:
					case OpCodeEnum.Conv_Ovf_U2:
					case OpCodeEnum.Conv_U2:
					{
						StackObject* objectAndResolveReference = esp - 1;
						int value;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.Integer:
						case ObjectTypes.Long:
							value = (ushort)objectAndResolveReference->Value;
							break;
						case ObjectTypes.Float:
							value = (ushort)(*(float*)(&objectAndResolveReference->Value));
							break;
						case ObjectTypes.Double:
							value = (ushort)(*(double*)(&objectAndResolveReference->Value));
							break;
						default:
							throw new NotImplementedException();
						}
						objectAndResolveReference->ObjectType = ObjectTypes.Integer;
						objectAndResolveReference->Value = value;
						objectAndResolveReference->ValueLow = 0;
						break;
					}
					case OpCodeEnum.Conv_I2:
					case OpCodeEnum.Conv_Ovf_I2_Un:
					case OpCodeEnum.Conv_Ovf_I2:
					{
						StackObject* objectAndResolveReference = esp - 1;
						int value;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.Integer:
						case ObjectTypes.Long:
							value = (short)objectAndResolveReference->Value;
							break;
						case ObjectTypes.Float:
							value = (short)(*(float*)(&objectAndResolveReference->Value));
							break;
						case ObjectTypes.Double:
							value = (short)(*(double*)(&objectAndResolveReference->Value));
							break;
						default:
							throw new NotImplementedException();
						}
						objectAndResolveReference->ObjectType = ObjectTypes.Integer;
						objectAndResolveReference->Value = value;
						objectAndResolveReference->ValueLow = 0;
						break;
					}
					case OpCodeEnum.Conv_U4:
					case OpCodeEnum.Conv_Ovf_U4_Un:
					case OpCodeEnum.Conv_Ovf_U4:
					case OpCodeEnum.Conv_U:
					{
						StackObject* objectAndResolveReference = esp - 1;
						uint value3 = objectAndResolveReference->ObjectType switch
						{
							ObjectTypes.Long => (uint)(*(ulong*)(&objectAndResolveReference->Value)), 
							ObjectTypes.Integer => (uint)objectAndResolveReference->Value, 
							ObjectTypes.Float => (uint)(*(float*)(&objectAndResolveReference->Value)), 
							ObjectTypes.Double => (uint)(*(double*)(&objectAndResolveReference->Value)), 
							_ => throw new NotImplementedException(), 
						};
						objectAndResolveReference->ObjectType = ObjectTypes.Integer;
						objectAndResolveReference->Value = (int)value3;
						objectAndResolveReference->ValueLow = 0;
						break;
					}
					case OpCodeEnum.Conv_I4:
					case OpCodeEnum.Conv_Ovf_I4_Un:
					case OpCodeEnum.Conv_Ovf_I_Un:
					case OpCodeEnum.Conv_Ovf_I4:
					case OpCodeEnum.Conv_I:
					case OpCodeEnum.Conv_Ovf_I:
					{
						StackObject* objectAndResolveReference = esp - 1;
						int value = objectAndResolveReference->ObjectType switch
						{
							ObjectTypes.Long => (int)(*(long*)(&objectAndResolveReference->Value)), 
							ObjectTypes.Float => (int)(*(float*)(&objectAndResolveReference->Value)), 
							ObjectTypes.Double => (int)(*(double*)(&objectAndResolveReference->Value)), 
							ObjectTypes.Integer => objectAndResolveReference->Value, 
							_ => throw new NotImplementedException(), 
						};
						objectAndResolveReference->ObjectType = ObjectTypes.Integer;
						objectAndResolveReference->Value = value;
						break;
					}
					case OpCodeEnum.Conv_I8:
					case OpCodeEnum.Conv_Ovf_I8_Un:
					case OpCodeEnum.Conv_Ovf_I8:
					{
						StackObject* objectAndResolveReference = esp - 1;
						long num8;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.Integer:
							num8 = objectAndResolveReference->Value;
							goto IL_762a;
						case ObjectTypes.Long:
							ptr9++;
							goto end_IL_0334;
						case ObjectTypes.Float:
							num8 = (long)(*(float*)(&objectAndResolveReference->Value));
							goto IL_762a;
						case ObjectTypes.Double:
							num8 = (long)(*(double*)(&objectAndResolveReference->Value));
							goto IL_762a;
						default:
							{
								throw new NotImplementedException();
							}
							IL_762a:
							objectAndResolveReference->ObjectType = ObjectTypes.Long;
							*(long*)(&objectAndResolveReference->Value) = num8;
							break;
						}
						break;
					}
					case OpCodeEnum.Conv_U8:
					case OpCodeEnum.Conv_Ovf_U8_Un:
					case OpCodeEnum.Conv_Ovf_U8:
					{
						StackObject* objectAndResolveReference = esp - 1;
						ulong num7;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.Integer:
							num7 = (uint)objectAndResolveReference->Value;
							goto IL_76ae;
						case ObjectTypes.Long:
							ptr9++;
							goto end_IL_0334;
						case ObjectTypes.Float:
							num7 = (ulong)(*(float*)(&objectAndResolveReference->Value));
							goto IL_76ae;
						case ObjectTypes.Double:
							num7 = (ulong)(*(double*)(&objectAndResolveReference->Value));
							goto IL_76ae;
						default:
							{
								throw new NotImplementedException();
							}
							IL_76ae:
							objectAndResolveReference->ObjectType = ObjectTypes.Long;
							*(ulong*)(&objectAndResolveReference->Value) = num7;
							break;
						}
						break;
					}
					case OpCodeEnum.Conv_R4:
					{
						StackObject* objectAndResolveReference = esp - 1;
						float num6;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.Long:
							num6 = *(long*)(&objectAndResolveReference->Value);
							goto IL_773e;
						case ObjectTypes.Float:
							ptr9++;
							goto end_IL_0334;
						case ObjectTypes.Double:
							num6 = (float)(*(double*)(&objectAndResolveReference->Value));
							goto IL_773e;
						case ObjectTypes.Integer:
							num6 = objectAndResolveReference->Value;
							goto IL_773e;
						default:
							{
								throw new NotImplementedException();
							}
							IL_773e:
							objectAndResolveReference->ObjectType = ObjectTypes.Float;
							*(float*)(&objectAndResolveReference->Value) = num6;
							break;
						}
						break;
					}
					case OpCodeEnum.Conv_R8:
					{
						StackObject* objectAndResolveReference = esp - 1;
						double num5;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.Long:
							num5 = *(long*)(&objectAndResolveReference->Value);
							goto IL_77d2;
						case ObjectTypes.Float:
							num5 = *(float*)(&objectAndResolveReference->Value);
							goto IL_77d2;
						case ObjectTypes.Integer:
							num5 = objectAndResolveReference->Value;
							goto IL_77d2;
						case ObjectTypes.Double:
							ptr9++;
							goto end_IL_0334;
						default:
							{
								throw new NotImplementedException();
							}
							IL_77d2:
							objectAndResolveReference->ObjectType = ObjectTypes.Double;
							*(double*)(&objectAndResolveReference->Value) = num5;
							break;
						}
						break;
					}
					case OpCodeEnum.Conv_R_Un:
					{
						StackObject* objectAndResolveReference = esp - 1;
						bool flag3 = false;
						float num3 = 0f;
						double num4 = 0.0;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.Long:
							num4 = *(ulong*)(&objectAndResolveReference->Value);
							flag3 = true;
							goto IL_788e;
						case ObjectTypes.Float:
							ptr9++;
							goto end_IL_0334;
						case ObjectTypes.Integer:
							num3 = (uint)objectAndResolveReference->Value;
							goto IL_788e;
						case ObjectTypes.Double:
							ptr9++;
							goto end_IL_0334;
						default:
							{
								throw new NotImplementedException();
							}
							IL_788e:
							if (flag3)
							{
								objectAndResolveReference->ObjectType = ObjectTypes.Double;
								*(double*)(&objectAndResolveReference->Value) = num4;
							}
							else
							{
								objectAndResolveReference->ObjectType = ObjectTypes.Float;
								*(float*)(&objectAndResolveReference->Value) = num3;
							}
							break;
						}
						break;
					}
					case OpCodeEnum.Pop:
						Free(esp - 1);
						esp--;
						break;
					case OpCodeEnum.Dup:
					{
						StackObject* objectAndResolveReference = esp - 1;
						if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
						{
							CloneStackValueType(objectAndResolveReference, esp, managedStack);
						}
						else
						{
							*esp = *objectAndResolveReference;
							if (esp->ObjectType >= ObjectTypes.Object)
							{
								esp->Value = managedStack.Count;
								managedStack.Add(managedStack[objectAndResolveReference->Value]);
							}
						}
						esp++;
						break;
					}
					case OpCodeEnum.Throw:
					{
						StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp - 1);
						Exception obj2 = managedStack[objectAndResolveReference->Value] as Exception;
						Free(objectAndResolveReference);
						esp--;
						throw obj2;
					}
					case OpCodeEnum.Rethrow:
						throw ex;
					default:
						throw new NotSupportedException("Not supported opcode " + code);
					case OpCodeEnum.Nop:
					case OpCodeEnum.Volatile:
					case OpCodeEnum.Readonly:
						break;
						IL_3213:
						ptr9 = ptr8 + ptr9->TokenInteger;
						goto end_IL_0334;
					}
					ptr9++;
					end_IL_0334:;
				}
				catch (Exception ex2)
				{
					if (exceptionHandler == null)
					{
						goto IL_7d79;
					}
					int addr2 = (int)(ptr9 - ptr8);
					ILRuntime.CLR.Method.ExceptionHandler correspondingExceptionHandler = GetCorrespondingExceptionHandler(exceptionHandler, ex2, addr2, ILRuntime.CLR.Method.ExceptionHandlerType.Catch, explicitMatch: true);
					if (correspondingExceptionHandler == null)
					{
						correspondingExceptionHandler = GetCorrespondingExceptionHandler(exceptionHandler, ex2, addr2, ILRuntime.CLR.Method.ExceptionHandlerType.Catch, explicitMatch: false);
					}
					if (correspondingExceptionHandler != null)
					{
						if (ex2 is ILRuntimeException)
						{
							ILRuntimeException ex3 = (ILRuntimeException)ex2;
							Exception innerException = ex3.InnerException;
							innerException.Data["ThisInfo"] = ex3.ThisInfo;
							innerException.Data["StackTrace"] = (innerException.Data.Contains("StackTrace") ? string.Format("{0}\n--- End of stack trace from previous location ---\n{1}", ex3.StackTrace, innerException.Data["StackTrace"]) : ex3.StackTrace);
							innerException.Data["LocalInfo"] = ex3.LocalInfo;
							ex2 = innerException;
						}
						else
						{
							DebugService debugService = AppDomain.DebugService;
							if (method.HasThis)
							{
								ex2.Data["ThisInfo"] = debugService.GetThisInfo(this);
							}
							else
							{
								ex2.Data["ThisInfo"] = "";
							}
							ex2.Data["StackTrace"] = (ex2.Data.Contains("StackTrace") ? string.Format("{0}\n--- End of stack trace from previous location ---\n{1}", debugService.GetStackTrace(this), ex2.Data["StackTrace"]) : debugService.GetStackTrace(this));
							ex2.Data["LocalInfo"] = debugService.GetLocalVariableInfo(this);
						}
						while (stack.Frames.Peek().BasePointer != res.BasePointer)
						{
							StackFrame frame = stack.Frames.Peek();
							esp = stack.PopFrame(ref frame, esp);
							if (frame.Method.ReturnType != AppDomain.VoidType)
							{
								Free(esp - 1);
								esp--;
							}
						}
						ex = ex2;
						esp = PushObject(esp, managedStack, ex2);
						unhandledException = false;
						ILRuntime.CLR.Method.ExceptionHandler exceptionHandler4 = FindExceptionHandlerByBranchTarget(addr2, correspondingExceptionHandler.HandlerStart, exceptionHandler);
						if (exceptionHandler4 != null)
						{
							num = correspondingExceptionHandler.HandlerStart;
							ptr9 = ptr8 + exceptionHandler4.HandlerStart;
						}
						else
						{
							ptr9 = ptr8 + correspondingExceptionHandler.HandlerStart;
						}
					}
					else
					{
						correspondingExceptionHandler = GetCorrespondingExceptionHandler(exceptionHandler, null, addr2, ILRuntime.CLR.Method.ExceptionHandlerType.Fault, explicitMatch: false);
						if (correspondingExceptionHandler == null)
						{
							correspondingExceptionHandler = GetCorrespondingExceptionHandler(exceptionHandler, null, addr2, ILRuntime.CLR.Method.ExceptionHandlerType.Finally, explicitMatch: false);
						}
						if (correspondingExceptionHandler == null)
						{
							goto IL_7d79;
						}
						unhandledException = false;
						num = -1;
						ex = ((ex2 is ILRuntimeException) ? ex2 : new ILRuntimeException(ex2.Message, this, method, ex2));
						ptr9 = ptr8 + correspondingExceptionHandler.HandlerStart;
					}
					goto end_IL_79b6;
					IL_7d79:
					if (unhandledException)
					{
						throw ex2;
					}
					unhandledException = true;
					flag2 = true;
					throw new ILRuntimeException(ex2.Message, this, method, ex2);
					end_IL_79b6:;
				}
			}
		}
		return stack.PopFrame(ref res, esp);
	}

	private unsafe StackObject* PrepareEventHandler(StackObject* esp, ILMethod ilm, UncheckedList<object> mStack, out ILTypeInstance instance)
	{
		instance = null;
		object obj = StackObject.ToObject(esp - 1, domain, mStack);
		Free(esp - 1);
		StackObject* esp2;
		if (ilm.IsStatic)
		{
			instance = ((ILType)ilm.DeclearingType).StaticInstance;
			esp2 = esp - 1;
		}
		else
		{
			esp2 = esp - 2;
			instance = StackObject.ToObject(esp2, domain, mStack) as ILTypeInstance;
			Free(esp2);
		}
		object obj2 = instance[ilm.EventFieldIndex];
		esp2 = PushObject(esp2, mStack, obj2);
		return PushObject(esp2, mStack, obj);
	}

	private ILRuntime.CLR.Method.ExceptionHandler FindExceptionHandlerByBranchTarget(int addr, int branchTarget, ILRuntime.CLR.Method.ExceptionHandler[] ehs)
	{
		ILRuntime.CLR.Method.ExceptionHandler exceptionHandler = null;
		foreach (ILRuntime.CLR.Method.ExceptionHandler exceptionHandler2 in ehs)
		{
			if (addr >= exceptionHandler2.TryStart && addr <= exceptionHandler2.TryEnd && (branchTarget < exceptionHandler2.TryStart || branchTarget > exceptionHandler2.TryEnd) && exceptionHandler2.HandlerType == ILRuntime.CLR.Method.ExceptionHandlerType.Finally && (exceptionHandler == null || exceptionHandler2.TryStart > exceptionHandler.TryStart))
			{
				exceptionHandler = exceptionHandler2;
			}
		}
		return exceptionHandler;
	}

	private unsafe void RelocateValueTypeManagedObj(StackObject* esp, UncheckedList<object> mStack, ref int curIdx)
	{
		StackObject* ptr = ResolveReference(esp);
		for (int num = ptr->ValueLow; num > 0; num--)
		{
			StackObject* ptr2 = ptr - num;
			if (ptr2->ObjectType >= ObjectTypes.Object)
			{
				mStack[curIdx] = mStack[ptr2->Value];
				ptr2->Value = curIdx;
				curIdx--;
			}
			else if (ptr2->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				RelocateValueTypeManagedObj(ptr2, mStack, ref curIdx);
			}
		}
	}

	private unsafe void PrepareRegisterCallStack(StackObject* esp, UncheckedList<object> mStack, ILMethod method)
	{
		int num = (method.HasThis ? (method.ParameterCount + 1) : method.ParameterCount);
		StackObject* ptr = esp - num;
		int num2 = 0;
		for (int i = 0; i < num; i++)
		{
			if (ptr[i].ObjectType < ObjectTypes.Object)
			{
				mStack.Add(null);
			}
			else
			{
				num2++;
			}
		}
		if (num2 <= 0)
		{
			return;
		}
		int curIdx = mStack.Count - 1;
		for (int num3 = num - 1; num3 >= 0; num3--)
		{
			StackObject* ptr2 = ptr + num3;
			if (ptr2->ObjectType >= ObjectTypes.Object)
			{
				mStack[curIdx] = mStack[ptr2->Value];
				ptr2->Value = curIdx;
			}
			else
			{
				if (ptr2->ObjectType == ObjectTypes.Null)
				{
					ptr2->ObjectType = ObjectTypes.Object;
					ptr2->Value = curIdx;
				}
				else if (ptr2->ObjectType == ObjectTypes.ValueTypeObjectReference)
				{
					RelocateValueTypeManagedObj(ptr2, mStack, ref curIdx);
				}
				mStack[curIdx] = null;
			}
			curIdx--;
		}
	}

	private unsafe void DumpStack(StackObject* esp)
	{
		AppDomain.DebugService.DumpStack(esp, stack);
	}

	private unsafe void CloneStackValueType(StackObject* src, StackObject* dst, UncheckedList<object> mStack)
	{
		StackObject* ptr = ResolveReference(src);
		stack.AllocValueType(dst, AppDomain.GetTypeByIndex(ptr->Value));
		StackObject* obj = ResolveReference(dst);
		int valueLow = ptr->ValueLow;
		for (int i = 0; i < valueLow; i++)
		{
			StackObject* val = Minus(ptr, i + 1);
			CopyToValueTypeField(obj, i, val, mStack);
		}
	}

	private unsafe bool CanCastTo(StackObject* src, StackObject* dst)
	{
		IType typeByIndex = AppDomain.GetTypeByIndex(src->Value);
		IType typeByIndex2 = AppDomain.GetTypeByIndex(dst->Value);
		return typeByIndex.CanAssignTo(typeByIndex2);
	}

	private unsafe bool CanCopyStackValueType(StackObject* src, StackObject* dst)
	{
		if (src->ObjectType == ObjectTypes.ValueTypeObjectReference && dst->ObjectType == ObjectTypes.ValueTypeObjectReference)
		{
			StackObject* src2 = ResolveReference(src);
			StackObject* dst2 = ResolveReference(dst);
			return CanCastTo(src2, dst2);
		}
		return false;
	}

	public unsafe void CopyStackValueType(StackObject* src, StackObject* dst, UncheckedList<object> mStack)
	{
		CopyStackValueType(src, dst, mStack, mStack);
	}

	public unsafe void CopyStackValueType(StackObject* src, StackObject* dst, UncheckedList<object> mStack, UncheckedList<object> dstmStack)
	{
		StackObject* ptr = ResolveReference(src);
		StackObject* a = ResolveReference(dst);
		int valueLow = ptr->ValueLow;
		for (int i = 0; i < valueLow; i++)
		{
			StackObject* ptr2 = Minus(ptr, i + 1);
			StackObject* ptr3 = Minus(a, i + 1);
			switch (ptr2->ObjectType)
			{
			case ObjectTypes.Object:
			case ObjectTypes.FieldReference:
			case ObjectTypes.ArrayReference:
				dstmStack[ptr3->Value] = mStack[ptr2->Value];
				break;
			case ObjectTypes.ValueTypeObjectReference:
				CopyStackValueType(ptr2, ptr3, mStack, dstmStack);
				break;
			default:
				*ptr3 = *ptr2;
				break;
			}
		}
	}

	private unsafe void CopyValueTypeToStack(StackObject* dst, object ins, UncheckedList<object> mStack)
	{
		if (ins is ILTypeInstance)
		{
			((ILTypeInstance)ins).CopyValueTypeToStack(dst, mStack);
		}
		else if (ins is CrossBindingAdaptorType)
		{
			((CrossBindingAdaptorType)ins).ILInstance.CopyValueTypeToStack(dst, mStack);
		}
		else
		{
			((CLRType)domain.GetTypeByIndex(dst->Value)).ValueTypeBinder.CopyValueTypeToStack(ins, dst, mStack);
		}
	}

	private unsafe void CopyToValueTypeField(StackObject* obj, int idx, StackObject* val, UncheckedList<object> mStack)
	{
		StackObject* ptr = Minus(obj, idx + 1);
		switch (val->ObjectType)
		{
		case ObjectTypes.Null:
			mStack[ptr->Value] = null;
			break;
		case ObjectTypes.Object:
		case ObjectTypes.FieldReference:
		case ObjectTypes.ArrayReference:
			if (ptr->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				object ins = mStack[val->Value];
				ptr = ResolveReference(ptr);
				CopyValueTypeToStack(ptr, ins, mStack);
			}
			else
			{
				mStack[ptr->Value] = CheckAndCloneValueType(mStack[val->Value], domain);
			}
			break;
		case ObjectTypes.ValueTypeObjectReference:
			if (ptr->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				CopyStackValueType(val, ptr, mStack);
				break;
			}
			throw new NotImplementedException();
		default:
			*ptr = *val;
			break;
		}
	}

	private unsafe void StLocSub(StackObject* esp, StackObject* v, int idx, UncheckedList<object> mStack)
	{
		switch (esp->ObjectType)
		{
		case ObjectTypes.Null:
			v->ObjectType = ObjectTypes.Object;
			v->Value = idx;
			mStack[idx] = null;
			break;
		case ObjectTypes.Object:
		case ObjectTypes.FieldReference:
		case ObjectTypes.ArrayReference:
			if (v->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				object obj = mStack[esp->Value];
				if (obj is ILTypeInstance)
				{
					StackObject* ptr = ResolveReference(v);
					((ILTypeInstance)obj).CopyValueTypeToStack(ptr, mStack);
				}
				else
				{
					StackObject* ptr2 = ResolveReference(v);
					(domain.GetTypeByIndex(ptr2->Value) as CLRType).ValueTypeBinder.CopyValueTypeToStack(obj, ptr2, mStack);
				}
			}
			else
			{
				*v = *esp;
				mStack[idx] = CheckAndCloneValueType(mStack[v->Value], domain);
				v->Value = idx;
			}
			Free(esp);
			break;
		case ObjectTypes.ValueTypeObjectReference:
			if (v->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				CopyStackValueType(esp, v, mStack);
				FreeStackValueType(esp);
				break;
			}
			throw new NotImplementedException();
		default:
			*v = *esp;
			mStack[idx] = null;
			break;
		}
	}

	[Obsolete]
	public unsafe object RetriveObject(StackObject* esp, IList<object> mStack)
	{
		return RetriveObject(esp, (UncheckedList<object>)mStack);
	}

	public unsafe object RetriveObject(StackObject* esp, UncheckedList<object> mStack)
	{
		StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp);
		if (objectAndResolveReference->ObjectType == ObjectTypes.Null)
		{
			return null;
		}
		object obj = null;
		switch (objectAndResolveReference->ObjectType)
		{
		case ObjectTypes.Object:
			return mStack[objectAndResolveReference->Value];
		case ObjectTypes.FieldReference:
		{
			obj = mStack[objectAndResolveReference->Value];
			int valueLow2 = objectAndResolveReference->ValueLow;
			if (obj is ILTypeInstance)
			{
				return ((ILTypeInstance)obj)[valueLow2];
			}
			return ((CLRType)AppDomain.GetType(obj.GetType())).GetFieldValue(valueLow2, obj);
		}
		case ObjectTypes.ArrayReference:
		{
			Array obj2 = mStack[objectAndResolveReference->Value] as Array;
			int valueLow3 = objectAndResolveReference->ValueLow;
			return obj2.GetValue(valueLow3);
		}
		case ObjectTypes.StaticFieldReference:
		{
			IType type = AppDomain.GetType(objectAndResolveReference->Value);
			int valueLow = objectAndResolveReference->ValueLow;
			if (type is ILType)
			{
				return ((ILType)type).StaticInstance[valueLow];
			}
			return ((CLRType)type).GetFieldValue(valueLow, null);
		}
		case ObjectTypes.ValueTypeObjectReference:
			return StackObject.ToObject(objectAndResolveReference, domain, mStack);
		default:
			throw new NotImplementedException();
		}
	}

	public unsafe int RetriveInt32(StackObject* esp, UncheckedList<object> mStack)
	{
		StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp);
		if (objectAndResolveReference->ObjectType == ObjectTypes.Null)
		{
			return 0;
		}
		object obj = null;
		int num = 0;
		switch (objectAndResolveReference->ObjectType)
		{
		case ObjectTypes.Object:
			return (int)mStack[objectAndResolveReference->Value];
		case ObjectTypes.Integer:
			return objectAndResolveReference->Value;
		case ObjectTypes.FieldReference:
		{
			obj = mStack[objectAndResolveReference->Value];
			int valueLow3 = objectAndResolveReference->ValueLow;
			if (obj is ILTypeInstance)
			{
				return ((ILTypeInstance)obj).Fields[valueLow3].Value;
			}
			IType type2 = AppDomain.GetType(obj.GetType());
			StackObject stackObject2 = default(StackObject);
			StackObject* esp3 = &stackObject2;
			if (!((CLRType)type2).CopyFieldToStack(valueLow3, obj, this, ref esp3, mStack))
			{
				return (int)((CLRType)type2).GetFieldValue(valueLow3, obj);
			}
			return stackObject2.Value;
		}
		case ObjectTypes.ArrayReference:
		{
			Array array = mStack[objectAndResolveReference->Value] as Array;
			int valueLow2 = objectAndResolveReference->ValueLow;
			if (array is int[])
			{
				return ((int[])array)[valueLow2];
			}
			return Convert.ToInt32(array.GetValue(valueLow2));
		}
		case ObjectTypes.StaticFieldReference:
		{
			IType type = AppDomain.GetType(objectAndResolveReference->Value);
			int valueLow = objectAndResolveReference->ValueLow;
			if (type is ILType)
			{
				return ((ILType)type).StaticInstance.Fields[valueLow].Value;
			}
			StackObject stackObject = default(StackObject);
			StackObject* esp2 = &stackObject;
			if (!((CLRType)type).CopyFieldToStack(valueLow, null, this, ref esp2, mStack))
			{
				return (int)((CLRType)type).GetFieldValue(valueLow, null);
			}
			return stackObject.Value;
		}
		default:
			throw new NotImplementedException();
		}
	}

	public unsafe long RetriveInt64(StackObject* esp, UncheckedList<object> mStack)
	{
		StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp);
		if (objectAndResolveReference->ObjectType == ObjectTypes.Null)
		{
			return 0L;
		}
		object obj = null;
		long num = 0L;
		switch (objectAndResolveReference->ObjectType)
		{
		case ObjectTypes.Object:
			return (long)mStack[objectAndResolveReference->Value];
		case ObjectTypes.Long:
			return *(long*)(&objectAndResolveReference->Value);
		case ObjectTypes.FieldReference:
		{
			obj = mStack[objectAndResolveReference->Value];
			int valueLow3 = objectAndResolveReference->ValueLow;
			StackObject stackObject2 = default(StackObject);
			if (obj is ILTypeInstance)
			{
				stackObject2 = ((ILTypeInstance)obj).Fields[valueLow3];
				return *(long*)(&stackObject2.Value);
			}
			IType type2 = AppDomain.GetType(obj.GetType());
			StackObject* esp3 = &stackObject2;
			if (!((CLRType)type2).CopyFieldToStack(valueLow3, obj, this, ref esp3, mStack))
			{
				return (long)((CLRType)type2).GetFieldValue(valueLow3, obj);
			}
			return *(long*)(&stackObject2.Value);
		}
		case ObjectTypes.ArrayReference:
		{
			Array array = mStack[objectAndResolveReference->Value] as Array;
			int valueLow2 = objectAndResolveReference->ValueLow;
			if (array is long[])
			{
				return ((long[])array)[valueLow2];
			}
			return (long)array.GetValue(valueLow2);
		}
		case ObjectTypes.StaticFieldReference:
		{
			IType type = AppDomain.GetType(objectAndResolveReference->Value);
			int valueLow = objectAndResolveReference->ValueLow;
			StackObject stackObject = default(StackObject);
			if (type is ILType)
			{
				stackObject = ((ILType)type).StaticInstance.Fields[valueLow];
				return *(long*)(&stackObject.Value);
			}
			StackObject* esp2 = &stackObject;
			if (!((CLRType)type).CopyFieldToStack(valueLow, null, this, ref esp2, mStack))
			{
				return (long)((CLRType)type).GetFieldValue(valueLow, null);
			}
			return *(long*)(&stackObject.Value);
		}
		default:
			throw new NotImplementedException();
		}
	}

	public unsafe float RetriveFloat(StackObject* esp, UncheckedList<object> mStack)
	{
		StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp);
		if (objectAndResolveReference->ObjectType == ObjectTypes.Null)
		{
			return 0f;
		}
		object obj = null;
		float num = 0f;
		switch (objectAndResolveReference->ObjectType)
		{
		case ObjectTypes.Object:
			return (float)mStack[objectAndResolveReference->Value];
		case ObjectTypes.Float:
			return *(float*)(&objectAndResolveReference->Value);
		case ObjectTypes.FieldReference:
		{
			obj = mStack[objectAndResolveReference->Value];
			int valueLow3 = objectAndResolveReference->ValueLow;
			StackObject stackObject2 = default(StackObject);
			if (obj is ILTypeInstance)
			{
				stackObject2 = ((ILTypeInstance)obj).Fields[valueLow3];
				return *(float*)(&stackObject2.Value);
			}
			IType type2 = AppDomain.GetType(obj.GetType());
			StackObject* esp3 = &stackObject2;
			if (!((CLRType)type2).CopyFieldToStack(valueLow3, obj, this, ref esp3, mStack))
			{
				return (float)((CLRType)type2).GetFieldValue(valueLow3, obj);
			}
			return *(float*)(&stackObject2.Value);
		}
		case ObjectTypes.ArrayReference:
		{
			Array array = mStack[objectAndResolveReference->Value] as Array;
			int valueLow2 = objectAndResolveReference->ValueLow;
			if (array is float[])
			{
				return ((float[])array)[valueLow2];
			}
			return (float)array.GetValue(valueLow2);
		}
		case ObjectTypes.StaticFieldReference:
		{
			IType type = AppDomain.GetType(objectAndResolveReference->Value);
			int valueLow = objectAndResolveReference->ValueLow;
			StackObject stackObject = default(StackObject);
			if (type is ILType)
			{
				stackObject = ((ILType)type).StaticInstance.Fields[valueLow];
				return *(float*)(&stackObject.Value);
			}
			StackObject* esp2 = &stackObject;
			if (!((CLRType)type).CopyFieldToStack(valueLow, null, this, ref esp2, mStack))
			{
				return (float)((CLRType)type).GetFieldValue(valueLow, null);
			}
			return *(float*)(&stackObject.Value);
		}
		default:
			throw new NotImplementedException();
		}
	}

	public unsafe double RetriveDouble(StackObject* esp, UncheckedList<object> mStack)
	{
		StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp);
		if (objectAndResolveReference->ObjectType == ObjectTypes.Null)
		{
			return 0.0;
		}
		object obj = null;
		double num = 0.0;
		switch (objectAndResolveReference->ObjectType)
		{
		case ObjectTypes.Object:
			return (double)mStack[objectAndResolveReference->Value];
		case ObjectTypes.Double:
			return *(double*)(&objectAndResolveReference->Value);
		case ObjectTypes.FieldReference:
		{
			obj = mStack[objectAndResolveReference->Value];
			int valueLow3 = objectAndResolveReference->ValueLow;
			StackObject stackObject2 = default(StackObject);
			if (obj is ILTypeInstance)
			{
				stackObject2 = ((ILTypeInstance)obj).Fields[valueLow3];
				return *(double*)(&stackObject2.Value);
			}
			IType type2 = AppDomain.GetType(obj.GetType());
			StackObject* esp3 = &stackObject2;
			if (!((CLRType)type2).CopyFieldToStack(valueLow3, obj, this, ref esp3, mStack))
			{
				return (double)((CLRType)type2).GetFieldValue(valueLow3, obj);
			}
			return *(double*)(&stackObject2.Value);
		}
		case ObjectTypes.ArrayReference:
		{
			Array array = mStack[objectAndResolveReference->Value] as Array;
			int valueLow2 = objectAndResolveReference->ValueLow;
			if (array is double[])
			{
				return ((double[])array)[valueLow2];
			}
			return (double)array.GetValue(valueLow2);
		}
		case ObjectTypes.StaticFieldReference:
		{
			IType type = AppDomain.GetType(objectAndResolveReference->Value);
			int valueLow = objectAndResolveReference->ValueLow;
			StackObject stackObject = default(StackObject);
			if (type is ILType)
			{
				stackObject = ((ILType)type).StaticInstance.Fields[valueLow];
				return *(double*)(&stackObject.Value);
			}
			StackObject* esp2 = &stackObject;
			if (!((CLRType)type).CopyFieldToStack(valueLow, null, this, ref esp2, mStack))
			{
				return (double)((CLRType)type).GetFieldValue(valueLow, null);
			}
			return *(double*)(&stackObject.Value);
		}
		default:
			throw new NotImplementedException();
		}
	}

	private void ArraySetValue(Array arr, object obj, int idx)
	{
		if (obj == null)
		{
			arr.SetValue(null, idx);
		}
		else
		{
			arr.SetValue(arr.GetType().GetElementType().CheckCLRTypes(obj), idx);
		}
	}

	private unsafe void StoreIntValueToArray(Array arr, StackObject* val, StackObject* idx)
	{
		if (arr is int[] array)
		{
			array[idx->Value] = val->Value;
			return;
		}
		if (arr is short[] array2)
		{
			array2[idx->Value] = (short)val->Value;
			return;
		}
		if (arr is byte[] array3)
		{
			array3[idx->Value] = (byte)val->Value;
			return;
		}
		if (arr is bool[] array4)
		{
			array4[idx->Value] = val->Value == 1;
			return;
		}
		if (arr is uint[] array5)
		{
			array5[idx->Value] = (uint)val->Value;
			return;
		}
		if (arr is ushort[] array6)
		{
			array6[idx->Value] = (ushort)val->Value;
			return;
		}
		if (arr is char[] array7)
		{
			array7[idx->Value] = (char)val->Value;
			return;
		}
		if (arr is sbyte[] array8)
		{
			array8[idx->Value] = (sbyte)val->Value;
			return;
		}
		throw new NotImplementedException();
	}

	private ILRuntime.CLR.Method.ExceptionHandler GetCorrespondingExceptionHandler(ILRuntime.CLR.Method.ExceptionHandler[] eh, object obj, int addr, ILRuntime.CLR.Method.ExceptionHandlerType type, bool explicitMatch)
	{
		ILRuntime.CLR.Method.ExceptionHandler result = null;
		int num = int.MaxValue;
		Exception exception = ((obj is ILRuntimeException) ? ((ILRuntimeException)obj).InnerException : (obj as Exception));
		foreach (ILRuntime.CLR.Method.ExceptionHandler exceptionHandler in eh)
		{
			if (exceptionHandler.HandlerType == type && addr >= exceptionHandler.TryStart && addr <= exceptionHandler.TryEnd && CheckExceptionType(exceptionHandler.CatchType, exception, explicitMatch))
			{
				int num2 = addr - exceptionHandler.TryStart;
				if (num2 < num)
				{
					num = num2;
					result = exceptionHandler;
				}
			}
		}
		return result;
	}

	private unsafe void LoadFromFieldReference(object obj, int idx, StackObject* dst, UncheckedList<object> mStack)
	{
		if (obj is ILTypeInstance)
		{
			((ILTypeInstance)obj).PushToStack(idx, dst, this, mStack);
			return;
		}
		CLRType cLRType = AppDomain.GetType(obj.GetType()) as CLRType;
		if (!cLRType.CopyFieldToStack(idx, obj, this, ref dst, mStack))
		{
			PushObject(dst, mStack, cLRType.GetFieldValue(idx, obj));
		}
	}

	private unsafe void StoreValueToFieldReference(ref object obj, int idx, StackObject* val, UncheckedList<object> mStack)
	{
		if (obj is ILTypeInstance)
		{
			((ILTypeInstance)obj).AssignFromStack(idx, val, AppDomain, mStack);
			return;
		}
		CLRType obj2 = AppDomain.GetType(obj.GetType()) as CLRType;
		object value = obj.GetType().CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(val, AppDomain, mStack), AppDomain));
		obj2.SetFieldValue(idx, ref obj, value, directSet: true);
	}

	private unsafe void LoadFromArrayReference(object obj, int idx, StackObject* objRef, IType t, UncheckedList<object> mStack, int managedIdx = -1)
	{
		Type typeForCLR = t.TypeForCLR;
		LoadFromArrayReference(obj, idx, objRef, typeForCLR, mStack, managedIdx);
	}

	private unsafe void LoadFromArrayReference(object obj, int idx, StackObject* objRef, Type nT, UncheckedList<object> mStack, int managedIdx = -1)
	{
		if (nT.IsPrimitive)
		{
			if (nT == typeof(int))
			{
				int[] array = obj as int[];
				objRef->ObjectType = ObjectTypes.Integer;
				objRef->Value = array[idx];
				objRef->ValueLow = 0;
				return;
			}
			if (nT == typeof(short))
			{
				short[] array2 = obj as short[];
				objRef->ObjectType = ObjectTypes.Integer;
				objRef->Value = array2[idx];
				objRef->ValueLow = 0;
				return;
			}
			if (nT == typeof(long))
			{
				long[] array3 = obj as long[];
				objRef->ObjectType = ObjectTypes.Long;
				*(long*)(&objRef->Value) = array3[idx];
				return;
			}
			if (nT == typeof(float))
			{
				float[] array4 = obj as float[];
				objRef->ObjectType = ObjectTypes.Float;
				*(float*)(&objRef->Value) = array4[idx];
				objRef->ValueLow = 0;
				return;
			}
			if (nT == typeof(double))
			{
				double[] array5 = obj as double[];
				objRef->ObjectType = ObjectTypes.Double;
				*(double*)(&objRef->Value) = array5[idx];
				return;
			}
			if (nT == typeof(byte))
			{
				byte[] array6 = obj as byte[];
				objRef->ObjectType = ObjectTypes.Integer;
				objRef->Value = array6[idx];
				objRef->ValueLow = 0;
				return;
			}
			if (nT == typeof(char))
			{
				char[] array7 = obj as char[];
				objRef->ObjectType = ObjectTypes.Integer;
				objRef->Value = array7[idx];
				objRef->ValueLow = 0;
				return;
			}
			if (nT == typeof(uint))
			{
				uint[] array8 = obj as uint[];
				objRef->ObjectType = ObjectTypes.Integer;
				objRef->Value = (int)array8[idx];
				objRef->ValueLow = 0;
				return;
			}
			if (nT == typeof(sbyte))
			{
				sbyte[] array9 = obj as sbyte[];
				objRef->ObjectType = ObjectTypes.Integer;
				objRef->Value = array9[idx];
				objRef->ValueLow = 0;
				return;
			}
			if (!(nT == typeof(ulong)))
			{
				throw new NotImplementedException();
			}
			ulong[] array10 = obj as ulong[];
			objRef->ObjectType = ObjectTypes.Long;
			*(ulong*)(&objRef->Value) = array10[idx];
		}
		else
		{
			Array array11 = obj as Array;
			objRef->ObjectType = ObjectTypes.Object;
			if (managedIdx >= 0)
			{
				objRef->Value = managedIdx;
				mStack[managedIdx] = array11.GetValue(idx);
			}
			else
			{
				objRef->Value = mStack.Count;
				mStack.Add(array11.GetValue(idx));
			}
			objRef->ValueLow = 0;
		}
	}

	private unsafe void StoreValueToArrayReference(StackObject* objRef, StackObject* val, IType t, UncheckedList<object> mStack)
	{
		Type typeForCLR = t.TypeForCLR;
		StoreValueToArrayReference(objRef, val, typeForCLR, mStack);
	}

	private unsafe void StoreValueToArrayReference(StackObject* objRef, StackObject* val, Type nT, UncheckedList<object> mStack)
	{
		if (nT.IsPrimitive)
		{
			if (nT == typeof(int))
			{
				(mStack[objRef->Value] as int[])[objRef->ValueLow] = val->Value;
				return;
			}
			if (nT == typeof(short))
			{
				(mStack[objRef->Value] as short[])[objRef->ValueLow] = (short)val->Value;
				return;
			}
			if (nT == typeof(long))
			{
				(mStack[objRef->Value] as long[])[objRef->ValueLow] = *(long*)(&val->Value);
				return;
			}
			if (nT == typeof(float))
			{
				(mStack[objRef->Value] as float[])[objRef->ValueLow] = *(float*)(&val->Value);
				return;
			}
			if (nT == typeof(double))
			{
				(mStack[objRef->Value] as double[])[objRef->ValueLow] = *(double*)(&val->Value);
				return;
			}
			if (nT == typeof(byte))
			{
				(mStack[objRef->Value] as byte[])[objRef->ValueLow] = (byte)val->Value;
				return;
			}
			if (nT == typeof(char))
			{
				(mStack[objRef->Value] as char[])[objRef->ValueLow] = (char)val->Value;
				return;
			}
			if (nT == typeof(uint))
			{
				(mStack[objRef->Value] as uint[])[objRef->ValueLow] = (uint)val->Value;
				return;
			}
			if (!(nT == typeof(sbyte)))
			{
				throw new NotImplementedException();
			}
			(mStack[objRef->Value] as sbyte[])[objRef->ValueLow] = (sbyte)val->Value;
		}
		else
		{
			(mStack[objRef->Value] as Array).SetValue(StackObject.ToObject(val, domain, mStack), objRef->ValueLow);
		}
	}

	private bool CheckExceptionType(IType catchType, object exception, bool explicitMatch)
	{
		if (catchType == null)
		{
			return true;
		}
		if (catchType is CLRType)
		{
			if (explicitMatch)
			{
				return exception.GetType() == catchType.TypeForCLR;
			}
			return catchType.TypeForCLR.IsAssignableFrom(exception.GetType());
		}
		throw new NotImplementedException();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static StackObject* ResolveReference(StackObject* esp)
	{
		return (StackObject*)(*(ulong*)(&esp->Value));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static StackObject* GetObjectAndResolveReference(StackObject* esp)
	{
		if (esp->ObjectType == ObjectTypes.StackObjectReference)
		{
			return ResolveReference(esp);
		}
		return esp;
	}

	private unsafe StackObject* PushParameters(IMethod method, StackObject* esp, object[] p, bool useRegister)
	{
		UncheckedList<object> managedStack = stack.ManagedStack;
		List<IType> parameters = method.Parameters;
		int num = parameters?.Count ?? 0;
		int num2 = ((p != null) ? p.Length : 0);
		if (num != num2)
		{
			throw new ArgumentOutOfRangeException("Parameter mismatch");
		}
		if (num2 > 0)
		{
			for (int i = 0; i < p.Length; i++)
			{
				bool isBox = false;
				if (parameters != null && i < parameters.Count)
				{
					isBox = parameters[i] == AppDomain.ObjectType;
				}
				object obj = p[i];
				if (obj is CrossBindingAdaptorType)
				{
					obj = ((CrossBindingAdaptorType)obj).ILInstance;
				}
				StackObject* intPtr = PushObject(esp, managedStack, obj, isBox);
				if (esp->ObjectType < ObjectTypes.Object && useRegister)
				{
					managedStack.Add(null);
				}
				esp = intPtr;
			}
		}
		return esp;
	}

	public unsafe void CopyToStack(StackObject* dst, StackObject* src, UncheckedList<object> mStack)
	{
		CopyToStack(dst, src, mStack, mStack);
	}

	private unsafe void CopyToStack(StackObject* dst, StackObject* src, UncheckedList<object> mStack, UncheckedList<object> dstmStack)
	{
		if (src->ObjectType == ObjectTypes.ValueTypeObjectReference)
		{
			StackObject* ptr = ResolveReference(src);
			IType typeByIndex = domain.GetTypeByIndex(ptr->Value);
			AllocValueType(dst, typeByIndex);
			CopyStackValueType(src, dst, mStack, dstmStack);
			return;
		}
		*dst = *src;
		if (dst->ObjectType >= ObjectTypes.Object)
		{
			dst->Value = dstmStack.Count;
			object item = mStack[src->Value];
			dstmStack.Add(item);
		}
	}

	internal static object CheckAndCloneValueType(object obj, ILRuntime.Runtime.Enviorment.AppDomain domain)
	{
		if (obj != null)
		{
			if (obj is ILTypeInstance)
			{
				ILTypeInstance iLTypeInstance = obj as ILTypeInstance;
				if (iLTypeInstance.IsValueType)
				{
					return iLTypeInstance.Clone();
				}
			}
			else
			{
				Type type = obj.GetType();
				ILRuntime.CLR.Utils.Extensions.TypeFlags typeFlags = type.GetTypeFlags();
				bool flag = (typeFlags & ILRuntime.CLR.Utils.Extensions.TypeFlags.IsPrimitive) != 0;
				bool flag2 = (typeFlags & ILRuntime.CLR.Utils.Extensions.TypeFlags.IsValueType) != 0;
				if (!flag && flag2)
				{
					return ((CLRType)domain.GetType(type)).PerformMemberwiseClone(obj);
				}
			}
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static StackObject* PushOne(StackObject* esp)
	{
		esp->ObjectType = ObjectTypes.Integer;
		esp->Value = 1;
		return esp + 1;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static StackObject* PushZero(StackObject* esp)
	{
		esp->ObjectType = ObjectTypes.Integer;
		esp->Value = 0;
		return esp + 1;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static StackObject* PushNull(StackObject* esp)
	{
		esp->ObjectType = ObjectTypes.Null;
		esp->Value = -1;
		esp->ValueLow = 0;
		return esp + 1;
	}

	[Obsolete]
	public unsafe static void UnboxObject(StackObject* esp, object obj, IList<object> mStack = null, ILRuntime.Runtime.Enviorment.AppDomain domain = null)
	{
		UnboxObject(esp, obj, (UncheckedList<object>)mStack, domain);
	}

	public unsafe static void UnboxObject(StackObject* esp, object obj, UncheckedList<object> mStack = null, ILRuntime.Runtime.Enviorment.AppDomain domain = null)
	{
		if (esp->ObjectType == ObjectTypes.ValueTypeObjectReference && domain != null)
		{
			StackObject* ptr = ResolveReference(esp);
			IType typeByIndex = domain.GetTypeByIndex(ptr->Value);
			if (obj != null)
			{
				if (obj is ILTypeInstance)
				{
					((ILTypeInstance)obj).CopyValueTypeToStack(ptr, mStack);
				}
				else if (obj is CrossBindingAdaptorType)
				{
					((CrossBindingAdaptorType)obj).ILInstance.CopyValueTypeToStack(ptr, mStack);
				}
				else
				{
					((CLRType)typeByIndex).ValueTypeBinder.CopyValueTypeToStack(obj, ptr, mStack);
				}
			}
		}
		else
		{
			if (obj == null)
			{
				return;
			}
			if (obj is int)
			{
				esp->ObjectType = ObjectTypes.Integer;
				esp->Value = (int)obj;
				return;
			}
			if (obj is bool)
			{
				esp->ObjectType = ObjectTypes.Integer;
				esp->Value = (((bool)obj) ? 1 : 0);
				return;
			}
			if (obj is short)
			{
				esp->ObjectType = ObjectTypes.Integer;
				esp->Value = (short)obj;
				return;
			}
			if (obj is long)
			{
				esp->ObjectType = ObjectTypes.Long;
				*(long*)(&esp->Value) = (long)obj;
				return;
			}
			if (obj is float)
			{
				esp->ObjectType = ObjectTypes.Float;
				*(float*)(&esp->Value) = (float)obj;
				return;
			}
			if (obj is byte)
			{
				esp->ObjectType = ObjectTypes.Integer;
				esp->Value = (byte)obj;
				return;
			}
			if (obj is uint)
			{
				esp->ObjectType = ObjectTypes.Integer;
				esp->Value = (int)(uint)obj;
				return;
			}
			if (obj is ushort)
			{
				esp->ObjectType = ObjectTypes.Integer;
				esp->Value = (ushort)obj;
				return;
			}
			if (obj is char)
			{
				esp->ObjectType = ObjectTypes.Integer;
				esp->Value = (char)obj;
				return;
			}
			if (obj is double)
			{
				esp->ObjectType = ObjectTypes.Double;
				*(double*)(&esp->Value) = (double)obj;
				return;
			}
			if (obj is ulong)
			{
				esp->ObjectType = ObjectTypes.Long;
				*(ulong*)(&esp->Value) = (ulong)obj;
				return;
			}
			if (obj is sbyte)
			{
				esp->ObjectType = ObjectTypes.Integer;
				esp->Value = (sbyte)obj;
				return;
			}
			if (!(obj is Enum))
			{
				throw new NotImplementedException();
			}
			esp->ObjectType = ObjectTypes.Integer;
			esp->Value = Convert.ToInt32(obj);
		}
	}

	[Obsolete]
	public unsafe static StackObject* PushObject(StackObject* esp, IList<object> mStack, object obj, bool isBox = false)
	{
		return PushObject(esp, (UncheckedList<object>)mStack, obj, isBox);
	}

	public unsafe static StackObject* PushObject(StackObject* esp, UncheckedList<object> mStack, object obj, bool isBox = false)
	{
		if (obj != null)
		{
			if (!isBox)
			{
				ILRuntime.CLR.Utils.Extensions.TypeFlags typeFlags = obj.GetType().GetTypeFlags();
				if ((typeFlags & ILRuntime.CLR.Utils.Extensions.TypeFlags.IsPrimitive) != ILRuntime.CLR.Utils.Extensions.TypeFlags.Default)
				{
					UnboxObject(esp, obj, mStack);
				}
				else if ((typeFlags & ILRuntime.CLR.Utils.Extensions.TypeFlags.IsEnum) != ILRuntime.CLR.Utils.Extensions.TypeFlags.Default)
				{
					esp->ObjectType = ObjectTypes.Integer;
					esp->Value = Convert.ToInt32(obj);
				}
				else
				{
					esp->ObjectType = ObjectTypes.Object;
					esp->Value = mStack.Count;
					mStack.Add(obj);
				}
			}
			else
			{
				esp->ObjectType = ObjectTypes.Object;
				esp->Value = mStack.Count;
				mStack.Add(obj);
			}
		}
		else
		{
			if (!isBox)
			{
				return PushNull(esp);
			}
			esp->ObjectType = ObjectTypes.Object;
			esp->Value = mStack.Count;
			mStack.Add(obj);
		}
		return esp + 1;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static StackObject* Add(StackObject* a, int b)
	{
		return (StackObject*)((ulong)a + (ulong)(sizeof(StackObject) * b));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static StackObject* Minus(StackObject* a, int b)
	{
		return (StackObject*)((ulong)a - (ulong)(sizeof(StackObject) * b));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe void Free(StackObject* esp)
	{
		switch (esp->ObjectType)
		{
		case ObjectTypes.Object:
		case ObjectTypes.FieldReference:
		case ObjectTypes.ArrayReference:
		{
			UncheckedList<object> managedStack = stack.ManagedStack;
			if (esp->Value == managedStack.Count - 1)
			{
				managedStack.RemoveAt(esp->Value);
			}
			break;
		}
		case ObjectTypes.ValueTypeObjectReference:
			FreeStackValueType(esp);
			break;
		}
	}

	public unsafe void FreeStackValueType(StackObject* esp)
	{
		if (esp->ObjectType == ObjectTypes.ValueTypeObjectReference)
		{
			if (ResolveReference(esp) <= ValueTypeBasePointer)
			{
				stack.FreeValueTypeObject(esp);
			}
			esp->ObjectType = ObjectTypes.Null;
		}
	}

	public unsafe void AllocValueType(StackObject* ptr, IType type)
	{
		stack.AllocValueType(ptr, type);
	}

	internal unsafe StackObject* ExecuteR(ILMethod method, StackObject* esp, out bool unhandledException)
	{
		OpCodeR[] bodyRegister = method.BodyRegister;
		stack.InitializeFrame(method, esp, out var res);
		res.IsRegister = true;
		int num = 0;
		Exception ex = null;
		StackObject* localVarPointer = res.LocalVarPointer;
		StackObject* ptr = res.LocalVarPointer - method.ParameterCount;
		UncheckedList<object> managedStack = stack.ManagedStack;
		int num2 = method.ParameterCount;
		if (method.HasThis)
		{
			ptr--;
			num2++;
		}
		unhandledException = false;
		bool flag = method.ReturnType != AppDomain.VoidType;
		for (int i = 0; i < num2; i++)
		{
			StackObject* ptr2 = ptr + i;
			ObjectTypes objectType = ptr2->ObjectType;
			if (objectType != ObjectTypes.ValueTypeObjectReference && (uint)(objectType - 9) <= 2u && (i > 0 || !method.HasThis))
			{
				managedStack[ptr2->Value] = CheckAndCloneValueType(managedStack[ptr2->Value], AppDomain);
			}
		}
		res.ManagedStackBase -= num2;
		stack.PushFrame(ref res);
		int count = managedStack.Count;
		int localVariableCount = method.LocalVariableCount;
		int stackRegisterCount = method.StackRegisterCount;
		RegisterFrameInfo info = default(RegisterFrameInfo);
		info.Intepreter = this;
		info.StackBase = stack.StackBase;
		info.LocalManagedBase = count;
		info.FrameManagedBase = res.ManagedStackBase;
		info.RegisterStart = ptr;
		info.StackRegisterStart = localVarPointer + localVariableCount;
		info.ManagedStack = managedStack;
		esp = localVarPointer + stackRegisterCount + localVariableCount;
		info.RegisterEnd = esp;
		for (int j = 0; j < stackRegisterCount + localVariableCount; j++)
		{
			StackObject* num3 = localVarPointer + j;
			num3->ObjectType = ObjectTypes.Object;
			num3->Value = managedStack.Count;
			managedStack.Add(null);
		}
		StackObject* valueTypeBasePointer = (ValueTypeBasePointer = stack.ValueTypeStackPointer);
		ILRuntime.CLR.Method.ExceptionHandler[] exceptionHandlerRegister = method.ExceptionHandlerRegister;
		int num4 = 0;
		long num5 = 0L;
		float num6 = 0f;
		double num7 = 0.0;
		fixed (OpCodeR* ptr3 = bodyRegister)
		{
			OpCodeR* ptr4 = ptr3;
			OpCodeREnum code = ptr4->Code;
			bool flag2 = false;
			while (!flag2)
			{
				try
				{
					code = ptr4->Code;
					switch (code)
					{
					case OpCodeREnum.Ldarga_S:
					case OpCodeREnum.Ldarga:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						ptr6->ObjectType = ObjectTypes.StackObjectReference;
						*(long*)(&ptr6->Value) = (long)ptr5;
						break;
					}
					case OpCodeREnum.Ldc_I4_M1:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = -1;
						break;
					}
					case OpCodeREnum.Ldc_I4_0:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = 0;
						break;
					}
					case OpCodeREnum.Ldc_I4_1:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = 1;
						break;
					}
					case OpCodeREnum.Ldc_I4_2:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = 2;
						break;
					}
					case OpCodeREnum.Ldc_I4_3:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = 3;
						break;
					}
					case OpCodeREnum.Ldc_I4_4:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = 4;
						break;
					}
					case OpCodeREnum.Ldc_I4_5:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = 5;
						break;
					}
					case OpCodeREnum.Ldc_I4_6:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = 6;
						break;
					}
					case OpCodeREnum.Ldc_I4_7:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = 7;
						break;
					}
					case OpCodeREnum.Ldc_I4_8:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = 8;
						break;
					}
					case OpCodeREnum.Ldc_I4_S:
					case OpCodeREnum.Ldc_I4:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = ptr4->Operand;
						break;
					}
					case OpCodeREnum.Ldc_R4:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						*(float*)(&ptr5->Value) = ptr4->OperandFloat;
						ptr5->ObjectType = ObjectTypes.Float;
						break;
					}
					case OpCodeREnum.Ldc_I8:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						*(long*)(&ptr5->Value) = ptr4->OperandLong;
						ptr5->ObjectType = ObjectTypes.Long;
						break;
					}
					case OpCodeREnum.Ldc_R8:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						*(double*)(&ptr5->Value) = ptr4->OperandDouble;
						ptr5->ObjectType = ObjectTypes.Double;
						break;
					}
					case OpCodeREnum.Ldstr:
						AssignToRegister(ref info, ptr4->Register1, AppDomain.GetString(ptr4->OperandLong));
						break;
					case OpCodeREnum.Ldnull:
						AssignToRegister(ref info, ptr4->Register1, null, isBox: true);
						break;
					case OpCodeREnum.Add:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) + *(long*)(&ptr6->Value);
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value + ptr6->Value;
							break;
						case ObjectTypes.Float:
							ptr7->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr7->Value) = *(float*)(&ptr5->Value) + *(float*)(&ptr6->Value);
							break;
						case ObjectTypes.Double:
							ptr7->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr7->Value) = *(double*)(&ptr5->Value) + *(double*)(&ptr6->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Addi:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) + ptr4->OperandLong;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value + ptr4->Operand;
							break;
						case ObjectTypes.Float:
							ptr7->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr7->Value) = *(float*)(&ptr5->Value) + ptr4->OperandFloat;
							break;
						case ObjectTypes.Double:
							ptr7->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr7->Value) = *(double*)(&ptr5->Value) + ptr4->OperandDouble;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Sub:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) - *(long*)(&ptr6->Value);
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value - ptr6->Value;
							break;
						case ObjectTypes.Float:
							ptr7->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr7->Value) = *(float*)(&ptr5->Value) - *(float*)(&ptr6->Value);
							break;
						case ObjectTypes.Double:
							ptr7->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr7->Value) = *(double*)(&ptr5->Value) - *(double*)(&ptr6->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Subi:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) - ptr4->OperandLong;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value - ptr4->Operand;
							break;
						case ObjectTypes.Float:
							ptr7->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr7->Value) = *(float*)(&ptr5->Value) - ptr4->OperandFloat;
							break;
						case ObjectTypes.Double:
							ptr7->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr7->Value) = *(double*)(&ptr5->Value) - ptr4->OperandDouble;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Mul:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) * *(long*)(&ptr6->Value);
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value * ptr6->Value;
							break;
						case ObjectTypes.Float:
							ptr7->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr7->Value) = *(float*)(&ptr5->Value) * *(float*)(&ptr6->Value);
							break;
						case ObjectTypes.Double:
							ptr7->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr7->Value) = *(double*)(&ptr5->Value) * *(double*)(&ptr6->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Muli:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) * ptr4->OperandLong;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value * ptr4->Operand;
							break;
						case ObjectTypes.Float:
							ptr7->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr7->Value) = *(float*)(&ptr5->Value) * ptr4->OperandFloat;
							break;
						case ObjectTypes.Double:
							ptr7->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr7->Value) = *(double*)(&ptr5->Value) * ptr4->OperandDouble;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Div:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) / *(long*)(&ptr6->Value);
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value / ptr6->Value;
							break;
						case ObjectTypes.Float:
							ptr7->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr7->Value) = *(float*)(&ptr5->Value) / *(float*)(&ptr6->Value);
							break;
						case ObjectTypes.Double:
							ptr7->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr7->Value) = *(double*)(&ptr5->Value) / *(double*)(&ptr6->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Divi:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) / ptr4->OperandLong;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value / ptr4->Operand;
							break;
						case ObjectTypes.Float:
							ptr7->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr7->Value) = *(float*)(&ptr5->Value) / ptr4->OperandFloat;
							break;
						case ObjectTypes.Double:
							ptr7->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr7->Value) = *(double*)(&ptr5->Value) / ptr4->OperandDouble;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Div_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(ulong*)(&ptr7->Value) = (ulong)(*(long*)(&ptr5->Value)) / (ulong)(*(long*)(&ptr6->Value));
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = (int)((uint)ptr5->Value / (uint)ptr6->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Divi_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(ulong*)(&ptr7->Value) = (ulong)(*(long*)(&ptr5->Value)) / (ulong)ptr4->OperandLong;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = (int)((uint)ptr5->Value / (uint)ptr4->Operand);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Rem:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) % *(long*)(&ptr6->Value);
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value % ptr6->Value;
							break;
						case ObjectTypes.Float:
							ptr7->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr7->Value) = *(float*)(&ptr5->Value) % *(float*)(&ptr6->Value);
							break;
						case ObjectTypes.Double:
							ptr7->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr7->Value) = *(double*)(&ptr5->Value) % *(double*)(&ptr6->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Remi:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) % ptr4->OperandLong;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value % ptr4->Operand;
							break;
						case ObjectTypes.Float:
							ptr7->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr7->Value) = *(float*)(&ptr5->Value) % ptr4->OperandFloat;
							break;
						case ObjectTypes.Double:
							ptr7->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr7->Value) = *(double*)(&ptr5->Value) % ptr4->OperandDouble;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Rem_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(ulong*)(&ptr7->Value) = (ulong)(*(long*)(&ptr5->Value)) % (ulong)(*(long*)(&ptr6->Value));
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = (int)((uint)ptr5->Value % (uint)ptr6->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Remi_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(ulong*)(&ptr7->Value) = (ulong)(*(long*)(&ptr5->Value)) % (ulong)ptr4->OperandLong;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = (int)((uint)ptr5->Value % (uint)ptr4->Operand);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Xor:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) ^ *(long*)(&ptr6->Value);
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value ^ ptr6->Value;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Xori:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) ^ ptr4->OperandLong;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value ^ ptr4->Operand;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.And:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) & *(long*)(&ptr6->Value);
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value & ptr6->Value;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Andi:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) & ptr4->OperandLong;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value & ptr4->Operand;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Or:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) | *(long*)(&ptr6->Value);
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value | ptr6->Value;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Ori:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) | ptr4->OperandLong;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value | ptr4->Operand;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Shl:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) << ptr6->Value;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value << ptr6->Value;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Shli:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) << ptr4->Operand;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value << ptr4->Operand;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Shr:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) >> ptr6->Value;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value >> ptr6->Value;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Shri:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) >> ptr4->Operand;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value >> ptr4->Operand;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Shr_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) >>> ptr6->Value;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value >>> ptr6->Value;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Shri_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = *(long*)(&ptr5->Value) >>> ptr4->Operand;
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ptr5->Value >>> ptr4->Operand;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Not:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = ~(*(long*)(&ptr5->Value));
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = ~ptr5->Value;
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Neg:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							ptr7->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr7->Value) = -(*(long*)(&ptr5->Value));
							break;
						case ObjectTypes.Integer:
							ptr7->ObjectType = ObjectTypes.Integer;
							ptr7->Value = -ptr5->Value;
							break;
						case ObjectTypes.Float:
							ptr7->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr7->Value) = 0f - *(float*)(&ptr5->Value);
							break;
						case ObjectTypes.Double:
							ptr7->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr7->Value) = 0.0 - *(double*)(&ptr5->Value);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Conv_Ovf_U1_Un:
					case OpCodeREnum.Conv_Ovf_U1:
					case OpCodeREnum.Conv_U1:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Integer:
						case ObjectTypes.Long:
							num4 = (byte)ptr5->Value;
							break;
						case ObjectTypes.Float:
							num4 = (byte)(*(float*)(&ptr5->Value));
							break;
						case ObjectTypes.Double:
							num4 = (byte)(*(double*)(&ptr5->Value));
							break;
						default:
							throw new NotImplementedException();
						}
						ptr6->ObjectType = ObjectTypes.Integer;
						ptr6->Value = num4;
						ptr6->ValueLow = 0;
						break;
					}
					case OpCodeREnum.Conv_I1:
					case OpCodeREnum.Conv_Ovf_I1_Un:
					case OpCodeREnum.Conv_Ovf_I1:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Integer:
						case ObjectTypes.Long:
							num4 = (sbyte)ptr5->Value;
							break;
						case ObjectTypes.Float:
							num4 = (sbyte)(*(float*)(&ptr5->Value));
							break;
						case ObjectTypes.Double:
							num4 = (sbyte)(*(double*)(&ptr5->Value));
							break;
						default:
							throw new NotImplementedException();
						}
						ptr6->ObjectType = ObjectTypes.Integer;
						ptr6->Value = num4;
						ptr6->ValueLow = 0;
						break;
					}
					case OpCodeREnum.Conv_Ovf_U2_Un:
					case OpCodeREnum.Conv_Ovf_U2:
					case OpCodeREnum.Conv_U2:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Integer:
						case ObjectTypes.Long:
							num4 = (ushort)ptr5->Value;
							break;
						case ObjectTypes.Float:
							num4 = (ushort)(*(float*)(&ptr5->Value));
							break;
						case ObjectTypes.Double:
							num4 = (ushort)(*(double*)(&ptr5->Value));
							break;
						default:
							throw new NotImplementedException();
						}
						ptr6->ObjectType = ObjectTypes.Integer;
						ptr6->Value = num4;
						ptr6->ValueLow = 0;
						break;
					}
					case OpCodeREnum.Conv_I2:
					case OpCodeREnum.Conv_Ovf_I2_Un:
					case OpCodeREnum.Conv_Ovf_I2:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Integer:
						case ObjectTypes.Long:
							num4 = (short)ptr5->Value;
							break;
						case ObjectTypes.Float:
							num4 = (short)(*(float*)(&ptr5->Value));
							break;
						case ObjectTypes.Double:
							num4 = (short)(*(double*)(&ptr5->Value));
							break;
						default:
							throw new NotImplementedException();
						}
						ptr6->ObjectType = ObjectTypes.Integer;
						ptr6->Value = num4;
						ptr6->ValueLow = 0;
						break;
					}
					case OpCodeREnum.Conv_U4:
					case OpCodeREnum.Conv_Ovf_U4_Un:
					case OpCodeREnum.Conv_Ovf_U4:
					case OpCodeREnum.Conv_U:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						uint value10 = ptr5->ObjectType switch
						{
							ObjectTypes.Long => (uint)(*(ulong*)(&ptr5->Value)), 
							ObjectTypes.Integer => (uint)ptr5->Value, 
							ObjectTypes.Float => (uint)(*(float*)(&ptr5->Value)), 
							ObjectTypes.Double => (uint)(*(double*)(&ptr5->Value)), 
							_ => throw new NotImplementedException(), 
						};
						ptr6->ObjectType = ObjectTypes.Integer;
						ptr6->Value = (int)value10;
						ptr6->ValueLow = 0;
						break;
					}
					case OpCodeREnum.Conv_I4:
					case OpCodeREnum.Conv_Ovf_I4_Un:
					case OpCodeREnum.Conv_Ovf_I_Un:
					case OpCodeREnum.Conv_Ovf_I4:
					case OpCodeREnum.Conv_I:
					case OpCodeREnum.Conv_Ovf_I:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						num4 = ptr5->ObjectType switch
						{
							ObjectTypes.Long => (int)(*(long*)(&ptr5->Value)), 
							ObjectTypes.Float => (int)(*(float*)(&ptr5->Value)), 
							ObjectTypes.Double => (int)(*(double*)(&ptr5->Value)), 
							ObjectTypes.Integer => ptr5->Value, 
							_ => throw new NotImplementedException(), 
						};
						ptr6->ObjectType = ObjectTypes.Integer;
						ptr6->Value = num4;
						break;
					}
					case OpCodeREnum.Conv_I8:
					case OpCodeREnum.Conv_Ovf_I8_Un:
					case OpCodeREnum.Conv_Ovf_I8:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						num5 = ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ptr5->Value, 
							ObjectTypes.Long => *(long*)(&ptr5->Value), 
							ObjectTypes.Float => (long)(*(float*)(&ptr5->Value)), 
							ObjectTypes.Double => (long)(*(double*)(&ptr5->Value)), 
							_ => throw new NotImplementedException(), 
						};
						ptr6->ObjectType = ObjectTypes.Long;
						*(long*)(&ptr6->Value) = num5;
						break;
					}
					case OpCodeREnum.Conv_U8:
					case OpCodeREnum.Conv_Ovf_U8_Un:
					case OpCodeREnum.Conv_Ovf_U8:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						ulong num9 = ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (uint)ptr5->Value, 
							ObjectTypes.Long => *(ulong*)(&ptr5->Value), 
							ObjectTypes.Float => (ulong)(*(float*)(&ptr5->Value)), 
							ObjectTypes.Double => (ulong)(*(double*)(&ptr5->Value)), 
							_ => throw new NotImplementedException(), 
						};
						ptr6->ObjectType = ObjectTypes.Long;
						*(ulong*)(&ptr6->Value) = num9;
						break;
					}
					case OpCodeREnum.Conv_R4:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						num6 = ptr5->ObjectType switch
						{
							ObjectTypes.Long => *(long*)(&ptr5->Value), 
							ObjectTypes.Float => *(float*)(&ptr5->Value), 
							ObjectTypes.Double => (float)(*(double*)(&ptr5->Value)), 
							ObjectTypes.Integer => ptr5->Value, 
							_ => throw new NotImplementedException(), 
						};
						ptr6->ObjectType = ObjectTypes.Float;
						*(float*)(&ptr6->Value) = num6;
						break;
					}
					case OpCodeREnum.Conv_R8:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						num7 = ptr5->ObjectType switch
						{
							ObjectTypes.Long => *(long*)(&ptr5->Value), 
							ObjectTypes.Float => *(float*)(&ptr5->Value), 
							ObjectTypes.Integer => ptr5->Value, 
							ObjectTypes.Double => *(double*)(&ptr5->Value), 
							_ => throw new NotImplementedException(), 
						};
						ptr6->ObjectType = ObjectTypes.Double;
						*(double*)(&ptr6->Value) = num7;
						break;
					}
					case OpCodeREnum.Conv_R_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						bool flag14 = false;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Long:
							num7 = *(ulong*)(&ptr5->Value);
							flag14 = true;
							break;
						case ObjectTypes.Float:
							num6 = *(float*)(&ptr5->Value);
							break;
						case ObjectTypes.Integer:
							num6 = (uint)ptr5->Value;
							break;
						case ObjectTypes.Double:
							num7 = *(double*)(&ptr5->Value);
							flag14 = true;
							break;
						default:
							throw new NotImplementedException();
						}
						if (flag14)
						{
							ptr6->ObjectType = ObjectTypes.Double;
							*(double*)(&ptr6->Value) = num7;
						}
						else
						{
							ptr6->ObjectType = ObjectTypes.Float;
							*(float*)(&ptr6->Value) = num6;
						}
						break;
					}
					case OpCodeREnum.Move:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						CopyToRegister(ref info, ptr4->Register1, ptr5);
						break;
					}
					case OpCodeREnum.Push:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						CopyToStack(esp, ptr5, managedStack);
						if (ptr4->Operand == 1)
						{
							managedStack.Add(null);
						}
						esp++;
						break;
					}
					case OpCodeREnum.Ldloca_S:
					case OpCodeREnum.Ldloca:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						ptr6->ObjectType = ObjectTypes.StackObjectReference;
						*(long*)(&ptr6->Value) = (long)ptr5;
						break;
					}
					case OpCodeREnum.Ldobj:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.ArrayReference:
						{
							IType type4 = AppDomain.GetType(ptr4->Operand);
							object obj = managedStack[ptr5->Value];
							int valueLow14 = ptr5->ValueLow;
							num4 = GetManagedStackIndex(ref info, ptr4->Register1);
							LoadFromArrayReference(obj, valueLow14, ptr6, type4, managedStack, num4);
							break;
						}
						case ObjectTypes.StackObjectReference:
							CopyToRegister(ref info, ptr4->Register1, GetObjectAndResolveReference(ptr5));
							break;
						case ObjectTypes.FieldReference:
						{
							object obj = managedStack[ptr5->Value];
							int valueLow15 = ptr5->ValueLow;
							if (obj is ILTypeInstance)
							{
								((ILTypeInstance)obj).CopyToRegister(valueLow15, ref info, ptr4->Register1);
								break;
							}
							IType type = AppDomain.GetType(ptr4->Operand);
							if (!((CLRType)type).CopyFieldToStack(valueLow15, obj, this, ref esp, managedStack))
							{
								obj = ((CLRType)type).GetFieldValue(valueLow15, obj);
								AssignToRegister(ref info, ptr4->Register1, obj);
							}
							else
							{
								esp = PopToRegister(ref info, ptr4->Register1, esp);
							}
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type = AppDomain.GetType(ptr5->Value);
							int valueLow13 = ptr5->ValueLow;
							if (type is ILType)
							{
								((ILType)type).StaticInstance.CopyToRegister(valueLow13, ref info, ptr4->Register1);
							}
							else if (!((CLRType)type).CopyFieldToStack(valueLow13, null, this, ref esp, managedStack))
							{
								object obj = ((CLRType)type).GetFieldValue(valueLow13, null);
								AssignToRegister(ref info, ptr4->Register1, obj);
							}
							else
							{
								esp = PopToRegister(ref info, ptr4->Register1, esp);
							}
							break;
						}
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Stobj:
					{
						StackObject* ptr11 = ptr + ptr4->Register2;
						StackObject* objectAndResolveReference = ptr + ptr4->Register1;
						switch (objectAndResolveReference->ObjectType)
						{
						case ObjectTypes.ArrayReference:
						{
							IType type7 = AppDomain.GetType(ptr4->Operand);
							StoreValueToArrayReference(objectAndResolveReference, ptr11, type7, managedStack);
							break;
						}
						case ObjectTypes.StackObjectReference:
							objectAndResolveReference = GetObjectAndResolveReference(objectAndResolveReference);
							if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
							{
								switch (ptr11->ObjectType)
								{
								case ObjectTypes.Object:
								{
									StackObject* ptr8 = ResolveReference(objectAndResolveReference);
									CopyValueTypeToStack(ptr8, managedStack[ptr11->Value], managedStack);
									break;
								}
								case ObjectTypes.ValueTypeObjectReference:
									CopyStackValueType(ptr11, objectAndResolveReference, managedStack);
									break;
								default:
									throw new NotImplementedException();
								}
							}
							else if (ptr11->ObjectType >= ObjectTypes.Object)
							{
								managedStack[objectAndResolveReference->Value] = managedStack[ptr11->Value];
								objectAndResolveReference->ValueLow = ptr11->ValueLow;
							}
							else
							{
								*objectAndResolveReference = *ptr11;
							}
							break;
						case ObjectTypes.FieldReference:
						{
							object obj = managedStack[objectAndResolveReference->Value];
							int valueLow16 = objectAndResolveReference->ValueLow;
							if (obj is ILTypeInstance)
							{
								((ILTypeInstance)obj).AssignFromStack(valueLow16, ptr11, AppDomain, managedStack);
								break;
							}
							IType type6 = AppDomain.GetType(ptr4->Operand);
							if (!((CLRType)type6).AssignFieldFromStack(valueLow16, ref obj, this, ptr11, managedStack))
							{
								((CLRType)type6).SetFieldValue(valueLow16, ref obj, type6.TypeForCLR.CheckCLRTypes(StackObject.ToObject(ptr11, AppDomain, managedStack)));
							}
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type5 = AppDomain.GetType(objectAndResolveReference->Value);
							if (type5 is ILType)
							{
								((ILType)type5).StaticInstance.AssignFromStack(objectAndResolveReference->ValueLow, ptr11, AppDomain, managedStack);
								break;
							}
							object obj = null;
							if (!((CLRType)type5).AssignFieldFromStack(objectAndResolveReference->ValueLow, ref obj, this, ptr11, managedStack))
							{
								((CLRType)type5).SetStaticFieldValue(objectAndResolveReference->ValueLow, type5.TypeForCLR.CheckCLRTypes(StackObject.ToObject(ptr11, AppDomain, managedStack)));
							}
							break;
						}
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Ldind_I1:
					case OpCodeREnum.Ldind_U1:
					case OpCodeREnum.Ldind_I2:
					case OpCodeREnum.Ldind_U2:
					case OpCodeREnum.Ldind_I4:
					case OpCodeREnum.Ldind_U4:
					case OpCodeREnum.Ldind_I:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr8 = ptr + ptr4->Register1;
						StackObject* ptr11 = GetObjectAndResolveReference(ptr5);
						switch (ptr11->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							object obj15 = managedStack[ptr11->Value];
							int valueLow22 = ptr11->ValueLow;
							LoadFromFieldReferenceToRegister(ref info, obj15, valueLow22, ptr4->Register1);
							break;
						}
						case ObjectTypes.ArrayReference:
						{
							object obj14 = managedStack[ptr11->Value];
							int valueLow21 = ptr11->ValueLow;
							num4 = GetManagedStackIndex(ref info, ptr4->Register1);
							LoadFromArrayReference(obj14, valueLow21, ptr8, obj14.GetType().GetElementType(), managedStack, num4);
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type = AppDomain.GetType(ptr11->Value);
							int valueLow20 = ptr11->ValueLow;
							if (type is ILType)
							{
								((ILType)type).StaticInstance.CopyToRegister(valueLow20, ref info, ptr4->Register1);
							}
							else if (!((CLRType)type).CopyFieldToStack(valueLow20, null, this, ref esp, managedStack))
							{
								((CLRType)type).GetField(valueLow20);
								object obj = ((CLRType)type).GetFieldValue(valueLow20, null);
								if (obj is CrossBindingAdaptorType)
								{
									obj = ((CrossBindingAdaptorType)obj).ILInstance;
								}
								AssignToRegister(ref info, ptr4->Register1, obj);
							}
							else
							{
								esp = PopToRegister(ref info, ptr4->Register1, esp);
							}
							break;
						}
						default:
							ptr8->ObjectType = ObjectTypes.Integer;
							ptr8->Value = ptr11->Value;
							ptr8->ValueLow = 0;
							break;
						}
						break;
					}
					case OpCodeREnum.Ldind_I8:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr8 = ptr + ptr4->Register1;
						StackObject* ptr11 = GetObjectAndResolveReference(ptr5);
						switch (ptr11->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							object obj11 = managedStack[ptr11->Value];
							int valueLow12 = ptr11->ValueLow;
							LoadFromFieldReferenceToRegister(ref info, obj11, valueLow12, ptr4->Register1);
							break;
						}
						case ObjectTypes.ArrayReference:
						{
							object obj10 = managedStack[ptr11->Value];
							int valueLow11 = ptr11->ValueLow;
							num4 = GetManagedStackIndex(ref info, ptr4->Register1);
							LoadFromArrayReference(obj10, valueLow11, ptr8, obj10.GetType().GetElementType(), managedStack, num4);
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type = AppDomain.GetType(ptr11->Value);
							int valueLow10 = ptr11->ValueLow;
							if (type is ILType)
							{
								((ILType)type).StaticInstance.CopyToRegister(valueLow10, ref info, ptr4->Register1);
							}
							else if (!((CLRType)type).CopyFieldToStack(valueLow10, null, this, ref esp, managedStack))
							{
								((CLRType)type).GetField(valueLow10);
								object obj = ((CLRType)type).GetFieldValue(valueLow10, null);
								if (obj is CrossBindingAdaptorType)
								{
									obj = ((CrossBindingAdaptorType)obj).ILInstance;
								}
								AssignToRegister(ref info, ptr4->Register1, obj);
							}
							else
							{
								esp = PopToRegister(ref info, ptr4->Register1, esp);
							}
							break;
						}
						default:
							*ptr8 = *ptr11;
							ptr8->ObjectType = ObjectTypes.Long;
							break;
						}
						break;
					}
					case OpCodeREnum.Ldind_R4:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr8 = ptr + ptr4->Register1;
						StackObject* ptr11 = GetObjectAndResolveReference(ptr5);
						switch (ptr11->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							object obj9 = managedStack[ptr11->Value];
							int valueLow6 = ptr11->ValueLow;
							LoadFromFieldReferenceToRegister(ref info, obj9, valueLow6, ptr4->Register1);
							break;
						}
						case ObjectTypes.ArrayReference:
						{
							object obj8 = managedStack[ptr11->Value];
							int valueLow5 = ptr11->ValueLow;
							num4 = GetManagedStackIndex(ref info, ptr4->Register1);
							LoadFromArrayReference(obj8, valueLow5, ptr8, obj8.GetType().GetElementType(), managedStack);
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type = AppDomain.GetType(ptr11->Value);
							int valueLow4 = ptr11->ValueLow;
							if (type is ILType)
							{
								((ILType)type).StaticInstance.CopyToRegister(valueLow4, ref info, ptr4->Register1);
							}
							else if (!((CLRType)type).CopyFieldToStack(valueLow4, null, this, ref esp, managedStack))
							{
								((CLRType)type).GetField(valueLow4);
								object obj = ((CLRType)type).GetFieldValue(valueLow4, null);
								if (obj is CrossBindingAdaptorType)
								{
									obj = ((CrossBindingAdaptorType)obj).ILInstance;
								}
								AssignToRegister(ref info, ptr4->Register1, obj);
							}
							else
							{
								esp = PopToRegister(ref info, ptr4->Register1, esp);
							}
							break;
						}
						default:
							ptr8->ObjectType = ObjectTypes.Float;
							ptr8->Value = ptr11->Value;
							ptr8->ValueLow = 0;
							break;
						}
						break;
					}
					case OpCodeREnum.Ldind_R8:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr8 = ptr + ptr4->Register1;
						StackObject* ptr11 = GetObjectAndResolveReference(ptr5);
						switch (ptr11->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							object obj13 = managedStack[ptr11->Value];
							int valueLow19 = ptr11->ValueLow;
							LoadFromFieldReferenceToRegister(ref info, obj13, valueLow19, ptr4->Register1);
							break;
						}
						case ObjectTypes.ArrayReference:
						{
							object obj12 = managedStack[ptr11->Value];
							int valueLow18 = ptr11->ValueLow;
							num4 = GetManagedStackIndex(ref info, ptr4->Register1);
							LoadFromArrayReference(obj12, valueLow18, ptr8, obj12.GetType().GetElementType(), managedStack, num4);
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type = AppDomain.GetType(ptr11->Value);
							int valueLow17 = ptr11->ValueLow;
							if (type is ILType)
							{
								((ILType)type).StaticInstance.CopyToRegister(valueLow17, ref info, ptr4->Register1);
							}
							else if (!((CLRType)type).CopyFieldToStack(valueLow17, null, this, ref esp, managedStack))
							{
								((CLRType)type).GetField(valueLow17);
								object obj = ((CLRType)type).GetFieldValue(valueLow17, null);
								if (obj is CrossBindingAdaptorType)
								{
									obj = ((CrossBindingAdaptorType)obj).ILInstance;
								}
								AssignToRegister(ref info, ptr4->Register1, obj);
							}
							else
							{
								esp = PopToRegister(ref info, ptr4->Register1, esp);
							}
							break;
						}
						default:
							*ptr8 = *ptr11;
							ptr8->ObjectType = ObjectTypes.Double;
							break;
						}
						break;
					}
					case OpCodeREnum.Ldind_Ref:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr8 = ptr + ptr4->Register1;
						StackObject* ptr11 = GetObjectAndResolveReference(ptr5);
						switch (ptr11->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							object obj = managedStack[ptr11->Value];
							num4 = ptr11->ValueLow;
							LoadFromFieldReferenceToRegister(ref info, obj, num4, ptr4->Register1);
							break;
						}
						case ObjectTypes.ArrayReference:
						{
							object obj = managedStack[ptr11->Value];
							int valueLow8 = ptr11->ValueLow;
							num4 = GetManagedStackIndex(ref info, ptr4->Register1);
							LoadFromArrayReference(obj, valueLow8, ptr8, obj.GetType().GetElementType(), managedStack, num4);
							break;
						}
						case ObjectTypes.StaticFieldReference:
						{
							IType type = AppDomain.GetType(ptr11->Value);
							int valueLow7 = ptr11->ValueLow;
							if (type is ILType)
							{
								((ILType)type).StaticInstance.CopyToRegister(valueLow7, ref info, ptr4->Register1);
							}
							else if (!((CLRType)type).CopyFieldToStack(valueLow7, null, this, ref esp, managedStack))
							{
								((CLRType)type).GetField(valueLow7);
								object obj = ((CLRType)type).GetFieldValue(valueLow7, null);
								if (obj is CrossBindingAdaptorType)
								{
									obj = ((CrossBindingAdaptorType)obj).ILInstance;
								}
								AssignToRegister(ref info, ptr4->Register1, obj);
							}
							else
							{
								esp = PopToRegister(ref info, ptr4->Register1, esp);
							}
							break;
						}
						default:
							CopyToRegister(ref info, ptr4->Register1, ptr11);
							break;
						}
						break;
					}
					case OpCodeREnum.Stind_I1:
					case OpCodeREnum.Stind_I2:
					case OpCodeREnum.Stind_I4:
					case OpCodeREnum.Stind_R4:
					case OpCodeREnum.Stind_I:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						StackObject* ptr8 = GetObjectAndResolveReference(ptr6);
						switch (ptr8->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							object obj = managedStack[ptr8->Value];
							StoreValueToFieldReference(ref obj, ptr8->ValueLow, ptr5, managedStack);
							managedStack[ptr8->Value] = obj;
							break;
						}
						case ObjectTypes.ArrayReference:
							StoreValueToArrayReference(ptr8, ptr5, managedStack[ptr8->Value].GetType().GetElementType(), managedStack);
							break;
						case ObjectTypes.StaticFieldReference:
						{
							IType type = AppDomain.GetType(ptr8->Value);
							int valueLow3 = ptr8->ValueLow;
							if (type != null)
							{
								if (type is ILType)
								{
									(type as ILType).StaticInstance.AssignFromStack(valueLow3, ptr5, AppDomain, managedStack);
									break;
								}
								CLRType cLRType5 = type as CLRType;
								FieldInfo field6 = cLRType5.GetField(valueLow3);
								object obj = null;
								if (!cLRType5.AssignFieldFromStack(valueLow3, ref obj, this, ptr5, managedStack))
								{
									cLRType5.SetStaticFieldValue(valueLow3, field6.FieldType.CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr5, domain, managedStack), domain)));
								}
								break;
							}
							throw new TypeLoadException();
						}
						default:
							ptr8->Value = ptr5->Value;
							break;
						}
						break;
					}
					case OpCodeREnum.Stind_I8:
					{
						StackObject* ptr11 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						StackObject* ptr8 = GetObjectAndResolveReference(ptr6);
						switch (ptr8->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							object obj = managedStack[ptr8->Value];
							StoreValueToFieldReference(ref obj, ptr8->ValueLow, ptr11, managedStack);
							managedStack[ptr8->Value] = obj;
							break;
						}
						case ObjectTypes.ArrayReference:
							StoreValueToArrayReference(ptr8, ptr11, typeof(long), managedStack);
							break;
						case ObjectTypes.StaticFieldReference:
						{
							IType type = AppDomain.GetType(ptr8->Value);
							int valueLow2 = ptr8->ValueLow;
							if (type != null)
							{
								if (type is ILType)
								{
									(type as ILType).StaticInstance.AssignFromStack(valueLow2, ptr11, AppDomain, managedStack);
									break;
								}
								CLRType cLRType4 = type as CLRType;
								FieldInfo field5 = cLRType4.GetField(valueLow2);
								object obj = null;
								if (!cLRType4.AssignFieldFromStack(valueLow2, ref obj, this, ptr11, managedStack))
								{
									cLRType4.SetStaticFieldValue(valueLow2, field5.FieldType.CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr11, domain, managedStack), domain)));
								}
								break;
							}
							throw new TypeLoadException();
						}
						default:
							ptr8->Value = ptr11->Value;
							ptr8->ValueLow = ptr11->ValueLow;
							break;
						}
						break;
					}
					case OpCodeREnum.Stind_R8:
					{
						StackObject* ptr11 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						StackObject* ptr8 = GetObjectAndResolveReference(ptr6);
						switch (ptr8->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							object obj = managedStack[ptr8->Value];
							StoreValueToFieldReference(ref obj, ptr8->ValueLow, ptr11, managedStack);
							managedStack[ptr8->Value] = obj;
							break;
						}
						case ObjectTypes.ArrayReference:
							StoreValueToArrayReference(ptr8, ptr11, typeof(double), managedStack);
							break;
						case ObjectTypes.StaticFieldReference:
						{
							IType type = AppDomain.GetType(ptr8->Value);
							int valueLow9 = ptr8->ValueLow;
							if (type != null)
							{
								if (type is ILType)
								{
									(type as ILType).StaticInstance.AssignFromStack(valueLow9, ptr11, AppDomain, managedStack);
									break;
								}
								CLRType cLRType6 = type as CLRType;
								FieldInfo field7 = cLRType6.GetField(valueLow9);
								object obj = null;
								if (!cLRType6.AssignFieldFromStack(valueLow9, ref obj, this, ptr11, managedStack))
								{
									cLRType6.SetStaticFieldValue(valueLow9, field7.FieldType.CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr11, domain, managedStack), domain)));
								}
								break;
							}
							throw new TypeLoadException();
						}
						default:
							ptr8->Value = ptr11->Value;
							ptr8->ValueLow = ptr11->ValueLow;
							break;
						}
						break;
					}
					case OpCodeREnum.Stind_Ref:
					{
						StackObject* ptr11 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register1;
						StackObject* ptr8 = GetObjectAndResolveReference(ptr6);
						switch (ptr8->ObjectType)
						{
						case ObjectTypes.FieldReference:
						{
							object obj = managedStack[ptr8->Value];
							StoreValueToFieldReference(ref obj, ptr8->ValueLow, ptr11, managedStack);
							managedStack[ptr8->Value] = obj;
							break;
						}
						case ObjectTypes.ArrayReference:
							StoreValueToArrayReference(ptr8, ptr11, typeof(object), managedStack);
							break;
						case ObjectTypes.StaticFieldReference:
						{
							IType type = AppDomain.GetType(ptr8->Value);
							int valueLow = ptr8->ValueLow;
							if (type != null)
							{
								if (type is ILType)
								{
									(type as ILType).StaticInstance.AssignFromStack(valueLow, ptr11, AppDomain, managedStack);
									break;
								}
								CLRType cLRType3 = type as CLRType;
								FieldInfo field4 = cLRType3.GetField(valueLow);
								object obj = null;
								if (!cLRType3.AssignFieldFromStack(valueLow, ref obj, this, ptr11, managedStack))
								{
									cLRType3.SetStaticFieldValue(valueLow, field4.FieldType.CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr11, domain, managedStack), domain)));
								}
								break;
							}
							throw new TypeLoadException();
						}
						default:
							switch (ptr11->ObjectType)
							{
							case ObjectTypes.Object:
								managedStack[ptr8->Value] = managedStack[ptr11->Value];
								break;
							case ObjectTypes.Null:
								managedStack[ptr8->Value] = null;
								break;
							default:
								throw new NotImplementedException();
							}
							break;
						}
						break;
					}
					case OpCodeREnum.Ldtoken:
						switch (ptr4->Operand)
						{
						case 0:
						{
							IType type = AppDomain.GetType((int)(ptr4->OperandLong >> 32));
							if (type != null)
							{
								if (!(type is ILType))
								{
									throw new NotImplementedException();
								}
								(type as ILType).StaticInstance.CopyToRegister((int)ptr4->OperandLong, ref info, ptr4->Register1);
							}
							break;
						}
						case 1:
						{
							IType type = AppDomain.GetType((int)ptr4->OperandLong);
							if (type != null)
							{
								AssignToRegister(ref info, ptr4->Register1, type.ReflectionType);
								break;
							}
							throw new TypeLoadException();
						}
						default:
							throw new NotImplementedException();
						}
						break;
					case OpCodeREnum.Ret:
						if (flag)
						{
							StackObject* ptr5 = ptr + ptr4->Register1;
							CopyToStack(esp, ptr5, managedStack);
							esp++;
						}
						flag2 = true;
						break;
					case OpCodeREnum.Br_S:
					case OpCodeREnum.Br:
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					case OpCodeREnum.Brtrue_S:
					case OpCodeREnum.Brtrue:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag5 = false;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Integer:
							flag5 = ptr5->Value != 0;
							break;
						case ObjectTypes.Long:
							flag5 = *(long*)(&ptr5->Value) != 0;
							break;
						case ObjectTypes.Object:
							flag5 = managedStack[ptr5->Value] != null;
							break;
						}
						if (!flag5)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Brfalse_S:
					case OpCodeREnum.Brfalse:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag4 = false;
						switch (ptr5->ObjectType)
						{
						case ObjectTypes.Null:
							flag4 = true;
							break;
						case ObjectTypes.Integer:
							flag4 = ptr5->Value == 0;
							break;
						case ObjectTypes.Long:
							flag4 = *(long*)(&ptr5->Value) == 0;
							break;
						case ObjectTypes.Object:
							flag4 = managedStack[ptr5->Value] == null;
							break;
						}
						if (!flag4)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Beq_S:
					case OpCodeREnum.Beq:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						bool flag3 = false;
						if (ptr5->ObjectType == ptr6->ObjectType)
						{
							flag3 = ptr5->ObjectType switch
							{
								ObjectTypes.Null => true, 
								ObjectTypes.Integer => ptr5->Value == ptr6->Value, 
								ObjectTypes.Long => *(long*)(&ptr5->Value) == *(long*)(&ptr6->Value), 
								ObjectTypes.Float => *(float*)(&ptr5->Value) == *(float*)(&ptr6->Value), 
								ObjectTypes.Double => *(double*)(&ptr5->Value) == *(double*)(&ptr6->Value), 
								ObjectTypes.Object => managedStack[ptr5->Value] == managedStack[ptr6->Value], 
								_ => throw new NotImplementedException(), 
							};
						}
						else if (ptr5->ObjectType == ObjectTypes.Null || ptr6->ObjectType == ObjectTypes.Null)
						{
							if (ptr5->ObjectType == ObjectTypes.Null && ptr6->ObjectType == ObjectTypes.Object)
							{
								flag3 = managedStack[ptr6->Value] == null;
							}
							else if (ptr5->ObjectType == ObjectTypes.Object && ptr6->ObjectType == ObjectTypes.Null)
							{
								flag3 = managedStack[ptr5->Value] == null;
							}
						}
						if (!flag3)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Beqi:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Null => (ptr4->Operand == 0) ? 1 : 0, 
							ObjectTypes.Integer => (ptr5->Value == ptr4->Operand) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) == ptr4->OperandLong) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) == ptr4->OperandFloat) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) == ptr4->OperandDouble) ? 1 : 0, 
							ObjectTypes.Object => (managedStack[ptr5->Value] == null && ptr4->Operand == 0) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand4;
						goto end_IL_0245;
					}
					case OpCodeREnum.Bne_Un_S:
					case OpCodeREnum.Bne_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						bool flag3 = false;
						if (ptr5->ObjectType == ptr6->ObjectType)
						{
							flag3 = ptr5->ObjectType switch
							{
								ObjectTypes.Null => false, 
								ObjectTypes.Integer => ptr5->Value != ptr6->Value, 
								ObjectTypes.Float => *(float*)(&ptr5->Value) != *(float*)(&ptr6->Value), 
								ObjectTypes.Long => *(long*)(&ptr5->Value) != *(long*)(&ptr6->Value), 
								ObjectTypes.Double => *(double*)(&ptr5->Value) != *(double*)(&ptr6->Value), 
								ObjectTypes.Object => managedStack[ptr5->Value] != managedStack[ptr6->Value], 
								_ => throw new NotImplementedException(), 
							};
						}
						else if (ptr5->ObjectType == ObjectTypes.Null || ptr6->ObjectType == ObjectTypes.Null)
						{
							if (ptr5->ObjectType == ObjectTypes.Null && ptr6->ObjectType == ObjectTypes.Object)
							{
								flag3 = managedStack[ptr6->Value] != null;
							}
							else if (ptr5->ObjectType == ObjectTypes.Object && ptr6->ObjectType == ObjectTypes.Null)
							{
								flag3 = managedStack[ptr5->Value] != null;
							}
						}
						else
						{
							flag3 = true;
						}
						if (!flag3)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Bnei_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Null => (ptr4->Operand != 0) ? 1 : 0, 
							ObjectTypes.Integer => (ptr5->Value != ptr4->Operand) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) != ptr4->OperandFloat) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) != ptr4->OperandLong) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) != ptr4->OperandDouble) ? 1 : 0, 
							ObjectTypes.Object => (managedStack[ptr5->Value] != null || ptr4->Operand != 0) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand4;
						goto end_IL_0245;
					}
					case OpCodeREnum.Blt_S:
					case OpCodeREnum.Blt:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value < ptr6->Value) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) < *(long*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) < *(float*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) < *(double*)(&ptr6->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Blti:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value < ptr4->Operand) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) < ptr4->OperandLong) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) < ptr4->OperandFloat) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) < ptr4->OperandDouble) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand4;
						goto end_IL_0245;
					}
					case OpCodeREnum.Blt_Un_S:
					case OpCodeREnum.Blt_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value < (uint)ptr6->Value) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) < (ulong)(*(long*)(&ptr6->Value))) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) < *(float*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) < *(double*)(&ptr6->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Blti_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value < (uint)ptr4->Operand) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) < (ulong)ptr4->Operand) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) < ptr4->OperandFloat) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) < ptr4->OperandDouble) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand4;
						goto end_IL_0245;
					}
					case OpCodeREnum.Ble_S:
					case OpCodeREnum.Ble:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value <= ptr6->Value) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) <= *(long*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) <= *(float*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) <= *(double*)(&ptr6->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Blei:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value <= ptr4->Operand) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) <= ptr4->OperandLong) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) <= ptr4->OperandFloat) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) <= ptr4->OperandDouble) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand4;
						goto end_IL_0245;
					}
					case OpCodeREnum.Ble_Un_S:
					case OpCodeREnum.Ble_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value <= (uint)ptr6->Value) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) <= (ulong)(*(long*)(&ptr6->Value))) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) <= *(float*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) <= *(double*)(&ptr6->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Blei_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value <= (uint)ptr4->Operand) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) <= (ulong)ptr4->OperandLong) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) <= ptr4->OperandFloat) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) <= ptr4->OperandDouble) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand4;
						goto end_IL_0245;
					}
					case OpCodeREnum.Bgt_S:
					case OpCodeREnum.Bgt:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value > ptr6->Value) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) > *(long*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) > *(float*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) > *(double*)(&ptr6->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Bgti:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value > ptr4->Operand) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) > ptr4->OperandLong) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) > ptr4->OperandFloat) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) > ptr4->OperandDouble) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand4;
						goto end_IL_0245;
					}
					case OpCodeREnum.Bgt_Un_S:
					case OpCodeREnum.Bgt_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value > (uint)ptr6->Value) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) > (ulong)(*(long*)(&ptr6->Value))) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) > *(float*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) > *(double*)(&ptr6->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Bgti_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value > (uint)ptr4->Operand) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) > (ulong)ptr4->OperandLong) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) > ptr4->OperandFloat) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) > ptr4->OperandDouble) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand4;
						goto end_IL_0245;
					}
					case OpCodeREnum.Bge_S:
					case OpCodeREnum.Bge:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value >= ptr6->Value) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) >= *(long*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) >= *(float*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) >= *(double*)(&ptr6->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Bgei:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (ptr5->Value >= ptr4->Operand) ? 1 : 0, 
							ObjectTypes.Long => (*(long*)(&ptr5->Value) >= ptr4->OperandLong) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) >= ptr4->OperandFloat) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) >= ptr4->OperandDouble) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand4;
						goto end_IL_0245;
					}
					case OpCodeREnum.Bge_Un_S:
					case OpCodeREnum.Bge_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value >= (uint)ptr6->Value) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) >= (ulong)(*(long*)(&ptr6->Value))) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) >= *(float*)(&ptr6->Value)) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) >= *(double*)(&ptr6->Value)) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					case OpCodeREnum.Bgei_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						bool flag3 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ((uint)ptr5->Value >= (uint)ptr4->Operand) ? 1 : 0, 
							ObjectTypes.Long => ((ulong)(*(long*)(&ptr5->Value)) >= (ulong)ptr4->OperandLong) ? 1 : 0, 
							ObjectTypes.Float => (*(float*)(&ptr5->Value) >= ptr4->OperandFloat) ? 1 : 0, 
							ObjectTypes.Double => (*(double*)(&ptr5->Value) >= ptr4->OperandDouble) ? 1 : 0, 
							_ => throw new NotImplementedException(), 
						} == 0)
						{
							break;
						}
						ptr4 = ptr3 + ptr4->Operand4;
						goto end_IL_0245;
					}
					case OpCodeREnum.Switch:
					{
						num4 = ptr[ptr4->Register1].Value;
						int[] array26 = method.JumpTablesRegister[ptr4->Operand];
						if (num4 < 0 || num4 >= array26.Length)
						{
							break;
						}
						ptr4 = ptr3 + array26[num4];
						goto end_IL_0245;
					}
					case OpCodeREnum.Leave:
					case OpCodeREnum.Leave_S:
					{
						if (exceptionHandlerRegister == null)
						{
							goto IL_4c99;
						}
						ILRuntime.CLR.Method.ExceptionHandler exceptionHandler = null;
						int addr = (int)(ptr4 - ptr3);
						exceptionHandler = FindExceptionHandlerByBranchTarget(addr, ptr4->Operand, exceptionHandlerRegister);
						if (exceptionHandler == null)
						{
							goto IL_4c99;
						}
						num = ptr4->Operand;
						ptr4 = ptr3 + exceptionHandler.HandlerStart;
						goto end_IL_0245;
					}
					case OpCodeREnum.Endfinally:
					{
						if (num < 0)
						{
							unhandledException = true;
							num = 0;
							throw ex;
						}
						num4 = (int)(ptr4 - ptr3);
						ILRuntime.CLR.Method.ExceptionHandler exceptionHandler2 = FindExceptionHandlerByBranchTarget(num4, num, exceptionHandlerRegister);
						if (exceptionHandler2 != null)
						{
							ptr4 = ptr3 + exceptionHandler2.HandlerStart;
							continue;
						}
						ptr4 = ptr3 + num;
						num = 0;
						goto end_IL_0245;
					}
					case OpCodeREnum.Call:
					case OpCodeREnum.Callvirt:
					{
						IMethod method9 = domain.GetMethod(ptr4->Operand2);
						if (method9 == null)
						{
							int num10 = Math.Max(ptr4->Operand3 - 3, 0);
							for (int n = 0; n < num10; n++)
							{
								Free(esp - 1);
								esp--;
							}
							break;
						}
						bool num11 = method9 is ILMethod;
						bool flag19 = num11 && ((ILMethod)method9).ShouldUseRegisterVM;
						if (ptr4->Operand4 == 0)
						{
							num4 = (method9.HasThis ? (method9.ParameterCount + 1) : method9.ParameterCount);
							num4 -= Math.Max(num4 - 3, 0);
							if (num4 > 0)
							{
								StackObject* ptr5 = ptr + ptr4->Register2;
								CopyToStack(esp, ptr5, managedStack);
								if (flag19 && ptr5->ObjectType < ObjectTypes.Object)
								{
									managedStack.Add(null);
								}
								esp++;
							}
							if (num4 > 1)
							{
								StackObject* ptr5 = ptr + ptr4->Register3;
								CopyToStack(esp, ptr5, managedStack);
								if (flag19 && ptr5->ObjectType < ObjectTypes.Object)
								{
									managedStack.Add(null);
								}
								esp++;
							}
							if (num4 > 2)
							{
								StackObject* ptr5 = ptr + ptr4->Register4;
								CopyToStack(esp, ptr5, managedStack);
								if (flag19 && ptr5->ObjectType < ObjectTypes.Object)
								{
									managedStack.Add(null);
								}
								esp++;
							}
						}
						if (num11)
						{
							ILMethod iLMethod2 = (ILMethod)method9;
							bool flag20 = false;
							if (method9.IsDelegateInvoke)
							{
								object obj = StackObject.ToObject(esp - (method9.ParameterCount + 1), domain, managedStack);
								if (obj is IDelegateAdapter)
								{
									esp = ((IDelegateAdapter)obj).ILInvoke(this, esp, managedStack);
									flag20 = true;
								}
							}
							else if (iLMethod2.IsEventAdd)
							{
								ILTypeInstance instance;
								StackObject* objectAndResolveReference = PrepareEventHandler(esp, iLMethod2, managedStack, out instance);
								esp = CLRRedirections.DelegateCombine(this, objectAndResolveReference, managedStack, null, isNewObj: false);
								object obj = StackObject.ToObject(esp - 1, domain, managedStack);
								instance[iLMethod2.EventFieldIndex] = obj;
								Free(esp - 1);
								esp--;
								flag20 = true;
							}
							else if (iLMethod2.IsEventRemove)
							{
								ILTypeInstance instance2;
								StackObject* objectAndResolveReference = PrepareEventHandler(esp, iLMethod2, managedStack, out instance2);
								esp = CLRRedirections.DelegateRemove(this, objectAndResolveReference, managedStack, null, isNewObj: false);
								object obj = StackObject.ToObject(esp - 1, domain, managedStack);
								instance2[iLMethod2.EventFieldIndex] = obj;
								Free(esp - 1);
								esp--;
								flag20 = true;
							}
							if (!flag20)
							{
								if (code == OpCodeREnum.Callvirt)
								{
									StackObject* objectAndResolveReference = GetObjectAndResolveReference(esp - (iLMethod2.ParameterCount + 1));
									if (objectAndResolveReference->ObjectType == ObjectTypes.Null)
									{
										throw new NullReferenceException();
									}
									if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
									{
										StackObject* ptr8 = *(StackObject**)(&objectAndResolveReference->Value);
										iLMethod2 = (domain.GetTypeByIndex(ptr8->Value) as ILType).GetVirtualMethod(iLMethod2) as ILMethod;
										flag19 = iLMethod2.ShouldUseRegisterVM;
									}
									else
									{
										object obj = managedStack[objectAndResolveReference->Value];
										if (obj == null)
										{
											throw new NullReferenceException();
										}
										iLMethod2 = ((ILTypeInstance)obj).Type.GetVirtualMethod(iLMethod2) as ILMethod;
										flag19 = iLMethod2.ShouldUseRegisterVM;
									}
								}
								esp = ((!flag19) ? Execute(iLMethod2, esp, out unhandledException) : ExecuteR(iLMethod2, esp, out unhandledException));
								ValueTypeBasePointer = valueTypeBasePointer;
								if (unhandledException)
								{
									flag2 = true;
								}
							}
						}
						else
						{
							CLRMethod cLRMethod2 = (CLRMethod)method9;
							bool flag21 = false;
							if (cLRMethod2.IsDelegateInvoke)
							{
								object obj16 = StackObject.ToObject(esp - (cLRMethod2.ParameterCount + 1), domain, managedStack);
								if (obj16 is IDelegateAdapter)
								{
									if (cLRMethod2.IsDelegateDynamicInvoke)
									{
										StackObject* objectAndResolveReference = esp - 1;
										object[] array27 = StackObject.ToObject(objectAndResolveReference, domain, managedStack) as object[];
										Free(objectAndResolveReference);
										if (array27 != null)
										{
											if (array27.Length != cLRMethod2.ParameterCount)
											{
												throw new ArgumentException($"{cLRMethod2.DeclearingType.FullName}.{cLRMethod2.Name} has {cLRMethod2.ParameterCount} arguments, but got {array27.Length}");
											}
											esp = objectAndResolveReference;
											for (num4 = 0; num4 < array27.Length; num4++)
											{
												esp = PushObject(esp, managedStack, array27[num4], cLRMethod2.Parameters[num4] == domain.ObjectType);
											}
										}
									}
									esp = ((IDelegateAdapter)obj16).ILInvoke(this, esp, managedStack);
									flag21 = true;
								}
							}
							if (!flag21)
							{
								CLRRedirectionDelegate redirection2 = cLRMethod2.Redirection;
								if (redirection2 != null)
								{
									esp = redirection2(this, esp, managedStack, cLRMethod2, isNewObj: false);
								}
								else
								{
									object obj17 = cLRMethod2.Invoke(this, esp, managedStack);
									if (obj17 is CrossBindingAdaptorType)
									{
										obj17 = ((CrossBindingAdaptorType)obj17).ILInstance;
									}
									int parameterCount2 = cLRMethod2.ParameterCount;
									for (int num12 = 1; num12 <= parameterCount2; num12++)
									{
										Free(esp - num12);
									}
									esp -= parameterCount2;
									if (cLRMethod2.HasThis)
									{
										Free(esp - 1);
										esp--;
									}
									if (cLRMethod2.ReturnType != AppDomain.VoidType && !cLRMethod2.IsConstructor)
									{
										esp = PushObject(esp, managedStack, obj17, cLRMethod2.ReturnType.TypeForCLR == typeof(object));
									}
								}
							}
						}
						if (method9.ReturnType != AppDomain.VoidType && !method9.IsConstructor)
						{
							esp = PopToRegister(ref info, ptr4->Register1, esp);
						}
						break;
					}
					case OpCodeREnum.Stfld:
					{
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* objectAndResolveReference = GetObjectAndResolveReference(ptr + ptr4->Register1);
						if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
						{
							StackObject* ptr8 = ResolveReference(objectAndResolveReference);
							IType typeByIndex2 = domain.GetTypeByIndex(ptr8->Value);
							if (typeByIndex2 is ILType)
							{
								CopyToValueTypeField(ptr8, (int)ptr4->OperandLong, ptr6, managedStack);
							}
							else
							{
								CopyToValueTypeField(ptr8, ((CLRType)typeByIndex2).FieldIndexMapping[(int)ptr4->OperandLong], ptr6, managedStack);
							}
							break;
						}
						object obj = RetriveObject(objectAndResolveReference, managedStack);
						if (obj != null)
						{
							ILTypeInstance iLTypeInstance4 = null;
							if (obj is ILTypeInstance)
							{
								iLTypeInstance4 = obj as ILTypeInstance;
							}
							else if (obj is CrossBindingAdaptorType)
							{
								iLTypeInstance4 = (obj as CrossBindingAdaptorType).ILInstance;
							}
							if (iLTypeInstance4 != null)
							{
								iLTypeInstance4.AssignFromStack((int)ptr4->OperandLong, ptr6, AppDomain, managedStack);
								break;
							}
							Type type8 = obj.GetType();
							IType type = AppDomain.GetType((int)(ptr4->OperandLong >> 32));
							if (type != null)
							{
								int hash2 = (int)ptr4->OperandLong;
								FieldInfo field8 = ((CLRType)type).GetField(hash2);
								CopyToStack(esp, ptr6, managedStack);
								if (!((CLRType)type).AssignFieldFromStack(hash2, ref obj, this, esp, managedStack))
								{
									((CLRType)type).SetFieldValue(hash2, ref obj, field8.FieldType.CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr6, domain, managedStack), domain)));
								}
								Free(esp);
								if (!type8.IsValueType)
								{
									break;
								}
								switch (objectAndResolveReference->ObjectType)
								{
								case ObjectTypes.Object:
									managedStack[objectAndResolveReference->Value] = obj;
									break;
								case ObjectTypes.FieldReference:
								{
									object target = managedStack[objectAndResolveReference->Value];
									num4 = objectAndResolveReference->ValueLow;
									if (target is ILTypeInstance)
									{
										((ILTypeInstance)target)[num4] = obj;
									}
									else
									{
										((CLRType)AppDomain.GetType(target.GetType())).SetFieldValue(num4, ref target, obj);
									}
									break;
								}
								case ObjectTypes.ArrayReference:
									(managedStack[objectAndResolveReference->Value] as Array).SetValue(index: objectAndResolveReference->ValueLow, value: obj);
									break;
								case ObjectTypes.StaticFieldReference:
								{
									IType type9 = AppDomain.GetType(objectAndResolveReference->Value);
									num4 = objectAndResolveReference->ValueLow;
									if (type9 is ILType)
									{
										((ILType)type9).StaticInstance[num4] = obj;
									}
									else
									{
										((CLRType)type9).SetStaticFieldValue(num4, obj);
									}
									break;
								}
								case ObjectTypes.ValueTypeObjectReference:
								{
									StackObject* ptr8 = ResolveReference(objectAndResolveReference);
									(domain.GetTypeByIndex(ptr8->Value) as CLRType).ValueTypeBinder.CopyValueTypeToStack(obj, ptr8, managedStack);
									break;
								}
								default:
									throw new NotImplementedException();
								}
								break;
							}
							throw new TypeLoadException();
						}
						throw new NullReferenceException();
					}
					case OpCodeREnum.Ldfld:
					{
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* objectAndResolveReference = GetObjectAndResolveReference(ptr6);
						if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
						{
							StackObject* ptr8 = *(StackObject**)(&objectAndResolveReference->Value);
							IType typeByIndex = domain.GetTypeByIndex(ptr8->Value);
							CopyToRegister(val: (!(typeByIndex is ILType)) ? (ptr8 - (((CLRType)typeByIndex).FieldIndexMapping[(int)ptr4->OperandLong] + 1)) : (ptr8 - ((int)ptr4->OperandLong + 1)), info: ref info, reg: ptr4->Register1);
							break;
						}
						object obj = RetriveObject(objectAndResolveReference, managedStack);
						if (obj != null)
						{
							ILTypeInstance iLTypeInstance2 = null;
							if (obj is ILTypeInstance)
							{
								iLTypeInstance2 = obj as ILTypeInstance;
							}
							else if (obj is CrossBindingAdaptorType)
							{
								iLTypeInstance2 = (obj as CrossBindingAdaptorType).ILInstance;
							}
							if (iLTypeInstance2 != null)
							{
								iLTypeInstance2.CopyToRegister((int)ptr4->OperandLong, ref info, ptr4->Register1);
								break;
							}
							IType type = AppDomain.GetType((int)(ptr4->OperandLong >> 32));
							if (type != null)
							{
								int hash = (int)ptr4->OperandLong;
								if (!((CLRType)type).CopyFieldToStack(hash, obj, this, ref esp, managedStack))
								{
									FieldInfo field3 = ((CLRType)type).GetField(hash);
									obj = ((CLRType)type).GetFieldValue(hash, obj);
									if (obj is CrossBindingAdaptorType)
									{
										obj = ((CrossBindingAdaptorType)obj).ILInstance;
									}
									AssignToRegister(ref info, ptr4->Register1, obj, field3.FieldType == typeof(object));
								}
								else
								{
									esp = PopToRegister(ref info, ptr4->Register1, esp);
								}
								break;
							}
							throw new TypeLoadException();
						}
						throw new NullReferenceException();
					}
					case OpCodeREnum.Ldflda:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* objectAndResolveReference = GetObjectAndResolveReference(ptr6);
						if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
						{
							IType type2 = domain.GetType((int)(ptr4->OperandLong >> 32));
							StackObject* ptr9 = ((!(type2 is ILType)) ? (ResolveReference(objectAndResolveReference) - (((CLRType)type2).FieldIndexMapping[(int)ptr4->OperandLong] + 1)) : (ResolveReference(objectAndResolveReference) - ((int)ptr4->OperandLong + 1)));
							ptr5->ObjectType = ObjectTypes.StackObjectReference;
							*(long*)(&ptr5->Value) = (long)ptr9;
							break;
						}
						object obj = RetriveObject(objectAndResolveReference, managedStack);
						if (obj != null)
						{
							AssignToRegister(ref info, ptr4->Register1, obj);
							ptr5->ObjectType = ObjectTypes.FieldReference;
							ptr5->ValueLow = (int)ptr4->OperandLong;
							break;
						}
						throw new NullReferenceException();
					}
					case OpCodeREnum.Stsfld:
					{
						IType type = AppDomain.GetType((int)(ptr4->OperandLong >> 32));
						if (type != null)
						{
							StackObject* ptr5 = ptr + ptr4->Register1;
							if (type is ILType)
							{
								(type as ILType).StaticInstance.AssignFromStack((int)ptr4->OperandLong, ptr5, AppDomain, managedStack);
								break;
							}
							CLRType cLRType2 = type as CLRType;
							num4 = (int)ptr4->OperandLong;
							FieldInfo field2 = cLRType2.GetField(num4);
							object obj = null;
							CopyToStack(esp, ptr5, managedStack);
							if (!cLRType2.AssignFieldFromStack(num4, ref obj, this, esp, managedStack))
							{
								cLRType2.SetStaticFieldValue(num4, field2.FieldType.CheckCLRTypes(CheckAndCloneValueType(StackObject.ToObject(ptr5, domain, managedStack), domain)));
							}
							Free(esp);
							break;
						}
						throw new TypeLoadException();
					}
					case OpCodeREnum.Ldsfld:
					{
						IType type = AppDomain.GetType((int)(ptr4->OperandLong >> 32));
						if (type != null)
						{
							if (type is ILType)
							{
								(type as ILType).StaticInstance.CopyToRegister((int)ptr4->OperandLong, ref info, ptr4->Register1);
								break;
							}
							CLRType cLRType = type as CLRType;
							num4 = (int)ptr4->OperandLong;
							if (!((CLRType)type).CopyFieldToStack(num4, null, this, ref esp, managedStack))
							{
								FieldInfo field = cLRType.GetField(num4);
								object obj = cLRType.GetFieldValue(num4, null);
								if (obj is CrossBindingAdaptorType)
								{
									obj = ((CrossBindingAdaptorType)obj).ILInstance;
								}
								AssignToRegister(ref info, ptr4->Register1, obj, field.FieldType == typeof(object));
							}
							else
							{
								esp = PopToRegister(ref info, ptr4->Register1, esp);
							}
							break;
						}
						throw new TypeLoadException();
					}
					case OpCodeREnum.Ldsflda:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						ptr5->ObjectType = ObjectTypes.StaticFieldReference;
						ptr5->Value = (int)(ptr4->OperandLong >> 32);
						ptr5->ValueLow = (int)ptr4->OperandLong;
						break;
					}
					case OpCodeREnum.Newobj:
					{
						IMethod method2 = domain.GetMethod(ptr4->Operand2);
						if (method2 is ILMethod)
						{
							IType type = method2.DeclearingType as ILType;
							if (type.IsDelegate)
							{
								StackObject* objectAndResolveReference = GetObjectAndResolveReference(ptr + ptr4->Register2);
								IMethod method3 = (IMethod)managedStack[ptr[ptr4->Register3].Value];
								object obj2 = ((objectAndResolveReference->ObjectType != ObjectTypes.Null) ? managedStack[objectAndResolveReference->Value] : null);
								if (!(method3 is ILMethod iLMethod))
								{
									throw new NotImplementedException();
								}
								object obj3;
								if (obj2 != null)
								{
									obj3 = ((ILTypeInstance)obj2).GetDelegateAdapter(iLMethod);
									if (obj3 == null)
									{
										IMethod method4 = type.GetMethod("Invoke", method3.ParameterCount);
										if (method4 == null && iLMethod.IsExtend)
										{
											method4 = type.GetMethod("Invoke", method3.ParameterCount - 1);
										}
										obj3 = domain.DelegateManager.FindDelegateAdapter((ILTypeInstance)obj2, iLMethod, method4);
									}
								}
								else
								{
									if (iLMethod.DelegateAdapter == null)
									{
										IMethod method5 = type.GetMethod("Invoke", method3.ParameterCount);
										iLMethod.DelegateAdapter = domain.DelegateManager.FindDelegateAdapter(null, iLMethod, method5);
									}
									obj3 = iLMethod.DelegateAdapter;
								}
								esp = PushObject(esp, managedStack, obj3);
							}
							else
							{
								num4 = method2.ParameterCount;
								num4 -= Math.Max(num4 - 3, 0);
								StackObject* ptr5;
								if (num4 < method2.ParameterCount)
								{
									if (num4 > 0)
									{
										ptr5 = ptr + ptr4->Register2;
										CopyToStack(esp, ptr5, managedStack);
										esp++;
									}
									if (num4 > 1)
									{
										ptr5 = ptr + ptr4->Register3;
										CopyToStack(esp, ptr5, managedStack);
										esp++;
									}
									if (num4 > 2)
									{
										ptr5 = ptr + ptr4->Register4;
										CopyToStack(esp, ptr5, managedStack);
										esp++;
									}
									ptr5 = esp - method2.ParameterCount;
								}
								else
								{
									ptr5 = esp;
								}
								object obj = null;
								bool isValueType = type.IsValueType;
								bool shouldUseRegisterVM = ((ILMethod)method2).ShouldUseRegisterVM;
								StackObject* objectAndResolveReference;
								if (isValueType)
								{
									stack.AllocValueType(esp, type);
									objectAndResolveReference = esp + 1;
									objectAndResolveReference->ObjectType = ObjectTypes.StackObjectReference;
									*(StackObject**)(&objectAndResolveReference->Value) = esp;
									if (shouldUseRegisterVM)
									{
										managedStack.Add(null);
									}
									objectAndResolveReference++;
								}
								else
								{
									obj = ((ILType)type).Instantiate(callDefaultConstructor: false);
									objectAndResolveReference = PushObject(esp, managedStack, obj);
								}
								esp = objectAndResolveReference;
								if (num4 < method2.ParameterCount)
								{
									for (int k = 0; k < method2.ParameterCount; k++)
									{
										CopyToStack(esp, ptr5 + k, managedStack);
										if (esp->ObjectType < ObjectTypes.Object && shouldUseRegisterVM)
										{
											managedStack.Add(null);
										}
										esp++;
									}
								}
								else
								{
									if (num4 > 0)
									{
										StackObject* ptr6 = ptr + ptr4->Register2;
										CopyToStack(esp, ptr6, managedStack);
										if (esp->ObjectType < ObjectTypes.Object && shouldUseRegisterVM)
										{
											managedStack.Add(null);
										}
										esp++;
									}
									if (num4 > 1)
									{
										StackObject* ptr6 = ptr + ptr4->Register3;
										CopyToStack(esp, ptr6, managedStack);
										if (esp->ObjectType < ObjectTypes.Object && shouldUseRegisterVM)
										{
											managedStack.Add(null);
										}
										esp++;
									}
									if (num4 > 2)
									{
										StackObject* ptr6 = ptr + ptr4->Register4;
										CopyToStack(esp, ptr6, managedStack);
										if (esp->ObjectType < ObjectTypes.Object && shouldUseRegisterVM)
										{
											managedStack.Add(null);
										}
										esp++;
									}
								}
								esp = ((!shouldUseRegisterVM) ? Execute((ILMethod)method2, esp, out unhandledException) : ExecuteR((ILMethod)method2, esp, out unhandledException));
								ValueTypeBasePointer = valueTypeBasePointer;
								if (isValueType)
								{
									StackObject* ptr10 = objectAndResolveReference - 1 - 1;
									*ptr5 = *ptr10;
									esp = ptr5 + 1;
								}
								else
								{
									esp = PushObject(ptr5, managedStack, obj);
								}
							}
							if (unhandledException)
							{
								flag2 = true;
							}
						}
						else
						{
							CLRMethod cLRMethod = (CLRMethod)method2;
							if (cLRMethod == null)
							{
								esp = PushObject(esp, managedStack, new object());
							}
							else if (cLRMethod.DeclearingType.IsDelegate)
							{
								StackObject* objectAndResolveReference = GetObjectAndResolveReference(ptr + ptr4->Register2);
								IMethod method6 = (IMethod)managedStack[ptr[ptr4->Register3].Value];
								object obj4 = ((objectAndResolveReference->ObjectType != ObjectTypes.Null) ? managedStack[objectAndResolveReference->Value] : null);
								object obj5;
								if (method6 is ILMethod ilMethod)
								{
									obj5 = domain.DelegateManager.FindDelegateAdapter((CLRType)cLRMethod.DeclearingType, (ILTypeInstance)obj4, ilMethod);
								}
								else
								{
									if (obj4 is ILTypeInstance)
									{
										obj4 = ((ILTypeInstance)obj4).CLRInstance;
									}
									obj5 = Delegate.CreateDelegate(cLRMethod.DeclearingType.TypeForCLR, obj4, ((CLRMethod)method6).MethodInfo);
								}
								esp = PushObject(esp, managedStack, obj5);
							}
							else
							{
								num4 = method2.ParameterCount;
								num4 -= Math.Max(num4 - 3, 0);
								if (num4 > 0)
								{
									StackObject* ptr5 = ptr + ptr4->Register2;
									CopyToStack(esp, ptr5, managedStack);
									esp++;
								}
								if (num4 > 1)
								{
									StackObject* ptr5 = ptr + ptr4->Register3;
									CopyToStack(esp, ptr5, managedStack);
									esp++;
								}
								if (num4 > 2)
								{
									StackObject* ptr5 = ptr + ptr4->Register4;
									CopyToStack(esp, ptr5, managedStack);
									esp++;
								}
								CLRRedirectionDelegate redirection = cLRMethod.Redirection;
								if (redirection != null)
								{
									esp = redirection(this, esp, managedStack, cLRMethod, isNewObj: true);
								}
								else
								{
									object obj6 = cLRMethod.Invoke(this, esp, managedStack, isNewObj: true);
									int parameterCount = cLRMethod.ParameterCount;
									for (int l = 1; l <= parameterCount; l++)
									{
										Free(esp - l);
									}
									esp -= parameterCount;
									esp = PushObject(esp, managedStack, obj6);
								}
							}
						}
						esp = PopToRegister(ref info, ptr4->Register1, esp);
						break;
					}
					case OpCodeREnum.Box:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* objectAndResolveReference = ptr + ptr4->Register2;
						IType type = domain.GetType(ptr4->Operand);
						if (type != null)
						{
							if (type is ILType)
							{
								if (((ILType)type).IsEnum)
								{
									ILEnumTypeInstance iLEnumTypeInstance2 = new ILEnumTypeInstance((ILType)type);
									iLEnumTypeInstance2.AssignFromStack(0, objectAndResolveReference, AppDomain, managedStack);
									iLEnumTypeInstance2.Boxed = true;
									AssignToRegister(ref info, ptr4->Register1, iLEnumTypeInstance2, isBox: true);
									break;
								}
								switch (objectAndResolveReference->ObjectType)
								{
								case ObjectTypes.ValueTypeObjectReference:
								{
									ILTypeInstance iLTypeInstance6 = ((ILType)type).Instantiate(callDefaultConstructor: false);
									iLTypeInstance6.AssignFromStack(objectAndResolveReference, domain, managedStack);
									AssignToRegister(ref info, ptr4->Register1, iLTypeInstance6, isBox: true);
									break;
								}
								default:
								{
									object obj = managedStack[objectAndResolveReference->Value];
									if (type.IsArray)
									{
										AssignToRegister(ref info, ptr4->Register1, obj, isBox: true);
										break;
									}
									ILTypeInstance iLTypeInstance5 = (ILTypeInstance)obj;
									if (iLTypeInstance5 != null)
									{
										if (iLTypeInstance5.IsValueType)
										{
											iLTypeInstance5.Boxed = true;
										}
										AssignToRegister(ref info, ptr4->Register1, iLTypeInstance5, isBox: true);
									}
									else
									{
										AssignToRegister(ref info, ptr4->Register1, null);
									}
									break;
								}
								case ObjectTypes.Null:
									break;
								}
							}
							else if (type.TypeForCLR.IsPrimitive)
							{
								Type typeForCLR4 = type.TypeForCLR;
								if (typeForCLR4 == typeof(int))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										AssignToRegister(ref info, ptr4->Register1, objectAndResolveReference->Value, isBox: true);
										break;
									case ObjectTypes.Null:
										AssignToRegister(ref info, ptr4->Register1, 0, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR4 == typeof(bool))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										AssignToRegister(ref info, ptr4->Register1, objectAndResolveReference->Value == 1, isBox: true);
										break;
									case ObjectTypes.Null:
										AssignToRegister(ref info, ptr4->Register1, false, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR4 == typeof(byte))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										AssignToRegister(ref info, ptr4->Register1, (byte)objectAndResolveReference->Value, isBox: true);
										break;
									case ObjectTypes.Null:
										AssignToRegister(ref info, ptr4->Register1, (byte)0, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR4 == typeof(short))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										AssignToRegister(ref info, ptr4->Register1, (short)objectAndResolveReference->Value, isBox: true);
										break;
									case ObjectTypes.Null:
										AssignToRegister(ref info, ptr4->Register1, (short)0, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR4 == typeof(long))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Long:
										AssignToRegister(ref info, ptr4->Register1, *(long*)(&objectAndResolveReference->Value), isBox: true);
										break;
									case ObjectTypes.Null:
										AssignToRegister(ref info, ptr4->Register1, 0L, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR4 == typeof(float))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Float:
										AssignToRegister(ref info, ptr4->Register1, *(float*)(&objectAndResolveReference->Value), isBox: true);
										break;
									case ObjectTypes.Null:
										AssignToRegister(ref info, ptr4->Register1, 0f, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR4 == typeof(double))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Double:
										AssignToRegister(ref info, ptr4->Register1, *(double*)(&objectAndResolveReference->Value), isBox: true);
										break;
									case ObjectTypes.Null:
										AssignToRegister(ref info, ptr4->Register1, 0.0, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR4 == typeof(char))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										AssignToRegister(ref info, ptr4->Register1, (char)objectAndResolveReference->Value, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR4 == typeof(uint))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										AssignToRegister(ref info, ptr4->Register1, (uint)objectAndResolveReference->Value, isBox: true);
										break;
									case ObjectTypes.Null:
										AssignToRegister(ref info, ptr4->Register1, 0u, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR4 == typeof(ushort))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Integer:
										AssignToRegister(ref info, ptr4->Register1, (ushort)objectAndResolveReference->Value, isBox: true);
										break;
									case ObjectTypes.Null:
										AssignToRegister(ref info, ptr4->Register1, (ushort)0, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (typeForCLR4 == typeof(ulong))
								{
									switch (objectAndResolveReference->ObjectType)
									{
									case ObjectTypes.Long:
										AssignToRegister(ref info, ptr4->Register1, *(ulong*)(&objectAndResolveReference->Value), isBox: true);
										break;
									case ObjectTypes.Null:
										AssignToRegister(ref info, ptr4->Register1, 0uL, isBox: true);
										break;
									default:
										throw new NotImplementedException();
									case ObjectTypes.Object:
										break;
									}
									break;
								}
								if (!(typeForCLR4 == typeof(sbyte)))
								{
									throw new NotImplementedException();
								}
								switch (objectAndResolveReference->ObjectType)
								{
								case ObjectTypes.Integer:
									AssignToRegister(ref info, ptr4->Register1, (sbyte)objectAndResolveReference->Value, isBox: true);
									break;
								case ObjectTypes.Null:
									AssignToRegister(ref info, ptr4->Register1, (sbyte)0, isBox: true);
									break;
								default:
									throw new NotImplementedException();
								case ObjectTypes.Object:
									break;
								}
							}
							else if (type.TypeForCLR.IsEnum)
							{
								AssignToRegister(ref info, ptr4->Register1, Enum.ToObject(type.TypeForCLR, StackObject.ToObject(objectAndResolveReference, AppDomain, managedStack)), isBox: true);
							}
							else if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
							{
								StackObject* ptr8 = *(StackObject**)(&objectAndResolveReference->Value);
								IType typeByIndex3 = domain.GetTypeByIndex(ptr8->Value);
								if (typeByIndex3 != type)
								{
									throw new InvalidCastException();
								}
								object obj = ((CLRType)typeByIndex3).ValueTypeBinder.ToObject(ptr8, managedStack);
								AssignToRegister(ref info, ptr4->Register1, obj, isBox: true);
							}
							else if (objectAndResolveReference->ObjectType == ObjectTypes.Object)
							{
								object obj = managedStack[objectAndResolveReference->Value];
								AssignToRegister(ref info, ptr4->Register1, obj, isBox: true);
							}
							else
							{
								CopyToRegister(ref info, ptr4->Register1, objectAndResolveReference);
							}
							break;
						}
						throw new NullReferenceException();
					}
					case OpCodeREnum.Constrained:
					{
						IType type = domain.GetType(ptr4->Operand);
						int parameterCount3 = domain.GetMethod(ptr4->Operand2).ParameterCount;
						StackObject* objectAndResolveReference = esp - (parameterCount3 + 1);
						int num13 = managedStack.Count;
						if (objectAndResolveReference->ObjectType < ObjectTypes.Object)
						{
							bool flag22 = false;
							for (int num14 = 0; num14 < parameterCount3; num14++)
							{
								StackObject* ptr12 = esp - (num14 + 1);
								if (ptr12->ObjectType >= ObjectTypes.Object)
								{
									int value7 = ptr12->Value;
									num13--;
									if (!flag22)
									{
										ptr12->Value = managedStack.Count;
										managedStack.Add(managedStack[value7]);
										managedStack[value7] = null;
										flag22 = true;
									}
									else
									{
										managedStack[value7 + 1] = managedStack[value7];
										managedStack[value7] = null;
										ptr12->Value = value7 + 1;
									}
								}
							}
							if (!flag22)
							{
								managedStack.Add(null);
							}
						}
						else
						{
							num13 = objectAndResolveReference->Value;
						}
						StackObject* objectAndResolveReference2 = GetObjectAndResolveReference(objectAndResolveReference);
						if (type != null)
						{
							if (type is ILType)
							{
								ILType iLType = (ILType)type;
								if (iLType.IsEnum)
								{
									ILEnumTypeInstance iLEnumTypeInstance = new ILEnumTypeInstance(iLType);
									switch (objectAndResolveReference2->ObjectType)
									{
									case ObjectTypes.FieldReference:
									{
										ILTypeInstance obj20 = managedStack[objectAndResolveReference2->Value] as ILTypeInstance;
										int valueLow25 = objectAndResolveReference2->ValueLow;
										obj20.PushToStack(valueLow25, objectAndResolveReference, this, managedStack);
										iLEnumTypeInstance.AssignFromStack(0, objectAndResolveReference, AppDomain, managedStack);
										iLEnumTypeInstance.Boxed = true;
										break;
									}
									case ObjectTypes.StaticFieldReference:
									{
										ILType obj19 = AppDomain.GetType(objectAndResolveReference2->Value) as ILType;
										int valueLow24 = objectAndResolveReference2->ValueLow;
										obj19.StaticInstance.PushToStack(valueLow24, objectAndResolveReference, this, managedStack);
										iLEnumTypeInstance.AssignFromStack(0, objectAndResolveReference, AppDomain, managedStack);
										iLEnumTypeInstance.Boxed = true;
										break;
									}
									case ObjectTypes.ArrayReference:
									{
										object obj18 = managedStack[objectAndResolveReference2->Value];
										int valueLow23 = objectAndResolveReference2->ValueLow;
										LoadFromArrayReference(obj18, valueLow23, objectAndResolveReference, iLType, managedStack);
										iLEnumTypeInstance.AssignFromStack(0, objectAndResolveReference, AppDomain, managedStack);
										iLEnumTypeInstance.Boxed = true;
										break;
									}
									default:
										iLEnumTypeInstance.AssignFromStack(0, objectAndResolveReference2, AppDomain, managedStack);
										iLEnumTypeInstance.Boxed = true;
										break;
									}
									objectAndResolveReference->ObjectType = ObjectTypes.Object;
									objectAndResolveReference->Value = num13;
									managedStack[num13] = iLEnumTypeInstance;
								}
								else if (objectAndResolveReference2->ObjectType != ObjectTypes.ValueTypeObjectReference)
								{
									object value8 = RetriveObject(objectAndResolveReference2, managedStack);
									objectAndResolveReference->ObjectType = ObjectTypes.Object;
									objectAndResolveReference->Value = num13;
									managedStack[num13] = value8;
								}
							}
							else
							{
								Type typeForCLR2 = type.TypeForCLR;
								if (typeForCLR2.IsEnum)
								{
									managedStack[num13] = Enum.ToObject(typeForCLR2, StackObject.ToObject(objectAndResolveReference2, AppDomain, managedStack));
									objectAndResolveReference->ObjectType = ObjectTypes.Object;
									objectAndResolveReference->Value = num13;
								}
								else if (typeForCLR2.IsPrimitive)
								{
									managedStack[num13] = typeForCLR2.CheckCLRTypes(StackObject.ToObject(objectAndResolveReference2, AppDomain, managedStack));
									objectAndResolveReference->ObjectType = ObjectTypes.Object;
									objectAndResolveReference->Value = num13;
								}
								else if (objectAndResolveReference2->ObjectType != ObjectTypes.ValueTypeObjectReference)
								{
									object value9 = RetriveObject(objectAndResolveReference2, managedStack);
									objectAndResolveReference->ObjectType = ObjectTypes.Object;
									objectAndResolveReference->Value = num13;
									managedStack[num13] = value9;
								}
							}
							break;
						}
						throw new NullReferenceException();
					}
					case OpCodeREnum.Unbox:
					case OpCodeREnum.Unbox_Any:
					{
						StackObject* objectAndResolveReference = ptr + ptr4->Register2;
						if (objectAndResolveReference->ObjectType == ObjectTypes.Object)
						{
							object obj = managedStack[objectAndResolveReference->Value];
							if (obj == null)
							{
								break;
							}
							IType type3 = domain.GetType(ptr4->Operand);
							if (type3 == null)
							{
								throw new TypeLoadException();
							}
							Type typeForCLR = type3.TypeForCLR;
							bool flag6 = obj is ILEnumTypeInstance;
							if (type3 is CLRType && typeForCLR.IsPrimitive && !flag6)
							{
								StackObject* ptr5 = ptr + ptr4->Register1;
								if (typeForCLR == typeof(int))
								{
									num4 = obj.ToInt32();
									ptr5->ObjectType = ObjectTypes.Integer;
									ptr5->Value = num4;
									break;
								}
								if (typeForCLR == typeof(bool))
								{
									bool flag7 = (bool)obj;
									ptr5->ObjectType = ObjectTypes.Integer;
									ptr5->Value = (flag7 ? 1 : 0);
									break;
								}
								if (typeForCLR == typeof(short))
								{
									short value2 = obj.ToInt16();
									ptr5->ObjectType = ObjectTypes.Integer;
									ptr5->Value = value2;
									break;
								}
								if (typeForCLR == typeof(long))
								{
									num5 = obj.ToInt64();
									ptr5->ObjectType = ObjectTypes.Long;
									*(long*)(&ptr5->Value) = num5;
									break;
								}
								if (typeForCLR == typeof(float))
								{
									num6 = obj.ToFloat();
									ptr5->ObjectType = ObjectTypes.Float;
									*(float*)(&ptr5->Value) = num6;
									break;
								}
								if (typeForCLR == typeof(byte))
								{
									byte value3 = (byte)obj;
									ptr5->ObjectType = ObjectTypes.Integer;
									ptr5->Value = value3;
									break;
								}
								if (typeForCLR == typeof(double))
								{
									num7 = obj.ToDouble();
									ptr5->ObjectType = ObjectTypes.Double;
									*(double*)(&ptr5->Value) = num7;
									break;
								}
								if (typeForCLR == typeof(char))
								{
									char c = (char)obj;
									ptr5->ObjectType = ObjectTypes.Integer;
									*(char*)(&ptr5->Value) = c;
									break;
								}
								if (typeForCLR == typeof(uint))
								{
									uint value4 = (uint)obj;
									ptr5->ObjectType = ObjectTypes.Integer;
									ptr5->Value = (int)value4;
									break;
								}
								if (typeForCLR == typeof(ushort))
								{
									ushort value5 = (ushort)obj;
									ptr5->ObjectType = ObjectTypes.Integer;
									ptr5->Value = value5;
									break;
								}
								if (typeForCLR == typeof(ulong))
								{
									ulong num8 = (ulong)obj;
									ptr5->ObjectType = ObjectTypes.Long;
									*(ulong*)(&ptr5->Value) = num8;
									break;
								}
								if (!(typeForCLR == typeof(sbyte)))
								{
									throw new NotImplementedException();
								}
								sbyte value6 = (sbyte)obj;
								ptr5->ObjectType = ObjectTypes.Integer;
								ptr5->Value = value6;
							}
							else if (type3.IsValueType)
							{
								if (obj is ILTypeInstance)
								{
									ILTypeInstance iLTypeInstance3 = (ILTypeInstance)obj;
									if (iLTypeInstance3 is ILEnumTypeInstance)
									{
										iLTypeInstance3.CopyToRegister(0, ref info, ptr4->Register1);
										break;
									}
									if (iLTypeInstance3.Boxed)
									{
										iLTypeInstance3 = iLTypeInstance3.Clone();
										iLTypeInstance3.Boxed = false;
									}
									AssignToRegister(ref info, ptr4->Register1, iLTypeInstance3);
								}
								else
								{
									AssignToRegister(ref info, ptr4->Register1, obj);
								}
							}
							else
							{
								AssignToRegister(ref info, ptr4->Register1, obj);
							}
						}
						else if (objectAndResolveReference->ObjectType >= ObjectTypes.StackObjectReference && objectAndResolveReference->ObjectType != ObjectTypes.ValueTypeObjectReference)
						{
							throw new InvalidCastException();
						}
						break;
					}
					case OpCodeREnum.Initobj:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* objectAndResolveReference = ((ptr4->Operand2 == 1) ? ptr5 : GetObjectAndResolveReference(ptr5));
						IType type = domain.GetType(ptr4->Operand);
						object obj;
						if (type is ILType)
						{
							ILType iLType2 = (ILType)type;
							if (iLType2.IsValueType)
							{
								if (iLType2.IsEnum || iLType2.IsPrimitive)
								{
									StackObject.Initialized(objectAndResolveReference, type);
									break;
								}
								if (objectAndResolveReference >= info.RegisterStart && objectAndResolveReference < info.RegisterEnd)
								{
									stack.AllocValueType(objectAndResolveReference, type, register: true);
									break;
								}
								switch (objectAndResolveReference->ObjectType)
								{
								case ObjectTypes.Null:
									throw new NullReferenceException();
								case ObjectTypes.ValueTypeObjectReference:
									stack.ClearValueTypeObject(type, ResolveReference(objectAndResolveReference));
									break;
								case ObjectTypes.Object:
									obj = managedStack[objectAndResolveReference->Value];
									if (obj == null)
									{
										throw new NotSupportedException();
									}
									if (obj is ILTypeInstance)
									{
										(obj as ILTypeInstance).Clear();
										break;
									}
									throw new NotSupportedException();
								case ObjectTypes.ArrayReference:
								{
									Array array28 = managedStack[objectAndResolveReference->Value] as Array;
									int valueLow27 = objectAndResolveReference->ValueLow;
									obj = array28.GetValue(valueLow27);
									if (obj == null)
									{
										array28.SetValue(iLType2.Instantiate(), valueLow27);
										break;
									}
									if (obj is ILTypeInstance)
									{
										(obj as ILTypeInstance).Clear();
										break;
									}
									throw new NotImplementedException();
								}
								case ObjectTypes.FieldReference:
									obj = managedStack[objectAndResolveReference->Value];
									if (obj != null)
									{
										if (obj is ILTypeInstance)
										{
											if ((obj as ILTypeInstance)[objectAndResolveReference->ValueLow] is ILTypeInstance iLTypeInstance8)
											{
												iLTypeInstance8.Clear();
												break;
											}
											throw new NotSupportedException();
										}
										throw new NotSupportedException();
									}
									throw new NullReferenceException();
								case ObjectTypes.StaticFieldReference:
								{
									IType type10 = AppDomain.GetType(objectAndResolveReference->Value);
									int valueLow26 = objectAndResolveReference->ValueLow;
									if (type10 is ILType)
									{
										if (((ILType)type10).StaticInstance[valueLow26] is ILTypeInstance iLTypeInstance7)
										{
											iLTypeInstance7.Clear();
											break;
										}
										throw new NotSupportedException();
									}
									throw new NotSupportedException();
								}
								default:
									throw new NotImplementedException();
								}
								break;
							}
							PushNull(esp);
							switch (objectAndResolveReference->ObjectType)
							{
							case ObjectTypes.StaticFieldReference:
								(AppDomain.GetType(objectAndResolveReference->Value) as ILType).StaticInstance.AssignFromStack(objectAndResolveReference->ValueLow, esp, AppDomain, managedStack);
								break;
							case ObjectTypes.FieldReference:
								(managedStack[objectAndResolveReference->Value] as ILTypeInstance).AssignFromStack(objectAndResolveReference->ValueLow, esp, AppDomain, managedStack);
								break;
							default:
								if (objectAndResolveReference->ObjectType >= ObjectTypes.Object)
								{
									managedStack[objectAndResolveReference->Value] = null;
									break;
								}
								if (ptr5->ObjectType != ObjectTypes.StackObjectReference)
								{
									WriteNull(ref info, ptr4->Register1);
									break;
								}
								if (objectAndResolveReference >= info.RegisterStart && objectAndResolveReference < info.RegisterEnd)
								{
									short reg = (short)(objectAndResolveReference - info.RegisterStart);
									WriteNull(ref info, reg);
									break;
								}
								throw new NotSupportedException();
							}
							break;
						}
						if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference && IsValueTypeReferenceValid(objectAndResolveReference, type))
						{
							stack.ClearValueTypeObject(type, ResolveReference(objectAndResolveReference));
							break;
						}
						if (objectAndResolveReference->ObjectType == ObjectTypes.FieldReference)
						{
							if (managedStack[objectAndResolveReference->Value] is ILTypeInstance iLTypeInstance9)
							{
								iLTypeInstance9.InitializeField(objectAndResolveReference->ValueLow);
								break;
							}
							throw new NotImplementedException();
						}
						if (type.IsPrimitive || type.IsEnum)
						{
							StackObject.Initialized(objectAndResolveReference, type);
							break;
						}
						if (!type.IsValueType)
						{
							if (objectAndResolveReference->ObjectType >= ObjectTypes.Object)
							{
								managedStack[objectAndResolveReference->Value] = null;
								break;
							}
							if (objectAndResolveReference >= info.RegisterStart && objectAndResolveReference < info.RegisterEnd)
							{
								short reg2 = (short)(objectAndResolveReference - info.RegisterStart);
								WriteNull(ref info, reg2);
								break;
							}
							throw new NotSupportedException();
						}
						CLRType cLRType7 = (CLRType)type;
						if (cLRType7.ValueTypeBinder != null)
						{
							if (objectAndResolveReference >= info.RegisterStart && objectAndResolveReference < info.RegisterEnd)
							{
								stack.AllocValueType(objectAndResolveReference, type, register: true);
								continue;
							}
							throw new NotSupportedException();
						}
						obj = cLRType7.CreateDefaultInstance();
						if (objectAndResolveReference->ObjectType >= ObjectTypes.Object)
						{
							managedStack[objectAndResolveReference->Value] = obj;
							break;
						}
						if (objectAndResolveReference >= info.RegisterStart && objectAndResolveReference < info.RegisterEnd)
						{
							short reg3 = (short)(objectAndResolveReference - info.RegisterStart);
							AssignToRegister(ref info, reg3, obj);
							break;
						}
						throw new NotSupportedException();
					}
					case OpCodeREnum.Castclass:
					{
						StackObject* ptr6 = ptr + ptr4->Register2;
						IType type = domain.GetType(ptr4->Operand);
						if (type != null)
						{
							StackObject* objectAndResolveReference = GetObjectAndResolveReference(ptr6);
							if (objectAndResolveReference->ObjectType <= ObjectTypes.Double)
							{
								throw new NotImplementedException();
							}
							object obj = RetriveObject(objectAndResolveReference, managedStack);
							if (obj != null)
							{
								if (obj is ILTypeInstance)
								{
									if (!((ILTypeInstance)obj).CanAssignTo(type))
									{
										throw new InvalidCastException($"Cannot Cast {((ILTypeInstance)obj).Type.FullName} to {type.FullName}");
									}
									AssignToRegister(ref info, ptr4->Register1, obj);
								}
								else
								{
									if (!type.TypeForCLR.IsAssignableFrom(obj.GetType()))
									{
										throw new InvalidCastException($"Cannot Cast {obj.GetType().FullName} to {type.FullName}");
									}
									AssignToRegister(ref info, ptr4->Register1, obj, isBox: true);
								}
							}
							else
							{
								WriteNull(ref info, ptr4->Register1);
							}
							break;
						}
						throw new NullReferenceException();
					}
					case OpCodeREnum.Isinst:
					{
						StackObject* ptr6 = ptr + ptr4->Register2;
						IType type = domain.GetType(ptr4->Operand);
						if (type != null)
						{
							StackObject* objectAndResolveReference = GetObjectAndResolveReference(ptr6);
							if (objectAndResolveReference->ObjectType <= ObjectTypes.Double)
							{
								Type typeForCLR3 = type.TypeForCLR;
								switch (objectAndResolveReference->ObjectType)
								{
								case ObjectTypes.Integer:
									if (typeForCLR3 != typeof(int) && typeForCLR3 != typeof(bool) && typeForCLR3 != typeof(short) && typeForCLR3 != typeof(byte) && typeForCLR3 != typeof(ushort) && typeForCLR3 != typeof(uint))
									{
										WriteNull(ref info, ptr4->Register1);
									}
									break;
								case ObjectTypes.Long:
									if (typeForCLR3 != typeof(long) && typeForCLR3 != typeof(ulong))
									{
										WriteNull(ref info, ptr4->Register1);
									}
									break;
								case ObjectTypes.Float:
									if (typeForCLR3 != typeof(float))
									{
										WriteNull(ref info, ptr4->Register1);
									}
									break;
								case ObjectTypes.Double:
									if (typeForCLR3 != typeof(double))
									{
										WriteNull(ref info, ptr4->Register1);
									}
									break;
								case ObjectTypes.Null:
									WriteNull(ref info, ptr4->Register1);
									break;
								}
								break;
							}
							object obj = RetriveObject(objectAndResolveReference, managedStack);
							if (obj != null)
							{
								if (obj is ILTypeInstance)
								{
									if (((ILTypeInstance)obj).CanAssignTo(type))
									{
										AssignToRegister(ref info, ptr4->Register1, obj);
									}
									else
									{
										WriteNull(ref info, ptr4->Register1);
									}
								}
								else if (type.TypeForCLR.IsAssignableFrom(obj.GetType()))
								{
									AssignToRegister(ref info, ptr4->Register1, obj, isBox: true);
								}
								else
								{
									WriteNull(ref info, ptr4->Register1);
								}
							}
							else
							{
								WriteNull(ref info, ptr4->Register1);
							}
							break;
						}
						throw new NullReferenceException();
					}
					case OpCodeREnum.Ldftn:
					{
						IMethod method10 = domain.GetMethod(ptr4->Operand2);
						AssignToRegister(ref info, ptr4->Register1, method10);
						break;
					}
					case OpCodeREnum.Ldvirtftn:
					{
						IMethod method7 = domain.GetMethod(ptr4->Operand2);
						StackObject* objectAndResolveReference = ptr + ptr4->Register2;
						if (method7 is ILMethod)
						{
							ILMethod method8 = (ILMethod)method7;
							object obj = managedStack[objectAndResolveReference->Value];
							method7 = ((ILTypeInstance)obj).Type.GetVirtualMethod(method8) as ILMethod;
						}
						else
						{
							object obj = managedStack[objectAndResolveReference->Value];
							if (obj is ILTypeInstance)
							{
								method7 = ((ILTypeInstance)obj).Type.GetVirtualMethod(method7);
							}
							else if (obj is CrossBindingAdaptorType)
							{
								method7 = ((CrossBindingAdaptorType)obj).ILInstance.Type.BaseType.GetVirtualMethod(method7);
							}
						}
						AssignToRegister(ref info, ptr4->Register1, method7);
						break;
					}
					case OpCodeREnum.Ceq:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						bool flag18 = false;
						if (ptr5->ObjectType == ptr6->ObjectType)
						{
							switch (ptr5->ObjectType)
							{
							case ObjectTypes.Integer:
							case ObjectTypes.Float:
								flag18 = ptr5->Value == ptr6->Value;
								break;
							case ObjectTypes.Object:
								flag18 = managedStack[ptr5->Value] == managedStack[ptr6->Value];
								break;
							case ObjectTypes.FieldReference:
								flag18 = managedStack[ptr5->Value] == managedStack[ptr6->Value] && ptr5->ValueLow == ptr6->ValueLow;
								break;
							case ObjectTypes.Null:
								flag18 = true;
								break;
							default:
								flag18 = ptr5->Value == ptr6->Value && ptr5->ValueLow == ptr6->ValueLow;
								break;
							}
						}
						else
						{
							switch (ptr5->ObjectType)
							{
							case ObjectTypes.Object:
								flag18 = managedStack[ptr5->Value] == null && ptr6->ObjectType == ObjectTypes.Null;
								break;
							case ObjectTypes.Null:
								flag18 = ptr6->ObjectType == ObjectTypes.Object && managedStack[ptr6->Value] == null;
								break;
							}
						}
						if (flag18)
						{
							WriteOne(ptr7);
						}
						else
						{
							WriteZero(ptr7);
						}
						break;
					}
					case OpCodeREnum.Ceqi:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						bool flag17 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Float => *(float*)(&ptr5->Value) == ptr4->OperandFloat, 
							ObjectTypes.Long => *(long*)(&ptr5->Value) == ptr4->OperandLong, 
							ObjectTypes.Double => *(double*)(&ptr5->Value) == ptr4->OperandDouble, 
							ObjectTypes.Integer => ptr5->Value == ptr4->Operand, 
							ObjectTypes.Null => ptr4->Operand == 0, 
							_ => throw new NotImplementedException(), 
						})
						{
							WriteOne(ptr7);
						}
						else
						{
							WriteZero(ptr7);
						}
						break;
					}
					case OpCodeREnum.Clt:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						bool flag16 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ptr5->Value < ptr6->Value, 
							ObjectTypes.Long => *(long*)(&ptr5->Value) < *(long*)(&ptr6->Value), 
							ObjectTypes.Float => *(float*)(&ptr5->Value) < *(float*)(&ptr6->Value), 
							ObjectTypes.Double => *(double*)(&ptr5->Value) < *(double*)(&ptr6->Value), 
							_ => throw new NotImplementedException(), 
						})
						{
							WriteOne(ptr7);
						}
						else
						{
							WriteZero(ptr7);
						}
						break;
					}
					case OpCodeREnum.Clti:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						bool flag15 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ptr5->Value < ptr4->Operand, 
							ObjectTypes.Long => *(long*)(&ptr5->Value) < ptr4->OperandLong, 
							ObjectTypes.Float => *(float*)(&ptr5->Value) < ptr4->OperandFloat, 
							ObjectTypes.Double => *(double*)(&ptr5->Value) < ptr4->OperandDouble, 
							_ => throw new NotImplementedException(), 
						})
						{
							WriteOne(ptr7);
						}
						else
						{
							WriteZero(ptr7);
						}
						break;
					}
					case OpCodeREnum.Clt_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						bool flag13 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (uint)ptr5->Value < (uint)ptr6->Value && ptr6->ObjectType != ObjectTypes.Null, 
							ObjectTypes.Long => (ulong)(*(long*)(&ptr5->Value)) < (ulong)(*(long*)(&ptr6->Value)) && ptr6->ObjectType != ObjectTypes.Null, 
							ObjectTypes.Float => *(float*)(&ptr5->Value) < *(float*)(&ptr6->Value) && ptr6->ObjectType != ObjectTypes.Null, 
							ObjectTypes.Double => *(double*)(&ptr5->Value) < *(double*)(&ptr6->Value) && ptr6->ObjectType != ObjectTypes.Null, 
							_ => throw new NotImplementedException(), 
						})
						{
							WriteOne(ptr7);
						}
						else
						{
							WriteZero(ptr7);
						}
						break;
					}
					case OpCodeREnum.Clti_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						bool flag12 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (uint)ptr5->Value < (uint)ptr4->Operand, 
							ObjectTypes.Long => (ulong)(*(long*)(&ptr5->Value)) < (ulong)ptr4->OperandLong, 
							ObjectTypes.Float => *(float*)(&ptr5->Value) < ptr4->OperandFloat, 
							ObjectTypes.Double => *(double*)(&ptr5->Value) < ptr4->OperandDouble, 
							_ => throw new NotImplementedException(), 
						})
						{
							WriteOne(ptr7);
						}
						else
						{
							WriteZero(ptr7);
						}
						break;
					}
					case OpCodeREnum.Cgt:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						bool flag11 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ptr5->Value > ptr6->Value || ptr6->ObjectType == ObjectTypes.Null, 
							ObjectTypes.Long => *(long*)(&ptr5->Value) > *(long*)(&ptr6->Value) || ptr6->ObjectType == ObjectTypes.Null, 
							ObjectTypes.Float => *(float*)(&ptr5->Value) > *(float*)(&ptr6->Value) || ptr6->ObjectType == ObjectTypes.Null, 
							ObjectTypes.Double => *(double*)(&ptr5->Value) > *(double*)(&ptr6->Value) || ptr6->ObjectType == ObjectTypes.Null, 
							_ => throw new NotImplementedException(), 
						})
						{
							WriteOne(ptr7);
						}
						else
						{
							WriteZero(ptr7);
						}
						break;
					}
					case OpCodeREnum.Cgti:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						bool flag10 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => ptr5->Value > ptr4->Operand, 
							ObjectTypes.Long => *(long*)(&ptr5->Value) > ptr4->OperandLong, 
							ObjectTypes.Float => *(float*)(&ptr5->Value) > ptr4->OperandFloat, 
							ObjectTypes.Double => *(double*)(&ptr5->Value) > ptr4->OperandDouble, 
							_ => throw new NotImplementedException(), 
						})
						{
							WriteOne(ptr7);
						}
						else
						{
							WriteZero(ptr7);
						}
						break;
					}
					case OpCodeREnum.Cgt_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr6 = ptr + ptr4->Register3;
						StackObject* ptr7 = ptr + ptr4->Register1;
						bool flag9 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (uint)ptr5->Value > (uint)ptr6->Value || ptr6->ObjectType == ObjectTypes.Null, 
							ObjectTypes.Long => (ulong)(*(long*)(&ptr5->Value)) > (ulong)(*(long*)(&ptr6->Value)) || ptr6->ObjectType == ObjectTypes.Null, 
							ObjectTypes.Float => *(float*)(&ptr5->Value) > *(float*)(&ptr6->Value) || ptr6->ObjectType == ObjectTypes.Null, 
							ObjectTypes.Double => *(double*)(&ptr5->Value) > *(double*)(&ptr6->Value) || ptr6->ObjectType == ObjectTypes.Null, 
							ObjectTypes.Object => managedStack[ptr5->Value] != null && (ptr6->ObjectType == ObjectTypes.Null || managedStack[ptr6->Value] == null), 
							ObjectTypes.Null => false, 
							_ => throw new NotImplementedException(), 
						})
						{
							WriteOne(ptr7);
						}
						else
						{
							WriteZero(ptr7);
						}
						break;
					}
					case OpCodeREnum.Cgti_Un:
					{
						StackObject* ptr5 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						bool flag8 = false;
						if (ptr5->ObjectType switch
						{
							ObjectTypes.Integer => (uint)ptr5->Value > (uint)ptr4->Operand, 
							ObjectTypes.Long => (ulong)(*(long*)(&ptr5->Value)) > (ulong)ptr4->OperandLong, 
							ObjectTypes.Float => *(float*)(&ptr5->Value) > ptr4->OperandFloat, 
							ObjectTypes.Double => *(double*)(&ptr5->Value) > ptr4->OperandDouble, 
							ObjectTypes.Object => managedStack[ptr5->Value] != null && ptr4->Operand != 0, 
							ObjectTypes.Null => false, 
							_ => throw new NotImplementedException(), 
						})
						{
							WriteOne(ptr7);
						}
						else
						{
							WriteZero(ptr7);
						}
						break;
					}
					case OpCodeREnum.Newarr:
					{
						StackObject* ptr6 = ptr + ptr4->Register2;
						IType type = domain.GetType(ptr4->Operand);
						object obj7 = null;
						if (type != null)
						{
							if (type.TypeForCLR != typeof(ILTypeInstance))
							{
								obj7 = ((!(type is CLRType)) ? Array.CreateInstance(type.TypeForCLR, ptr6->Value) : ((CLRType)type).CreateArrayInstance(ptr6->Value));
								AppDomain.GetType(obj7.GetType());
							}
							else
							{
								obj7 = new ILTypeInstance[ptr6->Value];
								ILTypeInstance[] array25 = (ILTypeInstance[])obj7;
								if (type.IsValueType)
								{
									for (int m = 0; m < ptr6->Value; m++)
									{
										array25[m] = ((ILType)type).Instantiate();
									}
								}
							}
						}
						AssignToRegister(ref info, ptr4->Register1, obj7);
						break;
					}
					case OpCodeREnum.Stelem_Ref:
					case OpCodeREnum.Stelem_Any:
					{
						StackObject* ptr5 = ptr + ptr4->Register3;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register1;
						StackObject* ptr11 = GetObjectAndResolveReference(ptr5);
						Array array24 = managedStack[ptr7->Value] as Array;
						if (array24 is object[])
						{
							switch (ptr11->ObjectType)
							{
							case ObjectTypes.Null:
								array24.SetValue(null, ptr6->Value);
								break;
							case ObjectTypes.Object:
								ArraySetValue(array24, managedStack[ptr11->Value], ptr6->Value);
								break;
							case ObjectTypes.Integer:
								array24.SetValue(ptr11->Value, ptr6->Value);
								break;
							case ObjectTypes.Long:
								array24.SetValue(*(long*)(&ptr11->Value), ptr6->Value);
								break;
							case ObjectTypes.Float:
								array24.SetValue(*(float*)(&ptr11->Value), ptr6->Value);
								break;
							case ObjectTypes.Double:
								array24.SetValue(*(double*)(&ptr11->Value), ptr6->Value);
								break;
							case ObjectTypes.ValueTypeObjectReference:
								ArraySetValue(array24, StackObject.ToObject(ptr11, domain, managedStack), ptr6->Value);
								FreeStackValueType(esp - 1);
								break;
							default:
								throw new NotImplementedException();
							}
							break;
						}
						switch (ptr11->ObjectType)
						{
						case ObjectTypes.Object:
							ArraySetValue(array24, managedStack[ptr11->Value], ptr6->Value);
							break;
						case ObjectTypes.Integer:
							StoreIntValueToArray(array24, ptr11, ptr6);
							break;
						case ObjectTypes.Long:
							if (array24 is long[])
							{
								((long[])array24)[ptr6->Value] = *(long*)(&ptr11->Value);
							}
							else
							{
								((ulong[])array24)[ptr6->Value] = *(ulong*)(&ptr11->Value);
							}
							break;
						case ObjectTypes.Float:
							((float[])array24)[ptr6->Value] = *(float*)(&ptr11->Value);
							break;
						case ObjectTypes.Double:
							((double[])array24)[ptr6->Value] = *(double*)(&ptr11->Value);
							break;
						case ObjectTypes.ValueTypeObjectReference:
							ArraySetValue(array24, StackObject.ToObject(ptr11, domain, managedStack), ptr6->Value);
							FreeStackValueType(esp - 1);
							break;
						default:
							throw new NotImplementedException();
						}
						break;
					}
					case OpCodeREnum.Stelem_I1:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						if (managedStack[ptr5->Value] is byte[] array22)
						{
							array22[ptr6->Value] = (byte)ptr7->Value;
						}
						else if (managedStack[ptr5->Value] is bool[] array23)
						{
							array23[ptr6->Value] = ptr7->Value == 1;
						}
						else
						{
							(managedStack[ptr5->Value] as sbyte[])[ptr6->Value] = (sbyte)ptr7->Value;
						}
						break;
					}
					case OpCodeREnum.Stelem_I2:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						if (managedStack[ptr5->Value] is short[] array20)
						{
							array20[ptr6->Value] = (short)ptr7->Value;
						}
						else if (managedStack[ptr5->Value] is ushort[] array21)
						{
							array21[ptr6->Value] = (ushort)ptr7->Value;
						}
						else
						{
							(managedStack[ptr5->Value] as char[])[ptr6->Value] = (char)ptr7->Value;
						}
						break;
					}
					case OpCodeREnum.Stelem_I4:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						if (managedStack[ptr5->Value] is int[] array19)
						{
							array19[ptr6->Value] = ptr7->Value;
						}
						else
						{
							(managedStack[ptr5->Value] as uint[])[ptr6->Value] = (uint)ptr7->Value;
						}
						break;
					}
					case OpCodeREnum.Stelem_R4:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						(managedStack[ptr5->Value] as float[])[ptr6->Value] = *(float*)(&ptr7->Value);
						break;
					}
					case OpCodeREnum.Stelem_I8:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						if (managedStack[ptr5->Value] is long[] array18)
						{
							array18[ptr6->Value] = *(long*)(&ptr7->Value);
						}
						else
						{
							(managedStack[ptr5->Value] as ulong[])[ptr6->Value] = *(ulong*)(&ptr7->Value);
						}
						break;
					}
					case OpCodeREnum.Stelem_R8:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						(managedStack[ptr5->Value] as double[])[ptr6->Value] = *(double*)(&ptr7->Value);
						break;
					}
					case OpCodeREnum.Ldlen:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						Array array17 = managedStack[ptr6->Value] as Array;
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = array17.Length;
						break;
					}
					case OpCodeREnum.Ldelema:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						Array value = managedStack[ptr6->Value] as Array;
						num4 = ptr7->Value;
						ptr5->ObjectType = ObjectTypes.ArrayReference;
						ptr5->Value = GetManagedStackIndex(ref info, ptr4->Register1);
						managedStack[ptr5->Value] = value;
						ptr5->ValueLow = num4;
						break;
					}
					case OpCodeREnum.Ldelem_Ref:
					case OpCodeREnum.Ldelem_Any:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						Array array15 = managedStack[ptr6->Value] as Array;
						object obj = ((array15 is ILTypeInstance[] array16) ? array16[ptr7->Value] : array15.GetValue(ptr7->Value));
						if (obj is CrossBindingAdaptorType)
						{
							obj = ((CrossBindingAdaptorType)obj).ILInstance;
						}
						if (obj is ILTypeInstance)
						{
							ILTypeInstance iLTypeInstance = (ILTypeInstance)obj;
							if (!(iLTypeInstance is DelegateAdapter) && iLTypeInstance.Type.IsValueType && !iLTypeInstance.Boxed)
							{
								AllocValueType(ptr5, iLTypeInstance.Type);
								StackObject* ptr8 = ResolveReference(ptr5);
								iLTypeInstance.CopyValueTypeToStack(ptr8, managedStack);
							}
							else
							{
								AssignToRegister(ref info, ptr4->Register1, obj, isBox: true);
							}
						}
						else
						{
							AssignToRegister(ref info, ptr4->Register1, obj, !array15.GetType().GetElementType().IsPrimitive);
						}
						break;
					}
					case OpCodeREnum.Ldelem_I1:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						if (managedStack[ptr6->Value] is bool[] array13)
						{
							ptr5->ObjectType = ObjectTypes.Integer;
							ptr5->Value = (array13[ptr7->Value] ? 1 : 0);
						}
						else
						{
							sbyte[] array14 = managedStack[ptr6->Value] as sbyte[];
							ptr5->ObjectType = ObjectTypes.Integer;
							ptr5->Value = array14[ptr7->Value];
						}
						break;
					}
					case OpCodeREnum.Ldelem_U1:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						if (managedStack[ptr6->Value] is byte[] array11)
						{
							ptr5->ObjectType = ObjectTypes.Integer;
							ptr5->Value = array11[ptr7->Value];
						}
						else
						{
							bool[] array12 = managedStack[ptr6->Value] as bool[];
							ptr5->ObjectType = ObjectTypes.Integer;
							ptr5->Value = (array12[ptr7->Value] ? 1 : 0);
						}
						break;
					}
					case OpCodeREnum.Ldelem_I2:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						if (managedStack[ptr6->Value] is short[] array9)
						{
							ptr5->ObjectType = ObjectTypes.Integer;
							ptr5->Value = array9[ptr7->Value];
						}
						else
						{
							char[] array10 = managedStack[ptr6->Value] as char[];
							ptr5->ObjectType = ObjectTypes.Integer;
							ptr5->Value = array10[ptr7->Value];
						}
						break;
					}
					case OpCodeREnum.Ldelem_U2:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						if (managedStack[ptr6->Value] is ushort[] array7)
						{
							ptr5->ObjectType = ObjectTypes.Integer;
							ptr5->Value = array7[ptr7->Value];
						}
						else
						{
							char[] array8 = managedStack[ptr6->Value] as char[];
							ptr5->ObjectType = ObjectTypes.Integer;
							ptr5->Value = array8[ptr7->Value];
						}
						break;
					}
					case OpCodeREnum.Ldelem_I4:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						int[] array6 = managedStack[ptr6->Value] as int[];
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = array6[ptr7->Value];
						break;
					}
					case OpCodeREnum.Ldelem_U4:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						uint[] array5 = managedStack[ptr6->Value] as uint[];
						ptr5->ObjectType = ObjectTypes.Integer;
						ptr5->Value = (int)array5[ptr7->Value];
						break;
					}
					case OpCodeREnum.Ldelem_I8:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						if (managedStack[ptr6->Value] is long[] array3)
						{
							ptr5->ObjectType = ObjectTypes.Long;
							*(long*)(&ptr5->Value) = array3[ptr7->Value];
						}
						else
						{
							ulong[] array4 = managedStack[ptr6->Value] as ulong[];
							ptr5->ObjectType = ObjectTypes.Long;
							*(ulong*)(&ptr5->Value) = array4[ptr7->Value];
						}
						break;
					}
					case OpCodeREnum.Ldelem_R4:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						float[] array2 = managedStack[ptr6->Value] as float[];
						ptr5->ObjectType = ObjectTypes.Float;
						*(float*)(&ptr5->Value) = array2[ptr7->Value];
						break;
					}
					case OpCodeREnum.Ldelem_R8:
					{
						StackObject* ptr5 = ptr + ptr4->Register1;
						StackObject* ptr6 = ptr + ptr4->Register2;
						StackObject* ptr7 = ptr + ptr4->Register3;
						double[] array = managedStack[ptr6->Value] as double[];
						ptr5->ObjectType = ObjectTypes.Double;
						*(double*)(&ptr5->Value) = array[ptr7->Value];
						break;
					}
					case OpCodeREnum.Throw:
					{
						StackObject* objectAndResolveReference = GetObjectAndResolveReference(ptr + ptr4->Register1);
						throw managedStack[objectAndResolveReference->Value] as Exception;
					}
					case OpCodeREnum.Rethrow:
						throw ex;
					default:
						{
							throw new NotSupportedException("Not supported opcode " + code);
						}
						IL_4c99:
						ptr4 = ptr3 + ptr4->Operand;
						goto end_IL_0245;
					}
					ptr4++;
					end_IL_0245:;
				}
				catch (Exception ex2)
				{
					if (exceptionHandlerRegister == null)
					{
						goto IL_95ab;
					}
					int addr2 = (int)(ptr4 - ptr3);
					ILRuntime.CLR.Method.ExceptionHandler correspondingExceptionHandler = GetCorrespondingExceptionHandler(exceptionHandlerRegister, ex2, addr2, ILRuntime.CLR.Method.ExceptionHandlerType.Catch, explicitMatch: true);
					if (correspondingExceptionHandler == null)
					{
						correspondingExceptionHandler = GetCorrespondingExceptionHandler(exceptionHandlerRegister, ex2, addr2, ILRuntime.CLR.Method.ExceptionHandlerType.Catch, explicitMatch: false);
					}
					if (correspondingExceptionHandler != null)
					{
						if (ex2 is ILRuntimeException)
						{
							ILRuntimeException ex3 = (ILRuntimeException)ex2;
							Exception innerException = ex3.InnerException;
							innerException.Data["ThisInfo"] = ex3.ThisInfo;
							innerException.Data["StackTrace"] = (innerException.Data.Contains("StackTrace") ? string.Format("{0}\n--- End of stack trace from previous location ---\n{1}", ex3.StackTrace, innerException.Data["StackTrace"]) : ex3.StackTrace);
							innerException.Data["LocalInfo"] = ex3.LocalInfo;
							ex2 = innerException;
						}
						else
						{
							DebugService debugService = AppDomain.DebugService;
							if (method.HasThis)
							{
								ex2.Data["ThisInfo"] = debugService.GetThisInfo(this);
							}
							else
							{
								ex2.Data["ThisInfo"] = "";
							}
							ex2.Data["StackTrace"] = (ex2.Data.Contains("StackTrace") ? string.Format("{0}\n--- End of stack trace from previous location ---\n{1}", debugService.GetStackTrace(this), ex2.Data["StackTrace"]) : debugService.GetStackTrace(this));
							ex2.Data["LocalInfo"] = debugService.GetLocalVariableInfo(this);
						}
						while (stack.Frames.Peek().BasePointer != res.BasePointer)
						{
							StackFrame frame = stack.Frames.Peek();
							esp = stack.PopFrame(ref frame, esp);
							if (frame.Method.ReturnType != AppDomain.VoidType)
							{
								Free(esp - 1);
								esp--;
							}
						}
						ex = ex2;
						short reg4 = (short)(num2 + localVariableCount);
						AssignToRegister(ref info, reg4, ex2);
						unhandledException = false;
						ILRuntime.CLR.Method.ExceptionHandler exceptionHandler3 = FindExceptionHandlerByBranchTarget(addr2, correspondingExceptionHandler.HandlerStart, exceptionHandlerRegister);
						if (exceptionHandler3 != null)
						{
							num = correspondingExceptionHandler.HandlerStart;
							ptr4 = ptr3 + exceptionHandler3.HandlerStart;
						}
						else
						{
							ptr4 = ptr3 + correspondingExceptionHandler.HandlerStart;
						}
					}
					else
					{
						correspondingExceptionHandler = GetCorrespondingExceptionHandler(exceptionHandlerRegister, null, addr2, ILRuntime.CLR.Method.ExceptionHandlerType.Fault, explicitMatch: false);
						if (correspondingExceptionHandler == null)
						{
							correspondingExceptionHandler = GetCorrespondingExceptionHandler(exceptionHandlerRegister, null, addr2, ILRuntime.CLR.Method.ExceptionHandlerType.Finally, explicitMatch: false);
						}
						if (correspondingExceptionHandler == null)
						{
							goto IL_95ab;
						}
						unhandledException = false;
						num = -1;
						ex = ((ex2 is ILRuntimeException) ? ex2 : new ILRuntimeException(ex2.Message, this, method, ex2));
						ptr4 = ptr3 + correspondingExceptionHandler.HandlerStart;
					}
					goto end_IL_92d8;
					IL_95ab:
					if (unhandledException)
					{
						throw ex2;
					}
					unhandledException = true;
					flag2 = true;
					throw new ILRuntimeException(ex2.Message, this, method, ex2);
					end_IL_92d8:;
				}
			}
		}
		return stack.PopFrame(ref res, esp);
	}

	private unsafe bool IsValueTypeReferenceValid(StackObject* ptr, IType type)
	{
		ptr = ResolveReference(ptr);
		if (ptr->ObjectType == ObjectTypes.ValueTypeDescriptor)
		{
			if (ptr->Value == type.TypeIndex)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private unsafe void LoadFromFieldReferenceToRegister(ref RegisterFrameInfo info, object obj, int idx, short reg)
	{
		if (obj is ILTypeInstance)
		{
			((ILTypeInstance)obj).CopyToRegister(idx, ref info, reg);
			return;
		}
		CLRType cLRType = AppDomain.GetType(obj.GetType()) as CLRType;
		StackObject stackObject = default(StackObject);
		StackObject* esp = &stackObject;
		UncheckedList<object> managedStack = info.ManagedStack;
		if (!cLRType.CopyFieldToStack(idx, obj, this, ref esp, managedStack))
		{
			AssignToRegister(ref info, reg, cLRType.GetFieldValue(idx, obj));
		}
		else
		{
			PopToRegister(ref info, reg, esp);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal unsafe void CopyToRegister(ref RegisterFrameInfo info, short reg, StackObject* val, UncheckedList<object> mStackSrc = null)
	{
		UncheckedList<object> managedStack = info.ManagedStack;
		StackObject* ptr = info.RegisterStart + reg;
		int managedStackIndex = GetManagedStackIndex(ref info, reg);
		if (mStackSrc == null)
		{
			mStackSrc = managedStack;
		}
		switch (val->ObjectType)
		{
		case ObjectTypes.Null:
			ptr->ObjectType = ObjectTypes.Object;
			ptr->Value = managedStackIndex;
			managedStack[managedStackIndex] = null;
			break;
		case ObjectTypes.StaticFieldReference:
		{
			IType type2 = info.Intepreter.AppDomain.GetType(val->Value);
			if (type2 is ILType)
			{
				ILType iLType = type2 as ILType;
				if (iLType.IsValueType)
				{
					if (ptr->ObjectType == ObjectTypes.ValueTypeObjectReference && (*(StackObject**)(&ptr->Value))->Value != iLType.TypeIndex)
					{
						stack.FreeRegisterValueType(ptr);
						stack.AllocValueType(ptr, iLType, register: true);
					}
					iLType.StaticInstance.CopyToRegister(val->ValueLow, ref info, reg);
				}
				else if (iLType.IsPrimitive)
				{
					iLType.StaticInstance.PushToStack(val->ValueLow, ptr, info.Intepreter, managedStack);
				}
				else
				{
					ptr->ObjectType = ObjectTypes.Object;
					ptr->Value = managedStackIndex;
					managedStack[managedStackIndex] = iLType.StaticInstance[val->ValueLow];
				}
				break;
			}
			CLRType cLRType2 = type2 as CLRType;
			if (cLRType2.ValueTypeBinder != null)
			{
				if (ptr->ObjectType == ObjectTypes.ValueTypeObjectReference && (*(StackObject**)(&ptr->Value))->Value != cLRType2.TypeIndex)
				{
					stack.FreeRegisterValueType(ptr);
					stack.AllocValueType(ptr, cLRType2, register: true);
				}
				StackObject stackObject = default(StackObject);
				StackObject* esp = &stackObject;
				if (!cLRType2.CopyFieldToStack(val->ValueLow, null, this, ref esp, managedStack))
				{
					object obj2 = ((CLRType)type2).GetFieldValue(val->ValueLow, null);
					if (obj2 is CrossBindingAdaptorType)
					{
						obj2 = ((CrossBindingAdaptorType)obj2).ILInstance;
					}
					AssignToRegister(ref info, reg, obj2);
				}
				else
				{
					PopToRegister(ref info, reg, esp);
				}
			}
			else
			{
				object obj3 = cLRType2.GetFieldValue(val->ValueLow, null);
				if (obj3 is CrossBindingAdaptorType)
				{
					obj3 = ((CrossBindingAdaptorType)obj3).ILInstance;
				}
				ptr->ObjectType = ObjectTypes.Object;
				ptr->Value = managedStackIndex;
				managedStack[managedStackIndex] = obj3;
			}
			break;
		}
		case ObjectTypes.Object:
		case ObjectTypes.FieldReference:
		case ObjectTypes.ArrayReference:
			if (ptr->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				object obj = mStackSrc[val->Value];
				if (obj is ILTypeInstance)
				{
					ILType type = ((ILTypeInstance)obj).Type;
					if (type != null && type.IsValueType)
					{
						StackObject* ptr5 = *(StackObject**)(&ptr->Value);
						if (ptr5->Value != type.TypeIndex)
						{
							stack.FreeRegisterValueType(ptr);
							stack.AllocValueType(ptr, type, register: true);
							ptr5 = *(StackObject**)(&ptr->Value);
						}
						((ILTypeInstance)obj).CopyValueTypeToStack(ptr5, managedStack);
					}
					else
					{
						ptr->ObjectType = ObjectTypes.Object;
						ptr->Value = managedStackIndex;
						managedStack[managedStackIndex] = obj;
					}
				}
				else if (obj != null)
				{
					CLRType cLRType = domain.GetType(obj.GetType()) as CLRType;
					ValueTypeBinder valueTypeBinder = cLRType.ValueTypeBinder;
					if (valueTypeBinder != null)
					{
						StackObject* ptr6 = *(StackObject**)(&ptr->Value);
						if (ptr6->Value != cLRType.TypeIndex)
						{
							stack.FreeRegisterValueType(ptr);
							stack.AllocValueType(ptr, cLRType, register: true);
							ptr6 = *(StackObject**)(&ptr->Value);
						}
						valueTypeBinder.CopyValueTypeToStack(obj, ptr6, managedStack);
					}
					else
					{
						ptr->ObjectType = ObjectTypes.Object;
						ptr->Value = managedStackIndex;
						managedStack[managedStackIndex] = obj;
					}
				}
				else
				{
					ptr->ObjectType = ObjectTypes.Object;
					ptr->Value = managedStackIndex;
					managedStack[managedStackIndex] = obj;
				}
			}
			else
			{
				*ptr = *val;
				bool flag2 = ptr >= info.RegisterStart && ptr < info.StackRegisterStart;
				managedStack[managedStackIndex] = (flag2 ? CheckAndCloneValueType(mStackSrc[ptr->Value], domain) : mStackSrc[ptr->Value]);
				ptr->Value = managedStackIndex;
			}
			break;
		case ObjectTypes.ValueTypeObjectReference:
			if (ptr->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				bool flag = false;
				if (!CanCopyStackValueType(val, ptr))
				{
					StackObject* ptr2 = *(StackObject**)(&val->Value);
					IType typeByIndex = domain.GetTypeByIndex(ptr2->Value);
					stack.FreeRegisterValueType(ptr);
					StackObject* ptr3 = null;
					int start = int.MaxValue;
					int end = 0;
					stack.CountValueTypeManaged(ptr, ref start, ref end, &ptr3);
					flag = val <= ResolveReference(ptr) && val > ptr3;
					stack.AllocValueType(ptr, typeByIndex, register: true, flag);
				}
				CopyStackValueType(val, ptr, managedStack);
			}
			else
			{
				if (ptr < info.RegisterStart || ptr >= info.RegisterEnd)
				{
					throw new NotImplementedException();
				}
				StackObject* ptr4 = ResolveReference(val);
				IType typeByIndex2 = domain.GetTypeByIndex(ptr4->Value);
				stack.AllocValueType(ptr, typeByIndex2, register: true);
				CopyStackValueType(val, ptr, managedStack);
			}
			break;
		default:
			*ptr = *val;
			managedStack[managedStackIndex] = null;
			break;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int GetManagedStackIndex(ref RegisterFrameInfo info, short reg)
	{
		return info.FrameManagedBase + reg;
	}

	internal unsafe static void AssignToRegister(ref RegisterFrameInfo info, short reg, object obj, bool isBox = false)
	{
		UncheckedList<object> managedStack = info.ManagedStack;
		StackObject* ptr = info.RegisterStart + reg;
		int managedStackIndex = GetManagedStackIndex(ref info, reg);
		if (obj != null)
		{
			if (!isBox)
			{
				ILRuntime.CLR.Utils.Extensions.TypeFlags typeFlags = obj.GetType().GetTypeFlags();
				if ((typeFlags & ILRuntime.CLR.Utils.Extensions.TypeFlags.IsPrimitive) != ILRuntime.CLR.Utils.Extensions.TypeFlags.Default)
				{
					UnboxObject(ptr, obj, managedStack);
				}
				else if ((typeFlags & ILRuntime.CLR.Utils.Extensions.TypeFlags.IsEnum) != ILRuntime.CLR.Utils.Extensions.TypeFlags.Default)
				{
					ptr->ObjectType = ObjectTypes.Integer;
					ptr->Value = Convert.ToInt32(obj);
				}
				else
				{
					ptr->ObjectType = ObjectTypes.Object;
					ptr->Value = managedStackIndex;
					managedStack[managedStackIndex] = obj;
				}
			}
			else
			{
				ptr->ObjectType = ObjectTypes.Object;
				ptr->Value = managedStackIndex;
				managedStack[managedStackIndex] = obj;
			}
		}
		else
		{
			ptr->ObjectType = ObjectTypes.Object;
			ptr->Value = managedStackIndex;
			managedStack[managedStackIndex] = null;
		}
	}

	private unsafe StackObject* PopToRegister(ref RegisterFrameInfo info, short reg, StackObject* esp)
	{
		StackObject* ptr = esp - 1;
		if (ptr->ObjectType == ObjectTypes.ValueTypeObjectReference)
		{
			StackObject* ptr2 = info.RegisterStart + reg;
			if (CanCopyStackValueType(ptr, ptr2))
			{
				CopyStackValueType(ptr, ptr2, info.ManagedStack);
				Free(ptr);
			}
			else
			{
				if (ptr2->ObjectType == ObjectTypes.ValueTypeObjectReference)
				{
					stack.FreeRegisterValueType(ptr2);
				}
				stack.AllocValueTypeAndCopy(ptr2, ptr);
			}
		}
		else
		{
			CopyToRegister(ref info, reg, ptr);
			Free(ptr);
		}
		return ptr;
	}

	public unsafe static void WriteOne(StackObject* esp)
	{
		esp->ObjectType = ObjectTypes.Integer;
		esp->Value = 1;
	}

	public unsafe static void WriteZero(StackObject* esp)
	{
		esp->ObjectType = ObjectTypes.Integer;
		esp->Value = 0;
	}

	internal unsafe static void WriteNull(ref RegisterFrameInfo info, short reg)
	{
		StackObject* num = info.RegisterStart + reg;
		int managedStackIndex = GetManagedStackIndex(ref info, reg);
		num->ObjectType = ObjectTypes.Object;
		num->Value = managedStackIndex;
		num->ValueLow = 0;
		info.ManagedStack[managedStackIndex] = null;
	}
}
