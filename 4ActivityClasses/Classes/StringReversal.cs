using ArrayActivity.Interfaces;

namespace ArrayActivity.Implementations
{
    public class StringReversal : IStringReversal
    {
        public string Reverse(string word)
        {
            char[] chars = word.ToCharArray();
            System.Array.Reverse(chars);
            return new string(chars);
        }
    }
}
