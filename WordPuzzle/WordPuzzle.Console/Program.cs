using WordPuzzle.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        RunWordFinder(new List<string>
             {
                 "abcdc",
                 "igwio",
                 "chill",
                 "pqnsd",
                 "uvdxy"
             }, new List<string>
            {
                "chill",
                "cold",
                "wind"
            },
            "chill,cold,wind", "Challenge example");
        RunWordFinder(new List<string>
             {
                 "abcdcc",
                 "igwioo",
                 "chilll",
                 "pqnsdd",
                 "uvdxyx"
             }, new List<string>
            {
                "chill",
                "cold",
                "wind"
            },
"cold,chill,wind", "The word \"cold\" appears twice (vertically and horizontally)");
        RunWordFinder(new List<string>
             {
                  "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuio",
    "hjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjkl",
    "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuio",
    "hjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjkl",
    "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfgasdfgasdfsundfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuio",
    "hjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjkl",
    "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yuiopyuiopyuiopyuiopyuiopyuiopyuiosuniopyuiopyuiopyuiopyuiopyuio",
    "hjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjkl",
    "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuio",
    "hjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjkl",
    "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuio",
    "hjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjkl",
    "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuio",
    "hjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjkl",
    "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuio",
    "hjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjkl",
    "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzsunbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwersqwer",
    "yuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiwindowpyuiopuuio",
    "hjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjwindowlmhjklmhjklmnjkl",
    "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qlertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yaiopyuiopyuiopyuiopyuiopyuiopyuiopywindowiopyuiopyuiopyuiopyuio",
    "hnklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjkl",
    "ztcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "aedfgasdfgasdfgasdfgasdfgasdfgwindowsdfgasdfgasdfgasdfgasdfgasdf",
    "qrertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yniobyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuio",
    "hjklohjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjkl",
    "zxcvozxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfkasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yuiopyuiopyuiopyuiopyuiowindowyuiopyuiopyuiopyuiopyuiopyuiopyuio",
    "hjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjklmhjkl",
    "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcv",
    "asdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdfgasdf",
    "qwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwertqwer",
    "yuiopyuiopyuiopyuiwindowpyuiopyuiopyuiopyuiopyuiopyuiopyuiopyuio"
             }, new List<string>
            {
                "sun",
                "window",
                "book",
                "lantern"

            },
"window,sun,book,lantern", "64X64 Matrix");
        RunWordFinder(new List<string>
             {
                "zxcquestvc",
                "zxcquestvc",
                "zxcvbzxcvc",
                "aballasdfa",
                "qwertqwert",
                "yuifishiop",
                "hjklmhjklm",
                "zxcvbzxcvb",
                "asdfgasdfg",
                "qwertqwert",
                "yuiopyuiop",
                "hjklmhjkls",
                "zxcvbzxcvt",
                "zxcvbfoxva",
                "asdfgasdfr",
                "cwertqwert",
                "cwertlampt",
                "auiopyuiop",
                "ruisunuiop",
                "rjkboxjklm",
                "rjkbtreelm",
                "rjkbtreelm",
             }, new List<string>
            {
                "cat",
                "lamp",
                "fish",
                "box",
                "car",
                "ball",
                "start",
                "tree",
                "fox",
                "sun",
                "quest"
            },
            "tree,quest,cat,lamp,fish,box,car,ball,start,fox", "Top 10 words most found in the matrix");
        RunWordFinder(new List<string>(), new List<string>
            {
                "chill",
                "cold",
                "wind"
            },
    "The matrix cannot be null or empty", "Challenge example");
        RunWordFinder(new List<string>
             {
                 "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "y",
                    "h",
                    "z",
                    "a",
                    "q",
                    "q",
                    "y",
             }, new List<string>
            {
                "a",
                "b",
                "c"
            },
    "The matrix size exceeds the maximum allowed size of 64x64.", "Matrix with more than 64 rows");
        RunWordFinder(new List<string>(), new List<string>
            {
                "chill",
                "cold",
                "wind"
            },
"The matrix cannot be null or empty", "Challenge example");
        RunWordFinder(new List<string>
             {
                 "zxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvbzxcvx",
             }, new List<string>
            {
                "a",
                "b",
                "c"
            },
    "The matrix size exceeds the maximum allowed size of 64x64.", "Matrix with more than 64 columns");

    }

    private static void RunWordFinder(List<string> matrix, List<string> words, string expectedWords, string desc)
    {
        Console.WriteLine($"Case: {desc}");

        try
        {
            var wordFinder = new WordFinder(matrix);
            var runFind = wordFinder.Find(words);
            var wordFound = string.Join(",", runFind);
            var wordsToFind = string.Join(",", words);
            var result = expectedWords == wordFound ? "Ok" : "Error";

            Console.WriteLine($"Words to find: {wordsToFind} ({words.Count})");
            Console.WriteLine($"Words found: {wordFound} ({runFind.Count()})");
            Console.WriteLine($"Expected words: {expectedWords}");
            Console.WriteLine($"Result: {result}");
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Expected error: {expectedWords}");
            Console.WriteLine($"Current error: {ex.Message}");
            Console.WriteLine($"Error is ok: {ex.Message == expectedWords}");
        }
        Console.WriteLine($"---------------");


    }
}