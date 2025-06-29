namespace System.Linq.Expressions;

internal static class Strings
{
	internal static string MethodPreconditionViolated => SR.GetString("MethodPreconditionViolated");

	internal static string InvalidArgumentValue => SR.GetString("InvalidArgumentValue");

	internal static string NonEmptyCollectionRequired => SR.GetString("NonEmptyCollectionRequired");

	internal static string ArgCntMustBeGreaterThanNameCnt => SR.GetString("ArgCntMustBeGreaterThanNameCnt");

	internal static string ReducibleMustOverrideReduce => SR.GetString("ReducibleMustOverrideReduce");

	internal static string MustReduceToDifferent => SR.GetString("MustReduceToDifferent");

	internal static string ReducedNotCompatible => SR.GetString("ReducedNotCompatible");

	internal static string SetterHasNoParams => SR.GetString("SetterHasNoParams");

	internal static string PropertyCannotHaveRefType => SR.GetString("PropertyCannotHaveRefType");

	internal static string IndexesOfSetGetMustMatch => SR.GetString("IndexesOfSetGetMustMatch");

	internal static string AccessorsCannotHaveVarArgs => SR.GetString("AccessorsCannotHaveVarArgs");

	internal static string AccessorsCannotHaveByRefArgs => SR.GetString("AccessorsCannotHaveByRefArgs");

	internal static string BoundsCannotBeLessThanOne => SR.GetString("BoundsCannotBeLessThanOne");

	internal static string TypeMustNotBeByRef => SR.GetString("TypeMustNotBeByRef");

	internal static string TypeDoesNotHaveConstructorForTheSignature => SR.GetString("TypeDoesNotHaveConstructorForTheSignature");

	internal static string CountCannotBeNegative => SR.GetString("CountCannotBeNegative");

	internal static string ArrayTypeMustBeArray => SR.GetString("ArrayTypeMustBeArray");

	internal static string SetterMustBeVoid => SR.GetString("SetterMustBeVoid");

	internal static string PropertyTyepMustMatchSetter => SR.GetString("PropertyTyepMustMatchSetter");

	internal static string BothAccessorsMustBeStatic => SR.GetString("BothAccessorsMustBeStatic");

	internal static string OnlyStaticFieldsHaveNullInstance => SR.GetString("OnlyStaticFieldsHaveNullInstance");

	internal static string OnlyStaticPropertiesHaveNullInstance => SR.GetString("OnlyStaticPropertiesHaveNullInstance");

	internal static string OnlyStaticMethodsHaveNullInstance => SR.GetString("OnlyStaticMethodsHaveNullInstance");

	internal static string PropertyTypeCannotBeVoid => SR.GetString("PropertyTypeCannotBeVoid");

	internal static string InvalidUnboxType => SR.GetString("InvalidUnboxType");

	internal static string ExpressionMustBeReadable => SR.GetString("ExpressionMustBeReadable");

	internal static string ExpressionMustBeWriteable => SR.GetString("ExpressionMustBeWriteable");

	internal static string ArgumentMustNotHaveValueType => SR.GetString("ArgumentMustNotHaveValueType");

	internal static string MustBeReducible => SR.GetString("MustBeReducible");

	internal static string AllTestValuesMustHaveSameType => SR.GetString("AllTestValuesMustHaveSameType");

	internal static string AllCaseBodiesMustHaveSameType => SR.GetString("AllCaseBodiesMustHaveSameType");

	internal static string DefaultBodyMustBeSupplied => SR.GetString("DefaultBodyMustBeSupplied");

	internal static string MethodBuilderDoesNotHaveTypeBuilder => SR.GetString("MethodBuilderDoesNotHaveTypeBuilder");

	internal static string TypeMustBeDerivedFromSystemDelegate => SR.GetString("TypeMustBeDerivedFromSystemDelegate");

	internal static string ArgumentTypeCannotBeVoid => SR.GetString("ArgumentTypeCannotBeVoid");

	internal static string LabelMustBeVoidOrHaveExpression => SR.GetString("LabelMustBeVoidOrHaveExpression");

