using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CodeFights.Intro;

namespace CodeFights.TheCore
{
    public static class ChessTavern
    {

        public static string pawnRace(string white, string black, char toMove)
        {
            var getLocation = new Func<string, int[]>(delegate (string f)
            {
                var c = -1;
                switch (f.ToCharArray()[0])
                {
                    case 'a':
                        c = 0;
                        break;
                    case 'b':
                        c = 1;
                        break;
                    case 'c':
                        c = 2;
                        break;
                    case 'd':
                        c = 3;
                        break;
                    case 'e':
                        c = 4;
                        break;
                    case 'f':
                        c = 5;
                        break;
                    case 'g':
                        c = 6;
                        break;
                    case 'h':
                        c = 7;
                        break;
                }

                return new[] { int.Parse(f.Substring(1, 1)) - 1, c };
            });
            var w = getLocation(white);
            var b = getLocation(black);

            if (w[1] == b[1] && w[0] < b[0] )
                return "draw";

            var nextTo = Math.Abs(b[1] - w[1]) == 1;

            while (w[0] != 7 && b[0] != 0)
            {
                if (toMove == 'b')
                {
                    if (b[0] - 1 == w[0] && nextTo)
                        return "black";
                    if (b[0] == 6 && !nextTo | (w[0] != 3 && nextTo))
                    {
                        b[0] -= 2;
                    }
                    else
                        b[0]--;
                }
                else
                {
                    if (w[0] + 1 == b[0] && nextTo)
                        return "white";
                    if (w[0] == 1 && !nextTo | (b[0] != 4 && nextTo))
                    {
                        w[0] += 2;
                    }
                    else
                        w[0]++;
                }

                toMove = toMove == 'b' ? 'w' : 'b';
            }
            return w[0] == 7 ? "white" : "black";
        }

