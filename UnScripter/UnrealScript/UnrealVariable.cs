namespace UnScripter.Unreal
{
    public class UnrealVariable
    {
        // Just use a function signature for now
        public string Signature { get; private set; }
        public int LineNumber { get; private set; }

        public UnrealVariable(string varSignature, int linenumber)
        {
            Signature = varSignature;
            LineNumber = linenumber;
        }
    }
}
