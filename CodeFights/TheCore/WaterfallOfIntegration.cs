using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class WaterfallOfIntegration
    {

        public static bool correctNonogram(int size, string[][] nonogramField)
        {
            for (var x = nonogramField.Length - size; x < nonogramField.Length; x++)
            {
                var colList = new List<int>();
                for (var y = 0; y < nonogramField.Length - size; y++)
                {
                    if (nonogramField[y][x] != "-")
                    {
                        colList.Add(int.Parse(nonogramField[y][x]));
                    }
                }
                colList.Reverse();
                var inASeq = false;
                for(var y = nonogramField.Length - size; y < nonogramField.Length; y++)
                {
                    if (colList.Count == 0)
                    {
                        if (nonogramField[y][x] == "#")
                            return false;
                    }
                    else if (nonogramField[y][x] == "#")
                    {
                        colList[colList.Count - 1]--;
                        inASeq = true;
                        if (colList[colList.Count - 1] < 0)
                            return false;
                        if (colList[colList.Count - 1] == 0)
                        {
                            colList.RemoveAt(colList.Count - 1);
                            inASeq = false;
                            if(y != nonogramField.Length -1 && nonogramField[y+1][x] == "#")
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        if (inASeq)
                            return false;
                    }
                }

            }

            for (var y = nonogramField.Length - size; y < nonogramField.Length; y++)
            {
                var rowList = new List<int>();
                for (var x = 0; x < nonogramField.Length - size; x++)
                {
                    if (nonogramField[y][x] != "-")
                    {
                        rowList.Add(int.Parse(nonogramField[y][x]));
                    }
                }
                rowList.Reverse();
                var inASeq = false;
                for(var x = nonogramField.Length - size; x < nonogramField.Length; x++)
                {
                    if (rowList.Count == 0)
                    {
                        if (nonogramField[y][x] == "#")
                            return false;
                    }
                    else if (nonogramField[y][x] == "#")
                    {
                        rowList[rowList.Count - 1]--;
                        inASeq = true;
                        if (rowList[rowList.Count - 1] < 0)
                            return false;
                        if (rowList[rowList.Count - 1] == 0)
                        {
                            rowList.RemoveAt(rowList.Count - 1);
                            inASeq = false;
                            if(x != nonogramField.Length -1 && nonogramField[y][x+1] == "#")
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        if (inASeq)
                            return false;
                    }
                }

            }



            return true;
        }


        public static bool isInformationConsistent(int[][] evidences)
        {
            for (var x = 0; x < evidences[0].Length; x++)
            {
                var initVerdict = -2;
                for (var y = 0; y < evidences.Length; y++)
                {
                    if (evidences[y][x] != 0)
                    {
                        if (initVerdict == -2)
                        {
                            initVerdict = evidences[y][x];
                        }
                        else if (initVerdict != evidences[y][x])
                            return false;
                    }
                }
            }
            return true;
        }

        public static int[] gravitation(string[] rows)
        {
            var foundStone = new bool[rows[0].Length];
            var unitsFall = new int[rows[0].Length];

            for (var x = 0; x < rows[0].Length; x++)
            {
                for (var y = 0; y < rows.Length; y++)
                {
                    if (rows[y][x] == '#')
                        foundStone[x] = true;
                    else if (foundStone[x])
                    {
                        if (rows[y][x] == '.')
                            unitsFall[x]++;
                    }
                }
            }

            return unitsFall.Select((s, i) => new { i, s }).Where(d => d.s == unitsFall.Min()).Select(d => d.i).ToArray();
        }

        public static int polygonPerimeter(bool[][] matrix)
        {
            var per = 0;

            for (var y = 0; y < matrix.Length; y++)
            {
                for (var x = 0; x < matrix[y].Length; x++)
                {
                    if (matrix[y][x])
                    {
                        if (y == 0 || matrix[y - 1][x] == false) //top
                            per++;
                        if (y == matrix.Length - 1 || matrix[y + 1][x] == false) //bottom
                            per++;
                        if (x == 0 || matrix[y][x - 1] == false) //left
                            per++;
                        if (x == matrix[y].Length - 1 || matrix[y][x + 1] == false)//right
                            per++;
                    }
                }
            }

            return per;
        }

        public static int[][] contoursShifting(int[][] matrix)
        {
            var height = matrix.Length;
            var width = matrix[0].Length;
            var newMatrix = new int[matrix.Length][];
            for (var i = 0; i < newMatrix.Length; i++)
                newMatrix[i] = new int[matrix[0].Length];

            if (matrix.Length == 1)
            {

            }
            var contours = Math.Ceiling(Math.Min(height, width) / 2.00);

            var offset = 0;
            while (offset < contours)
            {
                var goclockwise = (offset + 2) % 2 == 0;
                var topRow = offset;
                var bottomRow = matrix.Length - 1 - offset;
                var rightCol = matrix[0].Length - offset - 1;
                var leftCol = offset;
                var contourList = new List<int>();
                for (var tX = offset; tX <= rightCol; tX++)
                {
                    contourList.Add(matrix[offset][tX]);
                }
                for (var rY = offset + 1; rY <= bottomRow; rY++)
                {
                    contourList.Add(matrix[rY][rightCol]);
                }
                if (topRow != bottomRow)
                {
                    for (var bX = rightCol - 1; bX >= offset; bX--)
                    {
                        contourList.Add(matrix[bottomRow][bX]);
                    }
                }
                if (leftCol != rightCol)
                {
                    for (var lY = bottomRow - 1; lY > offset; lY--)
                    {
                        contourList.Add(matrix[lY][leftCol]);
                    }
                }
                if (goclockwise)
                {
                    contourList.Insert(0, contourList[contourList.Count - 1]);
                    contourList.RemoveAt(contourList.Count - 1);
                }
                else
                {
                    contourList.Add(contourList[0]);
                    contourList.RemoveAt(0);
                }
                var c = 0;
                for (var tX = offset; tX <= rightCol; tX++)
                {
                    newMatrix[offset][tX] = contourList[c];
                    c++;
                }
                for (var rY = offset + 1; rY <= bottomRow; rY++)
                {
                    newMatrix[rY][rightCol] = contourList[c];
                    c++;
                }
                if (topRow != bottomRow)
                {
                    for (var bX = rightCol - 1; bX >= offset; bX--)
                    {
                        newMatrix[bottomRow][bX] = contourList[c];
                        c++;
                    }
                }
                if (leftCol != rightCol)
                {
                    for (var lY = bottomRow - 1; lY > offset; lY--)
                    {
                        newMatrix[lY][leftCol] = contourList[c];
                        c++;
                    }
                }
                Debug.WriteLine("Contour " + offset + ": " + string.Join(", ", contourList));

                offset++;
            }

            Debug.WriteLine("Before:");
            foreach (var m in matrix)
            {
                foreach (var n in m)
                {
                    Debug.Write(n + ", ");
                }
                Debug.Write(Environment.NewLine);
            }

            Debug.WriteLine("After:");
            foreach (var m in newMatrix)
            {
                foreach (var n in m)
                {
                    Debug.Write(n + ", ");
                }
                Debug.Write(Environment.NewLine);
            }

            return newMatrix;
        }

        //boxBlur is in Intro/ArcadeIntro5

        //minesweeper is in Intro/ArcadeIntro5

        //sudoku is in Intro/ArcadeIntro12
    }
}
