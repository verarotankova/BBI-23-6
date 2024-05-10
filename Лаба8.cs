using System;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
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
                if (char.IsPunctuation(c))
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

class Task_4 : Task
{
    private string _text;
    private int _complexity;
    public Task_4(string text) : base(text)
    {
        _text = text;
    }
    public override string ToString()
    {
        return $"Сложность: { _complexity}";
    }
    public override void ParseText(string text)
    {
        _complexity = 0;
        char[] Text = text.ToCharArray();
        foreach (char s in Text)
        {
            if (Char.IsPunctuation(s) || Char.IsWhiteSpace(s))
            {
                _complexity++;
            }
        }
    }
}
class Task_6 : Task
{
    private string _text;
    private int[] _slogi;
    public Task_6(string text) : base(text)
    {
        _text = text;
    }
    public override void ParseText(string text)
    {
        _slogi = new int[10];
        string[] words = text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            int slog = 0;
            bool glasnii = false;
            foreach (char letter in word)
            {
                if (Glasnii(letter))
                {
                    if (!glasnii)
                    {
                        slog++;
                        glasnii = true;
                    }
                }
                else
                {
                    glasnii = false;
                }
            }
            _slogi[slog]++;
        }
    }

    private bool Glasnii(char letter)
    {
        return "аеёиоуыэюя".Contains(letter.ToString().ToLower());
    }
    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < _slogi.Length; i++)
        {
            result += $"{i + 1}-сложных слов: {_slogi[i]} \n";
        }
        return result;
    }
}

class Task_8 : Task
{
    private string _text;
    public Task_8(string text) : base(text) { }
    public override string ToString()
    {
        return _text;
    }
    public override void ParseText(string text)
    {
        string[] words = text.Split();
        List<string> list_lines = new List<string>();
        string Line = "";
        foreach (string word in words)
        {
            if (Line.Length + word.Length > 50)
            {
                list_lines.Add(Line);
                Line = "";
            }
            Line += word + " ";
        }
        list_lines.Add(Line);
        for (int i = 0; i < list_lines.Count; i++)
        {
            if (list_lines[i].Length > 0)
            {
                list_lines[i] = list_lines[i].Remove(list_lines[i].Length - 1);
                list_lines[i] = ParseLine(list_lines[i]);
                list_lines[i] += "\n";
            }
        }
        foreach (string line in list_lines)
        {
            _text += line;
        }
    }
    public string ParseLine(string line)
    {
        string[] Words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int spaces = 50 - line.Length;
        {
            int add_spaces = spaces / (Words.Length - 1); 
            int extraspaces = spaces % (Words.Length - 1);
            for (int i = 0; i < Words.Length - 1; i++)
            {
                Words[i] += new string(' ', add_spaces);
                if (extraspaces > 0)
                {
                    Words[i] += ' ';
                    extraspaces--;
                }
            }
        }
        return string.Join(" ", Words);
    }
}
class Task_9 : Task 
{
    private string _text;
    public string _Text;
    private Dictionary<string, string> _cod; 
    public Task_9(string text) : base(text)
    {
        _text = text;
        _cod = new Dictionary<string, string>();
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
            if (!_cod.ContainsKey(sequence.Key)) 
            {
                _cod[sequence.Key] = code.ToString();
                code++;
            }
        }
    }
    public void EncodeText()
    {
        foreach (var codePair in _cod)
        {
            _text = _text.Replace(codePair.Key, codePair.Value);
        }
        _Text = _text;
    }
}
class Task_10: Task
{
    private string _text;
    public string _Text;
    private Dictionary<string, string> _cod;
    public Task_10(string text) : base(text)
    {
        _text = text;
        _cod = new Dictionary<string, string>();
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
            if (!_cod.ContainsKey(sequence.Key))
            {
                _cod[sequence.Key] = code.ToString();
                code++;
            }
        }
    }

    public void DecodeText()
    {
        foreach (var codePair in _cod)
        {
            _text = _text.Replace(codePair.Value, codePair.Value);
        }
    }
}



class Program
{
    public static void Main()
    {
        string text = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений";
        Task_2 task2 = new Task_2(text);
        task2.ParseText(text);
        Console.WriteLine(task2.ToString());
        Task_4 task4 = new Task_4(text);
        task4.ParseText(text);
        Console.WriteLine(task4.ToString());
        Task_6 task6 = new Task_6(text);
        task6.ParseText(text);
        Console.WriteLine(task6.ToString());
        Task_8 task8 = new Task_8(text);
        task8.ParseText(text);
        Console.WriteLine(task8.ToString());
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