        public static int[] amazonCheckmate(string king, string amazon)
        {
            var checkmate = 0;
            var check = 0;
            var safe = 0;
            var stalemate = 0;

            var badSquares = new List<int[]>();
            var kingSquares = new List<int[]>();
            var getLocation = new Func<string, int[]>(delegate (string f)
            {
                var c = -1;
                switch (f.ToCharArray()[0])
                {
                    case 'a':
                        c = 0;
                        break;
                    case 'b':
                        c = 1;
                        break;
                    case 'c':
                        c = 2;
                        break;
                    case 'd':
                        c = 3;
                        break;
                    case 'e':
                        c = 4;
                        break;
                    case 'f':
                        c = 5;
                        break;
                    case 'g':
                        c = 6;
                        break;
                    case 'h':
                        c = 7;
                        break;
                }

                return new[] { c, int.Parse(f.Substring(1, 1)) - 1 };
            });

            var getAmazonMoves = new Func<int[], int[], int[][]>(delegate (int[] a, int[] k)
            {
                var blackList = new List<int[]>();
                if (a[0] == k[0])
                {
                    if (a[1] > k[1])
                    {
                        for (var i = 0; i < k[1] + 1; i++)
                        {
                            blackList.Add(new[] { a[0], i });
                        }
                    }
                    else
                    {
                        for (var i = k[1] + 1; i < 8 + 1; i++)
                        {
                            blackList.Add(new[] { a[0], i });
                        }
                    }
                }
                else if (a[1] == k[1])
                {
                    if (a[0] > k[0])
                    {
                        for (var i = 0; i < k[0] + 1; i++)
                        {
                            blackList.Add(new[] { i, a[1] });
                        }
                    }
                    else
                    {
                        for (var i = k[0] + 1; i < 8 + 1; i++)
                        {
                            blackList.Add(new[] { i, a[1] });
                        }
                    }
                }
                else
                {
                    var hor = a[1] > k[1] ? -1 : 1;
                    var vert = a[0] > k[0] ? -1 : 1;
                    var metKing = false;
                    for (var i = 1; i < 8; i++)
                    {
                        if (a[0] + vert * i == k[0] && a[1] + hor * i == k[1])
                        {
                            metKing = true;
                            i++;
                            continue;
                        }

                        if (metKing)
                        {
                            if (a[0] + vert * i >= 0 && a[0] + vert * i < 8 && a[1] + hor * i >= 0 && a[1] + hor * i < 8)
                                blackList.Add(new[] { a[0] + vert * i, a[1] + hor * i });
                        }
                    }

                }
                var ret = new List<int[]>();
                for (var y = 0; y < 8; y++)
                {
                    for (var x = 0; x < 8; x++)
                    {
                        if (blackList.Any(b => b[0] == y && b[1] == x))
                            continue;
                        if (y == a[0] && x == a[1])
                            continue;
                        if (y >= a[0] - 2 && y <= a[0] + 2 && x >= a[1] - 2 && x <= a[1] + 2)
                            ret.Add(new[] { y, x });
                        else if (y == a[0] | x == a[1])
                            ret.Add(new[] { y, x });
                        else if (Math.Abs(y - a[0]) == Math.Abs(x - a[1]))
                            ret.Add(new[] { y, x });
                    }
                }

                return ret.ToArray();
            });

            var getKingSquares = new Func<int[], int[][]>(delegate (int[] a)
            {
                var ret = new List<int[]>();
                for (var y = Math.Max(a[0] - 1, 0); y < Math.Min(a[0] + 2, 8); y++)
                {
                    for (var x = Math.Max(a[1] - 1, 0); x < Math.Min(a[1] + 2, 8); x++)
                    {
                        if (y != a[0] | x != a[1])
                            ret.Add(new[] { y, x });
                    }
                }
                return ret.ToArray();
            });

            var kingA = getLocation(king);
            var amazonA = getLocation(amazon);
            kingSquares.AddRange(getKingSquares(kingA));
            badSquares.AddRange(getAmazonMoves(amazonA, kingA));

            for (var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 8; x++)
                {
                    var nearAmazon = false;
                    var nearKing = false;
                    var nearSafes = 0;
                    var nearChecks = 0;
                    var nearKings = 0;
                    var surroundingSquares = 0;

                    if ((kingA[0] == y && kingA[1] == (x))
                        | (amazonA[0] == (y) && amazonA[1] == (x)) |
                        (kingSquares.Any(a => a[0] == y && a[1] == x)))
                        continue;

                    var imSafe = !badSquares.Any(a => a[0] == (y) && a[1] == (x));

                    for (var yo = Math.Max(0, y - 1); yo < Math.Min(8, y + 2); yo++)
                    {
                        for (var xo = Math.Max(0, x - 1); xo < Math.Min(8, x + 2); xo++)
                        {

                            if (y == yo && x == xo)
                                continue;

                            var badSquare = badSquares.Any(a => a[0] == yo && a[1] == xo);
                            var kingSquare = kingSquares.Any(a => a[0] == yo && a[1] == xo);

                            if (badSquare)
                            {
                                nearChecks++;
                            }
                            else if (kingA[0] == yo && kingA[1] == xo & !badSquare)
                            {
                                nearSafes++;
                            }
                            else if (amazonA[0] == yo && amazonA[1] == xo & !kingSquare)
                            {
                                nearSafes++;
                            }
                            else if (!badSquare && !kingSquare)
                            {
                                nearSafes++;
                            }
                            else if (kingSquare)
                            {
                                nearKings++;
                            }
                            surroundingSquares++;

                        }
                    }
                    //tally
                    if (nearSafes > 0 && imSafe)
                        safe++;
                    else if (nearSafes > 0)
                        check++;
                    else if (nearSafes == 0 && imSafe)
                        stalemate++;
                    else if (surroundingSquares == (nearKings + nearChecks))
                        checkmate++;
                }
            }

            return new[] { checkmate, check, stalemate, safe };
        }