	internal static string LabelTypeMustBeVoid => SR.GetString("LabelTypeMustBeVoid");

	internal static string QuotedExpressionMustBeLambda => SR.GetString("QuotedExpressionMustBeLambda");

	internal static string StartEndMustBeOrdered => SR.GetString("StartEndMustBeOrdered");

	internal static string FaultCannotHaveCatchOrFinally => SR.GetString("FaultCannotHaveCatchOrFinally");

	internal static string TryMustHaveCatchFinallyOrFault => SR.GetString("TryMustHaveCatchFinallyOrFault");

	internal static string BodyOfCatchMustHaveSameTypeAsBodyOfTry => SR.GetString("BodyOfCatchMustHaveSameTypeAsBodyOfTry");

	internal static string ConversionIsNotSupportedForArithmeticTypes => SR.GetString("ConversionIsNotSupportedForArithmeticTypes");

	internal static string ArgumentMustBeArray => SR.GetString("ArgumentMustBeArray");

	internal static string ArgumentMustBeBoolean => SR.GetString("ArgumentMustBeBoolean");

	internal static string ArgumentMustBeFieldInfoOrPropertInfo => SR.GetString("ArgumentMustBeFieldInfoOrPropertInfo");

	internal static string ArgumentMustBeFieldInfoOrPropertInfoOrMethod => SR.GetString("ArgumentMustBeFieldInfoOrPropertInfoOrMethod");

	internal static string ArgumentMustBeInstanceMember => SR.GetString("ArgumentMustBeInstanceMember");

	internal static string ArgumentMustBeInteger => SR.GetString("ArgumentMustBeInteger");

	internal static string ArgumentMustBeArrayIndexType => SR.GetString("ArgumentMustBeArrayIndexType");

	internal static string ArgumentMustBeSingleDimensionalArrayType => SR.GetString("ArgumentMustBeSingleDimensionalArrayType");

	internal static string ArgumentTypesMustMatch => SR.GetString("ArgumentTypesMustMatch");

	internal static string CoalesceUsedOnNonNullType => SR.GetString("CoalesceUsedOnNonNullType");

	internal static string IncorrectNumberOfIndexes => SR.GetString("IncorrectNumberOfIndexes");

	internal static string IncorrectNumberOfLambdaArguments => SR.GetString("IncorrectNumberOfLambdaArguments");

	internal static string IncorrectNumberOfLambdaDeclarationParameters => SR.GetString("IncorrectNumberOfLambdaDeclarationParameters");

	internal static string IncorrectNumberOfConstructorArguments => SR.GetString("IncorrectNumberOfConstructorArguments");

	internal static string IncorrectNumberOfMembersForGivenConstructor => SR.GetString("IncorrectNumberOfMembersForGivenConstructor");

	internal static string IncorrectNumberOfArgumentsForMembers => SR.GetString("IncorrectNumberOfArgumentsForMembers");

	internal static string LambdaTypeMustBeDerivedFromSystemDelegate => SR.GetString("LambdaTypeMustBeDerivedFromSystemDelegate");

	internal static string ListInitializerWithZeroMembers => SR.GetString("ListInitializerWithZeroMembers");

	internal static string ElementInitializerMethodNotAdd => SR.GetString("ElementInitializerMethodNotAdd");

	internal static string ElementInitializerMethodWithZeroArgs => SR.GetString("ElementInitializerMethodWithZeroArgs");

	internal static string ElementInitializerMethodStatic => SR.GetString("ElementInitializerMethodStatic");

	internal static string UnexpectedCoalesceOperator => SR.GetString("UnexpectedCoalesceOperator");

	internal static string UnhandledBinding => SR.GetString("UnhandledBinding");

	internal static string UnknownBindingType => SR.GetString("UnknownBindingType");

	internal static string IncorrectNumberOfTypeArgsForFunc => SR.GetString("IncorrectNumberOfTypeArgsForFunc");

	internal static string IncorrectNumberOfTypeArgsForAction => SR.GetString("IncorrectNumberOfTypeArgsForAction");

	internal static string ArgumentCannotBeOfTypeVoid => SR.GetString("ArgumentCannotBeOfTypeVoid");

