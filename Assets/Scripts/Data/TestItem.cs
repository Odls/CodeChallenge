using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

internal class NotDoException : System.Exception {}
internal enum E_FIELD_TYPE {
	Int,
	Bool,
	String
}
internal abstract class TestField {
	internal abstract E_FIELD_TYPE type { get; }
	internal abstract string showText { get; }
	internal abstract object value { get; }

	internal static string FieldsToString(IEnumerable<TestField> p_fields) {
		StringBuilder _sb = new StringBuilder();
		foreach (var _field in p_fields) {
			_sb.Append('<').Append(_field.type.ToString()).Append(">\t").Append(_field.showText).Append('\n');
		}
		return _sb.ToString();
	}

	internal bool CheckSame(TestField p_targetField) {
		if(p_targetField.type != type) {
			return false;
		}
		return p_targetField.value == value;
	}
}
internal abstract class TestField<T> : TestField {
	internal T fieldValue;
	internal override object value => fieldValue;
	internal string showFormat = "{0}";
	internal override string showText => string.Format(showFormat, fieldValue);
}
internal class TestIntField : TestField<int> { internal override E_FIELD_TYPE type => E_FIELD_TYPE.Int; }
internal class TestBoolField : TestField<bool> { internal override E_FIELD_TYPE type => E_FIELD_TYPE.Bool; }
internal class TestStringField : TestField<string> { internal override E_FIELD_TYPE type => E_FIELD_TYPE.String; }

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
