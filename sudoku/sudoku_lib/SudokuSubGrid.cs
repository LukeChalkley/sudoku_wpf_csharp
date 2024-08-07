namespace sudoku_lib;

/// <summary>
/// 
/// </summary>
public class SudokuSubGrid
{
    /// <summary>
    /// 
    /// </summary>
    private System.Collections.Generic.IList<int> _cellValues = new List<int>();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="row"></param>
    /// <param name="column"></param>
    /// <exception cref="NotImplementedException"></exception>
    public int this[int row, int column] => throw new NotImplementedException();

    /// <summary>
    /// 
    /// </summary>
    public SudokuSubGrid()
    {
        
    }
}