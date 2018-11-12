using System;
using System.Collections.Generic;
using System.Linq;

class TowersOfHanoi
{
    static void Main(string[] args)
    {
        var pegs = new Pegs(discs: 4);

        pegs.Answer();

        Console.ReadKey();
    }

    private static void Move(
        int discs,
        Stack<int> fromPeg,
        Stack<int> toPeg,
        Stack<int> otherPeg)
    {
        if (discs == 1)
        {
            toPeg.Push(fromPeg.Pop());
            return;
        }

        Move(discs - 1, fromPeg, otherPeg, toPeg);

        toPeg.Push(fromPeg.Pop());

        Move(discs - 1, otherPeg, toPeg, fromPeg);
    }

    class Pegs
    {
        private int TotalDiscs { get; set; } = 0;
        private Stack<int> FirstPeg { get; set; } = new Stack<int>();
        private Stack<int> SecondPeg { get; set; } = new Stack<int>();
        private Stack<int> ThirdPeg { get; set; } = new Stack<int>();

        public Pegs(int discs = 3)
        {
            TotalDiscs = discs;

            //Create list of items (discs)
            var discList = Enumerable.Range(1, TotalDiscs).Reverse();

            //Add items (discs) to first peg
            foreach (var disc in discList)
            {
                FirstPeg.Push(disc);
            }
        }

        public void Answer()
        {
            if (ThirdPeg.Count != TotalDiscs)
            {
                PrintPegs();

                //Move first item from firstpeg to secondpeg
                if (FirstPeg.Any())
                {
                    var fp_f = FirstPeg.Pop();
                    SecondPeg.Push(fp_f);
                }

                PrintPegs();

                //Move second item from firstpeg to thirdpeg
                if (FirstPeg.Any())
                {
                    var fp_s = FirstPeg.Pop();
                    ThirdPeg.Push(fp_s);
                }

                PrintPegs();

                //Move first item from secondpeg to thirdpeg
                if (SecondPeg.Any())
                {
                    var sp_f = SecondPeg.Pop();
                    ThirdPeg.Push(sp_f);
                }

                PrintPegs();

                Answer();
            }
        }

        private void PrintPegs()
        {
            var fp = FirstPeg.Select(x => x.ToString()).ToList();

            if (fp.Count < TotalDiscs)
            {
                fp.AddRange(Enumerable.Repeat(string.Empty, (TotalDiscs - fp.Count)));
            }

            var sp = SecondPeg.Select(x => x.ToString()).ToList();

            if (sp.Count < TotalDiscs)
            {
                sp.AddRange(Enumerable.Repeat(string.Empty, (TotalDiscs - sp.Count)));
            }

            var tp = ThirdPeg.Select(x => x.ToString()).ToList();

            if (tp.Count < TotalDiscs)
            {
                tp.AddRange(Enumerable.Repeat(string.Empty, (TotalDiscs - tp.Count)));
            }

            Console.WriteLine($"{"[First Peg]",10}" + $"{"[Second Peg]",10}" + $"{"[Third Peg]",10}");

            for (var i = 0; i < TotalDiscs; i++)
            {
                Console.WriteLine($"{fp[i],10}" +
                                  $"{sp[i],10}" +
                                  $"{tp[i],10}");
            }
        }
    }
}