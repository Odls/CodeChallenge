using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

internal class NotDoException : System.Exception {}
internal enum E_FIELD_TYPE {
	ArrayFlag = 1<<8,
	TypeMask = 0xFF,

	Int = 1,
	IntArray = Int | ArrayFlag,
	Float = 2,
	FloatArray = Float | ArrayFlag,
	Bool = 3,
	BoolArray = Bool | ArrayFlag,
	String = 4,
	StringArray = String | ArrayFlag,

	V2 = 10,
	V3 = 11,
	V4 = 12,

	Enum = 50,
}
internal abstract class TestField {
	protected StringBuilder stringBuilder = new StringBuilder();
	internal abstract E_FIELD_TYPE type { get; }
	internal abstract string showText { get; }
	internal abstract object value { get; }
	internal abstract string typeName { get; }

	internal static string FieldsToString(IEnumerable<TestField> p_fields) {
		StringBuilder _sb = new StringBuilder();
		foreach (var _field in p_fields) {
			_sb.Append('<').Append(_field.typeName).Append(">\t").Append(_field.showText).Append('\n');
		}
		return _sb.ToString();
	}

	internal abstract bool CheckSame(TestField p_targetField);
}
internal abstract class TestField<TestFieldT> : TestField
where TestFieldT : TestField<TestFieldT> {
	internal override bool CheckSame(TestField p_targetField) {
		if (p_targetField.type != type) {
			return false;
		}
		return CheckValueSame((TestFieldT)p_targetField);
	}
	internal abstract bool CheckValueSame(TestFieldT p_targetField);
}

internal abstract class TestValueField<TestFieldT, ValueT> : TestField<TestFieldT>
where TestFieldT : TestField<TestFieldT> {
	internal ValueT fieldValue;
	internal override object value => fieldValue;
	internal string showFormat = "{0}";
	internal override string showText => string.Format(showFormat, fieldValue);
	internal override string typeName => type.ToString();
	internal override bool CheckValueSame(TestFieldT p_targetField) {
		return p_targetField.value.Equals(value);
	}
}
internal abstract class TestArrayField<TestFieldT, ValueT> : TestField<TestFieldT>
where TestFieldT : TestField<TestFieldT> {
	internal ValueT[] fieldValues;
	internal override object value => fieldValues;
	internal string showFormat = "{0}";
	internal override string showText {
		get {
			stringBuilder.Clear();
			foreach (var _value in fieldValues) {
				stringBuilder.AppendFormat(showFormat, _value);
			}
			return stringBuilder.ToString();
		}
	}
	internal override string typeName => (type & E_FIELD_TYPE.TypeMask).ToString() + "[]";
}
internal class TestIntField : TestValueField<TestIntField, int> { internal override E_FIELD_TYPE type => E_FIELD_TYPE.Int; }
internal class TestFloatField : TestValueField<TestFloatField, float> { internal override E_FIELD_TYPE type => E_FIELD_TYPE.Float; }
internal class TestBoolField : TestValueField<TestBoolField, bool> { internal override E_FIELD_TYPE type => E_FIELD_TYPE.Bool; }
internal class TestStringField : TestValueField<TestStringField, string> { internal override E_FIELD_TYPE type => E_FIELD_TYPE.String; }
internal class TestV2Field : TestValueField<TestV2Field, Vector2> { internal override E_FIELD_TYPE type => E_FIELD_TYPE.V2; }
internal class TestV3Field : TestValueField<TestV3Field, Vector3> { internal override E_FIELD_TYPE type => E_FIELD_TYPE.V3; }
internal class TestV4Field : TestValueField<TestV4Field, Vector4> { internal override E_FIELD_TYPE type => E_FIELD_TYPE.V4; }
internal class TestEnumField<T> : TestValueField<TestEnumField<T>, T> where T :System.Enum { internal override E_FIELD_TYPE type => E_FIELD_TYPE.Enum; }


public class TestItem {
	internal readonly string showText;
	internal readonly TestField[] inputs;
	internal readonly TestField[] expectedResults;
	internal readonly string inputText;
	internal readonly string expectedResultText;

	internal TestItem(string p_showText, TestField[] p_inputs, TestField[] p_expectedResults) {
		showText = p_showText;
		inputs = p_inputs;
		expectedResults = p_expectedResults;

		inputText = TestField.FieldsToString(inputs);
		expectedResultText = TestField.FieldsToString(expectedResults);
	}
}
