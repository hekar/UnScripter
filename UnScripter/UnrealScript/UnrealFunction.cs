namespace UnScripter.Unreal
{
    public class UnrealFunction
    {
        // Just use a function signature for now
        public string Signature { get; private set; }
        public int LineNumber { get; private set; }

        public UnrealFunction(string function_signature, int linenumber)
        {
            Signature = function_signature;
            LineNumber = linenumber;
        }
    }
}