	internal static string NoOrInvalidRuleProduced => SR.GetString("NoOrInvalidRuleProduced");

	internal static string FirstArgumentMustBeCallSite => SR.GetString("FirstArgumentMustBeCallSite");

	internal static string BindingCannotBeNull => SR.GetString("BindingCannotBeNull");

	internal static string QueueEmpty => SR.GetString("QueueEmpty");

	internal static string ControlCannotLeaveFinally => SR.GetString("ControlCannotLeaveFinally");

	internal static string ControlCannotLeaveFilterTest => SR.GetString("ControlCannotLeaveFilterTest");

	internal static string ControlCannotEnterTry => SR.GetString("ControlCannotEnterTry");

	internal static string ControlCannotEnterExpression => SR.GetString("ControlCannotEnterExpression");

	internal static string ExtensionNotReduced => SR.GetString("ExtensionNotReduced");

	internal static string CannotCompileDynamic => SR.GetString("CannotCompileDynamic");

	internal static string InvalidOutputDir => SR.GetString("InvalidOutputDir");

	internal static string InvalidAsmNameOrExtension => SR.GetString("InvalidAsmNameOrExtension");

	internal static string CollectionReadOnly => SR.GetString("CollectionReadOnly");

	internal static string RethrowRequiresCatch => SR.GetString("RethrowRequiresCatch");

	internal static string TryNotAllowedInFilter => SR.GetString("TryNotAllowedInFilter");

	internal static string CollectionModifiedWhileEnumerating => SR.GetString("CollectionModifiedWhileEnumerating");

	internal static string EnumerationIsDone => SR.GetString("EnumerationIsDone");

	internal static string HomogenousAppDomainRequired => SR.GetString("HomogenousAppDomainRequired");

	internal static string PdbGeneratorNeedsExpressionCompiler => SR.GetString("PdbGeneratorNeedsExpressionCompiler");

	internal static string VariableMustNotBeByRef(object p0, object p1)
	{
		return SR.GetString("VariableMustNotBeByRef", p0, p1);
	}

	internal static string DuplicateVariable(object p0)
	{
		return SR.GetString("DuplicateVariable", p0);
	}

	internal static string ExtensionNodeMustOverrideProperty(object p0)
	{
		return SR.GetString("ExtensionNodeMustOverrideProperty", p0);
	}

	internal static string UserDefinedOperatorMustBeStatic(object p0)
	{
		return SR.GetString("UserDefinedOperatorMustBeStatic", p0);
	}

	internal static string UserDefinedOperatorMustNotBeVoid(object p0)
	{
		return SR.GetString("UserDefinedOperatorMustNotBeVoid", p0);
	}

	internal static string CoercionOperatorNotDefined(object p0, object p1)
	{
		return SR.GetString("CoercionOperatorNotDefined", p0, p1);
	}

	internal static string DynamicBinderResultNotAssignable(object p0, object p1, object p2)
	{
		return SR.GetString("DynamicBinderResultNotAssignable", p0, p1, p2);
	}

