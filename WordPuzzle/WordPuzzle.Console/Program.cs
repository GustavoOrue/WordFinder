// See https://aka.ms/new-console-template for more information

using WordPuzzle.Services;

var wordFinder = new WordFinder(new List<string>());

Console.WriteLine(wordFinder.Find(new List<string>()));