        public static int chessTriangle(int n, int m)
        {
            var area = n * m;
            var times = 0;

            var getPossibleKnightMoves = new Func<int[], int[][]>(delegate (int[] i)
            {
                var retVal = new List<int[]>();

                if (i[0] + 1 < n & i[1] + 2 < m)
                    retVal.Add(new[] { i[0] + 1, i[1] + 2 });
                if (i[0] + 2 < n & i[1] + 1 < m)
                    retVal.Add(new[] { i[0] + 2, i[1] + 1 });
                if (i[0] + 2 < n & i[1] - 1 >= 0)
                    retVal.Add(new[] { i[0] + 2, i[1] - 1 });
                if (i[0] + 1 < n & i[1] - 2 >= 0)
                    retVal.Add(new[] { i[0] + 1, i[1] - 2 });
                if (i[0] - 1 >= 0 & i[1] - 2 >= 0)
                    retVal.Add(new[] { i[0] - 1, i[1] - 2 });
                if (i[0] - 2 >= 0 & i[1] - 1 >= 0)
                    retVal.Add(new[] { i[0] - 2, i[1] - 1 });
                if (i[0] - 2 >= 0 & i[1] + 1 < m)
                    retVal.Add(new[] { i[0] - 2, i[1] + 1 });
                if (i[0] - 1 >= 0 & i[1] + 2 < m)
                    retVal.Add(new[] { i[0] - 1, i[1] + 2 });

                return retVal.ToArray();
            });

            var getPossibleRookPositions = new Func<int[], int[][]>(delegate (int[] i)
            {
                var retVal = new List<int[]>();
                for (var y = 0; y < n; y++)
                {
                    if (y != i[0])
                        retVal.Add(new[] { y, i[1] });
                }
                for (var x = 0; x < m; x++)
                {
                    if (x != i[1])
                        retVal.Add(new[] { i[0], x });
                }
                return retVal.ToArray();
            });

            var getPossibleBishopPositions = new Func<int[], int[][]>(delegate (int[] i)
            {
                var retVal = new List<int[]>();
                for (var x = 1; x < Math.Max(n, m); x++)
                {
                    if (i[0] - x >= 0 && i[1] - x >= 0)
                        retVal.Add(new[] { i[0] - x, i[1] - x });
                    if (i[0] - x >= 0 && i[1] + x < m)
                        retVal.Add(new[] { i[0] - x, i[1] + x });
                    if (i[0] + x < n && i[1] - x >= 0)
                        retVal.Add(new[] { i[0] + x, i[1] - x });
                    if (i[0] + x < n && i[1] + x < m)
                        retVal.Add(new[] { i[0] + x, i[1] + x });
                }
                return retVal.ToArray();
            });

            var canBishopKill = new Func<int[], int[], bool>((b, t) =>
            Math.Abs(b[0] - t[0]) == Math.Abs(b[1] - t[1]));

            var canRookKill = new Func<int[], int[], bool>((r, t) =>
            r[0] == t[0] | r[1] == t[1]);


            for (var x = 0; x < area; x++)
            {
                var kY = x / m;
                var kX = x % m;

                var knightMoves = getPossibleKnightMoves(new[] { kY, kX });


                foreach (var km in knightMoves)
                {
                    //find rook positions if bishop is in Knight kill spot.
                    var rookPositions = getPossibleRookPositions(new[] { kY, kX });
                    foreach (var rp in rookPositions)
                    {
                        if (canBishopKill(km, rp))
                            times++;
                    }

                    //find bishop positions if rook is in Knight kill spot.
                    var bishopPositions = getPossibleBishopPositions(new[] { kY, kX });
                    foreach (var bp in bishopPositions)
                    {
                        if (canRookKill(km, bp))
                            times++;
                    }

                }

            }

            return times;
        }


        public static int[] chessBishopDream(int[] boardSize, int[] initPosition, int[] initDirection, int k)
        {
            boardSize[0] -= 1;
            boardSize[1] -= 1;



            if (boardSize[0] + 1 == 1 && boardSize[1] + 1 == 1)
                return initPosition;

            var neededMoves = (boardSize[0] + 1) * (boardSize[1] + 1) * 2;
            k = k % neededMoves + neededMoves;

            var move = 0;
            while (move < k)
            {
                if (initPosition[0] < 0 | initPosition[0] > boardSize[0] | initPosition[1] < 0 | initPosition[1] > boardSize[1])
                {
                    if (initPosition[0] < 0)
                    {
                        initPosition[0] = 0;
                        //initPosition[1] += initDirection[1];
                        initDirection[0] *= -1;
                    }
                    else if (initPosition[0] > boardSize[0])
                    {
                        initPosition[0] = boardSize[0];
                        //initPosition[1] += initDirection[1];
                        initDirection[0] *= -1;
                    }
                    if (initPosition[1] < 0)
                    {
                        initPosition[1] = 0;
                        initDirection[1] *= -1;
                    }
                    else if (initPosition[1] > boardSize[1])
                    {
                        initPosition[1] = boardSize[1];
                        initDirection[1] *= -1;
                    }
                    move--;
                }
                else
                {
                    initPosition[0] += initDirection[0];
                    initPosition[1] += initDirection[1];
                }

                move++;
            }

            if (initPosition[0] < 0)
                initPosition[0] = 0;
            else if (initPosition[0] > boardSize[0])
                initPosition[0] = boardSize[0];
            if (initPosition[1] < 0)
                initPosition[1] = 0;
            else if (initPosition[1] > boardSize[1])
                initPosition[1] = boardSize[1];

            return initPosition;
        }