	internal static string DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3)
	{
		return SR.GetString("DynamicObjectResultNotAssignable", p0, p1, p2, p3);
	}

	internal static string DynamicBindingNeedsRestrictions(object p0, object p1)
	{
		return SR.GetString("DynamicBindingNeedsRestrictions", p0, p1);
	}

	internal static string BinderNotCompatibleWithCallSite(object p0, object p1, object p2)
	{
		return SR.GetString("BinderNotCompatibleWithCallSite", p0, p1, p2);
	}

	internal static string UnaryOperatorNotDefined(object p0, object p1)
	{
		return SR.GetString("UnaryOperatorNotDefined", p0, p1);
	}

	internal static string BinaryOperatorNotDefined(object p0, object p1, object p2)
	{
		return SR.GetString("BinaryOperatorNotDefined", p0, p1, p2);
	}

	internal static string ReferenceEqualityNotDefined(object p0, object p1)
	{
		return SR.GetString("ReferenceEqualityNotDefined", p0, p1);
	}

	internal static string OperandTypesDoNotMatchParameters(object p0, object p1)
	{
		return SR.GetString("OperandTypesDoNotMatchParameters", p0, p1);
	}

	internal static string OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1)
	{
		return SR.GetString("OverloadOperatorTypeDoesNotMatchConversionType", p0, p1);
	}

	internal static string EqualityMustReturnBoolean(object p0)
	{
		return SR.GetString("EqualityMustReturnBoolean", p0);
	}

	internal static string CannotAutoInitializeValueTypeElementThroughProperty(object p0)
	{
		return SR.GetString("CannotAutoInitializeValueTypeElementThroughProperty", p0);
	}

	internal static string CannotAutoInitializeValueTypeMemberThroughProperty(object p0)
	{
		return SR.GetString("CannotAutoInitializeValueTypeMemberThroughProperty", p0);
	}

	internal static string IncorrectTypeForTypeAs(object p0)
	{
		return SR.GetString("IncorrectTypeForTypeAs", p0);
	}

	internal static string ExpressionTypeCannotInitializeArrayType(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeCannotInitializeArrayType", p0, p1);
	}

	internal static string ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeDoesNotMatchConstructorParameter", p0, p1);
	}

	internal static string ArgumentTypeDoesNotMatchMember(object p0, object p1)
	{
		return SR.GetString("ArgumentTypeDoesNotMatchMember", p0, p1);
	}

	internal static string ArgumentMemberNotDeclOnType(object p0, object p1)
	{
		return SR.GetString("ArgumentMemberNotDeclOnType", p0, p1);
	}

	internal static string ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2)
	{
		return SR.GetString("ExpressionTypeDoesNotMatchMethodParameter", p0, p1, p2);
	}

	internal static string ExpressionTypeDoesNotMatchParameter(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeDoesNotMatchParameter", p0, p1);
	}

	internal static string ExpressionTypeDoesNotMatchReturn(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeDoesNotMatchReturn", p0, p1);
	}

	internal static string ExpressionTypeDoesNotMatchAssignment(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeDoesNotMatchAssignment", p0, p1);
	}

	internal static string ExpressionTypeDoesNotMatchLabel(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeDoesNotMatchLabel", p0, p1);
	}

	internal static string ExpressionTypeNotInvocable(object p0)
	{
		return SR.GetString("ExpressionTypeNotInvocable", p0);
	}

	internal static string FieldNotDefinedForType(object p0, object p1)
	{
		return SR.GetString("FieldNotDefinedForType", p0, p1);
	}

	internal static string InstanceFieldNotDefinedForType(object p0, object p1)
	{
		return SR.GetString("InstanceFieldNotDefinedForType", p0, p1);
	}

	internal static string FieldInfoNotDefinedForType(object p0, object p1, object p2)
	{
		return SR.GetString("FieldInfoNotDefinedForType", p0, p1, p2);
	}

	internal static string IncorrectNumberOfMethodCallArguments(object p0)
	{
		return SR.GetString("IncorrectNumberOfMethodCallArguments", p0);
	}

	internal static string MemberNotFieldOrProperty(object p0)
	{
		return SR.GetString("MemberNotFieldOrProperty", p0);
	}

	internal static string MethodContainsGenericParameters(object p0)
	{
		return SR.GetString("MethodContainsGenericParameters", p0);
	}

	internal static string MethodIsGeneric(object p0)
	{
		return SR.GetString("MethodIsGeneric", p0);
	}

	internal static string MethodNotPropertyAccessor(object p0, object p1)
	{
		return SR.GetString("MethodNotPropertyAccessor", p0, p1);
	}

	internal static string PropertyDoesNotHaveGetter(object p0)
	{
		return SR.GetString("PropertyDoesNotHaveGetter", p0);
	}

	internal static string PropertyDoesNotHaveSetter(object p0)
	{
		return SR.GetString("PropertyDoesNotHaveSetter", p0);
	}

	internal static string PropertyDoesNotHaveAccessor(object p0)
	{
		return SR.GetString("PropertyDoesNotHaveAccessor", p0);
	}

	internal static string NotAMemberOfType(object p0, object p1)
	{
		return SR.GetString("NotAMemberOfType", p0, p1);
	}

	internal static string OperatorNotImplementedForType(object p0, object p1)
	{
		return SR.GetString("OperatorNotImplementedForType", p0, p1);
	}

	internal static string ParameterExpressionNotValidAsDelegate(object p0, object p1)
	{
		return SR.GetString("ParameterExpressionNotValidAsDelegate", p0, p1);
	}

	internal static string PropertyNotDefinedForType(object p0, object p1)
	{
		return SR.GetString("PropertyNotDefinedForType", p0, p1);
	}

	internal static string InstancePropertyNotDefinedForType(object p0, object p1)
	{
		return SR.GetString("InstancePropertyNotDefinedForType", p0, p1);
	}

	internal static string InstancePropertyWithoutParameterNotDefinedForType(object p0, object p1)
	{
		return SR.GetString("InstancePropertyWithoutParameterNotDefinedForType", p0, p1);
	}

	internal static string InstancePropertyWithSpecifiedParametersNotDefinedForType(object p0, object p1, object p2)
	{
		return SR.GetString("InstancePropertyWithSpecifiedParametersNotDefinedForType", p0, p1, p2);
	}

	internal static string InstanceAndMethodTypeMismatch(object p0, object p1, object p2)
	{
		return SR.GetString("InstanceAndMethodTypeMismatch", p0, p1, p2);
	}

	internal static string TypeContainsGenericParameters(object p0)
	{
		return SR.GetString("TypeContainsGenericParameters", p0);
	}

	internal static string TypeIsGeneric(object p0)
	{
		return SR.GetString("TypeIsGeneric", p0);
	}

	internal static string TypeMissingDefaultConstructor(object p0)
	{
		return SR.GetString("TypeMissingDefaultConstructor", p0);
	}

	internal static string ElementInitializerMethodNoRefOutParam(object p0, object p1)
	{
		return SR.GetString("ElementInitializerMethodNoRefOutParam", p0, p1);
	}

	internal static string TypeNotIEnumerable(object p0)
	{
		return SR.GetString("TypeNotIEnumerable", p0);
	}

	internal static string TypeParameterIsNotDelegate(object p0)
	{
		return SR.GetString("TypeParameterIsNotDelegate", p0);
	}

	internal static string InvalidCast(object p0, object p1)
	{
		return SR.GetString("InvalidCast", p0, p1);
	}

	internal static string UnhandledBinary(object p0)
	{
		return SR.GetString("UnhandledBinary", p0);
	}

	internal static string UnhandledBindingType(object p0)
	{
		return SR.GetString("UnhandledBindingType", p0);
	}

	internal static string UnhandledConvert(object p0)
	{
		return SR.GetString("UnhandledConvert", p0);
	}

	internal static string UnhandledExpressionType(object p0)
	{
		return SR.GetString("UnhandledExpressionType", p0);
	}

	internal static string UnhandledUnary(object p0)
	{
		return SR.GetString("UnhandledUnary", p0);
	}

	internal static string UserDefinedOpMustHaveConsistentTypes(object p0, object p1)
	{
		return SR.GetString("UserDefinedOpMustHaveConsistentTypes", p0, p1);
	}

	internal static string UserDefinedOpMustHaveValidReturnType(object p0, object p1)
	{
		return SR.GetString("UserDefinedOpMustHaveValidReturnType", p0, p1);
	}

	internal static string LogicalOperatorMustHaveBooleanOperators(object p0, object p1)
	{
		return SR.GetString("LogicalOperatorMustHaveBooleanOperators", p0, p1);
	}

	internal static string MethodDoesNotExistOnType(object p0, object p1)
	{
		return SR.GetString("MethodDoesNotExistOnType", p0, p1);
	}

	internal static string MethodWithArgsDoesNotExistOnType(object p0, object p1)
	{
		return SR.GetString("MethodWithArgsDoesNotExistOnType", p0, p1);
	}

	internal static string GenericMethodWithArgsDoesNotExistOnType(object p0, object p1)
	{
		return SR.GetString("GenericMethodWithArgsDoesNotExistOnType", p0, p1);
	}

	internal static string MethodWithMoreThanOneMatch(object p0, object p1)
	{
		return SR.GetString("MethodWithMoreThanOneMatch", p0, p1);
	}

	internal static string PropertyWithMoreThanOneMatch(object p0, object p1)
	{
		return SR.GetString("PropertyWithMoreThanOneMatch", p0, p1);
	}

	internal static string AmbiguousMatchInExpandoObject(object p0)
	{
		return SR.GetString("AmbiguousMatchInExpandoObject", p0);
	}

	internal static string SameKeyExistsInExpando(object p0)
	{
		return SR.GetString("SameKeyExistsInExpando", p0);
	}

	internal static string KeyDoesNotExistInExpando(object p0)
	{
		return SR.GetString("KeyDoesNotExistInExpando", p0);
	}

	internal static string InvalidOperation(object p0)
	{
		return SR.GetString("InvalidOperation", p0);
	}

	internal static string OutOfRange(object p0, object p1)
	{
		return SR.GetString("OutOfRange", p0, p1);
	}

	internal static string LabelTargetAlreadyDefined(object p0)
	{
		return SR.GetString("LabelTargetAlreadyDefined", p0);
	}

	internal static string LabelTargetUndefined(object p0)
	{
		return SR.GetString("LabelTargetUndefined", p0);
	}

	internal static string AmbiguousJump(object p0)
	{
		return SR.GetString("AmbiguousJump", p0);
	}

	internal static string NonLocalJumpWithValue(object p0)
	{
		return SR.GetString("NonLocalJumpWithValue", p0);
	}

	internal static string CannotCompileConstant(object p0)
	{
		return SR.GetString("CannotCompileConstant", p0);
	}

	internal static string InvalidLvalue(object p0)
	{
		return SR.GetString("InvalidLvalue", p0);
	}

	internal static string InvalidMemberType(object p0)
	{
		return SR.GetString("InvalidMemberType", p0);
	}

	internal static string UnknownLiftType(object p0)
	{
		return SR.GetString("UnknownLiftType", p0);
	}

	internal static string IllegalNewGenericParams(object p0)
	{
		return SR.GetString("IllegalNewGenericParams", p0);
	}

	internal static string UndefinedVariable(object p0, object p1, object p2)
	{
		return SR.GetString("UndefinedVariable", p0, p1, p2);
	}

	internal static string CannotCloseOverByRef(object p0, object p1)
	{
		return SR.GetString("CannotCloseOverByRef", p0, p1);
	}

	internal static string UnexpectedVarArgsCall(object p0)
	{
		return SR.GetString("UnexpectedVarArgsCall", p0);
	}

	internal static string MustRewriteToSameNode(object p0, object p1, object p2)
	{
		return SR.GetString("MustRewriteToSameNode", p0, p1, p2);
	}

	internal static string MustRewriteChildToSameType(object p0, object p1, object p2)
	{
		return SR.GetString("MustRewriteChildToSameType", p0, p1, p2);
	}

	internal static string MustRewriteWithoutMethod(object p0, object p1)
	{
		return SR.GetString("MustRewriteWithoutMethod", p0, p1);
	}

	internal static string InvalidNullValue(object p0)
	{
		return SR.GetString("InvalidNullValue", p0);
	}

	internal static string InvalidObjectType(object p0, object p1)
	{
		return SR.GetString("InvalidObjectType", p0, p1);
	}

	internal static string TryNotSupportedForMethodsWithRefArgs(object p0)
	{
		return SR.GetString("TryNotSupportedForMethodsWithRefArgs", p0);
	}

	internal static string TryNotSupportedForValueTypeInstances(object p0)
	{
		return SR.GetString("TryNotSupportedForValueTypeInstances", p0);
	}

	internal static string TestValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1)
	{
		return SR.GetString("TestValueTypeDoesNotMatchComparisonMethodParameter", p0, p1);
	}

	internal static string SwitchValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1)
	{
		return SR.GetString("SwitchValueTypeDoesNotMatchComparisonMethodParameter", p0, p1);
	}

	internal static string InvalidMetaObjectCreated(object p0)
	{
		return SR.GetString("InvalidMetaObjectCreated", p0);
	}
}
