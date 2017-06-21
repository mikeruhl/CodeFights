using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class SecretArchives
    {
        public static string[] lrc2subRip(string[] lrcLyrics, string songLength)
        {
            var output = new List<string>();

            for (var i = 0; i < lrcLyrics.Length; i++)
            {
                var min = lrcLyrics[i].Substring(lrcLyrics[i].IndexOf(":") - 2, 2);
                var sec = lrcLyrics[i].Substring(lrcLyrics[i].IndexOf(":") + 1, 2);
                var ms = lrcLyrics[i].Substring(lrcLyrics[i].IndexOf(":") + 4, 2).PadRight(3, '0');

                var hr = (int.Parse(min) / 60).ToString().PadLeft(2, '0');
                min = (int.Parse(min) % 60).ToString().PadLeft(2, '0');
                string nextMin, nextSec, nextMs, nextHr, msg;
                if (i != lrcLyrics.Length - 1)
                {
                    var idOf = lrcLyrics[i + 1].IndexOf(":");
                    nextMin = lrcLyrics[i + 1].Substring(idOf - 2, 2);
                    nextSec = lrcLyrics[i + 1].Substring(idOf + 1, 2);
                    nextMs = lrcLyrics[i + 1].Substring(idOf + 4, 2).PadRight(3, '0');

                    nextHr = (int.Parse(nextMin) / 60).ToString().PadLeft(2, '0');
                    nextMin = (int.Parse(nextMin) % 60).ToString().PadLeft(2, '0');
                }
                else
                {
                    var idOf = songLength.IndexOf(":");
                    nextHr = songLength.Substring(idOf - 2, 2);
                    nextMin = songLength.Substring(idOf + 1, 2);
                    nextSec = songLength.Substring(idOf + 4, 2);
                    nextMs = "000";
                }

                var startMsg = lrcLyrics[i].IndexOf("]") + 2;
                if (startMsg > lrcLyrics[i].Length)
                    msg = string.Empty;
                else
                    msg = lrcLyrics[i].Substring(lrcLyrics[i].IndexOf("]") + 2);

                output.Add((i + 1).ToString());
                output.Add(string.Format("{0}:{1}:{2},{3} --> {4}:{5}:{6},{7}", hr, min, sec, ms, nextHr, nextMin, nextSec, nextMs));
                output.Add(msg);
                if (i != lrcLyrics.Length - 1)
                    output.Add(string.Empty);
            }

            return output.ToArray();
        }
    }
}