        public static bool whoseTurn(string p)
        {
            var splits = p.Split(';');


            var getColi = new Func<string, int[]>(delegate (string s)
            {
                var c = -1;
                switch (s.ToCharArray()[0])
                {
                    case 'a':
                        c = 1;
                        break;
                    case 'b':
                        c = 2;
                        break;
                    case 'c':
                        c = 3;
                        break;
                    case 'd':
                        c = 4;
                        break;
                    case 'e':
                        c = 5;
                        break;
                    case 'f':
                        c = 6;
                        break;
                    case 'g':
                        c = 7;
                        break;
                    case 'h':
                        c = 8;
                        break;
                }

                return new[] { c, int.Parse(s.Substring(1, 1)) };
            });
            var destinations = new[]
            {
            getColi(splits[0]),
            getColi(splits[1]),
            getColi(splits[2]),
            getColi(splits[3])
            };

            var parities = new[]
            {
                (destinations[0][0] + destinations[0][1]) % 2,
                (destinations[1][0] + destinations[1][1]) % 2,
                (destinations[2][0] + destinations[2][1]) % 2,
                (destinations[3][0] + destinations[3][1]) % 2
            };



            return parities.Sum(m => m) % 2 == 0;

        }


        public static string[] bishopDiagonal(string bishop1, string bishop2)
        {


            var getColi = new Func<string, int>(delegate (string s)
            {
                var c = -1;
                switch (s.ToCharArray()[0])
                {
                    case 'a':
                        c = 1;
                        break;
                    case 'b':
                        c = 2;
                        break;
                    case 'c':
                        c = 3;
                        break;
                    case 'd':
                        c = 4;
                        break;
                    case 'e':
                        c = 5;
                        break;
                    case 'f':
                        c = 6;
                        break;
                    case 'g':
                        c = 7;
                        break;
                    case 'h':
                        c = 8;
                        break;
                }

                return c;
            });

            var getCols = new Func<int, string>(delegate (int i)
            {
                var c = "z";
                switch (i)
                {
                    case 1:
                        c = "a";
                        break;
                    case 2:
                        c = "b";
                        break;
                    case 3:
                        c = "c";
                        break;
                    case 4:
                        c = "d";
                        break;
                    case 5:
                        c = "e";
                        break;
                    case 6:
                        c = "f";
                        break;
                    case 7:
                        c = "g";
                        break;
                    case 8:
                        c = "h";
                        break;
                }

                return c;
            });

            var b1 = new[] { getColi(bishop1), int.Parse(bishop1.Substring(1)) };
            var b2 = new[] { getColi(bishop2), int.Parse(bishop2.Substring(1)) };


            if (Math.Abs(b1[0] - b2[0]) != Math.Abs(b1[1] - b2[1]))
            {
                if (b1[0] <= b2[0] && b1[1] <= b2[0])
                    return new[] { bishop1, bishop2 };
                return new[] { bishop2, bishop1 };
            }

            var movingTopLeft = (b1[0] < b2[0] && b1[1] > b2[1]) | (b2[0] < b1[0] && b2[1] > b1[1]);

            if (b2[0] < b1[0])
            {
                var t = b1;
                b1 = b2;
                b2 = t;
            }

            while ((b1[0] != 1 & b1[0] != 8) &
                    (b1[1] != 1 & b1[1] != 8) |
                    (b2[0] != 1 & b2[0] != 8) &
                    (b2[1] != 1 & b2[1] != 8))
            {
                if (movingTopLeft)
                {
                    if (b1[0] != 1 && b1[1] != 8)
                    {
                        b1[0]--;
                        b1[1]++;
                    }
                    if (b2[0] != 8 && b2[1] != 1)
                    {
                        b2[0]++;
                        b2[1]--;
                    }
                }
                else
                {
                    if (b1[0] != 1 && b1[1] != 1)
                    {
                        b1[0]--;
                        b1[1]--;
                    }
                    if (b2[0] != 8 && b2[1] != 8)
                    {
                        b2[0]++;
                        b2[1]++;
                    }
                }

            }

            var b1S = getCols(b1[0]) + b1[1];
            var b2S = getCols(b2[0]) + b2[1];

            return new[] { b1S, b2S };

        }

        //chessKnightMoves in Intro/Level11

        //bishopAndPawn in Intro/Level9
    }
}
