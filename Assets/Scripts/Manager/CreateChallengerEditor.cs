using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;

public class CreateChallengerEditor : EditorWindow {
	static CreateChallengerEditor window;
	static string challengerStr =
@"using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBase<Name> : ChallengeBase {
	public ChallengeBase<Name>() {
		tests = new TestItem[] {
			new TestItem(
				""Name"",
				new TestField[] {
					new TestIntField{	showFormat=""p_a = {0}"",	fieldValue = 0}
				},
				new TestField[] {
					new TestIntField{	fieldValue = 0}
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<>(p_test, <Name>);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void <Name>() { throw new NotDoException(); }
}
";


	static string challengeDataStr =
@"using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ""<Folder>/<Name>"")] public class ChallengeData<Name> : ChallengeData<Challenge<Name>> { }
public class Challenge<Name> : ChallengeBase<Name> {
	/*
		┌───────── 說明區 ─────────┐
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void <Name>() {

	//}
	//	└──────────────────────┘
}
";
	[MenuItem("Window/Create Challenge")]
	static void Init() {
		window = (CreateChallengerEditor)GetWindow(typeof(CreateChallengerEditor));
		window.Show();
	}
	static string folder = "";
	static string challengeName = "";
	void OnGUI() {
		folder = EditorGUILayout.TextField("Folder", folder);
		challengeName = EditorGUILayout.TextField("Name", challengeName);
		if (GUILayout.Button("Create")) {
			string _challenger = challengerStr.Replace("<Name>", challengeName).Replace("<Folder>", folder);
			CreateFile($@"Scripts\Challenge\{folder}", $"ChallengeBase{challengeName}", _challenger);

			string _challengeData = challengeDataStr.Replace("<Name>", challengeName).Replace("<Folder>", folder);
			CreateFile($@"Challenger\{folder}", $"ChallengeData{challengeName}", _challengeData);

			AssetDatabase.Refresh();
		}
	}

	void CreateFile(string p_parentFolder, string p_fileName, string p_text) {
		string _fullPath = $@"{Application.dataPath}\{p_parentFolder}";
		if (!Directory.Exists(_fullPath)) { Directory.CreateDirectory(_fullPath); }
		File.WriteAllText($@"{_fullPath}\{p_fileName}.cs", p_text, Encoding.UTF8);
	}
}
