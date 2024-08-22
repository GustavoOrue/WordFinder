namespace WordPuzzle.Services;

public class WordFinder
{
    private readonly char[,] _matrix;
    private readonly int _numberOfRows;
    private readonly int _numberOfCols;

    public WordFinder(IEnumerable<string> matrix)
    {
        if (matrix == null || !matrix.Any())
        {
            throw new ArgumentException("The matrix cannot be null or empty.");
        }

        var matrixList = matrix.ToList();
        _numberOfRows = matrixList.Count;
        _numberOfCols = matrixList.First().Length;

        if (_numberOfRows > 64 || _numberOfCols > 64)
        {
            throw new ArgumentException("The matrix size exceeds the maximum allowed size of 64x64.");
        }

        _matrix = new char[_numberOfRows, _numberOfCols];
        int i = 0;

        foreach (var row in matrix)
        {
            if (row.Length != _numberOfCols)
            {
                throw new ArgumentException("All rows in the matrix must have the same length.");
            }

            for (int j = 0; j < _numberOfCols; j++)
            {
                _matrix[i, j] = row[j];
            }

            i++;
        }
    }

    public IEnumerable<string> Find(IEnumerable<string> wordstream)
    {
        var result = new Dictionary<string, int>();
        var wordsToFind = new HashSet<string>(wordstream);

        foreach (var word in wordsToFind)
        {
            if (AnyWordInMatrix(word, out int count))
            {
                result[word] = count;
            }
        }
        //Return the fists 10 result
        return result.OrderByDescending(x => x.Value)
                     .Take(10)
                     .Select(x => x.Key);
    }

    private bool AnyWordInMatrix(string word, out int count)
    {
        // Count occurrences in the rows (horizontal search)
        var rows = Enumerable.Range(0, _numberOfRows)
                         .Select(row => GetRow(row))
                         .Sum(rowString => WordsInLine(rowString, word));

        // Count occurrences in the columns(vertical search)
        var cols = Enumerable.Range(0, _numberOfCols)
                                 .Select(col => GetCol(col))
                                 .Sum(colString => WordsInLine(colString, word));

        count = rows + cols;

        return count > 0;
    }

    private int WordsInLine(string line, string word)
    {
        int result = 0;
        int i = 0;

        while ((i = line.IndexOf(word, i)) != -1)
        {
            result++;
            i += word.Length;
        }

        return result;
    }

    // Returns the string for the specified row

    private string GetRow(int row)
    {

        return new string(Enumerable.Range(0, _numberOfCols)
                                          .Select(col => _matrix[row, col])
                                          .ToArray());
    }

    // Returns the string for the specified col

    private string GetCol(int col)
    {
        return new string(Enumerable.Range(0, _numberOfRows)
                                    .Select(row => _matrix[row, col])
                                    .ToArray());
    }
}
