﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.Tests.Common;
using CodeFights.TheCore;
using NUnit.Framework;

namespace CodeFights.Tests.TheCore
{
    [TestFixture]
    public class SecretArchivesTests
    {

        #region SA01
        static List<ComplexTest<object[], string[]>> SA01 = new List<ComplexTest<object[], string[]>>
        {
            new ComplexTest<object[], string[]> //1
            {
                Input = new object[]
                {
                    new string[]
                    {
"[00:12.00] Happy birthday dear coder,",
 "[00:17.20] Happy birthday to you!"
                    },
                    "00:00:20"
                },
                ExpectedResult = new[] {"1",
 "00:00:12,000 --> 00:00:17,200",
 "Happy birthday dear coder,",
 "",
 "2",
 "00:00:17,200 --> 00:00:20,000",
 "Happy birthday to you!"}
            },
             new ComplexTest<object[], string[]> //2
            {
                Input = new object[]
                {
                    new string[]
                    {
"[00:04.42] jingle bells, jingle bells, jingle all the way!",
 "[00:08.46] Oh what fun it is to ride in a one horse open sleigh.",
 "[00:12.83] jingle bells, jingle bells, jingle all the way!",
 "[00:17.45] Oh what fun it is to ride in a one horse open sleigh.",
 "[00:21.89] jingle bells, jingle bells, jingle all the way!"
                    },
                    "00:24:00"
                },
                ExpectedResult = new[] {"1",
 "00:00:04,420 --> 00:00:08,460",
 "jingle bells, jingle bells, jingle all the way!",
 "",
 "2",
 "00:00:08,460 --> 00:00:12,830",
 "Oh what fun it is to ride in a one horse open sleigh.",
 "",
 "3",
 "00:00:12,830 --> 00:00:17,450",
 "jingle bells, jingle bells, jingle all the way!",
 "",
 "4",
 "00:00:17,450 --> 00:00:21,890",
 "Oh what fun it is to ride in a one horse open sleigh.",
 "",
 "5",
 "00:00:21,890 --> 00:24:00,000",
 "jingle bells, jingle bells, jingle all the way!"}
            },
              new ComplexTest<object[], string[]> //3
            {
                Input = new object[]
                {
                    new string[]
                    {
"[95:19.55] i hear babies cryin,",
 "[95:23.31] i watch them grow",
 "[95:26.05] theyll learn much more",
 "[95:29.18] than ill ever know",
 "[95:33.10] and i think to myself,",
 "[95:38.44] what a wonderful world"
                    },
                    "02:23:44"
                },
                ExpectedResult = new[] {"1",
 "01:35:19,550 --> 01:35:23,310",
 "i hear babies cryin,",
 "",
 "2",
 "01:35:23,310 --> 01:35:26,050",
 "i watch them grow",
 "",
 "3",
 "01:35:26,050 --> 01:35:29,180",
 "theyll learn much more",
 "",
 "4",
 "01:35:29,180 --> 01:35:33,100",
 "than ill ever know",
 "",
 "5",
 "01:35:33,100 --> 01:35:38,440",
 "and i think to myself,",
 "",
 "6",
 "01:35:38,440 --> 02:23:44,000",
 "what a wonderful world"}
            },
               new ComplexTest<object[], string[]> //4
            {
                Input = new object[]
                {
                    new string[]
                    {
"[12:24.80] make it the cutest",
 "[14:26.46] that ive ever seen",
 "[17:28.96] give hm the lips",
 "[21:30.36] like roses in clover",
 "[35:33.03] then tell him that",
 "[46:34.42] his lone some nights are over",
 "[57:36.68] Mr.sandman",
 "[67:38.71] i am so along",
 "[97:40.99] dont have nobody",
 "[99:42.63] to call my own"
                    },
                    "02:59:59"
                },
                ExpectedResult = new[] {"1",
 "00:12:24,800 --> 00:14:26,460",
 "make it the cutest",
 "",
 "2",
 "00:14:26,460 --> 00:17:28,960",
 "that ive ever seen",
 "",
 "3",
 "00:17:28,960 --> 00:21:30,360",
 "give hm the lips",
 "",
 "4",
 "00:21:30,360 --> 00:35:33,030",
 "like roses in clover",
 "",
 "5",
 "00:35:33,030 --> 00:46:34,420",
 "then tell him that",
 "",
 "6",
 "00:46:34,420 --> 00:57:36,680",
 "his lone some nights are over",
 "",
 "7",
 "00:57:36,680 --> 01:07:38,710",
 "Mr.sandman",
 "",
 "8",
 "01:07:38,710 --> 01:37:40,990",
 "i am so along",
 "",
 "9",
 "01:37:40,990 --> 01:39:42,630",
 "dont have nobody",
 "",
 "10",
 "01:39:42,630 --> 02:59:59,000",
 "to call my own"}
            },
                new ComplexTest<object[], string[]> //5
            {
                Input = new object[]
                {
                    new string[]
                    {
"[12:51.10] Hello tacher tell me whats my lesson",
 "[16:57.10] Look right through me,",
 "[24:00.36] look right through me",
 "[27:04.57] And I find it kind of funny",
 "[34:08.16] I find it kind of sad",
 "[46:10.42] The dream in which Im dying",
 "[57:13.70] Are the best Ive ever had",
 "[68:16.47] I find it hard to tell you",
 "[73:19.47] Cos I find it hard to take",
 "[86:22.56] When people run in circles",
 "[92:25.91] Its a very very"
                    },
                    "02:34:36"
                },
                ExpectedResult = new[] {"1",
 "00:12:51,100 --> 00:16:57,100",
 "Hello tacher tell me whats my lesson",
 "",
 "2",
 "00:16:57,100 --> 00:24:00,360",
 "Look right through me,",
 "",
 "3",
 "00:24:00,360 --> 00:27:04,570",
 "look right through me",
 "",
 "4",
 "00:27:04,570 --> 00:34:08,160",
 "And I find it kind of funny",
 "",
 "5",
 "00:34:08,160 --> 00:46:10,420",
 "I find it kind of sad",
 "",
 "6",
 "00:46:10,420 --> 00:57:13,700",
 "The dream in which Im dying",
 "",
 "7",
 "00:57:13,700 --> 01:08:16,470",
 "Are the best Ive ever had",
 "",
 "8",
 "01:08:16,470 --> 01:13:19,470",
 "I find it hard to tell you",
 "",
 "9",
 "01:13:19,470 --> 01:26:22,560",
 "Cos I find it hard to take",
 "",
 "10",
 "01:26:22,560 --> 01:32:25,910",
 "When people run in circles",
 "",
 "11",
 "01:32:25,910 --> 02:34:36,000",
 "Its a very very"}
            },
                 new ComplexTest<object[], string[]> //6
            {
                Input = new object[]
                {
                    new string[]
                    {
"[00:09.01]",
 "[00:10.01] Sweet dreams are made of this",
 "[00:13.26] Who am I to disagree?",
 "[00:17.01] Travel the world and the seven seas",
 "[00:20.95] Everybodys looking for something",
 "[00:24.57]",
 "[00:24.82] Some of them want to use you",
 "[00:28.64] Some of them want to get used by you",
 "[00:32.45] Some of them want to abuse you",
 "[00:36.32] Some of them want to be abused",
 "[00:40.32]",
 "[00:52.00] Sweet dreams are made of this",
 "[00:55.37] Who am I to disagree?",
 "[00:59.18] Travel the world and the seven seas",
 "[01:03.00] Everybodys looking for something",
 "[01:48.34] Some of them want to use you",
 "[01:52.16] Some of them want to get used by you",
 "[01:55.97] Some of them want to abuse you",
 "[01:59.72] Some of them want to be abused",
 "[02:03.58]",
 "[01:18.17]",
 "[01:29.17] Hold your head up, movin on",
 "[01:19.18] Hold your head up",
 "[01:31.11] Keep your head up",
 "[01:19.92] Keep your head up, movin on",
 "[01:21.86] Hold your head up, movin on",
 "[01:23.74] Keep your head up, movin on",
 "[01:25.67] Hold your head up, movin on",
 "[01:27.55] Keep your head up, movin on"
                    },
                    "00:09:32"
                },
                ExpectedResult = new[] {"1",
 "00:00:09,010 --> 00:00:10,010",
 "",
 "",
 "2",
 "00:00:10,010 --> 00:00:13,260",
 "Sweet dreams are made of this",
 "",
 "3",
 "00:00:13,260 --> 00:00:17,010",
 "Who am I to disagree?",
 "",
 "4",
 "00:00:17,010 --> 00:00:20,950",
 "Travel the world and the seven seas",
 "",
 "5",
 "00:00:20,950 --> 00:00:24,570",
 "Everybodys looking for something",
 "",
 "6",
 "00:00:24,570 --> 00:00:24,820",
 "",
 "",
 "7",
 "00:00:24,820 --> 00:00:28,640",
 "Some of them want to use you",
 "",
 "8",
 "00:00:28,640 --> 00:00:32,450",
 "Some of them want to get used by you",
 "",
 "9",
 "00:00:32,450 --> 00:00:36,320",
 "Some of them want to abuse you",
 "",
 "10",
 "00:00:36,320 --> 00:00:40,320",
 "Some of them want to be abused",
 "",
 "11",
 "00:00:40,320 --> 00:00:52,000",
 "",
 "",
 "12",
 "00:00:52,000 --> 00:00:55,370",
 "Sweet dreams are made of this",
 "",
 "13",
 "00:00:55,370 --> 00:00:59,180",
 "Who am I to disagree?",
 "",
 "14",
 "00:00:59,180 --> 00:01:03,000",
 "Travel the world and the seven seas",
 "",
 "15",
 "00:01:03,000 --> 00:01:48,340",
 "Everybodys looking for something",
 "",
 "16",
 "00:01:48,340 --> 00:01:52,160",
 "Some of them want to use you",
 "",
 "17",
 "00:01:52,160 --> 00:01:55,970",
 "Some of them want to get used by you",
 "",
 "18",
 "00:01:55,970 --> 00:01:59,720",
 "Some of them want to abuse you",
 "",
 "19",
 "00:01:59,720 --> 00:02:03,580",
 "Some of them want to be abused",
 "",
 "20",
 "00:02:03,580 --> 00:01:18,170",
 "",
 "",
 "21",
 "00:01:18,170 --> 00:01:29,170",
 "",
 "",
 "22",
 "00:01:29,170 --> 00:01:19,180",
 "Hold your head up, movin on",
 "",
 "23",
 "00:01:19,180 --> 00:01:31,110",
 "Hold your head up",
 "",
 "24",
 "00:01:31,110 --> 00:01:19,920",
 "Keep your head up",
 "",
 "25",
 "00:01:19,920 --> 00:01:21,860",
 "Keep your head up, movin on",
 "",
 "26",
 "00:01:21,860 --> 00:01:23,740",
 "Hold your head up, movin on",
 "",
 "27",
 "00:01:23,740 --> 00:01:25,670",
 "Keep your head up, movin on",
 "",
 "28",
 "00:01:25,670 --> 00:01:27,550",
 "Hold your head up, movin on",
 "",
 "29",
 "00:01:27,550 --> 00:09:32,000",
 "Keep your head up, movin on"}
            }
        };
        #endregion

        [TestCaseSource("SA01")]
        public void Testlrc2subRip(ComplexTest<object[], string[]> test)
        {
            Assert.AreEqual(test.ExpectedResult, SecretArchives.lrc2subRip((string[])test.Input[0], (string)test.Input[1]);
        }

    }
}
