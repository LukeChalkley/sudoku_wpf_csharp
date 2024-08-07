namespace sudoku_lib;

/// <summary>
/// 
/// </summary>
public class SudokuBoard
{
    /// <summary>
    /// 
    /// </summary>
    private System.Collections.Generic.IList<SudokuSubGrid> _subGrids = new List<SudokuSubGrid>();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="row"></param>
    /// <param name="column"></param>
    /// <exception cref="NotImplementedException"></exception>
    public SudokuSubGrid this[int row, int column] => throw new NotImplementedException();
}