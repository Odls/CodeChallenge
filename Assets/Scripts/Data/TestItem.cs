using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class NotDoException : System.Exception {}

[System.Serializable]
public abstract class TestItemBase {
	[SerializeField] protected string showTextFormat;
	internal abstract string showText { get; }

	[SerializeField, Multiline] protected string mInput;
	internal string inputText => mInput;

	[SerializeField, Multiline] private string mExpectedResult;
	internal string expectedResult => mExpectedResult;

}

[System.Serializable]
public class TestItem : TestItemBase {
	internal override string showText => showTextFormat;
}
[System.Serializable]
public class TestItemI1 : TestItemBase {
	internal override string showText => string.Format(showTextFormat, int1);
	int int1;
}
[System.Serializable]
public class TestItemI2 : TestItemBase {
	internal override string showText => string.Format(showTextFormat, int1, int2);
	int int1, int2;
}
