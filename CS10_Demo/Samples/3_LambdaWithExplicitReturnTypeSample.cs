namespace CS10_Demo.Samples;

public class LambdaWithExplicitReturnTypeSample {

	public static void Run()
	{
		// note: you probably wont need this, but it's possible now
		// If you ever want to do this, chances are good the lambda should be redesigned...
		PassingOn(object (string s) => s == "Zero" ? s : int.Parse(s));
	}

	static void PassingOn(Delegate converter) { }
}