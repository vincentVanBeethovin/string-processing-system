namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string _originalText = "";
        private string _currentText = "";

        public void SetText(string text)
        {
            _originalText = text;
            _currentText = text;
        }

        public string GetCurrentText() => _currentText;

        public void ToUpper() => _currentText = _currentText.ToUpper();

        public void ToLower() => _currentText = _currentText.ToLower();

        public int GetLength() => _currentText.Length;

        public bool ContainsWord(string word) => _currentText.Contains(word);

        public void ReplaceWord(string oldWord, string newWord) 
            => _currentText = _currentText.Replace(oldWord, newWord);

        public void ExtractSubstring(int startIndex, int length)
        {
            if (startIndex >= 0 && startIndex + length <= _currentText.Length)
                _currentText = _currentText.Substring(startIndex, length);
        }

        public void TrimSpaces() => _currentText = _currentText.Trim();

        public void ResetText() => _currentText = _originalText;
    }
}
