using System;
abstract class Task
{
    public Task(string text) { }
    public abstract void ParseText(string text);
}

class Task_2 : Task
{
    private string _text;
    public Task_2(string text) : base(text)
    {
        _text = text;
    }
    public override string ToString()
    {
        return _text;
    }
    private string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public override void ParseText(string text)
    {
        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            string wordreversed = "";
            string punctuation = "";
            foreach (char c in word)
            {
                if (char.IsPunctuation(c) && c != '-')
                {
                    punctuation += c;
                }
                else
                {
                    wordreversed = c + wordreversed;
                }
            }
            words[i] = wordreversed + punctuation;
        }
        _text = string.Join(' ', words);
    }

}
public struct CodePair
{
    public string _key { get; private set; }
    public string _value { get; private set; }

    public CodePair(string key, string value)
    {
        _key = key;
        _value = value;
    }
}

class Task_9 : Task
{
    private string _text;
    public string _Text;
    private List<CodePair> _cod;

    public Task_9(string text) : base(text)
    {
        _text = text;
        _cod = new List<CodePair>();
    }

    public override string ToString()
    {
        return _text;
    }

    public override void ParseText(string text)
    {
        var posl = new Dictionary<string, int>(); 
        for (int i = 0; i < text.Length - 1; i++)
        {
            var sequence = text.Substring(i, 2);
            if (!posl.ContainsKey(sequence))
            {
                posl[sequence] = 0;
            }
            posl[sequence]++;
        }

        char code = '!';
        foreach (var sequence in posl)
        {
            if (!_cod.Any(pair => pair._key == sequence.Key))
            {
                _cod.Add(new CodePair(sequence.Key, code.ToString()));
                code++;
            }
        }
    }

    public void EncodeText()
    {
        foreach (var codePair in _cod)
        {
            _text = _text.Replace(codePair._key, codePair._value);
        }
        _Text = _text;
    }
}
class Task_10 : Task
{
    private string _text;
    public string _Text;
    private List<CodePair> _cod;

    public Task_10(string text) : base(text)
    {
        _text = text;
        _cod = new List<CodePair>();
    }

    public override string ToString()
    {
        return _text;
    }

    public override void ParseText(string text)
    {
        var posl = new Dictionary<string, int>();
        for (int i = 0; i < text.Length - 1; i++)
        {
            var sequence = text.Substring(i, 2);
            if (!posl.ContainsKey(sequence))
            {
                posl[sequence] = 0;
            }
            posl[sequence]++;
        }
        char code = '!';
        foreach (var sequence in posl)
        {
            if (!_cod.Any(pair => pair._key == sequence.Key))
            {
                _cod.Add(new CodePair(sequence.Key, code.ToString()));
                code++;
            }
        }
    }

    public void DecodeText()
    {
        foreach (var codePair in _cod)
        {
            _text = _text.Replace(codePair._value, codePair._value);
        }
        _Text = _text;
    }
}
class Program
{
    public static void Main()
    {
        string text = "После из-за многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений";
        Task_2 task2 = new Task_2(text);
        task2.ParseText(text);
        Console.WriteLine(task2.ToString());
        Task_9 task9 = new Task_9(text);
        task9.ParseText(text);
        task9.EncodeText();
        Console.WriteLine(task9.ToString());
        Task_10 task10 = new Task_10(text);
        task10.ParseText(text);
        task10.DecodeText();
        Console.WriteLine(task10.ToString());
        Console.ReadKey();
    }
}