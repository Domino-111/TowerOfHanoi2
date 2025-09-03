using System;
using UnityEngine;

public class Solver
{
    static void Main(string[] args)
    {
        int n = 5;
        solveTower(n, '1', '2', '3');
    }

    static void solveTower(int n, char source, char target, char auxiliary)
    {
        if (n == 1)
        {
            Game.MoveTile();
            return;
        }
    }

    
}
