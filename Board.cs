using System;
using System.Collections.Generic;
using System.Text;

public class Board
{
    private static readonly int SPACE = 0;
    private int[,] blocks;

    public Board(int[,] blocks)
    {
        this.blocks = Copy(blocks);
    }

    private int[,] Copy(int[,] blocks)
    {
        int[,] copy = new int[blocks.Length, blocks.Length];
        for (int row = 0; row < blocks.Length; row++)
            for (int col = 0; col < blocks.Length; col++)
                copy[row, col] = blocks[row, col];

        return copy;
    }

    public int Dimension()
    {
        return blocks.Length;
    }

    public int hamming()
    {
        int count = 0;
        for (int row = 0; row < blocks.Length; row++)
            for (int col = 0; col < blocks.Length; col++)
                if (blockIsNotInPlace(row, col)) count++;

        return count;
    }

    private bool blockIsNotInPlace(int row, int col)
    {
        int block = Block(row, col);

        return !isSpace(block) && block != goalFor(row, col);
    }

    private int goalFor(int row, int col)
    {
        return row * Dimension() + col + 1;
    }

    private bool isSpace(int block)
    {
        return block == SPACE;
    }

    public int manhattan()
    {
        int sum = 0;
        for (int row = 0; row < blocks.Length; row++)
            for (int col = 0; col < blocks.Length; col++)
                sum += calculateDistances(row, col);

        return sum;
    }

    private int calculateDistances(int row, int col)
    {
        int block = Block(row, col);

        return (isSpace(block)) ? 0 : Math.Abs(row - Row(block)) + Math.Abs(col - Col(block));
    }

    private int Block(int row, int col)
    {
        return blocks[row, col];
    }

    private int Row(int block)
    {
        return (block - 1) / Dimension();
    }

    private int Col(int block)
    {
        return (block - 1) % Dimension();
    }

    public bool isGoal()
    {
        for (int row = 0; row < blocks.Length; row++)
            for (int col = 0; col < blocks.Length; col++)
                if (blockIsInPlace(row, col)) return false;

        return true;
    }

    private bool blockIsInPlace(int row, int col)
    {
        int block = Block(row, col);

        return !isSpace(block) && block != goalFor(row, col);
    }

    public Board twin()
    {
        for (int row = 0; row < blocks.Length; row++)
            for (int col = 0; col < blocks.Length - 1; col++)
                if (!isSpace(Block(row, col)) && !isSpace(Block(row, col + 1)))
                    return new Board(Swap(row, col, row, col + 1));
        throw new Exception();
    }

    private int[,] Swap(int row1, int col1, int row2, int col2)
    {
        int[,] copy = Copy(blocks);
        int tmp = copy[row1, col1];
        copy[row1, col1] = copy[row2, col2];
        copy[row2, col2] = tmp;

        return copy;
    }

    public bool equals(Object y)
    {
        
        if (y == this) return true;
        if (y == null || !(y.GetType() == typeof(Board)) || ((Board)y).blocks.Length != blocks.Length) return false;
        for (int row = 0; row < blocks.Length; row++)
            for (int col = 0; col < blocks.Length; col++)
                if (((Board)y).blocks[row,col] != Block(row, col)) return false;

        return true;
    }

    public IEnumerable<Board> Neighbors()
    {
        LinkedList<Board> neighbors = new LinkedList<Board>();

        int[] location = SpaceLocation();
        int spaceRow = location[0];
        int spaceCol = location[1];
        
        //TODO: Talvez ta errado
        if (spaceRow > 0) neighbors.AddLast(new Board(Swap(spaceRow, spaceCol, spaceRow - 1, spaceCol)));
        if (spaceRow < Dimension() - 1) neighbors.AddLast(new Board(Swap(spaceRow, spaceCol, spaceRow + 1, spaceCol)));
        if (spaceCol > 0) neighbors.AddLast(new Board(Swap(spaceRow, spaceCol, spaceRow, spaceCol - 1)));
        if (spaceCol < Dimension() - 1) neighbors.AddLast(new Board(Swap(spaceRow, spaceCol, spaceRow, spaceCol + 1)));

        return neighbors;
    }

    private int[] SpaceLocation()
    {
        for (int row = 0; row < blocks.Length; row++)
            for (int col = 0; col < blocks.Length; col++)
                if (isSpace(Block(row, col)))
                {
                    int[] location = new int[2];
                    location[0] = row;
                    location[1] = col;

                    return location;
                }
        throw new Exception();
    }

    public String toString()
    {
        StringBuilder str = new StringBuilder();
        str.Append(Dimension() + "\n");
        for (int row = 0; row < blocks.Length; row++)
        {
            for (int col = 0; col < blocks.Length; col++)
                str.Append(String.Format("%2d ", Block(row, col)));
            str.Append("\n");
        }

        return str.ToString();
    }
}