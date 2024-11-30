namespace FirstModul_Exam
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int TwoRoomsCount(List<int> numbers)
        {
            var count = 0;
            foreach (var number in numbers)
            {
                if (number > 9 && number < 100)
                {
                    count++;
                }
            }
            return count;
        }
        public static string RemoveEndsTwoChar(string text)
        {
            var length = text.Length;
            var result = text.Remove(length - 2);
            return result;
        }
        public static bool CheckIsUpperOneElements(List<string> words)
        {
            var checkingWord = true;
            foreach (var word in words)
            {
                if (char.IsLower(word[0]) || char.IsDigit(word[0]) || !char.IsLetter(word[0]))
                {
                    checkingWord = false;
                    break;
                }
            }
            return checkingWord;
        }
        public static bool CheckingQovun(string text)
        {
            var startWith = text.StartsWith("qovun");
            var endWith = text.EndsWith("qovun");
            var result = false;
            if (startWith is true && endWith is true)
            {
                result = true;
            }
            return result;
        }
    }
}
